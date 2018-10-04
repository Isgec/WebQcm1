<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_qcmProjects.ascx.vb" Inherits="LC_qcmProjects" %>
<asp:DropDownList 
  ID = "DDLqcmProjects"
  DataSourceID = "OdsDdlqcmProjects"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorqcmProjects"
  Runat = "server" 
  ControlToValidate = "DDLqcmProjects"
  Text = "Projects is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEqcmProjects"
  runat = "server"
  TargetControlID = "DDLqcmProjects"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlqcmProjects"
  TypeName = "SIS.QCM.qcmProjects"
  SortParameterName = "OrderBy"
  SelectMethod = "qcmProjectsSelectList"
  Runat="server" />
