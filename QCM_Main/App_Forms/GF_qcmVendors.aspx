<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="GF_qcmVendors.aspx.vb" Inherits="GF_qcmVendors" title="Maintain List: Vendors" %>
<asp:Content ID="CPHqcmVendors" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelqcmVendors" runat="server" Text="&nbsp;List: Vendors" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLqcmVendors" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLqcmVendors"
      ToolType = "lgNMGrid"
      EditUrl = "~/QCM_Main/App_Edit/EF_qcmVendors.aspx"
      AddUrl = "~/QCM_Main/App_Create/AF_qcmVendors.aspx"
      ValidationGroup = "qcmVendors"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSqcmVendors" runat="server" AssociatedUpdatePanelID="UPNLqcmVendors" DisplayAfter="100">
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
					<b><asp:Label ID="L_VendorID" runat="server" Text="Vendor :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_VendorID"
						Text=""
						CssClass = "mytxt"
						onfocus = "return this.select();"
						MaxLength="6"
            Width="42px"
						runat="server" />
				</td>
			</tr>
    </table>
		</asp:Panel>
		<AJX:CollapsiblePanelExtender ID="cpe1" runat="Server" TargetControlID="pnlD" ExpandControlID="pnlH" CollapseControlID="pnlH" Collapsed="True" TextLabelID="lblH" ImageControlID="imgH" ExpandedText="(Hide Filters...)" CollapsedText="(Show Filters...)" ExpandedImage="~/images/ua.png" CollapsedImage="~/images/da.png" SuppressPostBack="true" />
    
    <asp:GridView ID="GVqcmVendors" SkinID="gv_silver" BorderColor="#A9A9A9" width="100%" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ODSqcmVendors" DataKeyNames="VendorID">
      <Columns>
        <asp:TemplateField>
          <ItemTemplate>
						<Table><tr>
              <td><asp:ImageButton ID="cmdEditPage" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' /></td>
						</tr></Table>
          </ItemTemplate>
          <HeaderStyle Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Vendor" SortExpression="VendorID">
          <ItemTemplate>
            <asp:Label ID="LabelVendorID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("VendorID") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="50px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Description" SortExpression="Description">
          <ItemTemplate>
            <asp:Label ID="LabelDescription" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Description") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Contact Person" SortExpression="ContactPerson">
          <ItemTemplate>
            <asp:Label ID="LabelContactPerson" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("ContactPerson") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Contact No" SortExpression="ContactNo">
          <ItemTemplate>
            <asp:Label ID="LabelContactNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("ContactNo") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="50px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Address1" SortExpression="Address1">
          <ItemTemplate>
            <asp:Label ID="LabelAddress1" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Address1") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="100px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSqcmVendors"
      runat = "server"
      DataObjectTypeName = "SIS.QCM.qcmVendors"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "qcmVendorsSelectList"
      TypeName = "SIS.QCM.qcmVendors"
      SelectCountMethod = "qcmVendorsSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_VendorID" PropertyName="Text" Name="VendorID" Type="String" Size="6" />
				<asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
				<asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVqcmVendors" EventName="PageIndexChanged" />
    <asp:AsyncPostBackTrigger ControlID="F_VendorID" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
