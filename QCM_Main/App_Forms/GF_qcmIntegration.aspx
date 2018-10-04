<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="GF_qcmIntegration.aspx.vb" Inherits="GF_qcmIntegration" title="Upload/Download FTP server" %>
<asp:Content ID="CPHqcmVendors" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelqcmVendors" runat="server" Text="&nbsp;Upload Allotment / Download Inspection" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLqcmVendors" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLqcmVendors"
      ToolType = "lgNMGrid"
      EditUrl = ""
      AddUrl = ""
      EnableAdd="false"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSqcmVendors" runat="server" AssociatedUpdatePanelID="UPNLqcmVendors" DisplayAfter="100">
      <ProgressTemplate>
        <span style="color: #ff0033">Loading...</span>
      </ProgressTemplate>
    </asp:UpdateProgress>
		<asp:Panel ID="pnlH" runat="server" CssClass="cph_filter">
			<div style="padding: 5px; cursor: pointer; vertical-align: middle;">
				<div style="float: left;">Filter Records </div>
				<div style="float: left; margin-left: 20px;">
					<asp:Label ID="lblH" runat="server">(Show Filters...)</asp:Label>
				</div>
				<div style="float: right; vertical-align: middle;">
					<asp:ImageButton ID="imgH" runat="server" ImageUrl="~/images/ua.png" AlternateText="(Show Filters...)" />
				</div>
			</div>
		</asp:Panel>
		<asp:Panel ID="pnlD" runat="server" CssClass="cp_filter" Height="0">
		</asp:Panel>
		<AJX:CollapsiblePanelExtender ID="cpe1" runat="Server" TargetControlID="pnlD" ExpandControlID="pnlH" CollapseControlID="pnlH" Collapsed="True" TextLabelID="lblH" ImageControlID="imgH" ExpandedText="(Hide Filters...)" CollapsedText="(Show Filters...)" ExpandedImage="~/images/ua.png" CollapsedImage="~/images/da.png" SuppressPostBack="true" />
    
		<table width="100%">
			<tr>
				<td colspan="3">Upload Request Allotment Data on FTP</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_UploadForDate" runat="server" Text="Upload For Date :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_UploadForDate"
						Text='<%# Bind("UploadForDate") %>'
            Width="70px"
						CssClass = "mytxt"
						onfocus = "return this.select();"
						runat="server" />
					<asp:Image ID="ImageButtonUploadForDate" runat="server" ToolTip="Click to open calendar" style="cursor: pointer" ImageUrl="~/Images/cal.png" />
          <AJX:CalendarExtender 
            ID = "CEUploadForDate"
            TargetControlID="F_UploadForDate"
            BehaviorID="startDate"
            Format="dd/MM/yyyy"
            runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonUploadForDate" />
					<AJX:MaskedEditExtender 
						ID = "MEEUploadForDate"
						runat = "server"
						mask = "99/99/9999"
						MaskType="Date"
            CultureName = "en-GB"
						MessageValidatorTip="true"
						InputDirection="LeftToRight"
						ErrorTooltipEnabled="true"
						TargetControlID="F_UploadForDate" />
				</td>
				<td>
					<asp:Button ID="cmdUpload" runat="server" Text="Upload" />
				</td>
			</tr>
			<tr>
				<td colspan="3">Download and update Inspection Report from FTP</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_DownloadForDate" runat="server" Text="Download For Date :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_DownloadForDate"
						Text='<%# Bind("DownloadForDate") %>'
            Width="70px"
						CssClass = "mytxt"
						onfocus = "return this.select();"
						runat="server" />
					<asp:Image ID="ImageButtonDownloadForDate" runat="server" ToolTip="Click to open calendar" style="cursor: pointer" ImageUrl="~/Images/cal.png" />
          <AJX:CalendarExtender 
            ID = "CEDownloadForDate"
            BehaviorID="finishDate"
            TargetControlID="F_DownloadForDate"
            Format="dd/MM/yyyy"
            runat = "server" CssClass="MyCalendar" PopupButtonID="ImageButtonDownloadForDate" />
					<AJX:MaskedEditExtender 
						ID = "MEEDownloadForDate"
						runat = "server"
						mask = "99/99/9999"
						MaskType="Date"
            CultureName = "en-GB"
						MessageValidatorTip="true"
						InputDirection="LeftToRight"
						ErrorTooltipEnabled="true"
						TargetControlID="F_DownloadForDate" />
				</td>
				<td>
					<asp:Button ID="cmdDownload" runat="server" Text="Download" />
				</td>
			</tr>
		</table>
    
  </td></tr></table>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="cmdUpload" />
    <asp:AsyncPostBackTrigger ControlID="cmdDownload" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
