<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_qcmInspectionStages.aspx.vb" Inherits="AF_qcmInspectionStages" title="Add: Inspection Stages" %>
<asp:Content ID="CPHqcmInspectionStages" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmInspectionStages" runat="server" Text="&nbsp;Add: Inspection Stages" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmInspectionStages" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmInspectionStages"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    ValidationGroup = "qcmInspectionStages"
    runat = "server" />
<asp:FormView ID="FVqcmInspectionStages"
	runat = "server"
	DataKeyNames = "InspectionStageID"
	DataSourceID = "ODSqcmInspectionStages"
	DefaultMode = "Insert" CssClass="sis_formview">
	<InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgqcmInspectionStages" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_InspectionStageID" ForeColor="#CC6633" runat="server" Text="Inspection StageID :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_InspectionStageID" Enabled="False" CssClass="mypktxt" width="70px" runat="server" Text="0" />
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
						ValidationGroup="qcmInspectionStages"
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
						ValidationGroup = "qcmInspectionStages"
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
  ID = "ODSqcmInspectionStages"
  DataObjectTypeName = "SIS.QCM.qcmInspectionStages"
  InsertMethod="qcmInspectionStagesInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmInspectionStages"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
