<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="False" CodeFile="GF_pakQCPO.aspx.vb" Inherits="GF_pakQCPO" title="Maintain List: Implement Quality Clearance in PO" %>
<asp:Content ID="CPHpakQCPO" ContentPlaceHolderID="cph1" runat="Server">
  <div class="ui-widget-content page">
    <div class="caption">
      <asp:Label ID="LabelpakQCPO" runat="server" Text="&nbsp;List: Quality Clearance can be Implemented in PO"></asp:Label>
    </div>
    <div class="pagedata">
      <asp:UpdatePanel ID="UPNLpakQCPO" runat="server">
        <ContentTemplate>
          <table width="100%">
            <tr>
              <td class="sis_formview">
                <LGM:ToolBar0
                  ID="TBLpakQCPO"
                  ToolType="lgNMGrid"
                  EditUrl="~/PAK_Main/App_Edit/EF_pakQCPO.aspx"
                  EnableAdd="False"
                  ValidationGroup="pakQCPO"
                  runat="server" />
                <asp:UpdateProgress ID="UPGSpakQCPO" runat="server" AssociatedUpdatePanelID="UPNLpakQCPO" DisplayAfter="100">
                  <ProgressTemplate>
                    <span style="color: #ff0033">Loading...</span>
                  </ProgressTemplate>
                </asp:UpdateProgress>
                <style>
                  .nt-but-danger {
                    border: 1pt solid #960825;
                    background-color: #d1062f;
                    color: white;
                  }

                  .nt-but-primary {
                    border: 1pt solid #5780f8;
                    background-color: #2196F3;
                    color: black;
                  }

                  .nt-but-grey {
                    border: 1pt solid gray;
                    background-color: #bdbcbc;
                    color: black;
                  }

                  .nt-but-success {
                    border: 1pt solid #049317;
                    background-color: #06bf1e;
                    color: white;
                  }

                  .nt-but-warning {
                    border: 1pt solid #ff6a00;
                    background-color: #ffd800;
                    color:white;
                  }

                  .nt-but-danger,
                  .nt-but-grey,
                  .nt-but-primary,
                  .nt-but-warning,
                  .nt-but-success {
                    border-radius: 4px;
                    height: 20px;
                    font-size: 12px;
                    font-weight: bold;
                  }

                    .nt-but-warning:hover,
                    .nt-but-danger:hover,
                    .nt-but-grey:hover,
                    .nt-but-primary:hover,
                    .nt-but-success:hover {
                      border: 1pt solid orange;
                      opacity: 0.7;
                    }
                </style>
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
                        <b>
                          <asp:Label ID="L_ProjectID" runat="server" Text="Project :" /></b>
                      </td>
                      <td>
                        <asp:TextBox
                          ID="F_ProjectID"
                          CssClass="myfktxt"
                          Width="56px"
                          Text=""
                          onfocus="return this.select();"
                          AutoCompleteType="None"
                          onblur="validate_ProjectID(this);"
                          runat="Server" />
                        <asp:Label
                          ID="F_ProjectID_Display"
                          Text=""
                          runat="Server" />
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
                          CompletionListCssClass="autocomplete_completionListElement"
                          CompletionListItemCssClass="autocomplete_listItem"
                          CompletionListHighlightedItemCssClass="autocomplete_highlightedListItem"
                          runat="Server" />
                      </td>
                    </tr>
                    <tr style="display: none;">
                      <td class="alignright">
                        <b>
                          <asp:Label ID="L_BuyerID" runat="server" Text="Buyer :" /></b>
                      </td>
                      <td>
                        <asp:TextBox
                          ID="F_BuyerID"
                          CssClass="myfktxt"
                          Width="72px"
                          Text=""
                          onfocus="return this.select();"
                          AutoCompleteType="None"
                          onblur="validate_BuyerID(this);"
                          runat="Server" />
                        <asp:Label
                          ID="F_BuyerID_Display"
                          Text=""
                          runat="Server" />
                        <AJX:AutoCompleteExtender
                          ID="ACEBuyerID"
                          BehaviorID="B_ACEBuyerID"
                          ContextKey=""
                          UseContextKey="true"
                          ServiceMethod="BuyerIDCompletionList"
                          TargetControlID="F_BuyerID"
                          CompletionInterval="100"
                          FirstRowSelected="true"
                          MinimumPrefixLength="1"
                          OnClientItemSelected="ACEBuyerID_Selected"
                          OnClientPopulating="ACEBuyerID_Populating"
                          OnClientPopulated="ACEBuyerID_Populated"
                          CompletionSetCount="10"
                          CompletionListCssClass="autocomplete_completionListElement"
                          CompletionListItemCssClass="autocomplete_listItem"
                          CompletionListHighlightedItemCssClass="autocomplete_highlightedListItem"
                          runat="Server" />
                      </td>
                    </tr>
                    <tr style="display: none;">
                      <td class="alignright">
                        <b>
                          <asp:Label ID="L_IssuedBy" runat="server" Text="Issued By :" /></b>
                      </td>
                      <td>
                        <asp:TextBox
                          ID="F_IssuedBy"
                          CssClass="myfktxt"
                          Width="72px"
                          Text=""
                          onfocus="return this.select();"
                          AutoCompleteType="None"
                          onblur="validate_IssuedBy(this);"
                          runat="Server" />
                        <asp:Label
                          ID="F_IssuedBy_Display"
                          Text=""
                          runat="Server" />
                        <AJX:AutoCompleteExtender
                          ID="ACEIssuedBy"
                          BehaviorID="B_ACEIssuedBy"
                          ContextKey=""
                          UseContextKey="true"
                          ServiceMethod="IssuedByCompletionList"
                          TargetControlID="F_IssuedBy"
                          CompletionInterval="100"
                          FirstRowSelected="true"
                          MinimumPrefixLength="1"
                          OnClientItemSelected="ACEIssuedBy_Selected"
                          OnClientPopulating="ACEIssuedBy_Populating"
                          OnClientPopulated="ACEIssuedBy_Populated"
                          CompletionSetCount="10"
                          CompletionListCssClass="autocomplete_completionListElement"
                          CompletionListItemCssClass="autocomplete_listItem"
                          CompletionListHighlightedItemCssClass="autocomplete_highlightedListItem"
                          runat="Server" />
                      </td>
                    </tr>
                    <tr>
                      <td colspan="2" style="padding:10px;vertical-align:middle;">
                        <asp:HyperLink runat="server" NavigateUrl="~/MISView.aspx" CssClass="nt-but-warning" Target="_blank" Text="Online QC Progress Data"></asp:HyperLink>
                      </td>
                    </tr>
                  </table>
                </asp:Panel>
                <AJX:CollapsiblePanelExtender ID="cpe1" runat="Server" TargetControlID="pnlD" ExpandControlID="pnlH" CollapseControlID="pnlH" Collapsed="True" TextLabelID="lblH" ImageControlID="imgH" ExpandedText="(Hide Filters...)" CollapsedText="(Show Filters...)" ExpandedImage="~/images/ua.png" CollapsedImage="~/images/da.png" SuppressPostBack="true" />
                <asp:GridView ID="GVpakQCPO" SkinID="gv_silver" runat="server" DataSourceID="ODSpakQCPO" DataKeyNames="SerialNo">
                  <Columns>
                    <asp:TemplateField HeaderText="Serial No" SortExpression="SerialNo">
                      <ItemTemplate>
                        <asp:Label ID="LabelSerialNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("SerialNo") %>'></asp:Label>
                      </ItemTemplate>
                      <ItemStyle CssClass="alignCenter" />
                      <HeaderStyle CssClass="alignCenter" Width="40px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="PO Number" SortExpression="PONumber">
                      <ItemTemplate>
                        <asp:Label ID="LabelPONumber" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("PONumber") %>'></asp:Label>
                      </ItemTemplate>
                      <ItemStyle CssClass="alignCenter" />
                      <HeaderStyle CssClass="alignCenter" Width="50px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="REV." SortExpression="PORevision">
                      <ItemTemplate>
                        <asp:Label ID="LabelPORevision" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("PORevision") %>'></asp:Label>
                      </ItemTemplate>
                      <ItemStyle CssClass="alignCenter" />
                      <HeaderStyle CssClass="alignCenter" Width="50px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="PO Date" SortExpression="PODate">
                      <ItemTemplate>
                        <asp:Label ID="LabelPODate" runat="server" ForeColor='<%# Eval("ForeColor") %>' Text='<%# Bind("PODate") %>'></asp:Label>
                      </ItemTemplate>
                      <ItemStyle CssClass="alignCenter" />
                      <HeaderStyle CssClass="alignCenter" Width="90px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Supplier" SortExpression="VR_BusinessPartner9_BPName">
                      <ItemTemplate>
                        <asp:Label ID="L_BuyerID" runat="server" ForeColor='<%# Eval("ForeColor") %>' Title='<%# EVal("SupplierID") %>' Text='<%# Eval("VR_BusinessPartner9_BPName") %>'></asp:Label>
                      </ItemTemplate>
                      <HeaderStyle Width="100px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Project" SortExpression="IDM_Projects4_Description">
                      <ItemTemplate>
                        <asp:Label ID="L_ProjectID" runat="server" ForeColor='<%# Eval("ForeColor") %>' Title='<%# EVal("ProjectID") %>' Text='<%# Eval("IDM_Projects4_Description") %>'></asp:Label>
                      </ItemTemplate>
                      <HeaderStyle Width="100px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="PO Description" SortExpression="PODescription">
                      <ItemTemplate>
                        <asp:Label ID="LabelPODescription" runat="server" ForeColor='<%# Eval("ForeColor") %>' Text='<%# Bind("PODescription") %>'></asp:Label>
                      </ItemTemplate>
                      <ItemStyle CssClass="alignCenter" />
                      <HeaderStyle CssClass="alignCenter" Width="100px" />
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="QC Mandatory">
                      <ItemTemplate>
                        <asp:Button ID="cmdQCRequired" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("QCRequired") %>' Text='<%# Eval("QCRequired") %>' CommandName="cmdQCRequired" CommandArgument='<%# Container.DataItemIndex %>' OnClientClick="return confirm('Change Status?');" />
                      </ItemTemplate>
                      <ItemStyle CssClass="alignCenter" />
                      <HeaderStyle CssClass="alignCenter" Width="90px" />
                    </asp:TemplateField>
                  </Columns>
                  <EmptyDataTemplate>
                    <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
                  </EmptyDataTemplate>
                </asp:GridView>
                <asp:ObjectDataSource
                  ID="ODSpakQCPO"
                  runat="server"
                  DataObjectTypeName="SIS.PAK.pakQCPO"
                  OldValuesParameterFormatString="original_{0}"
                  SelectMethod="UZ_pakQCPOSelectList"
                  TypeName="SIS.PAK.pakQCPO"
                  SelectCountMethod="pakQCPOSelectCount"
                  SortParameterName="OrderBy" EnablePaging="True">
                  <SelectParameters>
                    <asp:ControlParameter ControlID="F_ProjectID" PropertyName="Text" Name="ProjectID" Type="String" Size="6" />
                    <asp:ControlParameter ControlID="F_BuyerID" PropertyName="Text" Name="BuyerID" Type="String" Size="8" />
                    <asp:ControlParameter ControlID="F_IssuedBy" PropertyName="Text" Name="IssuedBy" Type="String" Size="8" />
                    <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
                    <asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
                  </SelectParameters>
                </asp:ObjectDataSource>
                <br />
              </td>
            </tr>
          </table>
        </ContentTemplate>
        <Triggers>
          <asp:AsyncPostBackTrigger ControlID="GVpakQCPO" EventName="PageIndexChanged" />
          <asp:AsyncPostBackTrigger ControlID="F_ProjectID" />
          <asp:AsyncPostBackTrigger ControlID="F_BuyerID" />
          <asp:AsyncPostBackTrigger ControlID="F_IssuedBy" />
        </Triggers>
      </asp:UpdatePanel>
    </div>
  </div>
</asp:Content>
