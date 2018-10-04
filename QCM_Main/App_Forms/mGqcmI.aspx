<%@ Page Language="VB" MasterPageFile="~/Sample.master" AutoEventWireup="False" CodeFile="mGqcmI.aspx.vb" Inherits="mG_qcmI" title="List: Documents" %>
<asp:Content ID="None" ContentPlaceHolderID="cphMain" runat="server">
<style>
.switch {
  position: relative;
  display: inline-block;
  width: 50px;
  height: 24px;
}

.switch input {display:none;}

.slider {
  position: absolute;
  cursor: pointer;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  background-color: #ccc;
  -webkit-transition: .4s;
  transition: .4s;
}

.slider:before {
  position: absolute;
  content: "";
  height: 16px;
  width: 16px;
  left: 4px;
  bottom: 4px;
  background-color: white;
  -webkit-transition: .4s;
  transition: .4s;
}

input:checked + .slider {
  background-color: #2196F3;
}

input:focus + .slider {
  box-shadow: 0 0 1px #2196F3;
}

input:checked + .slider:before {
  -webkit-transform: translateX(26px);
  -ms-transform: translateX(26px);
  transform: translateX(26px);
}

/* Rounded sliders */
.slider.round {
  border-radius: 24px;
}

.slider.round:before {
  border-radius: 50%;
}
</style>
<style>
    a.transparent-input{
       background-color:rgba(0,0,0,0) !important;
       border:none !important;
    }
    span.transparent-input{
       background-color:rgba(0,0,0,0) !important;
       border:none !important;
    }
</style>
</asp:Content>
<asp:Content ID="CPHdmisg121" ContentPlaceHolderID="cph1" runat="Server">
  <div class="container">
    <div class="container text-center">
      <h3>
        <asp:Label ID="LabelqcmRequestAllotment" runat="server" Text="Inspection List"></asp:Label></h3>
    </div>
    <asp:UpdatePanel ID="UPNLqcmRequestAllotment" runat="server">
      <ContentTemplate>
        <LGM:ToolBar0 
          ID = "TBLqcmRequestAllotment"
          ToolType = "lgNMGrid"
          SVisible="false"
          runat = "server" />
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
        <br />
        <asp:GridView ID="GVqcmRequestAllotment" SkinID="gv_bs1" runat="server" AllowPaging="True" PagerSettings-Position="Bottom" DataSourceID="ODSqcmRequestAllotment" DataKeyNames="RequestID" AutoGenerateColumns="False">
          <Columns>
            <asp:TemplateField HeaderText="Document" SortExpression="t_docn">
              <ItemTemplate>
                <span><%# Eval("GetRequestDetails") %></span>
              </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="START">
              <ItemTemplate>
                <asp:LinkButton ID="cmdStart" commandName="cmdStart" commandArgument='<%# Container.DataItemIndex %>' runat="server" Visible='<%# EVal("StartVisible") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Start Call" OnClientClick='<%# "return confirm(""Do you want to Start Call ?"");" %>'><div class="btn btn-sm btn-success">START</div></asp:LinkButton>
              </ItemTemplate>
              <ItemStyle CssClass="alignCenter" />
              <HeaderStyle CssClass="alignCenter"/>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="INSPECTION DATA">
              <ItemTemplate>
                <asp:LinkButton ID="cmdData" commandName="cmdData" commandArgument='<%# Container.DataItemIndex %>' runat="server" Visible='<%# EVal("DataVisible") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Enter Inspection Data" OnClientClick='<%# "return confirm(""Do you want to enter Inspection Data ?"");" %>'><div class="btn btn-sm btn-primary"><i class="fa fa-1x  fa-arrow-circle-o-left"></i></div></asp:LinkButton>
              </ItemTemplate>
              <ItemStyle CssClass="alignCenter" />
              <HeaderStyle CssClass="alignCenter"/>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PAUSE/ RESUME">
              <ItemTemplate>
                <asp:LinkButton ID="cmdPause" commandName="cmdPause" commandArgument='<%# Container.DataItemIndex %>' runat="server" Visible='<%# EVal("PauseVisible") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Pause Call" OnClientClick='<%# "return confirm(""Do you want to Pause Call ?"");" %>'><div class="btn btn-sm btn-warning">PAUSE</div></asp:LinkButton>
                <asp:LinkButton ID="cmdResume" commandName="cmdResume" commandArgument='<%# Container.DataItemIndex %>' runat="server" Visible='<%# EVal("ResumeVisible") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Pause Call" OnClientClick='<%# "return confirm(""Do you want to Resume Call ?"");" %>'><div class="btn btn-sm btn-success">RESUME</i></div></asp:LinkButton>
              </ItemTemplate>
              <ItemStyle CssClass="alignCenter" />
              <HeaderStyle CssClass="alignCenter"/>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="CLOSE">
              <ItemTemplate>
                <asp:LinkButton ID="cmdClose" commandName="cmdClose" commandArgument='<%# Container.DataItemIndex %>' runat="server" Visible='<%# EVal("CloseVisible") %>' AlternateText='<%# EVal("PrimaryKey") %>' ToolTip="Start Call" OnClientClick='<%# "return confirm(""Do you want to Close Call ?"");" %>'><div class="btn btn-sm btn-danger"><i class="fa fa-1x  fa-arrow-circle-o-left"></i></div></asp:LinkButton>
              </ItemTemplate>
              <ItemStyle CssClass="alignCenter" />
              <HeaderStyle CssClass="alignCenter"/>
            </asp:TemplateField>
          </Columns>
          <EmptyDataTemplate>
            <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
          </EmptyDataTemplate>
        </asp:GridView>
        <asp:ObjectDataSource
          ID="ODSqcmRequestAllotment"
          runat="server"
          DataObjectTypeName="SIS.QCM.qcmRequestAllotment"
          OldValuesParameterFormatString="original_{0}"
          SelectMethod="UZ_qcmRequestAllotedTo"
          SelectCountMethod = "UZ_qcmRequestAllotedToCount"
          TypeName="SIS.QCM.qcmRequestAllotment"
          SortParameterName="OrderBy"
          EnablePaging="True">
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
</asp:Content>
