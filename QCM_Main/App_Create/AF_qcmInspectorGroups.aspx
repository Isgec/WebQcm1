<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_qcmInspectorGroups.aspx.vb" Inherits="AF_qcmInspectorGroups" title="Add: Inspector Groups" %>
<asp:Content ID="CPHqcmInspectorGroups" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmInspectorGroups" runat="server" Text="&nbsp;Add: Inspector Groups" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmInspectorGroups" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmInspectorGroups"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    AfterInsertURL = "~/QCM_Main/App_Edit/EF_qcmInspectorGroups.aspx"
    ValidationGroup = "qcmInspectorGroups"
    runat = "server" />
<asp:FormView ID="FVqcmInspectorGroups"
	runat = "server"
	DataKeyNames = "GroupID"
	DataSourceID = "ODSqcmInspectorGroups"
	DefaultMode = "Insert" CssClass="sis_formview">
	<InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgqcmInspectorGroups" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
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
						ValidationGroup="qcmInspectorGroups"
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
						ValidationGroup = "qcmInspectorGroups"
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
  ID = "ODSqcmInspectorGroups"
  DataObjectTypeName = "SIS.QCM.qcmInspectorGroups"
  InsertMethod="UZ_qcmInspectorGroupsInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmInspectorGroups"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
