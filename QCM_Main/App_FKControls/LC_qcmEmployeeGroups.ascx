<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_qcmEmployeeGroups.ascx.vb" Inherits="LC_qcmEmployeeGroups" %>
<asp:DropDownList 
  ID = "DDLqcmEmployeeGroups"
  DataSourceID = "OdsDdlqcmEmployeeGroups"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorqcmEmployeeGroups"
  Runat = "server" 
  ControlToValidate = "DDLqcmEmployeeGroups"
  Text = "Employee Groups is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEqcmEmployeeGroups"
  runat = "server"
  TargetControlID = "DDLqcmEmployeeGroups"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlqcmEmployeeGroups"
  TypeName = "SIS.QCM.qcmEmployeeGroups"
  SortParameterName = "OrderBy"
  SelectMethod = "qcmEmployeeGroupsSelectList"
  Runat="server" />
