Partial Class GF_qcmEmployeeGroupUsers
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/QCM_Main/App_Display/DF_qcmEmployeeGroupUsers.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?GroupiD=" & aVal(0) & "&CardNo=" & aVal(1)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVqcmEmployeeGroupUsers_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVqcmEmployeeGroupUsers.RowCommand
		If e.CommandName.ToLower = "lgedit".ToLower Then
			Try
				Dim GroupiD As Int32 = GVqcmEmployeeGroupUsers.DataKeys(e.CommandArgument).Values("GroupiD")  
				Dim CardNo As String = GVqcmEmployeeGroupUsers.DataKeys(e.CommandArgument).Values("CardNo")  
				Dim RedirectUrl As String = TBLqcmEmployeeGroupUsers.EditUrl & "?GroupiD=" & GroupiD & "&CardNo=" & CardNo
				Response.Redirect(RedirectUrl)
			Catch ex As Exception
			End Try
		End If
  End Sub
  Protected Sub GVqcmEmployeeGroupUsers_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVqcmEmployeeGroupUsers.Init
    DataClassName = "GqcmEmployeeGroupUsers"
    SetGridView = GVqcmEmployeeGroupUsers
  End Sub
  Protected Sub TBLqcmEmployeeGroupUsers_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmEmployeeGroupUsers.Init
    SetToolBar = TBLqcmEmployeeGroupUsers
  End Sub
  Protected Sub F_GroupiD_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_GroupiD.TextChanged
    Session("F_GroupiD") = F_GroupiD.Text
    Session("F_GroupiD_Display") = F_GroupiD_Display.Text
    InitGridPage()
  End Sub
	<System.Web.Services.WebMethod()> _
	<System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function GroupiDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.QCM.qcmEmployeeGroups.SelectqcmEmployeeGroupsAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
    F_GroupiD_Display.Text = String.Empty
    If Not Session("F_GroupiD_Display") Is Nothing Then
      If Session("F_GroupiD_Display") <> String.Empty Then
        F_GroupiD_Display.Text = Session("F_GroupiD_Display")
      End If
    End If
    F_GroupiD.Text = String.Empty
    If Not Session("F_GroupiD") Is Nothing Then
      If Session("F_GroupiD") <> String.Empty Then
        F_GroupiD.Text = Session("F_GroupiD")
      End If
    End If
		Dim strScriptGroupiD As String = "<script type=""text/javascript""> " & _
			"function ACEGroupiD_Selected(sender, e) {" & _
			"  var F_GroupiD = $get('" & F_GroupiD.ClientID & "');" & _
			"  var F_GroupiD_Display = $get('" & F_GroupiD_Display.ClientID & "');" & _
			"  var retval = e.get_value();" & _
			"  var p = retval.split('|');" & _
			"  F_GroupiD.value = p[0];" & _
			"  F_GroupiD_Display.innerHTML = e.get_text();" & _
			"}" & _
			"</script>"
			If Not Page.ClientScript.IsClientScriptBlockRegistered("F_GroupiD") Then
				Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_GroupiD", strScriptGroupiD)
			End If
		Dim strScriptPopulatingGroupiD As String = "<script type=""text/javascript""> " & _
			"function ACEGroupiD_Populating(o,e) {" & _
			"  var p = $get('" & F_GroupiD.ClientID & "');" & _
			"  p.style.backgroundImage  = 'url(../../images/loader.gif)';" & _
			"  p.style.backgroundRepeat= 'no-repeat';" & _
			"  p.style.backgroundPosition = 'right';" & _
			"  o._contextKey = '';" & _
			"}" & _
			"function ACEGroupiD_Populated(o,e) {" & _
			"  var p = $get('" & F_GroupiD.ClientID & "');" & _
			"  p.style.backgroundImage  = 'none';" & _
			"}" & _
			"</script>"
			If Not Page.ClientScript.IsClientScriptBlockRegistered("F_GroupiDPopulating") Then
				Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_GroupiDPopulating", strScriptPopulatingGroupiD)
			End If
		Dim validateScriptGroupiD As String = "<script type=""text/javascript"">" & _
			"  function validate_GroupiD(o) {" & _
			"    validated_FK_QCM_EGU_GroupID_main = true;" & _
			"    validate_FK_QCM_EGU_GroupID(o);" & _
			"  }" & _
		  "</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("validateGroupiD") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateGroupiD", validateScriptGroupiD)
		End If
		Dim validateScriptFK_QCM_EGU_GroupID As String = "<script type=""text/javascript"">" & _
			"  function validate_FK_QCM_EGU_GroupID(o) {" & _
			"    var value = o.id;" & _
			"    var GroupiD = $get('" & F_GroupiD.ClientID & "');" & _
			"    try{" & _
			"    if(GroupiD.value==''){" & _
			"      if(validated_FK_QCM_EGU_GroupID.main){" & _
			"        var o_d = $get(o.id +'_Display');" & _
			"        try{o_d.innerHTML = '';}catch(ex){}" & _
			"      }" & _
			"    }" & _
			"    value = value + ',' + GroupiD.value ;" & _
			"    }catch(ex){}" & _
			"    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" & _
			"    o.style.backgroundRepeat= 'no-repeat';" & _
			"    o.style.backgroundPosition = 'right';" & _
			"    PageMethods.validate_FK_QCM_EGU_GroupID(value, validated_FK_QCM_EGU_GroupID);" & _
			"  }" & _
			"  validated_FK_QCM_EGU_GroupID_main = false;" & _
			"  function validated_FK_QCM_EGU_GroupID(result) {" & _
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
		If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_QCM_EGU_GroupID") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_QCM_EGU_GroupID", validateScriptFK_QCM_EGU_GroupID)
		End If
  End Sub
	<System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_QCM_EGU_GroupID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
		Dim GroupiD As Int32 = CType(aVal(1),Int32)
		Dim oVar As SIS.QCM.qcmEmployeeGroups = SIS.QCM.qcmEmployeeGroups.qcmEmployeeGroupsGetByID(GroupiD)
    If oVar Is Nothing Then
			mRet = "1|" & aVal(0) & "|Record not found." 
    Else
			mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
End Class
