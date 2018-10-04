<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_qcmEmployeeGroupUsers.aspx.vb" Inherits="AF_qcmEmployeeGroupUsers" title="Add: Employee Group Users" %>
<asp:Content ID="CPHqcmEmployeeGroupUsers" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmEmployeeGroupUsers" runat="server" Text="&nbsp;Add: Employee Group Users" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmEmployeeGroupUsers" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmEmployeeGroupUsers"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    ValidationGroup = "qcmEmployeeGroupUsers"
    runat = "server" />
<asp:FormView ID="FVqcmEmployeeGroupUsers"
	runat = "server"
	DataKeyNames = "GroupiD,CardNo"
	DataSourceID = "ODSqcmEmployeeGroupUsers"
	DefaultMode = "Insert" CssClass="sis_formview">
	<InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgqcmEmployeeGroupUsers" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_GroupiD" ForeColor="#CC6633" runat="server" Text="GroupiD :" /></b>
				</td>
        <td>
          <LGM:LC_qcmEmployeeGroups
            ID="F_GroupiD"
            SelectedValue='<%# Bind("GroupiD") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
						ValidationGroup = "qcmEmployeeGroupUsers"
            RequiredFieldErrorMessage = "GroupiD is required."
            onblur= "script_qcmEmployeeGroupUsers.validate_GroupiD(this);"
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
						ValidationGroup = "qcmEmployeeGroupUsers"
            onblur= "script_qcmEmployeeGroupUsers.validate_CardNo(this);"
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
						ValidationGroup = "qcmEmployeeGroupUsers"
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
            OnClientItemSelected="script_qcmEmployeeGroupUsers.ACECardNo_Selected"
            OnClientPopulating="script_qcmEmployeeGroupUsers.ACECardNo_Populating"
            OnClientPopulated="script_qcmEmployeeGroupUsers.ACECardNo_Populated"
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
  ID = "ODSqcmEmployeeGroupUsers"
  DataObjectTypeName = "SIS.QCM.qcmEmployeeGroupUsers"
  InsertMethod="qcmEmployeeGroupUsersInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmEmployeeGroupUsers"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
