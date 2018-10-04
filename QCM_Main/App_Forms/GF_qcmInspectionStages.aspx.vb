Partial Class GF_qcmInspectionStages
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/QCM_Main/App_Display/DF_qcmInspectionStages.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?InspectionStageID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVqcmInspectionStages_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVqcmInspectionStages.RowCommand
		If e.CommandName.ToLower = "lgedit".ToLower Then
			Try
				Dim InspectionStageID As Int32 = GVqcmInspectionStages.DataKeys(e.CommandArgument).Values("InspectionStageID")  
				Dim RedirectUrl As String = TBLqcmInspectionStages.EditUrl & "?InspectionStageID=" & InspectionStageID
				Response.Redirect(RedirectUrl)
			Catch ex As Exception
			End Try
		End If
  End Sub
  Protected Sub GVqcmInspectionStages_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVqcmInspectionStages.Init
    DataClassName = "GqcmInspectionStages"
    SetGridView = GVqcmInspectionStages
  End Sub
  Protected Sub TBLqcmInspectionStages_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmInspectionStages.Init
    SetToolBar = TBLqcmInspectionStages
  End Sub
  Protected Sub F_InspectionStageID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_InspectionStageID.TextChanged
    Session("F_InspectionStageID") = F_InspectionStageID.Text
    InitGridPage()
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
