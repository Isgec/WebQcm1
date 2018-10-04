<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_qcmVendors.aspx.vb" Inherits="AF_qcmVendors" title="Add: Vendors" %>
<asp:Content ID="CPHqcmVendors" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmVendors" runat="server" Text="&nbsp;Add: Vendors" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmVendors" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmVendors"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    ValidationGroup = "qcmVendors"
    runat = "server" />
<asp:FormView ID="FVqcmVendors"
	runat = "server"
	DataKeyNames = "VendorID"
	DataSourceID = "ODSqcmVendors"
	DefaultMode = "Insert" CssClass="sis_formview">
	<InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgqcmVendors" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_VendorID" ForeColor="#CC6633" runat="server" Text="Vendor :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_VendorID"
						Text='<%# Bind("VendorID") %>'
						CssClass = "mypktxt"
						onfocus = "return this.select();"
						ValidationGroup="qcmVendors"
            onblur= "script_qcmVendors.validate_VendorID(this);"
            ToolTip="Enter value for Vendor."
						MaxLength="6"
            Width="42px"
						runat="server" />
					<asp:RequiredFieldValidator 
						ID = "RFVVendorID"
						runat = "server"
						ControlToValidate = "F_VendorID"
						Text = "Vendor is required."
						ErrorMessage = "[Required!]"
						Display = "Dynamic"
						EnableClientScript = "true"
						ValidationGroup = "qcmVendors"
						SetFocusOnError="true" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_Description" runat="server" Text="Description :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_Description"
						Text='<%# Bind("Description") %>'
						CssClass = "mytxt"
						onfocus = "return this.select();"
						ValidationGroup="qcmVendors"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Description."
						MaxLength="50"
            Width="350px"
						runat="server" />
					<asp:RequiredFieldValidator 
						ID = "RFVDescription"
						runat = "server"
						ControlToValidate = "F_Description"
						Text = "Description is required."
						ErrorMessage = "[Required!]"
						Display = "Dynamic"
						EnableClientScript = "true"
						ValidationGroup = "qcmVendors"
						SetFocusOnError="true" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_ContactPerson" runat="server" Text="Contact Person :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_ContactPerson"
						Text='<%# Bind("ContactPerson") %>'
						CssClass = "mytxt"
						onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Contact Person."
						MaxLength="50"
            Width="350px"
						runat="server" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_EmailID" runat="server" Text="EmailID :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_EmailID"
						Text='<%# Bind("EmailID") %>'
						CssClass = "mytxt"
						onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for EmailID."
						MaxLength="50"
            Width="350px"
						runat="server" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_ContactNo" runat="server" Text="Contact No :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_ContactNo"
						Text='<%# Bind("ContactNo") %>'
						CssClass = "mytxt"
						onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Contact No."
						MaxLength="20"
            Width="140px"
						runat="server" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_Address1" runat="server" Text="Address1 :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_Address1"
						Text='<%# Bind("Address1") %>'
						CssClass = "mytxt"
						onfocus = "return this.select();"
						ValidationGroup="qcmVendors"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Address1."
						MaxLength="60"
            Width="420px"
						runat="server" />
					<asp:RequiredFieldValidator 
						ID = "RFVAddress1"
						runat = "server"
						ControlToValidate = "F_Address1"
						Text = "Address1 is required."
						ErrorMessage = "[Required!]"
						Display = "Dynamic"
						EnableClientScript = "true"
						ValidationGroup = "qcmVendors"
						SetFocusOnError="true" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_Address2" runat="server" Text="Address2 :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_Address2"
						Text='<%# Bind("Address2") %>'
						CssClass = "mytxt"
						onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Address2."
						MaxLength="60"
            Width="420px"
						runat="server" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_Address3" runat="server" Text="Address3 :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_Address3"
						Text='<%# Bind("Address3") %>'
						CssClass = "mytxt"
						onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Address3."
						MaxLength="60"
            Width="420px"
						runat="server" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_Address4" runat="server" Text="Address4 :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_Address4"
						Text='<%# Bind("Address4") %>'
						CssClass = "mytxt"
						onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Address4."
						MaxLength="60"
            Width="420px"
						runat="server" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_ToEMailID" runat="server" Text="Remarks :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_ToEMailID"
						Text='<%# Bind("ToEMailID") %>'
						CssClass = "mytxt"
						onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Remarks."
						MaxLength="250"
            Width="350px" Height="40px" TextMode="MultiLine"
						runat="server" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_CCEmailID" runat="server" Text="CCEmailID :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_CCEmailID"
						Text='<%# Bind("CCEmailID") %>'
						CssClass = "mytxt"
						onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for CCEmailID."
						MaxLength="250"
            Width="350px" Height="40px" TextMode="MultiLine"
						runat="server" />
				</td>
			</tr>
		</table>
		</div>
	</InsertItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSqcmVendors"
  DataObjectTypeName = "SIS.QCM.qcmVendors"
  InsertMethod="qcmVendorsInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmVendors"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
