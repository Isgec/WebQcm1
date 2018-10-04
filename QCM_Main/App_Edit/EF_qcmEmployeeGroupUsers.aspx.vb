Partial Class EF_qcmEmployeeGroupUsers
  Inherits SIS.SYS.UpdateBase
  Protected Sub FVqcmEmployeeGroupUsers_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmEmployeeGroupUsers.Init
    DataClassName = "EqcmEmployeeGroupUsers"
    SetFormView = FVqcmEmployeeGroupUsers
  End Sub
  Protected Sub TBLqcmEmployeeGroupUsers_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmEmployeeGroupUsers.Init
    SetToolBar = TBLqcmEmployeeGroupUsers
  End Sub
  Protected Sub FVqcmEmployeeGroupUsers_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmEmployeeGroupUsers.PreRender
		Dim mStr As String = "<script type=""text/javascript""> "
		mStr = mStr & vbCrLf & " var script_qcmEmployeeGroupUsers = {"
    Dim oF_GroupiD As TextBox  = FVqcmEmployeeGroupUsers.FindControl("F_GroupiD")
    Dim oF_CardNo As TextBox  = FVqcmEmployeeGroupUsers.FindControl("F_CardNo")
		mStr = mStr & vbCrLf &	"temp: function() {"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmEmployeeGroupUsers") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmEmployeeGroupUsers", mStr)
		End If
  End Sub
End Class
