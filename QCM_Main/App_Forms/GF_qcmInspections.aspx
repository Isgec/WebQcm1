<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="GF_qcmInspections.aspx.vb" Inherits="GF_qcmInspections" title="Maintain List: Inspection Report-HO" %>
<asp:Content ID="CPHqcmInspections" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelqcmInspections" runat="server" Text="&nbsp;List: Inspection Report-HO" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLqcmInspections" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLqcmInspections"
      ToolType = "lgNMGrid"
      EditUrl = "~/QCM_Main/App_Edit/EF_qcmInspections.aspx"
      AddUrl = "~/QCM_Main/App_Create/AF_qcmInspections.aspx?skip=1"
      AddPostBack = "True"
      ValidationGroup = "qcmInspections"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSqcmInspections" runat="server" AssociatedUpdatePanelID="UPNLqcmInspections" DisplayAfter="100">
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
					<b><asp:Label ID="L_RequestID" runat="server" Text="Request ID :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_RequestID"
						CssClass = "mypktxt"
            Width="70px"
						Text=""
						onfocus = "return this.select();"
						AutoCompleteType = "None"
            onblur= "validate_RequestID(this);"
						Runat="Server" />
					<asp:Label
						ID = "F_RequestID_Display"
						Text=""
						Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACERequestID"
            BehaviorID="B_ACERequestID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="RequestIDCompletionList"
            TargetControlID="F_RequestID"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="ACERequestID_Selected"
            OnClientPopulating="ACERequestID_Populating"
            OnClientPopulated="ACERequestID_Populated"
            CompletionSetCount="10"
						CompletionListCssClass = "autocomplete_completionListElement"
						CompletionListItemCssClass = "autocomplete_listItem"
						CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_AllotedTo" runat="server" Text="Alloted To :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_AllotedTo" CssClass="myfktxt" Text="" AutoCompleteType="None" Width="56px" onfocus="return this.select();" ToolTip="Enter value for Alloted To." ValidationGroup="qcmRequestAllotment" onblur="return validate_AllotedTo(this);" runat="Server" />
					<asp:Label ID="F_AllotedTo_Display" Text="" runat="Server" />
					<AJX:AutoCompleteExtender ID="ACEAllotedTo" BehaviorID="B_ACEAllotedTo" ContextKey="" UseContextKey="true" ServiceMethod="AllotedToCompletionList" TargetControlID="F_AllotedTo" EnableCaching="false" CompletionInterval="100" FirstRowSelected="true" MinimumPrefixLength="1" OnClientItemSelected="ACEAllotedTo_Selected" OnClientPopulating="ACEAllotedTo_Populating" OnClientPopulated="ACEAllotedTo_Populated" CompletionSetCount="10" CompletionListCssClass="autocomplete_completionListElement" CompletionListItemCssClass="autocomplete_listItem" CompletionListHighlightedItemCssClass="autocomplete_highlightedListItem" runat="Server" />
				</td>
			</tr>
    </table>
		</asp:Panel>
		<AJX:CollapsiblePanelExtender ID="cpe1" runat="Server" TargetControlID="pnlD" ExpandControlID="pnlH" CollapseControlID="pnlH" Collapsed="True" TextLabelID="lblH" ImageControlID="imgH" ExpandedText="(Hide Filters...)" CollapsedText="(Show Filters...)" ExpandedImage="~/images/ua.png" CollapsedImage="~/images/da.png" SuppressPostBack="true" />
    
    <asp:GridView ID="GVqcmInspections" SkinID="gv_silver" BorderColor="#A9A9A9" width="100%" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ODSqcmInspections" DataKeyNames="RequestID,InspectionID">
      <Columns>
        <asp:TemplateField>
          <ItemTemplate>
						<Table><tr>
              <td><asp:ImageButton ID="cmdEditPage" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' /></td>
						</tr></Table>
          </ItemTemplate>
          <HeaderStyle Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Request ID" SortExpression="QCM_Requests8_Description">
          <ItemTemplate>
             <asp:Label ID="L_RequestID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("RequestID") %>' Text='<%# Eval("QCM_Requests8_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Inspection ID" SortExpression="InspectionID">
          <ItemTemplate>
            <asp:Label ID="LabelInspectionID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("InspectionID") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle CssClass="alignright" />
          <ItemStyle CssClass="alignright" />
          <HeaderStyle Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Project ID" SortExpression="IDM_Projects2_Description">
          <ItemTemplate>
             <asp:Label ID="L_ProjectID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("ProjectID") %>' Text='<%# Eval("IDM_Projects2_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Order No" SortExpression="OrderNo">
          <ItemTemplate>
            <asp:Label ID="LabelOrderNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("OrderNo") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Supplier ID" SortExpression="IDM_Vendors3_Description">
          <ItemTemplate>
             <asp:Label ID="L_SupplierID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("SupplierID") %>' Text='<%# Eval("IDM_Vendors3_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Inspection Remarks" SortExpression="InspectionRemarks">
          <ItemTemplate>
            <asp:Label ID="LabelInspectionRemarks" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("InspectionRemarks") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Inspected By" SortExpression="HRM_Employees1_EmployeeName">
          <ItemTemplate>
             <asp:Label ID="L_InspectedBy" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("InspectedBy") %>' Text='<%# Eval("HRM_Employees1_EmployeeName") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Inspected On" SortExpression="InspectedOn">
          <ItemTemplate>
            <asp:Label ID="LabelInspectedOn" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("InspectedOn") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="80px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSqcmInspections"
      runat = "server"
      DataObjectTypeName = "SIS.QCM.qcmInspections"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_qcmInspectionsSelectList"
      TypeName = "SIS.QCM.qcmInspections"
      SelectCountMethod = "qcmInspectionsSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_RequestID" PropertyName="Text" Name="RequestID" Type="Int32" Size="10" />
        <asp:ControlParameter ControlID="F_AllotedTo" PropertyName="Text" Name="AllotedTo" Type="String" Size="8" />
				<asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
				<asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVqcmInspections" EventName="PageIndexChanged" />
    <asp:AsyncPostBackTrigger ControlID="F_RequestID" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
