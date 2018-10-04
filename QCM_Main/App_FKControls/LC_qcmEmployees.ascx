<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_qcmEmployees.ascx.vb" Inherits="LC_qcmEmployees" %>
<asp:DropDownList 
  ID = "DDLqcmEmployees"
  DataSourceID = "OdsDdlqcmEmployees"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorqcmEmployees"
  Runat = "server" 
  ControlToValidate = "DDLqcmEmployees"
  Text = "Employees is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEqcmEmployees"
  runat = "server"
  TargetControlID = "DDLqcmEmployees"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlqcmEmployees"
  TypeName = "SIS.QCM.qcmEmployees"
  SortParameterName = "OrderBy"
  SelectMethod = "qcmEmployeesSelectList"
  Runat="server" />
