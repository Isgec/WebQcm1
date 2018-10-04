Partial Class EF_qcmInspectionStatus
  Inherits SIS.SYS.UpdateBase
  Protected Sub FVqcmInspectionStatus_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmInspectionStatus.Init
    DataClassName = "EqcmInspectionStatus"
    SetFormView = FVqcmInspectionStatus
  End Sub
  Protected Sub TBLqcmInspectionStatus_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmInspectionStatus.Init
    SetToolBar = TBLqcmInspectionStatus
  End Sub
  Protected Sub FVqcmInspectionStatus_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmInspectionStatus.PreRender
		Dim mStr As String = "<script type=""text/javascript""> "
		mStr = mStr & vbCrLf & " var script_qcmInspectionStatus = {"
		mStr = mStr & vbCrLf &	"temp: function() {"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmInspectionStatus") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmInspectionStatus", mStr)
		End If
  End Sub
End Class
