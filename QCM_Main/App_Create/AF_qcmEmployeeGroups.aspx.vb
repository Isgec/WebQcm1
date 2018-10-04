Partial Class AF_qcmEmployeeGroups
  Inherits SIS.SYS.InsertBase
  Protected Sub FVqcmEmployeeGroups_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmEmployeeGroups.Init
    DataClassName = "AqcmEmployeeGroups"
    SetFormView = FVqcmEmployeeGroups
  End Sub
  Protected Sub TBLqcmEmployeeGroups_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmEmployeeGroups.Init
    SetToolBar = TBLqcmEmployeeGroups
  End Sub
  Protected Sub ODSqcmEmployeeGroups_Inserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSqcmEmployeeGroups.Inserted
		If e.Exception Is Nothing Then
			Dim oDC As SIS.QCM.qcmEmployeeGroups = CType(e.ReturnValue,SIS.QCM.qcmEmployeeGroups)
			Dim tmpURL As String = "?tmp=1"
			tmpURL &= "&GroupID=" & oDC.GroupID
			TBLqcmEmployeeGroups.AfterInsertURL &= tmpURL 
		End If
  End Sub
  Protected Sub FVqcmEmployeeGroups_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmEmployeeGroups.PreRender
		Dim mStr As String = "<script type=""text/javascript""> "
		mStr = mStr & vbCrLf & " var script_qcmEmployeeGroups = {"
		mStr = mStr & vbCrLf &	"temp: function() {"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmEmployeeGroups") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmEmployeeGroups", mStr)
		End If
  End Sub
End Class
