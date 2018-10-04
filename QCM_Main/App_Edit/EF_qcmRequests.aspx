<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_qcmRequests.aspx.vb" Inherits="EF_qcmRequests" title="Edit: Inspection Requests" %>
<asp:Content ID="CPHqcmRequests" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmRequests" runat="server" Text="&nbsp;Edit: Inspection Requests" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmRequests" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmRequests"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "qcmRequests"
    runat = "server" />
<asp:FormView ID="FVqcmRequests"
	runat = "server"
	DataKeyNames = "RequestID"
	DataSourceID = "ODSqcmRequests"
	DefaultMode = "Edit" CssClass="sis_formview">
	<EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table style="margin:auto;border: solid 1pt lightgrey">
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_RequestID" runat="server" ForeColor="#CC6633" Text="Request ID :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_RequestID"
						Text='<%# Bind("RequestID") %>'
            ToolTip="Value of Request ID."
            Enabled = "False"
						CssClass = "mypktxt"
            Width="70px"
						style="text-align: right"
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
						CssClass = "myfktxt"
            Width="72px"
						Text='<%# Bind("ProjectID") %>'
						AutoCompleteType = "None"
						onfocus = "return this.select();"
            ToolTip="Enter Project ID."
						ValidationGroup = "qcmRequests"
            onblur= "script_qcmRequests.validate_ProjectID(this);"
						Runat="Server" />
					<asp:Label
						ID = "F_ProjectID_Display"
						Text='<%# Eval("IDM_Projects6_Description") %>'
						Runat="Server" />
					<asp:RequiredFieldValidator 
						ID = "RFVProjectID"
						runat = "server"
						ControlToValidate = "F_ProjectID"
						Text = "[Required!]"
						ErrorMessage = "[Required!]"
						Display = "Dynamic"
						EnableClientScript = "true"
						ValidationGroup = "qcmRequests"
            ForeColor="Red" 
						SetFocusOnError="true" />
          <AJX:AutoCompleteExtender
            ID="ACEProjectID"
            BehaviorID="B_ACEProjectID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="ProjectIDCompletionList"
            TargetControlID="F_ProjectID"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_qcmRequests.ACEProjectID_Selected"
            OnClientPopulating="script_qcmRequests.ACEProjectID_Populating"
            OnClientPopulated="script_qcmRequests.ACEProjectID_Populated"
            CompletionSetCount="10"
						CompletionListCssClass = "autocomplete_completionListElement"
						CompletionListItemCssClass = "autocomplete_listItem"
						CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
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
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter Purchase Order No."
						MaxLength="80"
            Width="350px"
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
            Width="92px"
						Text='<%# Bind("SupplierID") %>'
						AutoCompleteType = "None"
						onfocus = "return this.select();"
            ToolTip="Enter Supplier ID."
						ValidationGroup = "qcmRequests"
            onblur= "script_qcmRequests.validate_SupplierID(this);"
						Runat="Server" />
					<asp:Label
						ID = "F_SupplierID_Display"
						Text='<%# Eval("IDM_Vendors7_Description") %>'
						Runat="Server" />
					<asp:RequiredFieldValidator 
						ID = "RFVSupplierID"
						runat = "server"
						ControlToValidate = "F_SupplierID"
						Text = "[Required!]"
						ErrorMessage = "[Required!]"
						Display = "Dynamic"
						EnableClientScript = "true"
						ValidationGroup = "qcmRequests"
            ForeColor="Red" 
						SetFocusOnError="true" />
          <AJX:AutoCompleteExtender
            ID="ACESupplierID"
            BehaviorID="B_ACESupplierID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="SupplierIDCompletionList"
            TargetControlID="F_SupplierID"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_qcmRequests.ACESupplierID_Selected"
            OnClientPopulating="script_qcmRequests.ACESupplierID_Populating"
            OnClientPopulated="script_qcmRequests.ACESupplierID_Populated"
            CompletionSetCount="10"
						CompletionListCssClass = "autocomplete_completionListElement"
						CompletionListItemCssClass = "autocomplete_listItem"
						CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
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
<fieldset class="ui-widget-content page">
<legend>
    <asp:Label ID="LabelqcmRequestFiles" runat="server" Text="&nbsp;List: Request Attachments" Width="100%" CssClass="sis_formheading"></asp:Label>
</legend>
<div class="pagedata">
	<asp:UpdatePanel ID="UPNLqcmRequestFiles" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLqcmRequestFiles"
      ToolType = "lgNMGrid"
      EditUrl = "~/QCM_Main/App_Edit/EF_qcmRequestFiles.aspx"
      AddUrl = "~/QCM_Main/App_Create/AF_qcmRequestFiles.aspx"
      AddPostBack = "True"
      EnableAdd="false"
      ValidationGroup = "qcmRequestFiles"
  
      runat = "server" />
    <asp:UpdateProgress ID="UPGSqcmRequestFiles" runat="server" AssociatedUpdatePanelID="UPNLqcmRequestFiles" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
		<table id="F_Upload" runat="server" visible="<%# Editable %>" >
			<tr>
				<td>
					<asp:Label ID="L_FileUpload" runat="server" Font-Bold="true" Text="Attatch File :"></asp:Label>
				</td>
				<td style="text-align:left">
					<input type="text" id="fileName" style="width:500px" class="file_input_textbox" readonly="readonly">
					 
					<div class="file_input_div">
						<input type="button" value="Search file" class="file_input_button" />
						<asp:FileUpload ID="F_FileUpload" runat="server" Width="100%" Visible="<%# Editable %>" class="file_input_hidden" onchange="javascript: document.getElementById('fileName').value = this.value" ToolTip="Attatch File" />
					</div>
				</td>
				<td>
					<asp:Button ID="cmdFileUpload" CssClass="file_upload_button" Text="Upload File" runat="server" Visible="<%# Editable %>" ToolTip="Click to attatch file." CommandName="Upload" CommandArgument="" />
				</td>
			</tr>
		</table>
    <asp:GridView ID="GVqcmRequestFiles" SkinID="gv_silver" BorderColor="#A9A9A9" width="100%" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ODSqcmRequestFiles" DataKeyNames="RequestID,SerialNo">
      <Columns>
        <asp:TemplateField>
          <ItemTemplate>
						<table><tr>
              <td>
              <asp:ImageButton ID="cmdRemove" runat="server" AlternateText="Remove" Visible="<%# Editable %>" CommandName="Remove" CommandArgument='<%# Container.DataItemIndex %>' ToolTip="Click to remove." SkinID="delete" OnClientClick="return confirm('Remove the record ?');" />
							</td>
						</tr></Table>
          </ItemTemplate>
          <HeaderStyle Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Request ID" SortExpression="QCM_Requests1_Description">
          <ItemTemplate>
             <asp:Label ID="L_RequestID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("RequestID") %>' Text='<%# Eval("QCM_Requests1_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="SerialNo" SortExpression="SerialNo">
          <ItemTemplate>
            <asp:Label ID="LabelSerialNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("SerialNo") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle CssClass="alignright" />
          <ItemStyle CssClass="alignright" />
          <HeaderStyle Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="File Name" SortExpression="FileName">
          <ItemTemplate>
            <asp:LinkButton ID="LabelFileName" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("FileName") %>' CommandName="DownloadFile" CommandArgument='<%# Container.DataItemIndex %>' ></asp:LinkButton>
          </ItemTemplate>
        <HeaderStyle Width="100px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSqcmRequestFiles"
      runat = "server"
      DataObjectTypeName = "SIS.QCM.qcmRequestFiles"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "qcmRequestFilesSelectList"
      TypeName = "SIS.QCM.qcmRequestFiles"
      SelectCountMethod = "qcmRequestFilesSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_RequestID" PropertyName="Text" Name="RequestID" Type="Int32" Size="10" />
				<asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
				<asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:PostBackTrigger ControlID="GVqcmRequestFiles"/>
		<asp:PostBackTrigger ControlID="cmdFileUpload" />
  </Triggers>
</asp:UpdatePanel>
</div>
</fieldset>
</div>
	</EditItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSqcmRequests"
  DataObjectTypeName = "SIS.QCM.qcmRequests"
  SelectMethod = "qcmRequestsGetByID"
  UpdateMethod="UZ_qcmRequestsUpdate"
  DeleteMethod="UZ_qcmRequestsDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmRequests"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="RequestID" Name="RequestID" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
