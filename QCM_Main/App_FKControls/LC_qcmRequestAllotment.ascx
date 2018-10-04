<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_qcmRequestAllotment.ascx.vb" Inherits="LC_qcmRequestAllotment" %>
<asp:DropDownList 
  ID = "DDLqcmRequestAllotment"
  DataSourceID = "OdsDdlqcmRequestAllotment"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorqcmRequestAllotment"
  Runat = "server" 
  ControlToValidate = "DDLqcmRequestAllotment"
  Text = "Requests Allotment is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEqcmRequestAllotment"
  runat = "server"
  TargetControlID = "DDLqcmRequestAllotment"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlqcmRequestAllotment"
  TypeName = "SIS.QCM.qcmRequestAllotment"
  SortParameterName = "OrderBy"
  SelectMethod = "qcmRequestAllotmentSelectList"
  Runat="server" />
