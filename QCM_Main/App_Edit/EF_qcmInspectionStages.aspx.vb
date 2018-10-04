Partial Class EF_qcmInspectionStages
  Inherits SIS.SYS.UpdateBase
  Protected Sub FVqcmInspectionStages_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmInspectionStages.Init
    DataClassName = "EqcmInspectionStages"
    SetFormView = FVqcmInspectionStages
  End Sub
  Protected Sub TBLqcmInspectionStages_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmInspectionStages.Init
    SetToolBar = TBLqcmInspectionStages
  End Sub
  Protected Sub FVqcmInspectionStages_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmInspectionStages.PreRender
		Dim mStr As String = "<script type=""text/javascript""> "
		mStr = mStr & vbCrLf & " var script_qcmInspectionStages = {"
		mStr = mStr & vbCrLf &	"temp: function() {"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmInspectionStages") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmInspectionStages", mStr)
		End If
  End Sub
End Class
