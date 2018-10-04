<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_qcmInspectorGroups.aspx.vb" Inherits="EF_qcmInspectorGroups" title="Edit: Inspector Groups" %>
<asp:Content ID="CPHqcmInspectorGroups" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmInspectorGroups" runat="server" Text="&nbsp;Edit: Inspector Groups" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmInspectorGroups" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmInspectorGroups"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "qcmInspectorGroups"
    runat = "server" />
<asp:FormView ID="FVqcmInspectorGroups"
	runat = "server"
	DataKeyNames = "GroupID"
	DataSourceID = "ODSqcmInspectorGroups"
	DefaultMode = "Edit" CssClass="sis_formview">
	<EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
		<table>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_GroupID" runat="server" ForeColor="#CC6633" Text="Group ID :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_GroupID"
						Text='<%# Bind("GroupID") %>'
            ToolTip="Value of Group ID."
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
						ValidationGroup="qcmInspectorGroups"
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
						ValidationGroup = "qcmInspectorGroups"
						SetFocusOnError="true" />
				</td>
			</tr>
		</table>
<fieldset class="ui-widget-content page">
<legend>
    <asp:Label ID="LabelqcmInspectorGroupUsers" runat="server" Text="&nbsp;List: Inspector Group Users" Width="100%" CssClass="sis_formheading"></asp:Label>
</legend>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLqcmInspectorGroupUsers" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLqcmInspectorGroupUsers"
      ToolType = "lgNMGrid"
      EditUrl = "~/QCM_Main/App_Edit/EF_qcmInspectorGroupUsers.aspx"
      AddUrl = "~/QCM_Main/App_Create/AF_qcmInspectorGroupUsers.aspx"
      AddPostBack = "True"
      ValidationGroup = "qcmInspectorGroupUsers"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSqcmInspectorGroupUsers" runat="server" AssociatedUpdatePanelID="UPNLqcmInspectorGroupUsers" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVqcmInspectorGroupUsers" SkinID="gv_silver" BorderColor="#A9A9A9" width="100%" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ODSqcmInspectorGroupUsers" DataKeyNames="GroupID,CardNo">
      <Columns>
        <asp:TemplateField>
          <ItemTemplate>
						<Table><tr>
              <td><asp:ImageButton ID="cmdEditPage" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' /></td>
						</tr></Table>
          </ItemTemplate>
          <HeaderStyle Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Group ID" SortExpression="QCM_InspectorGroups2_Description">
          <ItemTemplate>
             <asp:Label ID="L_GroupID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("GroupID") %>' Text='<%# Eval("QCM_InspectorGroups2_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="User ID" SortExpression="HRM_Employees1_EmployeeName">
          <ItemTemplate>
             <asp:Label ID="L_CardNo" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("CardNo") %>' Text='<%# Eval("HRM_Employees1_EmployeeName") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSqcmInspectorGroupUsers"
      runat = "server"
      DataObjectTypeName = "SIS.QCM.qcmInspectorGroupUsers"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "qcmInspectorGroupUsersSelectList"
      TypeName = "SIS.QCM.qcmInspectorGroupUsers"
      SelectCountMethod = "qcmInspectorGroupUsersSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_GroupID" PropertyName="Text" Name="GroupID" Type="Int32" Size="10" />
				<asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
				<asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVqcmInspectorGroupUsers" EventName="PageIndexChanged" />
  </Triggers>
</asp:UpdatePanel>
</div>
</fieldset>
</div>
	</EditItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSqcmInspectorGroups"
  DataObjectTypeName = "SIS.QCM.qcmInspectorGroups"
  SelectMethod = "qcmInspectorGroupsGetByID"
  UpdateMethod="UZ_qcmInspectorGroupsUpdate"
  DeleteMethod="UZ_qcmInspectorGroupsDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmInspectorGroups"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="GroupID" Name="GroupID" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
