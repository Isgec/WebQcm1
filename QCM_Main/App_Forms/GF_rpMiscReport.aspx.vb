Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports OfficeOpenXml
Partial Class GF_rpMiscReport
  Inherits SIS.SYS.InsertBase
  Protected Sub FVvrReports_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVvrReports.Init
    DataClassName = "AvrReports"
    SetFormView = FVvrReports
  End Sub
  Protected Sub TBLvrReports_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLvrReports.Init
    SetToolBar = TBLvrReports
  End Sub
  Protected Sub FVvrReports_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVvrReports.PreRender
    CType(FVvrReports.FindControl("F_FReqDt"), TextBox).Text = Now.AddDays(-30)
    CType(FVvrReports.FindControl("F_TReqDt"), TextBox).Text = Now
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/QCM_Main/App_Forms") & "/GF_rpRequestList.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptvrReports") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptvrReports", mStr)
    End If
  End Sub
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function FProjectCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.QCM.qcmProjects.SelectqcmProjectsAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function TProjectCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.QCM.qcmProjects.SelectqcmProjectsAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function FUserCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.QCM.qcmUsers.SelectqcmUsersAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
  <System.Web.Script.Services.ScriptMethod()>
  Public Shared Function TUserCompletionList(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
    Return SIS.QCM.qcmUsers.SelectqcmUsersAutoCompleteList(prefixText, count, contextKey)
  End Function
  <System.Web.Services.WebMethod()>
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
  <System.Web.Services.WebMethod()>
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
  <System.Web.Services.WebMethod()>
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
  <System.Web.Services.WebMethod()>
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

  Private Sub FVvrReports_ItemCommand(sender As Object, e As FormViewCommandEventArgs) Handles FVvrReports.ItemCommand
    Dim oRec As New SIS.VR.vrReports
    oRec.FReqDt = CType(FVvrReports.FindControl("F_FReqDt"), TextBox).Text
    oRec.TReqDt = CType(FVvrReports.FindControl("F_TReqDt"), TextBox).Text
    oRec.RegionID = CType(FVvrReports.FindControl("F_RegionID"), LC_qcmRegions).SelectedValue
    oRec.FUser = CType(FVvrReports.FindControl("F_FUser"), TextBox).Text

    Dim LastTimeout As Integer = HttpContext.Current.Server.ScriptTimeout
    HttpContext.Current.Server.ScriptTimeout = Integer.MaxValue
    If e.CommandName.ToString.ToUpper = "DELAY" Then
      Try
        Dim FilePath As String = CreateDelayReport(oRec)
        Dim FileNameForUser As String = "DelayReport_" & Convert.ToDateTime(oRec.FReqDt).ToString("dd-MM-yyyy") & ".xlsx"
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
      Catch ex As Exception
      End Try
    End If
    If e.CommandName.ToString.ToUpper = "LOAD" Then
      Try
        Dim FilePath As String = CreateLoadReport(oRec)
        Dim FileNameForUser As String = "LoadReport_" & Convert.ToDateTime(oRec.FReqDt).ToString("dd-MM-yyyy") & ".xlsx"
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
      Catch ex As Exception
      End Try
    End If
    HttpContext.Current.Server.ScriptTimeout = LastTimeout
  End Sub

  Private Function CreateDelayReport(ByVal oRec As SIS.VR.vrReports) As String
    Dim FileName As String = Server.MapPath("~/..") & "App_Temp\" & Guid.NewGuid().ToString()
    IO.File.Copy(Server.MapPath("~/App_Templates") & "\DelayReport_Template.xlsx", FileName)
    Dim FileInfo As IO.FileInfo = New IO.FileInfo(FileName)
    Dim xlPk As ExcelPackage = New ExcelPackage(FileInfo)
    Dim xlWS As ExcelWorksheet = xlPk.Workbook.Worksheets("Data")

    Dim oRqs As List(Of DelayReport) = GetDelayReport(oRec)

    Dim r As Integer = 5
    Dim c As Integer = 1
    Dim l As Integer = -1
    With xlWS
      .Cells(3, 3).Value = oRec.TReqDt
      For Each rq As DelayReport In oRqs

        If rq.RegionID = 10 Then
          l = r
          r = 21
        Else
          If l > 0 Then
            r = l
            l = -1
          End If
        End If
        c = 2
        .Cells(r, c).Value = rq.RegionName
        c += 1
        .Cells(r, c).Value = rq.OnTime
        c += 1
        .Cells(r, c).Value = rq.Within2Days
        c += 1
        .Cells(r, c).Value = rq.Within4Days
        c += 1
        .Cells(r, c).Value = rq.MoreThan4Days
        c += 1
        .Cells(r, c).Value = rq.TotalPausedCalls
        c += 1
        .Cells(r, c).Value = rq.OnTime + rq.Within2Days + rq.Within4Days + rq.MoreThan4Days + rq.TotalPausedCalls
        c += 1
        .Cells(r, c).Value = rq.ReceivedYesterday
        c += 1
        .Cells(r, c).Value = rq.AttendedYesterday
        c += 1
        .Cells(r, c).Value = rq.ClosedYesterday

        r += 1
      Next
    End With

    Dim LRqs As List(Of SIS.QCM.qcmRequests) = GetRequestList(oRec)
    PrintList(xlWS, LRqs, oRec)

    xlPk.Save()
    xlPk.Dispose()
    Return FileName
  End Function
  Private Function GetDelayReport(ByVal oRq As SIS.VR.vrReports) As List(Of DelayReport)
    Dim Sql As String = ""
    Sql &= " select "
    Sql &= "    Distinct aa.RegionID, bb.RegionName, "
    'OnTime
    Sql &= "    ( Select Count(bb.RequestID) from qcm_requests as bb "
    Sql &= "    where bb.RegionID = aa.regionID "
    Sql &= "    and bb.RequestedInspectionStartDate = convert(datetime,'" & oRq.TReqDt & "',103) "
    Sql &= "    and bb.RequestStateID NOT IN ('OPEN','CANCELLED','RETURNED') "
    Sql &= "    and (case when bb.InspectionStartDate is null then datediff(d,bb.RequestedInspectionStartDate,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    else datediff(d,bb.RequestedInspectionStartDate, datediff(d,0,bb.InspectionStartDate)) end) < 1   "
    Sql &= "    and (case when bb.InspectionStartDate is null then datediff(d,bb.RequestedInspectionStartDate,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    else datediff(d,bb.RequestedInspectionStartDate, datediff(d,0,bb.InspectionStartDate)) end) >= 0   "
    Sql &= "    ) as OnTime, "
    'With in 1 to 2 Days
    Sql &= "    ( Select Count(bb.RequestID) from qcm_requests as bb "
    Sql &= "    where bb.RegionID = aa.regionID "
    Sql &= "    and bb.RequestedInspectionStartDate >= dateadd(d,-2,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    and bb.RequestedInspectionStartDate < convert(datetime,'" & oRq.TReqDt & "',103) "
    Sql &= "    and bb.RequestStateID NOT IN ('OPEN','CANCELLED','RETURNED') "
    Sql &= "    and (case when bb.InspectionStartDate is null then datediff(d,bb.RequestedInspectionStartDate,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    else datediff(d,bb.RequestedInspectionStartDate, datediff(d,0,bb.InspectionStartDate)) end) <= 2   "
    Sql &= "    and (case when bb.InspectionStartDate is null then datediff(d,bb.RequestedInspectionStartDate,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    else datediff(d,bb.RequestedInspectionStartDate, datediff(d,0,bb.InspectionStartDate)) end) >= 1   "
    Sql &= "    and (bb.InspectionStartDate is null or datediff(d,0,bb.InspectionStartDate) >= convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    ) as WithIn2Days, "
    'With In 3 to 4 Days
    Sql &= "    ( Select Count(bb.RequestID) from qcm_requests as bb "
    Sql &= "    where bb.RegionID = aa.regionID "
    Sql &= "    and bb.RequestedInspectionStartDate >= dateadd(d,-4,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    and bb.RequestedInspectionStartDate < convert(datetime,'" & oRq.TReqDt & "',103) "
    Sql &= "    and bb.RequestStateID NOT IN ('OPEN','CANCELLED','RETURNED') "
    Sql &= "    and (case when bb.InspectionStartDate is null then datediff(d,bb.RequestedInspectionStartDate,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    else datediff(d,bb.RequestedInspectionStartDate, datediff(d,0,bb.InspectionStartDate)) end) <= 4   "
    Sql &= "    and (case when bb.InspectionStartDate is null then datediff(d,bb.RequestedInspectionStartDate,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    else datediff(d,bb.RequestedInspectionStartDate, datediff(d,0,bb.InspectionStartDate)) end) >= 3   "
    Sql &= "    and (bb.InspectionStartDate is null or datediff(d,0,bb.InspectionStartDate) >= convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    ) as WithIn4Days, "
    'More Than 4 Days
    Sql &= "    ( Select Count(bb.RequestID) from qcm_requests as bb "
    Sql &= "    where bb.RegionID = aa.regionID "
    Sql &= "    and bb.RequestedInspectionStartDate >= dateadd(d,-30,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    and bb.RequestedInspectionStartDate < convert(datetime,'" & oRq.TReqDt & "',103) "
    Sql &= "    and bb.RequestStateID NOT IN ('OPEN','CANCELLED','RETURNED') "
    Sql &= "    and (case when bb.InspectionStartDate is null then datediff(d,bb.RequestedInspectionStartDate,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    else datediff(d,bb.RequestedInspectionStartDate, datediff(d,0,bb.InspectionStartDate)) end) > 4   "
    Sql &= "    and (bb.InspectionStartDate is null or datediff(d,0,bb.InspectionStartDate) >= convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    ) as MoreThan4Days, "
    'Total Paused Calls of Last 30 Days
    Sql &= "    ( Select Count(bb.RequestID) from qcm_requests as bb "
    Sql &= "    where bb.RegionID = aa.regionID "
    Sql &= "    and bb.RequestedInspectionStartDate >= dateadd(d,-30,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    and datediff(d,0,bb.LastPausedOn) < convert(datetime,'" & oRq.TReqDt & "',103) "
    Sql &= "    and bb.InspectionStatusID = 11 "
    Sql &= "    ) as TotalPausedCalls, "
    'Received Yesterday
    Sql &= "    ( Select Count(bb.RequestID) from qcm_requests as bb "
    Sql &= "    where bb.RegionID = aa.regionID "
    Sql &= "    and bb.CreatedOn = datediff(d,0,dateadd(d,-1, convert(datetime,'" & oRq.TReqDt & "',103))) "
    Sql &= "    and bb.RequestStateID NOT IN ('OPEN','CANCELLED','RETURNED') "
    Sql &= "    ) as ReceivedYesterday, "
    'Attended Yesterday
    Sql &= "    ( Select Count(bb.RequestID) from qcm_requests as bb "
    Sql &= "    where bb.RegionID = aa.regionID "
    Sql &= "    and ( "
    Sql &= "         bb.InspectionStartDate = datediff(d,0,dateadd(d,-1, convert(datetime,'" & oRq.TReqDt & "',103))) "
    Sql &= " 	       or "
    Sql &= " 	       bb.InspectionFinishDate = datediff(d,0,dateadd(d,-1, convert(datetime,'" & oRq.TReqDt & "',103))) "
    Sql &= " 	       or "
    Sql &= " 	       datediff(d,0,dateadd(d,-1, convert(datetime,'" & oRq.TReqDt & "',103))) IN (select datediff(d,0,cc.Inspectedon) as tmpdt from qcm_inspections as cc where cc.requestid=bb.requestid) "
    Sql &= " 	       ) "
    Sql &= "    and bb.RequestStateID IN ('INSPECTED','CLOSED') "
    Sql &= "    ) as AttendedYesterday, "
    'Calls Closed Yesterday
    Sql &= "    ( Select Count(bb.RequestID) from qcm_requests as bb "
    Sql &= "    where bb.RegionID = aa.regionID "
    Sql &= "    and bb.RequestedInspectionStartDate >= dateadd(d,-30,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    and bb.RequestStateID = 'CLOSED' "
    Sql &= "    and datediff(d,0,bb.InspectionFinishDate) = dateadd(d,-1, convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    ) as ClosedYesterday "

    Sql &= " from qcm_requests as aa "
    Sql &= " inner join qcm_regions as bb on aa.regionid=bb.regionid "
    Sql &= " where aa.RequestedInspectionStartDate >= dateadd(d,-30,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= " and aa.RequestStateID NOT IN ('OPEN','CANCELLED','RETURNED') "
    Sql &= " and aa.RegionID is not null "

    If oRq.FUser <> String.Empty Then
      Sql &= " AND aa.AllotedTo = '" & oRq.FUser & "' "
    End If
    If oRq.RegionID <> String.Empty Then
      Sql &= " AND aa.RegionID = " & oRq.RegionID
    End If
    Sql &= " ORDER BY bb.RegionName "

    Dim Results As New List(Of DelayReport)
    Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
      Using Cmd As SqlCommand = Con.CreateCommand()
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = Sql
        Con.Open()
        Dim Reader As SqlDataReader = Cmd.ExecuteReader()
        While (Reader.Read())
          Results.Add(New DelayReport(Reader))
        End While
        Reader.Close()
      End Using
    End Using
    Return Results
  End Function
  Public Class DelayReport
    Public Property RegionID As Integer = 0
    Public Property RegionName As String = ""
    Public Property OnTime As Integer = 0
    Public Property MoreThan4Days As Integer = 0
    Public Property Within4Days As Integer = 0
    Public Property Within2Days As Integer = 0
    Public Property TotalPausedCalls As Integer = 0
    Public Property ClosedYesterday As Integer = 0

    Public Property ReceivedYesterday As Integer = 0
    Public Property AttendedYesterday As Integer = 0
    Public Sub New(ByVal Reader As SqlDataReader)
      Try
        For Each pi As System.Reflection.PropertyInfo In Me.GetType.GetProperties
          If pi.MemberType = Reflection.MemberTypes.Property Then
            Try
              Dim Found As Boolean = False
              For I As Integer = 0 To Reader.FieldCount - 1
                If Reader.GetName(I).ToLower = pi.Name.ToLower Then
                  Found = True
                  Exit For
                End If
              Next
              If Found Then
                If Convert.IsDBNull(Reader(pi.Name)) Then
                  Select Case Reader.GetDataTypeName(Reader.GetOrdinal(pi.Name))
                    Case "decimal"
                      CallByName(Me, pi.Name, CallType.Let, "0.00")
                    Case "bit"
                      CallByName(Me, pi.Name, CallType.Let, Boolean.FalseString)
                    Case Else
                      CallByName(Me, pi.Name, CallType.Let, String.Empty)
                  End Select
                Else
                  CallByName(Me, pi.Name, CallType.Let, Reader(pi.Name))
                End If
              End If
            Catch ex As Exception
            End Try
          End If
        Next
      Catch ex As Exception
      End Try
    End Sub

    Public Sub New()
    End Sub

  End Class

  Private Function CreateLoadReport(ByVal oRec As SIS.VR.vrReports) As String
    Dim FileName As String = Server.MapPath("~/..") & "App_Temp\" & Guid.NewGuid().ToString()
    IO.File.Copy(Server.MapPath("~/App_Templates") & "\LoadReport_Template.xlsx", FileName)
    Dim FileInfo As IO.FileInfo = New IO.FileInfo(FileName)
    Dim xlPk As ExcelPackage = New ExcelPackage(FileInfo)
    Dim xlWS As ExcelWorksheet = xlPk.Workbook.Worksheets("Data")

    Dim oRqs As List(Of LoadReport) = GetLoadReport(oRec)

    Dim r As Integer = 5
    Dim c As Integer = 1
    Dim l As Integer = -1
    With xlWS
      .Cells(3, 3).Value = oRec.TReqDt
      For Each rq As LoadReport In oRqs
        If rq.RegionID = 10 Then
          l = r
          r = 21
        Else
          If l > 0 Then
            r = l
            l = -1
          End If
        End If
        c = 2
        .Cells(r, c).Value = rq.RegionName
        c += 1
        .Cells(r, c).Value = rq.LoadOnTime
        c += 1
        .Cells(r, c).Value = rq.StartedOnTime
        c += 1
        .Cells(r, c).Value = rq.Load12Days
        c += 1
        .Cells(r, c).Value = rq.Started12Days
        c += 1
        .Cells(r, c).Value = rq.Load34Days
        c += 1
        .Cells(r, c).Value = rq.Started34Days
        c += 1
        .Cells(r, c).Value = rq.Load4Days
        c += 1
        .Cells(r, c).Value = rq.Started4Days
        c += 1
        .Cells(r, c).Value = rq.TotalPausedCalls
        c += 1
        .Cells(r, c).Value = rq.Load4Days + rq.Load34Days + rq.Load12Days + rq.LoadOnTime + rq.TotalPausedCalls
        c += 1
        .Cells(r, c).Value = rq.Started4Days + rq.Started34Days + rq.Started12Days + rq.StartedOnTime

        r += 1
      Next
    End With

    Dim LRqs As List(Of SIS.QCM.qcmRequests) = GetRequestList(oRec)
    PrintList(xlWS, LRqs, oRec)



    xlPk.Save()
    xlPk.Dispose()
    Return FileName
  End Function
  Private Function GetLoadReport(ByVal oRq As SIS.VR.vrReports) As List(Of LoadReport)
    oRq.TReqDt = DateAdd(DateInterval.Day, -1, Convert.ToDateTime(oRq.TReqDt)).ToString("dd/MM/yyyy")
    Dim Sql As String = ""
    Sql &= "  select  "
    Sql &= "       Distinct aa.RegionID, bb.RegionName, "
    'Load On Time
    Sql &= "    ( Select Count(bb.RequestID) from qcm_requests as bb "
    Sql &= "    where bb.RegionID = aa.regionID "
    Sql &= "    and bb.RequestedInspectionStartDate = convert(datetime,'" & oRq.TReqDt & "',103) "
    Sql &= "    and (case when bb.InspectionStartDate is null then datediff(d,bb.RequestedInspectionStartDate,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    else datediff(d,bb.RequestedInspectionStartDate, datediff(d,0,bb.InspectionStartDate)) end) < 1   "
    Sql &= "    and (case when bb.InspectionStartDate is null then datediff(d,bb.RequestedInspectionStartDate,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    else datediff(d,bb.RequestedInspectionStartDate, datediff(d,0,bb.InspectionStartDate)) end) >= 0   "
    Sql &= "    and (bb.InspectionStartDate is null or datediff(d,0,bb.InspectionStartDate) >= convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    and bb.RequestStateID NOT IN ('OPEN','CANCELLED','RETURNED') "
    Sql &= "    ) as LoadOnTime, "
    'Started On Time
    Sql &= " 	  ( Select Count(bb.RequestID) from qcm_requests as bb                                          "
    Sql &= " 	  where bb.RegionID = aa.regionID                                                               "
    Sql &= "    and (case when bb.InspectionStartDate is null then datediff(d,bb.RequestedInspectionStartDate,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    else datediff(d,bb.RequestedInspectionStartDate, datediff(d,0,bb.InspectionStartDate)) end) < 1   "
    Sql &= "    and (case when bb.InspectionStartDate is null then datediff(d,bb.RequestedInspectionStartDate,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    else datediff(d,bb.RequestedInspectionStartDate, datediff(d,0,bb.InspectionStartDate)) end) >= 0   "
    Sql &= " 	  and datediff(d,0,bb.InspectionStartDate) = convert(datetime,'" & oRq.TReqDt & "',103) "
    Sql &= " 	  and bb.RequestStateID NOT IN ('OPEN','CANCELLED','RETURNED')  "
    Sql &= " 	  ) as StartedOnTime, "
    'Load 1 to 2 Days
    Sql &= " 	  ( Select Count(bb.RequestID) from qcm_requests as bb                                          "
    Sql &= " 	  where bb.RegionID = aa.regionID                                                               "
    Sql &= "    and bb.RequestedInspectionStartDate >= dateadd(d,-2,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    and bb.RequestedInspectionStartDate < convert(datetime,'" & oRq.TReqDt & "',103) "
    Sql &= "    and (case when bb.InspectionStartDate is null then datediff(d,bb.RequestedInspectionStartDate,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    else datediff(d,bb.RequestedInspectionStartDate, datediff(d,0,bb.InspectionStartDate)) end) <= 2   "
    Sql &= "    and (case when bb.InspectionStartDate is null then datediff(d,bb.RequestedInspectionStartDate,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    else datediff(d,bb.RequestedInspectionStartDate, datediff(d,0,bb.InspectionStartDate)) end) >= 1   "
    Sql &= "    and (bb.InspectionStartDate is null or datediff(d,0,bb.InspectionStartDate) >= convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= " 	  and bb.RequestStateID NOT IN ('OPEN','CANCELLED','RETURNED') "
    Sql &= " 	  ) as Load12Days, "
    'Started 1 to 2 Days
    Sql &= " 	  ( Select Count(bb.RequestID) from qcm_requests as bb  "
    Sql &= " 	  where bb.RegionID = aa.regionID  "
    Sql &= "    and bb.RequestedInspectionStartDate >= dateadd(d,-2,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    and (case when bb.InspectionStartDate is null then datediff(d,bb.RequestedInspectionStartDate,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    else datediff(d,bb.RequestedInspectionStartDate, datediff(d,0,bb.InspectionStartDate)) end) <= 2   "
    Sql &= "    and (case when bb.InspectionStartDate is null then datediff(d,bb.RequestedInspectionStartDate,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    else datediff(d,bb.RequestedInspectionStartDate, datediff(d,0,bb.InspectionStartDate)) end) >= 1   "
    Sql &= " 	  and datediff(d,0,bb.InspectionStartDate) = convert(datetime,'" & oRq.TReqDt & "',103)                               "
    Sql &= " 	  and bb.RequestStateID NOT IN ('OPEN','CANCELLED','RETURNED')  "
    Sql &= " 	  ) as Started12Days, "
    'Load 3 to 4 Days
    Sql &= " 	  ( Select Count(bb.RequestID) from qcm_requests as bb  "
    Sql &= " 	  where bb.RegionID = aa.regionID  "
    Sql &= "    and bb.RequestedInspectionStartDate >= dateadd(d,-4,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    and bb.RequestedInspectionStartDate < convert(datetime,'" & oRq.TReqDt & "',103) "
    Sql &= "    and (case when bb.InspectionStartDate is null then datediff(d,bb.RequestedInspectionStartDate,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    else datediff(d,bb.RequestedInspectionStartDate, datediff(d,0,bb.InspectionStartDate)) end) <= 4   "
    Sql &= "    and (case when bb.InspectionStartDate is null then datediff(d,bb.RequestedInspectionStartDate,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    else datediff(d,bb.RequestedInspectionStartDate, datediff(d,0,bb.InspectionStartDate)) end) >= 3   "
    Sql &= "    and (bb.InspectionStartDate is null or datediff(d,0,bb.InspectionStartDate) >= convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    and bb.RequestStateID NOT IN ('OPEN','CANCELLED','RETURNED') "
    Sql &= " 	  ) as Load34Days,  "
    'Started 3 to 4 Days
    Sql &= " 	  ( Select Count(bb.RequestID) from qcm_requests as bb                                          "
    Sql &= " 	  where bb.RegionID = aa.regionID                                                               "
    Sql &= "    and bb.RequestedInspectionStartDate >= dateadd(d,-4,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    and (case when bb.InspectionStartDate is null then datediff(d,bb.RequestedInspectionStartDate,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    else datediff(d,bb.RequestedInspectionStartDate, datediff(d,0,bb.InspectionStartDate)) end) <= 4   "
    Sql &= "    and (case when bb.InspectionStartDate is null then datediff(d,bb.RequestedInspectionStartDate,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    else datediff(d,bb.RequestedInspectionStartDate, datediff(d,0,bb.InspectionStartDate)) end) >= 3   "
    Sql &= " 	  and datediff(d,0,bb.InspectionStartDate) = convert(datetime,'" & oRq.TReqDt & "',103)                               "
    Sql &= " 	  and bb.RequestStateID NOT IN ('OPEN','CANCELLED','RETURNED')                                  "
    Sql &= " 	  ) as Started34Days,  "
    'Load More than 4 Days
    Sql &= " 	  ( Select Count(bb.RequestID) from qcm_requests as bb                                          "
    Sql &= " 	  where bb.RegionID = aa.regionID                                                               "
    Sql &= "    and bb.RequestedInspectionStartDate >= dateadd(d,-30,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    and bb.RequestedInspectionStartDate < convert(datetime,'" & oRq.TReqDt & "',103) "
    Sql &= "    and (case when bb.InspectionStartDate is null then datediff(d,bb.RequestedInspectionStartDate,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    else datediff(d,bb.RequestedInspectionStartDate, datediff(d,0,bb.InspectionStartDate)) end) > 4   "
    Sql &= "    and (bb.InspectionStartDate is null or dateadd(d,0,bb.InspectionStartDate) >= convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    and bb.RequestStateID NOT IN ('OPEN','CANCELLED','RETURNED') "
    Sql &= " 	  ) as Load4Days, "
    'Started More Than 4 Days
    Sql &= " 	  ( Select Count(bb.RequestID) from qcm_requests as bb                                          "
    Sql &= " 	  where bb.RegionID = aa.regionID                                                               "
    Sql &= "    and bb.RequestedInspectionStartDate >= dateadd(d,-30,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    and (case when bb.InspectionStartDate is null then datediff(d,bb.RequestedInspectionStartDate,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    else datediff(d,bb.RequestedInspectionStartDate, datediff(d,0,bb.InspectionStartDate)) end) > 4   "
    Sql &= " 	  and datediff(d,0,bb.InspectionStartDate) = convert(datetime,'" & oRq.TReqDt & "',103)                               "
    Sql &= " 	  and bb.RequestStateID NOT IN ('OPEN','CANCELLED','RETURNED')                                  "
    Sql &= " 	  ) as Started4Days, "
    'Total Paused Calls of Last 30 Days
    Sql &= "    ( Select Count(bb.RequestID) from qcm_requests as bb "
    Sql &= "    where bb.RegionID = aa.regionID "
    Sql &= "    and bb.RequestedInspectionStartDate >= dateadd(d,-30,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "    and datediff(d,0,bb.LastPausedOn) < convert(datetime,'" & oRq.TReqDt & "',103) "
    Sql &= "    and bb.InspectionStatusID = 11 "
    Sql &= "    ) as TotalPausedCalls "

    Sql &= " from qcm_requests as aa                                                                          "
    Sql &= " inner join qcm_regions as bb on aa.regionid=bb.regionid                                          "
    Sql &= " where aa.RequestedInspectionStartDate >= dateadd(d,-30,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= " and aa.RequestStateID NOT IN ('OPEN','CANCELLED','RETURNED')                                     "
    Sql &= " and aa.RegionID is not null                                                                      "

    If oRq.FUser <> String.Empty Then
      Sql &= " AND aa.AllotedTo = '" & oRq.FUser & "' "
    End If
    If oRq.RegionID <> String.Empty Then
      Sql &= " AND aa.RegionID = " & oRq.RegionID
    End If
    Sql &= " ORDER BY bb.RegionName "

    Dim Results As New List(Of LoadReport)
    Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
      Using Cmd As SqlCommand = Con.CreateCommand()
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = Sql
        Con.Open()
        Dim Reader As SqlDataReader = Cmd.ExecuteReader()
        While (Reader.Read())
          Results.Add(New LoadReport(Reader))
        End While
        Reader.Close()
      End Using
    End Using
    Return Results
  End Function
  Public Class LoadReport
    Public Property RegionID As Integer = 0
    Public Property RegionName As String = ""
    Public Property LoadOnTime As Integer = 0
    Public Property StartedOnTime As Integer = 0
    Public Property Load12Days As Integer = 0
    Public Property Started12Days As Integer = 0
    Public Property Load34Days As Integer = 0
    Public Property Started34Days As Integer = 0
    Public Property Load4Days As Integer = 0
    Public Property Started4Days As Integer = 0
    Public Property TotalPausedCalls As Integer = 0

    Public Sub New(ByVal Reader As SqlDataReader)
      Try
        For Each pi As System.Reflection.PropertyInfo In Me.GetType.GetProperties
          If pi.MemberType = Reflection.MemberTypes.Property Then
            Try
              Dim Found As Boolean = False
              For I As Integer = 0 To Reader.FieldCount - 1
                If Reader.GetName(I).ToLower = pi.Name.ToLower Then
                  Found = True
                  Exit For
                End If
              Next
              If Found Then
                If Convert.IsDBNull(Reader(pi.Name)) Then
                  Select Case Reader.GetDataTypeName(Reader.GetOrdinal(pi.Name))
                    Case "decimal"
                      CallByName(Me, pi.Name, CallType.Let, "0.00")
                    Case "bit"
                      CallByName(Me, pi.Name, CallType.Let, Boolean.FalseString)
                    Case Else
                      CallByName(Me, pi.Name, CallType.Let, String.Empty)
                  End Select
                Else
                  CallByName(Me, pi.Name, CallType.Let, Reader(pi.Name))
                End If
              End If
            Catch ex As Exception
            End Try
          End If
        Next
      Catch ex As Exception
      End Try
    End Sub

    Public Sub New()
    End Sub

  End Class

  Private Function GetRequestList(ByVal oRq As SIS.VR.vrReports) As List(Of SIS.QCM.qcmRequests)
    Dim Sql As String = ""
    Sql &= "  SELECT"
    Sql &= "		[QCM_Requests].* ,"
    Sql &= "		[HRM_Employees1].[EmployeeName] AS HRM_Employees1_EmployeeName,"
    Sql &= "		[HRM_Employees2].[UserFullName] AS HRM_Employees2_EmployeeName,"
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
    Sql &= "  LEFT OUTER JOIN [aspnet_users] AS [HRM_Employees2]"
    Sql &= "    ON [QCM_Requests].[AllotedTo] = [HRM_Employees2].[LoginID]"
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
    Sql &= "  [QCM_Requests].[RequestedInspectionStartDate] >= dateadd(d,-30,convert(datetime,'" & oRq.TReqDt & "',103)) "
    Sql &= "  AND [QCM_Requests].[RequestedInspectionStartDate] <= convert(datetime,'" & oRq.TReqDt & "',103)"
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

  Private Sub PrintList(xlWS As ExcelWorksheet, LRqs As List(Of SIS.QCM.qcmRequests), oRec As SIS.VR.vrReports)
    Dim c As Integer = 0
    Dim r As Integer = 25
    With xlWS

      For Each rq As SIS.QCM.qcmRequests In LRqs
        c = 2
        .Cells(r, c).Value = rq.RequestID
        c += 1
        .Cells(r, c).Value = rq.RequestedInspectionStartDate
        c += 1
        .Cells(r, c).Value = IIf(rq.InspectionStartDate <> "", Left(rq.InspectionStartDate, 10), "")
        c += 1
        .Cells(r, c).Value = IIf(rq.InspectionFinishDate <> "", Left(rq.InspectionFinishDate, 10), "")
        c += 1
        .Cells(r, c).Value = rq.QCM_Regions12_RegionName
        c += 1
        Dim Days As Integer = 0
        If rq.InspectionStartDate <> String.Empty Then
          Days = DateDiff(DateInterval.Day, Convert.ToDateTime(rq.RequestedInspectionStartDate), Convert.ToDateTime(Left(rq.InspectionStartDate, 10)))
        Else
          Days = DateDiff(DateInterval.Day, Convert.ToDateTime(rq.RequestedInspectionStartDate), Convert.ToDateTime(oRec.TReqDt))
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
        .Cells(r, c).Value = IIf(rq.Paused, "YES", "NO")
        c += 1
        .Cells(r, c).Value = rq.ProjectID
        c += 1
        .Cells(r, c).Value = rq.IDM_Projects6_Description
        c += 1
        .Cells(r, c).Value = rq.IDM_Vendors7_Description
        c += 1
        r += 1
      Next
    End With

  End Sub

End Class
