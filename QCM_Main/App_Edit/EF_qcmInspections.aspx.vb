Partial Class EF_qcmInspections
  Inherits SIS.SYS.UpdateBase
	Public Property Editable() As Boolean
		Get
      If ViewState("Editable") IsNot Nothing Then
        Return CType(ViewState("Editable"), Boolean)
      End If
      Return False
    End Get
    Set(ByVal value As Boolean)
      ViewState.Add("Editable", value)
    End Set

  End Property
	Public Property RequestID() As Integer
		Get
      If ViewState("RequestID") IsNot Nothing Then
        Return CType(ViewState("RequestID"), Integer)
      End If
      Return 0
    End Get
		Set(ByVal value As Integer)
			ViewState.Add("RequestID", value)
		End Set
	End Property
  Public Property InspectionID() As Integer
    Get
      If ViewState("InspectionID") IsNot Nothing Then
        Return CType(ViewState("InspectionID"), Integer)
      End If
      Return 0
    End Get
    Set(ByVal value As Integer)
      ViewState.Add("InspectionID", value)
    End Set
  End Property
  Dim oRequest As SIS.QCM.qcmRequests = Nothing
  Protected Sub ODSqcmInspections_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSqcmInspections.Selected
		Dim oInspections As SIS.QCM.qcmInspections = CType(e.ReturnValue, SIS.QCM.qcmInspections)
    oRequest = SIS.QCM.qcmRequests.qcmRequestsGetByID(oInspections.RequestID)
    If oRequest.RequestStateID = "ALLOTED" Or oRequest.RequestStateID = "INSPECTED" Then
      Editable = True
    Else
      Editable = False
		End If
	End Sub
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		If Not Page.IsCallback And Not Page.IsPostBack Then
			RequestID = Request.QueryString("RequestID")
			InspectionID = Request.QueryString("InspectionID")
		End If
	End Sub
	Protected Sub cmdFileUpload_Command(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.CommandEventArgs) Handles cmdFileUpload.Command
		With F_FileUpload
			If .HasFile Then
				Dim oAT As SIS.QCM.qcmInspectionFiles = New SIS.QCM.qcmInspectionFiles
				Dim oRm As Random = New Random
				oAT.RequestID = RequestID
				oAT.InspectionID = InspectionID
				oAT.FileName = .FileName
				oAT.DiskFIleName = oAT.RequestID & oRm.Next(1000, 99999999)
				oAT = SIS.QCM.qcmInspectionFiles.InsertData(oAT)
				.SaveAs(Server.MapPath(ConfigurationManager.AppSettings("InspectionDir")) & "/" & oAT.DiskFIleName)
				GVqcmInspectionFiles.DataBind()
			End If
		End With
	End Sub
	Protected Sub GVqcmInspectionFiles_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVqcmInspectionFiles.RowCommand
		If e.CommandName.ToLower = "downloadfile" Then
			Try
				Dim RequestID As Int32 = GVqcmInspectionFiles.DataKeys(e.CommandArgument).Values("RequestID")
				Dim InspectionID As Int32 = GVqcmInspectionFiles.DataKeys(e.CommandArgument).Values("InspectionID")
				Dim SerialNo As Int32 = GVqcmInspectionFiles.DataKeys(e.CommandArgument).Values("SerialNo")
				Dim oAT As SIS.QCM.qcmInspectionFiles = SIS.QCM.qcmInspectionFiles.qcmInspectionFilesGetByID(RequestID, InspectionID, SerialNo)
				If IO.File.Exists(Server.MapPath(ConfigurationManager.AppSettings("InspectionDir")) & "/" & oAT.DiskFIleName) Then
					Response.AppendHeader("content-disposition", "attachment; filename='" & oAT.FileName & "'")
					Response.ContentType = oAT.ContentType
					Response.WriteFile(Server.MapPath(ConfigurationManager.AppSettings("InspectionDir")) & "/" & oAT.DiskFIleName)
					Response.Flush()
				End If
			Catch ex As Exception
			End Try
		End If
		If e.CommandName.ToLower = "remove" Then
			Try
				Dim RequestID As Int32 = GVqcmInspectionFiles.DataKeys(e.CommandArgument).Values("RequestID")
				Dim InspectionID As Int32 = GVqcmInspectionFiles.DataKeys(e.CommandArgument).Values("InspectionID")
				Dim SerialNo As Int32 = GVqcmInspectionFiles.DataKeys(e.CommandArgument).Values("SerialNo")
				Dim oAT As SIS.QCM.qcmInspectionFiles = SIS.QCM.qcmInspectionFiles.qcmInspectionFilesGetByID(RequestID, InspectionID, SerialNo)
				IO.File.Delete(Server.MapPath(ConfigurationManager.AppSettings("InspectionDir")) & "/" & oAT.DiskFIleName)
				SIS.QCM.qcmInspectionFiles.Delete(oAT)
				GVqcmInspectionFiles.DataBind()
			Catch ex As Exception
			End Try
		End If
	End Sub
	Protected Sub FVqcmInspections_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmInspections.Init
		DataClassName = "EqcmInspections"
		SetFormView = FVqcmInspections
	End Sub
  Protected Sub TBLqcmInspections_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmInspections.Init
    SetToolBar = TBLqcmInspections
  End Sub
	<System.Web.Services.WebMethod()> _
	<System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function InspectedByCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.QCM.qcmUsers.SelectqcmUsersAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub FVqcmInspections_PreRender(ByVal sender As Object, ByVal ege As System.EventArgs) Handles FVqcmInspections.PreRender
    If Not Editable Then
      TBLqcmInspections.EnableSave = False
      TBLqcmInspections.EnableDelete = False
    End If
    If oRequest IsNot Nothing Then
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
      If oRequest.InspectionStageiD = "1" Then
        b.Enabled = False
        b.CssClass = "dmytxt"
        d.Enabled = False
        d.CssClass = "dmytxt"
        f.Enabled = False
        f.CssClass = "dmytxt"
        roqf.Enabled = False
        riqf.Enabled = False
        rcqf.Enabled = False
      ElseIf oRequest.InspectionStageiD = "2" Then
        roq.Enabled = False
        riq.Enabled = False
        rcq.Enabled = False
        a.Enabled = False
        a.CssClass = "dmytxt"
        c.Enabled = False
        c.CssClass = "dmytxt"
        e.Enabled = False
        e.CssClass = "dmytxt"
      End If
    End If
    Dim mStr As String = "<script type=""text/javascript""> "
    mStr = mStr & vbCrLf & " var script_qcmInspections = {"
    Dim oF_RequestID As TextBox = FVqcmInspections.FindControl("F_RequestID")
    Dim oF_InspectedBy_Display As Label = FVqcmInspections.FindControl("F_InspectedBy_Display")
    Dim oF_InspectedBy As TextBox = FVqcmInspections.FindControl("F_InspectedBy")
    mStr = mStr & vbCrLf & "ACEInspectedBy_Selected: function(sender, e) {"
    mStr = mStr & vbCrLf & "  var F_InspectedBy = $get('" & oF_InspectedBy.ClientID & "');"
    mStr = mStr & vbCrLf & "  var F_InspectedBy_Display = $get('" & oF_InspectedBy_Display.ClientID & "');"
    mStr = mStr & vbCrLf & "  var retval = e.get_value();"
    mStr = mStr & vbCrLf & "  var p = retval.split('|');"
    mStr = mStr & vbCrLf & "  F_InspectedBy.value = p[0];"
    mStr = mStr & vbCrLf & "  F_InspectedBy_Display.innerHTML = e.get_text();"
    mStr = mStr & vbCrLf & "},"
    mStr = mStr & vbCrLf & "ACEInspectedBy_Populating: function(o,e) {"
    mStr = mStr & vbCrLf & "  var p = o.get_element();"
    mStr = mStr & vbCrLf & "  p.style.backgroundImage  = 'url(../../images/loader.gif)';"
    mStr = mStr & vbCrLf & "  p.style.backgroundRepeat= 'no-repeat';"
    mStr = mStr & vbCrLf & "  p.style.backgroundPosition = 'right';"
    mStr = mStr & vbCrLf & "  o._contextKey = '';"
    mStr = mStr & vbCrLf & "},"
    mStr = mStr & vbCrLf & "ACEInspectedBy_Populated: function(o,e) {"
    mStr = mStr & vbCrLf & "  var p = o.get_element();"
    mStr = mStr & vbCrLf & "  p.style.backgroundImage  = 'none';"
    mStr = mStr & vbCrLf & "},"
    mStr = mStr & vbCrLf & "validate_InspectedBy: function(o) {"
    mStr = mStr & vbCrLf & "  this.validated_FK_QCM_Inspections_InspectedBy_main = true;"
    mStr = mStr & vbCrLf & "  this.validate_FK_QCM_Inspections_InspectedBy(o);"
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
    mStr = mStr & vbCrLf & "    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';"
    mStr = mStr & vbCrLf & "    o.style.backgroundRepeat= 'no-repeat';"
    mStr = mStr & vbCrLf & "    o.style.backgroundPosition = 'right';"
    mStr = mStr & vbCrLf & "    PageMethods.validate_FK_QCM_Inspections_InspectedBy(value, this.validated_FK_QCM_Inspections_InspectedBy);"
    mStr = mStr & vbCrLf & "  },"
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
    mStr = mStr & vbCrLf & "temp: function() {"
    mStr = mStr & vbCrLf & "}"
    mStr = mStr & vbCrLf & "}"
    mStr = mStr & vbCrLf & "</script>"
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmInspections") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmInspections", mStr)
    End If
  End Sub
  <System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_QCM_Inspections_InspectedBy(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
		Dim InspectedBy As String = CType(aVal(1),String)
    Dim oVar As SIS.QCM.qcmUsers = SIS.QCM.qcmUsers.qcmUsersGetByID(InspectedBy)
    If oVar Is Nothing Then
			mRet = "1|" & aVal(0) & "|Record not found." 
    Else
			mRet = "0|" & aVal(0) & "|" & oVar.DisplayField 
    End If
    Return mRet
  End Function
  Partial Class gvBase
		Inherits SIS.SYS.GridBase
  End Class
  Private WithEvents gvqcmInspectionFilesCC As New gvBase
  Protected Sub GVqcmInspectionFiles_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVqcmInspectionFiles.Init
		gvqcmInspectionFilesCC.DataClassName = "GqcmInspectionFiles"
		gvqcmInspectionFilesCC.SetGridView = GVqcmInspectionFiles
  End Sub
  Protected Sub TBLqcmInspectionFiles_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmInspectionFiles.Init
		gvqcmInspectionFilesCC.SetToolBar = TBLqcmInspectionFiles
  End Sub
	Protected Sub TBLqcmInspectionFiles_AddClicked(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles TBLqcmInspectionFiles.AddClicked
		Dim RequestID As Int32 = CType(FVqcmInspections.FindControl("F_RequestID"), TextBox).Text
		Dim InspectionID As Int32 = CType(FVqcmInspections.FindControl("F_InspectionID"), TextBox).Text
		TBLqcmInspectionFiles.AddUrl &= "?RequestID=" & RequestID
		TBLqcmInspectionFiles.AddUrl &= "&InspectionID=" & InspectionID
	End Sub
End Class
