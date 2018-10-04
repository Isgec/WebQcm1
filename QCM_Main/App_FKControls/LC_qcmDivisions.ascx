<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_qcmDivisions.ascx.vb" Inherits="LC_qcmDivisions" %>
<asp:DropDownList 
  ID = "DDLqcmDivisions"
  DataSourceID = "OdsDdlqcmDivisions"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorqcmDivisions"
  Runat = "server" 
  ControlToValidate = "DDLqcmDivisions"
  Text = "Divisions is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEqcmDivisions"
  runat = "server"
  TargetControlID = "DDLqcmDivisions"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlqcmDivisions"
  TypeName = "SIS.QCM.qcmDivisions"
  SortParameterName = "OrderBy"
  SelectMethod = "qcmDivisionsSelectList"
  Runat="server" />
