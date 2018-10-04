Partial Class AF_qcmInspectorGroupUsers
  Inherits SIS.SYS.InsertBase
  Protected Sub FVqcmInspectorGroupUsers_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmInspectorGroupUsers.Init
    DataClassName = "AqcmInspectorGroupUsers"
    SetFormView = FVqcmInspectorGroupUsers
  End Sub
  Protected Sub TBLqcmInspectorGroupUsers_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmInspectorGroupUsers.Init
    SetToolBar = TBLqcmInspectorGroupUsers
  End Sub
	<System.Web.Services.WebMethod()> _
	<System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function CardNoCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.QCM.qcmEmployees.SelectqcmEmployeesAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub FVqcmInspectorGroupUsers_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmInspectorGroupUsers.PreRender
		Dim mStr As String = "<script type=""text/javascript""> "
		mStr = mStr & vbCrLf & " var script_qcmInspectorGroupUsers = {"
    Dim oF_GroupID As LC_qcmInspectorGroups = FVqcmInspectorGroupUsers.FindControl("F_GroupID")
    oF_GroupID.Enabled = True
    oF_GroupID.SelectedValue = String.Empty
    If Not Session("F_GroupID") Is Nothing Then
      If Session("F_GroupID") <> String.Empty Then
        oF_GroupID.SelectedValue = Session("F_GroupID")
      End If
    End If
    Dim oF_CardNo_Display As Label  = FVqcmInspectorGroupUsers.FindControl("F_CardNo_Display")
    Dim oF_CardNo As TextBox  = FVqcmInspectorGroupUsers.FindControl("F_CardNo")
		mStr = mStr & vbCrLf &	"ACECardNo_Selected: function(o, e) {"
		mStr = mStr & vbCrLf &	"  var F_CardNo = $get('" & oF_CardNo.ClientID & "');"
		mStr = mStr & vbCrLf &	"  var F_CardNo_Display = $get('" & oF_CardNo_Display.ClientID & "');"
		mStr = mStr & vbCrLf &	"  var retval = e.get_value();"
		mStr = mStr & vbCrLf &	"  var p = retval.split('|');"
		mStr = mStr & vbCrLf &	"  F_CardNo.value = p[0];"
		mStr = mStr & vbCrLf &	"  F_CardNo_Display.innerHTML = e.get_text();"
		mStr = mStr & vbCrLf &	"},"
		mStr = mStr & vbCrLf &	"ACECardNo_Populating: function(o,e) {"
		mStr = mStr & vbCrLf &	"  var p = o.get_element();"
		mStr = mStr & vbCrLf &	"  p.style.backgroundImage = 'url(../../images/loader.gif)';"
		mStr = mStr & vbCrLf &	"  p.style.backgroundRepeat = 'no-repeat';"
		mStr = mStr & vbCrLf &	"  p.style.backgroundPosition = 'right';"
		mStr = mStr & vbCrLf &	"  o._contextKey = '';"
		mStr = mStr & vbCrLf &	"},"
		mStr = mStr & vbCrLf &	"ACECardNo_Populated: function(o,e) {"
		mStr = mStr & vbCrLf &	"  var p = o.get_element();"
		mStr = mStr & vbCrLf &	"  p.style.backgroundImage  = 'none';"
		mStr = mStr & vbCrLf &	"},"
		mStr = mStr & vbCrLf &	"validate_CardNo: function(o) {"
		mStr = mStr & vbCrLf &	"    this.validated_FK_QCM_IGU_CardNo_main = true;"
		mStr = mStr & vbCrLf &	"    this.validate_FK_QCM_IGU_CardNo(o);"
		mStr = mStr & vbCrLf &	"  },"
		Dim FK_QCM_IGU_CardNoCardNo As TextBox = FVqcmInspectorGroupUsers.FindControl("F_CardNo")
		mStr = mStr & vbCrLf &	"validate_FK_QCM_IGU_CardNo: function(o) {"
		mStr = mStr & vbCrLf &	"  var value = o.id;"
		mStr = mStr & vbCrLf &	"  var CardNo = $get('" & FK_QCM_IGU_CardNoCardNo.ClientID & "');"
		mStr = mStr & vbCrLf &	"  if(CardNo.value==''){"
		mStr = mStr & vbCrLf &	"    if(this.validated_FK_QCM_IGU_CardNo_main){"
		mStr = mStr & vbCrLf &	"      var o_d = $get(o.id +'_Display');"
		mStr = mStr & vbCrLf &	"      try{o_d.innerHTML = '';}catch(ex){}"
		mStr = mStr & vbCrLf &	"    }"
		mStr = mStr & vbCrLf &	"    return true;"
		mStr = mStr & vbCrLf &	"  }"
		mStr = mStr & vbCrLf &	"  value = value + ',' + CardNo.value ;"
		mStr = mStr & vbCrLf &	"  o.style.backgroundImage  = 'url(../../images/pkloader.gif)';"
		mStr = mStr & vbCrLf &	"  o.style.backgroundRepeat= 'no-repeat';"
		mStr = mStr & vbCrLf &	"  o.style.backgroundPosition = 'right';"
		mStr = mStr & vbCrLf &	"  PageMethods.validate_FK_QCM_IGU_CardNo(value, this.validated_FK_QCM_IGU_CardNo);"
		mStr = mStr & vbCrLf &	"},"
		mStr = mStr & vbCrLf &	"validated_FK_QCM_IGU_CardNo_main: false,"
		mStr = mStr & vbCrLf &	"validated_FK_QCM_IGU_CardNo: function(result) {"
		mStr = mStr & vbCrLf &	"  var p = result.split('|');"
		mStr = mStr & vbCrLf &	"  var o = $get(p[1]);"
		mStr = mStr & vbCrLf &	"  if(script_qcmInspectorGroupUsers.validated_FK_QCM_IGU_CardNo_main){"
		mStr = mStr & vbCrLf &	"    var o_d = $get(p[1]+'_Display');"
		mStr = mStr & vbCrLf &	"    try{o_d.innerHTML = p[2];}catch(ex){}"
		mStr = mStr & vbCrLf &	"  }"
		mStr = mStr & vbCrLf &	"  o.style.backgroundImage  = 'none';"
		mStr = mStr & vbCrLf &	"  if(p[0]=='1'){"
		mStr = mStr & vbCrLf &	"    o.value='';"
		mStr = mStr & vbCrLf &	"    o.focus();"
		mStr = mStr & vbCrLf &	"  }"
		mStr = mStr & vbCrLf &	"},"
		mStr = mStr & vbCrLf &	"temp: function() {"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmInspectorGroupUsers") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmInspectorGroupUsers", mStr)
		End If
  End Sub
	<System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_QCM_IGU_CardNo(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
		Dim CardNo As String = CType(aVal(1),String)
		Dim oVar As SIS.QCM.qcmEmployees = SIS.QCM.qcmEmployees.qcmEmployeesGetByID(CardNo)
    If oVar Is Nothing Then
			mRet = "1|" & aVal(0) & "|Record not found." 
    Else
			mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
End Class
