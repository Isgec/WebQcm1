Imports System.Xml.Serialization
Imports System.Xml
Imports System.Net
Partial Class GF_qcmIntegration
	Inherits SIS.SYS.GridBase

	Protected Sub TBLqcmVendors_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmVendors.Init
		SetToolBar = TBLqcmVendors
	End Sub
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
	End Sub
	Protected Sub cmdUpload_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdUpload.Click
		Dim ForDate As String = F_UploadForDate.Text
		If ForDate = String.Empty Then Return
		'Check Folder exists
		Dim mPath As String = HttpContext.Current.Server.MapPath("~/..") & ConfigurationManager.AppSettings("FTPUploadDir") & "/" & ForDate.Replace("/", "-")
		If Not IO.Directory.Exists(mPath) Then
			Try
				IO.Directory.CreateDirectory(mPath)
			Catch ex As Exception
				Throw New Exception("Error creating upload folder: " & mPath)
			End Try
		End If
		Dim oReqs As List(Of SIS.QCM.qcmRequests) = SIS.QCM.qcmRequests.GetByCreatedOn(ForDate, "")
		For Each oReq As SIS.QCM.qcmRequests In oReqs
			Dim strReq As String = SIS.QCM.qcmRequests.GetRequestsGetByIDinXML(oReq.RequestID)
			If strReq <> String.Empty Then
				'Create File
				Dim oTS As IO.StreamWriter = New IO.StreamWriter(mPath & "/" & oReq.RequestID & ".XML")
				oTS.WriteLine("<?xml version=""1.0"" encoding=""UTF-8""?>")
				oTS.WriteLine("<root>")
				oTS.WriteLine(strReq)
				'Get Request Files
				Dim strReqFiles As String = SIS.QCM.qcmRequestFiles.GetRequestFilesSelectListinXML(0, 999, "", oReq.RequestID)
				If strReqFiles <> String.Empty Then
					oTS.WriteLine(strReqFiles)
				End If
				oTS.WriteLine("</root>")
				oTS.Close()
				oTS.Dispose()
				'Get Disk Files
				Dim oReqFls As List(Of SIS.QCM.qcmRequestFiles) = SIS.QCM.qcmRequestFiles.qcmRequestFilesSelectList(0, 999, "", False, "", oReq.RequestID)
				For Each fls As SIS.QCM.qcmRequestFiles In oReqFls
					IO.File.Copy(HttpContext.Current.Server.MapPath(ConfigurationManager.AppSettings("RequestDir")) & "/" & fls.DiskFIleName, mPath & "/" & fls.DiskFIleName, True)
				Next
			End If
		Next
		UploadFTPFile(mPath)
	End Sub
	Private Function UploadFTPFile(ByVal mUploadFolder As String) As Boolean
		'Upload folder parameter folder to be uploaded
		Dim mPath As String = IO.Path.GetDirectoryName(mUploadFolder)
		'Folder Name Which is Date String
		Dim mFile As String = IO.Path.GetFileName(mUploadFolder)
		Dim FtpHost As String = ConfigurationManager.AppSettings("FTPHost")
		Dim FTPLoginID As String = ConfigurationManager.AppSettings("FTPLoginID")
		Dim FTPPassword As String = ConfigurationManager.AppSettings("FTPPassword")
		'Dim FtpPath As String = "ftp://" & FTPLoginID & ":" & FTPPassword & "@" & FtpHost & "/INPUT/" & mFile
		Dim FtpPath As String = "ftp://" & FtpHost & "/INPUT/" & mFile
		Dim oReq As FtpWebRequest = Nothing
		Dim oRes As FtpWebResponse = Nothing
		Dim strStatus As String = ""
		'Check Folder Exists, if not then create folder
		oReq = FtpWebRequest.Create(FtpPath & "/")
		oReq.Credentials = New NetworkCredential(FTPLoginID, FTPPassword)
		oReq.Method = WebRequestMethods.Ftp.ListDirectory
		Try
			oRes = oReq.GetResponse()
			oRes.Close()
		Catch ex As WebException
			oRes = ex.Response
			If oRes.StatusCode = FtpStatusCode.ActionNotTakenFileUnavailable Then
				oReq = FtpWebRequest.Create(FtpPath)
				oReq.Credentials = New NetworkCredential(FTPLoginID, FTPPassword)
				oReq.Method = WebRequestMethods.Ftp.MakeDirectory
			End If
		End Try
		'End of Folder Checking and creation
		'Upload all file in UploadFolder
		Dim oFiles() As String = IO.Directory.GetFiles(mUploadFolder, "*.*", IO.SearchOption.TopDirectoryOnly)

		For Each strFile As String In oFiles
			Try
				oReq = WebRequest.Create(FtpPath & "/" & IO.Path.GetFileName(strFile))
				oReq.Credentials = New NetworkCredential(FTPLoginID, FTPPassword)
				oReq.Method = WebRequestMethods.Ftp.UploadFile
				oReq.KeepAlive = True
				oReq.UseBinary = True
				Dim oSW As IO.StreamWriter = New IO.StreamWriter(oReq.GetRequestStream())
				Dim oSR As IO.StreamReader = New IO.StreamReader(strFile)
				oSW.Write(oSR.ReadToEnd)
				oSW.Close()
				oSR.Close()
			Catch ex As Exception

			End Try
		Next
    'oRes = oReq.GetResponse()
    'strStatus = oRes.StatusDescription
    'oRes.Close()

    '=========================For Image======================
    'resize image
    'Dim img1 As System.Drawing.Image = ResizeImage(FileUpload1.PostedFile.InputStream, 84, 118)

    'Convert the image into bytes Array;
    'Dim buffer As Byte() = ImageToByte(img1)

    '// Send the image file in form of bytes
    'Dim ftpstream As IO.Stream = ftp.GetRequestStream()
    'ftpstream.Write(Buffer, 0, Buffer.Length)
    'ftpstream.Close()
    '===========================================================
    Return True
  End Function
	Private Function DownloadFTPFile(ByVal mDownloadFolder As String) As Boolean
		Dim mPath As String = IO.Path.GetDirectoryName(mDownloadFolder)
		'Folder Name Which is Date String
		Dim mFile As String = IO.Path.GetFileName(mDownloadFolder)
		Dim FtpHost As String = ConfigurationManager.AppSettings("FTPHost")
		Dim FTPLoginID As String = ConfigurationManager.AppSettings("FTPLoginID")
		Dim FTPPassword As String = ConfigurationManager.AppSettings("FTPPassword")
		Dim FtpPath As String = "ftp://" & FtpHost & "/INPUT/" & mFile
		Dim oReq As FtpWebRequest = Nothing
		Dim oRes As FtpWebResponse = Nothing
		Dim strStatus As String = ""
		Dim aFiles() As String = Nothing
		'Check Folder Exists, if not then download all files
		oReq = FtpWebRequest.Create(FtpPath & "/")
		oReq.Credentials = New NetworkCredential(FTPLoginID, FTPPassword)
		oReq.Method = WebRequestMethods.Ftp.ListDirectory
    Try
      'Read Directory, Create FileName Array
      oRes = oReq.GetResponse()
      Dim oRS As IO.Stream = oRes.GetResponseStream()
      Dim sInt As Integer = 0
      Dim strRes As String = ""
      While ((sInt = oRS.ReadByte()) <> -1)
        strRes = strRes & Convert.ToChar(sInt)
      End While
      aFiles = strRes.Split("\r\n".ToCharArray, StringSplitOptions.RemoveEmptyEntries)
      oRes.Close()
      'Download all file in array
      For Each strFile As String In aFiles
        oReq = FtpWebRequest.Create(FtpPath & "/" & strFile)
        oReq.Credentials = New NetworkCredential(FTPLoginID, FTPPassword)
        oReq.Method = WebRequestMethods.Ftp.DownloadFile
        oReq.UseBinary = True
        oRes = oReq.GetResponse()
        Dim oSW As IO.StreamWriter = New IO.StreamWriter(mPath & "/" & strFile)
        oSW.Write(New IO.StreamReader(oRes.GetResponseStream()).ReadToEnd)
        oSW.Close()
        oRes.Close()
      Next
    Catch ex As WebException
    End Try
    Return True
  End Function
	Protected Sub cmdDownload_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDownload.Click
		Dim ForDate As String = F_DownloadForDate.Text
		If ForDate = String.Empty Then Return
		Dim mPath As String = HttpContext.Current.Server.MapPath("~/..") & ConfigurationManager.AppSettings("FTPDownloadDir") & "/" & ForDate.Replace("/", "-")
		If Not IO.Directory.Exists(mPath) Then
			IO.Directory.CreateDirectory(mPath)
		End If
		'====================
		DownloadFTPFile(mPath)
		'====================
		If IO.Directory.Exists(mPath) Then
			Dim oFiles() As String = IO.Directory.GetFiles(mPath, "*" & ".xml", IO.SearchOption.TopDirectoryOnly)
			For Each mFile As String In oFiles
				Dim FileUnderProcess As String = IO.Path.GetFileName(mFile)
				Dim oDoc As XmlDocument = New XmlDocument
				oDoc.Load(mFile)
				Dim FileAttachedNode As XmlNode = Nothing
				Dim oIns As SIS.QCM.qcmInspections = New SIS.QCM.qcmInspections
				Dim oInsFiles As New List(Of SIS.QCM.qcmInspectionFiles)
				For Each nd As XmlNode In oDoc.ChildNodes(1).ChildNodes(0).ChildNodes
					Select Case nd.Name.ToLower
						Case "request_id"
							oIns.RequestID = nd.InnerText
						Case "inspection_date"
							oIns.InspectedOn = nd.InnerText
						Case "inspected_by"
							oIns.InspectedBy = nd.InnerText
						Case "inspection_status"
							oIns.RequestStateID = nd.InnerText.ToUpper
						Case "closed_status"
							oIns.InspectionStatusID = nd.InnerText
						Case "remarks"
							oIns.InspectionRemarks = nd.InnerText
						Case "attached_files"
							For Each fnd As XmlNode In nd.ChildNodes
								Dim oInsFile As New SIS.QCM.qcmInspectionFiles
								With oInsFile
									.DiskFIleName = fnd.Attributes("diskfilename").Value
									.FileName = fnd.Attributes("filename").Value
								End With
								oInsFiles.Add(oInsFile)
							Next
					End Select
				Next
				For Each fnd As XmlNode In oDoc.ChildNodes(1).ChildNodes(1).ChildNodes
					Dim oInsFile As New SIS.QCM.qcmInspectionFiles
					With oInsFile
						.DiskFIleName = fnd.Attributes("DiskFileName").Value
						.FileName = fnd.Attributes("FileName").Value
					End With
					oInsFiles.Add(oInsFile)
				Next
				'Update / Insert Inspection
				Dim oReq As SIS.QCM.qcmRequests = SIS.QCM.qcmRequests.qcmRequestsGetByID(oIns.RequestID)
				'Try to find Inspection by RequestID and InspectedOn
				Dim tmpIns As SIS.QCM.qcmInspections = SIS.QCM.qcmInspections.GetByRequestIDAndInspectedOn(oReq.RequestID, oIns.InspectedOn)
				If tmpIns IsNot Nothing Then
					'Update it
					If tmpIns.RequestStateID.ToUpper <> "CLOSED" Then
						With tmpIns
							.InspectedBy = oIns.InspectedBy
							.RequestStateID = oIns.RequestStateID
							.InspectionStatusID = oIns.InspectionStatusID
							.InspectionRemarks = oIns.InspectionRemarks
						End With
						tmpIns = SIS.QCM.qcmInspections.UZ_qcmInspectionsUpdate(tmpIns)
						If oIns.RequestStateID.ToUpper = "CLOSED" Then
							SIS.QCM.qcmRequests.CloseInspectionRequestAuto(oIns.RequestID, oIns.InspectionStatusID)
						End If
					End If
				Else
					tmpIns = New SIS.QCM.qcmInspections
					With tmpIns
						.RequestID = oIns.RequestID
						.RequestStateID = oIns.RequestStateID
						.InspectionStatusID = oIns.InspectionStatusID
						.InspectedBy = oIns.InspectedBy
						.InspectedOn = oIns.InspectedOn
						.InspectionRemarks = oIns.InspectionRemarks
						.ProjectID = oReq.ProjectID
						.SupplierID = oReq.SupplierID
						.OrderNo = oReq.OrderNo
						.OrderDate = oReq.OrderDate
						.InspectionStageiD = oReq.InspectionStageiD
					End With
					tmpIns = SIS.QCM.qcmInspections.UZ_qcmInspectionsInsert(tmpIns)
					If oIns.RequestStateID.ToUpper = "CLOSED" Then
						SIS.QCM.qcmRequests.CloseInspectionRequestAuto(oIns.RequestID, oIns.InspectionStatusID)
					End If
				End If
				oIns = tmpIns
				'Update / Insert Inspection Files
				For Each oIfl As SIS.QCM.qcmInspectionFiles In oInsFiles
					Dim tmpIfl As SIS.QCM.qcmInspectionFiles = SIS.QCM.qcmInspectionFiles.GetByDiskFileName(oIns.RequestID, oIns.InspectionID, oIfl.DiskFIleName)
					If tmpIfl IsNot Nothing Then
						'Nothing to Update only copy file
					Else
						With oIfl
							.RequestID = oIns.RequestID
							.InspectionID = oIns.InspectionID
						End With
						oIfl = SIS.QCM.qcmInspectionFiles.qcmInspectionFilesInsert(oIfl)
					End If
					If IO.File.Exists(mPath & "/" & oIfl.DiskFIleName) Then
						IO.File.Copy(mPath & "/" & oIfl.DiskFIleName, HttpContext.Current.Server.MapPath(ConfigurationManager.AppSettings("InspectionDir")) & "/" & oIfl.DiskFIleName, True)
					End If
				Next
			Next
		End If
	End Sub
End Class
