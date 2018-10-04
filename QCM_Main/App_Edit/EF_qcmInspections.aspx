<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_qcmInspections.aspx.vb" Inherits="EF_qcmInspections" title="Edit: Inspection Report-HO" %>
<asp:Content ID="CPHqcmInspections" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmInspections" runat="server" Text="&nbsp;Edit: Inspection Report-HO" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmInspections" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmInspections"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "qcmInspections"
    runat = "server" />
<asp:FormView ID="FVqcmInspections"
	runat = "server"
	DataKeyNames = "RequestID,InspectionID"
	DataSourceID = "ODSqcmInspections"
	DefaultMode = "Edit" CssClass="sis_formview">
	<EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table style="margin:auto;border: solid 1pt lightgrey">
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_RequestID" runat="server" ForeColor="#CC6633" Text="Request ID :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_RequestID"
            Width="70px"
						Text='<%# Bind("RequestID") %>'
						CssClass = "mypktxt"
            Enabled = "False"
            ToolTip="Value of Request ID."
						Runat="Server" />
					<asp:Label
						ID = "F_RequestID_Display"
						Text='<%# Eval("QCM_Requests8_Description") %>'
						Runat="Server" />
        </td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_InspectionID" runat="server" ForeColor="#CC6633" Text="Inspection ID :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_InspectionID"
						Text='<%# Bind("InspectionID") %>'
            ToolTip="Value of Inspection ID."
            Enabled = "False"
						CssClass = "mypktxt"
            Width="70px"
						style="text-align: right"
						runat="server" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="Label1" runat="server" Text="Inspection Status :" /></b>
				</td>
				<td>
					<LGM:LC_qcmInspectionStatus
						ID="F_InspectionStatusID"
						SelectedValue='<%# Bind("InspectionStatusID") %>'
						OrderBy="Description"
						DataTextField="Description"
						DataValueField="InspectionStatusID"
						IncludeDefault="true"
						DefaultText="-- Select --"
						Width="200px"
						RequiredFieldErrorMessage="[Required]"
						ValidationGroup = "qcmInspections"
						CssClass="myddl"
						Runat="Server" />
				</td>
			</tr>
            <tr>
              <td>
              </td>
              <td>
                <table style="width:100%">
                  <tr style="background-color:antiquewhite;border-width: 1pt;border-color:bisque;border-style:solid">
				            <td class="alignCenter">
					            <b><asp:Label ID="Label2" runat="server" Text="STAGE" /></b>
				            </td>
				            <td class="alignCenter">
					            <b><asp:Label ID="Label3" runat="server" Text="FINAL" /></b>
				            </td>
                  </tr>
                </table>
              </td>
            </tr>
            <tr>
				      <td class="alignright">
					      <b><asp:Label ID="Label5" runat="server" Text="Offered Quantity :" /></b>
				      </td>
				      <td>
                <table style="width:100%">
                  <tr>
                    <td>
                      <asp:TextBox ID="F_OfferedQuantity"
                        Text='<%# Bind("OfferedQuantity") %>'
                        Width="130px"
                        CssClass = "mytxt"
                        style="text-align: Right"
                        MaxLength="14"
                        onfocus = "return this.select();"
                        type="number"
                        runat="server" />
                      <asp:RequiredFieldValidator 
                        ID = "RFVOfferedQuantity"
                        runat = "server"
                        ControlToValidate = "F_OfferedQuantity"
                        Text = "Required."
                        ErrorMessage = "[Required!]"
                        Display = "Dynamic"
                        EnableClientScript = "true"
                        ValidationGroup = "qcmInspections"
                        ForeColor="Red"
                        SetFocusOnError="true" />
                    </td>
                    <td>
                      <asp:TextBox ID="F_OfferedQuantityFinal"
                        Text='<%# Bind("OfferedQuantityFinal") %>'
                        Width="130px"
                        CssClass = "mytxt"
                        style="text-align: Right"
                        MaxLength="14"
                        onfocus = "return this.select();"
                        type="number"
                        runat="server" />
                      <asp:RequiredFieldValidator 
                        ID = "RFVOfferedQuantityFinal"
                        runat = "server"
                        ControlToValidate = "F_OfferedQuantityFinal"
                        Text = "Required."
                        ErrorMessage = "[Required!]"
                        Display = "Dynamic"
                        EnableClientScript = "true"
                        ValidationGroup = "qcmInspections"
                        ForeColor="Red"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                </table>
				      </td>
			      </tr>
			      <tr>
				      <td class="alignright">
					      <b><asp:Label ID="Label8" runat="server" Text="Inspected Quantity :" /></b>
				      </td>
				      <td>
                <table style="width:100%">
                  <tr>
                    <td>
                      <asp:TextBox ID="F_InspectedQuantity"
                        Text='<%# Bind("InspectedQuantity") %>'
                        Width="130px"
                        CssClass = "mytxt"
                        style="text-align: Right"
                        MaxLength="10"
                        onfocus = "return this.select();"
                        type="number"
                        runat="server" />
                      <asp:RequiredFieldValidator 
                        ID = "RFVInspectedQuantity"
                        runat = "server"
                        ControlToValidate = "F_InspectedQuantity"
                        Text = "Required."
                        ErrorMessage = "[Required!]"
                        Display = "Dynamic"
                        EnableClientScript = "true"
                        ValidationGroup = "qcmInspections"
                        ForeColor="Red"
                        SetFocusOnError="true" />
                    </td>
                    <td>
                      <asp:TextBox ID="F_InspectedQuantityFinal"
                        Text='<%# Bind("InspectedQuantityFinal") %>'
                        Width="130px"
                        CssClass = "mytxt"
                        style="text-align: Right"
                        MaxLength="10"
                        onfocus = "return this.select();"
                        type="number"
                        runat="server" />
                      <asp:RequiredFieldValidator 
                        ID = "RFVInspectedQuantityFinal"
                        runat = "server"
                        ControlToValidate = "F_InspectedQuantityFinal"
                        Text = "Required."
                        ErrorMessage = "[Required!]"
                        Display = "Dynamic"
                        EnableClientScript = "true"
                        ValidationGroup = "qcmInspections"
                        ForeColor="Red"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                </table>
				      </td>
			      </tr>
			      <tr>
				      <td class="alignright">
					      <b><asp:Label ID="Label9" runat="server" Text="Cleared Quantity :" /></b>
				      </td>
				      <td>
                <table style="width:100%">
                  <tr>
                    <td>
                      <asp:TextBox ID="F_ClearedQuantity"
                        Text='<%# Bind("ClearedQuantity") %>'
                        Width="130px"
                        CssClass = "mytxt"
                        style="text-align: Right"
                        MaxLength="14"
                        onfocus = "return this.select();"
                        type="number"
                        runat="server" />
                      <asp:RequiredFieldValidator 
                        ID = "RFVClearedQuantity"
                        runat = "server"
                        ControlToValidate = "F_ClearedQuantity"
                        Text = "Required."
                        ErrorMessage = "[Required!]"
                        Display = "Dynamic"
                        EnableClientScript = "true"
                        ValidationGroup = "qcmInspections"
                        ForeColor="Red"
                        SetFocusOnError="true" />
                    </td>
                    <td>
                      <asp:TextBox ID="F_ClearedQuantityFinal"
                        Text='<%# Bind("ClearedQuantityFinal") %>'
                        Width="130px"
                        CssClass = "mytxt"
                        style="text-align: Right"
                        MaxLength="14"
                        onfocus = "return this.select();"
                        type="number"
                        runat="server" />
                      <asp:RequiredFieldValidator 
                        ID = "RFVClearedQuantityFinal"
                        runat = "server"
                        ControlToValidate = "F_ClearedQuantityFinal"
                        Text = "Required."
                        ErrorMessage = "[Required!]"
                        Display = "Dynamic"
                        EnableClientScript = "true"
                        ValidationGroup = "qcmInspections"
                        ForeColor="Red"
                        SetFocusOnError="true" />
                    </td>
                  </tr>
                </table>
				      </td>
			      </tr>
      <tr>
				<td class="alignright">
					<b><asp:Label ID="Label4" runat="server" Text="UOM :" /></b>
				</td>
        <td>
          <asp:DropDownList
            ID="F_UOM"
            SelectedValue='<%# Bind("UOM") %>'
            CssClass = "dmyddl"
            Width="150px"
            Enabled="false"
            Runat="Server" >
            <asp:ListItem Value="">---Select---</asp:ListItem>
            <asp:ListItem Value="Nos">Nos</asp:ListItem>
            <asp:ListItem Value="MT">MT</asp:ListItem>
            <asp:ListItem Value="Package">Package</asp:ListItem>
          </asp:DropDownList>
        </td>
      </tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_InspectionRemarks" runat="server" Text="Inspection Remarks :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_InspectionRemarks"
						Text='<%# Bind("InspectionRemarks") %>'
            Width="350px" Height="40px" TextMode="MultiLine"
						CssClass = "mytxt"
						onfocus = "return this.select();"
						ValidationGroup="qcmInspections"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Inspection Remarks."
						MaxLength="500"
						runat="server" />
					<asp:RequiredFieldValidator 
						ID = "RFVInspectionRemarks"
						runat = "server"
						ControlToValidate = "F_InspectionRemarks"
						Text = "Required."
						ErrorMessage = "[Required!]"
						Display = "Dynamic"
						EnableClientScript = "true"
						ValidationGroup = "qcmInspections"
            ForeColor="Red"
						SetFocusOnError="true" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_InspectedBy" runat="server" Text="Inspected By :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_InspectedBy"
						CssClass = "myfktxt"
						Text='<%# Bind("InspectedBy") %>'
						AutoCompleteType = "None"
            Width="56px"
						onfocus = "return this.select();"
            ToolTip="Enter value for Inspected By."
						ValidationGroup = "qcmInspections"
            onblur= "script_qcmInspections.validate_InspectedBy(this);"
						Runat="Server" />
					<asp:Label
						ID = "F_InspectedBy_Display"
						Text='<%# Eval("HRM_Employees1_EmployeeName") %>'
						Runat="Server" />
					<asp:RequiredFieldValidator 
						ID = "RFVInspectedBy"
						runat = "server"
						ControlToValidate = "F_InspectedBy"
						Text = "Inspected By is required."
						ErrorMessage = "[Required!]"
						Display = "Dynamic"
						EnableClientScript = "true"
						ValidationGroup = "qcmInspections"
						SetFocusOnError="true" />
          <AJX:AutoCompleteExtender
            ID="ACEInspectedBy"
            BehaviorID="B_ACEInspectedBy"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="InspectedByCompletionList"
            TargetControlID="F_InspectedBy"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_qcmInspections.ACEInspectedBy_Selected"
            OnClientPopulating="script_qcmInspections.ACEInspectedBy_Populating"
            OnClientPopulated="script_qcmInspections.ACEInspectedBy_Populated"
            CompletionSetCount="10"
						CompletionListCssClass = "autocomplete_completionListElement"
						CompletionListItemCssClass = "autocomplete_listItem"
						CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_InspectedOn" runat="server" Text="Inspected On :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_InspectedOn"
						Text='<%# Bind("InspectedOn") %>'
            Width="70px"
						CssClass = "mytxt"
						onfocus = "return this.select();"
						ValidationGroup="qcmInspections"
						runat="server" />
					<asp:Image ID="ImageButtonInspectedOn" runat="server" ToolTip="Click to open calendar" style="cursor: pointer" ImageUrl="~/Images/cal.png" />
          <AJX:CalendarExtender 
            ID = "CEInspectedOn"
            TargetControlID="F_InspectedOn"
            Format="dd/MM/yyyy"
            runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonInspectedOn" />
					<AJX:MaskedEditExtender 
						ID = "MEEInspectedOn"
						runat = "server"
						mask = "99/99/9999"
						MaskType="Date"
            CultureName = "en-GB"
						MessageValidatorTip="true"
						InputDirection="LeftToRight"
						ErrorTooltipEnabled="true"
						TargetControlID="F_InspectedOn" />
					<AJX:MaskedEditValidator 
						ID = "MEVInspectedOn"
						runat = "server"
						ControlToValidate = "F_InspectedOn"
						ControlExtender = "MEEInspectedOn"
						InvalidValueMessage = "Invalid."
						EmptyValueMessage = "Required."
						EmptyValueBlurredText = "[Required!]"
						Display = "Dynamic"
						TooltipMessage = "Enter Inspected On."
						EnableClientScript = "true"
						ValidationGroup = "qcmInspections"
						IsValidEmpty = "false"
            ForeColor="Red"
						SetFocusOnError="true" />
				</td>
			</tr>
		</table>
<fieldset class="ui-widget-content page">
<legend>
    <asp:Label ID="LabelqcmInspectionFiles" runat="server" Text="&nbsp;List: Inspection Attachments" Width="100%" CssClass="sis_formheading"></asp:Label>
</legend>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLqcmInspectionFiles" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLqcmInspectionFiles"
      ToolType = "lgNMGrid"
      AddPostBack = "True"
      EnableAdd="false"
      ValidationGroup = "qcmInspectionFiles"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSqcmInspectionFiles" runat="server" AssociatedUpdatePanelID="UPNLqcmInspectionFiles" DisplayAfter="100">
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
    <asp:GridView ID="GVqcmInspectionFiles" SkinID="gv_silver" BorderColor="#A9A9A9" width="100%" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ODSqcmInspectionFiles" DataKeyNames="RequestID,InspectionID,SerialNo">
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
        <asp:TemplateField HeaderText="Serial No" SortExpression="SerialNo">
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
      ID = "ODSqcmInspectionFiles"
      runat = "server"
      DataObjectTypeName = "SIS.QCM.qcmInspectionFiles"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "qcmInspectionFilesSelectList"
      TypeName = "SIS.QCM.qcmInspectionFiles"
      SelectCountMethod = "qcmInspectionFilesSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_RequestID" PropertyName="Text" Name="RequestID" Type="Int32" Size="10" />
        <asp:ControlParameter ControlID="F_InspectionID" PropertyName="Text" Name="InspectionID" Type="Int32" Size="10" />
				<asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
				<asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:PostBackTrigger ControlID="GVqcmInspectionFiles" />
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
  ID = "ODSqcmInspections"
  DataObjectTypeName = "SIS.QCM.qcmInspections"
  SelectMethod = "qcmInspectionsGetByID"
  UpdateMethod="UZ_qcmInspectionsUpdate"
  DeleteMethod="UZ_qcmInspectionsDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmInspections"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="RequestID" Name="RequestID" Type="Int32" />
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="InspectionID" Name="InspectionID" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
