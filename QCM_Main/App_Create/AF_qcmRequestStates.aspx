<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_qcmRequestStates.aspx.vb" Inherits="AF_qcmRequestStates" title="Add: Request States" %>
<asp:Content ID="CPHqcmRequestStates" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmRequestStates" runat="server" Text="&nbsp;Add: Request States" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmRequestStates" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmRequestStates"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    ValidationGroup = "qcmRequestStates"
    runat = "server" />
<asp:FormView ID="FVqcmRequestStates"
	runat = "server"
	DataKeyNames = "StateID"
	DataSourceID = "ODSqcmRequestStates"
	DefaultMode = "Insert" CssClass="sis_formview">
	<InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgqcmRequestStates" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_StateID" ForeColor="#CC6633" runat="server" Text="Request State ID :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_StateID"
						Text='<%# Bind("StateID") %>'
						CssClass = "mypktxt"
						onfocus = "return this.select();"
						ValidationGroup="qcmRequestStates"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Request State ID."
						MaxLength="10"
            Width="70px"
						runat="server" />
					<asp:RequiredFieldValidator 
						ID = "RFVStateID"
						runat = "server"
						ControlToValidate = "F_StateID"
						Text = "Request State ID is required."
						ErrorMessage = "[Required!]"
						Display = "Dynamic"
						EnableClientScript = "true"
						ValidationGroup = "qcmRequestStates"
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
						ValidationGroup="qcmRequestStates"
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
						ValidationGroup = "qcmRequestStates"
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
  ID = "ODSqcmRequestStates"
  DataObjectTypeName = "SIS.QCM.qcmRequestStates"
  InsertMethod="qcmRequestStatesInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmRequestStates"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
