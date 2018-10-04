Partial Class GF_qcmVendors
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/QCM_Main/App_Display/DF_qcmVendors.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?VendorID=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVqcmVendors_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVqcmVendors.RowCommand
		If e.CommandName.ToLower = "lgedit".ToLower Then
			Try
				Dim VendorID As String = GVqcmVendors.DataKeys(e.CommandArgument).Values("VendorID")  
				Dim RedirectUrl As String = TBLqcmVendors.EditUrl & "?VendorID=" & VendorID
				Response.Redirect(RedirectUrl)
			Catch ex As Exception
			End Try
		End If
  End Sub
  Protected Sub GVqcmVendors_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVqcmVendors.Init
    DataClassName = "GqcmVendors"
    SetGridView = GVqcmVendors
  End Sub
  Protected Sub TBLqcmVendors_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmVendors.Init
    SetToolBar = TBLqcmVendors
  End Sub
  Protected Sub F_VendorID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_VendorID.TextChanged
    Session("F_VendorID") = F_VendorID.Text
    InitGridPage()
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
