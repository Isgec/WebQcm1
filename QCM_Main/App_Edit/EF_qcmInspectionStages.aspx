<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_qcmInspectionStages.aspx.vb" Inherits="EF_qcmInspectionStages" title="Edit: Inspection Stages" %>
<asp:Content ID="CPHqcmInspectionStages" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmInspectionStages" runat="server" Text="&nbsp;Edit: Inspection Stages" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmInspectionStages" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmInspectionStages"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "qcmInspectionStages"
    runat = "server" />
<asp:FormView ID="FVqcmInspectionStages"
	runat = "server"
	DataKeyNames = "InspectionStageID"
	DataSourceID = "ODSqcmInspectionStages"
	DefaultMode = "Edit" CssClass="sis_formview">
	<EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
		<table>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_InspectionStageID" runat="server" ForeColor="#CC6633" Text="Inspection StageID :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_InspectionStageID"
						Text='<%# Bind("InspectionStageID") %>'
            ToolTip="Value of Inspection StageID."
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
						ValidationGroup="qcmInspectionStages"
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
						ValidationGroup = "qcmInspectionStages"
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
  ID = "ODSqcmInspectionStages"
  DataObjectTypeName = "SIS.QCM.qcmInspectionStages"
  SelectMethod = "qcmInspectionStagesGetByID"
  UpdateMethod="qcmInspectionStagesUpdate"
  DeleteMethod="qcmInspectionStagesDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmInspectionStages"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="InspectionStageID" Name="InspectionStageID" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
