<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="GF_rpRequestList.aspx.vb" Inherits="GF_rpRequestList" title="Report: Request List" %>
<asp:Content ID="CPHvrReports" ContentPlaceHolderID="cph1" runat="Server">
  <div class="ui-widget-content page">
    <div class="caption">
      <asp:Label ID="LabelvrReports" runat="server" Text="&nbsp;Print: Request List" Width="100%" CssClass="sis_formheading"></asp:Label>
    </div>
    <div class="pagedata" style="min-height: 350px!important;">
      <LGM:ToolBar0
        ID="TBLvrReports"
        ToolType="lgNMAdd"
        InsertAndStay="False"
        ValidationGroup="vrReports"
        runat="server" />
      <asp:FormView ID="FVvrReports"
        runat="server"
        DataKeyNames="FProject"
        DataSourceID="ODSvrReports"
        DefaultMode="Insert" CssClass="sis_formview">
        <InsertItemTemplate>
          <asp:Label ID="L_ErrMsgvrReports" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
          <table width="100%">
            <tr>
              <td class="alignright">
                <b>
                  <asp:Label ID="L_FReqDt" runat="server" Text="From Request Date :" /></b>
              </td>
              <td>
                <asp:TextBox ID="F_FReqDt"
                  Text='<%# Bind("FReqDt") %>'
                  Width="70px"
                  CssClass="mytxt"
                  ValidationGroup="vrReports"
                  onfocus="return this.select();"
                  runat="server" />
                <asp:Image ID="ImageButtonFReqDt" runat="server" ToolTip="Click to open calendar" Style="cursor: pointer; vertical-align: bottom" ImageUrl="~/Images/cal.png" />
                <AJX:CalendarExtender
                  ID="CEFReqDt"
                  TargetControlID="F_FReqDt"
                  Format="dd/MM/yyyy"
                  runat="server" CssClass="MyCalendar" PopupButtonID="ImageButtonFReqDt" />
                <AJX:MaskedEditExtender
                  ID="MEEFReqDt"
                  runat="server"
                  Mask="99/99/9999"
                  MaskType="Date"
                  CultureName="en-GB"
                  MessageValidatorTip="true"
                  InputDirection="LeftToRight"
                  ErrorTooltipEnabled="true"
                  TargetControlID="F_FReqDt" />
                <AJX:MaskedEditValidator
                  ID="MEVFReqDt"
                  runat="server"
                  ControlToValidate="F_FReqDt"
                  ControlExtender="MEEFReqDt"
                  InvalidValueMessage="Invalid Date."
                  EmptyValueMessage="Date is required."
                  EmptyValueBlurredText="[Required!]"
                  Display="Dynamic"
                  TooltipMessage="Enter Date."
                  EnableClientScript="true"
                  ValidationGroup="vrReports"
                  IsValidEmpty="false"
                  SetFocusOnError="true" />
              </td>
              <td class="alignright">
                <b>
                  <asp:Label ID="L_TReqDt" runat="server" Text="To Request Date :" /></b>
              </td>
              <td>
                <asp:TextBox ID="F_TReqDt"
                  Text='<%# Bind("TReqDt") %>'
                  Width="70px"
                  CssClass="mytxt"
                  ValidationGroup="vrReports"
                  onfocus="return this.select();"
                  runat="server" />
                <asp:Image ID="ImageButtonTReqDt" runat="server" ToolTip="Click to open calendar" Style="cursor: pointer; vertical-align: bottom" ImageUrl="~/Images/cal.png" />
                <AJX:CalendarExtender
                  ID="CETReqDt"
                  TargetControlID="F_TReqDt"
                  Format="dd/MM/yyyy"
                  runat="server" CssClass="MyCalendar" PopupButtonID="ImageButtonTReqDt" />
                <AJX:MaskedEditExtender
                  ID="MEETReqDt"
                  runat="server"
                  Mask="99/99/9999"
                  MaskType="Date"
                  CultureName="en-GB"
                  MessageValidatorTip="true"
                  InputDirection="LeftToRight"
                  ErrorTooltipEnabled="true"
                  TargetControlID="F_TReqDt" />
                <AJX:MaskedEditValidator
                  ID="MEVTReqDt"
                  runat="server"
                  ControlToValidate="F_TReqDt"
                  ControlExtender="MEETReqDt"
                  InvalidValueMessage="Invalid Date."
                  EmptyValueMessage="Date is required."
                  EmptyValueBlurredText="[Required!]"
                  Display="Dynamic"
                  TooltipMessage="Enter Date."
                  EnableClientScript="true"
                  ValidationGroup="vrReports"
                  IsValidEmpty="false"
                  SetFocusOnError="true" />
              </td>
            </tr>
            <tr>
              <td class="alignright">
                <b>
                  <asp:Label ID="L_FUser" runat="server" Text="Quality Inspector :" /></b>
              </td>
              <td>
                <asp:TextBox
                  ID="F_FUser"
                  CssClass="myfktxt"
                  Width="56px"
                  Text='<%# Bind("FUser") %>'
                  AutoCompleteType="None"
                  onfocus="return this.select();"
                  ToolTip="Enter Requester."
                  onblur="script_vrReports.validate_FUser(this);"
                  runat="Server" />
                <asp:Label
                  ID="F_FUser_Display"
                  Text='<%# Eval("aspnet_Users1_UserFullName") %>'
                  runat="Server" />
                <AJX:AutoCompleteExtender
                  ID="ACEFUser"
                  BehaviorID="B_ACEFUser"
                  ContextKey=""
                  UseContextKey="true"
                  ServiceMethod="FUserCompletionList"
                  TargetControlID="F_FUser"
                  EnableCaching="false"
                  CompletionInterval="100"
                  FirstRowSelected="true"
                  MinimumPrefixLength="1"
                  OnClientItemSelected="script_vrReports.ACEFUser_Selected"
                  OnClientPopulating="script_vrReports.ACEFUser_Populating"
                  OnClientPopulated="script_vrReports.ACEFUser_Populated"
                  CompletionSetCount="10"
                  CompletionListCssClass="autocomplete_completionListElement"
                  CompletionListItemCssClass="autocomplete_listItem"
                  CompletionListHighlightedItemCssClass="autocomplete_highlightedListItem"
                  runat="Server" />
              </td>
              <td class="alignright">
                <b>
                  <asp:Label ID="L_RegionID" runat="server" Text="Inspection Region :" /></b>
              </td>
              <td>
                <LGM:LC_qcmRegions
                  ID="F_RegionID"
                  CssClass="myfktxt"
                  Width="170px"
                  SelectedValue='<%# Bind("RegionID") %>'
                  DataTextField="RegionName"
                  DataValueField="RegionID"
                  IncludeDefault="true"
                  DefaultText="-- Select --"
                  ToolTip="Enter value for Region ID."
                  Runat="Server" />
              </td>
            </tr>
            <tr>
              <td colspan="4" style="text-align: center;padding:10px;">
                <asp:CheckBox ID="F_AllCompany" runat="server" Checked='<%# Bind("AllCompany") %>' Text="All Company" TextAlign="Left" Font-Bold="true" />
              </td>
            </tr>
            <tr>
              <td colspan="4" style="text-align: center">
                <asp:Button runat="server" ID="cmdGenerate" Text="  PRINT  " BackColor="Aqua" CausesValidation="true" ValidationGroup="vrReports" CommandName="Insert" />
              </td>
            </tr>
          </table>
        </InsertItemTemplate>
      </asp:FormView>
      <asp:ObjectDataSource
        ID="ODSvrReports"
        DataObjectTypeName="SIS.VR.vrReports"
        InsertMethod="vrReportsInsert"
        OldValuesParameterFormatString="original_{0}"
        TypeName="SIS.VR.vrReports"
        SelectMethod="GetNewRecord"
        runat="server"></asp:ObjectDataSource>
    </div>
  </div>
</asp:Content>
