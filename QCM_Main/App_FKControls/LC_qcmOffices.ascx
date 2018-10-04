<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_qcmOffices.ascx.vb" Inherits="LC_qcmOffices" %>
<asp:DropDownList 
  ID = "DDLqcmOffices"
  DataSourceID = "OdsDdlqcmOffices"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorqcmOffices"
  Runat = "server" 
  ControlToValidate = "DDLqcmOffices"
  Text = "Office is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEqcmOffices"
  runat = "server"
  TargetControlID = "DDLqcmOffices"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlqcmOffices"
  TypeName = "SIS.QCM.qcmOffices"
  SortParameterName = "OrderBy"
  SelectMethod = "qcmOfficesSelectList"
  Runat="server" />
