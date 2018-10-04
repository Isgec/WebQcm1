<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="GF_qcmRegions.aspx.vb" Inherits="GF_qcmRegions" title="Maintain List: Regions" %>
<asp:Content ID="CPHqcmRegions" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelqcmRegions" runat="server" Text="&nbsp;List: Regions" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLqcmRegions" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLqcmRegions"
      ToolType = "lgNMGrid"
      EditUrl = "~/QCM_Main/App_Edit/EF_qcmRegions.aspx"
      AddUrl = "~/QCM_Main/App_Create/AF_qcmRegions.aspx"
      ValidationGroup = "qcmRegions"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSqcmRegions" runat="server" AssociatedUpdatePanelID="UPNLqcmRegions" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVqcmRegions" SkinID="gv_silver" BorderColor="#A9A9A9" width="100%" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ODSqcmRegions" DataKeyNames="RegionID">
      <Columns>
        <asp:TemplateField>
          <ItemTemplate>
						<Table><tr>
              <td><asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' /></td>
						</tr></Table>
          </ItemTemplate>
          <HeaderStyle Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Region ID" SortExpression="RegionID">
          <ItemTemplate>
            <asp:Label ID="LabelRegionID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("RegionID") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle CssClass="alignright" />
          <ItemStyle CssClass="alignright" />
          <HeaderStyle Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Region Name" SortExpression="RegionName">
          <ItemTemplate>
            <asp:Label ID="LabelRegionName" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("RegionName") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="100px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSqcmRegions"
      runat = "server"
      DataObjectTypeName = "SIS.QCM.qcmRegions"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "qcmRegionsSelectList"
      TypeName = "SIS.QCM.qcmRegions"
      SelectCountMethod = "qcmRegionsSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
				<asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
				<asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVqcmRegions" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
