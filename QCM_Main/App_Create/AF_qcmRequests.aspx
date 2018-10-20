<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_qcmRequests.aspx.vb" Inherits="AF_qcmRequests" title="Add: Inspection Requests" %>
<asp:Content ID="CPHqcmRequests" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmRequests" runat="server" Text="&nbsp;Add: Inspection Requests" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmRequests" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmRequests"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    AfterInsertURL = "~/QCM_Main/App_Edit/EF_qcmRequests.aspx"
    ValidationGroup = "qcmRequests"
    runat = "server" />
<asp:FormView ID="FVqcmRequests"
	runat = "server"
	DataKeyNames = "RequestID"
	DataSourceID = "ODSqcmRequests"
	DefaultMode = "Insert" CssClass="sis_formview">
	<InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td colspan="4" style="text-align:right;">
          <asp:Label ID="L_ErrMsgqcmRequests" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
        </td>
      </tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_RequestID" ForeColor="#CC6633" runat="server" Text="Request ID :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_RequestID" Enabled="False" CssClass="mypktxt" width="70px" runat="server" Text="0" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_OrderNo" runat="server" Text="Purchase Order No :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_OrderNo"
						Text='<%# Bind("OrderNo") %>'
						CssClass = "mytxt"
						onfocus = "return this.select();"
						ValidationGroup="qcmRequests"
            onblur="script_erpPO.validate_ERPPONumber(this);"
            ToolTip="Enter Purchase Order No."
						MaxLength="9"
            Width="90px"
						runat="server" />
					<asp:RequiredFieldValidator 
						ID = "RFVOrderNo"
						runat = "server"
						ControlToValidate = "F_OrderNo"
						Text = "[Required!]"
						ErrorMessage = "[Required!]"
						Display = "Dynamic"
						EnableClientScript = "true"
						ValidationGroup = "qcmRequests"
            ForeColor="Red" 
						SetFocusOnError="true" />
          <asp:Label ID="D_ERPPONumber" runat="server" Text=""></asp:Label>
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="Label2" runat="server" Text="PO Weight [Kg] :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_POWeight"
						Text='<%# Bind("POWeight") %>'
						CssClass = "dmytxt"
            Width="90px"
            Enabled="False" 
            style="text-align:right;"
						runat="server" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_ProjectID" runat="server" Text="Project ID :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_ProjectID"
						CssClass = "dmytxt"
            Width="72px"
						Text='<%# Bind("ProjectID") %>'
						ValidationGroup = "qcmRequests"
            onblur= "script_qcmRequests.validate_ProjectID(this);"
						Runat="Server" />
					<asp:Label
						ID = "F_ProjectID_Display"
						Text='<%# Eval("IDM_Projects6_Description") %>'
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
						CssClass = "dmytxt"
            Width="92px"
						Text='<%# Bind("SupplierID") %>'
						ValidationGroup = "qcmRequests"
            onblur= "script_qcmRequests.validate_SupplierID(this);"
						Runat="Server" />
					<asp:Label
						ID = "F_SupplierID_Display"
						Text='<%# Eval("IDM_Vendors7_Description") %>'
						Runat="Server" />
        </td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_CreationRemarks" runat="server" Text="Place of Inspection / Contact Details :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_CreationRemarks"
						Text='<%# Bind("CreationRemarks") %>'
						CssClass = "mytxt"
						onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter place of inspection"
						MaxLength="500"
            Width="350px" Height="40px" TextMode="MultiLine"
						runat="server" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_RegionID" runat="server" Text="Inspection Region :" /></b>
				</td>
        <td>
					<LGM:LC_qcmRegions 
						ID = "F_RegionID"
						CssClass = "myfktxt"
            Width="170px"
					  SelectedValue='<%# Bind("RegionID") %>'
            DataTextField="RegionName"
            DataValueField="RegionID"
            IncludeDefault="true"
            DefaultText="-- Select --"
            RequiredFieldErrorMessage = "[Required!]"
            ToolTip="Enter value for Region ID."
						ValidationGroup = "qcmRequests"
						Runat="Server" />
        </td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_Description" runat="server" Text="Item Description :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_Description"
						Text='<%# Bind("Description") %>'
						CssClass = "mytxt"
						onfocus = "return this.select();"
						ValidationGroup="qcmRequests"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter Item Description."
						MaxLength="500"
            Width="350px" Height="40px" TextMode="MultiLine"
						runat="server" />
					<asp:RequiredFieldValidator 
						ID = "RFVDescription"
						runat = "server"
						ControlToValidate = "F_Description"
						Text = "[Required!]"
						ErrorMessage = "[Required!]"
						Display = "Dynamic"
						EnableClientScript = "true"
						ValidationGroup = "qcmRequests"
            ForeColor="Red" 
						SetFocusOnError="true" />
				</td>
			</tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_InspectionStageiD" runat="server" Text="Inspection Stage :" /></b>
        </td>
        <td colspan="3">
          <LGM:LC_qcmInspectionStages
            ID="F_InspectionStageiD"
            SelectedValue='<%# Bind("InspectionStageiD") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
            ValidationGroup = "qcmRequests"
            RequiredFieldErrorMessage = "[Required!]"
            Runat="Server" />
          </td>
      </tr>
			<tr>
        <td></td>
        <td>
          <table style="width:100%;margin:auto">
            <tr>
				      <td class="alignleft">
					      <b><asp:Label ID="L_TotalRequestedQuantity" runat="server" Text="Stage Requested Quantity" /></b>
				      </td>
				      <td class="alignCenter">
					      <b><asp:Label ID="Label4" runat="server" Text="Final Requested Quantity" /></b>
				      </td>
            </tr>
            <tr>
				      <td class="alignleft">
                <asp:TextBox ID="F_TotalRequestedQuantity"
                  Text='<%# Bind("TotalRequestedQuantity") %>'
                  Width="130px"
                  CssClass = "mytxt"
                  style="text-align: Right"
                  MaxLength="14"
                  onfocus = "return this.select();"
						      ValidationGroup = "qcmRequests"
                  ClientIDMode="Static"
                  type="number"
                  onblur="return dc(this,2);"
                  runat="server" />
                <asp:RequiredFieldValidator 
                  ID = "RFVTotalRequestedQuantity"
                  runat = "server"
                  ControlToValidate = "F_TotalRequestedQuantity"
                  Text = "Required."
                  ErrorMessage = "[Required!]"
                  Display = "Dynamic"
                  EnableClientScript = "true"
						      ValidationGroup = "qcmRequests"
                  ForeColor="Red"
                  ClientIDMode="Static"
                  SetFocusOnError="true" />
				      </td>
				      <td class="alignCenter">
                <asp:TextBox ID="F_LotSize"
                  Text='<%# Bind("LotSize") %>'
                  Width="130px"
                  CssClass = "mytxt"
                  style="text-align: Right"
                  MaxLength="14"
                  onfocus = "return this.select();"
                  ValidationGroup = "qcmRequests"
                  ClientIDMode="Static"
                  type="number"
                  onblur="return dc(this,2);"
                  runat="server" />
                <asp:RequiredFieldValidator 
                  ID = "RFVLotSize"
                  runat = "server"
                  ControlToValidate = "F_LotSize"
                  Text = "Required."
                  ErrorMessage = "[Required!]"
                  Display = "Dynamic"
                  EnableClientScript = "true"
						      ValidationGroup = "qcmRequests"
                  ForeColor="Red"
                  ClientIDMode="Static"
                  SetFocusOnError="true" />
              </td>
            </tr>
          </table>
        </td>
			</tr>
      <tr>
				<td class="alignright">
					<b><asp:Label ID="Label1" runat="server" Text="UOM :" /></b>
				</td>
        <td>
          <asp:DropDownList
            ID="F_UOM"
            SelectedValue='<%# Bind("UOM") %>'
            CssClass = "myddl"
            Width="150px"
            Runat="Server" >
            <asp:ListItem Value="">---Select---</asp:ListItem>
            <asp:ListItem Value="Nos">Nos</asp:ListItem>
            <asp:ListItem Value="MT">MT</asp:ListItem>
            <asp:ListItem Value="Package">Package</asp:ListItem>
          </asp:DropDownList>
					<asp:RequiredFieldValidator 
						ID = "RFVUOM"
						runat = "server"
						ControlToValidate = "F_UOM"
						Text = "[Required!]"
						ErrorMessage = "[Required!]"
						Display = "Dynamic"
						EnableClientScript = "true"
						ValidationGroup = "qcmRequests"
            ForeColor="Red" 
						SetFocusOnError="true" />
        </td>
      </tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_RequestedInspectionStartDate" runat="server" Text="Requested Inspection Start Date :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_RequestedInspectionStartDate"
						Text='<%# Bind("RequestedInspectionStartDate") %>'
            Width="70px"
						CssClass = "mytxt"
						ValidationGroup="qcmRequests"
						onfocus = "return this.select();"
						runat="server" />
					<asp:Image ID="ImageButtonRequestedInspectionStartDate" runat="server" ToolTip="Click to open calendar" style="cursor: pointer; vertical-align:middle" ImageUrl="~/Images/cal.png" />
          <AJX:CalendarExtender 
            ID = "CERequestedInspectionStartDate"
            TargetControlID="F_RequestedInspectionStartDate"
            BehaviorID="startDate"
            Format="dd/MM/yyyy"
            runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonRequestedInspectionStartDate" />
					<AJX:MaskedEditExtender 
						ID = "MEERequestedInspectionStartDate"
						runat = "server"
						mask = "99/99/9999"
						MaskType="Date"
            CultureName = "en-GB"
						MessageValidatorTip="true"
						InputDirection="LeftToRight"
						ErrorTooltipEnabled="true"
						TargetControlID="F_RequestedInspectionStartDate" />
					<AJX:MaskedEditValidator 
						ID = "MEVRequestedInspectionStartDate"
						runat = "server"
						ControlToValidate = "F_RequestedInspectionStartDate"
						ControlExtender = "MEERequestedInspectionStartDate"
						InvalidValueMessage = "Invalid"
						EmptyValueMessage = "[Required!]"
						EmptyValueBlurredText = "[Required!]"
						Display = "Dynamic"
						TooltipMessage = "Enter Inspection Start Date."
						EnableClientScript = "true"
						ValidationGroup = "qcmRequests"
						IsValidEmpty = "false"
            ForeColor="Red"
						SetFocusOnError="true" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_ClientInspectionRequired" runat="server" Text="Client Inspection Required :" /></b>
				</td>
				<td>
          <asp:CheckBox ID="F_ClientInspectionRequired"
					 Checked='<%# Bind("ClientInspectionRequired") %>'
           runat="server" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_ThirdPartyInspectionRequired" runat="server" Text="Third Party Inspection Required :" /></b>
				</td>
				<td>
          <asp:CheckBox ID="F_ThirdPartyInspectionRequired"
					 Checked='<%# Bind("ThirdPartyInspectionRequired") %>'
           runat="server" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_ReceivedOn" runat="server" Text="Received On :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_ReceivedOn"
						Text='<%# Bind("ReceivedOn") %>'
            Width="70px"
						CssClass = "mytxt"
						onfocus = "return this.select();"
						runat="server" />
					<asp:Image ID="ImageButtonReceivedOn" runat="server" ToolTip="Click to open calendar" style="cursor: pointer;vertical-align:middle" ImageUrl="~/Images/cal.png" />
          <AJX:CalendarExtender 
            ID = "CEReceivedOn"
            TargetControlID="F_ReceivedOn"
            Format="dd/MM/yyyy"
            runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonReceivedOn" />
					<AJX:MaskedEditExtender 
						ID = "MEEReceivedOn"
						runat = "server"
						mask = "99/99/9999"
						MaskType="Date"
            CultureName = "en-GB"
						MessageValidatorTip="true"
						InputDirection="LeftToRight"
						ErrorTooltipEnabled="true"
						TargetControlID="F_ReceivedOn" />
					<AJX:MaskedEditValidator 
						ID = "MEVReceivedOn"
						runat = "server"
						ControlToValidate = "F_ReceivedOn"
						ControlExtender = "MEEReceivedOn"
						InvalidValueMessage = "Invalid"
						EmptyValueMessage = "[Required!]"
						EmptyValueBlurredText = "[Required!]"
						Display = "Dynamic"
						TooltipMessage = "Enter Received On."
						EnableClientScript = "true"
						IsValidEmpty = "True"
						SetFocusOnError="true" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_ReceivedBy" runat="server" Text="Received By :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_ReceivedBy"
						CssClass = "myfktxt"
            Width="56px"
						Text='<%# Bind("ReceivedBy") %>'
						AutoCompleteType = "None"
						onfocus = "return this.select();"
            ToolTip="Enter Received By."
            onblur= "script_qcmRequests.validate_ReceivedBy(this);"
						Runat="Server" />
					<asp:Label
						ID = "F_ReceivedBy_Display"
						Text='<%# Eval("HRM_Employees5_EmployeeName") %>'
						Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEReceivedBy"
            BehaviorID="B_ACEReceivedBy"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="ReceivedByCompletionList"
            TargetControlID="F_ReceivedBy"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_qcmRequests.ACEReceivedBy_Selected"
            OnClientPopulating="script_qcmRequests.ACEReceivedBy_Populating"
            OnClientPopulated="script_qcmRequests.ACEReceivedBy_Populated"
            CompletionSetCount="10"
						CompletionListCssClass = "autocomplete_completionListElement"
						CompletionListItemCssClass = "autocomplete_listItem"
						CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
			</tr>
		</table>
		</div>
	</InsertItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSqcmRequests"
  DataObjectTypeName = "SIS.QCM.qcmRequests"
  InsertMethod="UZ_qcmRequestsInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmRequests"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
