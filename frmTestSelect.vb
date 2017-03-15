Imports System.Windows.Forms

Public Class frmTestSelect

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
    If txtQName.Enabled And txtQName.Text.Replace(" "c, "").Length = 0 Then
      MessageBox.Show("@QNAME parameter is empty", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Exit Sub
    End If
    If txtQType.Enabled And txtQType.Text.Replace(" "c, "").Length = 0 Then
      MessageBox.Show("@QTYPE parameter is empty", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Exit Sub
    End If
    If txtQIP.Enabled And txtQIP.Text.Replace(" "c, "").Length = 0 Then
      MessageBox.Show("@QIP parameter is empty", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
      Exit Sub
    End If

    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.Close()
  End Sub

  Private Sub txtQName_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQName.LostFocus
    txtQName.Text = txtQName.Text.Replace(" "c, "")
  End Sub

  Private Sub txtQType_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtQType.LostFocus
    txtQType.Text = txtQType.Text.Replace(" "c, "")
  End Sub

  Private Sub txtQIP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQIP.TextChanged
    txtQIP.Text = txtQIP.Text.Replace(" "c, "")
  End Sub
End Class
