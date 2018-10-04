<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_qcmInspectionStatus.ascx.vb" Inherits="LC_qcmInspectionStatus" %>
<asp:DropDownList 
  ID = "DDLqcmInspectionStatus"
  DataSourceID = "OdsDdlqcmInspectionStatus"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorqcmInspectionStatus"
  Runat = "server" 
  ControlToValidate = "DDLqcmInspectionStatus"
  Text = "Required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  ForeColor="Red"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlqcmInspectionStatus"
  TypeName = "SIS.QCM.qcmInspectionStatus"
  SortParameterName = "OrderBy"
  SelectMethod = "qcmInspectionStatusSelectList"
  Runat="server" />
