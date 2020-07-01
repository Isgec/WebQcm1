<%@ Page Language="VB" MasterPageFile="~/Sample.master" AutoEventWireup="False" CodeFile="mGqcmI.aspx.vb" Inherits="mG_qcmI" title="List: Documents" %>
<asp:Content ID="None" ContentPlaceHolderID="cphMain" runat="server">
</asp:Content>
<asp:Content ID="CPHdmisg121" ContentPlaceHolderID="cph1" runat="Server">
  <div class="container-fluid text-center">
    <div class="row">
      <div class="col-sm-12">
        <h3>
          <asp:Label ID="LabelqcmRequestAllotment" runat="server" Text="Inspection List"></asp:Label></h3>
        <asp:UpdatePanel ID="UPNLqcmRequestAllotment" runat="server">
          <ContentTemplate>
            <div class="form-group">
              <div class="input-group mb-3">
                <div class="input-group-prepend">
                  <span class="input-group-text">Search :</span>
                </div>
                <asp:TextBox
                  ID="F_SearchText"
                  CssClass="form-control"
                  onfocus="return this.select();"
                  runat="Server" />
                <asp:Button ID="cmdSearch" runat="server" CssClass="btn btn-dark" Text="Search" />
              </div>
            </div>
            <asp:GridView ID="GVqcmRequestAllotment" Width="100%" runat="server" DataSourceID="ODSqcmRequestAllotment" DataKeyNames="RequestID,Company" AutoGenerateColumns="False">
              <Columns>
                <asp:TemplateField HeaderText="Request">
                  <ItemTemplate>
                    <span><%# Eval("GetRequestDetails") %></span>
                  </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="START">
                  <ItemTemplate>
                    <asp:LinkButton 
                      ID="cmdStart" 
                      CommandName="cmdStart" 
                      CommandArgument='<%# Container.DataItemIndex %>' 
                      runat="server" 
                      Visible='<%# EVal("StartVisible") %>' 
                      AlternateText='<%# EVal("PrimaryKey") %>' 
                      ToolTip="Start Call" 
                      OnClientClick='<%# "return confirm(""Do you want to Start Call ?"");" %>'>
                      <div class="btn btn-sm btn-success">START</div>
                    </asp:LinkButton>
                  </ItemTemplate>
                  <ItemStyle CssClass="alignCenter" />
                  <HeaderStyle CssClass="alignCenter" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="DATA">
                  <ItemTemplate>
                    <asp:LinkButton 
                      ID="cmdData" 
                      CommandName="cmdData" 
                      CommandArgument='<%# Container.DataItemIndex %>' 
                      runat="server" 
                      Visible='<%# EVal("DataVisible") %>' 
                      AlternateText='<%# EVal("PrimaryKey") %>' 
                      ToolTip="Enter Inspection Data" 
                      OnClientClick='<%# "return confirm(""Do you want to enter Inspection Data ?"");" %>'>
                      <div class="btn btn-sm btn-primary"><i class="fa fa-1x  fa-arrow-circle-o-left"></i></div>
                    </asp:LinkButton>
                  </ItemTemplate>
                  <ItemStyle CssClass="alignCenter" />
                  <HeaderStyle CssClass="alignCenter" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="PAUSE/ RESUME">
                  <ItemTemplate>
                    <asp:LinkButton 
                      ID="cmdPause" 
                      CommandName="cmdPause" 
                      CommandArgument='<%# Container.DataItemIndex %>' 
                      runat="server" 
                      Visible='<%# EVal("PauseVisible") %>' 
                      AlternateText='<%# EVal("PrimaryKey") %>' 
                      ToolTip="Pause Call" 
                      OnClientClick='<%# "return confirm(""Do you want to Pause Call ?"");" %>'>
                      <div class="btn btn-sm btn-warning">PAUSE</div>
                    </asp:LinkButton>
                    <asp:LinkButton 
                      ID="cmdResume" 
                      CommandName="cmdResume" 
                      CommandArgument='<%# Container.DataItemIndex %>' 
                      runat="server" 
                      Visible='<%# EVal("ResumeVisible") %>' 
                      AlternateText='<%# EVal("PrimaryKey") %>' 
                      ToolTip="Resume Call" 
                      OnClientClick='<%# "return confirm(""Do you want to Resume Call ?"");" %>'>
                      <div class="btn btn-sm btn-success">RESUME</i></div>
                    </asp:LinkButton>
                  </ItemTemplate>
                  <ItemStyle CssClass="alignCenter" />
                  <HeaderStyle CssClass="alignCenter" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="CLOSE">
                  <ItemTemplate>
                    <asp:LinkButton ID="cmdClose" 
                      CommandName="cmdClose" 
                      CommandArgument='<%# Container.DataItemIndex %>' 
                      runat="server" 
                      Visible='<%# EVal("CloseVisible") %>' 
                      AlternateText='<%# EVal("PrimaryKey") %>' 
                      ToolTip="Close Call" 
                      OnClientClick='<%# "return confirm(""Do you want to Close Call ?"");" %>'>
                      <div class="btn btn-sm btn-danger">
                        <i class="fa fa-1x  fa-arrow-circle-o-left"></i>
                      </div>
                    </asp:LinkButton>
                  </ItemTemplate>
                </asp:TemplateField>
              </Columns>
              <EmptyDataTemplate>
                <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
              </EmptyDataTemplate>
            </asp:GridView>
            <asp:ObjectDataSource
              ID="ODSqcmRequestAllotment"
              DataObjectTypeName="SIS.QCM.qcmRequestAllotment"
              SelectMethod="UZ_qcmRequestAllotedToMobile"
              TypeName="SIS.QCM.qcmRequestAllotment"
              runat="server">
              <SelectParameters>
                <asp:QueryStringParameter QueryStringField="LoginID" Name="AllotedTo" Type="String" DefaultValue="" />
                <asp:ControlParameter ControlID="F_SearchText" PropertyName="Text" Name="SearchText" Type="String" DefaultValue="" Size="250" />
                <asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
              </SelectParameters>
            </asp:ObjectDataSource>
          </ContentTemplate>
          <Triggers>
            <asp:AsyncPostBackTrigger ControlID="cmdSearch" />
          </Triggers>
        </asp:UpdatePanel>
      </div>
    </div>
  </div>
</asp:Content>
