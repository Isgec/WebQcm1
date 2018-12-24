Imports System.Web.Script.Serialization
Partial Class GF_pakQCPO
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/PAK_Main/App_Display/DF_pakQCPO.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?SerialNo=" & aVal(0)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVpakQCPO_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVpakQCPO.RowCommand
    If e.CommandName.ToLower = "cmdQCRequired".ToLower Then
      Try
        Dim SerialNo As Int32 = GVpakQCPO.DataKeys(e.CommandArgument).Values("SerialNo")
        SIS.PAK.pakQCPO.UpdateQCRequired(SerialNo)
        GVpakQCPO.DataBind()
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
  End Sub
  Protected Sub GVpakQCPO_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVpakQCPO.Init
    DataClassName = "GpakQCPO"
    SetGridView = GVpakQCPO
  End Sub
  Protected Sub TBLpakQCPO_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLpakQCPO.Init
    SetToolBar = TBLpakQCPO
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
  Protected Sub F_BuyerID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_BuyerID.TextChanged
    Session("F_BuyerID") = F_BuyerID.Text
    Session("F_BuyerID_Display") = F_BuyerID_Display.Text
    InitGridPage()
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function BuyerIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.QCM.qcmUsers.SelectqcmUsersAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub F_IssuedBy_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_IssuedBy.TextChanged
    Session("F_IssuedBy") = F_IssuedBy.Text
    Session("F_IssuedBy_Display") = F_IssuedBy_Display.Text
    InitGridPage()
  End Sub
  <System.Web.Services.WebMethod()> _
  <System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function IssuedByCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.QCM.qcmUsers.SelectqcmUsersAutoCompleteList(prefixText, count, contextKey)
  End Function
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
    F_BuyerID_Display.Text = String.Empty
    If Not Session("F_BuyerID_Display") Is Nothing Then
      If Session("F_BuyerID_Display") <> String.Empty Then
        F_BuyerID_Display.Text = Session("F_BuyerID_Display")
      End If
    End If
    F_BuyerID.Text = String.Empty
    If Not Session("F_BuyerID") Is Nothing Then
      If Session("F_BuyerID") <> String.Empty Then
        F_BuyerID.Text = Session("F_BuyerID")
      End If
    End If
    Dim strScriptBuyerID As String = "<script type=""text/javascript""> " & _
      "function ACEBuyerID_Selected(sender, e) {" & _
      "  var F_BuyerID = $get('" & F_BuyerID.ClientID & "');" & _
      "  var F_BuyerID_Display = $get('" & F_BuyerID_Display.ClientID & "');" & _
      "  var retval = e.get_value();" & _
      "  var p = retval.split('|');" & _
      "  F_BuyerID_Display.innerHTML = e.get_text();" & _
      "}" & _
      "</script>"
      If Not Page.ClientScript.IsClientScriptBlockRegistered("F_BuyerID") Then
        Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_BuyerID", strScriptBuyerID)
      End If
    Dim strScriptPopulatingBuyerID As String = "<script type=""text/javascript""> " & _
      "function ACEBuyerID_Populating(o,e) {" & _
      "  var p = $get('" & F_BuyerID.ClientID & "');" & _
      "  p.style.backgroundImage  = 'url(../../images/loader.gif)';" & _
      "  p.style.backgroundRepeat= 'no-repeat';" & _
      "  p.style.backgroundPosition = 'right';" & _
      "  o._contextKey = '';" & _
      "}" & _
      "function ACEBuyerID_Populated(o,e) {" & _
      "  var p = $get('" & F_BuyerID.ClientID & "');" & _
      "  p.style.backgroundImage  = 'none';" & _
      "}" & _
      "</script>"
      If Not Page.ClientScript.IsClientScriptBlockRegistered("F_BuyerIDPopulating") Then
        Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_BuyerIDPopulating", strScriptPopulatingBuyerID)
      End If
    F_IssuedBy_Display.Text = String.Empty
    If Not Session("F_IssuedBy_Display") Is Nothing Then
      If Session("F_IssuedBy_Display") <> String.Empty Then
        F_IssuedBy_Display.Text = Session("F_IssuedBy_Display")
      End If
    End If
    F_IssuedBy.Text = String.Empty
    If Not Session("F_IssuedBy") Is Nothing Then
      If Session("F_IssuedBy") <> String.Empty Then
        F_IssuedBy.Text = Session("F_IssuedBy")
      End If
    End If
    Dim strScriptIssuedBy As String = "<script type=""text/javascript""> " & _
      "function ACEIssuedBy_Selected(sender, e) {" & _
      "  var F_IssuedBy = $get('" & F_IssuedBy.ClientID & "');" & _
      "  var F_IssuedBy_Display = $get('" & F_IssuedBy_Display.ClientID & "');" & _
      "  var retval = e.get_value();" & _
      "  var p = retval.split('|');" & _
      "  F_IssuedBy_Display.innerHTML = e.get_text();" & _
      "}" & _
      "</script>"
      If Not Page.ClientScript.IsClientScriptBlockRegistered("F_IssuedBy") Then
        Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_IssuedBy", strScriptIssuedBy)
      End If
    Dim strScriptPopulatingIssuedBy As String = "<script type=""text/javascript""> " & _
      "function ACEIssuedBy_Populating(o,e) {" & _
      "  var p = $get('" & F_IssuedBy.ClientID & "');" & _
      "  p.style.backgroundImage  = 'url(../../images/loader.gif)';" & _
      "  p.style.backgroundRepeat= 'no-repeat';" & _
      "  p.style.backgroundPosition = 'right';" & _
      "  o._contextKey = '';" & _
      "}" & _
      "function ACEIssuedBy_Populated(o,e) {" & _
      "  var p = $get('" & F_IssuedBy.ClientID & "');" & _
      "  p.style.backgroundImage  = 'none';" & _
      "}" & _
      "</script>"
      If Not Page.ClientScript.IsClientScriptBlockRegistered("F_IssuedByPopulating") Then
        Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_IssuedByPopulating", strScriptPopulatingIssuedBy)
      End If
    Dim validateScriptProjectID As String = "<script type=""text/javascript"">" & _
      "  function validate_ProjectID(o) {" & _
      "    validated_FK_PAK_PO_ProjectID_main = true;" & _
      "    validate_FK_PAK_PO_ProjectID(o);" & _
      "  }" & _
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateProjectID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateProjectID", validateScriptProjectID)
    End If
    Dim validateScriptBuyerID As String = "<script type=""text/javascript"">" & _
      "  function validate_BuyerID(o) {" & _
      "    validated_FK_PAK_PO_BuyerID_main = true;" & _
      "    validate_FK_PAK_PO_BuyerID(o);" & _
      "  }" & _
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateBuyerID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateBuyerID", validateScriptBuyerID)
    End If
    Dim validateScriptIssuedBy As String = "<script type=""text/javascript"">" & _
      "  function validate_IssuedBy(o) {" & _
      "    validated_FK_PAK_PO_IssuedBy_main = true;" & _
      "    validate_FK_PAK_PO_IssuedBy(o);" & _
      "  }" & _
      "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateIssuedBy") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateIssuedBy", validateScriptIssuedBy)
    End If
    Dim validateScriptFK_PAK_PO_BuyerID As String = "<script type=""text/javascript"">" & _
      "  function validate_FK_PAK_PO_BuyerID(o) {" & _
      "    var value = o.id;" & _
      "    var BuyerID = $get('" & F_BuyerID.ClientID & "');" & _
      "    try{" & _
      "    if(BuyerID.value==''){" & _
      "      if(validated_FK_PAK_PO_BuyerID.main){" & _
      "        var o_d = $get(o.id +'_Display');" & _
      "        try{o_d.innerHTML = '';}catch(ex){}" & _
      "      }" & _
      "    }" & _
      "    value = value + ',' + BuyerID.value ;" & _
      "    }catch(ex){}" & _
      "    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" & _
      "    o.style.backgroundRepeat= 'no-repeat';" & _
      "    o.style.backgroundPosition = 'right';" & _
      "    PageMethods.validate_FK_PAK_PO_BuyerID(value, validated_FK_PAK_PO_BuyerID);" & _
      "  }" & _
      "  validated_FK_PAK_PO_BuyerID_main = false;" & _
      "  function validated_FK_PAK_PO_BuyerID(result) {" & _
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
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_PAK_PO_BuyerID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_PAK_PO_BuyerID", validateScriptFK_PAK_PO_BuyerID)
    End If
    Dim validateScriptFK_PAK_PO_IssuedBy As String = "<script type=""text/javascript"">" & _
      "  function validate_FK_PAK_PO_IssuedBy(o) {" & _
      "    var value = o.id;" & _
      "    var IssuedBy = $get('" & F_IssuedBy.ClientID & "');" & _
      "    try{" & _
      "    if(IssuedBy.value==''){" & _
      "      if(validated_FK_PAK_PO_IssuedBy.main){" & _
      "        var o_d = $get(o.id +'_Display');" & _
      "        try{o_d.innerHTML = '';}catch(ex){}" & _
      "      }" & _
      "    }" & _
      "    value = value + ',' + IssuedBy.value ;" & _
      "    }catch(ex){}" & _
      "    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" & _
      "    o.style.backgroundRepeat= 'no-repeat';" & _
      "    o.style.backgroundPosition = 'right';" & _
      "    PageMethods.validate_FK_PAK_PO_IssuedBy(value, validated_FK_PAK_PO_IssuedBy);" & _
      "  }" & _
      "  validated_FK_PAK_PO_IssuedBy_main = false;" & _
      "  function validated_FK_PAK_PO_IssuedBy(result) {" & _
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
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_PAK_PO_IssuedBy") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_PAK_PO_IssuedBy", validateScriptFK_PAK_PO_IssuedBy)
    End If
    Dim validateScriptFK_PAK_PO_ProjectID As String = "<script type=""text/javascript"">" & _
      "  function validate_FK_PAK_PO_ProjectID(o) {" & _
      "    var value = o.id;" & _
      "    var ProjectID = $get('" & F_ProjectID.ClientID & "');" & _
      "    try{" & _
      "    if(ProjectID.value==''){" & _
      "      if(validated_FK_PAK_PO_ProjectID.main){" & _
      "        var o_d = $get(o.id +'_Display');" & _
      "        try{o_d.innerHTML = '';}catch(ex){}" & _
      "      }" & _
      "    }" & _
      "    value = value + ',' + ProjectID.value ;" & _
      "    }catch(ex){}" & _
      "    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';" & _
      "    o.style.backgroundRepeat= 'no-repeat';" & _
      "    o.style.backgroundPosition = 'right';" & _
      "    PageMethods.validate_FK_PAK_PO_ProjectID(value, validated_FK_PAK_PO_ProjectID);" & _
      "  }" & _
      "  validated_FK_PAK_PO_ProjectID_main = false;" & _
      "  function validated_FK_PAK_PO_ProjectID(result) {" & _
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
    If Not Page.ClientScript.IsClientScriptBlockRegistered("validateFK_PAK_PO_ProjectID") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "validateFK_PAK_PO_ProjectID", validateScriptFK_PAK_PO_ProjectID)
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_PAK_PO_BuyerID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim BuyerID As String = CType(aVal(1),String)
    Dim oVar As SIS.QCM.qcmUsers = SIS.QCM.qcmUsers.qcmUsersGetByID(BuyerID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_PAK_PO_IssuedBy(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
    Dim IssuedBy As String = CType(aVal(1),String)
    Dim oVar As SIS.QCM.qcmUsers = SIS.QCM.qcmUsers.qcmUsersGetByID(IssuedBy)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found." 
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_PAK_PO_ProjectID(ByVal value As String) As String
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
End Class
