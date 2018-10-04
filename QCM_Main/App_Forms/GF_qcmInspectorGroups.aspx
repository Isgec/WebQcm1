<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="GF_qcmInspectorGroups.aspx.vb" Inherits="GF_qcmInspectorGroups" title="Maintain List: Inspector Groups" %>
<asp:Content ID="CPHqcmInspectorGroups" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelqcmInspectorGroups" runat="server" Text="&nbsp;List: Inspector Groups" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLqcmInspectorGroups" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLqcmInspectorGroups"
      ToolType = "lgNMGrid"
      EditUrl = "~/QCM_Main/App_Edit/EF_qcmInspectorGroups.aspx"
      AddUrl = "~/QCM_Main/App_Create/AF_qcmInspectorGroups.aspx?skip=1"
      ValidationGroup = "qcmInspectorGroups"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSqcmInspectorGroups" runat="server" AssociatedUpdatePanelID="UPNLqcmInspectorGroups" DisplayAfter="100">
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
					<asp:TextBox ID="F_GroupID"
						Text=""
            Width="70px"
						style="text-align: right"
						CssClass = "mytxt"
						MaxLength="10"
						onfocus = "return this.select();"
						runat="server" />
					<AJX:MaskedEditExtender 
						ID = "MEEGroupID"
						runat = "server"
						mask = "9999999999"
						AcceptNegative = "Left"
						MaskType="Number"
						MessageValidatorTip="true"
						InputDirection="RightToLeft"
						ErrorTooltipEnabled="true"
						TargetControlID="F_GroupID" />
					<AJX:MaskedEditValidator 
						ID = "MEVGroupID"
						runat = "server"
						ControlToValidate = "F_GroupID"
						ControlExtender = "MEEGroupID"
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
    
    <asp:GridView ID="GVqcmInspectorGroups" SkinID="gv_silver" BorderColor="#A9A9A9" width="100%" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ODSqcmInspectorGroups" DataKeyNames="GroupID">
      <Columns>
        <asp:TemplateField>
          <ItemTemplate>
						<Table><tr>
              <td><asp:ImageButton ID="cmdEditPage" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' /></td>
						</tr></Table>
          </ItemTemplate>
          <HeaderStyle Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Group ID" SortExpression="GroupID">
          <ItemTemplate>
            <asp:Label ID="LabelGroupID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("GroupID") %>'></asp:Label>
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
      ID = "ODSqcmInspectorGroups"
      runat = "server"
      DataObjectTypeName = "SIS.QCM.qcmInspectorGroups"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "qcmInspectorGroupsSelectList"
      TypeName = "SIS.QCM.qcmInspectorGroups"
      SelectCountMethod = "qcmInspectorGroupsSelectCount"
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
    <asp:AsyncPostBackTrigger ControlID="GVqcmInspectorGroups" EventName="PageIndexChanged" />
    <asp:AsyncPostBackTrigger ControlID="F_GroupID" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
