Partial Class AF_qcmctRequest
  Inherits SIS.SYS.InsertBase
  Protected Sub FVqcmctRequest_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmctRequest.Init
    DataClassName = "AqcmctRequest"
    SetFormView = FVqcmctRequest
  End Sub
  Protected Sub TBLqcmctRequest_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmctRequest.Init
    SetToolBar = TBLqcmctRequest
  End Sub
  Protected Sub FVqcmctRequest_DataBound(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmctRequest.DataBound
    SIS.QCMCT.qcmctRequest.SetDefaultValues(sender, e) 
  End Sub
  Protected Sub FVqcmctRequest_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmctRequest.PreRender
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/QCMCT_Main/App_Create") & "/AF_qcmctRequest.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmctRequest") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmctRequest", mStr)
    End If
    If Request.QueryString("QCRequestNo") IsNot Nothing Then
      CType(FVqcmctRequest.FindControl("F_QCRequestNo"), TextBox).Text = Request.QueryString("QCRequestNo")
      CType(FVqcmctRequest.FindControl("F_QCRequestNo"), TextBox).Enabled = False
    End If
    If Request.QueryString("SerialNo") IsNot Nothing Then
      CType(FVqcmctRequest.FindControl("F_SerialNo"), TextBox).Text = Request.QueryString("SerialNo")
      CType(FVqcmctRequest.FindControl("F_SerialNo"), TextBox).Enabled = False
    End If
    If Request.QueryString("PONumber") IsNot Nothing Then
      CType(FVqcmctRequest.FindControl("F_PONumber"), TextBox).Text = Request.QueryString("PONumber")
      CType(FVqcmctRequest.FindControl("F_PONumber"), TextBox).Enabled = False
    End If
    If Request.QueryString("ItemReference") IsNot Nothing Then
      CType(FVqcmctRequest.FindControl("F_ItemReference"), TextBox).Text = Request.QueryString("ItemReference")
      CType(FVqcmctRequest.FindControl("F_ItemReference"), TextBox).Enabled = False
    End If
    If Request.QueryString("ActivityID") IsNot Nothing Then
      CType(FVqcmctRequest.FindControl("F_ActivityID"), TextBox).Text = Request.QueryString("ActivityID")
      CType(FVqcmctRequest.FindControl("F_ActivityID"), TextBox).Enabled = False
    End If
  End Sub

End Class
