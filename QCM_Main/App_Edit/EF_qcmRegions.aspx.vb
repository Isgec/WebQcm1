Partial Class EF_qcmRegions
  Inherits SIS.SYS.UpdateBase
  Protected Sub FVqcmRegions_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmRegions.Init
    DataClassName = "EqcmRegions"
    SetFormView = FVqcmRegions
  End Sub
  Protected Sub TBLqcmRegions_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmRegions.Init
    SetToolBar = TBLqcmRegions
  End Sub
  Protected Sub FVqcmRegions_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmRegions.PreRender
		Dim mStr As String = ""
		Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/QCM_Main/App_Edit") & "/EF_qcmRegions.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmRegions") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmRegions", mStr)
    End If
  End Sub

End Class
