Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.QCM
  <DataObject()> _
  Partial Public Class qcmIGvsEG
    Private Shared _RecordCount As Integer
    Private _InspectorGroupID As Int32 = 0
    Private _EmployeeGroupID As Int32 = 0
    Private _QCM_EmployeeGroups1_Description As String = ""
    Private _QCM_InspectorGroups2_Description As String = ""
    Private _FK_QCM_IE_EmployeeGroupID As SIS.QCM.qcmEmployeeGroups = Nothing
    Private _FK_QCM_IE_InspectorGroupID As SIS.QCM.qcmInspectorGroups = Nothing
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
    Public Property InspectorGroupID() As Int32
      Get
        Return _InspectorGroupID
      End Get
      Set(ByVal value As Int32)
        _InspectorGroupID = value
      End Set
    End Property
    Public Property EmployeeGroupID() As Int32
      Get
        Return _EmployeeGroupID
      End Get
      Set(ByVal value As Int32)
        _EmployeeGroupID = value
      End Set
    End Property
    Public Property QCM_EmployeeGroups1_Description() As String
      Get
        Return _QCM_EmployeeGroups1_Description
      End Get
      Set(ByVal value As String)
        _QCM_EmployeeGroups1_Description = value
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
        Return _InspectorGroupID & "|" & _EmployeeGroupID
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
    Public Class PKqcmIGvsEG
			Private _InspectorGroupID As Int32 = 0
			Private _EmployeeGroupID As Int32 = 0
			Public Property InspectorGroupID() As Int32
				Get
					Return _InspectorGroupID
				End Get
				Set(ByVal value As Int32)
					_InspectorGroupID = value
				End Set
			End Property
			Public Property EmployeeGroupID() As Int32
				Get
					Return _EmployeeGroupID
				End Get
				Set(ByVal value As Int32)
					_EmployeeGroupID = value
				End Set
			End Property
    End Class
    Public ReadOnly Property FK_QCM_IE_EmployeeGroupID() As SIS.QCM.qcmEmployeeGroups
      Get
        If _FK_QCM_IE_EmployeeGroupID Is Nothing Then
          _FK_QCM_IE_EmployeeGroupID = SIS.QCM.qcmEmployeeGroups.qcmEmployeeGroupsGetByID(_EmployeeGroupID)
        End If
        Return _FK_QCM_IE_EmployeeGroupID
      End Get
    End Property
    Public ReadOnly Property FK_QCM_IE_InspectorGroupID() As SIS.QCM.qcmInspectorGroups
      Get
        If _FK_QCM_IE_InspectorGroupID Is Nothing Then
          _FK_QCM_IE_InspectorGroupID = SIS.QCM.qcmInspectorGroups.qcmInspectorGroupsGetByID(_InspectorGroupID)
        End If
        Return _FK_QCM_IE_InspectorGroupID
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmIGvsEGGetNewRecord() As SIS.QCM.qcmIGvsEG
      Return New SIS.QCM.qcmIGvsEG()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmIGvsEGGetByID(ByVal InspectorGroupID As Int32, ByVal EmployeeGroupID As Int32) As SIS.QCM.qcmIGvsEG
      Dim Results As SIS.QCM.qcmIGvsEG = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmIGvsEGSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectorGroupID",SqlDbType.Int,InspectorGroupID.ToString.Length, InspectorGroupID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EmployeeGroupID",SqlDbType.Int,EmployeeGroupID.ToString.Length, EmployeeGroupID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
					If Reader.Read() Then
						Results = New SIS.QCM.qcmIGvsEG(Reader)
					End If
					Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetByInspectorGroupID(ByVal InspectorGroupID As Int32, ByVal OrderBy as String) As List(Of SIS.QCM.qcmIGvsEG)
      Dim Results As List(Of SIS.QCM.qcmIGvsEG) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmIGvsEGSelectByInspectorGroupID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectorGroupID",SqlDbType.Int,InspectorGroupID.ToString.Length, InspectorGroupID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.QCM.qcmIGvsEG)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCM.qcmIGvsEG(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetByEmployeeGroupID(ByVal EmployeeGroupID As Int32, ByVal OrderBy as String) As List(Of SIS.QCM.qcmIGvsEG)
      Dim Results As List(Of SIS.QCM.qcmIGvsEG) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmIGvsEGSelectByEmployeeGroupID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EmployeeGroupID",SqlDbType.Int,EmployeeGroupID.ToString.Length, EmployeeGroupID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.QCM.qcmIGvsEG)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCM.qcmIGvsEG(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmIGvsEGSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal InspectorGroupID As Int32, ByVal EmployeeGroupID As Int32) As List(Of SIS.QCM.qcmIGvsEG)
      Dim Results As List(Of SIS.QCM.qcmIGvsEG) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
					If SearchState Then
						Cmd.CommandText = "spqcmIGvsEGSelectListSearch"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
					Else
						Cmd.CommandText = "spqcmIGvsEGSelectListFilteres"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_InspectorGroupID",SqlDbType.Int,10, IIf(InspectorGroupID = Nothing, 0,InspectorGroupID))
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_EmployeeGroupID",SqlDbType.Int,10, IIf(EmployeeGroupID = Nothing, 0,EmployeeGroupID))
					End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.QCM.qcmIGvsEG)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCM.qcmIGvsEG(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function qcmIGvsEGSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal InspectorGroupID As Int32, ByVal EmployeeGroupID As Int32) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmIGvsEGGetByID(ByVal InspectorGroupID As Int32, ByVal EmployeeGroupID As Int32, ByVal Filter_InspectorGroupID As Int32, ByVal Filter_EmployeeGroupID As Int32) As SIS.QCM.qcmIGvsEG
      Return qcmIGvsEGGetByID(InspectorGroupID, EmployeeGroupID)
    End Function
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function qcmIGvsEGInsert(ByVal Record As SIS.QCM.qcmIGvsEG) As SIS.QCM.qcmIGvsEG
      Dim _Rec As SIS.QCM.qcmIGvsEG = SIS.QCM.qcmIGvsEG.qcmIGvsEGGetNewRecord()
      With _Rec
        .InspectorGroupID = Record.InspectorGroupID
        .EmployeeGroupID = Record.EmployeeGroupID
      End With
      Return SIS.QCM.qcmIGvsEG.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.QCM.qcmIGvsEG) As SIS.QCM.qcmIGvsEG
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmIGvsEGInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectorGroupID",SqlDbType.Int,11, Record.InspectorGroupID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EmployeeGroupID",SqlDbType.Int,11, Record.EmployeeGroupID)
          Cmd.Parameters.Add("@Return_InspectorGroupID", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_InspectorGroupID").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_EmployeeGroupID", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_EmployeeGroupID").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.InspectorGroupID = Cmd.Parameters("@Return_InspectorGroupID").Value
          Record.EmployeeGroupID = Cmd.Parameters("@Return_EmployeeGroupID").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function qcmIGvsEGUpdate(ByVal Record As SIS.QCM.qcmIGvsEG) As SIS.QCM.qcmIGvsEG
      Dim _Rec As SIS.QCM.qcmIGvsEG = SIS.QCM.qcmIGvsEG.qcmIGvsEGGetByID(Record.InspectorGroupID, Record.EmployeeGroupID)
      With _Rec
      End With
      Return SIS.QCM.qcmIGvsEG.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.QCM.qcmIGvsEG) As SIS.QCM.qcmIGvsEG
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmIGvsEGUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_InspectorGroupID",SqlDbType.Int,11, Record.InspectorGroupID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_EmployeeGroupID",SqlDbType.Int,11, Record.EmployeeGroupID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectorGroupID",SqlDbType.Int,11, Record.InspectorGroupID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@EmployeeGroupID",SqlDbType.Int,11, Record.EmployeeGroupID)
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
		<DataObjectMethod(DataObjectMethodType.Delete, True)> _
		Public Shared Function Delete(ByVal Record As SIS.QCM.qcmIGvsEG) As Int32
			Dim _Result As Integer = 0
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "spqcmIGvsEGDelete"
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_InspectorGroupID", SqlDbType.Int, Record.InspectorGroupID.ToString.Length, Record.InspectorGroupID)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_EmployeeGroupID", SqlDbType.Int, Record.EmployeeGroupID.ToString.Length, Record.EmployeeGroupID)
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
      _InspectorGroupID = Ctype(Reader("InspectorGroupID"),Int32)
      _EmployeeGroupID = Ctype(Reader("EmployeeGroupID"),Int32)
      _QCM_EmployeeGroups1_Description = Ctype(Reader("QCM_EmployeeGroups1_Description"),String)
      _QCM_InspectorGroups2_Description = Ctype(Reader("QCM_InspectorGroups2_Description"),String)
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
