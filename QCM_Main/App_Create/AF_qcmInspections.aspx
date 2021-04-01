<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_qcmInspections.aspx.vb" Inherits="AF_qcmInspections" title="Add: Inspection Report-HO" %>
<asp:Content ID="CPHqcmInspections" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmInspections" runat="server" Text="&nbsp;Add: Inspection Report-HO" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmInspections" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmInspections"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    AfterInsertURL = "~/QCM_Main/App_Edit/EF_qcmInspections.aspx"
    ValidationGroup = "qcmInspections"
    runat = "server" />
<asp:FormView ID="FVqcmInspections"
	runat = "server"
	DataKeyNames = "RequestID,InspectionID"
	DataSourceID = "ODSqcmInspections"
	DefaultMode = "Insert" CssClass="sis_formview">
	<InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgqcmInspections" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_RequestID" ForeColor="#CC6633" runat="server" Text="Request ID :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_RequestID"
						CssClass = "mypktxt"
            Width="70px"
						Text='<%# Bind("RequestID") %>'
						AutoCompleteType = "None"
						onfocus = "return this.select();"
            ToolTip="Enter value for Request ID."
						ValidationGroup = "qcmInspections"
            onblur= "script_qcmInspections.validate_RequestID(this);"
						Runat="Server" />
					<asp:Label
						ID = "F_RequestID_Display"
						Text='<%# Eval("QCM_Requests8_Description") %>'
						Runat="Server" />
					<asp:RequiredFieldValidator 
						ID = "RFVRequestID"
						runat = "server"
						ControlToValidate = "F_RequestID"
						Text = "Request ID is required."
						ErrorMessage = "[Required!]"
						Display = "Dynamic"
						EnableClientScript = "true"
						ValidationGroup = "qcmInspections"
						SetFocusOnError="true" />
          <AJX:AutoCompleteExtender
            ID="ACERequestID"
            BehaviorID="B_ACERequestID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="RequestIDCompletionList"
            TargetControlID="F_RequestID"
            EnableCaching="false"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="script_qcmInspections.ACERequestID_Selected"
            OnClientPopulating="script_qcmInspections.ACERequestID_Populating"
            OnClientPopulated="script_qcmInspections.ACERequestID_Populated"
            CompletionSetCount="10"
						CompletionListCssClass = "autocomplete_completionListElement"
						CompletionListItemCssClass = "autocomplete_listItem"
						CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_InspectionID" ForeColor="#CC6633" runat="server" Text="Inspection ID :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_InspectionID" Enabled="False" CssClass="mypktxt" width="70px" runat="server" Text="0" />
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
					            <b><asp:Label ID="Label6" runat="server" Text="STAGE" /></b>
				            </td>
				            <td class="alignCenter">
					            <b><asp:Label ID="Label7" runat="server" Text="FINAL" /></b>
				            </td>
                  </tr>
                </table>
              </td>
            </tr>
            <tr>
				      <td class="alignright">
					      <b><asp:Label ID="Label2" runat="server" Text="Offered Quantity :" /></b>
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
					      <b><asp:Label ID="Label5" runat="server" Text="Inspected Quantity :" /></b>
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
					      <b><asp:Label ID="Label3" runat="server" Text="Cleared Quantity :" /></b>
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
					<b><asp:Label ID="Label8" runat="server" Text="Attended Virtually :" /></b>
				</td>
        <td>
          <asp:CheckBox 
            ID="F_AttendedVirtually"
            Checked='<%# Bind("AttendedVirtually") %>'
            CssClass = "mychk"
            Runat="Server" >
          </asp:CheckBox>
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
		</div>
	</InsertItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSqcmInspections"
  DataObjectTypeName = "SIS.QCM.qcmInspections"
  InsertMethod="UZ_qcmInspectionsInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmInspections"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
