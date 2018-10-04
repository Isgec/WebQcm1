Partial Class GF_qcmInspectorGroupUsers
  Inherits SIS.SYS.GridBase
  Private _InfoUrl As String = "~/QCM_Main/App_Display/DF_qcmInspectorGroupUsers.aspx"
  Protected Sub Info_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs)
    Dim oBut As ImageButton = CType(sender, ImageButton)
    Dim aVal() As String = oBut.CommandArgument.ToString.Split(",".ToCharArray)
    Dim RedirectUrl As String = _InfoUrl  & "?GroupID=" & aVal(0) & "&CardNo=" & aVal(1)
    Response.Redirect(RedirectUrl)
  End Sub
  Protected Sub GVqcmInspectorGroupUsers_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVqcmInspectorGroupUsers.RowCommand
		If e.CommandName.ToLower = "lgedit".ToLower Then
			Try
				Dim GroupID As Int32 = GVqcmInspectorGroupUsers.DataKeys(e.CommandArgument).Values("GroupID")  
				Dim CardNo As String = GVqcmInspectorGroupUsers.DataKeys(e.CommandArgument).Values("CardNo")  
				Dim RedirectUrl As String = TBLqcmInspectorGroupUsers.EditUrl & "?GroupID=" & GroupID & "&CardNo=" & CardNo
				Response.Redirect(RedirectUrl)
			Catch ex As Exception
			End Try
		End If
  End Sub
  Protected Sub GVqcmInspectorGroupUsers_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVqcmInspectorGroupUsers.Init
    DataClassName = "GqcmInspectorGroupUsers"
    SetGridView = GVqcmInspectorGroupUsers
  End Sub
  Protected Sub TBLqcmInspectorGroupUsers_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmInspectorGroupUsers.Init
    SetToolBar = TBLqcmInspectorGroupUsers
  End Sub
  Protected Sub F_GroupID_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_GroupID.TextChanged
    Session("F_GroupID") = F_GroupID.Text
    Session("F_GroupID_Display") = F_GroupID_Display.Text
    InitGridPage()
  End Sub
	<System.Web.Services.WebMethod()> _
	<System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function GroupIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.QCM.qcmInspectorGroups.SelectqcmInspectorGroupsAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub Page_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
    F_GroupID_Display.Text = String.Empty
    If Not Session("F_GroupID_Display") Is Nothing Then
      If Session("F_GroupID_Display") <> String.Empty Then
        F_GroupID_Display.Text = Session("F_GroupID_Display")
      End If
    End If
    F_GroupID.Text = String.Empty
    If Not Session("F_GroupID") Is Nothing Then
      If Session("F_GroupID") <> String.Empty Then
        F_GroupID.Text = Session("F_GroupID")
      End If
    End If
		Dim strScriptGroupID As String = "<script type=""text/javascript""> " & _
			"function ACEGroupID_Selected(sender, e) {" & _
			"  var F_GroupID = $get('" & F_GroupID.ClientID & "');" & _
			"  var F_GroupID_Display = $get('" & F_GroupID_Display.ClientID & "');" & _
			"  var retval = e.get_value();" & _
			"  var p = retval.split('|');" & _
			"  F_GroupID.value = p[0];" & _
			"  F_GroupID_Display.innerHTML = e.get_text();" & _
			"}" & _
			"</script>"
			If Not Page.ClientScript.IsClientScriptBlockRegistered("F_GroupID") Then
				Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_GroupID", strScriptGroupID)
			End If
		Dim strScriptPopulatingGroupID As String = "<script type=""text/javascript""> " & _
			"function ACEGroupID_Populating(o,e) {" & _
			"  var p = $get('" & F_GroupID.ClientID & "');" & _
			"  p.style.backgroundImage  = 'url(../../images/loader.gif)';" & _
			"  p.style.backgroundRepeat= 'no-repeat';" & _
			"  p.style.backgroundPosition = 'right';" & _
			"  o._contextKey = '';" & _
			"}" & _
			"function ACEGroupID_Populated(o,e) {" & _
			"  var p = $get('" & F_GroupID.ClientID & "');" & _
			"  p.style.backgroundImage  = 'none';" & _
			"}" & _
			"</script>"
			If Not Page.ClientScript.IsClientScriptBlockRegistered("F_GroupIDPopulating") Then
				Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "F_GroupIDPopulating", strScriptPopulatingGroupID)
			End If
  End Sub
End Class
