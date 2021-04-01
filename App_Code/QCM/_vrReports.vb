Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.VR
  <DataObject()> _
  Partial Public Class vrReports
    Private Shared _RecordCount As Integer
    Private _FProject As String = ""
    Private _TProject As String = ""
    Private _FSupplier As String = ""
    Private _TSupplier As String = ""
    Private _FReqDt As String = ""
    Private _TReqDt As String = ""
    Private _FUser As String = ""
    Private _TUser As String = ""
    Private _aspnet_Users1_UserFullName As String = ""
    Private _aspnet_Users2_UserFullName As String = ""
    Private _IDM_Projects3_Description As String = ""
    Private _IDM_Projects4_Description As String = ""
    Private _VR_Transporters5_TransporterName As String = ""
		Private _VR_Transporters6_TransporterName As String = ""

    Private _FK_VR_Reports_FUser As SIS.QCM.qcmUsers = Nothing
    Private _FK_VR_Reports_TUser As SIS.QCM.qcmUsers = Nothing
    Private _FK_VR_Reports_FProjectID As SIS.QCM.qcmProjects = Nothing
    Private _FK_VR_Reports_TProjectID As SIS.QCM.qcmProjects = Nothing
    Public Property AllCompany As Boolean = True
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
    Public Property FProject() As String
      Get
        Return _FProject
      End Get
      Set(ByVal value As String)
        _FProject = value
      End Set
    End Property
    Public Property TProject() As String
      Get
        Return _TProject
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _TProject = ""
				 Else
					 _TProject = value
			   End If
      End Set
    End Property
    Public Property FSupplier() As String
      Get
        Return _FSupplier
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _FSupplier = ""
				 Else
					 _FSupplier = value
			   End If
      End Set
    End Property
    Public Property TSupplier() As String
      Get
        Return _TSupplier
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _TSupplier = ""
				 Else
					 _TSupplier = value
			   End If
      End Set
    End Property
    Public Property FReqDt() As String
      Get
        If Not _FReqDt = String.Empty Then
          Return Convert.ToDateTime(_FReqDt).ToString("dd/MM/yyyy")
        End If
        Return _FReqDt
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _FReqDt = ""
				 Else
					 _FReqDt = value
			   End If
      End Set
    End Property
    Public Property TReqDt() As String
      Get
        If Not _TReqDt = String.Empty Then
          Return Convert.ToDateTime(_TReqDt).ToString("dd/MM/yyyy")
        End If
        Return _TReqDt
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _TReqDt = ""
				 Else
					 _TReqDt = value
			   End If
      End Set
    End Property
    Public Property FUser() As String
      Get
        Return _FUser
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _FUser = ""
				 Else
					 _FUser = value
			   End If
      End Set
    End Property
    Public Property TUser() As String
      Get
        Return _TUser
      End Get
      Set(ByVal value As String)
				 If Convert.IsDBNull(Value) Then
					 _TUser = ""
				 Else
					 _TUser = value
			   End If
      End Set
    End Property
    Public Property aspnet_Users1_UserFullName() As String
      Get
        Return _aspnet_Users1_UserFullName
      End Get
      Set(ByVal value As String)
        _aspnet_Users1_UserFullName = value
      End Set
    End Property
    Public Property aspnet_Users2_UserFullName() As String
      Get
        Return _aspnet_Users2_UserFullName
      End Get
      Set(ByVal value As String)
        _aspnet_Users2_UserFullName = value
      End Set
    End Property
    Public Property IDM_Projects3_Description() As String
      Get
        Return _IDM_Projects3_Description
      End Get
      Set(ByVal value As String)
        _IDM_Projects3_Description = value
      End Set
    End Property
    Public Property IDM_Projects4_Description() As String
      Get
        Return _IDM_Projects4_Description
      End Get
      Set(ByVal value As String)
        _IDM_Projects4_Description = value
      End Set
    End Property
    Public Property VR_Transporters5_TransporterName() As String
      Get
        Return _VR_Transporters5_TransporterName
      End Get
      Set(ByVal value As String)
        _VR_Transporters5_TransporterName = value
      End Set
    End Property
    Public Property VR_Transporters6_TransporterName() As String
      Get
        Return _VR_Transporters6_TransporterName
      End Get
      Set(ByVal value As String)
        _VR_Transporters6_TransporterName = value
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return ""
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _FProject
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
    Public Class PKvrReports
			Private _FProject As String = ""
			Public Property FProject() As String
				Get
					Return _FProject
				End Get
				Set(ByVal value As String)
					_FProject = value
				End Set
			End Property
    End Class
    Public ReadOnly Property FK_VR_Reports_FUser() As SIS.QCM.qcmUsers
      Get
        If _FK_VR_Reports_FUser Is Nothing Then
          _FK_VR_Reports_FUser = SIS.QCM.qcmUsers.qcmUsersGetByID(_FUser)
        End If
        Return _FK_VR_Reports_FUser
      End Get
    End Property
    Public ReadOnly Property FK_VR_Reports_TUser() As SIS.QCM.qcmUsers
      Get
        If _FK_VR_Reports_TUser Is Nothing Then
          _FK_VR_Reports_TUser = SIS.QCM.qcmUsers.qcmUsersGetByID(_TUser)
        End If
        Return _FK_VR_Reports_TUser
      End Get
    End Property
    Public ReadOnly Property FK_VR_Reports_FProjectID() As SIS.QCM.qcmProjects
      Get
        If _FK_VR_Reports_FProjectID Is Nothing Then
          _FK_VR_Reports_FProjectID = SIS.QCM.qcmProjects.qcmProjectsGetByID(_FProject)
        End If
        Return _FK_VR_Reports_FProjectID
      End Get
    End Property
    Public ReadOnly Property FK_VR_Reports_TProjectID() As SIS.QCM.qcmProjects
      Get
        If _FK_VR_Reports_TProjectID Is Nothing Then
          _FK_VR_Reports_TProjectID = SIS.QCM.qcmProjects.qcmProjectsGetByID(_TProject)
        End If
        Return _FK_VR_Reports_TProjectID
      End Get
    End Property
		<DataObjectMethod(DataObjectMethodType.Select)> _
		Public Shared Function vrReportsGetNewRecord() As SIS.VR.vrReports
			Return New SIS.VR.vrReports()
		End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function vrReportsGetByID(ByVal FProject As String) As SIS.VR.vrReports
      Dim Results As SIS.VR.vrReports = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spvrReportsSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FProject",SqlDbType.NVarChar,FProject.ToString.Length, FProject)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
					If Reader.Read() Then
						Results = New SIS.VR.vrReports(Reader)
					End If
					Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function vrReportsInsert(ByVal Record As SIS.VR.vrReports) As SIS.VR.vrReports
      Dim _Rec As SIS.VR.vrReports = SIS.VR.vrReports.vrReportsGetNewRecord()
      With _Rec
        .FProject = Record.FProject
        .TProject = Record.TProject
        .FSupplier = Record.FSupplier
        .TSupplier = Record.TSupplier
        .FReqDt = Record.FReqDt
        .TReqDt = Record.TReqDt
        .FUser = Record.FUser
        .TUser = Record.TUser
      End With
      Return SIS.VR.vrReports.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.VR.vrReports) As SIS.VR.vrReports
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spvrReportsInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FProject",SqlDbType.NVarChar,7, Record.FProject)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TProject",SqlDbType.NVarChar,7, Iif(Record.TProject= "" ,Convert.DBNull, Record.TProject))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FSupplier",SqlDbType.NVarChar,10, Iif(Record.FSupplier= "" ,Convert.DBNull, Record.FSupplier))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TSupplier",SqlDbType.NVarChar,10, Iif(Record.TSupplier= "" ,Convert.DBNull, Record.TSupplier))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FReqDt",SqlDbType.DateTime,21, Iif(Record.FReqDt= "" ,Convert.DBNull, Record.FReqDt))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TReqDt",SqlDbType.DateTime,21, Iif(Record.TReqDt= "" ,Convert.DBNull, Record.TReqDt))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FUser",SqlDbType.NVarChar,9, Iif(Record.FUser= "" ,Convert.DBNull, Record.FUser))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@TUser",SqlDbType.NVarChar,9, Iif(Record.TUser= "" ,Convert.DBNull, Record.TUser))
          Cmd.Parameters.Add("@Return_FProject", SqlDbType.NVarChar, 7)
          Cmd.Parameters("@Return_FProject").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.FProject = Cmd.Parameters("@Return_FProject").Value
        End Using
      End Using
      Return Record
    End Function
    Public Sub New(ByVal Reader As SqlDataReader)
      On Error Resume Next
      _FProject = Ctype(Reader("FProject"),String)
      If Convert.IsDBNull(Reader("TProject")) Then
        _TProject = String.Empty
      Else
        _TProject = Ctype(Reader("TProject"), String)
      End If
      If Convert.IsDBNull(Reader("FSupplier")) Then
        _FSupplier = String.Empty
      Else
        _FSupplier = Ctype(Reader("FSupplier"), String)
      End If
      If Convert.IsDBNull(Reader("TSupplier")) Then
        _TSupplier = String.Empty
      Else
        _TSupplier = Ctype(Reader("TSupplier"), String)
      End If
      If Convert.IsDBNull(Reader("FReqDt")) Then
        _FReqDt = String.Empty
      Else
        _FReqDt = Ctype(Reader("FReqDt"), String)
      End If
      If Convert.IsDBNull(Reader("TReqDt")) Then
        _TReqDt = String.Empty
      Else
        _TReqDt = Ctype(Reader("TReqDt"), String)
      End If
      If Convert.IsDBNull(Reader("FUser")) Then
        _FUser = String.Empty
      Else
        _FUser = Ctype(Reader("FUser"), String)
      End If
      If Convert.IsDBNull(Reader("TUser")) Then
        _TUser = String.Empty
      Else
        _TUser = Ctype(Reader("TUser"), String)
      End If
      _aspnet_Users1_UserFullName = Ctype(Reader("aspnet_Users1_UserFullName"),String)
      _aspnet_Users2_UserFullName = Ctype(Reader("aspnet_Users2_UserFullName"),String)
      _IDM_Projects3_Description = Ctype(Reader("IDM_Projects3_Description"),String)
      _IDM_Projects4_Description = Ctype(Reader("IDM_Projects4_Description"),String)
      _VR_Transporters5_TransporterName = Ctype(Reader("VR_Transporters5_TransporterName"),String)
      _VR_Transporters6_TransporterName = Ctype(Reader("VR_Transporters6_TransporterName"),String)
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
