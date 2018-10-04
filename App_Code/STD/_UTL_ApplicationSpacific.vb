Imports System.Data.SqlClient
Imports System.Data
Imports System.Web
Imports Microsoft.VisualBasic
Imports System
Namespace SIS.SYS.Utilities
  Public Class ApplicationSpacific
    Public Shared ReadOnly Property NextLinkNo As Integer
      Get
        Dim mRet As Integer = 0
        Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
          Con.Open()
          Using Cmd As SqlCommand = Con.CreateCommand()
            Cmd.CommandType = CommandType.Text
            Cmd.CommandText = "Select top 1 LinkSrNo from QCM_LogSrNo"
            mRet = Cmd.ExecuteScalar()
          End Using
          mRet = mRet + 1
          Using Cmd As SqlCommand = Con.CreateCommand()
            Cmd.CommandType = CommandType.Text
            Cmd.CommandText = "Update QCM_LogSrNo set LinkSrNo =" & mRet
            Cmd.ExecuteNonQuery()
          End Using
        End Using
        Return mRet
      End Get
    End Property
    Public Shared ReadOnly Property NextMailNo As Integer
      Get
        Dim mRet As Integer = 0
        Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
          Con.Open()
          Using Cmd As SqlCommand = Con.CreateCommand()
            Cmd.CommandType = CommandType.Text
            Cmd.CommandText = "Select top 1 MailSrNo from QCM_LogSrNo"
            mRet = Cmd.ExecuteScalar()
          End Using
          mRet = mRet + 1
          Using Cmd As SqlCommand = Con.CreateCommand()
            Cmd.CommandType = CommandType.Text
            Cmd.CommandText = "Update QCM_LogSrNo set MailSrNo =" & mRet
            Cmd.ExecuteNonQuery()
          End Using
        End Using
        Return mRet
      End Get
    End Property
    Public Shared ReadOnly Property IsTesting As Boolean
      Get
        Return Convert.ToBoolean(ConfigurationManager.AppSettings("Testing"))
      End Get
    End Property
    Public Shared Sub Initialize()
      With HttpContext.Current
        .Session("ApplicationID") = 19
        .Session("ApplicationDefaultPage") = "~/Default.aspx"
      End With
    End Sub
    Public Shared Sub ApplicationReports(ByVal Context As HttpContext)
      If Not Context.Request.QueryString("ReportName") Is Nothing Then
        Select Case (Context.Request.QueryString("ReportName").ToLower)
          Case "customertransmittal"
            'Dim oRep As RPT_idmCT = New RPT_idmCT(Context)
            'oRep.GenerateReport()
            '	Case "pendingdocument"
            '		Dim oRep As RPT_dcmPendingDocument = New RPT_dcmPendingDocument(Context)
            '		oRep.GenerateReport()
            '	Case "sentdocument"
            '		Dim oRep As RPT_dcmSentDocument = New RPT_dcmSentDocument(Context)
            '		oRep.GenerateReport()
        End Select
      End If
    End Sub
    Public Shared Function ContentType(ByVal FileName As String) As String
      Dim mRet As String = "application/octet-stream"
      Dim Extn As String = IO.Path.GetExtension(FileName).ToLower.Replace(".", "")
      Select Case Extn
        Case "pdf", "rtf"
          mRet = "application/" & Extn
        Case "doc", "docx"
          mRet = "application/vnd.ms-works"
        Case "xls", "xlsx"
          mRet = "application/vnd.ms-excel"
        Case "gif", "jpg", "jpeg", "png", "tif", "bmp"
          mRet = "image/" & Extn
        Case "pot", "ppt", "pps", "pptx", "ppsx"
          mRet = "application/vnd.ms-powerpoint"
        Case "htm", "html"
          mRet = "text/HTML"
        Case "txt"
          mRet = "text/plain"
        Case "zip"
          mRet = "application/zip"
        Case "rar", "tar", "tgz"
          mRet = "application/x-compressed"
        Case Else
          mRet = "application/octet-stream"
      End Select
      Return mRet
    End Function
  End Class
End Namespace