Partial Class EF_qcmEmployeeGroups
  Inherits SIS.SYS.UpdateBase
  Protected Sub FVqcmEmployeeGroups_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmEmployeeGroups.Init
    DataClassName = "EqcmEmployeeGroups"
    SetFormView = FVqcmEmployeeGroups
  End Sub
  Protected Sub TBLqcmEmployeeGroups_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmEmployeeGroups.Init
    SetToolBar = TBLqcmEmployeeGroups
  End Sub
  Protected Sub FVqcmEmployeeGroups_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmEmployeeGroups.PreRender
		Dim mStr As String = "<script type=""text/javascript""> "
		mStr = mStr & vbCrLf & " var script_qcmEmployeeGroups = {"
		mStr = mStr & vbCrLf &	"temp: function() {"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmEmployeeGroups") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmEmployeeGroups", mStr)
		End If
  End Sub
  Partial Class gvBase
		Inherits SIS.SYS.GridBase
  End Class
  Private WithEvents gvqcmEmployeeGroupUsersCC As New gvBase
  Protected Sub GVqcmEmployeeGroupUsers_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVqcmEmployeeGroupUsers.Init
		gvqcmEmployeeGroupUsersCC.DataClassName = "GqcmEmployeeGroupUsers"
		gvqcmEmployeeGroupUsersCC.SetGridView = GVqcmEmployeeGroupUsers
  End Sub
  Protected Sub TBLqcmEmployeeGroupUsers_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmEmployeeGroupUsers.Init
		gvqcmEmployeeGroupUsersCC.SetToolBar = TBLqcmEmployeeGroupUsers
  End Sub
  Protected Sub GVqcmEmployeeGroupUsers_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVqcmEmployeeGroupUsers.RowCommand
		If e.CommandName.ToLower = "lgedit".ToLower Then
			Try
				Dim GroupiD As Int32 = GVqcmEmployeeGroupUsers.DataKeys(e.CommandArgument).Values("GroupiD")  
				Dim CardNo As String = GVqcmEmployeeGroupUsers.DataKeys(e.CommandArgument).Values("CardNo")  
				Dim RedirectUrl As String = TBLqcmEmployeeGroupUsers.EditUrl & "?GroupiD=" & GroupiD & "&CardNo=" & CardNo
				Response.Redirect(RedirectUrl)
			Catch ex As Exception
			End Try
		End If
  End Sub
  Protected Sub TBLqcmEmployeeGroupUsers_AddClicked(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles TBLqcmEmployeeGroupUsers.AddClicked
		Dim GroupID As Int32 = CType(FVqcmEmployeeGroups.FindControl("F_GroupID"),TextBox).Text
		TBLqcmEmployeeGroupUsers.AddUrl &= "?GroupID=" & GroupID
  End Sub
End Class
