<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="AF_qcmctRequest.aspx.vb" Inherits="AF_qcmctRequest" title="Add: CT Request" %>
<asp:Content ID="CPHqcmctRequest" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page">
<div id="div2" class="caption">
    <asp:Label ID="LabelqcmctRequest" runat="server" Text="&nbsp;Add: CT Request"></asp:Label>
</div>
<div id="div3" class="pagedata">
<asp:UpdatePanel ID="UPNLqcmctRequest" runat="server" >
  <ContentTemplate>
  <LGM:ToolBar0 
    ID = "TBLqcmctRequest"
    ToolType = "lgNMAdd"
    InsertAndStay = "False"
    ValidationGroup = "qcmctRequest"
    runat = "server" />
<asp:FormView ID="FVqcmctRequest"
  runat = "server"
  DataKeyNames = "QCRequestNo,SerialNo,PONumber,ItemReference,ActivityID"
  DataSourceID = "ODSqcmctRequest"
  DefaultMode = "Insert" CssClass="sis_formview">
  <InsertItemTemplate>
    <div id="frmdiv" class="ui-widget-content minipage">
    <asp:Label ID="L_ErrMsgqcmctRequest" runat="server" ForeColor="Red" Font-Bold="true" Text=""></asp:Label>
    <table style="margin:auto;border: solid 1pt lightgrey">
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_QCRequestNo" ForeColor="#CC6633" runat="server" Text="QC Request No :" /><span style="color:red">*</span></b>
        </td>
        <td>
          <asp:TextBox ID="F_QCRequestNo"
            Text='<%# Bind("QCRequestNo") %>'
            Width="88px"
            style="text-align: Right"
            CssClass = "mypktxt"
            ValidationGroup="qcmctRequest"
            MaxLength="10"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEQCRequestNo"
            runat = "server"
            mask = "9999999999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_QCRequestNo" />
          <AJX:MaskedEditValidator 
            ID = "MEVQCRequestNo"
            runat = "server"
            ControlToValidate = "F_QCRequestNo"
            ControlExtender = "MEEQCRequestNo"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "qcmctRequest"
            IsValidEmpty = "false"
            MinimumValue = "1"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <b><asp:Label ID="L_SerialNo" ForeColor="#CC6633" runat="server" Text="Serial No :" /><span style="color:red">*</span></b>
        </td>
        <td>
          <asp:TextBox ID="F_SerialNo"
            Text='<%# Bind("SerialNo") %>'
            Width="88px"
            style="text-align: Right"
            CssClass = "mypktxt"
            ValidationGroup="qcmctRequest"
            MaxLength="10"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEESerialNo"
            runat = "server"
            mask = "9999999999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_SerialNo" />
          <AJX:MaskedEditValidator 
            ID = "MEVSerialNo"
            runat = "server"
            ControlToValidate = "F_SerialNo"
            ControlExtender = "MEESerialNo"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "qcmctRequest"
            IsValidEmpty = "false"
            MinimumValue = "1"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_PONumber" ForeColor="#CC6633" runat="server" Text="PO Number :" /><span style="color:red">*</span></b>
        </td>
        <td>
          <asp:TextBox ID="F_PONumber"
            Text='<%# Bind("PONumber") %>'
            CssClass = "mypktxt"
            onfocus = "return this.select();"
            ValidationGroup="qcmctRequest"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for PO Number."
            MaxLength="9"
            Width="80px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVPONumber"
            runat = "server"
            ControlToValidate = "F_PONumber"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "qcmctRequest"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <b><asp:Label ID="L_ItemReference" ForeColor="#CC6633" runat="server" Text="Item Reference :" /><span style="color:red">*</span></b>
        </td>
        <td>
          <asp:TextBox ID="F_ItemReference"
            Text='<%# Bind("ItemReference") %>'
            CssClass = "mypktxt"
            onfocus = "return this.select();"
            ValidationGroup="qcmctRequest"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Item Reference."
            MaxLength="200"
            Width="350px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVItemReference"
            runat = "server"
            ControlToValidate = "F_ItemReference"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "qcmctRequest"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <b><asp:Label ID="L_ActivityID" ForeColor="#CC6633" runat="server" Text="Activity ID :" /><span style="color:red">*</span></b>
        </td>
        <td>
          <asp:TextBox ID="F_ActivityID"
            Text='<%# Bind("ActivityID") %>'
            CssClass = "mypktxt"
            onfocus = "return this.select();"
            ValidationGroup="qcmctRequest"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Activity ID."
            MaxLength="9"
            Width="80px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVActivityID"
            runat = "server"
            ControlToValidate = "F_ActivityID"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "qcmctRequest"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_ItemUnit" runat="server" Text="Item Unit :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_ItemUnit"
            Text='<%# Bind("ItemUnit") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="qcmctRequest"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Item Unit."
            MaxLength="20"
            Width="168px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVItemUnit"
            runat = "server"
            ControlToValidate = "F_ItemUnit"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "qcmctRequest"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Activity2Desc" runat="server" Text="Sub Item :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_Activity2Desc"
            Text='<%# Bind("Activity2Desc") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="qcmctRequest"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Sub Item."
            MaxLength="150"
            Width="350px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVActivity2Desc"
            runat = "server"
            ControlToValidate = "F_Activity2Desc"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "qcmctRequest"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_Quantity" runat="server" Text="Quantity :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_Quantity"
            Text='<%# Bind("Quantity") %>'
            Width="184px"
            CssClass = "mytxt"
            style="text-align: Right"
            ValidationGroup="qcmctRequest"
            MaxLength="22"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEQuantity"
            runat = "server"
            mask = "999999999999999999.9999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_Quantity" />
          <AJX:MaskedEditValidator 
            ID = "MEVQuantity"
            runat = "server"
            ControlToValidate = "F_Quantity"
            ControlExtender = "MEEQuantity"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "qcmctRequest"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_PercentOfQuantity" runat="server" Text="Percent Of PO Quantity :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_PercentOfQuantity"
            Text='<%# Bind("PercentOfQuantity") %>'
            Width="184px"
            CssClass = "mytxt"
            style="text-align: Right"
            ValidationGroup="qcmctRequest"
            MaxLength="22"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEPercentOfQuantity"
            runat = "server"
            mask = "999999999999999999.9999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_PercentOfQuantity" />
          <AJX:MaskedEditValidator 
            ID = "MEVPercentOfQuantity"
            runat = "server"
            ControlToValidate = "F_PercentOfQuantity"
            ControlExtender = "MEEPercentOfQuantity"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "qcmctRequest"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_PartialOrFull" runat="server" Text="Partial Or Full :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:DropDownList
            ID="F_PartialOrFull"
            SelectedValue='<%# Bind("PartialOrFull") %>'
            Width="200px"
            ValidationGroup = "qcmctRequest"
            CssClass = "myddl"
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
      <tr>
        <td class="alignright">
          <asp:Label ID="L_NotSelectedList" runat="server" Text="Items NOT Selected :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_NotSelectedList"
            Text='<%# Bind("NotSelectedList") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="qcmctRequest"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Items NOT Selected."
            MaxLength="500"
            Width="350px"
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
        <td class="alignright">
          <asp:Label ID="L_SelectedList" runat="server" Text="Items Selected :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_SelectedList"
            Text='<%# Bind("SelectedList") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="qcmctRequest"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Items Selected."
            MaxLength="500"
            Width="350px"
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
      <tr>
        <td class="alignright">
          <asp:Label ID="L_ProgressPercent" runat="server" Text="Progress Percent :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_ProgressPercent"
            Text='<%# Bind("ProgressPercent") %>'
            Width="128px"
            CssClass = "mytxt"
            style="text-align: Right"
            ValidationGroup="qcmctRequest"
            MaxLength="15"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEProgressPercent"
            runat = "server"
            mask = "999999999999999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_ProgressPercent" />
          <AJX:MaskedEditValidator 
            ID = "MEVProgressPercent"
            runat = "server"
            ControlToValidate = "F_ProgressPercent"
            ControlExtender = "MEEProgressPercent"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "qcmctRequest"
            IsValidEmpty = "false"
            MinimumValue = "0.01"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_Activity3Desc" runat="server" Text="Activity Desc [3] :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_Activity3Desc"
            Text='<%# Bind("Activity3Desc") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="qcmctRequest"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Activity Desc [3]."
            MaxLength="150"
            Width="350px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVActivity3Desc"
            runat = "server"
            ControlToValidate = "F_Activity3Desc"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "qcmctRequest"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Product" runat="server" Text="Product :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_Product"
            Text='<%# Bind("Product") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="qcmctRequest"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Product."
            MaxLength="9"
            Width="80px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVProduct"
            runat = "server"
            ControlToValidate = "F_Product"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "qcmctRequest"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_Project" runat="server" Text="Project :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_Project"
            Text='<%# Bind("Project") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="qcmctRequest"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Project."
            MaxLength="9"
            Width="80px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVProject"
            runat = "server"
            ControlToValidate = "F_Project"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "qcmctRequest"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Activity4Desc" runat="server" Text="Activity Desc [4] :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_Activity4Desc"
            Text='<%# Bind("Activity4Desc") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="qcmctRequest"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Activity Desc [4]."
            MaxLength="150"
            Width="350px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVActivity4Desc"
            runat = "server"
            ControlToValidate = "F_Activity4Desc"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "qcmctRequest"
            SetFocusOnError="true" />
        </td>
        <td class="alignright">
          <asp:Label ID="L_GridLineStatus" runat="server" Text="GridLineStatus :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_GridLineStatus"
            Text='<%# Bind("GridLineStatus") %>'
            Width="88px"
            style="text-align: Right"
            CssClass = "mytxt"
            ValidationGroup="qcmctRequest"
            MaxLength="10"
            onfocus = "return this.select();"
            runat="server" />
          <AJX:MaskedEditExtender 
            ID = "MEEGridLineStatus"
            runat = "server"
            mask = "9999999999"
            AcceptNegative = "Left"
            MaskType="Number"
            MessageValidatorTip="true"
            InputDirection="RightToLeft"
            ErrorTooltipEnabled="true"
            TargetControlID="F_GridLineStatus" />
          <AJX:MaskedEditValidator 
            ID = "MEVGridLineStatus"
            runat = "server"
            ControlToValidate = "F_GridLineStatus"
            ControlExtender = "MEEGridLineStatus"
            EmptyValueBlurredText = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "qcmctRequest"
            IsValidEmpty = "false"
            MinimumValue = "1"
            SetFocusOnError="true" />
        </td>
      </tr>
      <tr>
        <td class="alignright">
          <asp:Label ID="L_Handle" runat="server" Text="Handle :" /><span style="color:red">*</span>
        </td>
        <td>
          <asp:TextBox ID="F_Handle"
            Text='<%# Bind("Handle") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            ValidationGroup="qcmctRequest"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            ToolTip="Enter value for Handle."
            MaxLength="50"
            Width="408px"
            runat="server" />
          <asp:RequiredFieldValidator 
            ID = "RFVHandle"
            runat = "server"
            ControlToValidate = "F_Handle"
            ErrorMessage = "<div class='errorLG'>Required!</div>"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup = "qcmctRequest"
            SetFocusOnError="true" />
        </td>
      <td></td><td></td></tr>
      <tr><td colspan="4" style="border-top: solid 1pt LightGrey" ></td></tr>
    </table>
    </div>
  </InsertItemTemplate>
</asp:FormView>
  </ContentTemplate>
</asp:UpdatePanel>
<asp:ObjectDataSource 
  ID = "ODSqcmctRequest"
  DataObjectTypeName = "SIS.QCMCT.qcmctRequest"
  InsertMethod="UZ_qcmctRequestInsert"
  OldValuesParameterFormatString = "original_{0}"
  TypeName = "SIS.QCMCT.qcmctRequest"
  SelectMethod = "GetNewRecord"
  runat = "server" >
</asp:ObjectDataSource>
</div>
</div>
</asp:Content>
