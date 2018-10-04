<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_qcmRegions.ascx.vb" Inherits="LC_qcmRegions" %>
<asp:DropDownList 
  ID = "DDLqcmRegions"
  DataSourceID = "OdsDdlqcmRegions"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorqcmRegions"
  Runat = "server" 
  ControlToValidate = "DDLqcmRegions"
  Text = "Regions is required."
  ErrorMessage = "[Required!]"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  ForeColor="Red"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlqcmRegions"
  TypeName = "SIS.QCM.qcmRegions"
  SortParameterName = "OrderBy"
  SelectMethod = "qcmRegionsSelectList"
  Runat="server" />
