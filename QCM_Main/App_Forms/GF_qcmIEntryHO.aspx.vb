Partial Class GF_qcmIEntryHO
  Inherits SIS.SYS.GridBase
	Protected Sub GVqcmIEntryHO_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVqcmIEntryHO.RowCommand
		If e.CommandName.ToLower = "lgedit".ToLower Then
			Try
				Dim RequestID As Int32 = GVqcmIEntryHO.DataKeys(e.CommandArgument).Values("RequestID")
				Dim RedirectUrl As String = TBLqcmIEntryHO.EditUrl & "?RequestID=" & RequestID
				Response.Redirect(RedirectUrl)
			Catch ex As Exception
			End Try
		End If
		If e.CommandName.ToLower = "lgclose".ToLower Then
			Try
				Dim RequestID As Int32 = GVqcmIEntryHO.DataKeys(e.CommandArgument).Values("RequestID")
				Dim InspectionStatusID As String = CType(GVqcmIEntryHO.Rows(e.CommandArgument).FindControl("F_InspectionStatusID"), LC_qcmInspectionStatus).SelectedValue
				If InspectionStatusID <> String.Empty Then
					If SIS.QCM.qcmRequests.CloseInspectionRequest(RequestID, InspectionStatusID) Then
						GVqcmIEntryHO.DataBind()
					End If
				End If
			Catch ex As Exception
			End Try
		End If
		If e.CommandName.ToLower = "lgreturn".ToLower Then
			Try
				Dim RequestID As Int32 = GVqcmIEntryHO.DataKeys(e.CommandArgument).Values("RequestID")
				If SIS.QCM.qcmRequests.ReturnToAllotment(RequestID) Then
					GVqcmIEntryHO.DataBind()
				End If
			Catch ex As Exception
			End Try
		End If
	End Sub
  Protected Sub GVqcmIEntryHO_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVqcmIEntryHO.Init
    DataClassName = "GqcmIEntryHO"
    SetGridView = GVqcmIEntryHO
  End Sub
  Protected Sub TBLqcmIEntryHO_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmIEntryHO.Init
    SetToolBar = TBLqcmIEntryHO
  End Sub
  Protected Sub F_ProjectID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_ProjectID.TextChanged
    Session("F_ProjectID") = F_ProjectID.Text
    Session("F_ProjectID_Display") = F_ProjectID_Display.Text
    InitGridPage()
  End Sub
	<System.Web.Services.WebMethod()> _
	<System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function ProjectIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.QCM.qcmProjects.SelectqcmProjectsAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub F_SupplierID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_SupplierID.TextChanged
    Session("F_SupplierID") = F_SupplierID.Text
    Session("F_SupplierID_Display") = F_SupplierID_Display.Text
    InitGridPage()
  End Sub
	Protected Sub F_AllotedTo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_AllotedTo.TextChanged
		Session("F_AllotedTo") = F_AllotedTo.Text
		Session("F_AllotedTo_Display") = F_AllotedTo_Display.Text
		InitGridPage()
	End Sub
	<System.Web.Services.WebMethod()> _
	<System.Web.Script.Services.ScriptMethod()> _
	 Public Shared Function SupplierIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
		Return SIS.QCM.qcmVendors.SelectqcmVendorsAutoCompleteList(prefixText, count, contextKey)
	End Function
	<System.Web.Services.WebMethod()> _
	<System.Web.Script.Services.ScriptMethod()> _
	 Public Shared Function AllotedToCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
		Return SIS.QCM.qcmEmployees.SelectqcmAllotedToAutoCompleteList(prefixText, count, contextKey)
	End Function
	Protected Sub F_RequestStateID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_RequestStateID.SelectedIndexChanged
		Session("F_RequestStateID") = F_RequestStateID.SelectedValue
		InitGridPage()
	End Sub
	Protected Sub F_InspectionStatusID_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_InspectionStatusID.SelectedIndexChanged
		Session("F_InspectionStatusID") = F_InspectionStatusID.SelectedValue
		InitGridPage()
	End Sub
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
		F_ProjectID_Display.Text = String.Empty
		If Not Session("F_ProjectID_Display") Is Nothing Then
			If Session("F_ProjectID_Display") <> String.Empty Then
				F_ProjectID_Display.Text = Session("F_ProjectID_Display")
			End If
		End If
		F_ProjectID.Text = String.Empty
		If Not Session("F_ProjectID") Is Nothing Then
			If Session("F_ProjectID") <> String.Empty Then
				F_ProjectID.Text = Session("F_ProjectID")
			End If
		End If
		Dim strScriptProjectID As String = "<script type=""text/javascript""> " & _
		 "function ACEProjectID_Selected(sender, e) {" & _
		 "  var F_ProjectID = $get('" & F_ProjectID.ClientID & "');" & _
		 "  var F_ProjectID_Display = $get('" & F_ProjectID_Display.ClientID & "');" & _
		 "  var retval = e.get_value();" & _
		 "  var p = retval.split('|');" & _
		 "  F_ProjectID.value = p[0];" & _
		 "  F_ProjectID_Display.innerHTML = e.get_text();" & _
		 "}" & _
		 "</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("F_ProjectID") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_ProjectID", strScriptProjectID)
		End If
		Dim strScriptPopulatingProjectID As String = "<script type=""text/javascript""> " & _
		 "function ACEProjectID_Populating(o,e) {" & _
		 "  var p = $get('" & F_ProjectID.ClientID & "');" & _
		 "  p.style.backgroundImage  = 'url(../../images/loader.gif)';" & _
		 "  p.style.backgroundRepeat= 'no-repeat';" & _
		 "  p.style.backgroundPosition = 'right';" & _
		 "  o._contextKey = '';" & _
		 "}" & _
		 "function ACEProjectID_Populated(o,e) {" & _
		 "  var p = $get('" & F_ProjectID.ClientID & "');" & _
		 "  p.style.backgroundImage  = 'none';" & _
		 "}" & _
		 "</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("F_ProjectIDPopulating") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_ProjectIDPopulating", strScriptPopulatingProjectID)
		End If
		F_SupplierID_Display.Text = String.Empty
		If Not Session("F_SupplierID_Display") Is Nothing Then
			If Session("F_SupplierID_Display") <> String.Empty Then
				F_SupplierID_Display.Text = Session("F_SupplierID_Display")
			End If
		End If
		F_SupplierID.Text = String.Empty
		If Not Session("F_SupplierID") Is Nothing Then
			If Session("F_SupplierID") <> String.Empty Then
				F_SupplierID.Text = Session("F_SupplierID")
			End If
		End If
		Dim strScriptSupplierID As String = "<script type=""text/javascript""> " & _
		 "function ACESupplierID_Selected(sender, e) {" & _
		 "  var F_SupplierID = $get('" & F_SupplierID.ClientID & "');" & _
		 "  var F_SupplierID_Display = $get('" & F_SupplierID_Display.ClientID & "');" & _
		 "  var retval = e.get_value();" & _
		 "  var p = retval.split('|');" & _
		 "  F_SupplierID.value = p[0];" & _
		 "  F_SupplierID_Display.innerHTML = e.get_text();" & _
		 "}" & _
		 "</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("F_SupplierID") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_SupplierID", strScriptSupplierID)
		End If
		Dim strScriptPopulatingSupplierID As String = "<script type=""text/javascript""> " & _
		 "function ACESupplierID_Populating(o,e) {" & _
		 "  var p = $get('" & F_SupplierID.ClientID & "');" & _
		 "  p.style.backgroundImage  = 'url(../../images/loader.gif)';" & _
		 "  p.style.backgroundRepeat= 'no-repeat';" & _
		 "  p.style.backgroundPosition = 'right';" & _
		 "  o._contextKey = '';" & _
		 "}" & _
		 "function ACESupplierID_Populated(o,e) {" & _
		 "  var p = $get('" & F_SupplierID.ClientID & "');" & _
		 "  p.style.backgroundImage  = 'none';" & _
		 "}" & _
		 "</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("F_SupplierIDPopulating") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_SupplierIDPopulating", strScriptPopulatingSupplierID)
		End If
		F_AllotedTo_Display.Text = String.Empty
		If Not Session("F_AllotedTo_Display") Is Nothing Then
			If Session("F_AllotedTo_Display") <> String.Empty Then
				F_AllotedTo_Display.Text = Session("F_AllotedTo_Display")
			End If
		End If
		F_AllotedTo.Text = String.Empty
		If Not Session("F_AllotedTo") Is Nothing Then
			If Session("F_AllotedTo") <> String.Empty Then
				F_AllotedTo.Text = Session("F_AllotedTo")
			End If
		End If
		Dim strScriptAllotedTo As String = "<script type=""text/javascript""> " & _
		 "function ACEAllotedTo_Selected(sender, e) {" & _
		 "  var F_AllotedTo = $get('" & F_AllotedTo.ClientID & "');" & _
		 "  var F_AllotedTo_Display = $get('" & F_AllotedTo_Display.ClientID & "');" & _
		 "  var retval = e.get_value();" & _
		 "  var p = retval.split('|');" & _
		 "  F_AllotedTo.value = p[0];" & _
		 "  F_AllotedTo_Display.innerHTML = e.get_text();" & _
		 "}" & _
		 "</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("F_AllotedTo") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_AllotedTo", strScriptAllotedTo)
		End If
		Dim strScriptPopulatingAllotedTo As String = "<script type=""text/javascript""> " & _
		 "function ACEAllotedTo_Populating(o,e) {" & _
		 "  var p = $get('" & F_AllotedTo.ClientID & "');" & _
		 "  p.style.backgroundImage  = 'url(../../images/loader.gif)';" & _
		 "  p.style.backgroundRepeat= 'no-repeat';" & _
		 "  p.style.backgroundPosition = 'right';" & _
		 "  o._contextKey = '';" & _
		 "}" & _
		 "function ACEAllotedTo_Populated(o,e) {" & _
		 "  var p = $get('" & F_AllotedTo.ClientID & "');" & _
		 "  p.style.backgroundImage  = 'none';" & _
		 "}" & _
		 "</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("F_AllotedToPopulating") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_AllotedToPopulating", strScriptPopulatingAllotedTo)
		End If
		F_RequestStateID.SelectedValue = String.Empty
		If Not Session("F_RequestStateID") Is Nothing Then
			If Session("F_RequestStateID") <> String.Empty Then
				F_RequestStateID.SelectedValue = Session("F_RequestStateID")
			End If
		End If
		F_InspectionStatusID.SelectedValue = String.Empty
		If Not Session("F_InspectionStatusID") Is Nothing Then
			If Session("F_InspectionStatusID") <> String.Empty Then
				F_InspectionStatusID.SelectedValue = Session("F_InspectionStatusID")
			End If
		End If
		Dim validateScriptProjectID As String = "<script type=""text/javascript"">" & _
		 "  function validate_ProjectID(o) {" & _
		 "    validated_FK_QCM_Requests_ProjectID_main = true;" & _
		 "    validate_FK_QCM_Requests_ProjectID(o);" & _
		 "  }" & _
		 "</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("validateProjectID") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateProjectID", validateScriptProjectID)
		End If
		Dim validateScriptSupplierID As String = "<script type=""text/javascript"">" & _
		 "  function validate_SupplierID(o) {" & _
		 "    validated_FK_QCM_Requests_SupplierID_main = true;" & _
		 "    validate_FK_QCM_Requests_SupplierID(o);" & _
		 "  }" & _
		 "</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("validateSupplierID") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateSupplierID", validateScriptSupplierID)
		End If
		Dim validateScriptAllotedTo As String = "<script type=""text/javascript"">" & _
		 "  function validate_AllotedTo(o) {" & _
		 "    validated_FK_QCM_Requests_AllotedTo_main = true;" & _
		 "    validate_FK_QCM_Requests_AllotedTo(o);" & _
		 "  }" & _
		 "</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("validateAllotedTo") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateAllotedTo", validateScriptAllotedTo)
		End If
		Dim validateScriptFK_QCM_Requests_ProjectID As String = "<script type=""text/javascript"">" & _
		 "  function validate_FK_QCM_Requests_ProjectID(o) {" & _
		 "    var value = o.id;" & _
		 "    var ProjectID = $get('" & F_ProjectID.ClientID & "');" & _
		 "    try{" & _
		 "    if(ProjectID.value==''){" & _
		 "      if(validated_FK_QCM_Requests_ProjectID.main){" & _
		 "        var o_d = $get(o.id +'_Display');" & _
		 "        try{o_d.innerHTML = '';}catch(ex){}" & _
		 "      }" & _
		 "    }" & _
		 "    value = value + ',' + ProjectID.value ;" & _
		 "    }catch(ex){}" & _
		 "    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" & _
		 "    o.style.backgroundRepeat= 'no-repeat';" & _
		 "    o.style.backgroundPosition = 'right';" & _
		 "    PageMethods.validate_FK_QCM_Requests_ProjectID(value, validated_FK_QCM_Requests_ProjectID);" & _
		 "  }" & _
		 "  validated_FK_QCM_Requests_ProjectID_main = false;" & _
		 "  function validated_FK_QCM_Requests_ProjectID(result) {" & _
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
		If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_QCM_Requests_ProjectID") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_QCM_Requests_ProjectID", validateScriptFK_QCM_Requests_ProjectID)
		End If
		Dim validateScriptFK_QCM_Requests_SupplierID As String = "<script type=""text/javascript"">" & _
		 "  function validate_FK_QCM_Requests_SupplierID(o) {" & _
		 "    var value = o.id;" & _
		 "    var SupplierID = $get('" & F_SupplierID.ClientID & "');" & _
		 "    try{" & _
		 "    if(SupplierID.value==''){" & _
		 "      if(validated_FK_QCM_Requests_SupplierID.main){" & _
		 "        var o_d = $get(o.id +'_Display');" & _
		 "        try{o_d.innerHTML = '';}catch(ex){}" & _
		 "      }" & _
		 "    }" & _
		 "    value = value + ',' + SupplierID.value ;" & _
		 "    }catch(ex){}" & _
		 "    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" & _
		 "    o.style.backgroundRepeat= 'no-repeat';" & _
		 "    o.style.backgroundPosition = 'right';" & _
		 "    PageMethods.validate_FK_QCM_Requests_SupplierID(value, validated_FK_QCM_Requests_SupplierID);" & _
		 "  }" & _
		 "  validated_FK_QCM_Requests_SupplierID_main = false;" & _
		 "  function validated_FK_QCM_Requests_SupplierID(result) {" & _
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
		If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_QCM_Requests_SupplierID") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_QCM_Requests_SupplierID", validateScriptFK_QCM_Requests_SupplierID)
		End If
		Dim validateScriptFK_QCM_Requests_AllotedTo As String = "<script type=""text/javascript"">" & _
		 "  function validate_FK_QCM_Requests_AllotedTo(o) {" & _
		 "    var value = o.id;" & _
		 "    var AllotedTo = $get('" & F_AllotedTo.ClientID & "');" & _
		 "    try{" & _
		 "    if(AllotedTo.value==''){" & _
		 "      if(validated_FK_QCM_Requests_AllotedTo.main){" & _
		 "        var o_d = $get(o.id +'_Display');" & _
		 "        try{o_d.innerHTML = '';}catch(ex){}" & _
		 "      }" & _
		 "    }" & _
		 "    value = value + ',' + AllotedTo.value ;" & _
		 "    }catch(ex){}" & _
		 "    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" & _
		 "    o.style.backgroundRepeat= 'no-repeat';" & _
		 "    o.style.backgroundPosition = 'right';" & _
		 "    PageMethods.validate_FK_QCM_Requests_AllotedTo(value, validated_FK_QCM_Requests_AllotedTo);" & _
		 "  }" & _
		 "  validated_FK_QCM_Requests_AllotedTo_main = false;" & _
		 "  function validated_FK_QCM_Requests_AllotedTo(result) {" & _
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
		If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_QCM_Requests_AllotedTo") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_QCM_Requests_AllotedTo", validateScriptFK_QCM_Requests_AllotedTo)
		End If
	End Sub
	<System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_QCM_Requests_ProjectID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
		Dim ProjectID As String = CType(aVal(1),String)
		Dim oVar As SIS.QCM.qcmProjects = SIS.QCM.qcmProjects.qcmProjectsGetByID(ProjectID)
    If oVar Is Nothing Then
			mRet = "1|" & aVal(0) & "|Record not found." 
    Else
			mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
	<System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_QCM_Requests_SupplierID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
		Dim SupplierID As String = CType(aVal(1),String)
		Dim oVar As SIS.QCM.qcmVendors = SIS.QCM.qcmVendors.qcmVendorsGetByID(SupplierID)
    If oVar Is Nothing Then
			mRet = "1|" & aVal(0) & "|Record not found." 
    Else
			mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
	<System.Web.Services.WebMethod()> _
	 Public Shared Function validate_FK_QCM_Requests_AllotedTo(ByVal value As String) As String
		Dim aVal() As String = value.Split(",".ToCharArray)
		Dim mRet As String = "0|" & aVal(0)
		Dim AllotedTo As String = CType(aVal(1), String)
    Dim oVar As SIS.QCM.qcmUsers = SIS.QCM.qcmEmployees.qcmAllotedToGetByID(AllotedTo)
    If oVar Is Nothing Then
			mRet = "1|" & aVal(0) & "|Record not found."
		Else
			mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
		End If
		Return mRet
	End Function
End Class
