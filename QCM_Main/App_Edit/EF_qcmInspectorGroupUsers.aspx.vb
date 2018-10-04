Partial Class EF_qcmInspectorGroupUsers
  Inherits SIS.SYS.UpdateBase
  Protected Sub FVqcmInspectorGroupUsers_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmInspectorGroupUsers.Init
    DataClassName = "EqcmInspectorGroupUsers"
    SetFormView = FVqcmInspectorGroupUsers
  End Sub
  Protected Sub TBLqcmInspectorGroupUsers_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmInspectorGroupUsers.Init
    SetToolBar = TBLqcmInspectorGroupUsers
  End Sub
  Protected Sub FVqcmInspectorGroupUsers_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmInspectorGroupUsers.PreRender
		Dim mStr As String = "<script type=""text/javascript""> "
		mStr = mStr & vbCrLf & " var script_qcmInspectorGroupUsers = {"
    Dim oF_GroupID As TextBox  = FVqcmInspectorGroupUsers.FindControl("F_GroupID")
    Dim oF_CardNo As TextBox  = FVqcmInspectorGroupUsers.FindControl("F_CardNo")
		mStr = mStr & vbCrLf &	"temp: function() {"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmInspectorGroupUsers") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmInspectorGroupUsers", mStr)
		End If
  End Sub
End Class
