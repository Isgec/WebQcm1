Imports System.Web.Script.Serialization
Partial Class AF_qcmRequests
  Inherits SIS.SYS.InsertBase
  Protected Sub FVqcmRequests_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmRequests.Init
    DataClassName = "AqcmRequests"
    SetFormView = FVqcmRequests
  End Sub
  Protected Sub TBLqcmRequests_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmRequests.Init
    SetToolBar = TBLqcmRequests
  End Sub
  Protected Sub ODSqcmRequests_Inserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSqcmRequests.Inserted
    If e.Exception Is Nothing Then
      Dim oDC As SIS.QCM.qcmRequests = CType(e.ReturnValue, SIS.QCM.qcmRequests)
      Dim tmpURL As String = "?tmp=1"
      tmpURL &= "&RequestID=" & oDC.RequestID
      TBLqcmRequests.AfterInsertURL &= tmpURL
    End If
  End Sub
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function ProjectIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.QCM.qcmProjects.SelectqcmProjectsAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function SupplierIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.QCM.qcmVendors.SelectqcmVendorsAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function ReceivedByCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.QCM.qcmEmployees.SelectqcmEmployeesAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub FVqcmRequests_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmRequests.PreRender
    Dim stgQty As TextBox = FVqcmRequests.FindControl("F_TotalRequestedQuantity")
    Dim fnlQty As TextBox = FVqcmRequests.FindControl("F_LotSize")
    stgQty.Text = "0.00"
    fnlQty.Text = "0.00"
    Dim omevSdt As AjaxControlToolkit.MaskedEditValidator = FVqcmRequests.FindControl("MEVRequestedInspectionStartDate")
    If Now.Hour >= 11 Then
      With omevSdt
        .MinimumValue = Now.AddDays(1).ToString("dd/MM/yyyy")
        .MinimumValueMessage = "After 11:00 AM, Requested start date can not be less than tomorrow's Date"
        .MinimumValueBlurredText = "Invalid Start Date."
      End With
    Else
      With omevSdt
        .MinimumValue = Now.ToString("dd/MM/yyyy")
        .MinimumValueMessage = "Requested start date can not be less than today's"
        .MinimumValueBlurredText = "Invalid Start Date."
      End With
    End If
    Dim mStr As String = "<script type=""text/javascript""> "
    mStr = mStr & vbCrLf & " var script_qcmRequests = {"
    Dim oF_ProjectID_Display As Label = FVqcmRequests.FindControl("F_ProjectID_Display")
    oF_ProjectID_Display.Text = String.Empty
    If Not Session("F_ProjectID_Display") Is Nothing Then
      If Session("F_ProjectID_Display") <> String.Empty Then
        oF_ProjectID_Display.Text = Session("F_ProjectID_Display")
      End If
    End If
    Dim oF_ProjectID As TextBox = FVqcmRequests.FindControl("F_ProjectID")
    oF_ProjectID.Enabled = True
    oF_ProjectID.Text = String.Empty
    If Not Session("F_ProjectID") Is Nothing Then
      If Session("F_ProjectID") <> String.Empty Then
        oF_ProjectID.Text = Session("F_ProjectID")
      End If
    End If
    mStr = mStr & vbCrLf & "ACEProjectID_Selected: function(o, e) {"
    mStr = mStr & vbCrLf & "  var F_ProjectID = $get('" & oF_ProjectID.ClientID & "');"
    mStr = mStr & vbCrLf & "  var F_ProjectID_Display = $get('" & oF_ProjectID_Display.ClientID & "');"
    mStr = mStr & vbCrLf & "  var retval = e.get_value();"
    mStr = mStr & vbCrLf & "  var p = retval.split('|');"
    mStr = mStr & vbCrLf & "  F_ProjectID.value = p[0];"
    mStr = mStr & vbCrLf & "  F_ProjectID_Display.innerHTML = e.get_text();"
    mStr = mStr & vbCrLf & "},"
    mStr = mStr & vbCrLf & "ACEProjectID_Populating: function(o,e) {"
    mStr = mStr & vbCrLf & "  var p = o.get_element();"
    mStr = mStr & vbCrLf & "  p.style.backgroundImage = 'url(../../images/loader.gif)';"
    mStr = mStr & vbCrLf & "  p.style.backgroundRepeat = 'no-repeat';"
    mStr = mStr & vbCrLf & "  p.style.backgroundPosition = 'right';"
    mStr = mStr & vbCrLf & "  o._contextKey = '';"
    mStr = mStr & vbCrLf & "},"
    mStr = mStr & vbCrLf & "ACEProjectID_Populated: function(o,e) {"
    mStr = mStr & vbCrLf & "  var p = o.get_element();"
    mStr = mStr & vbCrLf & "  p.style.backgroundImage  = 'none';"
    mStr = mStr & vbCrLf & "},"
    Dim oF_SupplierID_Display As Label = FVqcmRequests.FindControl("F_SupplierID_Display")
    oF_SupplierID_Display.Text = String.Empty
    If Not Session("F_SupplierID_Display") Is Nothing Then
      If Session("F_SupplierID_Display") <> String.Empty Then
        oF_SupplierID_Display.Text = Session("F_SupplierID_Display")
      End If
    End If
    Dim oF_SupplierID As TextBox = FVqcmRequests.FindControl("F_SupplierID")
    oF_SupplierID.Enabled = True
    oF_SupplierID.Text = String.Empty
    If Not Session("F_SupplierID") Is Nothing Then
      If Session("F_SupplierID") <> String.Empty Then
        oF_SupplierID.Text = Session("F_SupplierID")
      End If
    End If
    mStr = mStr & vbCrLf & "ACESupplierID_Selected: function(o, e) {"
    mStr = mStr & vbCrLf & "  var F_SupplierID = $get('" & oF_SupplierID.ClientID & "');"
    mStr = mStr & vbCrLf & "  var F_SupplierID_Display = $get('" & oF_SupplierID_Display.ClientID & "');"
    mStr = mStr & vbCrLf & "  var retval = e.get_value();"
    mStr = mStr & vbCrLf & "  var p = retval.split('|');"
    mStr = mStr & vbCrLf & "  F_SupplierID.value = p[0];"
    mStr = mStr & vbCrLf & "  F_SupplierID_Display.innerHTML = e.get_text();"
    mStr = mStr & vbCrLf & "},"
    mStr = mStr & vbCrLf & "ACESupplierID_Populating: function(o,e) {"
    mStr = mStr & vbCrLf & "  var p = o.get_element();"
    mStr = mStr & vbCrLf & "  p.style.backgroundImage = 'url(../../images/loader.gif)';"
    mStr = mStr & vbCrLf & "  p.style.backgroundRepeat = 'no-repeat';"
    mStr = mStr & vbCrLf & "  p.style.backgroundPosition = 'right';"
    mStr = mStr & vbCrLf & "  o._contextKey = '';"
    mStr = mStr & vbCrLf & "},"
    mStr = mStr & vbCrLf & "ACESupplierID_Populated: function(o,e) {"
    mStr = mStr & vbCrLf & "  var p = o.get_element();"
    mStr = mStr & vbCrLf & "  p.style.backgroundImage  = 'none';"
    mStr = mStr & vbCrLf & "},"
    Dim oF_ReceivedBy_Display As Label = FVqcmRequests.FindControl("F_ReceivedBy_Display")
    Dim oF_ReceivedBy As TextBox = FVqcmRequests.FindControl("F_ReceivedBy")
    mStr = mStr & vbCrLf & "ACEReceivedBy_Selected: function(o, e) {"
    mStr = mStr & vbCrLf & "  var F_ReceivedBy = $get('" & oF_ReceivedBy.ClientID & "');"
    mStr = mStr & vbCrLf & "  var F_ReceivedBy_Display = $get('" & oF_ReceivedBy_Display.ClientID & "');"
    mStr = mStr & vbCrLf & "  var retval = e.get_value();"
    mStr = mStr & vbCrLf & "  var p = retval.split('|');"
    mStr = mStr & vbCrLf & "  F_ReceivedBy.value = p[0];"
    mStr = mStr & vbCrLf & "  F_ReceivedBy_Display.innerHTML = e.get_text();"
    mStr = mStr & vbCrLf & "},"
    mStr = mStr & vbCrLf & "ACEReceivedBy_Populating: function(o,e) {"
    mStr = mStr & vbCrLf & "  var p = o.get_element();"
    mStr = mStr & vbCrLf & "  p.style.backgroundImage = 'url(../../images/loader.gif)';"
    mStr = mStr & vbCrLf & "  p.style.backgroundRepeat = 'no-repeat';"
    mStr = mStr & vbCrLf & "  p.style.backgroundPosition = 'right';"
    mStr = mStr & vbCrLf & "  o._contextKey = '';"
    mStr = mStr & vbCrLf & "},"
    mStr = mStr & vbCrLf & "ACEReceivedBy_Populated: function(o,e) {"
    mStr = mStr & vbCrLf & "  var p = o.get_element();"
    mStr = mStr & vbCrLf & "  p.style.backgroundImage  = 'none';"
    mStr = mStr & vbCrLf & "},"
    mStr = mStr & vbCrLf & "validate_ProjectID: function(o) {"
    mStr = mStr & vbCrLf & "    this.validated_FK_QCM_Requests_ProjectID_main = true;"
    mStr = mStr & vbCrLf & "    this.validate_FK_QCM_Requests_ProjectID(o);"
    mStr = mStr & vbCrLf & "  },"
    mStr = mStr & vbCrLf & "validate_SupplierID: function(o) {"
    mStr = mStr & vbCrLf & "    this.validated_FK_QCM_Requests_SupplierID_main = true;"
    mStr = mStr & vbCrLf & "    this.validate_FK_QCM_Requests_SupplierID(o);"
    mStr = mStr & vbCrLf & "  },"
    mStr = mStr & vbCrLf & "validate_ReceivedBy: function(o) {"
    mStr = mStr & vbCrLf & "    this.validated_FK_QCM_Requests_ReceivedBy_main = true;"
    mStr = mStr & vbCrLf & "    this.validate_FK_QCM_Requests_ReceivedBy(o);"
    mStr = mStr & vbCrLf & "  },"
    Dim FK_QCM_Requests_ReceivedByReceivedBy As TextBox = FVqcmRequests.FindControl("F_ReceivedBy")
    mStr = mStr & vbCrLf & "validate_FK_QCM_Requests_ReceivedBy: function(o) {"
    mStr = mStr & vbCrLf & "  var value = o.id;"
    mStr = mStr & vbCrLf & "  var ReceivedBy = $get('" & FK_QCM_Requests_ReceivedByReceivedBy.ClientID & "');"
    mStr = mStr & vbCrLf & "  if(ReceivedBy.value==''){"
    mStr = mStr & vbCrLf & "    if(this.validated_FK_QCM_Requests_ReceivedBy_main){"
    mStr = mStr & vbCrLf & "      var o_d = $get(o.id +'_Display');"
    mStr = mStr & vbCrLf & "      try{o_d.innerHTML = '';}catch(ex){}"
    mStr = mStr & vbCrLf & "    }"
    mStr = mStr & vbCrLf & "    return true;"
    mStr = mStr & vbCrLf & "  }"
    mStr = mStr & vbCrLf & "  value = value + ',' + ReceivedBy.value ;"
    mStr = mStr & vbCrLf & "  o.style.backgroundImage  = 'url(../../images/pkloader.gif)';"
    mStr = mStr & vbCrLf & "  o.style.backgroundRepeat= 'no-repeat';"
    mStr = mStr & vbCrLf & "  o.style.backgroundPosition = 'right';"
    mStr = mStr & vbCrLf & "  PageMethods.validate_FK_QCM_Requests_ReceivedBy(value, this.validated_FK_QCM_Requests_ReceivedBy);"
    mStr = mStr & vbCrLf & "},"
    mStr = mStr & vbCrLf & "validated_FK_QCM_Requests_ReceivedBy_main: false,"
    mStr = mStr & vbCrLf & "validated_FK_QCM_Requests_ReceivedBy: function(result) {"
    mStr = mStr & vbCrLf & "  var p = result.split('|');"
    mStr = mStr & vbCrLf & "  var o = $get(p[1]);"
    mStr = mStr & vbCrLf & "  if(script_qcmRequests.validated_FK_QCM_Requests_ReceivedBy_main){"
    mStr = mStr & vbCrLf & "    var o_d = $get(p[1]+'_Display');"
    mStr = mStr & vbCrLf & "    try{o_d.innerHTML = p[2];}catch(ex){}"
    mStr = mStr & vbCrLf & "  }"
    mStr = mStr & vbCrLf & "  o.style.backgroundImage  = 'none';"
    mStr = mStr & vbCrLf & "  if(p[0]=='1'){"
    mStr = mStr & vbCrLf & "    o.value='';"
    mStr = mStr & vbCrLf & "    o.focus();"
    mStr = mStr & vbCrLf & "  }"
    mStr = mStr & vbCrLf & "},"
    Dim FK_QCM_Requests_ProjectIDProjectID As TextBox = FVqcmRequests.FindControl("F_ProjectID")
    mStr = mStr & vbCrLf & "validate_FK_QCM_Requests_ProjectID: function(o) {"
    mStr = mStr & vbCrLf & "  var value = o.id;"
    mStr = mStr & vbCrLf & "  var ProjectID = $get('" & FK_QCM_Requests_ProjectIDProjectID.ClientID & "');"
    mStr = mStr & vbCrLf & "  if(ProjectID.value==''){"
    mStr = mStr & vbCrLf & "    if(this.validated_FK_QCM_Requests_ProjectID_main){"
    mStr = mStr & vbCrLf & "      var o_d = $get(o.id +'_Display');"
    mStr = mStr & vbCrLf & "      try{o_d.innerHTML = '';}catch(ex){}"
    mStr = mStr & vbCrLf & "    }"
    mStr = mStr & vbCrLf & "    return true;"
    mStr = mStr & vbCrLf & "  }"
    mStr = mStr & vbCrLf & "  value = value + ',' + ProjectID.value ;"
    mStr = mStr & vbCrLf & "  o.style.backgroundImage  = 'url(../../images/pkloader.gif)';"
    mStr = mStr & vbCrLf & "  o.style.backgroundRepeat= 'no-repeat';"
    mStr = mStr & vbCrLf & "  o.style.backgroundPosition = 'right';"
    mStr = mStr & vbCrLf & "  PageMethods.validate_FK_QCM_Requests_ProjectID(value, this.validated_FK_QCM_Requests_ProjectID);"
    mStr = mStr & vbCrLf & "},"
    mStr = mStr & vbCrLf & "validated_FK_QCM_Requests_ProjectID_main: false,"
    mStr = mStr & vbCrLf & "validated_FK_QCM_Requests_ProjectID: function(result) {"
    mStr = mStr & vbCrLf & "  var p = result.split('|');"
    mStr = mStr & vbCrLf & "  var o = $get(p[1]);"
    mStr = mStr & vbCrLf & "  if(script_qcmRequests.validated_FK_QCM_Requests_ProjectID_main){"
    mStr = mStr & vbCrLf & "    var o_d = $get(p[1]+'_Display');"
    mStr = mStr & vbCrLf & "    try{o_d.innerHTML = p[2];}catch(ex){}"
    mStr = mStr & vbCrLf & "  }"
    mStr = mStr & vbCrLf & "  o.style.backgroundImage  = 'none';"
    mStr = mStr & vbCrLf & "  if(p[0]=='1'){"
    mStr = mStr & vbCrLf & "    o.value='';"
    mStr = mStr & vbCrLf & "    o.focus();"
    mStr = mStr & vbCrLf & "  }"
    mStr = mStr & vbCrLf & "},"
    Dim FK_QCM_Requests_SupplierIDSupplierID As TextBox = FVqcmRequests.FindControl("F_SupplierID")
    mStr = mStr & vbCrLf & "validate_FK_QCM_Requests_SupplierID: function(o) {"
    mStr = mStr & vbCrLf & "  var value = o.id;"
    mStr = mStr & vbCrLf & "  var SupplierID = $get('" & FK_QCM_Requests_SupplierIDSupplierID.ClientID & "');"
    mStr = mStr & vbCrLf & "  if(SupplierID.value==''){"
    mStr = mStr & vbCrLf & "    if(this.validated_FK_QCM_Requests_SupplierID_main){"
    mStr = mStr & vbCrLf & "      var o_d = $get(o.id +'_Display');"
    mStr = mStr & vbCrLf & "      try{o_d.innerHTML = '';}catch(ex){}"
    mStr = mStr & vbCrLf & "    }"
    mStr = mStr & vbCrLf & "    return true;"
    mStr = mStr & vbCrLf & "  }"
    mStr = mStr & vbCrLf & "  value = value + ',' + SupplierID.value ;"
    mStr = mStr & vbCrLf & "  o.style.backgroundImage  = 'url(../../images/pkloader.gif)';"
    mStr = mStr & vbCrLf & "  o.style.backgroundRepeat= 'no-repeat';"
    mStr = mStr & vbCrLf & "  o.style.backgroundPosition = 'right';"
    mStr = mStr & vbCrLf & "  PageMethods.validate_FK_QCM_Requests_SupplierID(value, this.validated_FK_QCM_Requests_SupplierID);"
    mStr = mStr & vbCrLf & "},"
    mStr = mStr & vbCrLf & "validated_FK_QCM_Requests_SupplierID_main: false,"
    Dim oF_CreationRemarks As TextBox = FVqcmRequests.FindControl("F_CreationRemarks")
    mStr = mStr & vbCrLf & "validated_FK_QCM_Requests_SupplierID: function(result) {"
    mStr = mStr & vbCrLf & "  var p = result.split('|');"
    mStr = mStr & vbCrLf & "  var o = $get(p[1]);"
    mStr = mStr & vbCrLf & "  var q = $get('" & oF_CreationRemarks.ClientID & "');"
    mStr = mStr & vbCrLf & "  if(script_qcmRequests.validated_FK_QCM_Requests_SupplierID_main){"
    mStr = mStr & vbCrLf & "    var o_d = $get(p[1]+'_Display');"
    mStr = mStr & vbCrLf & "    try{o_d.innerHTML = p[2];}catch(ex){}"
    mStr = mStr & vbCrLf & "    q.value=p[3];"
    mStr = mStr & vbCrLf & "  }"
    mStr = mStr & vbCrLf & "  o.style.backgroundImage  = 'none';"
    mStr = mStr & vbCrLf & "  if(p[0]=='1'){"
    mStr = mStr & vbCrLf & "    q.value='';"
    mStr = mStr & vbCrLf & "    o.value='';"
    mStr = mStr & vbCrLf & "    o.focus();"
    mStr = mStr & vbCrLf & "  }"
    mStr = mStr & vbCrLf & "},"
    mStr = mStr & vbCrLf & "		ACERegionID_Selected: function(sender, e) {"
    mStr = mStr & vbCrLf & "		  var Prefix = sender._element.id.replace('RegionID','');"
    mStr = mStr & vbCrLf & "		  var F_RegionID = $get(sender._element.id);"
    mStr = mStr & vbCrLf & "		  var F_RegionID_Display = $get(sender._element.id + '_Display');"
    mStr = mStr & vbCrLf & "		  var retval = e.get_value();"
    mStr = mStr & vbCrLf & "		  var p = retval.split('|');"
    mStr = mStr & vbCrLf & "		  F_RegionID.value = p[0];"
    mStr = mStr & vbCrLf & "		  F_RegionID_Display.innerHTML = e.get_text();"
    mStr = mStr & vbCrLf & "		},"
    mStr = mStr & vbCrLf & "		ACERegionID_Populating: function(sender,e) {"
    mStr = mStr & vbCrLf & "		  var p = sender.get_element();"
    mStr = mStr & vbCrLf & "		  var Prefix = sender._element.id.replace('RegionID','');"
    mStr = mStr & vbCrLf & "		  p.style.backgroundImage  = 'url(../../images/loader.gif)';"
    mStr = mStr & vbCrLf & "		  p.style.backgroundRepeat= 'no-repeat';"
    mStr = mStr & vbCrLf & "		  p.style.backgroundPosition = 'right';"
    mStr = mStr & vbCrLf & "		  sender._contextKey = '';"
    mStr = mStr & vbCrLf & "		},"
    mStr = mStr & vbCrLf & "		ACERegionID_Populated: function(sender,e) {"
    mStr = mStr & vbCrLf & "		  var p = sender.get_element();"
    mStr = mStr & vbCrLf & "		  p.style.backgroundImage  = 'none';"
    mStr = mStr & vbCrLf & "		},"
    mStr = mStr & vbCrLf & "		validate_RegionID: function(sender) {"
    mStr = mStr & vbCrLf & "		  var Prefix = sender.id.replace('RegionID','');"
    mStr = mStr & vbCrLf & "		  this.validated_FK_QCM_Requests_RegionID_main = true;"
    mStr = mStr & vbCrLf & "		  this.validate_FK_QCM_Requests_RegionID(sender,Prefix);"
    mStr = mStr & vbCrLf & "		  },"
    mStr = mStr & vbCrLf & "		validate_FK_QCM_Requests_RegionID: function(o,Prefix) {"
    mStr = mStr & vbCrLf & "		  var value = o.id;"
    mStr = mStr & vbCrLf & "		  var RegionID = $get(Prefix + 'RegionID');"
    mStr = mStr & vbCrLf & "		  if(RegionID.value==''){"
    mStr = mStr & vbCrLf & "		    if(this.validated_FK_QCM_Requests_RegionID_main){"
    mStr = mStr & vbCrLf & "		      var o_d = $get(Prefix + 'RegionID' + '_Display');"
    mStr = mStr & vbCrLf & "		      try{o_d.innerHTML = '';}catch(ex){}"
    mStr = mStr & vbCrLf & "		    }"
    mStr = mStr & vbCrLf & "		    return true;"
    mStr = mStr & vbCrLf & "		  }"
    mStr = mStr & vbCrLf & "		  value = value + ',' + RegionID.value ;"
    mStr = mStr & vbCrLf & "		    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';"
    mStr = mStr & vbCrLf & "		    o.style.backgroundRepeat= 'no-repeat';"
    mStr = mStr & vbCrLf & "		    o.style.backgroundPosition = 'right';"
    mStr = mStr & vbCrLf & "		    PageMethods.validate_FK_QCM_Requests_RegionID(value, this.validated_FK_QCM_Requests_RegionID);"
    mStr = mStr & vbCrLf & "		  },"
    mStr = mStr & vbCrLf & "		validated_FK_QCM_Requests_RegionID_main: false,"
    mStr = mStr & vbCrLf & "		validated_FK_QCM_Requests_RegionID: function(result) {"
    mStr = mStr & vbCrLf & "		  var p = result.split('|');"
    mStr = mStr & vbCrLf & "		  var o = $get(p[1]);"
    mStr = mStr & vbCrLf & "		  if(script_qcmRequests.validated_FK_QCM_Requests_RegionID_main){"
    mStr = mStr & vbCrLf & "		    var o_d = $get(p[1]+'_Display');"
    mStr = mStr & vbCrLf & "		    try{o_d.innerHTML = p[2];}catch(ex){}"
    mStr = mStr & vbCrLf & "		  }"
    mStr = mStr & vbCrLf & "		  o.style.backgroundImage  = 'none';"
    mStr = mStr & vbCrLf & "		  if(p[0]=='1'){"
    mStr = mStr & vbCrLf & "		    o.value='';"
    mStr = mStr & vbCrLf & "		    o.focus();"
    mStr = mStr & vbCrLf & "		  }"
    mStr = mStr & vbCrLf & "		},"
    mStr = mStr & vbCrLf & "temp: function() {"
    mStr = mStr & vbCrLf & "}"
    mStr = mStr & vbCrLf & "}"
    mStr = mStr & vbCrLf & "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmRequests") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmRequests", mStr)
    End If
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/QCM_Main/App_Create") & "/AF_qcmRequests.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scripterpPO") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scripterpPO", mStr)
    End If
  End Sub
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_QCM_Requests_ReceivedBy(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim ReceivedBy As String = CType(aVal(1), String)
    Dim oVar As SIS.QCM.qcmEmployees = SIS.QCM.qcmEmployees.qcmEmployeesGetByID(ReceivedBy)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_QCM_Requests_ProjectID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim ProjectID As String = CType(aVal(1), String)
    Dim oVar As SIS.QCM.qcmProjects = SIS.QCM.qcmProjects.qcmProjectsGetByID(ProjectID)
    If oVar Is Nothing Then
      oVar = SIS.QCM.qcmProjects.GetProjectFromERP(ProjectID)
      If oVar Is Nothing Then
        mRet = "1|" & aVal(0) & "|Record not found IN ERP."
      Else
        mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
      End If
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_QCM_Requests_SupplierID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim SupplierID As String = CType(aVal(1), String)
    Dim oVar As SIS.QCM.qcmVendors = SIS.QCM.qcmVendors.qcmVendorsGetByID(SupplierID)
    Dim PlaceToVisit As String = ""
    If oVar Is Nothing Then
      SIS.QCM.qcmVendors.GetBPFromERP(SupplierID)
      oVar = SIS.QCM.qcmVendors.qcmVendorsGetByID(SupplierID)
      If oVar Is Nothing Then
        mRet = "1|" & aVal(0) & "|Record not found." & "|" & PlaceToVisit
      Else
        PlaceToVisit = " " & oVar.Description.Trim & vbCrLf & " " & oVar.Address1.Trim & vbCrLf & " " & oVar.Address2.Trim & vbCrLf & " " & oVar.Address3.Trim & vbCrLf & " " & oVar.Address4.Trim
        mRet = "0|" & aVal(0) & "|" & oVar.DisplayField & "|" & PlaceToVisit
      End If
    Else
      PlaceToVisit = " " & oVar.Description.Trim & vbCrLf & " " & oVar.Address1.Trim & vbCrLf & " " & oVar.Address2.Trim & vbCrLf & " " & oVar.Address3.Trim & vbCrLf & " " & oVar.Address4.Trim
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField & "|" & PlaceToVisit
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function RegionIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.QCM.qcmRegions.SelectqcmRegionsAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_QCM_Requests_RegionID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim RegionID As Int32 = CType(aVal(1), Int32)
    Dim oVar As SIS.QCM.qcmRegions = SIS.QCM.qcmRegions.qcmRegionsGetByID(RegionID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function

  Private Sub FVqcmRequests_ItemInserting(sender As Object, e As FormViewInsertEventArgs) Handles FVqcmRequests.ItemInserting
    Dim tmpDate As String = e.Values("RequestedInspectionStartDate")
    Try
      If Convert.ToDateTime(tmpDate).DayOfWeek = DayOfWeek.Sunday Then
        Dim message As String = New JavaScriptSerializer().Serialize("You can not request for Sunday. Pl. request for week days.")
        Dim script As String = String.Format("alert({0});", message)
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", script, True)
        e.Cancel = True
      End If
    Catch ex As Exception

    End Try
  End Sub
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_ERPPONumber(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim ERPPoNumber As String = CType(aVal(1), String)
    Dim oVar As SIS.ERP.ERPPo = SIS.ERP.ERPPo.ERPPoGetByID(ERPPoNumber)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|PO Number NOT found in ERP LN."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.SupplierID & "|" & oVar.ProjectID & "|" & oVar.POWeight
    End If
    Return mRet
  End Function
End Class
