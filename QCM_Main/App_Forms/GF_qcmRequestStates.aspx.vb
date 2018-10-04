Partial Class GF_qcmRequestStates
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/QCM_Main/App_Display/DF_qcmRequestStates.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?StateID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVqcmRequestStates_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVqcmRequestStates.RowCommand
		If e.CommandName.ToLower = "lgedit".ToLower Then
			Try
				Dim StateID As String = GVqcmRequestStates.DataKeys(e.CommandArgument).Values("StateID")  
				Dim RedirectUrl As String = TBLqcmRequestStates.EditUrl & "?StateID=" & StateID
				Response.Redirect(RedirectUrl)
			Catch ex As Exception
			End Try
		End If
  End Sub
  Protected Sub GVqcmRequestStates_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVqcmRequestStates.Init
    DataClassName = "GqcmRequestStates"
    SetGridView = GVqcmRequestStates
  End Sub
  Protected Sub TBLqcmRequestStates_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmRequestStates.Init
    SetToolBar = TBLqcmRequestStates
  End Sub
  Protected Sub F_StateID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_StateID.TextChanged
    Session("F_StateID") = F_StateID.Text
    InitGridPage()
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
