<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_qcmRegions.aspx.vb" Inherits="AF_qcmRegions" title="Add: Regions" %>
<asp:Content ID="CPHqcmRegions" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmRegions" runat="server" Text="&nbsp;Add: Regions" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmRegions" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmRegions"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    ValidationGroup = "qcmRegions"
    runat = "server" />
<asp:FormView ID="FVqcmRegions"
	runat = "server"
	DataKeyNames = "RegionID"
	DataSourceID = "ODSqcmRegions"
	DefaultMode = "Insert" CssClass="sis_formview">
	<InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgqcmRegions" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_RegionID" ForeColor="#CC6633" runat="server" Text="Region ID :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_RegionID" Enabled="False" CssClass="mypktxt" width="70px" runat="server" Text="0" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_RegionName" runat="server" Text="Region Name :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_RegionName"
						Text='<%# Bind("RegionName") %>'
						CssClass = "mytxt"
						onfocus = "return this.select();"
						ValidationGroup="qcmRegions"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Region Name."
						MaxLength="50"
            Width="350px"
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
	</InsertItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSqcmRegions"
  DataObjectTypeName = "SIS.QCM.qcmRegions"
  InsertMethod="qcmRegionsInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmRegions"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
