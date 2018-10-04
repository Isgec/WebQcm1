<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_qcmIGvsEG.aspx.vb" Inherits="EF_qcmIGvsEG" title="Edit: Inspectors vs Employee" %>
<asp:Content ID="CPHqcmIGvsEG" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmIGvsEG" runat="server" Text="&nbsp;Edit: Inspectors vs Employee" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmIGvsEG" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmIGvsEG"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "qcmIGvsEG"

    runat = "server" />
<asp:FormView ID="FVqcmIGvsEG"
	runat = "server"
	DataKeyNames = "InspectorGroupID,EmployeeGroupID"
	DataSourceID = "ODSqcmIGvsEG"
	DefaultMode = "Edit" CssClass="sis_formview">
	<EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
		<table>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_InspectorGroupID" runat="server" ForeColor="#CC6633" Text="Inspector Group ID :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_InspectorGroupID"
            Width="70px"
						Text='<%# Bind("InspectorGroupID") %>'
						CssClass = "mypktxt"
            Enabled = "False"
            ToolTip="Value of Inspector Group ID."
						Runat="Server" />
					<asp:Label
						ID = "F_InspectorGroupID_Display"
						Text='<%# Eval("QCM_InspectorGroups2_Description") %>'
						Runat="Server" />
        </td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_EmployeeGroupID" runat="server" ForeColor="#CC6633" Text="Employee Group ID :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_EmployeeGroupID"
            Width="70px"
						Text='<%# Bind("EmployeeGroupID") %>'
						CssClass = "mypktxt"
            Enabled = "False"
            ToolTip="Value of Employee Group ID."
						Runat="Server" />
					<asp:Label
						ID = "F_EmployeeGroupID_Display"
						Text='<%# Eval("QCM_EmployeeGroups1_Description") %>'
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
  ID = "ODSqcmIGvsEG"
  DataObjectTypeName = "SIS.QCM.qcmIGvsEG"
  SelectMethod = "qcmIGvsEGGetByID"
  UpdateMethod="qcmIGvsEGUpdate"
  DeleteMethod="qcmIGvsEGDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmIGvsEG"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="InspectorGroupID" Name="InspectorGroupID" Type="Int32" />
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="EmployeeGroupID" Name="EmployeeGroupID" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
