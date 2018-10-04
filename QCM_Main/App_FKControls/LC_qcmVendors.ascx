<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_qcmVendors.ascx.vb" Inherits="LC_qcmVendors" %>
<asp:DropDownList 
  ID = "DDLqcmVendors"
  DataSourceID = "OdsDdlqcmVendors"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorqcmVendors"
  Runat = "server" 
  ControlToValidate = "DDLqcmVendors"
  Text = "Vendors is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEqcmVendors"
  runat = "server"
  TargetControlID = "DDLqcmVendors"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlqcmVendors"
  TypeName = "SIS.QCM.qcmVendors"
  SortParameterName = "OrderBy"
  SelectMethod = "qcmVendorsSelectList"
  Runat="server" />
