<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_qcmEmployeeGroups.aspx.vb" Inherits="AF_qcmEmployeeGroups" title="Add: Employee Groups" %>
<asp:Content ID="CPHqcmEmployeeGroups" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmEmployeeGroups" runat="server" Text="&nbsp;Add: Employee Groups" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmEmployeeGroups" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmEmployeeGroups"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    AfterInsertURL = "~/QCM_Main/App_Edit/EF_qcmEmployeeGroups.aspx"
    ValidationGroup = "qcmEmployeeGroups"
    runat = "server" />
<asp:FormView ID="FVqcmEmployeeGroups"
	runat = "server"
	DataKeyNames = "GroupID"
	DataSourceID = "ODSqcmEmployeeGroups"
	DefaultMode = "Insert" CssClass="sis_formview">
	<InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgqcmEmployeeGroups" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_GroupID" ForeColor="#CC6633" runat="server" Text="Group ID :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_GroupID" Enabled="False" CssClass="mypktxt" width="70px" runat="server" Text="0" />
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
						ValidationGroup="qcmEmployeeGroups"
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
						ValidationGroup = "qcmEmployeeGroups"
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
  ID = "ODSqcmEmployeeGroups"
  DataObjectTypeName = "SIS.QCM.qcmEmployeeGroups"
  InsertMethod="UZ_qcmEmployeeGroupsInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmEmployeeGroups"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
