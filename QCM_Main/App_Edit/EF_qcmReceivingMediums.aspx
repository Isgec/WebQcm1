<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_qcmReceivingMediums.aspx.vb" Inherits="EF_qcmReceivingMediums" title="Edit: Receiving Mediums" %>
<asp:Content ID="CPHqcmReceivingMediums" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmReceivingMediums" runat="server" Text="&nbsp;Edit: Receiving Mediums" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmReceivingMediums" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmReceivingMediums"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "qcmReceivingMediums"
    runat = "server" />
<asp:FormView ID="FVqcmReceivingMediums"
	runat = "server"
	DataKeyNames = "ReceivingMediumID"
	DataSourceID = "ODSqcmReceivingMediums"
	DefaultMode = "Edit" CssClass="sis_formview">
	<EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
		<table>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_ReceivingMediumID" runat="server" ForeColor="#CC6633" Text="Receiving Medium ID :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_ReceivingMediumID"
						Text='<%# Bind("ReceivingMediumID") %>'
            ToolTip="Value of Receiving Medium ID."
            Enabled = "False"
						CssClass = "mypktxt"
            Width="70px"
						style="text-align: right"
						runat="server" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_Description" runat="server" Text="Description :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_Description"
						Text='<%# Bind("Description") %>'
            Width="350px"
						CssClass = "mytxt"
						onfocus = "return this.select();"
						ValidationGroup="qcmReceivingMediums"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Description."
						MaxLength="50"
						runat="server" />
					<asp:RequiredFieldValidator 
						ID = "RFVDescription"
						runat = "server"
						ControlToValidate = "F_Description"
						Text = "Description is required."
						ErrorMessage = "[Required!]"
						Display = "Dynamic"
						EnableClientScript = "true"
						ValidationGroup = "qcmReceivingMediums"
						SetFocusOnError="true" />
				</td>
			</tr>
		</table>
	</div>
	</EditItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSqcmReceivingMediums"
  DataObjectTypeName = "SIS.QCM.qcmReceivingMediums"
  SelectMethod = "qcmReceivingMediumsGetByID"
  UpdateMethod="qcmReceivingMediumsUpdate"
  DeleteMethod="qcmReceivingMediumsDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmReceivingMediums"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="ReceivingMediumID" Name="ReceivingMediumID" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
