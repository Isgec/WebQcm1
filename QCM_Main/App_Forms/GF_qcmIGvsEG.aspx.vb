Partial Class GF_qcmIGvsEG
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/QCM_Main/App_Display/DF_qcmIGvsEG.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?InspectorGroupID=" & aVal(0) & "&EmployeeGroupID=" & aVal(1)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVqcmIGvsEG_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVqcmIGvsEG.RowCommand
		If e.CommandName.ToLower = "lgedit".ToLower Then
			Try
				Dim InspectorGroupID As Int32 = GVqcmIGvsEG.DataKeys(e.CommandArgument).Values("InspectorGroupID")  
				Dim EmployeeGroupID As Int32 = GVqcmIGvsEG.DataKeys(e.CommandArgument).Values("EmployeeGroupID")  
				Dim RedirectUrl As String = TBLqcmIGvsEG.EditUrl & "?InspectorGroupID=" & InspectorGroupID & "&EmployeeGroupID=" & EmployeeGroupID
				Response.Redirect(RedirectUrl)
			Catch ex As Exception
			End Try
		End If
  End Sub
  Protected Sub GVqcmIGvsEG_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVqcmIGvsEG.Init
    DataClassName = "GqcmIGvsEG"
    SetGridView = GVqcmIGvsEG
  End Sub
  Protected Sub TBLqcmIGvsEG_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmIGvsEG.Init
    SetToolBar = TBLqcmIGvsEG
  End Sub
  Protected Sub F_InspectorGroupID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_InspectorGroupID.TextChanged
    Session("F_InspectorGroupID") = F_InspectorGroupID.Text
    Session("F_InspectorGroupID_Display") = F_InspectorGroupID_Display.Text
    InitGridPage()
  End Sub
	<System.Web.Services.WebMethod()> _
	<System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function InspectorGroupIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.QCM.qcmInspectorGroups.SelectqcmInspectorGroupsAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub F_EmployeeGroupID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_EmployeeGroupID.TextChanged
    Session("F_EmployeeGroupID") = F_EmployeeGroupID.Text
    Session("F_EmployeeGroupID_Display") = F_EmployeeGroupID_Display.Text
    InitGridPage()
  End Sub
	<System.Web.Services.WebMethod()> _
	<System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function EmployeeGroupIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.QCM.qcmEmployeeGroups.SelectqcmEmployeeGroupsAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
    F_InspectorGroupID_Display.Text = String.Empty
    If Not Session("F_InspectorGroupID_Display") Is Nothing Then
      If Session("F_InspectorGroupID_Display") <> String.Empty Then
        F_InspectorGroupID_Display.Text = Session("F_InspectorGroupID_Display")
      End If
    End If
    F_InspectorGroupID.Text = String.Empty
    If Not Session("F_InspectorGroupID") Is Nothing Then
      If Session("F_InspectorGroupID") <> String.Empty Then
        F_InspectorGroupID.Text = Session("F_InspectorGroupID")
      End If
    End If
		Dim strScriptInspectorGroupID As String = "<script type=""text/javascript""> " & _
			"function ACEInspectorGroupID_Selected(sender, e) {" & _
			"  var F_InspectorGroupID = $get('" & F_InspectorGroupID.ClientID & "');" & _
			"  var F_InspectorGroupID_Display = $get('" & F_InspectorGroupID_Display.ClientID & "');" & _
			"  var retval = e.get_value();" & _
			"  var p = retval.split('|');" & _
			"  F_InspectorGroupID.value = p[0];" & _
			"  F_InspectorGroupID_Display.innerHTML = e.get_text();" & _
			"}" & _
			"</script>"
			If Not Page.ClientScript.IsClientScriptBlockRegistered("F_InspectorGroupID") Then
				Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_InspectorGroupID", strScriptInspectorGroupID)
			End If
		Dim strScriptPopulatingInspectorGroupID As String = "<script type=""text/javascript""> " & _
			"function ACEInspectorGroupID_Populating(o,e) {" & _
			"  var p = $get('" & F_InspectorGroupID.ClientID & "');" & _
			"  p.style.backgroundImage  = 'url(../../images/loader.gif)';" & _
			"  p.style.backgroundRepeat= 'no-repeat';" & _
			"  p.style.backgroundPosition = 'right';" & _
			"  o._contextKey = '';" & _
			"}" & _
			"function ACEInspectorGroupID_Populated(o,e) {" & _
			"  var p = $get('" & F_InspectorGroupID.ClientID & "');" & _
			"  p.style.backgroundImage  = 'none';" & _
			"}" & _
			"</script>"
			If Not Page.ClientScript.IsClientScriptBlockRegistered("F_InspectorGroupIDPopulating") Then
				Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_InspectorGroupIDPopulating", strScriptPopulatingInspectorGroupID)
			End If
    F_EmployeeGroupID_Display.Text = String.Empty
    If Not Session("F_EmployeeGroupID_Display") Is Nothing Then
      If Session("F_EmployeeGroupID_Display") <> String.Empty Then
        F_EmployeeGroupID_Display.Text = Session("F_EmployeeGroupID_Display")
      End If
    End If
    F_EmployeeGroupID.Text = String.Empty
    If Not Session("F_EmployeeGroupID") Is Nothing Then
      If Session("F_EmployeeGroupID") <> String.Empty Then
        F_EmployeeGroupID.Text = Session("F_EmployeeGroupID")
      End If
    End If
		Dim strScriptEmployeeGroupID As String = "<script type=""text/javascript""> " & _
			"function ACEEmployeeGroupID_Selected(sender, e) {" & _
			"  var F_EmployeeGroupID = $get('" & F_EmployeeGroupID.ClientID & "');" & _
			"  var F_EmployeeGroupID_Display = $get('" & F_EmployeeGroupID_Display.ClientID & "');" & _
			"  var retval = e.get_value();" & _
			"  var p = retval.split('|');" & _
			"  F_EmployeeGroupID.value = p[0];" & _
			"  F_EmployeeGroupID_Display.innerHTML = e.get_text();" & _
			"}" & _
			"</script>"
			If Not Page.ClientScript.IsClientScriptBlockRegistered("F_EmployeeGroupID") Then
				Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_EmployeeGroupID", strScriptEmployeeGroupID)
			End If
		Dim strScriptPopulatingEmployeeGroupID As String = "<script type=""text/javascript""> " & _
			"function ACEEmployeeGroupID_Populating(o,e) {" & _
			"  var p = $get('" & F_EmployeeGroupID.ClientID & "');" & _
			"  p.style.backgroundImage  = 'url(../../images/loader.gif)';" & _
			"  p.style.backgroundRepeat= 'no-repeat';" & _
			"  p.style.backgroundPosition = 'right';" & _
			"  o._contextKey = '';" & _
			"}" & _
			"function ACEEmployeeGroupID_Populated(o,e) {" & _
			"  var p = $get('" & F_EmployeeGroupID.ClientID & "');" & _
			"  p.style.backgroundImage  = 'none';" & _
			"}" & _
			"</script>"
			If Not Page.ClientScript.IsClientScriptBlockRegistered("F_EmployeeGroupIDPopulating") Then
				Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_EmployeeGroupIDPopulating", strScriptPopulatingEmployeeGroupID)
			End If
		Dim validateScriptInspectorGroupID As String = "<script type=""text/javascript"">" & _
			"  function validate_InspectorGroupID(o) {" & _
			"    validated_FK_QCM_IE_InspectorGroupID_main = true;" & _
			"    validate_FK_QCM_IE_InspectorGroupID(o);" & _
			"  }" & _
		  "</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("validateInspectorGroupID") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateInspectorGroupID", validateScriptInspectorGroupID)
		End If
		Dim validateScriptEmployeeGroupID As String = "<script type=""text/javascript"">" & _
			"  function validate_EmployeeGroupID(o) {" & _
			"    validated_FK_QCM_IE_EmployeeGroupID_main = true;" & _
			"    validate_FK_QCM_IE_EmployeeGroupID(o);" & _
			"  }" & _
		  "</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("validateEmployeeGroupID") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateEmployeeGroupID", validateScriptEmployeeGroupID)
		End If
		Dim validateScriptFK_QCM_IE_EmployeeGroupID As String = "<script type=""text/javascript"">" & _
			"  function validate_FK_QCM_IE_EmployeeGroupID(o) {" & _
			"    var value = o.id;" & _
			"    var EmployeeGroupID = $get('" & F_EmployeeGroupID.ClientID & "');" & _
			"    try{" & _
			"    if(EmployeeGroupID.value==''){" & _
			"      if(validated_FK_QCM_IE_EmployeeGroupID.main){" & _
			"        var o_d = $get(o.id +'_Display');" & _
			"        try{o_d.innerHTML = '';}catch(ex){}" & _
			"      }" & _
			"    }" & _
			"    value = value + ',' + EmployeeGroupID.value ;" & _
			"    }catch(ex){}" & _
			"    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" & _
			"    o.style.backgroundRepeat= 'no-repeat';" & _
			"    o.style.backgroundPosition = 'right';" & _
			"    PageMethods.validate_FK_QCM_IE_EmployeeGroupID(value, validated_FK_QCM_IE_EmployeeGroupID);" & _
			"  }" & _
			"  validated_FK_QCM_IE_EmployeeGroupID_main = false;" & _
			"  function validated_FK_QCM_IE_EmployeeGroupID(result) {" & _
			"    var p = result.split('|');" & _
			"    var o = $get(p[1]);" & _
			"    var o_d = $get(p[1]+'_Display');" & _
			"    try{o_d.innerHTML = p[2];}catch(ex){}" & _
			"    o.style.backgroundImage  = 'none';" & _
			"    if(p[0]=='1'){" & _
			"      o.value='';" & _
			"      try{o_d.innerHTML = '';}catch(ex){}" & _
			"      __doPostBack(o.id, o.value);" & _
			"    }" & _
			"    else" & _
			"      __doPostBack(o.id, o.value);" & _
			"  }" & _
		  "</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_QCM_IE_EmployeeGroupID") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_QCM_IE_EmployeeGroupID", validateScriptFK_QCM_IE_EmployeeGroupID)
		End If
		Dim validateScriptFK_QCM_IE_InspectorGroupID As String = "<script type=""text/javascript"">" & _
			"  function validate_FK_QCM_IE_InspectorGroupID(o) {" & _
			"    var value = o.id;" & _
			"    var InspectorGroupID = $get('" & F_InspectorGroupID.ClientID & "');" & _
			"    try{" & _
			"    if(InspectorGroupID.value==''){" & _
			"      if(validated_FK_QCM_IE_InspectorGroupID.main){" & _
			"        var o_d = $get(o.id +'_Display');" & _
			"        try{o_d.innerHTML = '';}catch(ex){}" & _
			"      }" & _
			"    }" & _
			"    value = value + ',' + InspectorGroupID.value ;" & _
			"    }catch(ex){}" & _
			"    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" & _
			"    o.style.backgroundRepeat= 'no-repeat';" & _
			"    o.style.backgroundPosition = 'right';" & _
			"    PageMethods.validate_FK_QCM_IE_InspectorGroupID(value, validated_FK_QCM_IE_InspectorGroupID);" & _
			"  }" & _
			"  validated_FK_QCM_IE_InspectorGroupID_main = false;" & _
			"  function validated_FK_QCM_IE_InspectorGroupID(result) {" & _
			"    var p = result.split('|');" & _
			"    var o = $get(p[1]);" & _
			"    var o_d = $get(p[1]+'_Display');" & _
			"    try{o_d.innerHTML = p[2];}catch(ex){}" & _
			"    o.style.backgroundImage  = 'none';" & _
			"    if(p[0]=='1'){" & _
			"      o.value='';" & _
			"      try{o_d.innerHTML = '';}catch(ex){}" & _
			"      __doPostBack(o.id, o.value);" & _
			"    }" & _
			"    else" & _
			"      __doPostBack(o.id, o.value);" & _
			"  }" & _
		  "</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_QCM_IE_InspectorGroupID") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_QCM_IE_InspectorGroupID", validateScriptFK_QCM_IE_InspectorGroupID)
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
