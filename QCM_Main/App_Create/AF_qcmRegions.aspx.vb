Partial Class AF_qcmRegions
  Inherits SIS.SYS.InsertBase
  Protected Sub FVqcmRegions_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmRegions.Init
    DataClassName = "AqcmRegions"
    SetFormView = FVqcmRegions
  End Sub
  Protected Sub TBLqcmRegions_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmRegions.Init
    SetToolBar = TBLqcmRegions
  End Sub
  Protected Sub FVqcmRegions_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmRegions.PreRender
		Dim mStr As String = ""
		Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/QCM_Main/App_Create") & "/AF_qcmRegions.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmRegions") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmRegions", mStr)
    End If
    If Request.QueryString("RegionID") IsNot Nothing Then
      CType(FVqcmRegions.FindControl("F_RegionID"), TextBox).Text = Request.QueryString("RegionID")
      CType(FVqcmRegions.FindControl("F_RegionID"), TextBox).Enabled = False
    End If
  End Sub

End Class
