<%@ Control Language="VB" AutoEventWireup="false" CodeFile="LC_comFinanceCompany.ascx.vb" Inherits="LC_comFinanceCompany" %>
<asp:DropDownList 
  ID = "DDLcomFinanceCompany"
  DataSourceID = "OdsDdlcomFinanceCompany"
  AppendDataBoundItems = "true"
  SkinID = "DropDownSkin"
  Width="200px"
  CssClass = "myddl"
  Runat="server" />
<asp:RequiredFieldValidator 
  ID = "RequiredFieldValidatorcomFinanceCompany"
  Runat = "server" 
  ControlToValidate = "DDLcomFinanceCompany"
  ErrorMessage = "<div class='errorLG'>Required!</div>"
  Display = "Dynamic"
  EnableClientScript = "true"
  ValidationGroup = "none"
  SetFocusOnError = "true" />
<asp:ObjectDataSource 
  ID = "OdsDdlcomFinanceCompany"
  TypeName = "SIS.COM.comFinanceCompany"
  SortParameterName = "OrderBy"
  SelectMethod = "comFinanceCompanySelectList"
  Runat="server" />
