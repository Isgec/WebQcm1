Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports OfficeOpenXml
Imports System.Web.Script.Serialization

Partial Class filedownload
    Inherits System.Web.UI.Page
  Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    Dim Value As String = ""
    If Request.QueryString("reqfil") IsNot Nothing Then
      Value = Request.QueryString("reqfil")
      DownloadREQFIL(Value)
    End If
  End Sub

#Region " REQFIL "
  Private Sub DownloadREQFIL(ByVal value As String)
    Dim val() As String = value.Split("|".ToCharArray)
    Dim RequestID As Int32 = val(0)
    Dim SerialNo As Int32 = val(1)
    Dim tmp As SIS.QCM.qcmRequestFiles = SIS.QCM.qcmRequestFiles.qcmRequestFilesGetByID(RequestID, SerialNo)
    Dim tmpFile As String = ConfigurationManager.AppSettings("RequestDir") & "\" & tmp.DiskFIleName.Trim
    If IO.File.Exists(tmpFile) Then
      Dim FileName As String = Server.MapPath("~/..") & "App_Temp/" & Guid.NewGuid().ToString()
      IO.File.Copy(tmpFile, FileName)
      Response.Clear()
      Response.AppendHeader("content-disposition", "attachment; filename=""" & tmp.FileName)
      Response.ContentType = SIS.SYS.Utilities.ApplicationSpacific.ContentType(tmp.FileName)
      Response.WriteFile(FileName)
    End If
    Response.End()
  End Sub

#End Region

End Class
