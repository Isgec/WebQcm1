Partial Class EF_qcmVendors
  Inherits SIS.SYS.UpdateBase
  Protected Sub FVqcmVendors_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmVendors.Init
    DataClassName = "EqcmVendors"
    SetFormView = FVqcmVendors
  End Sub
  Protected Sub TBLqcmVendors_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmVendors.Init
    SetToolBar = TBLqcmVendors
  End Sub
  Protected Sub FVqcmVendors_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmVendors.PreRender
		Dim mStr As String = "<script type=""text/javascript""> "
		mStr = mStr & vbCrLf & " var script_qcmVendors = {"
		mStr = mStr & vbCrLf &	"temp: function() {"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmVendors") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmVendors", mStr)
		End If
  End Sub
End Class
