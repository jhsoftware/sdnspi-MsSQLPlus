Imports JHSoftware.SimpleDNS.Plugin
Imports System.Data.SqlClient

Public Class MsSqlPlusPlugIn
  Implements IGetAnswerPlugIn

  Friend dbConnStr As String
  Friend SelectStr As String
  Private HasParam(2) As Boolean
  Private ParamNames() As String = {"@QNAME", "@QTYPE", "@QIP"}
  Private ColNames() As String = {"recdata", "recname", "rectype", "recttl", "recsec"}

  REM removed to try connection pooling
  'Friend dbConn As SqlConnection
  'Private LastConnectAttempt As DateTime

#Region "events"
  Public Event LogLine(ByVal text As String) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.LogLine
  Public Event AsyncError(ByVal ex As System.Exception) Implements JHSoftware.SimpleDNS.Plugin.IGetAnswerPlugIn.AsyncError
  Public Event SaveConfig(ByVal config As String) Implements JHSoftware.SimpleDNS.Plugin.IGetAnswerPlugIn.SaveConfig
#End Region

#Region "not implemented"
  Public Function SaveState() As String Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.SaveState
    Return ""
  End Function

  Public Sub LoadState(ByVal state As String) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.LoadState
    REM nothing
  End Sub

  Public Function InstanceConflict(ByVal config1 As String, ByVal config2 As String, ByRef errorMsg As String) As Boolean Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.InstanceConflict
    Return False
  End Function

  Public Function GetDNSAskAbout() As JHSoftware.SimpleDNS.Plugin.DNSAskAbout Implements JHSoftware.SimpleDNS.Plugin.IGetAnswerPlugIn.GetDNSAskAbout
  End Function

#End Region

#Region "other methods"

  Public Function GetPlugInTypeInfo() As JHSoftware.SimpleDNS.Plugin.IPlugInBase.PlugInTypeInfo Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.GetPlugInTypeInfo
    With GetPlugInTypeInfo
      .Name = "MS SQL Server Plus"
      .Description = "Fetches DNS records from a Microsoft SQL server"
      .InfoURL = "http://www.simpledns.com/kb.aspx?kbid=1249"
      .ConfigFile = False
      .MultiThreaded = True
    End With
  End Function

  Public Function Lookup(ByVal req As IDNSRequest) As JHSoftware.SimpleDNS.Plugin.DNSAnswer Implements JHSoftware.SimpleDNS.Plugin.IGetAnswerPlugIn.Lookup
    Dim dt As New DataTable

    Using dbConn = New SqlConnection(dbConnStr)
      dbConn.Open()

      Dim cmd = dbConn.CreateCommand()
      cmd.CommandText = SelectStr
      If HasParam(0) Then cmd.Parameters.AddWithValue(ParamNames(0), req.QName.ToString)
      If HasParam(1) Then cmd.Parameters.AddWithValue(ParamNames(1), req.QType.ToString)
      If HasParam(2) Then cmd.Parameters.AddWithValue(ParamNames(2), req.FromIP.ToString)
      Dim da As New SqlClient.SqlDataAdapter(cmd)

      'mark1:
      '      Try
      da.Fill(dt)
      'Catch ex As Exception
      'If DateTime.UtcNow.Subtract(LastConnectAttempt).TotalSeconds < 15 OrElse _
      '   dbConn.State <> ConnectionState.Closed Then Throw ex
      'RaiseEvent LogLine("Database connection closed - attempting to re-connect...")
      'LastConnectAttempt = DateTime.UtcNow
      'dbConn.Open()
      'GoTo mark1
      'End Try

    End Using


    If dt.Rows.Count = 0 Then Return Nothing

    Dim ColPos(4) As Integer
    For i = 0 To 4
      ColPos(i) = dt.Columns.IndexOf(ColNames(i))
    Next

    If ColPos(0) < 0 Then Throw New Exception("No ""RecData"" column returned by SQL server")

    Dim ans = New DNSAnswer
    Dim rec As DNSRecord
    Dim rowCt = 0
    For Each row As Data.DataRow In dt.Rows
      rowCt += 1
      If rowCt > 50 Then Exit For
      rec = New DNSRecord

      rec.Data = CStr(row(ColPos(0)))

      If ColPos(1) < 0 Then
        rec.Name = req.QName
      Else
        rec.Name = DomainName.Parse(CStr(row(ColPos(1))))
      End If

      If ColPos(2) < 0 Then
        rec.RRType = req.QType
      Else
        rec.RRType = DNSRRType.Parse(CStr(row(ColPos(2))))
      End If

      If ColPos(3) < 0 Then
        rec.TTL = 300
      Else
        rec.TTL = CInt(row(ColPos(3)))
      End If

      If ColPos(4) < 0 Then
        rec.AnswerSection = DNSAnswerSection.Answer
      Else
        rec.AnswerSection = CType(CInt(row(ColPos(4))), DNSAnswerSection)
      End If

      ans.Records.Add(rec)
    Next

    Return ans
  End Function

  Public Sub LoadConfig(ByVal config As String, ByVal instanceID As Guid, ByVal dataPath As String, ByRef maxThreads As Integer) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.LoadConfig
    Dim tmp = PipeDecode(config)
    If tmp.Length > 0 Then dbConnStr = tmp(0)
    If tmp.Length > 1 Then SelectStr = tmp(1)
    For i = 0 To 2
      HasParam(i) = (SelectStr.IndexOf(ParamNames(i), StringComparison.InvariantCultureIgnoreCase) >= 0)
    Next
  End Sub

  Public Sub StartService() Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.StartService
    REM removed to try connection pooling
    'dbConn = New SqlConnection(dbConnStr)
    'LastConnectAttempt = DateTime.UtcNow
    'dbConn.Open()
  End Sub

  Public Sub StopService() Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.StopService
    'If dbConn IsNot Nothing Then dbConn.Close() : dbConn = Nothing
  End Sub

  Public Function GetOptionsUI(ByVal instanceID As Guid, ByVal dataPath As String) As JHSoftware.SimpleDNS.Plugin.OptionsUI Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.GetOptionsUI
    Return New OptionsCtrl
  End Function

#End Region


End Class
