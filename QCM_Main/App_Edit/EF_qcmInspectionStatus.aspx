<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_qcmInspectionStatus.aspx.vb" Inherits="EF_qcmInspectionStatus" title="Edit: Inspection Status" %>
<asp:Content ID="CPHqcmInspectionStatus" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmInspectionStatus" runat="server" Text="&nbsp;Edit: Inspection Status" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmInspectionStatus" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmInspectionStatus"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "qcmInspectionStatus"
    runat = "server" />
<asp:FormView ID="FVqcmInspectionStatus"
	runat = "server"
	DataKeyNames = "InspectionStatusID"
	DataSourceID = "ODSqcmInspectionStatus"
	DefaultMode = "Edit" CssClass="sis_formview">
	<EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
		<table>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_InspectionStatusID" runat="server" ForeColor="#CC6633" Text="Inspection Status ID :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_InspectionStatusID"
						Text='<%# Bind("InspectionStatusID") %>'
            ToolTip="Value of Inspection Status ID."
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
						ValidationGroup="qcmInspectionStatus"
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
						ValidationGroup = "qcmInspectionStatus"
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
  ID = "ODSqcmInspectionStatus"
  DataObjectTypeName = "SIS.QCM.qcmInspectionStatus"
  SelectMethod = "qcmInspectionStatusGetByID"
  UpdateMethod="qcmInspectionStatusUpdate"
  DeleteMethod="qcmInspectionStatusDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmInspectionStatus"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="InspectionStatusID" Name="InspectionStatusID" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
