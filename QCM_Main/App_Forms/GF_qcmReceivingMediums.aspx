<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="GF_qcmReceivingMediums.aspx.vb" Inherits="GF_qcmReceivingMediums" title="Maintain List: Receiving Mediums" %>
<asp:Content ID="CPHqcmReceivingMediums" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelqcmReceivingMediums" runat="server" Text="&nbsp;List: Receiving Mediums" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLqcmReceivingMediums" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLqcmReceivingMediums"
      ToolType = "lgNMGrid"
      EditUrl = "~/QCM_Main/App_Edit/EF_qcmReceivingMediums.aspx"
      AddUrl = "~/QCM_Main/App_Create/AF_qcmReceivingMediums.aspx"
      ValidationGroup = "qcmReceivingMediums"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSqcmReceivingMediums" runat="server" AssociatedUpdatePanelID="UPNLqcmReceivingMediums" DisplayAfter="100">
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
					<b><asp:Label ID="L_ReceivingMediumID" runat="server" Text="Receiving Medium ID :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_ReceivingMediumID"
						Text=""
            Width="70px"
						style="text-align: right"
						CssClass = "mytxt"
						MaxLength="10"
						onfocus = "return this.select();"
						runat="server" />
					<AJX:MaskedEditExtender 
						ID = "MEEReceivingMediumID"
						runat = "server"
						mask = "9999999999"
						AcceptNegative = "Left"
						MaskType="Number"
						MessageValidatorTip="true"
						InputDirection="RightToLeft"
						ErrorTooltipEnabled="true"
						TargetControlID="F_ReceivingMediumID" />
					<AJX:MaskedEditValidator 
						ID = "MEVReceivingMediumID"
						runat = "server"
						ControlToValidate = "F_ReceivingMediumID"
						ControlExtender = "MEEReceivingMediumID"
						InvalidValueMessage = "*"
						EmptyValueMessage = ""
						EmptyValueBlurredText = ""
						Display = "Dynamic"
						EnableClientScript = "true"
						IsValidEmpty = "True"
						SetFocusOnError="true" />
				</td>
			</tr>
    </table>
		</asp:Panel>
		<AJX:CollapsiblePanelExtender ID="cpe1" runat="Server" TargetControlID="pnlD" ExpandControlID="pnlH" CollapseControlID="pnlH" Collapsed="True" TextLabelID="lblH" ImageControlID="imgH" ExpandedText="(Hide Filters...)" CollapsedText="(Show Filters...)" ExpandedImage="~/images/ua.png" CollapsedImage="~/images/da.png" SuppressPostBack="true" />
    
    <asp:GridView ID="GVqcmReceivingMediums" SkinID="gv_silver" BorderColor="#A9A9A9" width="100%" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ODSqcmReceivingMediums" DataKeyNames="ReceivingMediumID">
      <Columns>
        <asp:TemplateField>
          <ItemTemplate>
						<Table><tr>
              <td><asp:ImageButton ID="cmdEditPage" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' /></td>
						</tr></Table>
          </ItemTemplate>
          <HeaderStyle Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Receiving Medium ID" SortExpression="ReceivingMediumID">
          <ItemTemplate>
            <asp:Label ID="LabelReceivingMediumID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("ReceivingMediumID") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle CssClass="alignright" />
          <ItemStyle CssClass="alignright" />
          <HeaderStyle Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Description" SortExpression="Description">
          <ItemTemplate>
            <asp:Label ID="LabelDescription" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Description") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="100px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSqcmReceivingMediums"
      runat = "server"
      DataObjectTypeName = "SIS.QCM.qcmReceivingMediums"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "qcmReceivingMediumsSelectList"
      TypeName = "SIS.QCM.qcmReceivingMediums"
      SelectCountMethod = "qcmReceivingMediumsSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_ReceivingMediumID" PropertyName="Text" Name="ReceivingMediumID" Type="Int32" Size="10" />
				<asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
				<asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVqcmReceivingMediums" EventName="PageIndexChanged" />
    <asp:AsyncPostBackTrigger ControlID="F_ReceivingMediumID" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
