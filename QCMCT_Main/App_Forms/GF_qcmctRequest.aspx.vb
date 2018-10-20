Imports System.Web.Script.Serialization
Partial Class GF_qcmctRequest
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/QCMCT_Main/App_Display/DF_qcmctRequest.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?QCRequestNo=" & aVal(0) & "&SerialNo=" & aVal(1) & "&PONumber=" & aVal(2) & "&ItemReference=" & aVal(3) & "&ActivityID=" & aVal(4)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVqcmctRequest_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVqcmctRequest.RowCommand
    If e.CommandName.ToLower = "lgedit".ToLower Then
      Try
        Dim QCRequestNo As Int32 = GVqcmctRequest.DataKeys(e.CommandArgument).Values("QCRequestNo")  
        Dim SerialNo As Int32 = GVqcmctRequest.DataKeys(e.CommandArgument).Values("SerialNo")  
        Dim PONumber As String = GVqcmctRequest.DataKeys(e.CommandArgument).Values("PONumber")  
        Dim ItemReference As String = GVqcmctRequest.DataKeys(e.CommandArgument).Values("ItemReference")  
        Dim ActivityID As String = GVqcmctRequest.DataKeys(e.CommandArgument).Values("ActivityID")  
        Dim RedirectUrl As String = TBLqcmctRequest.EditUrl & "?QCRequestNo=" & QCRequestNo & "&SerialNo=" & SerialNo & "&PONumber=" & PONumber & "&ItemReference=" & ItemReference & "&ActivityID=" & ActivityID
        Response.Redirect(RedirectUrl)
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
  End Sub
  Protected Sub GVqcmctRequest_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVqcmctRequest.Init
    DataClassName = "GqcmctRequest"
    SetGridView = GVqcmctRequest
  End Sub
  Protected Sub TBLqcmctRequest_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmctRequest.Init
    SetToolBar = TBLqcmctRequest
  End Sub
  Protected Sub F_QCRequestNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_QCRequestNo.TextChanged
    Session("F_QCRequestNo") = F_QCRequestNo.Text
    InitGridPage()
  End Sub
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
  End Sub
End Class
