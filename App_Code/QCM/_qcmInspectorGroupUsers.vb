Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.QCM
  <DataObject()> _
  Partial Public Class qcmInspectorGroupUsers
    Private Shared _RecordCount As Integer
    Private _GroupID As Int32 = 0
    Private _CardNo As String = ""
    Private _HRM_Employees1_EmployeeName As String = ""
    Private _QCM_InspectorGroups2_Description As String = ""
    Private _FK_QCM_IGU_CardNo As SIS.QCM.qcmEmployees = Nothing
    Private _FK_QCM_IGU_GroupID As SIS.QCM.qcmInspectorGroups = Nothing
    Public ReadOnly Property ForeColor() As System.Drawing.Color
      Get
        Dim mRet As System.Drawing.Color = Drawing.Color.Blue
        Try
					mRet = GetColor()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property Visible() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
					mRet = GetVisible()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property Enable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
					mRet = GetEnable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Property GroupID() As Int32
      Get
        Return _GroupID
      End Get
      Set(ByVal value As Int32)
        _GroupID = value
      End Set
    End Property
    Public Property CardNo() As String
      Get
        Return _CardNo
      End Get
      Set(ByVal value As String)
        _CardNo = value
      End Set
    End Property
    Public Property HRM_Employees1_EmployeeName() As String
      Get
        Return _HRM_Employees1_EmployeeName
      End Get
      Set(ByVal value As String)
        _HRM_Employees1_EmployeeName = value
      End Set
    End Property
    Public Property QCM_InspectorGroups2_Description() As String
      Get
        Return _QCM_InspectorGroups2_Description
      End Get
      Set(ByVal value As String)
        _QCM_InspectorGroups2_Description = value
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return ""
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _GroupID & "|" & _CardNo
      End Get
    End Property
    Public Shared Property RecordCount() As Integer
      Get
        Return _RecordCount
      End Get
      Set(ByVal value As Integer)
        _RecordCount = value
      End Set
    End Property
    Public Class PKqcmInspectorGroupUsers
			Private _GroupID As Int32 = 0
			Private _CardNo As String = ""
			Public Property GroupID() As Int32
				Get
					Return _GroupID
				End Get
				Set(ByVal value As Int32)
					_GroupID = value
				End Set
			End Property
			Public Property CardNo() As String
				Get
					Return _CardNo
				End Get
				Set(ByVal value As String)
					_CardNo = value
				End Set
			End Property
    End Class
    Public ReadOnly Property FK_QCM_IGU_CardNo() As SIS.QCM.qcmEmployees
      Get
        If _FK_QCM_IGU_CardNo Is Nothing Then
          _FK_QCM_IGU_CardNo = SIS.QCM.qcmEmployees.qcmEmployeesGetByID(_CardNo)
        End If
        Return _FK_QCM_IGU_CardNo
      End Get
    End Property
    Public ReadOnly Property FK_QCM_IGU_GroupID() As SIS.QCM.qcmInspectorGroups
      Get
        If _FK_QCM_IGU_GroupID Is Nothing Then
          _FK_QCM_IGU_GroupID = SIS.QCM.qcmInspectorGroups.qcmInspectorGroupsGetByID(_GroupID)
        End If
        Return _FK_QCM_IGU_GroupID
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmInspectorGroupUsersGetNewRecord() As SIS.QCM.qcmInspectorGroupUsers
      Return New SIS.QCM.qcmInspectorGroupUsers()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmInspectorGroupUsersGetByID(ByVal GroupID As Int32, ByVal CardNo As String) As SIS.QCM.qcmInspectorGroupUsers
      Dim Results As SIS.QCM.qcmInspectorGroupUsers = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetToolsConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmInspectorGroupUsersSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@GroupID", SqlDbType.Int, GroupID.ToString.Length, GroupID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CardNo", SqlDbType.NVarChar, CardNo.ToString.Length, CardNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.QCM.qcmInspectorGroupUsers(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function GetByGroupID(ByVal GroupID As Int32, ByVal OrderBy As String) As List(Of SIS.QCM.qcmInspectorGroupUsers)
      Dim Results As List(Of SIS.QCM.qcmInspectorGroupUsers) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetToolsConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmInspectorGroupUsersSelectByGroupID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@GroupID", SqlDbType.Int, GroupID.ToString.Length, GroupID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.QCM.qcmInspectorGroupUsers)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCM.qcmInspectorGroupUsers(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function GetByCardNo(ByVal CardNo As String, ByVal OrderBy As String) As List(Of SIS.QCM.qcmInspectorGroupUsers)
      Dim Results As List(Of SIS.QCM.qcmInspectorGroupUsers) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetToolsConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmInspectorGroupUsersSelectByCardNo"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CardNo", SqlDbType.NVarChar, CardNo.ToString.Length, CardNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.QCM.qcmInspectorGroupUsers)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCM.qcmInspectorGroupUsers(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function qcmInspectorGroupUsersSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal GroupID As Int32) As List(Of SIS.QCM.qcmInspectorGroupUsers)
      Dim Results As List(Of SIS.QCM.qcmInspectorGroupUsers) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetToolsConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spqcmInspectorGroupUsersSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spqcmInspectorGroupUsersSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_GroupID", SqlDbType.Int, 10, IIf(GroupID = Nothing, 0, GroupID))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.QCM.qcmInspectorGroupUsers)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCM.qcmInspectorGroupUsers(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function qcmInspectorGroupUsersSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal GroupID As Int32) As Integer
      Return _RecordCount
    End Function
    'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function qcmInspectorGroupUsersGetByID(ByVal GroupID As Int32, ByVal CardNo As String, ByVal Filter_GroupID As Int32) As SIS.QCM.qcmInspectorGroupUsers
      Return qcmInspectorGroupUsersGetByID(GroupID, CardNo)
    End Function
    <DataObjectMethod(DataObjectMethodType.Insert, True)>
    Public Shared Function qcmInspectorGroupUsersInsert(ByVal Record As SIS.QCM.qcmInspectorGroupUsers) As SIS.QCM.qcmInspectorGroupUsers
      Dim _Rec As SIS.QCM.qcmInspectorGroupUsers = SIS.QCM.qcmInspectorGroupUsers.qcmInspectorGroupUsersGetNewRecord()
      With _Rec
        .GroupID = Record.GroupID
        .CardNo = Record.CardNo
      End With
      Return SIS.QCM.qcmInspectorGroupUsers.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.QCM.qcmInspectorGroupUsers) As SIS.QCM.qcmInspectorGroupUsers
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetToolsConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmInspectorGroupUsersInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@GroupID", SqlDbType.Int, 11, Record.GroupID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CardNo", SqlDbType.NVarChar, 9, Record.CardNo)
          Cmd.Parameters.Add("@Return_GroupID", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_GroupID").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_CardNo", SqlDbType.NVarChar, 9)
          Cmd.Parameters("@Return_CardNo").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.GroupID = Cmd.Parameters("@Return_GroupID").Value
          Record.CardNo = Cmd.Parameters("@Return_CardNo").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)>
    Public Shared Function qcmInspectorGroupUsersUpdate(ByVal Record As SIS.QCM.qcmInspectorGroupUsers) As SIS.QCM.qcmInspectorGroupUsers
      Dim _Rec As SIS.QCM.qcmInspectorGroupUsers = SIS.QCM.qcmInspectorGroupUsers.qcmInspectorGroupUsersGetByID(Record.GroupID, Record.CardNo)
      With _Rec
      End With
      Return SIS.QCM.qcmInspectorGroupUsers.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.QCM.qcmInspectorGroupUsers) As SIS.QCM.qcmInspectorGroupUsers
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetToolsConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmInspectorGroupUsersUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_GroupID", SqlDbType.Int, 11, Record.GroupID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_CardNo", SqlDbType.NVarChar, 9, Record.CardNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@GroupID", SqlDbType.Int, 11, Record.GroupID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@CardNo", SqlDbType.NVarChar, 9, Record.CardNo)
          Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Con.Open()
          Cmd.ExecuteNonQuery()
          _RecordCount = Cmd.Parameters("@RowCount").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Delete, True)>
    Public Shared Function Delete(ByVal Record As SIS.QCM.qcmInspectorGroupUsers) As Int32
      Dim _Result As Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetToolsConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmInspectorGroupUsersDelete"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_GroupID", SqlDbType.Int, Record.GroupID.ToString.Length, Record.GroupID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_CardNo", SqlDbType.NVarChar, Record.CardNo.ToString.Length, Record.CardNo)
          Cmd.Parameters.Add("@RowCount", SqlDbType.Int)
          Cmd.Parameters("@RowCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Con.Open()
          Cmd.ExecuteNonQuery()
          _RecordCount = Cmd.Parameters("@RowCount").Value
        End Using
      End Using
      Return _RecordCount
		End Function
    Public Sub New(ByVal Reader As SqlDataReader)
      On Error Resume Next
      _GroupID = Ctype(Reader("GroupID"),Int32)
      _CardNo = Ctype(Reader("CardNo"),String)
      _HRM_Employees1_EmployeeName = Ctype(Reader("HRM_Employees1_EmployeeName"),String)
      _QCM_InspectorGroups2_Description = Ctype(Reader("QCM_InspectorGroups2_Description"),String)
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
