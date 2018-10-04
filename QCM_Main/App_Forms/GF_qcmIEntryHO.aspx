<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="GF_qcmIEntryHO.aspx.vb" Inherits="GF_qcmIEntryHO" title="Maintain List: Pending Inspections" %>
<asp:Content ID="CPHqcmIEntryHO" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelqcmIEntryHO" runat="server" Text="&nbsp;List: Requests Pending for Inspection" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLqcmIEntryHO" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLqcmIEntryHO"
      ToolType = "lgNMGrid"
      EditUrl = "~/QCM_Main/App_Edit/EF_qcmIEntryHO.aspx"
      EnableAdd = "False"
      ValidationGroup = "qcmIEntryHO"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSqcmIEntryHO" runat="server" AssociatedUpdatePanelID="UPNLqcmIEntryHO" DisplayAfter="100">
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
					<b><asp:Label ID="L_ProjectID" runat="server" Text="Project ID :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_ProjectID"
						CssClass = "myfktxt"
            Width="42px"
						Text=""
						onfocus = "return this.select();"
						AutoCompleteType = "None"
            onblur= "validate_ProjectID(this);"
						Runat="Server" />
					<asp:Label
						ID = "F_ProjectID_Display"
						Text=""
						Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEProjectID"
            BehaviorID="B_ACEProjectID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="ProjectIDCompletionList"
            TargetControlID="F_ProjectID"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="ACEProjectID_Selected"
            OnClientPopulating="ACEProjectID_Populating"
            OnClientPopulated="ACEProjectID_Populated"
            CompletionSetCount="10"
						CompletionListCssClass = "autocomplete_completionListElement"
						CompletionListItemCssClass = "autocomplete_listItem"
						CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_SupplierID" runat="server" Text="Supplier ID :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_SupplierID"
						CssClass = "myfktxt"
            Width="42px"
						Text=""
						onfocus = "return this.select();"
						AutoCompleteType = "None"
            onblur= "validate_SupplierID(this);"
						Runat="Server" />
					<asp:Label
						ID = "F_SupplierID_Display"
						Text=""
						Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACESupplierID"
            BehaviorID="B_ACESupplierID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="SupplierIDCompletionList"
            TargetControlID="F_SupplierID"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="ACESupplierID_Selected"
            OnClientPopulating="ACESupplierID_Populating"
            OnClientPopulated="ACESupplierID_Populated"
            CompletionSetCount="10"
						CompletionListCssClass = "autocomplete_completionListElement"
						CompletionListItemCssClass = "autocomplete_listItem"
						CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_RequestStateID" runat="server" Text="Request State :" /></b>
				</td>
        <td>
          <LGM:LC_qcmRequestStates
            ID="F_RequestStateID"
            SelectedValue=""
            OrderBy="Description"
            DataTextField="Description"
            DataValueField="StateID"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            AutoPostBack="true"
            RequiredFieldErrorMessage=""
            CssClass="myddl"
            Runat="Server" />
          </td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_InspectionStatusID" runat="server" Text="Inspection Status :" /></b>
				</td>
        <td>
          <LGM:LC_qcmInspectionStatus
            ID="F_InspectionStatusID"
            SelectedValue=""
            OrderBy="Description"
            DataTextField="Description"
            DataValueField="InspectionStatusID"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            AutoPostBack="true"
            RequiredFieldErrorMessage=""
            CssClass="myddl"
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
    
    <asp:GridView ID="GVqcmIEntryHO" SkinID="gv_silver" BorderColor="#A9A9A9" width="100%" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ODSqcmIEntryHO" DataKeyNames="RequestID">
      <Columns>
        <asp:TemplateField>
          <ItemTemplate>
						<Table><tr>
              <td><asp:ImageButton ID="cmdEditPage" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' /></td>
						</tr></Table>
          </ItemTemplate>
          <HeaderStyle Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Request ID" SortExpression="RequestID">
          <ItemTemplate>
            <asp:Label ID="LabelRequestID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("RequestID") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle CssClass="alignright" />
          <ItemStyle CssClass="alignright" />
          <HeaderStyle Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Project ID" SortExpression="IDM_Projects6_Description">
          <ItemTemplate>
             <asp:Label ID="L_ProjectID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("ProjectID") %>' Text='<%# Eval("IDM_Projects6_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Supplier ID" SortExpression="IDM_Vendors7_Description">
          <ItemTemplate>
             <asp:Label ID="L_SupplierID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("SupplierID") %>' Text='<%# Eval("IDM_Vendors7_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Item Description & Stage" SortExpression="Description">
          <ItemTemplate>
            <asp:Label ID="LabelDescription" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Description") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Total Requested Quantity" SortExpression="TotalRequestedQuantity">
          <ItemTemplate>
            <asp:Label ID="LabelTotalRequestedQuantity" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("TotalRequestedQuantity") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Request State" SortExpression="QCM_RequestStates10_Description">
          <ItemTemplate>
             <asp:Label ID="L_RequestStateID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("RequestStateID") %>' Text='<%# Eval("QCM_RequestStates10_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Alloted To" SortExpression="HRM_Employees2_EmployeeName">
          <ItemTemplate>
             <asp:Label ID="L_AllotedTo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("AllotedTo") %>' Text='<%# Eval("HRM_Employees2_EmployeeName") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Alloted Start Date" SortExpression="AllotedStartDate">
          <ItemTemplate>
            <asp:Label ID="LabelAllotedStartDate" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("AllotedStartDate") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Alloted Finish Date" SortExpression="AllotedFinishDate">
          <ItemTemplate>
            <asp:Label ID="LabelAllotedFinishDate" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("AllotedFinishDate") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Alloted By" SortExpression="HRM_Employees3_EmployeeName">
          <ItemTemplate>
             <asp:Label ID="L_AllotedBy" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("AllotedBy") %>' Text='<%# Eval("HRM_Employees3_EmployeeName") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField>
          <ItemTemplate>
						</td></tr>
						<tr style="background-color:AntiqueWhite; color:DeepPink">
							<td></td>
							<td></td>
							<td></td>
							<td></td>
							<td></td>
							<td><li><b>
								<asp:Label ID="labelRegion" runat="server" Text='<%# Eval("QCM_Regions12_RegionName") %>' />
							</b></li>
							</td>
							<td></td>
							<td>
								<li><b><u>Inspection:</u></b></li>
							</td>
							<td>
								<asp:Label ID="LabelInspectionStartDate" runat="server"  Text='<%# Bind("InspectionStartDate") %>'></asp:Label>
							</td>
							<td>
								<asp:Label ID="LabelInspectionFinishDate" runat="server" Text='<%# Bind("InspectionFinishDate") %>'></asp:Label>
							</td>
							<td>
								<asp:Label ID="L_InspectionStatusID" runat="server" Title='<%# EVal("InspectionStatusID") %>' Text='<%# Eval("QCM_InspectionStatus11_Description") %>'></asp:Label>
								<LGM:LC_qcmInspectionStatus
									ID="F_InspectionStatusID"
									SelectedValue=""
									OrderBy="Description"
									DataTextField="Description"
									DataValueField="InspectionStatusID"
									IncludeDefault="true"
									DefaultText="-- Select --"
									Width="200px"
									AutoPostBack="false"
									Visible='<%# EVal("CloseVisible") %>'
									RequiredFieldErrorMessage="[Required]"
								  ValidationGroup='<%# Container.DataItemIndex %>'
									CssClass="myddl"
									Runat="Server" />
							</td>
							<td>
								<asp:ImageButton 
									ID="cmdClose" 
									runat="server" 
									Visible='<%# EVal("CloseVisible") %>' 
									Enabled='<%# EVal("Enable") %>' 
									AlternateText="Close" 
									ToolTip="Close the request." 
									ImageUrl="~/App_Themes/Default/Images/lock.png"   
									CommandName="lgClose" 
									CommandArgument='<%# Container.DataItemIndex %>' 
								  ValidationGroup='<%# Container.DataItemIndex %>'
									OnClientClick="return confirm('Close the inspection request ?');" />
							</td>
						</tr>
          </ItemTemplate>
          <HeaderStyle Width="30px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSqcmIEntryHO"
      runat = "server"
      DataObjectTypeName = "SIS.QCM.qcmIEntryHO"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_qcmIEntryHOSelectList"
      TypeName = "SIS.QCM.qcmIEntryHO"
      SelectCountMethod = "qcmIEntryHOSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_ProjectID" PropertyName="Text" Name="ProjectID" Type="String" Size="6" />
        <asp:ControlParameter ControlID="F_SupplierID" PropertyName="Text" Name="SupplierID" Type="String" Size="6" />
        <asp:ControlParameter ControlID="F_RequestStateID" PropertyName="SelectedValue" Name="RequestStateID" Type="String" Size="10" />
        <asp:ControlParameter ControlID="F_InspectionStatusID" PropertyName="SelectedValue" Name="InspectionStatusID" Type="Int32" Size="10" />
        <asp:ControlParameter ControlID="F_AllotedTo" PropertyName="Text" Name="AllotedTo" Type="String" Size="8" />
				<asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
				<asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVqcmIEntryHO" EventName="PageIndexChanged" />
    <asp:AsyncPostBackTrigger ControlID="F_ProjectID" />
    <asp:AsyncPostBackTrigger ControlID="F_SupplierID" />
    <asp:AsyncPostBackTrigger ControlID="F_RequestStateID" />
    <asp:AsyncPostBackTrigger ControlID="F_InspectionStatusID" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
