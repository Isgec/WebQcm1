<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="LGDefault" title="Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph1" Runat="Server">
<div id="div1" class="ui-widget-content page" runat="server" style="min-height:200px;">
<div id="div2" class="caption">
    <asp:Label ID="LabelspmtIsgecGSTIN" runat="server" Text="&nbsp;SELECT FINANCE COMPANY"></asp:Label>
</div>
<div style="margin-top:20px;margin-bottom:20px;text-align:center;">
  <h2 id="F_SelectedCompany" runat="server"></h2>
</div>
<div id="div3" class="pagedata" style="text-align:center;padding-top:50px;">
  <asp:Label ID="label1" runat="server" Font-Bold="true" Text="Change Finance Company :"></asp:Label>
  <LGM:LC_comFinanceCompany
    ID="F_FinanceCompany"
    OrderBy="DisplayField"
    DataTextField="DisplayField"
    DataValueField="PrimaryKey"
    IncludeDefault="false"
    Width="200px"
    CssClass="myddl"
    ValidationGroup = "temp"
    RequiredFieldErrorMessage = "<div class='errorLG'>Required!</div>"
    AutoPostBack="true"
    Runat="Server" />
</div>
</div>
</asp:Content>
