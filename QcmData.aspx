<%@ Page Language="VB" AutoEventWireup="false" CodeFile="QcmData.aspx.vb" Inherits="QcmData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  <meta name="viewport" content="width=480" />
  <meta name="viewport" content="width=device-width" />
  <meta name="MobileOptimized" content="width" />
  <meta name="HandheldFriendly" content="true" />
</head>
<body>
  <form id="form1" runat="server">
      <div id="maindiv" runat="server">
  <ASP:ScriptManager ID="ToolkitScriptManager1" runat="server" ScriptMode="Auto">
  </ASP:ScriptManager>
      <asp:FormView ID="FVqcmInspections"
	      runat = "server"
	      DataKeyNames = "RequestID,InspectionID"
	      DataSourceID = "ODSqcmInspections"
	      DefaultMode = "Insert" CssClass="sis_formview">
	      <InsertItemTemplate>
          <table style="border: solid 1pt lightgrey">
			      <tr style="display:none">
				      <td class="alignright">
					      <b><asp:Label ID="L_RequestID" ForeColor="#CC6633" runat="server" Text="Request ID :" /></b>
				      </td>
              <td>
					      <asp:TextBox
						      ID = "F_RequestID"
						      CssClass = "mypktxt"
                  Width="70px"
						      Text='<%# Bind("RequestID") %>'
                  Enabled="false"
						      Runat="Server" />
              </td>
			      </tr>
			      <tr style="display:none">
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
                  ToolTip="Enter Inspection Remarks."
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
              <td></td>
              <td>
                <table style="margin:auto">
                  <tr>
                    <td style="text-align:center">
                      <input type="button" value="Cancel" style="background-color:pink;color:red" onclick="self.close();return false;" />
                    </td>
                    <td style="text-align:center">
                      <asp:Button ID="cmdSave" runat="server" Text="Save" BackColor="Lime" ForeColor="Green" CommandName="Insert"  />
                    </td>
                  </tr>
                </table>
              </td>
            </tr>
		      </table>
	      </InsertItemTemplate>
      </asp:FormView>
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
      <div id="subDiv" runat="server" style="text-align:left">
        <asp:Label ID="msg" runat="server" Font-Bold="true" Font-Size="Larger" ForeColor="Green" Text="" />
      </div>
    </form>
</body>
</html>
