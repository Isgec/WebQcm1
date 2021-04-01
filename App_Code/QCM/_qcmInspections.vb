Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.QCM
  <DataObject()> _
  Partial Public Class qcmInspections
    Private Shared _RecordCount As Integer
    Private _RequestID As Int32 = 0
    Private _InspectionID As Int32 = 0
    Private _ProjectID As String = ""
    Private _OrderNo As String = ""
    Private _OrderDate As String = ""
    Private _SupplierID As String = ""
    Private _InspectionRemarks As String = ""
    Private _InspectedBy As String = ""
    Private _InspectedOn As String = ""
    Private _RequestStateID As String = ""
    Private _FileAttached As Boolean = False
    Private _InspectionStatusID As String = ""
    Private _InspectedQuantity As String = ""
    Private _InspectionStageiD As String = ""
    Private _EnteredBy As String = ""
    Private _EnteredOn As String = ""
    Private _OfferedQuantity As String = ""
    Private _ClearedQuantity As String = ""
    Private _UOM As String = ""
    Private _InspectedQuantityFinal As String = ""
    Private _OfferedQuantityFinal As String = ""
    Private _ClearedQuantityFinal As String = ""
    Private _HRM_Employees1_EmployeeName As String = ""
    Private _IDM_Projects2_Description As String = ""
    Private _IDM_Vendors3_Description As String = ""
    Private _QCM_InspectionStages4_Description As String = ""
    Private _QCM_InspectionStatus5_Description As String = ""
    Private _QCM_RequestStates6_Description As String = ""
    Private _HRM_Employees7_EmployeeName As String = ""
    Private _QCM_Requests8_Description As String = ""
    Private _FK_QCM_Inspections_InspectedBy As SIS.QCM.qcmUsers = Nothing
    Private _FK_QCM_Inspections_ProjectID As SIS.QCM.qcmProjects = Nothing
    Private _FK_QCM_Inspections_SupplierID As SIS.QCM.qcmVendors = Nothing
    Private _FK_QCM_Inspections_InspectionStageID As SIS.QCM.qcmInspectionStages = Nothing
    Private _FK_QCM_Inspections_InspectionStateID As SIS.QCM.qcmInspectionStatus = Nothing
    Private _FK_QCM_Inspections_RequestStateID As SIS.QCM.qcmRequestStates = Nothing
    Private _FK_QCM_Inspections_EnteredBy As SIS.QCM.qcmUsers = Nothing
    Private _FK_QCM_Inspections_RequestID As SIS.QCM.qcmRequests = Nothing
    Public Property Company As String = ""
    Public Property AttendedVirtually As Boolean = False

    Public Property InspectedQuantityFinal() As String
      Get
        Return _InspectedQuantityFinal
      End Get
      Set(ByVal value As String)
        If Convert.IsDBNull(value) Then
          _InspectedQuantityFinal = ""
        Else
          _InspectedQuantityFinal = value
        End If
      End Set
    End Property
    Public Property OfferedQuantityFinal As String
      Get
        Return _OfferedQuantityFinal
      End Get
      Set(value As String)
        If Convert.IsDBNull(value) Then
          _OfferedQuantityFinal = ""
        Else
          _OfferedQuantityFinal = value
        End If
      End Set
    End Property
    Public Property ClearedQuantityFinal As String
      Get
        Return _ClearedQuantityFinal
      End Get
      Set(value As String)
        If Convert.IsDBNull(value) Then
          _ClearedQuantityFinal = ""
        Else
          _ClearedQuantityFinal = value
        End If
      End Set
    End Property

    Public Property OfferedQuantity As String
      Get
        Return _OfferedQuantity
      End Get
      Set(value As String)
        If Convert.IsDBNull(value) Then
          _OfferedQuantity = ""
        Else
          _OfferedQuantity = value
        End If
      End Set
    End Property
    Public Property ClearedQuantity As String
      Get
        Return _ClearedQuantity
      End Get
      Set(value As String)
        If Convert.IsDBNull(value) Then
          _ClearedQuantity = ""
        Else
          _ClearedQuantity = value
        End If
      End Set
    End Property
    Public Property UOM As String
      Get
        Return _UOM
      End Get
      Set(value As String)
        If Convert.IsDBNull(value) Then
          _UOM = ""
        Else
          _UOM = value
        End If
      End Set
    End Property
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
    Public Property RequestID() As Int32
      Get
        Return _RequestID
      End Get
      Set(ByVal value As Int32)
        _RequestID = value
      End Set
    End Property
    Public Property InspectionID() As Int32
      Get
        Return _InspectionID
      End Get
      Set(ByVal value As Int32)
        _InspectionID = value
      End Set
    End Property
    Public Property ProjectID() As String
      Get
        Return _ProjectID
      End Get
      Set(ByVal value As String)
        _ProjectID = value
      End Set
    End Property
    Public Property OrderNo() As String
      Get
        Return _OrderNo
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _OrderNo = ""
				 Else
					 _OrderNo = value
			   End If
      End Set
    End Property
    Public Property OrderDate() As String
      Get
        If Not _OrderDate = String.Empty Then
          Return Convert.ToDateTime(_OrderDate).ToString("dd/MM/yyyy")
        End If
        Return _OrderDate
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _OrderDate = ""
				 Else
					 _OrderDate = value
			   End If
      End Set
    End Property
    Public Property SupplierID() As String
      Get
        Return _SupplierID
      End Get
      Set(ByVal value As String)
        _SupplierID = value
      End Set
    End Property
    Public Property InspectionRemarks() As String
      Get
        Return _InspectionRemarks
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _InspectionRemarks = ""
				 Else
					 _InspectionRemarks = value
			   End If
      End Set
    End Property
    Public Property InspectedBy() As String
      Get
        Return _InspectedBy
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _InspectedBy = ""
				 Else
					 _InspectedBy = value
			   End If
      End Set
    End Property
    Public Property InspectedOn() As String
      Get
        If Not _InspectedOn = String.Empty Then
          Return Convert.ToDateTime(_InspectedOn).ToString("dd/MM/yyyy HH:mm")
        End If
        Return _InspectedOn
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _InspectedOn = ""
				 Else
					 _InspectedOn = value
			   End If
      End Set
    End Property
    Public Property RequestStateID() As String
      Get
        Return _RequestStateID
      End Get
      Set(ByVal value As String)
        _RequestStateID = value
      End Set
    End Property
    Public Property FileAttached() As Boolean
      Get
        Return _FileAttached
      End Get
      Set(ByVal value As Boolean)
        _FileAttached = value
      End Set
    End Property
    Public Property InspectionStatusID() As String
      Get
        Return _InspectionStatusID
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _InspectionStatusID = ""
				 Else
					 _InspectionStatusID = value
			   End If
      End Set
    End Property
    Public Property InspectedQuantity() As String
      Get
        Return _InspectedQuantity
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _InspectedQuantity = ""
				 Else
					 _InspectedQuantity = value
			   End If
      End Set
    End Property
    Public Property InspectionStageiD() As String
      Get
        Return _InspectionStageiD
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _InspectionStageiD = ""
				 Else
					 _InspectionStageiD = value
			   End If
      End Set
    End Property
    Public Property EnteredBy() As String
      Get
        Return _EnteredBy
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _EnteredBy = ""
				 Else
					 _EnteredBy = value
			   End If
      End Set
    End Property
    Public Property EnteredOn() As String
      Get
        If Not _EnteredOn = String.Empty Then
          Return Convert.ToDateTime(_EnteredOn).ToString("dd/MM/yyyy")
        End If
        Return _EnteredOn
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _EnteredOn = ""
				 Else
					 _EnteredOn = value
			   End If
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
    Public Property IDM_Projects2_Description() As String
      Get
        Return _IDM_Projects2_Description
      End Get
      Set(ByVal value As String)
        _IDM_Projects2_Description = value
      End Set
    End Property
    Public Property IDM_Vendors3_Description() As String
      Get
        Return _IDM_Vendors3_Description
      End Get
      Set(ByVal value As String)
        _IDM_Vendors3_Description = value
      End Set
    End Property
    Public Property QCM_InspectionStages4_Description() As String
      Get
        Return _QCM_InspectionStages4_Description
      End Get
      Set(ByVal value As String)
        _QCM_InspectionStages4_Description = value
      End Set
    End Property
    Public Property QCM_InspectionStatus5_Description() As String
      Get
        Return _QCM_InspectionStatus5_Description
      End Get
      Set(ByVal value As String)
        _QCM_InspectionStatus5_Description = value
      End Set
    End Property
    Public Property QCM_RequestStates6_Description() As String
      Get
        Return _QCM_RequestStates6_Description
      End Get
      Set(ByVal value As String)
        _QCM_RequestStates6_Description = value
      End Set
    End Property
    Public Property HRM_Employees7_EmployeeName() As String
      Get
        Return _HRM_Employees7_EmployeeName
      End Get
      Set(ByVal value As String)
        _HRM_Employees7_EmployeeName = value
      End Set
    End Property
    Public Property QCM_Requests8_Description() As String
      Get
        Return _QCM_Requests8_Description
      End Get
      Set(ByVal value As String)
        _QCM_Requests8_Description = value
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return ""
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _RequestID & "|" & _InspectionID
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
    Public Class PKqcmInspections
			Private _RequestID As Int32 = 0
			Private _InspectionID As Int32 = 0
			Public Property RequestID() As Int32
				Get
					Return _RequestID
				End Get
				Set(ByVal value As Int32)
					_RequestID = value
				End Set
			End Property
			Public Property InspectionID() As Int32
				Get
					Return _InspectionID
				End Get
				Set(ByVal value As Int32)
					_InspectionID = value
				End Set
			End Property
    End Class
    Public ReadOnly Property FK_QCM_Inspections_InspectedBy() As SIS.QCM.qcmUsers
      Get
        If _FK_QCM_Inspections_InspectedBy Is Nothing Then
          _FK_QCM_Inspections_InspectedBy = SIS.QCM.qcmUsers.qcmUsersGetByID(_InspectedBy)
        End If
        Return _FK_QCM_Inspections_InspectedBy
      End Get
    End Property
    Public ReadOnly Property FK_QCM_Inspections_ProjectID() As SIS.QCM.qcmProjects
      Get
        If _FK_QCM_Inspections_ProjectID Is Nothing Then
          _FK_QCM_Inspections_ProjectID = SIS.QCM.qcmProjects.qcmProjectsGetByID(_ProjectID)
        End If
        Return _FK_QCM_Inspections_ProjectID
      End Get
    End Property
    Public ReadOnly Property FK_QCM_Inspections_SupplierID() As SIS.QCM.qcmVendors
      Get
        If _FK_QCM_Inspections_SupplierID Is Nothing Then
          _FK_QCM_Inspections_SupplierID = SIS.QCM.qcmVendors.qcmVendorsGetByID(_SupplierID)
        End If
        Return _FK_QCM_Inspections_SupplierID
      End Get
    End Property
    Public ReadOnly Property FK_QCM_Inspections_InspectionStageID() As SIS.QCM.qcmInspectionStages
      Get
        If _FK_QCM_Inspections_InspectionStageID Is Nothing Then
          _FK_QCM_Inspections_InspectionStageID = SIS.QCM.qcmInspectionStages.qcmInspectionStagesGetByID(_InspectionStageiD)
        End If
        Return _FK_QCM_Inspections_InspectionStageID
      End Get
    End Property
    Public ReadOnly Property FK_QCM_Inspections_InspectionStateID() As SIS.QCM.qcmInspectionStatus
      Get
        If _FK_QCM_Inspections_InspectionStateID Is Nothing Then
          _FK_QCM_Inspections_InspectionStateID = SIS.QCM.qcmInspectionStatus.qcmInspectionStatusGetByID(_InspectionStatusID)
        End If
        Return _FK_QCM_Inspections_InspectionStateID
      End Get
    End Property
    Public ReadOnly Property FK_QCM_Inspections_RequestStateID() As SIS.QCM.qcmRequestStates
      Get
        If _FK_QCM_Inspections_RequestStateID Is Nothing Then
          _FK_QCM_Inspections_RequestStateID = SIS.QCM.qcmRequestStates.qcmRequestStatesGetByID(_RequestStateID)
        End If
        Return _FK_QCM_Inspections_RequestStateID
      End Get
    End Property
    Public ReadOnly Property FK_QCM_Inspections_EnteredBy() As SIS.QCM.qcmUsers
      Get
        If _FK_QCM_Inspections_EnteredBy Is Nothing Then
          _FK_QCM_Inspections_EnteredBy = SIS.QCM.qcmUsers.qcmUsersGetByID(_EnteredBy)
        End If
        Return _FK_QCM_Inspections_EnteredBy
      End Get
    End Property
    Public ReadOnly Property FK_QCM_Inspections_RequestID() As SIS.QCM.qcmRequests
      Get
        If _FK_QCM_Inspections_RequestID Is Nothing Then
          _FK_QCM_Inspections_RequestID = SIS.QCM.qcmRequests.qcmRequestsGetByID(_RequestID)
        End If
        Return _FK_QCM_Inspections_RequestID
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmInspectionsGetNewRecord() As SIS.QCM.qcmInspections
      Return New SIS.QCM.qcmInspections()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function qcmInspectionsGetByID(ByVal RequestID As Int32, ByVal InspectionID As Int32) As SIS.QCM.qcmInspections
      Dim Results As SIS.QCM.qcmInspections = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmInspectionsSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RequestID", SqlDbType.Int, RequestID.ToString.Length, RequestID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectionID", SqlDbType.Int, InspectionID.ToString.Length, InspectionID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.QCM.qcmInspections(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function qcmInspectionsGetByID(ByVal RequestID As Int32, ByVal InspectionID As Int32, ByVal Filter_RequestID As Int32) As SIS.QCM.qcmInspections
      Return qcmInspectionsGetByID(RequestID, InspectionID)
    End Function
    Public Shared Function qcmInspectionsGetByIDComp(ByVal RequestID As Int32, ByVal InspectionID As Int32, ByVal comp As String) As SIS.QCM.qcmInspections
      Dim Results As SIS.QCM.qcmInspections = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString(comp))
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmInspectionsSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RequestID", SqlDbType.Int, RequestID.ToString.Length, RequestID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectionID", SqlDbType.Int, InspectionID.ToString.Length, InspectionID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.QCM.qcmInspections(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function GetByRequestID(ByVal RequestID As Int32, ByVal OrderBy As String) As List(Of SIS.QCM.qcmInspections)
      Dim Results As List(Of SIS.QCM.qcmInspections) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmInspectionsSelectByRequestID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RequestID", SqlDbType.Int, RequestID.ToString.Length, RequestID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.QCM.qcmInspections)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCM.qcmInspections(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetByProjectID(ByVal ProjectID As String, ByVal OrderBy as String) As List(Of SIS.QCM.qcmInspections)
      Dim Results As List(Of SIS.QCM.qcmInspections) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmInspectionsSelectByProjectID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,ProjectID.ToString.Length, ProjectID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.QCM.qcmInspections)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCM.qcmInspections(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetBySupplierID(ByVal SupplierID As String, ByVal OrderBy as String) As List(Of SIS.QCM.qcmInspections)
      Dim Results As List(Of SIS.QCM.qcmInspections) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmInspectionsSelectBySupplierID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SupplierID",SqlDbType.NVarChar,SupplierID.ToString.Length, SupplierID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.QCM.qcmInspections)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCM.qcmInspections(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetByInspectedBy(ByVal InspectedBy As String, ByVal OrderBy as String) As List(Of SIS.QCM.qcmInspections)
      Dim Results As List(Of SIS.QCM.qcmInspections) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmInspectionsSelectByInspectedBy"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectedBy",SqlDbType.NVarChar,InspectedBy.ToString.Length, InspectedBy)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.QCM.qcmInspections)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCM.qcmInspections(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function GetByRequestStateID(ByVal RequestStateID As String, ByVal OrderBy As String) As List(Of SIS.QCM.qcmInspections)
      Dim Results As List(Of SIS.QCM.qcmInspections) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmInspectionsSelectByRequestStateID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RequestStateID", SqlDbType.NVarChar, RequestStateID.ToString.Length, RequestStateID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.QCM.qcmInspections)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCM.qcmInspections(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function qcmInspectionsList(ByVal RequestID As Int32, comp As String) As List(Of SIS.QCM.qcmInspections)
      Dim Results As List(Of SIS.QCM.qcmInspections) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString(comp))
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmInspectionsSelectListFilteres"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_RequestID", SqlDbType.Int, 10, IIf(RequestID = Nothing, 0, RequestID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, 0)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, 999)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, "")
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, "")
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.QCM.qcmInspections)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCM.qcmInspections(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function

    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmInspectionsSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal RequestID As Int32) As List(Of SIS.QCM.qcmInspections)
      Dim Results As List(Of SIS.QCM.qcmInspections) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
					If SearchState Then
						Cmd.CommandText = "spqcmInspectionsSelectListSearch"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
					Else
						Cmd.CommandText = "spqcmInspectionsSelectListFilteres"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_RequestID",SqlDbType.Int,10, IIf(RequestID = Nothing, 0,RequestID))
					End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.QCM.qcmInspections)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCM.qcmInspections(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function qcmInspectionsSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal RequestID As Int32) As Integer
      Return _RecordCount
    End Function
    'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Insert, True)>
    Public Shared Function qcmInspectionsInsert(ByVal Record As SIS.QCM.qcmInspections) As SIS.QCM.qcmInspections
      Dim _Rec As SIS.QCM.qcmInspections = SIS.QCM.qcmInspections.qcmInspectionsGetNewRecord()
      With _Rec
        .RequestID = Record.RequestID
        .ProjectID = Record.FK_QCM_Inspections_RequestID.ProjectID
        .OrderNo = Record.FK_QCM_Inspections_RequestID.OrderNo
        .OrderDate = Record.FK_QCM_Inspections_RequestID.OrderDate
        .SupplierID = Record.FK_QCM_Inspections_RequestID.SupplierID
        .InspectedQuantity = Record.InspectedQuantity
        .InspectionStatusID = Record.InspectionStatusID
        .InspectionRemarks = Record.InspectionRemarks
        .InspectedBy = Record.InspectedBy
        .InspectedOn = Record.InspectedOn
        .RequestStateID = "INSPECTED"
        .FileAttached = Record.FileAttached
        .EnteredBy = Global.System.Web.HttpContext.Current.Session("LoginID")
        .EnteredOn = Now
        .OfferedQuantity = Record.OfferedQuantity
        .ClearedQuantity = Record.ClearedQuantity
        .UOM = Record.UOM
        .InspectedQuantityFinal = Record.InspectedQuantityFinal
        .OfferedQuantityFinal = Record.OfferedQuantityFinal
        .ClearedQuantityFinal = Record.ClearedQuantityFinal
        .AttendedVirtually = Record.AttendedVirtually
      End With
      If Record.Company = "" Then
        Return SIS.QCM.qcmInspections.InsertData(_Rec)
      Else
        Return SIS.QCM.qcmInspections.InsertData(_Rec, Record.Company)
      End If
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.QCM.qcmInspections) As SIS.QCM.qcmInspections
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmInspectionsInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RequestID", SqlDbType.Int, 11, Record.RequestID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID", SqlDbType.NVarChar, 7, Record.ProjectID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderNo", SqlDbType.NVarChar, 51, Iif(Record.OrderNo = "", Convert.DBNull, Record.OrderNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderDate", SqlDbType.DateTime, 21, Iif(Record.OrderDate = "", Convert.DBNull, Record.OrderDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SupplierID", SqlDbType.NVarChar, 9, Record.SupplierID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectionRemarks", SqlDbType.NVarChar, 501, Iif(Record.InspectionRemarks = "", Convert.DBNull, Record.InspectionRemarks))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectedBy", SqlDbType.NVarChar, 9, Iif(Record.InspectedBy = "", Convert.DBNull, Record.InspectedBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectedOn", SqlDbType.DateTime, 21, Iif(Record.InspectedOn = "", Convert.DBNull, Record.InspectedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RequestStateID", SqlDbType.NVarChar, 11, Record.RequestStateID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FileAttached", SqlDbType.Bit, 3, Record.FileAttached)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectionStatusID", SqlDbType.Int, 11, Iif(Record.InspectionStatusID = "", Convert.DBNull, Record.InspectionStatusID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectedQuantity", SqlDbType.NVarChar, 51, Iif(Record.InspectedQuantity = "", Convert.DBNull, Record.InspectedQuantity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectionStageiD", SqlDbType.Int, 11, Iif(Record.InspectionStageiD = "", Convert.DBNull, Record.InspectionStageiD))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EnteredBy", SqlDbType.NVarChar, 9, Iif(Record.EnteredBy = "", Convert.DBNull, Record.EnteredBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EnteredOn", SqlDbType.DateTime, 21, Iif(Record.EnteredOn = "", Convert.DBNull, Record.EnteredOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UOM", SqlDbType.NVarChar, 10, IIf(Record.UOM = "", Convert.DBNull, Record.UOM))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OfferedQuantity", SqlDbType.NVarChar, 21, IIf(Record.OfferedQuantity = "", Convert.DBNull, Record.OfferedQuantity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ClearedQuantity", SqlDbType.NVarChar, 21, IIf(Record.ClearedQuantity = "", Convert.DBNull, Record.ClearedQuantity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectedQuantityFinal", SqlDbType.NVarChar, 51, IIf(Record.InspectedQuantityFinal = "", Convert.DBNull, Record.InspectedQuantityFinal))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OfferedQuantityFinal", SqlDbType.NVarChar, 21, IIf(Record.OfferedQuantityFinal = "", Convert.DBNull, Record.OfferedQuantityFinal))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ClearedQuantityFinal", SqlDbType.NVarChar, 21, IIf(Record.ClearedQuantityFinal = "", Convert.DBNull, Record.ClearedQuantityFinal))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AttendedVirtually", SqlDbType.Bit, 3, Record.AttendedVirtually)
          Cmd.Parameters.Add("@Return_RequestID", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_RequestID").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_InspectionID", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_InspectionID").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.RequestID = Cmd.Parameters("@Return_RequestID").Value
          Record.InspectionID = Cmd.Parameters("@Return_InspectionID").Value
        End Using
      End Using
      Return Record
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.QCM.qcmInspections, Comp As String) As SIS.QCM.qcmInspections
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString(Comp))
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmInspectionsInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RequestID", SqlDbType.Int, 11, Record.RequestID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID", SqlDbType.NVarChar, 7, Record.ProjectID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderNo", SqlDbType.NVarChar, 51, IIf(Record.OrderNo = "", Convert.DBNull, Record.OrderNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderDate", SqlDbType.DateTime, 21, IIf(Record.OrderDate = "", Convert.DBNull, Record.OrderDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SupplierID", SqlDbType.NVarChar, 9, Record.SupplierID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectionRemarks", SqlDbType.NVarChar, 501, IIf(Record.InspectionRemarks = "", Convert.DBNull, Record.InspectionRemarks))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectedBy", SqlDbType.NVarChar, 9, IIf(Record.InspectedBy = "", Convert.DBNull, Record.InspectedBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectedOn", SqlDbType.DateTime, 21, IIf(Record.InspectedOn = "", Convert.DBNull, Record.InspectedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RequestStateID", SqlDbType.NVarChar, 11, Record.RequestStateID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FileAttached", SqlDbType.Bit, 3, Record.FileAttached)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectionStatusID", SqlDbType.Int, 11, IIf(Record.InspectionStatusID = "", Convert.DBNull, Record.InspectionStatusID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectedQuantity", SqlDbType.NVarChar, 51, IIf(Record.InspectedQuantity = "", Convert.DBNull, Record.InspectedQuantity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectionStageiD", SqlDbType.Int, 11, IIf(Record.InspectionStageiD = "", Convert.DBNull, Record.InspectionStageiD))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EnteredBy", SqlDbType.NVarChar, 9, IIf(Record.EnteredBy = "", Convert.DBNull, Record.EnteredBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EnteredOn", SqlDbType.DateTime, 21, IIf(Record.EnteredOn = "", Convert.DBNull, Record.EnteredOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UOM", SqlDbType.NVarChar, 10, IIf(Record.UOM = "", Convert.DBNull, Record.UOM))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OfferedQuantity", SqlDbType.NVarChar, 21, IIf(Record.OfferedQuantity = "", Convert.DBNull, Record.OfferedQuantity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ClearedQuantity", SqlDbType.NVarChar, 21, IIf(Record.ClearedQuantity = "", Convert.DBNull, Record.ClearedQuantity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectedQuantityFinal", SqlDbType.NVarChar, 51, IIf(Record.InspectedQuantityFinal = "", Convert.DBNull, Record.InspectedQuantityFinal))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OfferedQuantityFinal", SqlDbType.NVarChar, 21, IIf(Record.OfferedQuantityFinal = "", Convert.DBNull, Record.OfferedQuantityFinal))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ClearedQuantityFinal", SqlDbType.NVarChar, 21, IIf(Record.ClearedQuantityFinal = "", Convert.DBNull, Record.ClearedQuantityFinal))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AttendedVirtually", SqlDbType.Bit, 3, Record.AttendedVirtually)
          Cmd.Parameters.Add("@Return_RequestID", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_RequestID").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_InspectionID", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_InspectionID").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.RequestID = Cmd.Parameters("@Return_RequestID").Value
          Record.InspectionID = Cmd.Parameters("@Return_InspectionID").Value
        End Using
      End Using
      Return Record
    End Function

    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function qcmInspectionsUpdate(ByVal Record As SIS.QCM.qcmInspections) As SIS.QCM.qcmInspections
      Dim _Rec As SIS.QCM.qcmInspections = SIS.QCM.qcmInspections.qcmInspectionsGetByID(Record.RequestID, Record.InspectionID)
      With _Rec
        .InspectedQuantity = Record.InspectedQuantity
        .InspectionStatusID = Record.InspectionStatusID
        .InspectionRemarks = Record.InspectionRemarks
        .InspectedBy = Record.InspectedBy
        .InspectedOn = Record.InspectedOn
				.RequestStateID = "INSPECTED"
        .FileAttached = Record.FileAttached
        .EnteredBy = Global.System.Web.HttpContext.Current.Session("LoginID")
        .EnteredOn = Now
        .OfferedQuantity = Record.OfferedQuantity
        .ClearedQuantity = Record.ClearedQuantity
        .UOM = Record.UOM
        .InspectedQuantityFinal = Record.InspectedQuantityFinal
        .OfferedQuantityFinal = Record.OfferedQuantityFinal
        .ClearedQuantityFinal = Record.ClearedQuantityFinal
      End With
      Return SIS.QCM.qcmInspections.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.QCM.qcmInspections) As SIS.QCM.qcmInspections
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmInspectionsUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_RequestID",SqlDbType.Int,11, Record.RequestID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_InspectionID",SqlDbType.Int,11, Record.InspectionID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RequestID",SqlDbType.Int,11, Record.RequestID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID",SqlDbType.NVarChar,7, Record.ProjectID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderNo",SqlDbType.NVarChar,51, Iif(Record.OrderNo= "" ,Convert.DBNull, Record.OrderNo))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderDate",SqlDbType.DateTime,21, Iif(Record.OrderDate= "" ,Convert.DBNull, Record.OrderDate))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SupplierID", SqlDbType.NVarChar, 9, Record.SupplierID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectionRemarks",SqlDbType.NVarChar,501, Iif(Record.InspectionRemarks= "" ,Convert.DBNull, Record.InspectionRemarks))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectedBy",SqlDbType.NVarChar,9, Iif(Record.InspectedBy= "" ,Convert.DBNull, Record.InspectedBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectedOn",SqlDbType.DateTime,21, Iif(Record.InspectedOn= "" ,Convert.DBNull, Record.InspectedOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RequestStateID",SqlDbType.NVarChar,11, Record.RequestStateID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FileAttached",SqlDbType.Bit,3, Record.FileAttached)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectionStatusID",SqlDbType.Int,11, Iif(Record.InspectionStatusID= "" ,Convert.DBNull, Record.InspectionStatusID))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectedQuantity",SqlDbType.NVarChar,51, Iif(Record.InspectedQuantity= "" ,Convert.DBNull, Record.InspectedQuantity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectionStageiD",SqlDbType.Int,11, Iif(Record.InspectionStageiD= "" ,Convert.DBNull, Record.InspectionStageiD))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EnteredBy",SqlDbType.NVarChar,9, Iif(Record.EnteredBy= "" ,Convert.DBNull, Record.EnteredBy))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EnteredOn",SqlDbType.DateTime,21, Iif(Record.EnteredOn= "" ,Convert.DBNull, Record.EnteredOn))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@UOM", SqlDbType.NVarChar, 10, IIf(Record.UOM = "", Convert.DBNull, Record.UOM))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OfferedQuantity", SqlDbType.NVarChar, 21, IIf(Record.OfferedQuantity = "", Convert.DBNull, Record.OfferedQuantity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ClearedQuantity", SqlDbType.NVarChar, 21, IIf(Record.ClearedQuantity = "", Convert.DBNull, Record.ClearedQuantity))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectedQuantityFinal", SqlDbType.NVarChar, 51, IIf(Record.InspectedQuantityFinal = "", Convert.DBNull, Record.InspectedQuantityFinal))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OfferedQuantityFinal", SqlDbType.NVarChar, 21, IIf(Record.OfferedQuantityFinal = "", Convert.DBNull, Record.OfferedQuantityFinal))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ClearedQuantityFinal", SqlDbType.NVarChar, 21, IIf(Record.ClearedQuantityFinal = "", Convert.DBNull, Record.ClearedQuantityFinal))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@AttendedVirtually", SqlDbType.Bit, 3, Record.AttendedVirtually)
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
    Public Shared Function Delete(ByVal Record As SIS.QCM.qcmInspections) As Int32
      Dim _Result As Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmInspectionsDelete"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_RequestID", SqlDbType.Int, Record.RequestID.ToString.Length, Record.RequestID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_InspectionID", SqlDbType.Int, Record.InspectionID.ToString.Length, Record.InspectionID)
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
End Namespace
