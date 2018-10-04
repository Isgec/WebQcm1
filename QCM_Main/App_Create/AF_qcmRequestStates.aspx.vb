Partial Class AF_qcmRequestStates
  Inherits SIS.SYS.InsertBase
  Protected Sub FVqcmRequestStates_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmRequestStates.Init
    DataClassName = "AqcmRequestStates"
    SetFormView = FVqcmRequestStates
  End Sub
  Protected Sub TBLqcmRequestStates_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmRequestStates.Init
    SetToolBar = TBLqcmRequestStates
  End Sub
  Protected Sub FVqcmRequestStates_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmRequestStates.PreRender
		Dim mStr As String = "<script type=""text/javascript""> "
		mStr = mStr & vbCrLf & " var script_qcmRequestStates = {"
		mStr = mStr & vbCrLf &	"temp: function() {"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmRequestStates") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmRequestStates", mStr)
		End If
  End Sub
End Class
