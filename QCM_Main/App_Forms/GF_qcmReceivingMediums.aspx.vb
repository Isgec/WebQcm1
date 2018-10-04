Partial Class GF_qcmReceivingMediums
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/QCM_Main/App_Display/DF_qcmReceivingMediums.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?ReceivingMediumID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVqcmReceivingMediums_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVqcmReceivingMediums.RowCommand
		If e.CommandName.ToLower = "lgedit".ToLower Then
			Try
				Dim ReceivingMediumID As Int32 = GVqcmReceivingMediums.DataKeys(e.CommandArgument).Values("ReceivingMediumID")  
				Dim RedirectUrl As String = TBLqcmReceivingMediums.EditUrl & "?ReceivingMediumID=" & ReceivingMediumID
				Response.Redirect(RedirectUrl)
			Catch ex As Exception
			End Try
		End If
  End Sub
  Protected Sub GVqcmReceivingMediums_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVqcmReceivingMediums.Init
    DataClassName = "GqcmReceivingMediums"
    SetGridView = GVqcmReceivingMediums
  End Sub
  Protected Sub TBLqcmReceivingMediums_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmReceivingMediums.Init
    SetToolBar = TBLqcmReceivingMediums
  End Sub
  Protected Sub F_ReceivingMediumID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_ReceivingMediumID.TextChanged
    Session("F_ReceivingMediumID") = F_ReceivingMediumID.Text
    InitGridPage()
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
