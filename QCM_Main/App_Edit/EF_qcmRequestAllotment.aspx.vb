Partial Class EF_qcmRequestAllotment
  Inherits SIS.SYS.UpdateBase
  Public Property Editable As Boolean
    Get
      If ViewState("Editable") IsNot Nothing Then
        Return CType(ViewState("Editable"), Boolean)
      End If
      Return False
    End Get
    Set(value As Boolean)
      ViewState.Add("Editable", value)
    End Set
  End Property
  Protected Sub FVqcmRequestAllotment_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmRequestAllotment.Init
    DataClassName = "EqcmRequestAllotment"
    SetFormView = FVqcmRequestAllotment
  End Sub
  Protected Sub TBLqcmRequestAllotment_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmRequestAllotment.Init
    SetToolBar = TBLqcmRequestAllotment
  End Sub
	<System.Web.Services.WebMethod()> _
	<System.Web.Script.Services.ScriptMethod()> _
  Public Shared Function AllotedToCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
		Return SIS.QCM.qcmEmployees.SelectqcmAllotedToAutoCompleteList(prefixText, count, contextKey)
  End Function
  Protected Sub FVqcmRequestAllotment_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmRequestAllotment.PreRender
		Dim mStr As String = "<script type=""text/javascript""> "
		mStr = mStr & vbCrLf & " var script_qcmRequestAllotment = {"
		Dim oSdt As TextBox = FVqcmRequestAllotment.FindControl("F_AllotedStartDate")
		Dim oFdt As TextBox = FVqcmRequestAllotment.FindControl("F_AllotedFinishDate")
		mStr = mStr & vbCrLf & "validateStartDate: function(s) {"
		mStr = mStr & vbCrLf & "  var f = $get('" & oFdt.ClientID & "');"
		mStr = mStr & vbCrLf & "  var afdt = f.value.split('/');"
		mStr = mStr & vbCrLf & "  var asdt = s.value.split('/');"
		mStr = mStr & vbCrLf & "  var fdt = new Date(afdt[2],afdt[1],afdt[0]);"
		mStr = mStr & vbCrLf & "  var sdt = new Date(asdt[2],asdt[1],asdt[0]);"
		mStr = mStr & vbCrLf & "  if(isNaN(fdt)||fdt<sdt) {"
		mStr = mStr & vbCrLf & "		//f.value = s.value;"
		mStr = mStr & vbCrLf & "		$find('finishDate').set_selectedDate($find('startDate').get_selectedDate());"
		mStr = mStr & vbCrLf & "  }"
		mStr = mStr & vbCrLf & "},"
		mStr = mStr & vbCrLf & "validateFinishDate: function(f) {"
		mStr = mStr & vbCrLf & "  var s = $get('" & oSdt.ClientID & "');"
		mStr = mStr & vbCrLf & "  var afdt = f.value.split('/');"
		mStr = mStr & vbCrLf & "  var asdt = s.value.split('/');"
		mStr = mStr & vbCrLf & "  var fdt = new Date(afdt[2],afdt[1],afdt[0]);"
		mStr = mStr & vbCrLf & "  var sdt = new Date(asdt[2],asdt[1],asdt[0]);"
		mStr = mStr & vbCrLf & "  if(isNaN(fdt)||fdt<sdt) {"
		mStr = mStr & vbCrLf & "		//f.value = s.value;"
		mStr = mStr & vbCrLf & "		$find('finishDate').set_selectedDate($find('startDate').get_selectedDate());"
		mStr = mStr & vbCrLf & "  }"
		mStr = mStr & vbCrLf & "},"
		Dim oF_AllotedTo_Display As Label = FVqcmRequestAllotment.FindControl("F_AllotedTo_Display")
    Dim oF_AllotedTo As TextBox  = FVqcmRequestAllotment.FindControl("F_AllotedTo")
		mStr = mStr & vbCrLf &	"ACEAllotedTo_Selected: function(sender, e) {"
		mStr = mStr & vbCrLf &	"  var F_AllotedTo = $get('" & oF_AllotedTo.ClientID & "');"
		mStr = mStr & vbCrLf &	"  var F_AllotedTo_Display = $get('" & oF_AllotedTo_Display.ClientID & "');"
		mStr = mStr & vbCrLf & "  var retval = e.get_value();"
		mStr = mStr & vbCrLf &	"  var p = retval.split('|');"
		mStr = mStr & vbCrLf & "  F_AllotedTo.value = p[0];"
		mStr = mStr & vbCrLf & "  F_AllotedTo_Display.innerHTML = e.get_text();"
		mStr = mStr & vbCrLf & "},"
		mStr = mStr & vbCrLf & "ACEAllotedTo_Populating: function(o,e) {"
		mStr = mStr & vbCrLf & "  var p = o.get_element();"
		mStr = mStr & vbCrLf & "  p.style.backgroundImage  = 'url(../../images/loader.gif)';"
		mStr = mStr & vbCrLf & "  p.style.backgroundRepeat= 'no-repeat';"
		mStr = mStr & vbCrLf & "  p.style.backgroundPosition = 'right';"
		mStr = mStr & vbCrLf & "  o._contextKey = '';"
		mStr = mStr & vbCrLf & 	"},"
		mStr = mStr & vbCrLf & 	"ACEAllotedTo_Populated: function(o,e) {"
		mStr = mStr & vbCrLf & 	"  var p = o.get_element();"
		mStr = mStr & vbCrLf & 	"  p.style.backgroundImage  = 'none';"
		mStr = mStr & vbCrLf & 	"},"
		mStr = mStr & vbCrLf & 	"validate_AllotedTo: function(o) {"
		mStr = mStr & vbCrLf & 	"  this.validated_FK_QCM_Requests_AllotedTo_main = true;"
		mStr = mStr & vbCrLf & 	"  this.validate_FK_QCM_Requests_AllotedTo(o);"
		mStr = mStr & vbCrLf & 	"  },"
		Dim FK_QCM_Requests_AllotedToAllotedTo As TextBox = FVqcmRequestAllotment.FindControl("F_AllotedTo")
		mStr = mStr & vbCrLf & 	"validate_FK_QCM_Requests_AllotedTo: function(o) {"
		mStr = mStr & vbCrLf & 	"  var value = o.id;"
		mStr = mStr & vbCrLf & 	"  var AllotedTo = $get('" & FK_QCM_Requests_AllotedToAllotedTo.ClientID & "');"
		mStr = mStr & vbCrLf & 	"  if(AllotedTo.value==''){"
		mStr = mStr & vbCrLf & 	"    if(this.validated_FK_QCM_Requests_AllotedTo_main){"
		mStr = mStr & vbCrLf &	"      var o_d = $get(o.id +'_Display');"
		mStr = mStr & vbCrLf &	"      try{o_d.innerHTML = '';}catch(ex){}"
		mStr = mStr & vbCrLf &	"    }"
		mStr = mStr & vbCrLf &	"    return true;"
		mStr = mStr & vbCrLf &	"  }"
		mStr = mStr & vbCrLf &	"  value = value + ',' + AllotedTo.value ;"
		mStr = mStr & vbCrLf &	"    o.style.backgroundImage  = 'url(../../images/pkloader.gif)';"
		mStr = mStr & vbCrLf &	"    o.style.backgroundRepeat= 'no-repeat';"
		mStr = mStr & vbCrLf &	"    o.style.backgroundPosition = 'right';"
		mStr = mStr & vbCrLf &	"    PageMethods.validate_FK_QCM_Requests_AllotedTo(value, this.validated_FK_QCM_Requests_AllotedTo);"
		mStr = mStr & vbCrLf &	"  },"
		mStr = mStr & vbCrLf &	"validated_FK_QCM_Requests_AllotedTo_main: false,"
		mStr = mStr & vbCrLf &	"validated_FK_QCM_Requests_AllotedTo: function(result) {"
		mStr = mStr & vbCrLf &	"  var p = result.split('|');"
		mStr = mStr & vbCrLf &	"  var o = $get(p[1]);"
		mStr = mStr & vbCrLf &	"  if(script_qcmRequestAllotment.validated_FK_QCM_Requests_AllotedTo_main){"
		mStr = mStr & vbCrLf &	"    var o_d = $get(p[1]+'_Display');"
		mStr = mStr & vbCrLf &	"    try{o_d.innerHTML = p[2];}catch(ex){}"
		mStr = mStr & vbCrLf &	"  }"
		mStr = mStr & vbCrLf &	"  o.style.backgroundImage  = 'none';"
		mStr = mStr & vbCrLf &	"  if(p[0]=='1'){"
		mStr = mStr & vbCrLf &	"    o.value='';"
		mStr = mStr & vbCrLf &	"    o.focus();"
		mStr = mStr & vbCrLf &	"  }"
		mStr = mStr & vbCrLf &	"},"
		mStr = mStr & vbCrLf &	"temp: function() {"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"}"
		mStr = mStr & vbCrLf &	"</script>"
		If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmRequestAllotment") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmRequestAllotment", mStr)
		End If
  End Sub
	<System.Web.Services.WebMethod()> _
  Public Shared Function validate_FK_QCM_Requests_AllotedTo(ByVal value As String) As String
    Dim aVal() As String = value.Split(",".ToCharArray)
    Dim mRet As String="0|" & aVal(0)
		Dim AllotedTo As String = CType(aVal(1),String)
    Dim oVar As SIS.QCM.qcmUsers = SIS.QCM.qcmEmployees.qcmAllotedToGetByID(AllotedTo)
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
  Private WithEvents gvqcmRequestFilesCC As New gvBase
  'Protected Sub GVqcmRequestFiles_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GVqcmRequestFiles.RowCommand
  '	If e.CommandName.ToLower = "downloadfile" Then
  '		Try
  '			Dim RequestID As Int32 = GVqcmRequestFiles.DataKeys(e.CommandArgument).Values("RequestID")
  '			Dim SerialNo As Int32 = GVqcmRequestFiles.DataKeys(e.CommandArgument).Values("SerialNo")
  '			Dim oAT As SIS.QCM.qcmRequestFiles = SIS.QCM.qcmRequestFiles.qcmRequestFilesGetByID(RequestID, SerialNo)
  '			If IO.File.Exists(Server.MapPath(ConfigurationManager.AppSettings("RequestDir")) & "/" & oAT.DiskFIleName) Then
  '				Response.AppendHeader("content-disposition", "attachment; filename='" & oAT.FileName & "'")
  '				Response.ContentType = oAT.ContentType
  '				Response.WriteFile(Server.MapPath(ConfigurationManager.AppSettings("RequestDir")) & "/" & oAT.DiskFIleName)
  '         Response.End()
  '       End If
  '		Catch ex As Exception
  '		End Try
  '	End If
  'End Sub
  Protected Sub cmdSchedule_Click(ByVal sender As Object, ByVal e As System.EventArgs)
		Dim oAllotedTo As TextBox = FVqcmRequestAllotment.FindControl("F_AllotedTo")
		Dim oF_AllotedStartDate As TextBox = FVqcmRequestAllotment.FindControl("F_AllotedStartDate")
		Dim AllotedTo As String = oAllotedTo.Text
		Dim oReqs As List(Of SIS.QCM.qcmRequests) = Nothing
		Dim ForDate As DateTime = Now
		If oF_AllotedStartDate.Text <> String.Empty Then
			ForDate = Convert.ToDateTime(oF_AllotedStartDate.Text)
		End If
		If AllotedTo = String.Empty Then
			oReqs = SIS.QCM.qcmRequests.GetAllotedToByCreatedByForMonthYear(ForDate)
		Else
			oReqs = SIS.QCM.qcmRequests.GetAllotedToByAllotedToForMonthYear(AllotedTo, ForDate)
		End If
		Dim oTbl As New Table

		Dim row As TableRow = Nothing
		Dim col As TableCell = Nothing
		For Each req As SIS.QCM.qcmRequests In oReqs
			row = New TableRow


			col = New TableCell
			col.BorderStyle = BorderStyle.Solid
			col.BorderColor = Drawing.Color.Black
			col.BorderWidth = Unit.Point(1)
			col.Text = req.HRM_Employees2_EmployeeName
			row.Cells.Add(col)

			col = New TableCell
			col.BorderStyle = BorderStyle.Solid
			col.BorderColor = Drawing.Color.Black
			col.BorderWidth = Unit.Point(1)
			col.Text = req.AllotedStartDate
			row.Cells.Add(col)

			col = New TableCell
			col.BorderStyle = BorderStyle.Solid
			col.BorderColor = Drawing.Color.Black
			col.BorderWidth = Unit.Point(1)
			col.Text = req.AllotedFinishDate
			row.Cells.Add(col)

			col = New TableCell
			col.BorderStyle = BorderStyle.Solid
			col.BorderColor = Drawing.Color.Black
			col.BorderWidth = Unit.Point(1)
			col.Text = req.IDM_Vendors7_Description
			row.Cells.Add(col)

			oTbl.Rows.Add(row)
		Next

		Dim oPnlSchedule As Panel = FVqcmRequestAllotment.FindControl("pnlSchedule")
		oPnlSchedule.Controls.Add(oTbl)

	End Sub

  Private Sub ODSqcmRequestAllotment_Selected(sender As Object, e As ObjectDataSourceStatusEventArgs) Handles ODSqcmRequestAllotment.Selected
    Dim oRequest As SIS.QCM.qcmRequestAllotment = CType(e.ReturnValue, SIS.QCM.qcmRequestAllotment)
    Editable = False
    Select Case oRequest.RequestStateID
      Case "UNDERALLOT", "ALLOTED", "REALLOTED"
        Editable = True
    End Select

  End Sub
End Class
