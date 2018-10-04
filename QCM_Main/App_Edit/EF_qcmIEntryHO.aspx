<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_qcmIEntryHO.aspx.vb" Inherits="EF_qcmIEntryHO" title="Edit: Pending Inspections" %>
<asp:Content ID="CPHqcmIEntryHO" ContentPlaceHolderID="cph1" runat="Server">
  <div id="div1" class="ui-widget-content page">
    <div id="div2" class="caption">
      <asp:Label ID="LabelqcmIEntryHO" runat="server" Text="&nbsp;Request Details" Width="100%" CssClass="sis_formheading"></asp:Label>
    </div>
    <div id="div3" class="pagedata">
      <asp:UpdatePanel ID="UPNLqcmIEntryHO" runat="server">
        <ContentTemplate>
          <LGM:ToolBar0 ID="TBLqcmIEntryHO" ToolType="lgNMEdit" UpdateAndStay="False" EnableSave="false" EnableDelete="False" ValidationGroup="qcmIEntryHO" runat="server" />
          <asp:FormView ID="FVqcmIEntryHO" runat="server" DataKeyNames="RequestID" DataSourceID="ODSqcmIEntryHO" DefaultMode="Edit" CssClass="sis_formview">
            <EditItemTemplate>
              <div id="frmdiv" class="ui-widget-content minipage">
                <table style="margin: auto; border: solid 1pt lightgrey">
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
                              <asp:Label ID="L_OrderNo" runat="server" Text="Purchase Order No :" /></b>
                          </td>
                          <td>
                            <table>
                              <tr>
                                <td>
                                  <asp:TextBox ID="F_OrderNo" Text='<%# Bind("OrderNo") %>' Enabled="False" Width="100px" CssClass="dmytxt" runat="server" />
                                </td>
                                <td class="alignright">
                                  <b>
                                    <asp:Label ID="L_OrderDate" runat="server" Text="Date :" /></b>
                                </td>
                                <td>
                                  <asp:TextBox ID="F_OrderDate" Text='<%# Bind("OrderDate") %>' Enabled="False" Width="100px" CssClass="dmytxt" runat="server" />
                                </td>
                              </tr>
                            </table>
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <b>
                              <asp:Label ID="L_SupplierID" runat="server" Text="Supplier ID :" /></b>
                          </td>
                          <td>
                            <asp:TextBox ID="F_SupplierID" Width="42px" Text='<%# Bind("SupplierID") %>' Enabled="False"  CssClass="dmyfktxt" runat="Server" />
                            <asp:Label ID="F_SupplierID_Display" Text='<%# Eval("IDM_Vendors7_Description") %>' runat="Server" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <b>
                              <asp:Label ID="L_Description" runat="server" Text="Item Description :" /></b>
                          </td>
                          <td>
                            <asp:TextBox ID="F_Description" Text='<%# Bind("Description") %>'  Enabled="False" Width="350px" TextMode="MultiLine" Height="40px" CssClass="dmytxt" runat="server" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <b>
                              <asp:Label ID="Label1" runat="server" Text="Requested Stage :" /></b>
                          </td>
                          <td>
                            <asp:TextBox ID="F_QCM_InspectionStages8_Description" Text='<%# Bind("QCM_InspectionStages8_Description") %>' Enabled="False" Width="350px" CssClass="dmytxt" runat="server" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <b>
                              <asp:Label ID="L_TotalRequestedQuantity" runat="server" Text="Stage Quantity :" /></b>
                          </td>
                          <td>
                            <table>
                              <tr>
                                <td>
                                  <asp:TextBox ID="F_TotalRequestedQuantity" Text='<%# Bind("TotalRequestedQuantity") %>' Enabled="False" Width="100px" CssClass="dmytxt" runat="server" />
                                </td>
                                <td class="alignright">
                                  <b>
                                    <asp:Label ID="Label2" runat="server" Text="Final Quantity :" /></b>
                                </td>
                                <td>
                                  <asp:TextBox ID="F_LotSize" Text='<%# Bind("LotSize") %>' Enabled="False" Width="100px" CssClass="dmytxt" runat="server" />
                                </td>
                                <td class="alignright">
                                  <b>
                                    <asp:Label ID="Label3" runat="server" Text="UOM :" /></b>
                                </td>
                                <td>
                                  <asp:TextBox ID="F_UOM" Text='<%# Bind("UOM") %>' Enabled="False" Width="60px" CssClass="dmytxt" runat="server" />
                                </td>
                              </tr>
                            </table>
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <b>
                              <asp:Label ID="L_ClientInspectionRequired" runat="server" Text="Client Inspection Required :" /></b>
                          </td>
                          <td>
                            <table>
                              <tr>
                                <td>
                                  <asp:CheckBox ID="F_ClientInspectionRequired" Checked='<%# Bind("ClientInspectionRequired") %>' Enabled="False" runat="server" />
                                </td>
                                <td class="alignright">
                                  <b>
                                    <asp:Label ID="L_ThirdPartyInspectionRequired" runat="server" Text="Third Party Inspection Required :" /></b>
                                </td>
                                <td>
                                  <asp:CheckBox ID="F_ThirdPartyInspectionRequired" Checked='<%# Bind("ThirdPartyInspectionRequired") %>' Enabled="False" runat="server" />
                                </td>
                              </tr>
                            </table>
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <b>
                              <asp:Label ID="L_AllotedTo" runat="server" Text="Alloted To :" /></b>
                          </td>
                          <td>
                            <asp:TextBox ID="F_AllotedTo" Width="56px" Text='<%# Bind("AllotedTo") %>' Enabled="False" ToolTip="Value of Alloted To." CssClass="dmyfktxt" runat="Server" />
                            <asp:Label ID="F_AllotedTo_Display" Text='<%# Eval("HRM_Employees2_EmployeeName") %>' runat="Server" />
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <b>
                              <asp:Label ID="L_AllotedStartDate" runat="server" Text="Alloted Start Date :" /></b>
                          </td>
                          <td>
                            <table>
                              <tr>
                                <td>
                                  <asp:TextBox ID="F_AllotedStartDate" Text='<%# Bind("AllotedStartDate") %>' ToolTip="Value of Alloted Start Date." Enabled="False" Width="140px" CssClass="dmytxt" runat="server" />
                                </td>
                                <td class="alignright">
                                  <b>
                                    <asp:Label ID="L_AllotedFinishDate" runat="server" Text="Alloted Finish Date :" /></b>
                                </td>
                                <td>
                                  <asp:TextBox ID="F_AllotedFinishDate" Text='<%# Bind("AllotedFinishDate") %>' ToolTip="Value of Alloted Finish Date." Enabled="False" Width="140px" CssClass="dmytxt" runat="server" />
                                </td>
                              </tr>
                            </table>
                          </td>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <b>
                              <asp:Label ID="L_AllotedOn" runat="server" Text="Alloted On :" /></b>
                          </td>
                          <td>
                            <table>
                              <tr>
                                <td>
                                  <asp:TextBox ID="F_AllotedOn" Text='<%# Bind("AllotedOn") %>' ToolTip="Value of Alloted On." Enabled="False" Width="140px" CssClass="dmytxt" runat="server" />
                                </td>
                                <td class="alignright">
                                  <b>
                                    <asp:Label ID="L_AllotedBy" runat="server" Text="Alloted By :" /></b>
                                </td>
                                <td>
                                  <asp:TextBox ID="F_AllotedBy" Width="56px" Text='<%# Bind("AllotedBy") %>' Enabled="False" ToolTip="Value of Alloted By." CssClass="dmyfktxt" runat="Server" />
                                  <asp:Label ID="F_AllotedBy_Display" Text='<%# Eval("HRM_Employees3_EmployeeName") %>' runat="Server" />
                                </td>
                              </tr>
                            </table>
                          </td>
                        </tr>
                        <tr>
                        </tr>
                        <tr>
                          <td class="alignright">
                            <b>
                              <asp:Label ID="L_AllotmentRemarks" runat="server" Text="Allotment Remarks :" /></b>
                          </td>
                          <td>
                            <asp:TextBox ID="F_AllotmentRemarks" Text='<%# Bind("AllotmentRemarks") %>' Enabled="False" Width="350px" CssClass="dmytxt" runat="server" />
                          </td>
                        </tr>
                      </table>
                    </td>
                    <td width="30%" valign="top">
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
                                <asp:GridView ID="GVqcmRequestFiles" SkinID="gv_silver" PagerSettings-Mode="NumericFirstLast" PagerSettings-Position="Bottom" BorderColor="#A9A9A9" Width="100%" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ODSqcmRequestFiles" DataKeyNames="RequestID,SerialNo">
                                  <Columns>
                                    <asp:TemplateField HeaderText="Attached File(s)" SortExpression="FileName">
                                      <ItemTemplate>
                                        <asp:LinkButton ID="LabelFileName" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("FileName") %>' CommandName="DownloadFile" CommandArgument='<%# Container.DataItemIndex %>'></asp:LinkButton>
                                      </ItemTemplate>
                                      <HeaderStyle Width="200px" />
                                    </asp:TemplateField>
                                  </Columns>
                                  <EmptyDataTemplate>
                                    <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No Attachment found !!!"></asp:Label>
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
                    </td>
                  </tr>
                </table>
                <fieldset class="ui-widget-content page">
                  <legend>
                    <asp:Label ID="LabelqcmInspections" runat="server" Text="&nbsp;List: Inspection Reports Submitted to HO" Width="100%" CssClass="sis_formheading"></asp:Label>
                  </legend>
                  <div class="pagedata">
                    <asp:UpdatePanel ID="UPNLqcmInspections" runat="server">
                      <ContentTemplate>
                        <table width="100%">
                          <tr>
                            <td class="sis_formview">
                              <LGM:ToolBar0 ID="TBLqcmInspections" ToolType="lgNMGrid" EnableAdd='<%# Editable %>' EditUrl="~/QCM_Main/App_Edit/EF_qcmInspections.aspx" AddUrl="~/QCM_Main/App_Create/AF_qcmInspections.aspx?skip=1" AddPostBack="True" ValidationGroup="qcmInspections" runat="server" />
                              <asp:UpdateProgress ID="UPGSqcmInspections" runat="server" AssociatedUpdatePanelID="UPNLqcmInspections" DisplayAfter="100">
                                <ProgressTemplate>
                                  <span style="color: #ff0033">Loading...</span>
                                </ProgressTemplate>
                              </asp:UpdateProgress>
                              <asp:GridView ID="GVqcmInspections" SkinID="gv_silver" BorderColor="#A9A9A9" Width="100%" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ODSqcmInspections" DataKeyNames="RequestID,InspectionID">
                                <Columns>
                                  <asp:TemplateField HeaderText="EDIT">
                                    <ItemTemplate>
                                      <asp:ImageButton ID="cmdEditPage" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
                                    </ItemTemplate>
                                    <HeaderStyle Width="30px" CssClass="alignCenter" />
                                    <ItemStyle CssClass="alignCenter" />
                                  </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Inspection ID" SortExpression="InspectionID">
                                    <ItemTemplate>
                                      <asp:Label ID="LabelInspectionID" runat="server" ForeColor='<%# Eval("ForeColor") %>' Text='<%# Bind("InspectionID") %>'></asp:Label>
                                    </ItemTemplate>
                                    <HeaderStyle Width="50px" CssClass="alignCenter" />
                                    <ItemStyle CssClass="alignCenter" />
                                  </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Project ID" SortExpression="IDM_Projects2_Description">
                                    <ItemTemplate>
                                      <asp:Label ID="L_ProjectID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("ProjectID") %>' Text='<%# Eval("IDM_Projects2_Description") %>'></asp:Label>
                                    </ItemTemplate>
                                    <HeaderStyle Width="100px" />
                                  </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Order No" SortExpression="OrderNo">
                                    <ItemTemplate>
                                      <asp:Label ID="LabelOrderNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("OrderNo") %>'></asp:Label>
                                    </ItemTemplate>
                                    <HeaderStyle Width="80px" />
                                  </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Supplier ID" SortExpression="IDM_Vendors3_Description">
                                    <ItemTemplate>
                                      <asp:Label ID="L_SupplierID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("SupplierID") %>' Text='<%# Eval("IDM_Vendors3_Description") %>'></asp:Label>
                                    </ItemTemplate>
                                    <HeaderStyle Width="100px" />
                                  </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Inspection Remarks" SortExpression="InspectionRemarks">
                                    <ItemTemplate>
                                      <asp:Label ID="LabelInspectionRemarks" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("InspectionRemarks") %>'></asp:Label>
                                    </ItemTemplate>
                                    <HeaderStyle Width="100px" />
                                  </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Status" SortExpression="QCM_InspectionStatus5_Description">
                                    <ItemTemplate>
                                      <asp:Label ID="L_QCM_InspectionStatus5_Description" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Eval("QCM_InspectionStatus5_Description") %>'></asp:Label>
                                    </ItemTemplate>
                                    <HeaderStyle Width="100px" />
                                  </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Inspected By" SortExpression="HRM_Employees1_EmployeeName">
                                    <ItemTemplate>
                                      <asp:Label ID="L_InspectedBy" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("InspectedBy") %>' Text='<%# Eval("HRM_Employees1_EmployeeName") %>'></asp:Label>
                                    </ItemTemplate>
                                    <HeaderStyle Width="100px" />
                                  </asp:TemplateField>
                                  <asp:TemplateField HeaderText="Inspected On" SortExpression="InspectedOn">
                                    <ItemTemplate>
                                      <asp:Label ID="LabelInspectedOn" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("InspectedOn") %>'></asp:Label>
                                    </ItemTemplate>
                                    <HeaderStyle Width="80px" />
                                  </asp:TemplateField>
                                </Columns>
                                <EmptyDataTemplate>
                                  <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
                                </EmptyDataTemplate>
                              </asp:GridView>
                              <asp:ObjectDataSource ID="ODSqcmInspections" runat="server" DataObjectTypeName="SIS.QCM.qcmInspections" OldValuesParameterFormatString="original_{0}" SelectMethod="UZ_qcmInspectionsSelectList" TypeName="SIS.QCM.qcmInspections" SelectCountMethod="qcmInspectionsSelectCount" SortParameterName="OrderBy" EnablePaging="True">
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
                        <asp:AsyncPostBackTrigger ControlID="GVqcmInspections" EventName="PageIndexChanged" />
                      </Triggers>
                    </asp:UpdatePanel>
                  </div>
                </fieldset>
              </div>
            </EditItemTemplate>
          </asp:FormView>
        </ContentTemplate>
      </asp:UpdatePanel>
      <asp:ObjectDataSource ID="ODSqcmIEntryHO" DataObjectTypeName="SIS.QCM.qcmIEntryHO" SelectMethod="qcmIEntryHOGetByID" UpdateMethod="UZ_qcmIEntryHOUpdate" OldValuesParameterFormatString="original_{0}" TypeName="SIS.QCM.qcmIEntryHO" runat="server">
        <SelectParameters>
          <asp:QueryStringParameter DefaultValue="0" QueryStringField="RequestID" Name="RequestID" Type="Int32" />
        </SelectParameters>
      </asp:ObjectDataSource>
    </div>
  </div>
</asp:Content>
