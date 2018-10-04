Partial Class EF_qcmIEntryHO
  Inherits SIS.SYS.UpdateBase
  Protected Sub FVqcmIEntryHO_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmIEntryHO.Init
    DataClassName = "EqcmIEntryHO"
    SetFormView = FVqcmIEntryHO
  End Sub
  Protected Sub TBLqcmIEntryHO_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmIEntryHO.Init
    SetToolBar = TBLqcmIEntryHO
  End Sub
  Protected Sub FVqcmIEntryHO_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmIEntryHO.PreRender
		Dim mStr As String = "<script type=""text/javascript""> "
		mStr = mStr & vbCrLf & " var script_qcmIEntryHO = {"
		mStr = mStr & vbCrLf &	"temp: function() {"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmIEntryHO") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmIEntryHO", mStr)
		End If
  End Sub
  Partial Class gvBase
		Inherits SIS.SYS.GridBase
  End Class
  Private WithEvents gvqcmRequestFilesCC As New gvBase
	Protected Sub GVqcmRequestFiles_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVqcmRequestFiles.RowCommand
		If e.CommandName.ToLower = "downloadfile".ToLower Then
			Try
				Dim RequestID As Int32 = GVqcmRequestFiles.DataKeys(e.CommandArgument).Values("RequestID")
				Dim SerialNo As Int32 = GVqcmRequestFiles.DataKeys(e.CommandArgument).Values("SerialNo")
				Dim oAT As SIS.QCM.qcmRequestFiles = SIS.QCM.qcmRequestFiles.qcmRequestFilesGetByID(RequestID, SerialNo)
				If IO.File.Exists(Server.MapPath(ConfigurationManager.AppSettings("RequestDir")) & "/" & oAT.DiskFIleName) Then
					Response.AppendHeader("content-disposition", "attachment; filename='" & oAT.FileName & "'")
					Response.ContentType = oAT.ContentType
					Response.WriteFile(Server.MapPath(ConfigurationManager.AppSettings("RequestDir")) & "/" & oAT.DiskFIleName)
					Response.Flush()
				End If
			Catch ex As Exception
			End Try
		End If
	End Sub
	Private WithEvents gvqcmInspectionsCC As New gvBase
  Protected Sub GVqcmInspections_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVqcmInspections.Init
		gvqcmInspectionsCC.DataClassName = "GqcmInspections"
		gvqcmInspectionsCC.SetGridView = GVqcmInspections
  End Sub
  Protected Sub TBLqcmInspections_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmInspections.Init
		gvqcmInspectionsCC.SetToolBar = TBLqcmInspections
  End Sub
  Protected Sub GVqcmInspections_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVqcmInspections.RowCommand
		If e.CommandName.ToLower = "lgedit".ToLower Then
			Try
				Dim RequestID As Int32 = GVqcmInspections.DataKeys(e.CommandArgument).Values("RequestID")  
				Dim InspectionID As Int32 = GVqcmInspections.DataKeys(e.CommandArgument).Values("InspectionID")  
				Dim RedirectUrl As String = TBLqcmInspections.EditUrl & "?RequestID=" & RequestID & "&InspectionID=" & InspectionID
				Response.Redirect(RedirectUrl)
			Catch ex As Exception
			End Try
		End If
  End Sub
  Protected Sub TBLqcmInspections_AddClicked(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles TBLqcmInspections.AddClicked
		Dim RequestID As Int32 = CType(FVqcmIEntryHO.FindControl("F_RequestID"),TextBox).Text
		TBLqcmInspections.AddUrl &= "&RequestID=" & RequestID
  End Sub
	Public Property Editable() As Boolean
		Get
      If ViewState("Editable") IsNot Nothing Then
        Return CType(ViewState("Editable"), Boolean)
      End If
      Return False
    End Get
		Set(ByVal value As Boolean)
			ViewState.Add("Editable", value)
		End Set
	End Property
	Protected Sub ODSqcmIEntryHO_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSqcmIEntryHO.Selected
		Dim oReq As SIS.QCM.qcmIEntryHO = CType(e.ReturnValue, SIS.QCM.qcmIEntryHO)
		If oReq.RequestStateID = "CLOSED" Then
			Editable = False
		Else
			Editable = True
		End If
	End Sub
End Class
