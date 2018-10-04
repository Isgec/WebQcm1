<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_qcmRegions.aspx.vb" Inherits="EF_qcmRegions" title="Edit: Regions" %>
<asp:Content ID="CPHqcmRegions" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmRegions" runat="server" Text="&nbsp;Edit: Regions" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmRegions" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmRegions"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "qcmRegions"
    runat = "server" />
<asp:FormView ID="FVqcmRegions"
	runat = "server"
	DataKeyNames = "RegionID"
	DataSourceID = "ODSqcmRegions"
	DefaultMode = "Edit" CssClass="sis_formview">
	<EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
		<table>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_RegionID" runat="server" ForeColor="#CC6633" Text="Region ID :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_RegionID"
						Text='<%# Bind("RegionID") %>'
            ToolTip="Value of Region ID."
            Enabled = "False"
						CssClass = "mypktxt"
            Width="70px"
						style="text-align: right"
						runat="server" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_RegionName" runat="server" Text="Region Name :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_RegionName"
						Text='<%# Bind("RegionName") %>'
            Width="350px"
						CssClass = "mytxt"
						onfocus = "return this.select();"
						ValidationGroup="qcmRegions"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Region Name."
						MaxLength="50"
						runat="server" />
					<asp:RequiredFieldValidator 
						ID = "RFVRegionName"
						runat = "server"
						ControlToValidate = "F_RegionName"
						Text = "Region Name is required."
						ErrorMessage = "[Required!]"
						Display = "Dynamic"
						EnableClientScript = "true"
						ValidationGroup = "qcmRegions"
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
  ID = "ODSqcmRegions"
  DataObjectTypeName = "SIS.QCM.qcmRegions"
  SelectMethod = "qcmRegionsGetByID"
  UpdateMethod="qcmRegionsUpdate"
  DeleteMethod="qcmRegionsDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmRegions"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="RegionID" Name="RegionID" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
