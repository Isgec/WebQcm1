Partial Class EF_qcmIGvsEG
  Inherits SIS.SYS.UpdateBase
  Protected Sub FVqcmIGvsEG_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmIGvsEG.Init
    DataClassName = "EqcmIGvsEG"
    SetFormView = FVqcmIGvsEG
  End Sub
  Protected Sub TBLqcmIGvsEG_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmIGvsEG.Init
    SetToolBar = TBLqcmIGvsEG
  End Sub
  Protected Sub FVqcmIGvsEG_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmIGvsEG.PreRender
		Dim mStr As String = "<script type=""text/javascript""> "
		mStr = mStr & vbCrLf & " var script_qcmIGvsEG = {"
    Dim oF_InspectorGroupID As TextBox  = FVqcmIGvsEG.FindControl("F_InspectorGroupID")
    Dim oF_EmployeeGroupID As TextBox  = FVqcmIGvsEG.FindControl("F_EmployeeGroupID")
		mStr = mStr & vbCrLf &	"temp: function() {"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmIGvsEG") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmIGvsEG", mStr)
		End If
  End Sub
End Class
