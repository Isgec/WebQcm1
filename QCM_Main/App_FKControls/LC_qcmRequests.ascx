<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_qcmRequests.ascx.vb" Inherits="LC_qcmRequests" %>
<asp:DropDownList 
  ID = "DDLqcmRequests"
  DataSourceID = "OdsDdlqcmRequests"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorqcmRequests"
  Runat = "server" 
  ControlToValidate = "DDLqcmRequests"
  Text = "Inspection Requests is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEqcmRequests"
  runat = "server"
  TargetControlID = "DDLqcmRequests"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlqcmRequests"
  TypeName = "SIS.QCM.qcmRequests"
  SortParameterName = "OrderBy"
  SelectMethod = "qcmRequestsSelectList"
  Runat="server" />
