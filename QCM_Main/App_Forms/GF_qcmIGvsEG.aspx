<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="GF_qcmIGvsEG.aspx.vb" Inherits="GF_qcmIGvsEG" title="Maintain List: Inspectors vs Employee" %>
<asp:Content ID="CPHqcmIGvsEG" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelqcmIGvsEG" runat="server" Text="&nbsp;List: Inspectors vs Employee" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLqcmIGvsEG" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLqcmIGvsEG"
      ToolType = "lgNMGrid"
      EditUrl = "~/QCM_Main/App_Edit/EF_qcmIGvsEG.aspx"
      AddUrl = "~/QCM_Main/App_Create/AF_qcmIGvsEG.aspx"
      ValidationGroup = "qcmIGvsEG"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSqcmIGvsEG" runat="server" AssociatedUpdatePanelID="UPNLqcmIGvsEG" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    
		<asp:Panel ID="pnlH" runat="server" CssClass="cph_filter">
			<div style="padding: 5px; cursor: pointer; vertical-align: middle;">
				<div style="float: left;">Filter Records </div>
				<div style="float: left; margin-left: 20px;">
					<asp:Label ID="lblH" runat="server">(Show Filters...)</asp:Label>
				</div>
				<div style="float: right; vertical-align: middle;">
					<asp:ImageButton ID="imgH" runat="server" ImageUrl="~/images/ua.png" AlternateText="(Show Filters...)" />
				</div>
			</div>
		</asp:Panel>
		<asp:Panel ID="pnlD" runat="server" CssClass="cp_filter" Height="0">
    <table>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_InspectorGroupID" runat="server" Text="Inspector Group ID :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_InspectorGroupID"
						CssClass = "mypktxt"
            Width="70px"
						Text=""
						onfocus = "return this.select();"
						AutoCompleteType = "None"
            onblur= "validate_InspectorGroupID(this);"
						Runat="Server" />
					<asp:Label
						ID = "F_InspectorGroupID_Display"
						Text=""
						Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEInspectorGroupID"
            BehaviorID="B_ACEInspectorGroupID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="InspectorGroupIDCompletionList"
            TargetControlID="F_InspectorGroupID"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="ACEInspectorGroupID_Selected"
            OnClientPopulating="ACEInspectorGroupID_Populating"
            OnClientPopulated="ACEInspectorGroupID_Populated"
            CompletionSetCount="10"
						CompletionListCssClass = "autocomplete_completionListElement"
						CompletionListItemCssClass = "autocomplete_listItem"
						CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_EmployeeGroupID" runat="server" Text="Employee Group ID :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_EmployeeGroupID"
						CssClass = "mypktxt"
            Width="70px"
						Text=""
						onfocus = "return this.select();"
						AutoCompleteType = "None"
            onblur= "validate_EmployeeGroupID(this);"
						Runat="Server" />
					<asp:Label
						ID = "F_EmployeeGroupID_Display"
						Text=""
						Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEEmployeeGroupID"
            BehaviorID="B_ACEEmployeeGroupID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="EmployeeGroupIDCompletionList"
            TargetControlID="F_EmployeeGroupID"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="ACEEmployeeGroupID_Selected"
            OnClientPopulating="ACEEmployeeGroupID_Populating"
            OnClientPopulated="ACEEmployeeGroupID_Populated"
            CompletionSetCount="10"
						CompletionListCssClass = "autocomplete_completionListElement"
						CompletionListItemCssClass = "autocomplete_listItem"
						CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
			</tr>
    </table>
		</asp:Panel>
		<AJX:CollapsiblePanelExtender ID="cpe1" runat="Server" TargetControlID="pnlD" ExpandControlID="pnlH" CollapseControlID="pnlH" Collapsed="True" TextLabelID="lblH" ImageControlID="imgH" ExpandedText="(Hide Filters...)" CollapsedText="(Show Filters...)" ExpandedImage="~/images/ua.png" CollapsedImage="~/images/da.png" SuppressPostBack="true" />
    
    <asp:GridView ID="GVqcmIGvsEG" SkinID="gv_silver" BorderColor="#A9A9A9" width="100%" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ODSqcmIGvsEG" DataKeyNames="InspectorGroupID,EmployeeGroupID">
      <Columns>
        <asp:TemplateField>
          <ItemTemplate>
						<Table><tr>
              <td><asp:ImageButton ID="cmdEditPage" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' /></td>
						</tr></Table>
          </ItemTemplate>
          <HeaderStyle Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Inspector Group ID" SortExpression="QCM_InspectorGroups2_Description">
          <ItemTemplate>
             <asp:Label ID="L_InspectorGroupID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("InspectorGroupID") %>' Text='<%# Eval("QCM_InspectorGroups2_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Employee Group ID" SortExpression="QCM_EmployeeGroups1_Description">
          <ItemTemplate>
             <asp:Label ID="L_EmployeeGroupID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("EmployeeGroupID") %>' Text='<%# Eval("QCM_EmployeeGroups1_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSqcmIGvsEG"
      runat = "server"
      DataObjectTypeName = "SIS.QCM.qcmIGvsEG"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "qcmIGvsEGSelectList"
      TypeName = "SIS.QCM.qcmIGvsEG"
      SelectCountMethod = "qcmIGvsEGSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_InspectorGroupID" PropertyName="Text" Name="InspectorGroupID" Type="Int32" Size="10" />
        <asp:ControlParameter ControlID="F_EmployeeGroupID" PropertyName="Text" Name="EmployeeGroupID" Type="Int32" Size="10" />
				<asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
				<asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVqcmIGvsEG" EventName="PageIndexChanged" />
    <asp:AsyncPostBackTrigger ControlID="F_InspectorGroupID" />
    <asp:AsyncPostBackTrigger ControlID="F_EmployeeGroupID" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
