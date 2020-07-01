<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_qcmRequestAllotment.aspx.vb" Inherits="EF_qcmRequestAllotment" title="Edit: Requests Allotment" %>
<asp:Content ID="CPHqcmRequestAllotment" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmRequestAllotment" runat="server" Text="&nbsp;Edit: Requests Allotment" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmRequestAllotment" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmRequestAllotment"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    EnableDelete = "False"
    ValidationGroup = "qcmRequestAllotment"
    runat = "server" />
<asp:FormView ID="FVqcmRequestAllotment"
	runat = "server"
	DataKeyNames = "RequestID"
	DataSourceID = "ODSqcmRequestAllotment"
	DefaultMode = "Edit" CssClass="sis_formview">
	<EditItemTemplate>
		<style type="text/css">
			.input[@disabled=true], input[@disabled] {
			 color:Black;
			}	
			.disabledCss
			.aspNetDisabled
			{
			color:Black;
			}
		</style>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table width="100%">
			<tr>
				<td>
					<table>
						<tr>
							<td class="alignright">
								<b>
									<asp:Label ID="L_RequestID" runat="server" ForeColor="#CC6633" Text="Request ID :" /></b>
							</td>
							<td>
								<asp:TextBox ID="F_RequestID" Text='<%# Bind("RequestID") %>' ToolTip="Value of Request ID." Enabled="False" Width="70px" CssClass="dmypktxt" Style="text-align: right" runat="server" />
							</td>
						</tr>
						<tr>
							<td class="alignright">
								<b>
									<asp:Label ID="L_Description" runat="server" Text="Item Description :" /></b>
							</td>
							<td>
								<asp:TextBox ID="F_Description" Text='<%# Bind("Description") %>' ToolTip="Item Description" Enabled="False" Width="350px" Height="40px" CssClass="dmytxt" runat="server" />
							</td>
						</tr>
						<tr>
							<td class="alignright">
								<b>
									<asp:Label ID="L_ProjectID" runat="server" Text="Project ID :" /></b>
							</td>
							<td>
								<asp:TextBox ID="F_ProjectID" Width="42px" Text='<%# Bind("ProjectID") %>' Enabled="False" ToolTip="Value of Project ID." CssClass="dmyfktxt" runat="Server" />
								<asp:Label ID="F_ProjectID_Display" Text='<%# Eval("IDM_Projects6_Description") %>' runat="Server" />
							</td>
						</tr>
						<tr>
							<td class="alignright">
								<b>
									<asp:Label ID="L_SupplierID" runat="server" Text="Supplier ID :" /></b>
							</td>
							<td>
								<asp:TextBox ID="F_SupplierID" Width="42px" Text='<%# Bind("SupplierID") %>' Enabled="False" ToolTip="Value of Supplier ID." CssClass="dmyfktxt" runat="Server" />
								<asp:Label ID="F_SupplierID_Display" Text='<%# Eval("IDM_Vendors7_Description") %>' runat="Server" />
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
									RequiredFieldErrorMessage = "Region is required."
									ToolTip="Enter value for Region ID."
									ValidationGroup = "qcmRequests"
									Runat="Server" />
							</td>
						</tr>
						<tr>
							<td class="alignright">
								<b>
									<asp:Label ID="L_CreationRemarks" runat="server" Text="Place of Inspection :" /></b>
							</td>
							<td>
								<asp:TextBox ID="F_CreationRemarks" Text='<%# Bind("CreationRemarks") %>' ToolTip="Value of Creation Remarks." Enabled="False" Width="350px" Height="40px" CssClass="dmytxt" runat="server" />
							</td>
						</tr>
						<tr>
							<td class="alignright">
								<b>
									<asp:Label ID="L_OrderNo" runat="server" Text="Purchase Order No :" /></b>
							</td>
							<td>
								<asp:TextBox ID="F_OrderNo" Text='<%# Bind("OrderNo") %>' ToolTip="Value of Purchase Order No." Enabled="False" Width="350px" CssClass="dmytxt" runat="server" />
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
                  CssClass="dmytxt"
                  ValidationGroup = "qcmRequests"
                  RequiredFieldErrorMessage = "[Required!]"
                  Enabled="False"
                  Runat="Server" />
                </td>
            </tr>
						<tr>
							<td class="alignright">
								<b>
									<asp:Label ID="L_TotalRequestedQuantity" runat="server" Text="Stage Requested Quantity :" /></b>
							</td>
							<td>
								<asp:TextBox ID="F_TotalRequestedQuantity" Text='<%# Bind("TotalRequestedQuantity") %>' ToolTip="Stage Requested Quantity." Enabled="False" Width="200px" CssClass="dmytxt" runat="server" />
							</td>
						</tr>
						<tr>
							<td class="alignright">
								<b>
									<asp:Label ID="Label1" runat="server" Text="Final Requested Quantity :" /></b>
							</td>
							<td>
								<asp:TextBox ID="TextBox1" Text='<%# Bind("LotSize") %>' ToolTip="Final Requested Quantity." Enabled="False" Width="200px" CssClass="dmytxt" runat="server" />
							</td>
						</tr>
            <tr>
				      <td class="alignright">
					      <b><asp:Label ID="Label2" runat="server" Text="UOM :" /></b>
				      </td>
              <td>
                <asp:DropDownList
                  ID="F_UOM"
                  SelectedValue='<%# Bind("UOM") %>'
                  CssClass = "dmytxt"
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
								<b>
									<asp:Label ID="L_RequestedInspectionStartDate" runat="server" Text="Requested Inspection Date :" /></b>
							</td>
							<td>
								<asp:TextBox ID="F_RequestedInspectionStartDate" Text='<%# Bind("RequestedInspectionStartDate") %>' ToolTip="Requested Inspection Date." Enabled="False" Width="140px" CssClass="dmytxt" runat="server" />
							</td>
						</tr>
						<tr>
							<td class="alignright">
								<b>
									<asp:Label ID="L_ClientInspectionRequired" runat="server" Text="Client Inspection Required :" /></b>
							</td>
							<td>
								<asp:CheckBox ID="F_ClientInspectionRequired" Checked='<%# Bind("ClientInspectionRequired") %>' Enabled="False" runat="server" />
							</td>
						</tr>
						<tr>
							<td class="alignright">
								<b>
									<asp:Label ID="L_ThirdPartyInspectionRequired" runat="server" Text="Third Party Inspection Required :" /></b>
							</td>
							<td>
								<asp:CheckBox ID="F_ThirdPartyInspectionRequired" Checked='<%# Bind("ThirdPartyInspectionRequired") %>' Enabled="False" runat="server" />
							</td>
						</tr>
						<tr>
							<td class="alignright">
								<b>
									<asp:Label ID="L_ReceivedOn" runat="server" Text="Received On :" /></b>
							</td>
							<td>
                <table>
                  <tr>
                    <td>
      								<asp:TextBox ID="F_ReceivedOn" Text='<%# Bind("ReceivedOn") %>' ToolTip="Value of Received On." Enabled="False" Width="140px" CssClass="dmytxt" runat="server" />
                    </td>
							      <td class="alignright">
								      <b>
									      <asp:Label ID="L_ReceivedBy" runat="server" Text="Received By :" /></b>
							      </td>
							      <td>
								      <asp:TextBox ID="F_ReceivedBy" Width="56px" Text='<%# Bind("ReceivedBy") %>' Enabled="False" ToolTip="Value of Received By." CssClass="dmyfktxt" runat="Server" />
								      <asp:Label ID="F_ReceivedBy_Display" Text='<%# Eval("HRM_Employees5_EmployeeName") %>' runat="Server" />
							      </td>
                  </tr>
                </table>
							</td>
						</tr>
						<tr>
							<td class="alignright">
								<b>
									<asp:Label ID="L_CreatedOn" runat="server" Text="Created On :" /></b>
							</td>
							<td>
                <table>
                  <tr>
                    <td>
      								<asp:TextBox ID="F_CreatedOn" Text='<%# Bind("CreatedOn") %>' ToolTip="Value of Created On." Enabled="False" Width="140px" CssClass="dmytxt" runat="server" />
                    </td>
							      <td class="alignright">
								      <b>
									      <asp:Label ID="L_CreatedBy" runat="server" Text="Created By :" /></b>
							      </td>
							      <td>
								      <asp:TextBox ID="F_CreatedBy" Width="56px" Text='<%# Bind("CreatedBy") %>' Enabled="False" ToolTip="Value of Created By." CssClass="dmyfktxt" runat="Server" />
								      <asp:Label ID="F_CreatedBy_Display" Text='<%# Eval("HRM_Employees1_EmployeeName") %>' runat="Server" />
							      </td>
                  </tr>
                </table>
							</td>
						</tr>
					</table>
				</td>
				<td valign="top">
					<asp:UpdatePanel ID="UPNLqcmRequestFiles" runat="server">
						<ContentTemplate>
							<table width="100%">
								<tr>
									<td class="sis_formview">
										<asp:UpdateProgress ID="UPGSqcmRequestFiles" runat="server" AssociatedUpdatePanelID="UPNLqcmRequestFiles" DisplayAfter="100">
											<ProgressTemplate>
												<span style="color: #ff0033">Loading...</span>
											</ProgressTemplate>
										</asp:UpdateProgress>
										<asp:GridView ID="GVqcmRequestFiles" SkinID="gv_silver" PagerSettings-Mode="NumericFirstLast" RowStyle-Height="20px" BorderColor="#A9A9A9" Width="100%" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ODSqcmRequestFiles" DataKeyNames="RequestID,SerialNo">
											<Columns>
												<asp:TemplateField HeaderText="File Name" SortExpression="FileName">
													<ItemTemplate>
														<asp:LinkButton ID="LabelFileName"  runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("FileName") %>' CommandName="DownloadFile" CommandArgument='<%# Container.DataItemIndex %>' OnClientClick='<%# Eval("GetDownloadLink") %>' ></asp:LinkButton>
													</ItemTemplate>
													<HeaderStyle HorizontalAlign="Center" />
													<ItemStyle HorizontalAlign="Center" />
												</asp:TemplateField>
											</Columns>
											<EmptyDataTemplate>
												<asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No attachment found !!!"></asp:Label>
											</EmptyDataTemplate>
										</asp:GridView>
										<asp:ObjectDataSource ID="ODSqcmRequestFiles" runat="server" DataObjectTypeName="SIS.QCM.qcmRequestFiles" OldValuesParameterFormatString="original_{0}" SelectMethod="qcmRequestFilesSelectList" TypeName="SIS.QCM.qcmRequestFiles" SelectCountMethod="qcmRequestFilesSelectCount" SortParameterName="OrderBy" EnablePaging="True">
											<SelectParameters>
												<asp:ControlParameter ControlID="F_RequestID" PropertyName="Text" Name="RequestID" Type="Int32" Size="10" />
												<asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
												<asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
											</SelectParameters>
										</asp:ObjectDataSource>
									</td>
								</tr>
							</table>
						</ContentTemplate>
						<Triggers>
							<asp:PostBackTrigger ControlID="GVqcmRequestFiles" />
						</Triggers>
					</asp:UpdatePanel>
					<br>
					</br>
					<table>
						<tr>
							<td class="alignright">
								<b>
									<asp:Label ID="L_AllotedTo" runat="server" Text="Alloted To :" /></b>
							</td>
							<td>
								<asp:TextBox 
                  ID="F_AllotedTo" 
                  CssClass="myfktxt" 
                  Text='<%# Bind("AllotedTo") %>' 
                  AutoCompleteType="None" 
                  Width="56px" 
                  onfocus="return this.select();" 
                  ToolTip="Enter value for Alloted To." 
                  ValidationGroup="qcmRequestAllotment" 
                  onblur="script_qcmRequestAllotment.validate_AllotedTo(this);" 
                  runat="Server" />
								<asp:Button ID="cmdSchedule" 
                  runat="server" 
                  Text="Get Schedule" 
                  OnClick="cmdSchedule_Click" />
								<asp:Label ID="F_AllotedTo_Display" 
                  Text='<%# Eval("HRM_Employees2_EmployeeName") %>' 
                  runat="Server" />
								<asp:RequiredFieldValidator 
                  ID="RFVAllotedTo" 
                  ForeColor="Red" 
                  runat="server" 
                  ControlToValidate="F_AllotedTo" 
                  Text="Alloted To is required." 
                  ErrorMessage="[Required!]" 
                  Display="Dynamic" 
                  EnableClientScript="true" 
                  ValidationGroup="qcmRequestAllotment" 
                  SetFocusOnError="true" />
								<AJX:AutoCompleteExtender 
                  ID="ACEAllotedTo" 
                  BehaviorID="B_ACEAllotedTo" 
                  ContextKey="" 
                  UseContextKey="true" 
                  ServiceMethod="AllotedToCompletionList" 
                  TargetControlID="F_AllotedTo" 
                  EnableCaching="false" 
                  CompletionInterval="100" 
                  FirstRowSelected="true" 
                  MinimumPrefixLength="1" 
                  OnClientItemSelected="script_qcmRequestAllotment.ACEAllotedTo_Selected" 
                  OnClientPopulating="script_qcmRequestAllotment.ACEAllotedTo_Populating" 
                  OnClientPopulated="script_qcmRequestAllotment.ACEAllotedTo_Populated" 
                  CompletionSetCount="10" 
                  CompletionListCssClass="autocomplete_completionListElement" 
                  CompletionListItemCssClass="autocomplete_listItem" 
                  CompletionListHighlightedItemCssClass="autocomplete_highlightedListItem" 
                  runat="Server" />
							</td>
						</tr>
						<tr>
							<td class="alignright">
								<b>
									<asp:Label ID="L_AllotedStartDate" runat="server" Text="Alloted Start Date :" /></b>
							</td>
							<td>
								<asp:TextBox ID="F_AllotedStartDate" onchange  = "return script_qcmRequestAllotment.validateStartDate(this);" Text='<%# Bind("AllotedStartDate") %>' Width="70px" CssClass="mytxt" onfocus="return this.select();" ValidationGroup="qcmRequestAllotment" runat="server" />
								<asp:Image ID="ImageButtonAllotedStartDate" runat="server" ToolTip="Click to open calendar" Style="cursor: pointer;vertical-align:middle" ImageUrl="~/Images/cal.png" />
								<AJX:CalendarExtender 
									ID="CEAllotedStartDate" 
									BehaviorID="startDate" 
									TargetControlID="F_AllotedStartDate" 
									Format="dd/MM/yyyy" 
									runat="server" 
									CssClass="MyCalendar" 
									PopupButtonID="ImageButtonAllotedStartDate" />
								<AJX:MaskedEditExtender ID="MEEAllotedStartDate" runat="server" Mask="99/99/9999" MaskType="Date" CultureName="en-GB" MessageValidatorTip="true" InputDirection="LeftToRight" ErrorTooltipEnabled="true" TargetControlID="F_AllotedStartDate" />
								<AJX:MaskedEditValidator ID="MEVAllotedStartDate" ForeColor="Red" runat="server" ControlToValidate="F_AllotedStartDate" ControlExtender="MEEAllotedStartDate" InvalidValueMessage="Invalid value for Alloted Start Date." EmptyValueMessage="Alloted Start Date is required." EmptyValueBlurredText="[Required!]" Display="Dynamic" TooltipMessage="Enter value for Alloted Start Date." EnableClientScript="true" ValidationGroup="qcmRequestAllotment" IsValidEmpty="false" SetFocusOnError="true" />
							</td>
						</tr>
						<tr>
							<td class="alignright">
								<b>
									<asp:Label ID="L_AllotedFinishDate" runat="server" Text="Alloted Finish Date :" /></b>
							</td>
							<td>
								<asp:TextBox ID="F_AllotedFinishDate" onchange  = "return script_qcmRequestAllotment.validateFinishDate(this);" Text='<%# Bind("AllotedFinishDate") %>' Width="70px" CssClass="mytxt" onfocus="return this.select();" ValidationGroup="qcmRequestAllotment" runat="server" />
								<asp:Image ID="ImageButtonAllotedFinishDate" runat="server" ToolTip="Click to open calendar" Style="cursor: pointer; vertical-align:middle" ImageUrl="~/Images/cal.png" />
								<AJX:CalendarExtender 
									ID="CEAllotedFinishDate" 
									BehaviorID="finishDate" 
									TargetControlID="F_AllotedFinishDate" 
									Format="dd/MM/yyyy" 
									runat="server" 
									CssClass="MyCalendar" 
									PopupButtonID="ImageButtonAllotedFinishDate" />
								<AJX:MaskedEditExtender ID="MEEAllotedFinishDate" runat="server" Mask="99/99/9999" MaskType="Date" CultureName="en-GB" MessageValidatorTip="true" InputDirection="LeftToRight" ErrorTooltipEnabled="true" TargetControlID="F_AllotedFinishDate" />
								<AJX:MaskedEditValidator ID="MEVAllotedFinishDate" ForeColor="Red" runat="server" ControlToValidate="F_AllotedFinishDate" ControlExtender="MEEAllotedFinishDate" InvalidValueMessage="Invalid value for Alloted Finish Date." EmptyValueMessage="Alloted Finish Date is required." EmptyValueBlurredText="[Required!]" Display="Dynamic" TooltipMessage="Enter value for Alloted Finish Date." EnableClientScript="true" ValidationGroup="qcmRequestAllotment" IsValidEmpty="false" SetFocusOnError="true" />
							</td>
						</tr>
						<tr>
							<td class="alignright">
								<b>
									<asp:Label ID="L_AllotmentRemarks" runat="server" Text="Allotment Remarks :" /></b>
							</td>
							<td>
								<asp:TextBox ID="F_AllotmentRemarks" Text='<%# Bind("AllotmentRemarks") %>' Width="350px" Height="40px" TextMode="MultiLine" CssClass="mytxt" onfocus="return this.select();" ValidationGroup="qcmRequestAllotment" onblur="this.value=this.value.replace(/\'/g,'');" ToolTip="Enter value for Allotment Remarks." MaxLength="500" runat="server" />
							</td>
						</tr>
					</table>
					<asp:Panel ID="pnlSchedule" runat="server" ScrollBars="Vertical" Width="100%" Height="200px" BackColor="#FFCC00">
					</asp:Panel>
				</td>
			</tr>
			<tr>
				<td>
				</td>
				<td>
				</td>
			</tr>
    </table>
	</div>
	</EditItemTemplate>
</asp:FormView>
  </ContentTemplate>
  <Triggers>
    <asp:PostBackTrigger ControlID="FVqcmRequestAllotment" />
  </Triggers>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSqcmRequestAllotment"
  DataObjectTypeName = "SIS.QCM.qcmRequestAllotment"
  SelectMethod = "qcmRequestAllotmentGetByID"
  UpdateMethod="UZ_qcmRequestAllotmentUpdate"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmRequestAllotment"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="RequestID" Name="RequestID" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
