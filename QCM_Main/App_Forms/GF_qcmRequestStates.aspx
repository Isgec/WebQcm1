<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="GF_qcmRequestStates.aspx.vb" Inherits="GF_qcmRequestStates" title="Maintain List: Request States" %>
<asp:Content ID="CPHqcmRequestStates" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelqcmRequestStates" runat="server" Text="&nbsp;List: Request States" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLqcmRequestStates" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLqcmRequestStates"
      ToolType = "lgNMGrid"
      EditUrl = "~/QCM_Main/App_Edit/EF_qcmRequestStates.aspx"
      AddUrl = "~/QCM_Main/App_Create/AF_qcmRequestStates.aspx"
      ValidationGroup = "qcmRequestStates"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSqcmRequestStates" runat="server" AssociatedUpdatePanelID="UPNLqcmRequestStates" DisplayAfter="100">
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
					<b><asp:Label ID="L_StateID" runat="server" Text="Request State ID :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_StateID"
						Text=""
						CssClass = "mytxt"
						onfocus = "return this.select();"
						MaxLength="10"
            Width="70px"
						runat="server" />
				</td>
			</tr>
    </table>
		</asp:Panel>
		<AJX:CollapsiblePanelExtender ID="cpe1" runat="Server" TargetControlID="pnlD" ExpandControlID="pnlH" CollapseControlID="pnlH" Collapsed="True" TextLabelID="lblH" ImageControlID="imgH" ExpandedText="(Hide Filters...)" CollapsedText="(Show Filters...)" ExpandedImage="~/images/ua.png" CollapsedImage="~/images/da.png" SuppressPostBack="true" />
    
    <asp:GridView ID="GVqcmRequestStates" SkinID="gv_silver" BorderColor="#A9A9A9" width="100%" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ODSqcmRequestStates" DataKeyNames="StateID">
      <Columns>
        <asp:TemplateField>
          <ItemTemplate>
						<Table><tr>
              <td><asp:ImageButton ID="cmdEditPage" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' /></td>
						</tr></Table>
          </ItemTemplate>
          <HeaderStyle Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Request State ID" SortExpression="StateID">
          <ItemTemplate>
            <asp:Label ID="LabelStateID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("StateID") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="50px" />
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
      ID = "ODSqcmRequestStates"
      runat = "server"
      DataObjectTypeName = "SIS.QCM.qcmRequestStates"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "qcmRequestStatesSelectList"
      TypeName = "SIS.QCM.qcmRequestStates"
      SelectCountMethod = "qcmRequestStatesSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_StateID" PropertyName="Text" Name="StateID" Type="String" Size="10" />
				<asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
				<asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVqcmRequestStates" EventName="PageIndexChanged" />
    <asp:AsyncPostBackTrigger ControlID="F_StateID" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
