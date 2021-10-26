Imports JHSoftware.SimpleDNS.Plugin
Imports System.Data.SqlClient

Public Class MsSqlPlusPlugIn
  Implements ILookupAnswer
  Implements IOptionsUI

  Friend dbConnStr As String
  Friend SelectStr As String
  Private HasParam(2) As Boolean
  Private ParamNames() As String = {"@QNAME", "@QTYPE", "@QIP"}

  Public Property Host As IHost Implements IPlugInBase.Host

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

  Public Function StartService() As Threading.Tasks.Task Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.StartService
    Return Threading.Tasks.Task.CompletedTask
  End Function

  Public Sub StopService() Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.StopService
  End Sub

#End Region

  Public Function GetPlugInTypeInfo() As JHSoftware.SimpleDNS.Plugin.IPlugInBase.PlugInTypeInfo Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.GetTypeInfo
    With GetPlugInTypeInfo
      .Name = "MS SQL Server Plus"
      .Description = "Fetches DNS records from a Microsoft SQL server"
      .InfoURL = "https://simpledns.plus/plugin-mssqlplus"
    End With
  End Function

  Public Async Function LookupAnswer(ByVal req As IRequestContext) As Threading.Tasks.Task(Of JHSoftware.SimpleDNS.Plugin.DNSAnswer) Implements JHSoftware.SimpleDNS.Plugin.ILookupAnswer.LookupAnswer
    Using dbConn = New SqlConnection(dbConnStr)
      Await dbConn.OpenAsync()

      Dim cmd = dbConn.CreateCommand()
      cmd.CommandText = SelectStr
      If HasParam(0) Then cmd.Parameters.AddWithValue(ParamNames(0), req.QName.ToString)
      If HasParam(1) Then cmd.Parameters.AddWithValue(ParamNames(1), req.QType.ToString)
      If HasParam(2) Then cmd.Parameters.AddWithValue(ParamNames(2), req.FromIP.ToString)
      Dim rdr = Await cmd.ExecuteReaderAsync()

      Dim ans = New DNSAnswer
      Dim rec As DNSRecord
      Dim rowCt = 0
      Dim HasRecData, HasRecName, HasRecType, HasRecTTL, HasRecSec As Boolean
      Dim sec As Integer

      While Await rdr.ReadAsync()
        If rowCt = 0 Then
          For i = 0 To rdr.FieldCount - 1
            Select Case rdr.GetName(i).ToLower
              Case "recdata"
                HasRecData = True
              Case "recname"
                HasRecName = True
              Case "rectype"
                HasRecType = True
              Case "recttl"
                HasRecType = True
              Case "recsec"
                HasRecSec = True
            End Select
          Next
          If Not HasRecData Then Throw New Exception("No ""RecData"" column returned by SQL server")
        End If

        rowCt += 1
        If rowCt > 50 Then Exit While

        rec = New DNSRecord With {
          .Name = If(HasRecName, DomName.Parse(CStr(rdr("recname"))), req.QName),
          .RRType = If(HasRecType, ParseDNSRecType(CStr(rdr("rectype"))), req.QType),
          .Data = CStr(rdr("recdata")),
          .TTL = If(HasRecTTL, CInt(rdr("recttl")), 300)
        }

        If Not HasRecSec Then
          ans.Answer.Add(rec)
        Else
          sec = CInt(rdr("recsec"))
          Select Case sec
            Case 1
              ans.Answer.Add(rec)
            Case 2
              ans.Authority.Add(rec)
            Case 3
              ans.Additional.Add(rec)
            Case Else
              Throw New Exception("Invalid answer section returned by SQL server: " & sec)
          End Select
        End If

      End While
      If rowCt = 0 Then Return Nothing

      Return ans
    End Using
  End Function

  Public Sub LoadConfig(ByVal config As String, ByVal instanceID As Guid, ByVal dataPath As String) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.LoadConfig
    Dim tmp = PipeDecode(config)
    If tmp.Length > 0 Then dbConnStr = tmp(0)
    If tmp.Length > 1 Then SelectStr = tmp(1)
    For i = 0 To 2
      HasParam(i) = (SelectStr.IndexOf(ParamNames(i), StringComparison.InvariantCultureIgnoreCase) >= 0)
    Next
  End Sub

  Public Function GetOptionsUI(ByVal instanceID As Guid, ByVal dataPath As String) As JHSoftware.SimpleDNS.Plugin.OptionsUI Implements JHSoftware.SimpleDNS.Plugin.IOptionsUI.GetOptionsUI
    Return New OptionsCtrl
  End Function

End Class
