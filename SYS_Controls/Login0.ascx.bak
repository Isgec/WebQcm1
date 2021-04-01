<%@ Control Language="VB" AutoEventWireup="false" CodeFile="Login0.ascx.vb" Inherits="Login0" %>
<div class="sis_login">
  <asp:LoginView ID="LoginFormView1" runat="server">
    <AnonymousTemplate>
      <asp:Login ID="Login0" OnLoggedIn="LoggedIn" OnLoginError="LoginError" OnLoggingIn="LoggingIn" runat="server">
        <LayoutTemplate>
          <asp:Panel ID="panel1" runat="server" DefaultButton="LoginButton">
            <table>
              <tr>
                <td>
                  <asp:Label runat="server" Text="Login ID:"></asp:Label>
                </td>
                <td style="height: 22px">
                  <asp:TextBox ID="UserName" runat="server" CssClass="mytxt" Font-Size="8pt" MaxLength="20" Width="60px"></asp:TextBox>
                </td>
                <td>
                  <asp:Label ID="Label1" runat="server" Text="Password:"></asp:Label>
                </td>
                <td style="height: 22px">
                  <asp:TextBox ID="Password" runat="server" CssClass="mytxt" Font-Size="8pt" MaxLength="20" TextMode="Password" Width="60px"></asp:TextBox>
                </td>
                <td style="height: 22px">
                  <asp:Button ID="LoginButton" CssClass="signin" runat="server" CommandName="Login" ValidationGroup="ctl00$ctl00$Login0" Text="Sign In" />
                </td>
              </tr>
              <tr>
                <td align="center" colspan="5" style="color: #66FF66; font-weight: bold; background-color: Black">
                  <asp:Label ID="FailureText" runat="server" EnableViewState="False"></asp:Label>
                </td>
              </tr>
            </table>
          </asp:Panel>
        </LayoutTemplate>
      </asp:Login>
    </AnonymousTemplate>
    <LoggedInTemplate>
      <table>
        <tr>
        <td>
          <LGM:Informations ID="Informations1" Visible="false" runat="server" />
          <asp:Label ID="sysInfo" runat="server" Text=""></asp:Label>
        </td>
        <td style="vertical-align:top;text-align:right;">
            <asp:LinkButton ID="LinkButton1"  runat="server" Height="26px"  PostBackUrl="~/ChangePassword.aspx" Text="Change Password" /><br />
            <asp:LoginStatus ID="LoginStatus1" CssClass="signout" runat="server"  Width="86px" LoginText="Sign In" LogoutAction="Redirect" LogoutPageUrl="~/Default.aspx" LogoutText="  Sign Out  " ToolTip="Sign Out" />
        </td>
          </tr>
      </table>
    </LoggedInTemplate>
  </asp:LoginView>
</div>
