<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_qcmEmployeeGroups.aspx.vb" Inherits="EF_qcmEmployeeGroups" title="Edit: Employee Groups" %>
<asp:Content ID="CPHqcmEmployeeGroups" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
  <asp:Label ID="LabelqcmEmployeeGroups" runat="server" Text="&nbsp;Edit: Employee Groups" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmEmployeeGroups" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmEmployeeGroups"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    ValidationGroup = "qcmEmployeeGroups"
    runat = "server" />
<asp:FormView ID="FVqcmEmployeeGroups"
	runat = "server"
	DataKeyNames = "GroupID"
	DataSourceID = "ODSqcmEmployeeGroups"
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
						ValidationGroup="qcmEmployeeGroups"
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
						ValidationGroup = "qcmEmployeeGroups"
						SetFocusOnError="true" />
				</td>
			</tr>
		</table>
<fieldset class="ui-widget-content page">
<legend>
    <asp:Label ID="LabelqcmEmployeeGroupUsers" runat="server" Text="&nbsp;List: Employee Group Users" Width="100%" CssClass="sis_formheading"></asp:Label>
</legend>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLqcmEmployeeGroupUsers" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLqcmEmployeeGroupUsers"
      ToolType = "lgNMGrid"
      EditUrl = "~/QCM_Main/App_Edit/EF_qcmEmployeeGroupUsers.aspx"
      AddUrl = "~/QCM_Main/App_Create/AF_qcmEmployeeGroupUsers.aspx"
      AddPostBack = "True"
      ValidationGroup = "qcmEmployeeGroupUsers"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSqcmEmployeeGroupUsers" runat="server" AssociatedUpdatePanelID="UPNLqcmEmployeeGroupUsers" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
    <asp:GridView ID="GVqcmEmployeeGroupUsers" SkinID="gv_silver" BorderColor="#A9A9A9" width="100%" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ODSqcmEmployeeGroupUsers" DataKeyNames="GroupiD,CardNo">
      <Columns>
        <asp:TemplateField>
          <ItemTemplate>
						<Table><tr>
              <td><asp:ImageButton ID="cmdEditPage" runat="server" Visible='<%# EVal("Visible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' /></td>
						</tr></Table>
          </ItemTemplate>
          <HeaderStyle Width="30px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="GroupiD" SortExpression="QCM_EmployeeGroups2_Description">
          <ItemTemplate>
             <asp:Label ID="L_GroupiD" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("GroupiD") %>' Text='<%# Eval("QCM_EmployeeGroups2_Description") %>'></asp:Label>
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
      ID = "ODSqcmEmployeeGroupUsers"
      runat = "server"
      DataObjectTypeName = "SIS.QCM.qcmEmployeeGroupUsers"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "qcmEmployeeGroupUsersSelectList"
      TypeName = "SIS.QCM.qcmEmployeeGroupUsers"
      SelectCountMethod = "qcmEmployeeGroupUsersSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_GroupiD" PropertyName="Text" Name="GroupiD" Type="Int32" Size="10" />
				<asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
				<asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVqcmEmployeeGroupUsers" EventName="PageIndexChanged" />
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
  ID = "ODSqcmEmployeeGroups"
  DataObjectTypeName = "SIS.QCM.qcmEmployeeGroups"
  SelectMethod = "qcmEmployeeGroupsGetByID"
  UpdateMethod="UZ_qcmEmployeeGroupsUpdate"
  DeleteMethod="UZ_qcmEmployeeGroupsDelete"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCM.qcmEmployeeGroups"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="GroupID" Name="GroupID" Type="Int32" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
