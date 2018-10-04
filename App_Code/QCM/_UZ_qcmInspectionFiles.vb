Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.QCM
  Partial Public Class qcmInspectionFiles
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
		Public Shared Function GetByDiskFileName(ByVal RequestID As Int32, ByVal InspectionID As Int32, ByVal DiskFileName As String) As SIS.QCM.qcmInspectionFiles
			Dim Results As SIS.QCM.qcmInspectionFiles = Nothing
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "spqcm_LG_InspectionFilesSelectByDiskFileName"
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RequestID", SqlDbType.Int, RequestID.ToString.Length, RequestID)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectionID", SqlDbType.Int, InspectionID.ToString.Length, InspectionID)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DiskFileName", SqlDbType.NVarChar, DiskFileName.ToString.Length, DiskFileName)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
					Con.Open()
					Dim Reader As SqlDataReader = Cmd.ExecuteReader()
					If Reader.Read() Then
						Results = New SIS.QCM.qcmInspectionFiles(Reader)
					End If
					Reader.Close()
				End Using
			End Using
			Return Results
		End Function

  End Class
End Namespace
