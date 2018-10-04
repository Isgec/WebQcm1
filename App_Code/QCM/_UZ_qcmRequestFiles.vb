Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.QCM
  Partial Public Class qcmRequestFiles
    Public ReadOnly Property GetDownloadLink() As String
      Get
        Return "javascript:window.open('" & HttpContext.Current.Request.Url.Scheme & Uri.SchemeDelimiter & HttpContext.Current.Request.Url.Authority & HttpContext.Current.Request.ApplicationPath & "/QCM_Main/App_Downloads/filedownload.aspx?reqfil=" & PrimaryKey & "', 'win" & SerialNo & "', 'left=20,top=20,width=100,height=100,toolbar=1,resizable=1,scrollbars=1'); return false;"
      End Get
    End Property
    Public Function GetColor() As System.Drawing.Color
      Dim mRet As System.Drawing.Color = Drawing.Color.Blue
      Return mRet
    End Function
    Public Function GetVisible() As Boolean
			Dim mRet As Boolean = True
			Return mRet
		End Function
		Public Function GetEnable() As Boolean
			Dim mRet As Boolean = True
			Return mRet
		End Function
		Public ReadOnly Property ContentType() As String
			Get
				Dim mRet As String = "application/octet-stream"
				Dim Extn As String = IO.Path.GetExtension(_FileName).ToLower.Replace(".", "")
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
				End Select
				Return mRet
			End Get
		End Property
		Public Shared Function GetRequestFilesSelectListinXML(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal RequestID As Int32) As String
			Dim Results As String = ""
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "spqcm_LG_RequestFilesSelectListFilteresinXML"
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_RequestID", SqlDbType.Int, 10, IIf(RequestID = Nothing, 0, RequestID))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
					Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
					Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
					_RecordCount = -1
					Con.Open()
					Dim rXML As Xml.XmlReader = Cmd.ExecuteXmlReader
					rXML.Read()
					Do While rXML.ReadState <> Xml.ReadState.EndOfFile
						Results &= rXML.ReadOuterXml()
					Loop
					rXML.Close()
					_RecordCount = Cmd.Parameters("@RecordCount").Value
				End Using
			End Using
			Return Results
		End Function

	End Class
End Namespace
