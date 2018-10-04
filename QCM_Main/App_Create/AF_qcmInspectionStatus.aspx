<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_qcmInspectionStatus.aspx.vb" Inherits="AF_qcmInspectionStatus" title="Add: Inspection Status" %>
<asp:Content ID="CPHqcmInspectionStatus" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmInspectionStatus" runat="server" Text="&nbsp;Add: Inspection Status" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmInspectionStatus" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmInspectionStatus"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    ValidationGroup = "qcmInspectionStatus"

    runat = "server" />
<asp:FormView ID="FVqcmInspectionStatus"
	runat = "server"
	DataKeyNames = "InspectionStatusID"
	DataSourceID = "ODSqcmInspectionStatus"
	DefaultMode = "Insert" CssClass="sis_formview">
	<InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgqcmInspectionStatus" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_InspectionStatusID" ForeColor="#CC6633" runat="server" Text="Inspection Status ID :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_InspectionStatusID" Enabled="False" CssClass="mypktxt" width="70px" runat="server" Text="0" />
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
						ValidationGroup="qcmInspectionStatus"
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
						ValidationGroup = "qcmInspectionStatus"
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
  ID = "ODSqcmInspectionStatus"
  DataObjectTypeName = "SIS.QCM.qcmInspectionStatus"
  InsertMethod="qcmInspectionStatusInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmInspectionStatus"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
