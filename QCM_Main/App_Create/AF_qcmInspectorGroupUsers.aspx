<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_qcmInspectorGroupUsers.aspx.vb" Inherits="AF_qcmInspectorGroupUsers" title="Add: Inspector Group Users" %>
<asp:Content ID="CPHqcmInspectorGroupUsers" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmInspectorGroupUsers" runat="server" Text="&nbsp;Add: Inspector Group Users" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmInspectorGroupUsers" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmInspectorGroupUsers"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    ValidationGroup = "qcmInspectorGroupUsers"
    runat = "server" />
<asp:FormView ID="FVqcmInspectorGroupUsers"
	runat = "server"
	DataKeyNames = "GroupID,CardNo"
	DataSourceID = "ODSqcmInspectorGroupUsers"
	DefaultMode = "Insert" CssClass="sis_formview">
	<InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgqcmInspectorGroupUsers" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_GroupID" ForeColor="#CC6633" runat="server" Text="Group ID :" /></b>
				</td>
        <td>
          <LGM:LC_qcmInspectorGroups
            ID="F_GroupID"
            SelectedValue='<%# Bind("GroupID") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
						ValidationGroup = "qcmInspectorGroupUsers"
            RequiredFieldErrorMessage = "Group ID is required."
            Runat="Server" />
          </td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_CardNo" ForeColor="#CC6633" runat="server" Text="User ID :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_CardNo"
						CssClass = "mypktxt"
            Width="56px"
						Text='<%# Bind("CardNo") %>'
						AutoCompleteType = "None"
						onfocus = "return this.select();"
            ToolTip="Enter value for User ID."
						ValidationGroup = "qcmInspectorGroupUsers"
            onblur= "script_qcmInspectorGroupUsers.validate_CardNo(this);"
						Runat="Server" />
					<asp:Label
						ID = "F_CardNo_Display"
						Text='<%# Eval("HRM_Employees1_EmployeeName") %>'
						Runat="Server" />
					<asp:RequiredFieldValidator 
						ID = "RFVCardNo"
						runat = "server"
						ControlToValidate = "F_CardNo"
						Text = "User ID is required."
						ErrorMessage = "[Required!]"
						Display = "Dynamic"
						EnableClientScript = "true"
						ValidationGroup = "qcmInspectorGroupUsers"
						SetFocusOnError="true" />
          <AJX:AutoCompleteExtender
            ID="ACECardNo"
            BehaviorID="B_ACECardNo"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="CardNoCompletionList"
            TargetControlID="F_CardNo"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_qcmInspectorGroupUsers.ACECardNo_Selected"
            OnClientPopulating="script_qcmInspectorGroupUsers.ACECardNo_Populating"
            OnClientPopulated="script_qcmInspectorGroupUsers.ACECardNo_Populated"
            CompletionSetCount="10"
						CompletionListCssClass = "autocomplete_completionListElement"
						CompletionListItemCssClass = "autocomplete_listItem"
						CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
			</tr>
		</table>
		</div>
	</InsertItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSqcmInspectorGroupUsers"
  DataObjectTypeName = "SIS.QCM.qcmInspectorGroupUsers"
  InsertMethod="qcmInspectorGroupUsersInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmInspectorGroupUsers"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
