Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports OfficeOpenXml
Partial Class GF_rpRequestList
	Inherits SIS.SYS.InsertBase
	Protected Sub FVvrReports_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVvrReports.Init
		DataClassName = "AvrReports"
		SetFormView = FVvrReports
	End Sub
	Protected Sub TBLvrReports_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLvrReports.Init
		SetToolBar = TBLvrReports
	End Sub
	Protected Sub FVvrReports_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVvrReports.PreRender
		Dim mStr As String = ""
		Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/QCM_Main/App_Forms") & "/GF_rpRequestList.js")
		mStr = oTR.ReadToEnd
		oTR.Close()
		oTR.Dispose()
		If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptvrReports") Then
			Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptvrReports", mStr)
		End If
	End Sub
	<System.Web.Services.WebMethod()> _
	<System.Web.Script.Services.ScriptMethod()> _
	 Public Shared Function FProjectCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
		Return SIS.QCM.qcmProjects.SelectqcmProjectsAutoCompleteList(prefixText, count, contextKey)
	End Function
	<System.Web.Services.WebMethod()> _
	<System.Web.Script.Services.ScriptMethod()> _
	 Public Shared Function TProjectCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
		Return SIS.QCM.qcmProjects.SelectqcmProjectsAutoCompleteList(prefixText, count, contextKey)
	End Function
	<System.Web.Services.WebMethod()> _
 <System.Web.Script.Services.ScriptMethod()> _
	Public Shared Function FUserCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
		Return SIS.QCM.qcmUsers.SelectqcmUsersAutoCompleteList(prefixText, count, contextKey)
	End Function
	<System.Web.Services.WebMethod()> _
	<System.Web.Script.Services.ScriptMethod()> _
	 Public Shared Function TUserCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
		Return SIS.QCM.qcmUsers.SelectqcmUsersAutoCompleteList(prefixText, count, contextKey)
	End Function
	<System.Web.Services.WebMethod()> _
	 Public Shared Function validate_FK_VR_Reports_FUser(ByVal value As String) As String
		Dim aVal() As String = value.Split(",".ToCharArray)
		Dim mRet As String = "0|" & aVal(0)
		Dim FUser As String = CType(aVal(1), String)
		Dim oVar As SIS.QCM.qcmUsers = SIS.QCM.qcmUsers.qcmUsersGetByID(FUser)
		If oVar Is Nothing Then
			mRet = "1|" & aVal(0) & "|Record not found."
		Else
			mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
		End If
		Return mRet
	End Function
	<System.Web.Services.WebMethod()> _
	 Public Shared Function validate_FK_VR_Reports_TUser(ByVal value As String) As String
		Dim aVal() As String = value.Split(",".ToCharArray)
		Dim mRet As String = "0|" & aVal(0)
		Dim TUser As String = CType(aVal(1), String)
		Dim oVar As SIS.QCM.qcmUsers = SIS.QCM.qcmUsers.qcmUsersGetByID(TUser)
		If oVar Is Nothing Then
			mRet = "1|" & aVal(0) & "|Record not found."
		Else
			mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
		End If
		Return mRet
	End Function
	<System.Web.Services.WebMethod()> _
	 Public Shared Function validate_FK_VR_Reports_FProjectID(ByVal value As String) As String
		Dim aVal() As String = value.Split(",".ToCharArray)
		Dim mRet As String = "0|" & aVal(0)
		Dim FProject As String = CType(aVal(1), String)
		Dim oVar As SIS.QCM.qcmProjects = SIS.QCM.qcmProjects.qcmProjectsGetByID(FProject)
		If oVar Is Nothing Then
			mRet = "1|" & aVal(0) & "|Record not found."
		Else
			mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
		End If
		Return mRet
	End Function
	<System.Web.Services.WebMethod()> _
	 Public Shared Function validate_FK_VR_Reports_TProjectID(ByVal value As String) As String
		Dim aVal() As String = value.Split(",".ToCharArray)
		Dim mRet As String = "0|" & aVal(0)
		Dim TProject As String = CType(aVal(1), String)
		Dim oVar As SIS.QCM.qcmProjects = SIS.QCM.qcmProjects.qcmProjectsGetByID(TProject)
		If oVar Is Nothing Then
			mRet = "1|" & aVal(0) & "|Record not found."
		Else
			mRet = "0|" & aVal(0) & "|" & oVar.DisplayField
		End If
		Return mRet
	End Function
	<System.Web.Services.WebMethod()> _
 <System.Web.Script.Services.ScriptMethod()> _
 Public Shared Function RegionIDCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
		Return SIS.QCM.qcmRegions.SelectqcmRegionsAutoCompleteList(prefixText, count, contextKey)
	End Function
	<System.Web.Services.WebMethod()> _
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

	Protected Sub ODSvrReports_Inserting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceMethodEventArgs) Handles ODSvrReports.Inserting
		Dim oRec As SIS.VR.vrReports = e.InputParameters.Item(0)
		Dim FilePath As String = CreateFile(oRec)
		Dim FileNameForUser As String = "RequestList_" & Convert.ToDateTime(oRec.FReqDt).ToString("dd-MM-yyyy") & ".xlsx"
		If IO.File.Exists(FilePath) Then
			Response.Clear()
      Response.AppendHeader("content-disposition", "attachment; filename=" & FileNameForUser)
      Response.ContentType = SIS.SYS.Utilities.ApplicationSpacific.ContentType(FileNameForUser)
			Response.WriteFile(FilePath)
			Response.End()
			Try
				IO.File.Delete(FilePath)
			Catch ex As Exception
			End Try
		End If
		e.Cancel = True
	End Sub
	Private Function CreateFile(ByVal oRec As SIS.VR.vrReports) As String
		Dim FileName As String = Server.MapPath("~/..") & "App_Temp\" & Guid.NewGuid().ToString()
		IO.File.Copy(Server.MapPath("~/App_Templates") & "\CallTrends_Template.xlsx", FileName)
		Dim FileInfo As IO.FileInfo = New IO.FileInfo(FileName)
		Dim xlPk As ExcelPackage = New ExcelPackage(FileInfo)
		Dim xlWS As ExcelWorksheet = xlPk.Workbook.Worksheets("Calls Data")

		Dim oRqs As List(Of SIS.QCM.qcmRequests) = GetRequestCallsAndTrends(oRec)

		Dim r As Integer = 5
		Dim c As Integer = 1
		With xlWS
			.Cells(2, 10).Value = oRqs.Count
			.Cells(2, 3).Value = oRec.FReqDt
			.Cells(3, 3).Value = oRec.TReqDt
			.Cells(2, 6).Value = oRec.FUser
			.Cells(2, 7).Value = oRec.aspnet_Users1_UserFullName
			.Cells(3, 6).Value = oRec.RegionID
			.Cells(3, 7).Value = oRec.QCM_Regions12_RegionName
			For Each rq As SIS.QCM.qcmRequests In oRqs
				On Error Resume Next
				If r > 5 Then xlWS.InsertRow(r, 1, r + 1)
				c = 1
				.Cells(r, c).Value = rq.RequestID
				c += 1
				.Cells(r, c).Value = rq.ProjectID
				c += 1
				.Cells(r, c).Value = rq.IDM_Projects6_Description
				c += 1
				.Cells(r, c).Value = rq.SupplierID
				c += 1
				.Cells(r, c).Value = rq.IDM_Vendors7_Description
				c += 1
				.Cells(r, c).Value = rq.Description
				c += 1
				.Cells(r, c).Value = rq.OrderNo
				c += 1
				.Cells(r, c).Value = rq.HRM_Employees5_EmployeeName
				c += 1
				.Cells(r, c).Value = rq.ReceivedOn
				c += 1
				.Cells(r, c).Value = rq.RequestedInspectionStartDate
				c += 1
				'.Cells(r, c).Value = rq.AllotedStartDate
				.Cells(r, c).Value = rq.InspectionFinishDate
				c += 1
				.Cells(r, c).Value = Convert.ToDateTime(rq.RequestedInspectionStartDate).ToString("MMM-yy")
				c += 1
				Dim Days As Integer = 0
        'If rq.AllotedStartDate <> String.Empty Then
        '	Days = DateDiff(DateInterval.Day, Convert.ToDateTime(rq.RequestedInspectionStartDate), Convert.ToDateTime(rq.AllotedStartDate))
        'Else
        '	Days = DateDiff(DateInterval.Day, Convert.ToDateTime(rq.RequestedInspectionStartDate), Now)
        'End If
        If rq.InspectionStartDate <> String.Empty Then
          Days = DateDiff(DateInterval.Day, Convert.ToDateTime(rq.RequestedInspectionStartDate), Convert.ToDateTime(rq.InspectionStartDate))
        Else
          Days = DateDiff(DateInterval.Day, Convert.ToDateTime(rq.RequestedInspectionStartDate), Now)
				End If
				If Days <= 0 Then
					.Cells(r, c).Value = "    On Time"
				ElseIf Days >= 1 And Days <= 2 Then
					.Cells(r, c).Value = "   Within 1 to 2 days"
				ElseIf Days >= 3 And Days <= 4 Then
					.Cells(r, c).Value = "  Within 3 to 4 days"
				ElseIf Days > 4 Then
					.Cells(r, c).Value = "More than 4 days"
				End If
				c += 1
				.Cells(r, c).Value = rq.HRM_Employees3_EmployeeName
				c += 1
				.Cells(r, c).Value = rq.AllotedOn
				c += 1
				.Cells(r, c).Value = rq.QCM_Regions12_RegionName
				c += 1
        .Cells(r, c).Value = rq.HRM_Employees2_EmployeeName
        c += 1
        .Cells(r, c).Value = rq.InspectionStartDate
        c += 1
        .Cells(r, c).Value = rq.InspectionFinishDate
        c += 1
        .Cells(r, c).Value = rq.TotalHrs
        c += 1
        .Cells(r, c).Value = rq.TotalRequestedQuantity 'Requested Quantity Stage
        c += 1
        .Cells(r, c).Value = rq.LotSize 'Final Requested Quantity
        c += 1
        .Cells(r, c).Value = rq.UOM
        c += 1
        Dim tmpIs As List(Of SIS.QCM.qcmInspections) = SIS.QCM.qcmInspections.qcmInspectionsSelectList(0, 999, "", False, "", rq.RequestID)
        Dim soQty As Decimal = 0
        Dim siQty As Decimal = 0
        Dim scQty As Decimal = 0
        Dim foQty As Decimal = 0
        Dim fiQty As Decimal = 0
        Dim fcQty As Decimal = 0
        For Each tmp As SIS.QCM.qcmInspections In tmpIs
          soQty += tmp.OfferedQuantity
          siQty += tmp.InspectedQuantity
          scQty += tmp.ClearedQuantity
          foQty += tmp.OfferedQuantityFinal
          fiQty += tmp.InspectedQuantityFinal
          fcQty += tmp.ClearedQuantityFinal
        Next
        .Cells(r, c).Value = soQty
        c += 1
        .Cells(r, c).Value = siQty
        c += 1
        .Cells(r, c).Value = scQty
        c += 1
        .Cells(r, c).Value = foQty
        c += 1
        .Cells(r, c).Value = fiQty
        c += 1
        .Cells(r, c).Value = fcQty
        c += 1

        r += 1
      Next
			Dim ec As OfficeOpenXml.Drawing.Chart.ExcelChart = .Drawings("Chart2")
			If oRec.RegionID = String.Empty Then
				ec.Title.Text = "QUALITY OBJECTIVE ACHIEVED (OVERALL)"
			Else
				ec.Title.Text = "QUALITY OBJECTIVE ACHIEVED - " & oRec.QCM_Regions12_RegionName
			End If
		End With

		xlPk.Save()
		xlPk.Dispose()
		Return FileName
	End Function
	Private Function GetRequestCallsAndTrends(ByVal oRq As SIS.VR.vrReports) As List(Of SIS.QCM.qcmRequests)
		Dim Sql As String = ""
		Sql &= "  SELECT"
    Sql &= "		[QCM_Requests].* ,"
    'Sql &= "		[QCM_Requests].[ProjectID] ,"
    'Sql &= "		[QCM_Requests].[OrderNo] ,"
    'Sql &= "		[QCM_Requests].[OrderDate] ,"
    'Sql &= "		[QCM_Requests].[SupplierID] ,"
    'Sql &= "		[QCM_Requests].[Description] ,"
    'Sql &= "		[QCM_Requests].[TotalRequestedQuantity] ,"
    'Sql &= "		[QCM_Requests].[RequestedInspectionStartDate] ,"
    'Sql &= "		[QCM_Requests].[RequestedInspectionFinishDate] ,"
    'Sql &= "		[QCM_Requests].[ClientInspectionRequired] ,"
    'Sql &= "		[QCM_Requests].[ThirdPartyInspectionRequired] ,"
    'Sql &= "		[QCM_Requests].[ReceivedOn] ,"
    'Sql &= "		[QCM_Requests].[ReceivedBy] ,"
    'Sql &= "		[QCM_Requests].[ReceivingMediumID] ,"
    'Sql &= "		[QCM_Requests].[CreationRemarks] ,"
    'Sql &= "		[QCM_Requests].[CreatedBy] ,"
    'Sql &= "		[QCM_Requests].[CreatedOn] ,"
    'Sql &= "		[QCM_Requests].[RequestStateID] ,"
    'Sql &= "		[QCM_Requests].[FileAttached] ,"
    'Sql &= "		[QCM_Requests].[InspectionStageiD] ,"
    'Sql &= "		[QCM_Requests].[AllotedTo] ,"
    'Sql &= "		[QCM_Requests].[AllotedStartDate] ,"
    'Sql &= "		[QCM_Requests].[AllotedFinishDate] ,"
    'Sql &= "		[QCM_Requests].[AllotedOn] ,"
    'Sql &= "		[QCM_Requests].[AllotedBy] ,"
    'Sql &= "		[QCM_Requests].[AllotmentRemarks] ,"
    'Sql &= "		[QCM_Requests].[InspectionStartDate] ,"
    'Sql &= "		[QCM_Requests].[InspectionFinishDate] ,"
    'Sql &= "		[QCM_Requests].[InspectionStatusID] ,"
    'Sql &= "		[QCM_Requests].[CancelledOn] ,"
    'Sql &= "		[QCM_Requests].[CancelledBy] ,"
    'Sql &= "		[QCM_Requests].[CancellationRemarks] ,"
    'Sql &= "		[QCM_Requests].[RegionID] ,"
    'Sql &= "		[QCM_Requests].[UOM] ,"
    'Sql &= "		[QCM_Requests].[LotSize] ,"
    Sql &= "		[HRM_Employees1].[EmployeeName] AS HRM_Employees1_EmployeeName,"
    Sql &= "		[HRM_Employees2].[EmployeeName] AS HRM_Employees2_EmployeeName,"
		Sql &= "		[HRM_Employees3].[EmployeeName] AS HRM_Employees3_EmployeeName,"
		Sql &= "		[HRM_Employees4].[EmployeeName] AS HRM_Employees4_EmployeeName,"
		Sql &= "		[HRM_Employees5].[EmployeeName] AS HRM_Employees5_EmployeeName,"
		Sql &= "		[IDM_Projects6].[Description] AS IDM_Projects6_Description,"
		Sql &= "		[IDM_Vendors7].[Description] AS IDM_Vendors7_Description,"
		Sql &= "		[QCM_InspectionStages8].[Description] AS QCM_InspectionStages8_Description,"
		Sql &= "		[QCM_ReceivingMediums9].[Description] AS QCM_ReceivingMediums9_Description,"
		Sql &= "		[QCM_RequestStates10].[Description] AS QCM_RequestStates10_Description,"
		Sql &= "		[QCM_InspectionStatus11].[Description] AS QCM_InspectionStatus11_Description, "
		Sql &= "		[QCM_Regions12].[RegionName] AS QCM_Regions12_RegionName "
		Sql &= "  FROM [QCM_Requests] "
		Sql &= "  INNER JOIN [HRM_Employees] AS [HRM_Employees1]"
		Sql &= "    ON [QCM_Requests].[CreatedBy] = [HRM_Employees1].[CardNo]"
		Sql &= "  LEFT OUTER JOIN [HRM_Employees] AS [HRM_Employees2]"
		Sql &= "    ON [QCM_Requests].[AllotedTo] = [HRM_Employees2].[CardNo]"
		Sql &= "  LEFT OUTER JOIN [HRM_Employees] AS [HRM_Employees3]"
		Sql &= "    ON [QCM_Requests].[AllotedBy] = [HRM_Employees3].[CardNo]"
		Sql &= "  LEFT OUTER JOIN [HRM_Employees] AS [HRM_Employees4]"
		Sql &= "    ON [QCM_Requests].[CancelledBy] = [HRM_Employees4].[CardNo]"
		Sql &= "  LEFT OUTER JOIN [HRM_Employees] AS [HRM_Employees5]"
		Sql &= "    ON [QCM_Requests].[ReceivedBy] = [HRM_Employees5].[CardNo]"
		Sql &= "  INNER JOIN [IDM_Projects] AS [IDM_Projects6]"
		Sql &= "    ON [QCM_Requests].[ProjectID] = [IDM_Projects6].[ProjectID]"
		Sql &= "  INNER JOIN [IDM_Vendors] AS [IDM_Vendors7]"
		Sql &= "    ON [QCM_Requests].[SupplierID] = [IDM_Vendors7].[VendorID]"
		Sql &= "  LEFT OUTER JOIN [QCM_InspectionStages] AS [QCM_InspectionStages8]"
		Sql &= "    ON [QCM_Requests].[InspectionStageiD] = [QCM_InspectionStages8].[InspectionStageID]"
		Sql &= "  LEFT OUTER JOIN [QCM_ReceivingMediums] AS [QCM_ReceivingMediums9]"
		Sql &= "    ON [QCM_Requests].[ReceivingMediumID] = [QCM_ReceivingMediums9].[ReceivingMediumID]"
		Sql &= "  INNER JOIN [QCM_RequestStates] AS [QCM_RequestStates10]"
		Sql &= "    ON [QCM_Requests].[RequestStateID] = [QCM_RequestStates10].[StateID]"
		Sql &= "  LEFT OUTER JOIN [QCM_InspectionStatus] AS [QCM_InspectionStatus11]"
		Sql &= "    ON [QCM_Requests].[InspectionStatusID] = [QCM_InspectionStatus11].[InspectionStatusID]"
		Sql &= "  LEFT OUTER JOIN [QCM_Regions] AS [QCM_Regions12]"
		Sql &= "    ON [QCM_Requests].[RegionID] = [QCM_Regions12].[RegionID]"
		Sql &= "  WHERE"
		Sql &= "  [QCM_Requests].[RequestedInspectionStartDate] >= '" & Convert.ToDateTime(oRq.FReqDt).ToString("yyyy-MM-dd") & "' AND [QCM_Requests].[RequestedInspectionStartDate] < '" & Convert.ToDateTime(oRq.TReqDt).AddDays(1).ToString("yyyy-MM-dd") & "'"
    Sql &= "  AND [QCM_Requests].[RequestStateID] NOT IN ('OPEN','CANCELLED','RETURNED')"
    If oRq.FUser <> String.Empty Then
			Sql &= " AND [QCM_Requests].[AllotedTo] = '" & oRq.FUser & "' "
		End If
		If oRq.RegionID <> String.Empty Then
			Sql &= " AND [QCM_Requests].[RegionID] = " & oRq.RegionID
		End If
		Sql &= " ORDER BY [QCM_Requests].[RequestedInspectionStartDate]"

		Dim Results As List(Of SIS.QCM.qcmRequests) = Nothing
		Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
			Using Cmd As SqlCommand = Con.CreateCommand()
				Cmd.CommandType = CommandType.Text
				Cmd.CommandText = Sql
				Results = New List(Of SIS.QCM.qcmRequests)()
				Con.Open()
				Dim Reader As SqlDataReader = Cmd.ExecuteReader()
				While (Reader.Read())
					Results.Add(New SIS.QCM.qcmRequests(Reader))
				End While
				Reader.Close()
			End Using
		End Using
		Return Results
	End Function
End Class
