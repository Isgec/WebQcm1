<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_qcmDesignations.ascx.vb" Inherits="LC_qcmDesignations" %>
<asp:DropDownList 
  ID = "DDLqcmDesignations"
  DataSourceID = "OdsDdlqcmDesignations"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorqcmDesignations"
  Runat = "server" 
  ControlToValidate = "DDLqcmDesignations"
  Text = "Designations is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<AJX:ListSearchExtender
  ID="DDSEqcmDesignations"
  runat = "server"
  TargetControlID = "DDLqcmDesignations"
  PromptCssClass="ddsearchprompt">
</AJX:ListSearchExtender>
<asp:ObjectDataSource 
  ID = "OdsDdlqcmDesignations"
  TypeName = "SIS.QCM.qcmDesignations"
  SortParameterName = "OrderBy"
  SelectMethod = "qcmDesignationsSelectList"
  Runat="server" />
