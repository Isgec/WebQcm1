<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_qcmInspectorGroupUsers.aspx.vb" Inherits="EF_qcmInspectorGroupUsers" title="Edit: Inspector Group Users" %>
<asp:Content ID="CPHqcmInspectorGroupUsers" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmInspectorGroupUsers" runat="server" Text="&nbsp;Edit: Inspector Group Users" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmInspectorGroupUsers" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmInspectorGroupUsers"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "qcmInspectorGroupUsers"
    runat = "server" />
<asp:FormView ID="FVqcmInspectorGroupUsers"
	runat = "server"
	DataKeyNames = "GroupID,CardNo"
	DataSourceID = "ODSqcmInspectorGroupUsers"
	DefaultMode = "Edit" CssClass="sis_formview">
	<EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
		<table>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_GroupID" runat="server" ForeColor="#CC6633" Text="Group ID :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_GroupID"
            Width="70px"
						Text='<%# Bind("GroupID") %>'
						CssClass = "mypktxt"
            Enabled = "False"
            ToolTip="Value of Group ID."
						Runat="Server" />
					<asp:Label
						ID = "F_GroupID_Display"
						Text='<%# Eval("QCM_InspectorGroups2_Description") %>'
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
  ID = "ODSqcmInspectorGroupUsers"
  DataObjectTypeName = "SIS.QCM.qcmInspectorGroupUsers"
  SelectMethod = "qcmInspectorGroupUsersGetByID"
  UpdateMethod="qcmInspectorGroupUsersUpdate"
  DeleteMethod="qcmInspectorGroupUsersDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmInspectorGroupUsers"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="GroupID" Name="GroupID" Type="Int32" />
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="CardNo" Name="CardNo" Type="String" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
