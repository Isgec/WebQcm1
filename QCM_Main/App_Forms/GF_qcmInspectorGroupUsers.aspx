<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="GF_qcmInspectorGroupUsers.aspx.vb" Inherits="GF_qcmInspectorGroupUsers" title="Maintain List: Inspector Group Users" %>
<asp:Content ID="CPHqcmInspectorGroupUsers" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelqcmInspectorGroupUsers" runat="server" Text="&nbsp;List: Inspector Group Users" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLqcmInspectorGroupUsers" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLqcmInspectorGroupUsers"
      ToolType = "lgNMGrid"
      EditUrl = "~/QCM_Main/App_Edit/EF_qcmInspectorGroupUsers.aspx"
      AddUrl = "~/QCM_Main/App_Create/AF_qcmInspectorGroupUsers.aspx"
      AddPostBack = "True"
      ValidationGroup = "qcmInspectorGroupUsers"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSqcmInspectorGroupUsers" runat="server" AssociatedUpdatePanelID="UPNLqcmInspectorGroupUsers" DisplayAfter="100">
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
					<b><asp:Label ID="L_GroupID" runat="server" Text="Group ID :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_GroupID"
						CssClass = "mypktxt"
            Width="70px"
						Text=""
						onfocus = "return this.select();"
						AutoCompleteType = "None"
						AutoPostBack = "True"
						Runat="Server" />
					<asp:Label
						ID = "F_GroupID_Display"
						Text=""
						Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEGroupID"
            BehaviorID="B_ACEGroupID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="GroupIDCompletionList"
            TargetControlID="F_GroupID"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="ACEGroupID_Selected"
            OnClientPopulating="ACEGroupID_Populating"
            OnClientPopulated="ACEGroupID_Populated"
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
    
    <asp:GridView ID="GVqcmInspectorGroupUsers" SkinID="gv_silver" BorderColor="#A9A9A9" width="100%" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ODSqcmInspectorGroupUsers" DataKeyNames="GroupID,CardNo">
      <Columns>
        <asp:TemplateField>
          <ItemTemplate>
						<Table><tr>
              <td><asp:ImageButton ID="cmdEditPage" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' /></td>
						</tr></Table>
          </ItemTemplate>
          <HeaderStyle Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Group ID" SortExpression="QCM_InspectorGroups2_Description">
          <ItemTemplate>
             <asp:Label ID="L_GroupID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("GroupID") %>' Text='<%# Eval("QCM_InspectorGroups2_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="User ID" SortExpression="HRM_Employees1_EmployeeName">
          <ItemTemplate>
             <asp:Label ID="L_CardNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("CardNo") %>' Text='<%# Eval("HRM_Employees1_EmployeeName") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSqcmInspectorGroupUsers"
      runat = "server"
      DataObjectTypeName = "SIS.QCM.qcmInspectorGroupUsers"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "qcmInspectorGroupUsersSelectList"
      TypeName = "SIS.QCM.qcmInspectorGroupUsers"
      SelectCountMethod = "qcmInspectorGroupUsersSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_GroupID" PropertyName="Text" Name="GroupID" Type="Int32" Size="10" />
				<asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
				<asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVqcmInspectorGroupUsers" EventName="PageIndexChanged" />
    <asp:AsyncPostBackTrigger ControlID="F_GroupID" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
