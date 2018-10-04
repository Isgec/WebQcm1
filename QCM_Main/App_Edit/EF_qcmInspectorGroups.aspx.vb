Partial Class EF_qcmInspectorGroups
  Inherits SIS.SYS.UpdateBase
  Protected Sub FVqcmInspectorGroups_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmInspectorGroups.Init
    DataClassName = "EqcmInspectorGroups"
    SetFormView = FVqcmInspectorGroups
  End Sub
  Protected Sub TBLqcmInspectorGroups_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmInspectorGroups.Init
    SetToolBar = TBLqcmInspectorGroups
  End Sub
  Protected Sub FVqcmInspectorGroups_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmInspectorGroups.PreRender
		Dim mStr As String = "<script type=""text/javascript""> "
		mStr = mStr & vbCrLf & " var script_qcmInspectorGroups = {"
		mStr = mStr & vbCrLf &	"temp: function() {"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmInspectorGroups") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmInspectorGroups", mStr)
		End If
  End Sub
  Partial Class gvBase
		Inherits SIS.SYS.GridBase
  End Class
  Private WithEvents gvqcmInspectorGroupUsersCC As New gvBase
  Protected Sub GVqcmInspectorGroupUsers_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVqcmInspectorGroupUsers.Init
		gvqcmInspectorGroupUsersCC.DataClassName = "GqcmInspectorGroupUsers"
		gvqcmInspectorGroupUsersCC.SetGridView = GVqcmInspectorGroupUsers
  End Sub
  Protected Sub TBLqcmInspectorGroupUsers_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmInspectorGroupUsers.Init
		gvqcmInspectorGroupUsersCC.SetToolBar = TBLqcmInspectorGroupUsers
  End Sub
  Protected Sub GVqcmInspectorGroupUsers_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVqcmInspectorGroupUsers.RowCommand
		If e.CommandName.ToLower = "lgedit".ToLower Then
			Try
				Dim GroupID As Int32 = GVqcmInspectorGroupUsers.DataKeys(e.CommandArgument).Values("GroupID")  
				Dim CardNo As String = GVqcmInspectorGroupUsers.DataKeys(e.CommandArgument).Values("CardNo")  
				Dim RedirectUrl As String = TBLqcmInspectorGroupUsers.EditUrl & "?GroupID=" & GroupID & "&CardNo=" & CardNo
				Response.Redirect(RedirectUrl)
			Catch ex As Exception
			End Try
		End If
  End Sub
  Protected Sub TBLqcmInspectorGroupUsers_AddClicked(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles TBLqcmInspectorGroupUsers.AddClicked
		Dim GroupID As Int32 = CType(FVqcmInspectorGroups.FindControl("F_GroupID"),TextBox).Text
		TBLqcmInspectorGroupUsers.AddUrl &= "?GroupID=" & GroupID
  End Sub
End Class
