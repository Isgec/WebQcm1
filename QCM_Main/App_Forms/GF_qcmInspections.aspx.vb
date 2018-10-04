Partial Class GF_qcmInspections
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/QCM_Main/App_Display/DF_qcmInspections.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?RequestID=" & aVal(0) & "&InspectionID=" & aVal(1)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVqcmInspections_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVqcmInspections.RowCommand
		If e.CommandName.ToLower = "lgedit".ToLower Then
			Try
				Dim RequestID As Int32 = GVqcmInspections.DataKeys(e.CommandArgument).Values("RequestID")  
				Dim InspectionID As Int32 = GVqcmInspections.DataKeys(e.CommandArgument).Values("InspectionID")  
				Dim RedirectUrl As String = TBLqcmInspections.EditUrl & "?RequestID=" & RequestID & "&InspectionID=" & InspectionID
				Response.Redirect(RedirectUrl)
			Catch ex As Exception
			End Try
		End If
  End Sub
  Protected Sub GVqcmInspections_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVqcmInspections.Init
    DataClassName = "GqcmInspections"
    SetGridView = GVqcmInspections
  End Sub
  Protected Sub TBLqcmInspections_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmInspections.Init
    SetToolBar = TBLqcmInspections
  End Sub
  Protected Sub F_RequestID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_RequestID.TextChanged
    Session("F_RequestID") = F_RequestID.Text
    Session("F_RequestID_Display") = F_RequestID_Display.Text
    InitGridPage()
  End Sub
	Protected Sub F_AllotedTo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_AllotedTo.TextChanged
		Session("F_AllotedTo") = F_AllotedTo.Text
		Session("F_AllotedTo_Display") = F_AllotedTo_Display.Text
		InitGridPage()
	End Sub
	<System.Web.Services.WebMethod()> _
	<System.Web.Script.Services.ScriptMethod()> _
	 Public Shared Function RequestIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
		Return SIS.QCM.qcmRequests.SelectqcmRequestsAutoCompleteList(prefixText, count, contextKey)
	End Function
	<System.Web.Services.WebMethod()> _
	<System.Web.Script.Services.ScriptMethod()> _
	 Public Shared Function AllotedToCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
		Return SIS.QCM.qcmEmployees.SelectqcmAllotedToAutoCompleteList(prefixText, count, contextKey)
	End Function
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
		F_RequestID_Display.Text = String.Empty
		If Not Session("F_RequestID_Display") Is Nothing Then
			If Session("F_RequestID_Display") <> String.Empty Then
				F_RequestID_Display.Text = Session("F_RequestID_Display")
			End If
		End If
		F_RequestID.Text = String.Empty
		If Not Session("F_RequestID") Is Nothing Then
			If Session("F_RequestID") <> String.Empty Then
				F_RequestID.Text = Session("F_RequestID")
			End If
		End If
		Dim strScriptRequestID As String = "<script type=""text/javascript""> " & _
		 "function ACERequestID_Selected(sender, e) {" & _
		 "  var F_RequestID = $get('" & F_RequestID.ClientID & "');" & _
		 "  var F_RequestID_Display = $get('" & F_RequestID_Display.ClientID & "');" & _
		 "  var retval = e.get_value();" & _
		 "  var p = retval.split('|');" & _
		 "  F_RequestID.value = p[0];" & _
		 "  F_RequestID_Display.innerHTML = e.get_text();" & _
		 "}" & _
		 "</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("F_RequestID") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_RequestID", strScriptRequestID)
		End If
		Dim strScriptPopulatingRequestID As String = "<script type=""text/javascript""> " & _
		 "function ACERequestID_Populating(o,e) {" & _
		 "  var p = $get('" & F_RequestID.ClientID & "');" & _
		 "  p.style.backgroundImage  = 'url(../../images/loader.gif)';" & _
		 "  p.style.backgroundRepeat= 'no-repeat';" & _
		 "  p.style.backgroundPosition = 'right';" & _
		 "  o._contextKey = '';" & _
		 "}" & _
		 "function ACERequestID_Populated(o,e) {" & _
		 "  var p = $get('" & F_RequestID.ClientID & "');" & _
		 "  p.style.backgroundImage  = 'none';" & _
		 "}" & _
		 "</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("F_RequestIDPopulating") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_RequestIDPopulating", strScriptPopulatingRequestID)
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
		Dim validateScriptRequestID As String = "<script type=""text/javascript"">" & _
		 "  function validate_RequestID(o) {" & _
		 "    validated_FK_QCM_Inspections_RequestID_main = true;" & _
		 "    validate_FK_QCM_Inspections_RequestID(o);" & _
		 "  }" & _
		 "</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("validateRequestID") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateRequestID", validateScriptRequestID)
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
		Dim validateScriptFK_QCM_Inspections_RequestID As String = "<script type=""text/javascript"">" & _
		 "  function validate_FK_QCM_Inspections_RequestID(o) {" & _
		 "    var value = o.id;" & _
		 "    var RequestID = $get('" & F_RequestID.ClientID & "');" & _
		 "    try{" & _
		 "    if(RequestID.value==''){" & _
		 "      if(validated_FK_QCM_Inspections_RequestID.main){" & _
		 "        var o_d = $get(o.id +'_Display');" & _
		 "        try{o_d.innerHTML = '';}catch(ex){}" & _
		 "      }" & _
		 "    }" & _
		 "    value = value + ',' + RequestID.value ;" & _
		 "    }catch(ex){}" & _
		 "    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" & _
		 "    o.style.backgroundRepeat= 'no-repeat';" & _
		 "    o.style.backgroundPosition = 'right';" & _
		 "    PageMethods.validate_FK_QCM_Inspections_RequestID(value, validated_FK_QCM_Inspections_RequestID);" & _
		 "  }" & _
		 "  validated_FK_QCM_Inspections_RequestID_main = false;" & _
		 "  function validated_FK_QCM_Inspections_RequestID(result) {" & _
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
		If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_QCM_Inspections_RequestID") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_QCM_Inspections_RequestID", validateScriptFK_QCM_Inspections_RequestID)
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
  Public Shared Function validate_FK_QCM_Inspections_RequestID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
		Dim RequestID As Int32 = CType(aVal(1),Int32)
		Dim oVar As SIS.QCM.qcmRequests = SIS.QCM.qcmRequests.qcmRequestsGetByID(RequestID)
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
		Dim oVar As SIS.QCM.qcmEmployees = SIS.QCM.qcmEmployees.qcmAllotedToGetByID(AllotedTo)
		If oVar Is Nothing Then
			mRet = "1|" & aVal(0) & "|Record not found."
		Else
			mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
		End If
		Return mRet
	End Function
End Class
