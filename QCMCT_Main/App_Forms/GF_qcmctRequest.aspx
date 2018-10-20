<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_qcmctRequest.aspx.vb" Inherits="GF_qcmctRequest" title="Maintain List: CT Request" %>
<asp:Content ID="CPHqcmctRequest" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelqcmctRequest" runat="server" Text="&nbsp;List: CT Request"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLqcmctRequest" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLqcmctRequest"
      ToolType = "lgNMGrid"
      EditUrl = "~/QCMCT_Main/App_Edit/EF_qcmctRequest.aspx"
      AddUrl = "~/QCMCT_Main/App_Create/AF_qcmctRequest.aspx"
      AddPostBack = "True"
      ValidationGroup = "qcmctRequest"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSqcmctRequest" runat="server" AssociatedUpdatePanelID="UPNLqcmctRequest" DisplayAfter="100">
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
          <b><asp:Label ID="L_QCRequestNo" runat="server" Text="QC Request No :" /></b>
        </td>
        <td>
          <asp:TextBox ID="F_QCRequestNo"
            Text=""
            Width="88px"
            style="text-align: right"
            CssClass = "mytxt"
            MaxLength="10"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEQCRequestNo"
            runat = "server"
            mask = "9999999999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_QCRequestNo" />
          <AJX:MaskedEditValidator 
            ID = "MEVQCRequestNo"
            runat = "server"
            ControlToValidate = "F_QCRequestNo"
            ControlExtender = "MEEQCRequestNo"
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
    <asp:GridView ID="GVqcmctRequest" SkinID="gv_silver" runat="server" DataSourceID="ODSqcmctRequest" DataKeyNames="QCRequestNo,SerialNo,PONumber,ItemReference,ActivityID">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" ValidationGroup="Edit" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="PO Number" SortExpression="PONumber">
          <ItemTemplate>
            <asp:Label ID="LabelPONumber" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("PONumber") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
        <HeaderStyle CssClass="alignCenter" Width="50px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Item Reference" SortExpression="ItemReference">
          <ItemTemplate>
            <asp:Label ID="LabelItemReference" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("ItemReference") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
        <HeaderStyle CssClass="alignCenter" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Sub Item" SortExpression="Activity2Desc">
          <ItemTemplate>
            <asp:Label ID="LabelActivity2Desc" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Activity2Desc") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
        <HeaderStyle CssClass="alignCenter" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Quantity" SortExpression="Quantity">
          <ItemTemplate>
            <asp:Label ID="LabelQuantity" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Quantity") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Partial Or Full" SortExpression="PartialOrFull">
          <ItemTemplate>
            <asp:Label ID="LabelPartialOrFull" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("PartialOrFull") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
        <HeaderStyle CssClass="alignCenter" Width="50px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Percent Of PO Quantity" SortExpression="PercentOfQuantity">
          <ItemTemplate>
            <asp:Label ID="LabelPercentOfQuantity" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("PercentOfQuantity") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle CssClass="alignCenter" Width="80px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Items NOT Selected" SortExpression="NotSelectedList">
          <ItemTemplate>
            <asp:Label ID="LabelNotSelectedList" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("NotSelectedList") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
        <HeaderStyle CssClass="alignCenter" Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Items Selected" SortExpression="SelectedList">
          <ItemTemplate>
            <asp:Label ID="LabelSelectedList" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("SelectedList") %>'></asp:Label>
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
        <HeaderStyle CssClass="alignCenter" Width="100px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSqcmctRequest"
      runat = "server"
      DataObjectTypeName = "SIS.QCMCT.qcmctRequest"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_qcmctRequestSelectList"
      TypeName = "SIS.QCMCT.qcmctRequest"
      SelectCountMethod = "qcmctRequestSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_QCRequestNo" PropertyName="Text" Name="QCRequestNo" Type="Int32" Size="10" />
        <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
        <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    <br />
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVqcmctRequest" EventName="PageIndexChanged" />
    <asp:AsyncPostBackTrigger ControlID="F_QCRequestNo" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
