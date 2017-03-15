Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class OptionsCtrl

  Public Overrides Sub LoadData(ByVal config As String)
    If config Is Nothing Then Exit Sub 'new instance
    Dim tmp = PipeDecode(config)
    If tmp.Length > 0 Then txtConn.Text = tmp(0)
    If tmp.Length > 1 Then txtSelect.Text = tmp(1)
  End Sub

  Public Overrides Function SaveData() As String
    Return PipeEncode(txtConn.Text.Trim) & "|" & PipeEncode(txtSelect.Text.Trim)
  End Function

  Public Overrides Function ValidateData() As Boolean
    If txtConn.Text.Trim.Length = 0 Then
      MessageBox.Show("Database connection string is empty", "Plug-In settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return False
    End If
    If txtSelect.Text.Trim.Length = 0 Then
      MessageBox.Show("SELECT statement is empty", "Plug-In settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return False
    End If
    Return True
  End Function

  Private Sub btnBuildConn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuildConn.Click
    Dim frm As New frmBuildDBConn
    If txtConn.Text.Trim.Length > 0 Then frm.LoadData(txtConn.Text.Trim)
    If frm.ShowDialog() <> Windows.Forms.DialogResult.OK Then Exit Sub
    txtConn.Text = frm.ConnStr
  End Sub

  Private Sub btnTestConn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestConn.Click
    Dim conn = OpenDBConn("Test database connection string")
    If conn Is Nothing Then Exit Sub
    conn.Close()
    MessageBox.Show("Connected succesfully!", "Test database connection string ", MessageBoxButtons.OK, MessageBoxIcon.Information)
  End Sub

  Function OpenDBConn(ByVal title As String) As SqlConnection
    If txtConn.Text.Trim.Length = 0 Then Return Nothing
    Try
      Dim conn As New SqlConnection(txtConn.Text)
      conn.Open()
      Return conn
    Catch ex As Exception
      MessageBox.Show("Could not connect to database!" & vbCrLf & vbCrLf & _
                      ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Return Nothing
    End Try
  End Function

  Private Sub btnTestSel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestSelect.Click
    If txtConn.Text.Trim.Length = 0 Then
      MessageBox.Show("Database connection string is empty", "Test SELECT statement", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Exit Sub
    End If
    Dim sql As String= txtSelect.Text.Trim
    If sql.Length = 0 Then
      MessageBox.Show("SELECT statement is empty", "Test SELECT statement", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Exit Sub
    End If

    Dim frm As New frmTestSelect
    Dim ParamNames = New String() {"@QNAME", "@QTYPE", "@QIP"}
    Dim ParamTextBox = New TextBox() {frm.txtQName, frm.txtQType, frm.txtQIP}
    Dim AnyParams = False
    For i = 0 To 2
      If sql.IndexOf(ParamNames(i), StringComparison.InvariantCultureIgnoreCase) >= 0 Then
        ParamTextBox(i).Enabled = True
        AnyParams = True
      Else
        ParamTextBox(i).Enabled = False
      End If
    Next
    If AnyParams Then
      If frm.ShowDialog = DialogResult.Cancel Then Exit Sub
    End If

    Dim dbConn = OpenDBConn("Test SELECT statement")
    If dbConn Is Nothing Then Exit Sub
    Dim cmd As SqlCommand
    Try
      cmd = New SqlCommand(sql, dbConn)
    Catch ex As Exception
      dbConn.Close()
      MessageBox.Show("Error instantiating SQL command" & vbCrLf & vbCrLf & _
                      ex.Message, "Test SELECT statement", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Exit Sub
    End Try

    For i = 0 To 2
      If ParamTextBox(i).Enabled Then
        Try
          cmd.Parameters.AddWithValue(ParamNames(i), ParamTextBox(i).Text.Replace(" "c, ""))
        Catch ex As Exception
          dbConn.Close()
          MessageBox.Show("Error adding " & ParamNames(i) & " parameter to SQL command" & vbCrLf & vbCrLf & _
                          ex.Message, "Test SELECT statement", MessageBoxButtons.OK, MessageBoxIcon.Error)
          Exit Sub
        End Try
      End If
    Next

    Dim da As New SqlClient.SqlDataAdapter(cmd)
    Dim dt As New DataTable
    Try
      da.Fill(dt)
    Catch ex As Exception
      dbConn.Close()
      MessageBox.Show("Error executing SELECT statement:" & vbCrLf & vbCrLf & _
                      ex.Message, "Test SELECT statement", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Exit Sub
    End Try
    dbConn.Close()

    If dt.Rows.Count = 0 Then
      MessageBox.Show("Error: SQL executed succesfully, but no data was returned", "Test SELECT statement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
      Exit Sub
    End If

    If dt.Rows.Count > 50 Then
      MessageBox.Show("Error: More than 50 rows were returned", "Test SELECT statement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
      Exit Sub
    End If

    Dim ColNames = New String() {"recdata", "recname", "rectype", "recttl", "recsec"}
    Dim ColPos(4) As Integer
    For i = 0 To 4
      ColPos(i) = dt.Columns.IndexOf(ColNames(i))
    Next

    If ColPos(0) < 0 Then
      MessageBox.Show("Error: SELECT statement did not return the required ""RecData"" column", "Test SELECT statement", MessageBoxButtons.OK, MessageBoxIcon.Error)
      Exit Sub
    End If

    Dim frmR = New frmTestRes
    Dim rv = New String() {"<default>", "<default>", "<default>", "<default>", "<default>"}
    Dim rowCt = 0
    For Each row As Data.DataRow In dt.Rows
      rowCt += 1
      For i = 0 To 4
        If ColPos(i) < 0 Then Continue For
        If row(ColPos(i)) Is DBNull.Value Then
          If i > 0 Then rv(i) = "<null>" : Continue For
          MessageBox.Show("Error: ""RecData"" column in row " & rowCt & " is NULL", "Test SELECT statement", MessageBoxButtons.OK, MessageBoxIcon.Error)
          Exit Sub
        End If
        Try
          If i < 3 Then
            rv(i) = CStr(row(ColPos(i)))
          Else
            rv(i) = CInt(row(ColPos(i))).ToString
          End If
        Catch ex As Exception
          MessageBox.Show("Error: Incorrect data type in """ & ColNames(i) & """ column in row " & rowCt, "Test SELECT statement", MessageBoxButtons.OK, MessageBoxIcon.Error)
          Exit Sub
        End Try
        Select Case i
          Case 0, 1, 2
            If CStr(row(ColPos(i))).Length = 0 Then
              MessageBox.Show("Error: Empty string returned in """ & ColNames(i) & """ column in row " & rowCt, "Test SELECT statement", MessageBoxButtons.OK, MessageBoxIcon.Error)
              Exit Sub
            End If
          Case 3
            If CInt(row(ColPos(i))) < 0 Then
              MessageBox.Show("Error: Negative value returned in """ & ColNames(i) & """ column in row " & rowCt, "Test SELECT statement", MessageBoxButtons.OK, MessageBoxIcon.Error)
              Exit Sub
            End If
          Case 4
            If CInt(row(ColPos(i))) < 1 Or CInt(row(ColPos(i))) > 3 Then
              MessageBox.Show("Error: Invalid value returned in """ & ColNames(i) & """ column in row " & rowCt, "Test SELECT statement", MessageBoxButtons.OK, MessageBoxIcon.Error)
              Exit Sub
            End If
        End Select
      Next
      frmR.dgv.Rows.Add(rv)
    Next
    frmR.ShowDialog()

  End Sub


End Class

