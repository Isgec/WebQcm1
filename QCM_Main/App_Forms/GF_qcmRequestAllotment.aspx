<%@ Page Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="GF_qcmRequestAllotment.aspx.vb" Inherits="GF_qcmRequestAllotment" title="Maintain List: Requests Allotment" %>
<asp:Content ID="CPHqcmRequestAllotment" ContentPlaceHolderID="cph1" Runat="Server">
<div class="ui-widget-content page">
<div class="caption">
    <asp:Label ID="LabelqcmRequestAllotment" runat="server" Text="&nbsp;List: Requests Allotment" Width="100%" CssClass="sis_formheading"></asp:Label>
</div>
<div class="pagedata">
<asp:UpdatePanel ID="UPNLqcmRequestAllotment" runat="server">
  <ContentTemplate>
    <table width="100%"><tr><td class="sis_formview"> 
    <LGM:ToolBar0 
      ID = "TBLqcmRequestAllotment"
      ToolType = "lgNMGrid"
      EditUrl = "~/QCM_Main/App_Edit/EF_qcmRequestAllotment.aspx"
      EnableAdd = "False"
      ValidationGroup = "qcmRequestAllotment"
      runat = "server" />
    <asp:UpdateProgress ID="UPGSqcmRequestAllotment" runat="server" AssociatedUpdatePanelID="UPNLqcmRequestAllotment" DisplayAfter="100">
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
    <table>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_ProjectID" runat="server" Text="Project ID :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_ProjectID"
						CssClass = "myfktxt"
            Width="42px"
						Text=""
						onfocus = "return this.select();"
						AutoCompleteType = "None"
            onblur= "validate_ProjectID(this);"
						Runat="Server" />
					<asp:Label
						ID = "F_ProjectID_Display"
						Text=""
						Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACEProjectID"
            BehaviorID="B_ACEProjectID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="ProjectIDCompletionList"
            TargetControlID="F_ProjectID"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="ACEProjectID_Selected"
            OnClientPopulating="ACEProjectID_Populating"
            OnClientPopulated="ACEProjectID_Populated"
            CompletionSetCount="10"
						CompletionListCssClass = "autocomplete_completionListElement"
						CompletionListItemCssClass = "autocomplete_listItem"
						CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_SupplierID" runat="server" Text="Supplier ID :" /></b>
				</td>
        <td>
					<asp:TextBox
						ID = "F_SupplierID"
						CssClass = "myfktxt"
            Width="42px"
						Text=""
						onfocus = "return this.select();"
						AutoCompleteType = "None"
            onblur= "validate_SupplierID(this);"
						Runat="Server" />
					<asp:Label
						ID = "F_SupplierID_Display"
						Text=""
						Runat="Server" />
          <AJX:AutoCompleteExtender
            ID="ACESupplierID"
            BehaviorID="B_ACESupplierID"
            ContextKey=""
            UseContextKey="true"
            ServiceMethod="SupplierIDCompletionList"
            TargetControlID="F_SupplierID"
            CompletionInterval="100"
            FirstRowSelected="true"
            MinimumPrefixLength="1"
            OnClientItemSelected="ACESupplierID_Selected"
            OnClientPopulating="ACESupplierID_Populating"
            OnClientPopulated="ACESupplierID_Populated"
            CompletionSetCount="10"
						CompletionListCssClass = "autocomplete_completionListElement"
						CompletionListItemCssClass = "autocomplete_listItem"
						CompletionListHighlightedItemCssClass = "autocomplete_highlightedListItem"
            Runat="Server" />
        </td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_RequestStateID" runat="server" Text="Request State :" /></b>
				</td>
        <td>
          <LGM:LC_qcmRequestStates
            ID="F_RequestStateID"
            SelectedValue=""
            OrderBy="Description"
            DataTextField="Description"
            DataValueField="StateID"
            IncludeDefault="true"
            DefaultText="-- Select --"
            Width="200px"
            AutoPostBack="true"
            RequiredFieldErrorMessage=""
            CssClass="myddl"
            Runat="Server" />
          </td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_AllotedTo" runat="server" Text="Alloted To :" /></b>
				</td>
				<td>
					<asp:TextBox ID="F_AllotedTo" CssClass="myfktxt" Text="" AutoCompleteType="None" Width="56px" onfocus="return this.select();" ToolTip="Enter value for Alloted To." ValidationGroup="qcmRequestAllotment" onblur="return validate_AllotedTo(this);" runat="Server" />
					<asp:Label ID="F_AllotedTo_Display" Text="" runat="Server" />
					<AJX:AutoCompleteExtender ID="ACEAllotedTo" BehaviorID="B_ACEAllotedTo" ContextKey="" UseContextKey="true" ServiceMethod="AllotedToCompletionList" TargetControlID="F_AllotedTo" EnableCaching="false" CompletionInterval="100" FirstRowSelected="true" MinimumPrefixLength="1" OnClientItemSelected="ACEAllotedTo_Selected" OnClientPopulating="ACEAllotedTo_Populating" OnClientPopulated="ACEAllotedTo_Populated" CompletionSetCount="10" CompletionListCssClass="autocomplete_completionListElement" CompletionListItemCssClass="autocomplete_listItem" CompletionListHighlightedItemCssClass="autocomplete_highlightedListItem" runat="Server" />
				</td>
			</tr>
			<tr>
				<td class="alignright">
					<b><asp:Label ID="L_RegionID" runat="server" Text="Inspection Region :" /></b>
				</td>
				<td>
					<LGM:LC_qcmRegions 
						ID = "F_RegionID"
						CssClass = "myddl"
						Width="200px"
						SelectedValue=""
						DataTextField="RegionName"
						DataValueField="RegionID"
						IncludeDefault="true"
						DefaultText="-- Select --"
            AutoPostBack="true"
						RequiredFieldErrorMessage = ""
						Runat="Server" />
				</td>
			</tr>
    </table>
		</asp:Panel>
		<AJX:CollapsiblePanelExtender ID="cpe1" runat="Server" TargetControlID="pnlD" ExpandControlID="pnlH" CollapseControlID="pnlH" Collapsed="True" TextLabelID="lblH" ImageControlID="imgH" ExpandedText="(Hide Filters...)" CollapsedText="(Show Filters...)" ExpandedImage="~/images/ua.png" CollapsedImage="~/images/da.png" SuppressPostBack="true" />
    
    <asp:GridView ID="GVqcmRequestAllotment" SkinID="gv_silver" BorderColor="#A9A9A9" width="100%" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="ODSqcmRequestAllotment" DataKeyNames="RequestID">
      <Columns>
        <asp:TemplateField HeaderText="EDIT">
          <ItemTemplate>
            <asp:ImageButton ID="cmdEditPage" runat="server" Enabled='<%# Eval("Enable") %>' AlternateText="Edit" ToolTip="Edit the record." SkinID="Edit" CommandName="lgEdit" CommandArgument='<%# Container.DataItemIndex %>' />
          </ItemTemplate>
          <ItemStyle CssClass="alignCenter" />
          <HeaderStyle Width="30px" CssClass="alignCenter" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Request ID" SortExpression="RequestID">
          <ItemTemplate>
            <asp:Label ID="LabelRequestID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("RequestID") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle CssClass="alignleft" Width="40px" />
          <ItemStyle CssClass="alignleft" />
          <HeaderStyle  />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Project ID" SortExpression="IDM_Projects6_Description">
          <ItemTemplate>
             <asp:Label ID="L_ProjectID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("ProjectID") %>' Text='<%# Eval("IDM_Projects6_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="150px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Supplier ID" SortExpression="IDM_Vendors7_Description">
          <ItemTemplate>
             <asp:Label ID="L_SupplierID" runat="server" ForeColor='<%# EVal("ForeColor") %>' Title='<%# EVal("SupplierID") %>' Text='<%# Eval("IDM_Vendors7_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Item Description & Stage" SortExpression="Description">
          <ItemTemplate>
            <asp:Label ID="LabelDescription" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("Description") %>'></asp:Label>
          </ItemTemplate>
        <HeaderStyle Width="200px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Total Requested Quantity" SortExpression="TotalRequestedQuantity">
          <ItemTemplate>
            <asp:Label ID="LabelTotalRequestedQuantity" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Eval("NewTotalQuantity") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="50px" />
          <ItemStyle CssClass="alignCenter" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Requested Date" SortExpression="RequestedInspectionStartDate">
          <ItemTemplate>
            <asp:Label ID="LabelRequestedInspectionStartDate" runat="server" ForeColor='<%# EVal("ForeColor") %>' Text='<%# Bind("RequestedInspectionStartDate") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="80px" />
          <ItemStyle CssClass="alignCenter" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Created By" SortExpression="HRM_Employees1_EmployeeName">
          <ItemTemplate>
             <asp:Label ID="L_CreatedBy" runat="server" ForeColor='<%# Eval("ForeColor") %>' Title='<%# EVal("CreatedBy") %>' Text='<%# Eval("HRM_Employees1_EmployeeName") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Request State" SortExpression="QCM_RequestStates10_Description">
          <ItemTemplate>
             <asp:Label ID="L_RequestStateID" runat="server" ForeColor='<%# Eval("ForeColor") %>' Title='<%# EVal("RequestStateID") %>' Text='<%# Eval("QCM_RequestStates10_Description") %>'></asp:Label>
          </ItemTemplate>
          <HeaderStyle Width="100px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Return Reason" >
          <ItemTemplate>
          <asp:TextBox ID="F_ReturnRemarks"
            Text='<%# Bind("ReturnRemarks") %>'
            CssClass = "mytxt"
            onfocus = "return this.select();"
            onblur= "this.value=this.value.replace(/\'/g,'');"
            Visible='<%# Eval("AllotVisible") %>'
            ToolTip="Enter Return Reason."
            MaxLength="250"
            Width="100px" 
            ValidationGroup='<%# "Reject" & Container.DataItemIndex %>'
            runat="server" /><br />
          <asp:RequiredFieldValidator 
            ID = "RFVReturnRemarks"
            runat = "server"
            ControlToValidate = "F_ReturnRemarks"
            ErrorMessage = "[Required!]"
            Display = "Dynamic"
            EnableClientScript = "true"
            ValidationGroup='<%# "Reject" & Container.DataItemIndex %>'
            ForeColor="Red"
            SetFocusOnError="true" />
          </ItemTemplate>
        <HeaderStyle Width="40px" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="RET">
          <ItemTemplate>
             <asp:ImageButton ID="cmdReturn" runat="server" Visible='<%# Eval("AllotVisible") %>'  ValidationGroup='<%# "Reject" & Container.DataItemIndex %>' CausesValidation="true" AlternateText="Return" ToolTip="Return the record." SkinID="reject" CommandName="lgReturn" CommandArgument='<%# Container.DataItemIndex %>' OnClientClick='<%# "return Page_ClientValidate(""Reject" & Container.DataItemIndex & """) && confirm(""Return record ?"");" %>' />
          </ItemTemplate>
          <HeaderStyle Width="30px" CssClass="alignCenter" />
          <ItemStyle CssClass="alignCenter" />
        </asp:TemplateField>
        <asp:TemplateField HeaderText="E-Mail">
          <ItemTemplate>
              <asp:ImageButton ID="cmdSendSMS" runat="server" Visible='<%# Eval("SendSMSVisible") %>' Enabled='<%# EVal("Enable") %>' AlternateText="SMS" ToolTip="Send E-Mail to Inspector." SkinID="forward" CommandName="lgSendSMS" CommandArgument='<%# Container.DataItemIndex %>' />
						</td>
						</tr>
						<tr style="background-color:AntiqueWhite; color:DeepPink">
							<td></td>
							<td colspan="3">
                <b>Attended Virtually:&nbsp;</b><%# Eval("AttendedVirtually") %>
							</td>
							<td><li><b>
								<asp:Label ID="labelRegion" runat="server" Text='<%# Eval("QCM_Regions12_RegionName") %>' />
							</b></li>
							</td>
							<td>
								<li><b><u>Allotment:</u></b></li>
							</td>
							<td>
									<asp:Label ID="Label2" runat="server" Title='<%# EVal("AllotedStartDate") %>' Text='<%# Eval("AllotedStartDate") %>'></asp:Label>
							</td>
							<td>
									<asp:Label ID="Label3" runat="server"  Title='<%# EVal("AllotedFinishDate") %>' Text='<%# Eval("AllotedFinishDate") %>'></asp:Label>
							</td>
							<td>
								<asp:Label ID="Label1" runat="server" Title='<%# EVal("AllotedTo") %>' Text='<%# Eval("HRM_Employees2_EmployeeName") %>'></asp:Label>
							</td>
							<td>
									<asp:Label ID="Label5" runat="server"  Title='<%# EVal("QCM_InspectionStatus11_Description") %>' Text='<%# Eval("QCM_InspectionStatus11_Description") %>'></asp:Label>
							</td>
							<td></td>
							<td></td>
						</tr>
          </ItemTemplate>
          <HeaderStyle Width="30px" CssClass="alignCenter" />
          <ItemStyle CssClass="alignCenter" />
        </asp:TemplateField>
      </Columns>
      <EmptyDataTemplate>
        <asp:Label ID="LabelEmpty" runat="server" Font-Size="Small" ForeColor="Red" Text="No record found !!!"></asp:Label>
      </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource 
      ID = "ODSqcmRequestAllotment"
      runat = "server"
      DataObjectTypeName = "SIS.QCM.qcmRequestAllotment"
      OldValuesParameterFormatString = "original_{0}"
      SelectMethod = "UZ_qcmRequestAllotmentSelectList"
      TypeName = "SIS.QCM.qcmRequestAllotment"
      SelectCountMethod = "qcmRequestAllotmentSelectCount"
      SortParameterName="OrderBy" EnablePaging="True">
      <SelectParameters >
        <asp:ControlParameter ControlID="F_ProjectID" PropertyName="Text" Name="ProjectID" Type="String" Size="6" />
        <asp:ControlParameter ControlID="F_AllotedTo" PropertyName="Text" Name="AllotedTo" Type="String" Size="8" />
        <asp:ControlParameter ControlID="F_SupplierID" PropertyName="Text" Name="SupplierID" Type="String" Size="6" />
        <asp:ControlParameter ControlID="F_RequestStateID" PropertyName="SelectedValue" Name="RequestStateID" Type="String" Size="10" />
        <asp:ControlParameter ControlID="F_RegionID" PropertyName="SelectedValue" Name="RegionID" Type="String" Size="10" />
				<asp:Parameter Name="SearchState" Type="Boolean" Direction="Input" DefaultValue="false" />
				<asp:Parameter Name="SearchText" Type="String" Direction="Input" DefaultValue="" />
      </SelectParameters>
    </asp:ObjectDataSource>
    
  </td></tr></table>
  <script type="text/javascript">
  	var qcmSms = {
  		s1Win: '',
  		s2Win: '',
  		sms1: '',
  		sms2: '',
  		rqid: '',
  		SendSMS: function(req) {
  			if (confirm('Send SMS to Alloted Quality Inspector ?')) {
  				this.rqid = req;
  				showProcessingMPV();
  				//PageMethods.SendEMail(req, this.MailSent, this.MailSentError);
  				PageMethods.GetSMSData(req, this.smsSent, this.smsSentError);
  			}
  			return false;
  		},
  		smsSentError: function(err) {
  			alert(err._message);
  			hideProcessingMPV();
  		},
  		Send2ndSMS: function() {
  			qcmSms.s2Win = window.open(qcmSms.sms2, 'wSms2', 'left=20,top=20,width=100,height=100,toolbar=1,resizable=0,scrollbars=0');
  			hideProcessingMPV();
  			setTimeout('qcmSms.closeWin()', 2000);
  		},
  		smsSent: function(s) {
  			var aval = s.split('|');
  			qcmSms.sms1 = aval[0] + aval[1] + '&message=' + aval[3];
  			qcmSms.sms2 = aval[0] + aval[2] + '&message=' + aval[3];

  			qcmSms.s1Win = window.open(qcmSms.sms1, 'wSms1', 'left=20,top=20,width=100,height=100,toolbar=1,resizable=0,scrollbars=0');
  			setTimeout('qcmSms.Send2ndSMS()', 2000);
  		},
  		closeWin: function() {
  			qcmSms.s1Win.close();
  			qcmSms.s2Win.close();
  			if (confirm('Re-send E-Mail to inspector ?')) {
  				showProcessingMPV();
  				PageMethods.SendEMail(qcmSms.rqid, this.MailSent, this.MailSentError);
  			}
  		},
  		MailSent: function(s) {
  			if (s != '')
  				alert(s);
  			hideProcessingMPV();
  		},
  		MailSentError: function(err) {
  			alert(err._message);
  			hideProcessingMPV();
  		}
  	}
  </script>
  </ContentTemplate>
  <Triggers>
    <asp:AsyncPostBackTrigger ControlID="GVqcmRequestAllotment" EventName="PageIndexChanged" />
    <asp:AsyncPostBackTrigger ControlID="F_ProjectID" />
    <asp:AsyncPostBackTrigger ControlID="F_SupplierID" />
    <asp:AsyncPostBackTrigger ControlID="F_RequestStateID" />
  </Triggers>
</asp:UpdatePanel>
</div>
</div>
</asp:Content>
