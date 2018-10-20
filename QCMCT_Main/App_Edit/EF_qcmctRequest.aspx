<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="EF_qcmctRequest.aspx.vb" Inherits="EF_qcmctRequest" title="Edit: CT Request" %>
<asp:Content ID="CPHqcmctRequest" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelqcmctRequest" runat="server" Text="&nbsp;Edit: CT Request"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmctRequest" runat="server" >
<ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmctRequest"
    ToolType = "lgNMEdit"
    UpdateAndStay = "False"
    EnableDelete = "False"
    ValidationGroup = "qcmctRequest"
    runat = "server" />
<asp:FormView ID="FVqcmctRequest"
  runat = "server"
  DataKeyNames = "QCRequestNo,SerialNo,PONumber,ItemReference,ActivityID"
  DataSourceID = "ODSqcmctRequest"
  DefaultMode = "Edit" CssClass="sis_formview">
  <EditItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_QCRequestNo" runat="server" ForeColor="#CC6633" Text="QC Request No :" />&nbsp;</b>
        </td>
        <td>
          <asp:Label ID="F_QCRequestNo"
            Text='<%# Bind("QCRequestNo") %>'
            CssClass = "dmypktxt"
            style="text-align: right"
            runat="server" />
        </td>
        <td class="alignright">
          <b><asp:Label ID="L_SerialNo" runat="server" ForeColor="#CC6633" Text="Serial No :" />&nbsp;</b>
        </td>
        <td>
          <asp:Label ID="F_SerialNo"
            Text='<%# Bind("SerialNo") %>'
            CssClass = "dmypktxt"
            style="text-align: right"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_PONumber" runat="server" ForeColor="#CC6633" Text="PO Number :" />&nbsp;</b>
        </td>
        <td colspan="3">
          <asp:Label ID="F_PONumber"
            Text='<%# Bind("PONumber") %>'
            CssClass = "dmypktxt"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_ItemReference" runat="server" ForeColor="#CC6633" Text="Item Reference :" />&nbsp;</b>
        </td>
        <td colspan="3">
          <asp:Label ID="F_ItemReference"
            Text='<%# Bind("ItemReference") %>'
            CssClass = "dmypktxt"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_ActivityID" runat="server" ForeColor="#CC6633" Text="Sub Item :" />&nbsp;</b>
        </td>
        <td>
          <asp:Label ID="F_ActivityID"
            Text='<%# Bind("ActivityID") %>'
            CssClass = "dmypktxt"
            runat="server" />
        </td>
        <td class="alignright">
          <b><asp:Label ID="L_Activity2Desc" runat="server" ForeColor="#CC6633" Text="Sub Item Desc :" />&nbsp;</b>
        </td>
        <td>
          <asp:Label ID="F_SubItemDesc"
            Text='<%# Eval("SubItemDesc") %>'
            CssClass = "dmypktxt"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="Label1" runat="server" ForeColor="#CC6633" Text="Iref./Sub Item Weight [Kg] :" />&nbsp;</b>
        </td>
        <td>
          <asp:Label ID="Label2"
            Text='<%# Eval("IRefWeight") %>'
            CssClass = "dmypktxt"
            runat="server" />
        </td>
        <td class="alignright">
          <b><asp:Label ID="Label3" runat="server" ForeColor="#CC6633" Text="Cleared Weight [Kg] :" />&nbsp;</b>
        </td>
        <td>
          <asp:Label ID="Label4"
            Text='<%# Eval("ClearedWt") %>'
            CssClass = "dmypktxt"
            runat="server" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Quantity" runat="server" Text="Quantity :" />
        </td>
        <td>
          <asp:TextBox ID="F_Quantity"
            Text='<%# Bind("Quantity") %>'
            style="text-align: right"
            Width="184px"
            CssClass = "mytxt"
            ValidationGroup= "qcmctRequest"
            MaxLength="22"
            onfocus = "return this.select();"
            onblur ="return dc(this,4);"
            runat="server" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_PartialOrFull" runat="server" Text="Partial Or Full :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:DropDownList
            ID="F_PartialOrFull"
            SelectedValue='<%# Bind("PartialOrFull") %>'
            CssClass = "myddl"
            Width="200px"
            ValidationGroup = "qcmctRequest"
            Runat="Server" >
            <asp:ListItem Value="PARTIAL">PARTIAL</asp:ListItem>
            <asp:ListItem Value="FULL">FULL</asp:ListItem>
          </asp:DropDownList>
          <asp:RequiredFieldValidator 
            ID = "RFVPartialOrFull"
            runat = "server"
            ControlToValidate = "F_PartialOrFull"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "qcmctRequest"
            SetFocusOnError="true" />
         </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr id="RowProgressPercent" runat="server" clientIDMode="Static" visible='<%# Eval("RowProgressPercent") %>' >
        <td class="alignright">
          <asp:Label ID="L_ProgressPercent" runat="server" Text="% Progress :" />
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_ProgressPercent"
            Text='<%# Bind("ProgressPercent") %>'
            style="text-align: right"
            Width="184px"
            CssClass = "mytxt"
            ValidationGroup= "qcmctRequest"
            MaxLength="8"
            onfocus = "return this.select();"
            onblur ="return dc(this,4);"
            runat="server" />
          </td>
        </tr>
        <tr id="RowProgressWeight" runat="server" clientIDMode="Static" visible='<%# Eval("RowProgressWeight") %>' >
          <td class="alignright">
            <asp:Label ID="Label5" runat="server" Text="Progress Weight [Kg] :" />
          </td>
          <td colspan="3">
            <asp:TextBox ID="F_ProgressWeight"
              Text='<%# Bind("ProgressWeight") %>'
              style="text-align: right"
              Width="184px"
              CssClass = "mytxt"
              ValidationGroup= "qcmctRequest"
              MaxLength="18"
              onfocus = "return this.select();"
              onblur ="return dc(this,4);"
              runat="server" />
            </td>
        </tr>
        <tr>
        <td class="alignright">
          <asp:Label ID="L_InspectionStageiD" runat="server" Text="Inspection Stage :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <LGM:LC_qcmInspectionStages
            ID="F_InspectionStageiD"
            SelectedValue='<%# Bind("InspectionStageiD") %>'
            OrderBy="DisplayField"
            DataTextField="DisplayField"
            DataValueField="PrimaryKey"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            CssClass="myddl"
            ValidationGroup = "qcmctRequest"
            RequiredFieldErrorMessage = "<div class='errorLG'>Required!</div>"
            Runat="Server" />
          </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_NotSelectedList" runat="server" Text="Items NOT Offered :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_NotSelectedList"
            Text='<%# Bind("NotSelectedList") %>'
            Width="350px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="qcmctRequest"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Items NOT Selected."
            MaxLength="500"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVNotSelectedList"
            runat = "server"
            ControlToValidate = "F_NotSelectedList"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "qcmctRequest"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_SelectedList" runat="server" Text="Items Offered :" /><span style="color:red">*</span>
        </td>
        <td colspan="3">
          <asp:TextBox ID="F_SelectedList"
            Text='<%# Bind("SelectedList") %>'
            Width="350px"
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="qcmctRequest"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Items Selected."
            MaxLength="500"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVSelectedList"
            runat = "server"
            ControlToValidate = "F_SelectedList"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "qcmctRequest"
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
  ID = "ODSqcmctRequest"
  DataObjectTypeName = "SIS.QCMCT.qcmctRequest"
  SelectMethod = "qcmctRequestGetByID"
  UpdateMethod="UZ_qcmctRequestUpdate"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCMCT.qcmctRequest"
  runat = "server" >
<SelectParameters>
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="QCRequestNo" Name="QCRequestNo" Type="Int32" />
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="SerialNo" Name="SerialNo" Type="Int32" />
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="PONumber" Name="PONumber" Type="String" />
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="ItemReference" Name="ItemReference" Type="String" />
  <asp:QueryStringParameter DefaultValue="0" QueryStringField="ActivityID" Name="ActivityID" Type="String" />
</SelectParameters>
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
