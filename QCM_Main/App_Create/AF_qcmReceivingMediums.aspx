<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_qcmReceivingMediums.aspx.vb" Inherits="AF_qcmReceivingMediums" title="Add: Receiving Mediums" %>
<asp:Content ID="CPHqcmReceivingMediums" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmReceivingMediums" runat="server" Text="&nbsp;Add: Receiving Mediums" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmReceivingMediums" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmReceivingMediums"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    ValidationGroup = "qcmReceivingMediums"
    runat = "server" />
<asp:FormView ID="FVqcmReceivingMediums"
	runat = "server"
	DataKeyNames = "ReceivingMediumID"
	DataSourceID = "ODSqcmReceivingMediums"
	DefaultMode = "Insert" CssClass="sis_formview">
	<InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgqcmReceivingMediums" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_ReceivingMediumID" ForeColor="#CC6633" runat="server" Text="Receiving Medium ID :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_ReceivingMediumID" Enabled="False" CssClass="mypktxt" width="70px" runat="server" Text="0" />
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
						ValidationGroup="qcmReceivingMediums"
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
						ValidationGroup = "qcmReceivingMediums"
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
  ID = "ODSqcmReceivingMediums"
  DataObjectTypeName = "SIS.QCM.qcmReceivingMediums"
  InsertMethod="qcmReceivingMediumsInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmReceivingMediums"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
