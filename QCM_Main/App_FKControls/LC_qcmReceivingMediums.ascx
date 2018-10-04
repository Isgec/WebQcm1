<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_qcmReceivingMediums.ascx.vb" Inherits="LC_qcmReceivingMediums" %>
<asp:DropDownList 
  ID = "DDLqcmReceivingMediums"
  DataSourceID = "OdsDdlqcmReceivingMediums"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorqcmReceivingMediums"
  Runat = "server" 
  ControlToValidate = "DDLqcmReceivingMediums"
  Text = "Receiving Mediums is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEqcmReceivingMediums"
  runat = "server"
  TargetControlID = "DDLqcmReceivingMediums"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlqcmReceivingMediums"
  TypeName = "SIS.QCM.qcmReceivingMediums"
  SortParameterName = "OrderBy"
  SelectMethod = "qcmReceivingMediumsSelectList"
  Runat="server" />
