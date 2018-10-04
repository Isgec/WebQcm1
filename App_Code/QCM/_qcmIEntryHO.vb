Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.QCM
  <DataObject()> _
  Partial Public Class qcmIEntryHO
    Inherits SIS.QCM.qcmRequests
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmIEntryHOGetNewRecord() As SIS.QCM.qcmIEntryHO
      Return New SIS.QCM.qcmIEntryHO()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmIEntryHOSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal ProjectID As String, ByVal SupplierID As String, ByVal RequestStateID As String, ByVal InspectionStatusID As Int32) As List(Of SIS.QCM.qcmIEntryHO)
      Dim Results As List(Of SIS.QCM.qcmIEntryHO) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "RequestID DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spqcmIEntryHOSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spqcmIEntryHOSelectListFilteres"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_ProjectID",SqlDbType.NVarChar,6, IIf(ProjectID Is Nothing, String.Empty,ProjectID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_SupplierID", SqlDbType.NVarChar, 9, IIf(SupplierID Is Nothing, String.Empty, SupplierID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_RequestStateID",SqlDbType.NVarChar,10, IIf(RequestStateID Is Nothing, String.Empty,RequestStateID))
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_InspectionStatusID",SqlDbType.Int,10, IIf(InspectionStatusID = Nothing, 0,InspectionStatusID))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          RecordCount = -1
          Results = New List(Of SIS.QCM.qcmIEntryHO)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCM.qcmIEntryHO(Reader))
          End While
          Reader.Close()
          RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function qcmIEntryHOSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal ProjectID As String, ByVal SupplierID As String, ByVal RequestStateID As String, ByVal InspectionStatusID As Int32) As Integer
      Return RecordCount
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmIEntryHOGetByID(ByVal RequestID As Int32) As SIS.QCM.qcmIEntryHO
      Dim Results As SIS.QCM.qcmIEntryHO = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmRequestsSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RequestID",SqlDbType.Int,RequestID.ToString.Length, RequestID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
					If Reader.Read() Then
						Results = New SIS.QCM.qcmIEntryHO(Reader)
					End If
					Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmIEntryHOGetByID(ByVal RequestID As Int32, ByVal Filter_ProjectID As String, ByVal Filter_SupplierID As String, ByVal Filter_RequestStateID As String, ByVal Filter_InspectionStatusID As Int32) As SIS.QCM.qcmIEntryHO
      Dim Results As SIS.QCM.qcmIEntryHO = SIS.QCM.qcmIEntryHO.qcmIEntryHOGetByID(RequestID)
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function qcmIEntryHOUpdate(ByVal Record As SIS.QCM.qcmIEntryHO) As SIS.QCM.qcmIEntryHO
      Dim _Rec As SIS.QCM.qcmIEntryHO = SIS.QCM.qcmIEntryHO.qcmIEntryHOGetByID(Record.RequestID)
      With _Rec
        .RequestStateID = "INSPECTED"
        .AllotedTo = Record.AllotedTo
        .AllotedStartDate = Record.AllotedStartDate
        .AllotedFinishDate = Record.AllotedFinishDate
        .AllotedOn = Now
        .AllotedBy = Global.System.Web.HttpContext.Current.Session("LoginID")
        .AllotmentRemarks = Record.AllotmentRemarks
      End With
      Return SIS.QCM.qcmIEntryHO.UpdateData(_Rec)
    End Function
    Public Sub New(ByVal Reader As SqlDataReader)
      MyBase.New(Reader)
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
