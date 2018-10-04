<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_qcmRequestStates.aspx.vb" Inherits="EF_qcmRequestStates" title="Edit: Request States" %>
<asp:Content ID="CPHqcmRequestStates" ContentPlaceHolderID="cph1" runat="Server">
  <div id="div1" class="ui-widget-content page">
    <div id="div2" class="caption">
      <asp:Label ID="LabelqcmRequestStates" runat="server" Text="&nbsp;Edit: Request States" Width="100%" CssClass="sis_formheading"></asp:Label>
    </div>
    <div id="div3" class="pagedata">
      <asp:UpdatePanel ID="UPNLqcmRequestStates" runat="server">
        <ContentTemplate>
          <LGM:ToolBar0
            ID="TBLqcmRequestStates"
            ToolType="lgNMEdit"
            UpdateAndStay="False"
            ValidationGroup="qcmRequestStates"
            runat="server" />
          <asp:FormView ID="FVqcmRequestStates"
            runat="server"
            DataKeyNames="StateID"
            DataSourceID="ODSqcmRequestStates"
            DefaultMode="Edit" CssClass="sis_formview">
            <EditItemTemplate>
              <div id="frmdiv" class="ui-widget-content minipage">
                <table>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="L_StateID" runat="server" ForeColor="#CC6633" Text="Request State ID :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="F_StateID"
                        Text='<%# Bind("StateID") %>'
                        ToolTip="Value of Request State ID."
                        Enabled="False"
                        CssClass="mypktxt"
                        Width="70px"
                        runat="server" />
                    </td>
                  </tr>
                  <tr>
                    <td class="alignright">
                      <b>
                        <asp:Label ID="L_Description" runat="server" Text="Description :" /></b>
                    </td>
                    <td>
                      <asp:TextBox ID="F_Description"
                        Text='<%# Bind("Description") %>'
                        Width="350px"
                        CssClass="mytxt"
                        onfocus="return this.select();"
                        ValidationGroup="qcmRequestStates"
                        onblur="this.value=this.value.replace(/\'/g,'');"
                        ToolTip="Enter value for Description."
                        MaxLength="50"
                        runat="server" />
                      <asp:RequiredFieldValidator
                        ID="RFVDescription"
                        runat="server"
                        ControlToValidate="F_Description"
                        Text="Description is required."
                        ErrorMessage="[Required!]"
                        Display="Dynamic"
                        EnableClientScript="true"
                        ValidationGroup="qcmRequestStates"
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
        ID="ODSqcmRequestStates"
        DataObjectTypeName="SIS.QCM.qcmRequestStates"
        SelectMethod="qcmRequestStatesGetByID"
        UpdateMethod="qcmRequestStatesUpdate"
        DeleteMethod="qcmRequestStatesDelete"
        OldValuesParameterFormatString="original_{0}"
        TypeName="SIS.QCM.qcmRequestStates"
        runat="server">
        <SelectParameters>
          <asp:QueryStringParameter DefaultValue="0" QueryStringField="StateID" Name="StateID" Type="String" />
        </SelectParameters>
      </asp:ObjectDataSource>
    </div>
  </div>
</asp:Content>
