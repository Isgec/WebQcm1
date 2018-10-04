Partial Class GF_qcmInspectorGroups
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/QCM_Main/App_Display/DF_qcmInspectorGroups.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?GroupID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVqcmInspectorGroups_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVqcmInspectorGroups.RowCommand
		If e.CommandName.ToLower = "lgedit".ToLower Then
			Try
				Dim GroupID As Int32 = GVqcmInspectorGroups.DataKeys(e.CommandArgument).Values("GroupID")  
				Dim RedirectUrl As String = TBLqcmInspectorGroups.EditUrl & "?GroupID=" & GroupID
				Response.Redirect(RedirectUrl)
			Catch ex As Exception
			End Try
		End If
  End Sub
  Protected Sub GVqcmInspectorGroups_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVqcmInspectorGroups.Init
    DataClassName = "GqcmInspectorGroups"
    SetGridView = GVqcmInspectorGroups
  End Sub
  Protected Sub TBLqcmInspectorGroups_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmInspectorGroups.Init
    SetToolBar = TBLqcmInspectorGroups
  End Sub
  Protected Sub F_GroupID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_GroupID.TextChanged
    Session("F_GroupID") = F_GroupID.Text
    InitGridPage()
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
