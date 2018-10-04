<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_qcmCompanies.ascx.vb" Inherits="LC_qcmCompanies" %>
<asp:DropDownList 
  ID = "DDLqcmCompanies"
  DataSourceID = "OdsDdlqcmCompanies"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorqcmCompanies"
  Runat = "server" 
  ControlToValidate = "DDLqcmCompanies"
  Text = "Companies is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEqcmCompanies"
  runat = "server"
  TargetControlID = "DDLqcmCompanies"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlqcmCompanies"
  TypeName = "SIS.QCM.qcmCompanies"
  SortParameterName = "OrderBy"
  SelectMethod = "qcmCompaniesSelectList"
  Runat="server" />
