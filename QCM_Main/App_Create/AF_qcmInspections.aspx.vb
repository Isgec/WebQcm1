Partial Class AF_qcmInspections
  Inherits SIS.SYS.InsertBase
  Protected Sub FVqcmInspections_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmInspections.Init
    DataClassName = "AqcmInspections"
    SetFormView = FVqcmInspections
  End Sub
  Protected Sub TBLqcmInspections_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmInspections.Init
    SetToolBar = TBLqcmInspections
  End Sub
  Protected Sub ODSqcmInspections_Inserted(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSqcmInspections.Inserted
    If e.Exception Is Nothing Then
      Dim oDC As SIS.QCM.qcmInspections = CType(e.ReturnValue, SIS.QCM.qcmInspections)
      Dim tmpURL As String = "?tmp=1"
      tmpURL &= "&RequestID=" & oDC.RequestID
      tmpURL &= "&InspectionID=" & oDC.InspectionID
      TBLqcmInspections.AfterInsertURL &= tmpURL
    End If
  End Sub
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function RequestIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.QCM.qcmRequests.SelectqcmRequestsAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function InspectedByCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.QCM.qcmEmployees.SelectqcmEmployeesAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub FVqcmInspections_PreRender(ByVal sender As Object, ByVal eex As System.EventArgs) Handles FVqcmInspections.PreRender
    Dim oReq As SIS.QCM.qcmRequests = SIS.QCM.qcmRequests.qcmRequestsGetByID(Request.QueryString("RequestID"))
    If oReq IsNot Nothing Then
      Dim roq As RequiredFieldValidator = CType(FVqcmInspections.FindControl("RFVOfferedQuantity"), RequiredFieldValidator)
      Dim riq As RequiredFieldValidator = CType(FVqcmInspections.FindControl("RFVInspectedQuantity"), RequiredFieldValidator)
      Dim rcq As RequiredFieldValidator = CType(FVqcmInspections.FindControl("RFVClearedQuantity"), RequiredFieldValidator)
      Dim roqf As RequiredFieldValidator = CType(FVqcmInspections.FindControl("RFVOfferedQuantityFinal"), RequiredFieldValidator)
      Dim riqf As RequiredFieldValidator = CType(FVqcmInspections.FindControl("RFVInspectedQuantityFinal"), RequiredFieldValidator)
      Dim rcqf As RequiredFieldValidator = CType(FVqcmInspections.FindControl("RFVClearedQuantityFinal"), RequiredFieldValidator)
      Dim a As TextBox = FVqcmInspections.FindControl("F_OfferedQuantity")
      Dim b As TextBox = FVqcmInspections.FindControl("F_OfferedQuantityFinal")
      Dim c As TextBox = FVqcmInspections.FindControl("F_InspectedQuantity")
      Dim d As TextBox = FVqcmInspections.FindControl("F_InspectedQuantityFinal")
      Dim e As TextBox = FVqcmInspections.FindControl("F_ClearedQuantity")
      Dim f As TextBox = FVqcmInspections.FindControl("F_ClearedQuantityFinal")
      Try
        CType(FVqcmInspections.FindControl("F_UOM"), DropDownList).SelectedValue = oReq.UOM
      Catch ex As Exception
      End Try

      If oReq.InspectionStageiD = "1" Then
        b.Enabled = False
        b.CssClass = "dmytxt"
        d.Enabled = False
        d.CssClass = "dmytxt"
        f.Enabled = False
        f.CssClass = "dmytxt"
        roqf.Enabled = False
        riqf.Enabled = False
        rcqf.Enabled = False
        Try
          a.Text = oReq.TotalRequestedQuantity
        Catch ex As Exception
        End Try
        Try
          c.Text = oReq.TotalRequestedQuantity
        Catch ex As Exception
        End Try
        Try
          e.Text = oReq.TotalRequestedQuantity
        Catch ex As Exception
        End Try
        b.Text = "0.00"
        d.Text = "0.00"
        f.Text = "0.00"
      ElseIf oReq.InspectionStageiD = "2" Then
        roq.Enabled = False
        riq.Enabled = False
        rcq.Enabled = False
        a.Enabled = False
        a.CssClass = "dmytxt"
        c.Enabled = False
        c.CssClass = "dmytxt"
        e.Enabled = False
        e.CssClass = "dmytxt"
        Try
          b.Text = oReq.LotSize
        Catch ex As Exception
        End Try
        Try
          d.Text = oReq.LotSize
        Catch ex As Exception
        End Try
        Try
          f.Text = oReq.LotSize
        Catch ex As Exception
        End Try
        a.Text = "0.00"
        c.Text = "0.00"
        e.Text = "0.00"
      End If
    End If
    Dim mStr As String = "<script type=""text/javascript""> "
    mStr = mStr & vbCrLf & " var script_qcmInspections = {"
    Dim oF_RequestID_Display As Label = FVqcmInspections.FindControl("F_RequestID_Display")
    oF_RequestID_Display.Text = oReq.Description
    Dim oF_RequestID As TextBox = FVqcmInspections.FindControl("F_RequestID")
    oF_RequestID.Enabled = False
    oF_RequestID.Text = oReq.RequestID
    mStr = mStr & vbCrLf & "ACERequestID_Selected: function(o, e) {"
    mStr = mStr & vbCrLf & "  var F_RequestID = $get('" & oF_RequestID.ClientID & "');"
    mStr = mStr & vbCrLf & "  var F_RequestID_Display = $get('" & oF_RequestID_Display.ClientID & "');"
    mStr = mStr & vbCrLf & "  var retval = e.get_value();"
    mStr = mStr & vbCrLf & "  var p = retval.split('|');"
    mStr = mStr & vbCrLf & "  F_RequestID.value = p[0];"
    mStr = mStr & vbCrLf & "  F_RequestID_Display.innerHTML = e.get_text();"
    mStr = mStr & vbCrLf & "},"
    mStr = mStr & vbCrLf & "ACERequestID_Populating: function(o,e) {"
    mStr = mStr & vbCrLf & "  var p = o.get_element();"
    mStr = mStr & vbCrLf & "  p.style.backgroundImage = 'url(../../images/loader.gif)';"
    mStr = mStr & vbCrLf & "  p.style.backgroundRepeat = 'no-repeat';"
    mStr = mStr & vbCrLf & "  p.style.backgroundPosition = 'right';"
    mStr = mStr & vbCrLf & "  o._contextKey = '';"
    mStr = mStr & vbCrLf & "},"
    mStr = mStr & vbCrLf & "ACERequestID_Populated: function(o,e) {"
    mStr = mStr & vbCrLf & "  var p = o.get_element();"
    mStr = mStr & vbCrLf & "  p.style.backgroundImage  = 'none';"
    mStr = mStr & vbCrLf & "},"
    Dim oF_InspectedBy_Display As Label = FVqcmInspections.FindControl("F_InspectedBy_Display")
    Dim oF_InspectedBy As TextBox = FVqcmInspections.FindControl("F_InspectedBy")
    oF_InspectedBy.Text = oReq.AllotedTo
    oF_InspectedBy_Display.Text = oReq.FK_QCM_Requests_AllotedTo.EmployeeName
    mStr = mStr & vbCrLf & "ACEInspectedBy_Selected: function(o, e) {"
    mStr = mStr & vbCrLf & "  var F_InspectedBy = $get('" & oF_InspectedBy.ClientID & "');"
    mStr = mStr & vbCrLf & "  var F_InspectedBy_Display = $get('" & oF_InspectedBy_Display.ClientID & "');"
    mStr = mStr & vbCrLf & "  var retval = e.get_value();"
    mStr = mStr & vbCrLf & "  var p = retval.split('|');"
    mStr = mStr & vbCrLf & "  F_InspectedBy.value = p[0];"
    mStr = mStr & vbCrLf & "  F_InspectedBy_Display.innerHTML = e.get_text();"
    mStr = mStr & vbCrLf & "},"
    mStr = mStr & vbCrLf & "ACEInspectedBy_Populating: function(o,e) {"
    mStr = mStr & vbCrLf & "  var p = o.get_element();"
    mStr = mStr & vbCrLf & "  p.style.backgroundImage = 'url(../../images/loader.gif)';"
    mStr = mStr & vbCrLf & "  p.style.backgroundRepeat = 'no-repeat';"
    mStr = mStr & vbCrLf & "  p.style.backgroundPosition = 'right';"
    mStr = mStr & vbCrLf & "  o._contextKey = '';"
    mStr = mStr & vbCrLf & "},"
    mStr = mStr & vbCrLf & "ACEInspectedBy_Populated: function(o,e) {"
    mStr = mStr & vbCrLf & "  var p = o.get_element();"
    mStr = mStr & vbCrLf & "  p.style.backgroundImage  = 'none';"
    mStr = mStr & vbCrLf & "},"
    mStr = mStr & vbCrLf & "validate_RequestID: function(o) {"
    mStr = mStr & vbCrLf & "    this.validated_FK_QCM_Inspections_RequestID_main = true;"
    mStr = mStr & vbCrLf & "    this.validate_FK_QCM_Inspections_RequestID(o);"
    mStr = mStr & vbCrLf & "  },"
    mStr = mStr & vbCrLf & "validate_InspectedBy: function(o) {"
    mStr = mStr & vbCrLf & "    this.validated_FK_QCM_Inspections_InspectedBy_main = true;"
    mStr = mStr & vbCrLf & "    this.validate_FK_QCM_Inspections_InspectedBy(o);"
    mStr = mStr & vbCrLf & "  },"
    Dim FK_QCM_Inspections_InspectedByInspectedBy As TextBox = FVqcmInspections.FindControl("F_InspectedBy")
    mStr = mStr & vbCrLf & "validate_FK_QCM_Inspections_InspectedBy: function(o) {"
    mStr = mStr & vbCrLf & "  var value = o.id;"
    mStr = mStr & vbCrLf & "  var InspectedBy = $get('" & FK_QCM_Inspections_InspectedByInspectedBy.ClientID & "');"
    mStr = mStr & vbCrLf & "  if(InspectedBy.value==''){"
    mStr = mStr & vbCrLf & "    if(this.validated_FK_QCM_Inspections_InspectedBy_main){"
    mStr = mStr & vbCrLf & "      var o_d = $get(o.id +'_Display');"
    mStr = mStr & vbCrLf & "      try{o_d.innerHTML = '';}catch(ex){}"
    mStr = mStr & vbCrLf & "    }"
    mStr = mStr & vbCrLf & "    return true;"
    mStr = mStr & vbCrLf & "  }"
    mStr = mStr & vbCrLf & "  value = value + ',' + InspectedBy.value ;"
    mStr = mStr & vbCrLf & "  o.style.backgroundImage  = 'url(../../images/pkloader.gif)';"
    mStr = mStr & vbCrLf & "  o.style.backgroundRepeat= 'no-repeat';"
    mStr = mStr & vbCrLf & "  o.style.backgroundPosition = 'right';"
    mStr = mStr & vbCrLf & "  PageMethods.validate_FK_QCM_Inspections_InspectedBy(value, this.validated_FK_QCM_Inspections_InspectedBy);"
    mStr = mStr & vbCrLf & "},"
    mStr = mStr & vbCrLf & "validated_FK_QCM_Inspections_InspectedBy_main: false,"
    mStr = mStr & vbCrLf & "validated_FK_QCM_Inspections_InspectedBy: function(result) {"
    mStr = mStr & vbCrLf & "  var p = result.split('|');"
    mStr = mStr & vbCrLf & "  var o = $get(p[1]);"
    mStr = mStr & vbCrLf & "  if(script_qcmInspections.validated_FK_QCM_Inspections_InspectedBy_main){"
    mStr = mStr & vbCrLf & "    var o_d = $get(p[1]+'_Display');"
    mStr = mStr & vbCrLf & "    try{o_d.innerHTML = p[2];}catch(ex){}"
    mStr = mStr & vbCrLf & "  }"
    mStr = mStr & vbCrLf & "  o.style.backgroundImage  = 'none';"
    mStr = mStr & vbCrLf & "  if(p[0]=='1'){"
    mStr = mStr & vbCrLf & "    o.value='';"
    mStr = mStr & vbCrLf & "    o.focus();"
    mStr = mStr & vbCrLf & "  }"
    mStr = mStr & vbCrLf & "},"
    Dim FK_QCM_Inspections_RequestIDRequestID As TextBox = FVqcmInspections.FindControl("F_RequestID")
    mStr = mStr & vbCrLf & "validate_FK_QCM_Inspections_RequestID: function(o) {"
    mStr = mStr & vbCrLf & "  var value = o.id;"
    mStr = mStr & vbCrLf & "  var RequestID = $get('" & FK_QCM_Inspections_RequestIDRequestID.ClientID & "');"
    mStr = mStr & vbCrLf & "  if(RequestID.value==''){"
    mStr = mStr & vbCrLf & "    if(this.validated_FK_QCM_Inspections_RequestID_main){"
    mStr = mStr & vbCrLf & "      var o_d = $get(o.id +'_Display');"
    mStr = mStr & vbCrLf & "      try{o_d.innerHTML = '';}catch(ex){}"
    mStr = mStr & vbCrLf & "    }"
    mStr = mStr & vbCrLf & "    return true;"
    mStr = mStr & vbCrLf & "  }"
    mStr = mStr & vbCrLf & "  value = value + ',' + RequestID.value ;"
    mStr = mStr & vbCrLf & "  o.style.backgroundImage  = 'url(../../images/pkloader.gif)';"
    mStr = mStr & vbCrLf & "  o.style.backgroundRepeat= 'no-repeat';"
    mStr = mStr & vbCrLf & "  o.style.backgroundPosition = 'right';"
    mStr = mStr & vbCrLf & "  PageMethods.validate_FK_QCM_Inspections_RequestID(value, this.validated_FK_QCM_Inspections_RequestID);"
    mStr = mStr & vbCrLf & "},"
    mStr = mStr & vbCrLf & "validated_FK_QCM_Inspections_RequestID_main: false,"
    mStr = mStr & vbCrLf & "validated_FK_QCM_Inspections_RequestID: function(result) {"
    mStr = mStr & vbCrLf & "  var p = result.split('|');"
    mStr = mStr & vbCrLf & "  var o = $get(p[1]);"
    mStr = mStr & vbCrLf & "  if(script_qcmInspections.validated_FK_QCM_Inspections_RequestID_main){"
    mStr = mStr & vbCrLf & "    var o_d = $get(p[1]+'_Display');"
    mStr = mStr & vbCrLf & "    try{o_d.innerHTML = p[2];}catch(ex){}"
    mStr = mStr & vbCrLf & "  }"
    mStr = mStr & vbCrLf & "  o.style.backgroundImage  = 'none';"
    mStr = mStr & vbCrLf & "  if(p[0]=='1'){"
    mStr = mStr & vbCrLf & "    o.value='';"
    mStr = mStr & vbCrLf & "    o.focus();"
    mStr = mStr & vbCrLf & "  }"
    mStr = mStr & vbCrLf & "},"
    mStr = mStr & vbCrLf & "temp: function() {"
    mStr = mStr & vbCrLf & "}"
    mStr = mStr & vbCrLf & "}"
    mStr = mStr & vbCrLf & "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmInspections") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmInspections", mStr)
    End If
  End Sub
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_QCM_Inspections_InspectedBy(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim InspectedBy As String = CType(aVal(1), String)
    Dim oVar As SIS.QCM.qcmEmployees = SIS.QCM.qcmEmployees.qcmEmployeesGetByID(InspectedBy)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function
  <System.Web.Services.WebMethod()>
  Public Shared Function validate_FK_QCM_Inspections_RequestID(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String = "0|" & aVal(0)
    Dim RequestID As Int32 = CType(aVal(1), Int32)
    Dim oVar As SIS.QCM.qcmRequests = SIS.QCM.qcmRequests.qcmRequestsGetByID(RequestID)
    If oVar Is Nothing Then
      mRet = "1|" & aVal(0) & "|Record not found."
    Else
      mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
    End If
    Return mRet
  End Function

  Private Sub FVqcmInspections_DataBound(sender As Object, e As EventArgs) Handles FVqcmInspections.DataBound
    SIS.QCM.qcmInspections.SetDefaultValues(sender, e)
  End Sub
End Class
