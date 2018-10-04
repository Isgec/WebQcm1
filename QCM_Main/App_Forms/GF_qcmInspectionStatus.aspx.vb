Partial Class GF_qcmInspectionStatus
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/QCM_Main/App_Display/DF_qcmInspectionStatus.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?InspectionStatusID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVqcmInspectionStatus_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVqcmInspectionStatus.RowCommand
		If e.CommandName.ToLower = "lgedit".ToLower Then
			Try
				Dim InspectionStatusID As Int32 = GVqcmInspectionStatus.DataKeys(e.CommandArgument).Values("InspectionStatusID")  
				Dim RedirectUrl As String = TBLqcmInspectionStatus.EditUrl & "?InspectionStatusID=" & InspectionStatusID
				Response.Redirect(RedirectUrl)
			Catch ex As Exception
			End Try
		End If
  End Sub
  Protected Sub GVqcmInspectionStatus_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVqcmInspectionStatus.Init
    DataClassName = "GqcmInspectionStatus"
    SetGridView = GVqcmInspectionStatus
  End Sub
  Protected Sub TBLqcmInspectionStatus_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmInspectionStatus.Init
    SetToolBar = TBLqcmInspectionStatus
  End Sub
  Protected Sub F_InspectionStatusID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_InspectionStatusID.TextChanged
    Session("F_InspectionStatusID") = F_InspectionStatusID.Text
    InitGridPage()
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
