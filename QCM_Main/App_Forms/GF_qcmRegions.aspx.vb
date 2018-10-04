Partial Class GF_qcmRegions
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/QCM_Main/App_Display/DF_qcmRegions.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?RegionID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVqcmRegions_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVqcmRegions.RowCommand
		If e.CommandName.ToLower = "lgedit".ToLower Then
			Try
				Dim RegionID As Int32 = GVqcmRegions.DataKeys(e.CommandArgument).Values("RegionID")  
				Dim RedirectUrl As String = TBLqcmRegions.EditUrl & "?RegionID=" & RegionID
				Response.Redirect(RedirectUrl)
			Catch ex As Exception
			End Try
		End If
  End Sub
  Protected Sub GVqcmRegions_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVqcmRegions.Init
    DataClassName = "GqcmRegions"
    SetGridView = GVqcmRegions
  End Sub
  Protected Sub TBLqcmRegions_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmRegions.Init
    SetToolBar = TBLqcmRegions
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
