<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_qcmRequestStates.ascx.vb" Inherits="LC_qcmRequestStates" %>
<asp:DropDownList 
  ID = "DDLqcmRequestStates"
  DataSourceID = "OdsDdlqcmRequestStates"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorqcmRequestStates"
  Runat = "server" 
  ControlToValidate = "DDLqcmRequestStates"
  Text = "Request States is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEqcmRequestStates"
  runat = "server"
  TargetControlID = "DDLqcmRequestStates"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlqcmRequestStates"
  TypeName = "SIS.QCM.qcmRequestStates"
  SortParameterName = "OrderBy"
  SelectMethod = "qcmRequestStatesSelectList"
  Runat="server" />
