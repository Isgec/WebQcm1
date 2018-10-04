<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_qcmEmployeeGroupUsers.aspx.vb" Inherits="EF_qcmEmployeeGroupUsers" title="Edit: Employee Group Users" %>
<asp:Content ID="CPHqcmEmployeeGroupUsers" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmEmployeeGroupUsers" runat="server" Text="&nbsp;Edit: Employee Group Users" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmEmployeeGroupUsers" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmEmployeeGroupUsers"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "qcmEmployeeGroupUsers"
    runat = "server" />
<asp:FormView ID="FVqcmEmployeeGroupUsers"
	runat = "server"
	DataKeyNames = "GroupiD,CardNo"
	DataSourceID = "ODSqcmEmployeeGroupUsers"
	DefaultMode = "Edit" CssClass="sis_formview">
	<EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
		<table>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_GroupiD" runat="server" ForeColor="#CC6633" Text="GroupiD :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_GroupiD"
            Width="70px"
						Text='<%# Bind("GroupiD") %>'
						CssClass = "mypktxt"
            Enabled = "False"
            ToolTip="Value of GroupiD."
						Runat="Server" />
					<asp:Label
						ID = "F_GroupiD_Display"
						Text='<%# Eval("QCM_EmployeeGroups2_Description") %>'
						Runat="Server" />
        </td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_CardNo" runat="server" ForeColor="#CC6633" Text="User ID :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_CardNo"
            Width="56px"
						Text='<%# Bind("CardNo") %>'
						CssClass = "mypktxt"
            Enabled = "False"
            ToolTip="Value of User ID."
						Runat="Server" />
					<asp:Label
						ID = "F_CardNo_Display"
						Text='<%# Eval("HRM_Employees1_EmployeeName") %>'
						Runat="Server" />
        </td>
			</tr>
		</table>
	  </div>
	</EditItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSqcmEmployeeGroupUsers"
  DataObjectTypeName = "SIS.QCM.qcmEmployeeGroupUsers"
  SelectMethod = "qcmEmployeeGroupUsersGetByID"
  UpdateMethod="qcmEmployeeGroupUsersUpdate"
  DeleteMethod="qcmEmployeeGroupUsersDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmEmployeeGroupUsers"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="GroupiD" Name="GroupiD" Type="Int32" />
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="CardNo" Name="CardNo" Type="String" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
