Partial Class AF_qcmInspectorGroups
  Inherits SIS.SYS.InsertBase
  Protected Sub FVqcmInspectorGroups_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmInspectorGroups.Init
    DataClassName = "AqcmInspectorGroups"
    SetFormView = FVqcmInspectorGroups
  End Sub
  Protected Sub TBLqcmInspectorGroups_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmInspectorGroups.Init
    SetToolBar = TBLqcmInspectorGroups
  End Sub
  Protected Sub ODSqcmInspectorGroups_Inserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSqcmInspectorGroups.Inserted
		If e.Exception Is Nothing Then
			Dim oDC As SIS.QCM.qcmInspectorGroups = CType(e.ReturnValue,SIS.QCM.qcmInspectorGroups)
			Dim tmpURL As String = "?tmp=1"
			tmpURL &= "&GroupID=" & oDC.GroupID
			TBLqcmInspectorGroups.AfterInsertURL &= tmpURL 
		End If
  End Sub
  Protected Sub FVqcmInspectorGroups_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmInspectorGroups.PreRender
		Dim mStr As String = "<script type=""text/javascript""> "
		mStr = mStr & vbCrLf & " var script_qcmInspectorGroups = {"
		mStr = mStr & vbCrLf &	"temp: function() {"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmInspectorGroups") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmInspectorGroups", mStr)
		End If
  End Sub
End Class
