Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.QCM
  Partial Public Class qcmIEntryHO
    Public Shared Function UZ_qcmIEntryFieldSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal ProjectID As String, ByVal SupplierID As String, ByVal RequestStateID As String, ByVal InspectionStatusID As Int32, ByVal AllotedTo As String) As List(Of SIS.QCM.qcmIEntryHO)
      Dim Results As List(Of SIS.QCM.qcmIEntryHO) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "RequestID DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spqcm_LG_IEntryFieldSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spqcm_LG_IEntryFieldSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_ProjectID", SqlDbType.NVarChar, 6, IIf(ProjectID Is Nothing, String.Empty, ProjectID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_SupplierID", SqlDbType.NVarChar, 9, IIf(SupplierID Is Nothing, String.Empty, SupplierID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_RequestStateID", SqlDbType.NVarChar, 10, IIf(RequestStateID Is Nothing, String.Empty, RequestStateID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_InspectionStatusID", SqlDbType.Int, 10, IIf(InspectionStatusID = Nothing, 0, InspectionStatusID))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
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
    Public Shared Function UZ_qcmIEntryHOSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal ProjectID As String, ByVal SupplierID As String, ByVal RequestStateID As String, ByVal InspectionStatusID As Int32, ByVal AllotedTo As String) As List(Of SIS.QCM.qcmIEntryHO)
      Dim Results As List(Of SIS.QCM.qcmIEntryHO) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          If OrderBy = String.Empty Then OrderBy = "RequestID DESC"
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spqcm_LG_IEntryHOSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spqcm_LG_IEntryHOSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_ProjectID", SqlDbType.NVarChar, 6, IIf(ProjectID Is Nothing, String.Empty, ProjectID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_AllotedTo", SqlDbType.NVarChar, 8, IIf(AllotedTo Is Nothing, String.Empty, AllotedTo))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_SupplierID", SqlDbType.NVarChar, 9, IIf(SupplierID Is Nothing, String.Empty, SupplierID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_RequestStateID", SqlDbType.NVarChar, 10, IIf(RequestStateID Is Nothing, String.Empty, RequestStateID))
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_InspectionStatusID", SqlDbType.Int, 10, IIf(InspectionStatusID = Nothing, 0, InspectionStatusID))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
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
    Public Shared Function qcmIEntryHOSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal ProjectID As String, ByVal SupplierID As String, ByVal RequestStateID As String, ByVal InspectionStatusID As Int32, ByVal AllotedTo As String) As Integer
			Return RecordCount
		End Function
		Public Shared Function UZ_qcmIEntryHOUpdate(ByVal Record As SIS.QCM.qcmIEntryHO) As SIS.QCM.qcmIEntryHO
			Dim _Result As SIS.QCM.qcmIEntryHO = qcmIEntryHOUpdate(Record)
			Return _Result
		End Function
		Public ReadOnly Property CloseVisible() As Boolean
			Get
				If RequestStateID = "INSPECTED" Then
					Return True
				End If
				Return False
			End Get
		End Property
  End Class
End Namespace
