<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_qcmIGvsEG.aspx.vb" Inherits="AF_qcmIGvsEG" title="Add: Inspectors vs Employee" %>
<asp:Content ID="CPHqcmIGvsEG" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmIGvsEG" runat="server" Text="&nbsp;Add: Inspectors vs Employee" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmIGvsEG" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmIGvsEG"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    ValidationGroup = "qcmIGvsEG"
    runat = "server" />
<asp:FormView ID="FVqcmIGvsEG"
	runat = "server"
	DataKeyNames = "InspectorGroupID,EmployeeGroupID"
	DataSourceID = "ODSqcmIGvsEG"
	DefaultMode = "Insert" CssClass="sis_formview">
	<InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgqcmIGvsEG" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_InspectorGroupID" ForeColor="#CC6633" runat="server" Text="Inspector Group ID :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_InspectorGroupID"
						CssClass = "mypktxt"
            Width="70px"
						Text='<%# Bind("InspectorGroupID") %>'
						AutoCompleteType = "None"
						onfocus = "return this.select();"
            ToolTip="Enter value for Inspector Group ID."
						ValidationGroup = "qcmIGvsEG"
            onblur= "script_qcmIGvsEG.validate_InspectorGroupID(this);"
						Runat="Server" />
					<asp:Label
						ID = "F_InspectorGroupID_Display"
						Text='<%# Eval("QCM_InspectorGroups2_Description") %>'
						Runat="Server" />
					<asp:RequiredFieldValidator 
						ID = "RFVInspectorGroupID"
						runat = "server"
						ControlToValidate = "F_InspectorGroupID"
						Text = "Inspector Group ID is required."
						ErrorMessage = "[Required!]"
						Display = "Dynamic"
						EnableClientScript = "true"
						ValidationGroup = "qcmIGvsEG"
						SetFocusOnError="true" />
          <AJX:AutoCompleteExtender
            ID="ACEInspectorGroupID"
            BehaviorID="B_ACEInspectorGroupID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="InspectorGroupIDCompletionList"
            TargetControlID="F_InspectorGroupID"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_qcmIGvsEG.ACEInspectorGroupID_Selected"
            OnClientPopulating="script_qcmIGvsEG.ACEInspectorGroupID_Populating"
            OnClientPopulated="script_qcmIGvsEG.ACEInspectorGroupID_Populated"
            CompletionSetCount="10"
						CompletionListCssClass = "autocomplete_completionListElement"
						CompletionListItemCssClass = "autocomplete_listItem"
						CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_EmployeeGroupID" ForeColor="#CC6633" runat="server" Text="Employee Group ID :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_EmployeeGroupID"
						CssClass = "mypktxt"
            Width="70px"
						Text='<%# Bind("EmployeeGroupID") %>'
						AutoCompleteType = "None"
						onfocus = "return this.select();"
            ToolTip="Enter value for Employee Group ID."
						ValidationGroup = "qcmIGvsEG"
            onblur= "script_qcmIGvsEG.validate_EmployeeGroupID(this);"
						Runat="Server" />
					<asp:Label
						ID = "F_EmployeeGroupID_Display"
						Text='<%# Eval("QCM_EmployeeGroups1_Description") %>'
						Runat="Server" />
					<asp:RequiredFieldValidator 
						ID = "RFVEmployeeGroupID"
						runat = "server"
						ControlToValidate = "F_EmployeeGroupID"
						Text = "Employee Group ID is required."
						ErrorMessage = "[Required!]"
						Display = "Dynamic"
						EnableClientScript = "true"
						ValidationGroup = "qcmIGvsEG"
						SetFocusOnError="true" />
          <AJX:AutoCompleteExtender
            ID="ACEEmployeeGroupID"
            BehaviorID="B_ACEEmployeeGroupID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="EmployeeGroupIDCompletionList"
            TargetControlID="F_EmployeeGroupID"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_qcmIGvsEG.ACEEmployeeGroupID_Selected"
            OnClientPopulating="script_qcmIGvsEG.ACEEmployeeGroupID_Populating"
            OnClientPopulated="script_qcmIGvsEG.ACEEmployeeGroupID_Populated"
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
  ID = "ODSqcmIGvsEG"
  DataObjectTypeName = "SIS.QCM.qcmIGvsEG"
  InsertMethod="qcmIGvsEGInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmIGvsEG"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
