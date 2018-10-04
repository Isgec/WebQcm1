Partial Class EF_qcmReceivingMediums
  Inherits SIS.SYS.UpdateBase
  Protected Sub FVqcmReceivingMediums_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmReceivingMediums.Init
    DataClassName = "EqcmReceivingMediums"
    SetFormView = FVqcmReceivingMediums
  End Sub
  Protected Sub TBLqcmReceivingMediums_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmReceivingMediums.Init
    SetToolBar = TBLqcmReceivingMediums
  End Sub
  Protected Sub FVqcmReceivingMediums_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmReceivingMediums.PreRender
		Dim mStr As String = "<script type=""text/javascript""> "
		mStr = mStr & vbCrLf & " var script_qcmReceivingMediums = {"
		mStr = mStr & vbCrLf &	"temp: function() {"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmReceivingMediums") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmReceivingMediums", mStr)
		End If
  End Sub
End Class
