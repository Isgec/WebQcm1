Partial Class AF_qcmIGvsEG
  Inherits SIS.SYS.InsertBase
  Protected Sub FVqcmIGvsEG_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmIGvsEG.Init
    DataClassName = "AqcmIGvsEG"
    SetFormView = FVqcmIGvsEG
  End Sub
  Protected Sub TBLqcmIGvsEG_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmIGvsEG.Init
    SetToolBar = TBLqcmIGvsEG
  End Sub
	<System.Web.Services.WebMethod()> _
	<System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function InspectorGroupIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.QCM.qcmInspectorGroups.SelectqcmInspectorGroupsAutoCompleteList(prefixText, count, contextKey)
  End Function
	<System.Web.Services.WebMethod()> _
	<System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function EmployeeGroupIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.QCM.qcmEmployeeGroups.SelectqcmEmployeeGroupsAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub FVqcmIGvsEG_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmIGvsEG.PreRender
		Dim mStr As String = "<script type=""text/javascript""> "
		mStr = mStr & vbCrLf & " var script_qcmIGvsEG = {"
    Dim oF_InspectorGroupID_Display As Label  = FVqcmIGvsEG.FindControl("F_InspectorGroupID_Display")
    oF_InspectorGroupID_Display.Text = String.Empty
    If Not Session("F_InspectorGroupID_Display") Is Nothing Then
      If Session("F_InspectorGroupID_Display") <> String.Empty Then
        oF_InspectorGroupID_Display.Text = Session("F_InspectorGroupID_Display")
      End If
    End If
    Dim oF_InspectorGroupID As TextBox  = FVqcmIGvsEG.FindControl("F_InspectorGroupID")
    oF_InspectorGroupID.Enabled = True
    oF_InspectorGroupID.Text = String.Empty
    If Not Session("F_InspectorGroupID") Is Nothing Then
      If Session("F_InspectorGroupID") <> String.Empty Then
        oF_InspectorGroupID.Text = Session("F_InspectorGroupID")
      End If
    End If
		mStr = mStr & vbCrLf &	"ACEInspectorGroupID_Selected: function(o, e) {"
		mStr = mStr & vbCrLf &	"  var F_InspectorGroupID = $get('" & oF_InspectorGroupID.ClientID & "');"
		mStr = mStr & vbCrLf &	"  var F_InspectorGroupID_Display = $get('" & oF_InspectorGroupID_Display.ClientID & "');"
		mStr = mStr & vbCrLf &	"  var retval = e.get_value();"
		mStr = mStr & vbCrLf &	"  var p = retval.split('|');"
		mStr = mStr & vbCrLf &	"  F_InspectorGroupID.value = p[0];"
		mStr = mStr & vbCrLf &	"  F_InspectorGroupID_Display.innerHTML = e.get_text();"
		mStr = mStr & vbCrLf &	"},"
		mStr = mStr & vbCrLf &	"ACEInspectorGroupID_Populating: function(o,e) {"
		mStr = mStr & vbCrLf &	"  var p = o.get_element();"
		mStr = mStr & vbCrLf &	"  p.style.backgroundImage = 'url(../../images/loader.gif)';"
		mStr = mStr & vbCrLf &	"  p.style.backgroundRepeat = 'no-repeat';"
		mStr = mStr & vbCrLf &	"  p.style.backgroundPosition = 'right';"
		mStr = mStr & vbCrLf &	"  o._contextKey = '';"
		mStr = mStr & vbCrLf &	"},"
		mStr = mStr & vbCrLf &	"ACEInspectorGroupID_Populated: function(o,e) {"
		mStr = mStr & vbCrLf &	"  var p = o.get_element();"
		mStr = mStr & vbCrLf &	"  p.style.backgroundImage  = 'none';"
		mStr = mStr & vbCrLf &	"},"
    Dim oF_EmployeeGroupID_Display As Label  = FVqcmIGvsEG.FindControl("F_EmployeeGroupID_Display")
    oF_EmployeeGroupID_Display.Text = String.Empty
    If Not Session("F_EmployeeGroupID_Display") Is Nothing Then
      If Session("F_EmployeeGroupID_Display") <> String.Empty Then
        oF_EmployeeGroupID_Display.Text = Session("F_EmployeeGroupID_Display")
      End If
    End If
    Dim oF_EmployeeGroupID As TextBox  = FVqcmIGvsEG.FindControl("F_EmployeeGroupID")
    oF_EmployeeGroupID.Enabled = True
    oF_EmployeeGroupID.Text = String.Empty
    If Not Session("F_EmployeeGroupID") Is Nothing Then
      If Session("F_EmployeeGroupID") <> String.Empty Then
        oF_EmployeeGroupID.Text = Session("F_EmployeeGroupID")
      End If
    End If
		mStr = mStr & vbCrLf &	"ACEEmployeeGroupID_Selected: function(o, e) {"
		mStr = mStr & vbCrLf &	"  var F_EmployeeGroupID = $get('" & oF_EmployeeGroupID.ClientID & "');"
		mStr = mStr & vbCrLf &	"  var F_EmployeeGroupID_Display = $get('" & oF_EmployeeGroupID_Display.ClientID & "');"
		mStr = mStr & vbCrLf &	"  var retval = e.get_value();"
		mStr = mStr & vbCrLf &	"  var p = retval.split('|');"
		mStr = mStr & vbCrLf &	"  F_EmployeeGroupID.value = p[0];"
		mStr = mStr & vbCrLf &	"  F_EmployeeGroupID_Display.innerHTML = e.get_text();"
		mStr = mStr & vbCrLf &	"},"
		mStr = mStr & vbCrLf &	"ACEEmployeeGroupID_Populating: function(o,e) {"
		mStr = mStr & vbCrLf &	"  var p = o.get_element();"
		mStr = mStr & vbCrLf &	"  p.style.backgroundImage = 'url(../../images/loader.gif)';"
		mStr = mStr & vbCrLf &	"  p.style.backgroundRepeat = 'no-repeat';"
		mStr = mStr & vbCrLf &	"  p.style.backgroundPosition = 'right';"
		mStr = mStr & vbCrLf &	"  o._contextKey = '';"
		mStr = mStr & vbCrLf &	"},"
		mStr = mStr & vbCrLf &	"ACEEmployeeGroupID_Populated: function(o,e) {"
		mStr = mStr & vbCrLf &	"  var p = o.get_element();"
		mStr = mStr & vbCrLf &	"  p.style.backgroundImage  = 'none';"
		mStr = mStr & vbCrLf &	"},"
		mStr = mStr & vbCrLf &	"validate_InspectorGroupID: function(o) {"
		mStr = mStr & vbCrLf &	"    this.validated_FK_QCM_IE_InspectorGroupID_main = true;"
		mStr = mStr & vbCrLf &	"    this.validate_FK_QCM_IE_InspectorGroupID(o);"
		mStr = mStr & vbCrLf &	"  },"
		mStr = mStr & vbCrLf &	"validate_EmployeeGroupID: function(o) {"
		mStr = mStr & vbCrLf &	"    this.validated_FK_QCM_IE_EmployeeGroupID_main = true;"
		mStr = mStr & vbCrLf &	"    this.validate_FK_QCM_IE_EmployeeGroupID(o);"
		mStr = mStr & vbCrLf &	"  },"
		Dim FK_QCM_IE_EmployeeGroupIDEmployeeGroupID As TextBox = FVqcmIGvsEG.FindControl("F_EmployeeGroupID")
		mStr = mStr & vbCrLf &	"validate_FK_QCM_IE_EmployeeGroupID: function(o) {"
		mStr = mStr & vbCrLf &	"  var value = o.id;"
		mStr = mStr & vbCrLf &	"  var EmployeeGroupID = $get('" & FK_QCM_IE_EmployeeGroupIDEmployeeGroupID.ClientID & "');"
		mStr = mStr & vbCrLf &	"  if(EmployeeGroupID.value==''){"
		mStr = mStr & vbCrLf &	"    if(this.validated_FK_QCM_IE_EmployeeGroupID_main){"
		mStr = mStr & vbCrLf &	"      var o_d = $get(o.id +'_Display');"
		mStr = mStr & vbCrLf &	"      try{o_d.innerHTML = '';}catch(ex){}"
		mStr = mStr & vbCrLf &	"    }"
		mStr = mStr & vbCrLf &	"    return true;"
		mStr = mStr & vbCrLf &	"  }"
		mStr = mStr & vbCrLf &	"  value = value + ',' + EmployeeGroupID.value ;"
		mStr = mStr & vbCrLf &	"  o.style.backgroundImage  = 'url(../../images/pkloader.gif)';"
		mStr = mStr & vbCrLf &	"  o.style.backgroundRepeat= 'no-repeat';"
		mStr = mStr & vbCrLf &	"  o.style.backgroundPosition = 'right';"
		mStr = mStr & vbCrLf &	"  PageMethods.validate_FK_QCM_IE_EmployeeGroupID(value, this.validated_FK_QCM_IE_EmployeeGroupID);"
		mStr = mStr & vbCrLf &	"},"
		mStr = mStr & vbCrLf &	"validated_FK_QCM_IE_EmployeeGroupID_main: false,"
		mStr = mStr & vbCrLf &	"validated_FK_QCM_IE_EmployeeGroupID: function(result) {"
		mStr = mStr & vbCrLf &	"  var p = result.split('|');"
		mStr = mStr & vbCrLf &	"  var o = $get(p[1]);"
		mStr = mStr & vbCrLf &	"  if(script_qcmIGvsEG.validated_FK_QCM_IE_EmployeeGroupID_main){"
		mStr = mStr & vbCrLf &	"    var o_d = $get(p[1]+'_Display');"
		mStr = mStr & vbCrLf &	"    try{o_d.innerHTML = p[2];}catch(ex){}"
		mStr = mStr & vbCrLf &	"  }"
		mStr = mStr & vbCrLf &	"  o.style.backgroundImage  = 'none';"
		mStr = mStr & vbCrLf &	"  if(p[0]=='1'){"
		mStr = mStr & vbCrLf &	"    o.value='';"
		mStr = mStr & vbCrLf &	"    o.focus();"
		mStr = mStr & vbCrLf &	"  }"
		mStr = mStr & vbCrLf &	"},"
		Dim FK_QCM_IE_InspectorGroupIDInspectorGroupID As TextBox = FVqcmIGvsEG.FindControl("F_InspectorGroupID")
		mStr = mStr & vbCrLf &	"validate_FK_QCM_IE_InspectorGroupID: function(o) {"
		mStr = mStr & vbCrLf &	"  var value = o.id;"
		mStr = mStr & vbCrLf &	"  var InspectorGroupID = $get('" & FK_QCM_IE_InspectorGroupIDInspectorGroupID.ClientID & "');"
		mStr = mStr & vbCrLf &	"  if(InspectorGroupID.value==''){"
		mStr = mStr & vbCrLf &	"    if(this.validated_FK_QCM_IE_InspectorGroupID_main){"
		mStr = mStr & vbCrLf &	"      var o_d = $get(o.id +'_Display');"
		mStr = mStr & vbCrLf &	"      try{o_d.innerHTML = '';}catch(ex){}"
		mStr = mStr & vbCrLf &	"    }"
		mStr = mStr & vbCrLf &	"    return true;"
		mStr = mStr & vbCrLf &	"  }"
		mStr = mStr & vbCrLf &	"  value = value + ',' + InspectorGroupID.value ;"
		mStr = mStr & vbCrLf &	"  o.style.backgroundImage  = 'url(../../images/pkloader.gif)';"
		mStr = mStr & vbCrLf &	"  o.style.backgroundRepeat= 'no-repeat';"
		mStr = mStr & vbCrLf &	"  o.style.backgroundPosition = 'right';"
		mStr = mStr & vbCrLf &	"  PageMethods.validate_FK_QCM_IE_InspectorGroupID(value, this.validated_FK_QCM_IE_InspectorGroupID);"
		mStr = mStr & vbCrLf &	"},"
		mStr = mStr & vbCrLf &	"validated_FK_QCM_IE_InspectorGroupID_main: false,"
		mStr = mStr & vbCrLf &	"validated_FK_QCM_IE_InspectorGroupID: function(result) {"
		mStr = mStr & vbCrLf &	"  var p = result.split('|');"
		mStr = mStr & vbCrLf &	"  var o = $get(p[1]);"
		mStr = mStr & vbCrLf &	"  if(script_qcmIGvsEG.validated_FK_QCM_IE_InspectorGroupID_main){"
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
		If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmIGvsEG") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmIGvsEG", mStr)
		End If
  End Sub
	<System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_QCM_IE_EmployeeGroupID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
		Dim EmployeeGroupID As Int32 = CType(aVal(1),Int32)
		Dim oVar As SIS.QCM.qcmEmployeeGroups = SIS.QCM.qcmEmployeeGroups.qcmEmployeeGroupsGetByID(EmployeeGroupID)
    If oVar Is Nothing Then
			mRet = "1|" & aVal(0) & "|Record not found." 
    Else
			mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
	<System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_QCM_IE_InspectorGroupID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
		Dim InspectorGroupID As Int32 = CType(aVal(1),Int32)
		Dim oVar As SIS.QCM.qcmInspectorGroups = SIS.QCM.qcmInspectorGroups.qcmInspectorGroupsGetByID(InspectorGroupID)
    If oVar Is Nothing Then
			mRet = "1|" & aVal(0) & "|Record not found." 
    Else
			mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
End Class
