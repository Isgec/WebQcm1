<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_qcmInspectorGroups.ascx.vb" Inherits="LC_qcmInspectorGroups" %>
<asp:DropDownList 
  ID = "DDLqcmInspectorGroups"
  DataSourceID = "OdsDdlqcmInspectorGroups"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorqcmInspectorGroups"
  Runat = "server" 
  ControlToValidate = "DDLqcmInspectorGroups"
  Text = "Inspector Groups is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEqcmInspectorGroups"
  runat = "server"
  TargetControlID = "DDLqcmInspectorGroups"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlqcmInspectorGroups"
  TypeName = "SIS.QCM.qcmInspectorGroups"
  SortParameterName = "OrderBy"
  SelectMethod = "qcmInspectorGroupsSelectList"
  Runat="server" />
