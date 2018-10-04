<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_qcmUsers.ascx.vb" Inherits="LC_qcmUsers" %>
<asp:DropDownList 
  ID = "DDLqcmUsers"
  DataSourceID = "OdsDdlqcmUsers"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorqcmUsers"
  Runat = "server" 
  ControlToValidate = "DDLqcmUsers"
  Text = "Web User is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEqcmUsers"
  runat = "server"
  TargetControlID = "DDLqcmUsers"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlqcmUsers"
  TypeName = "SIS.QCM.qcmUsers"
  SortParameterName = "OrderBy"
  SelectMethod = "qcmUsersSelectList"
  Runat="server" />
