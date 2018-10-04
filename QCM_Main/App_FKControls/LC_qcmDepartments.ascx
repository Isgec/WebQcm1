<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_qcmDepartments.ascx.vb" Inherits="LC_qcmDepartments" %>
<asp:DropDownList 
  ID = "DDLqcmDepartments"
  DataSourceID = "OdsDdlqcmDepartments"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorqcmDepartments"
  Runat = "server" 
  ControlToValidate = "DDLqcmDepartments"
  Text = "Departments is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEqcmDepartments"
  runat = "server"
  TargetControlID = "DDLqcmDepartments"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlqcmDepartments"
  TypeName = "SIS.QCM.qcmDepartments"
  SortParameterName = "OrderBy"
  SelectMethod = "qcmDepartmentsSelectList"
  Runat="server" />
