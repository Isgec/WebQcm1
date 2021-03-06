Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.QCM
  <DataObject()> _
  Partial Public Class qcmInspectionFiles
    Private Shared _RecordCount As Integer
    Private _RequestID As Int32 = 0
    Private _InspectionID As Int32 = 0
    Private _SerialNo As Int32 = 0
    Private _FileName As String = ""
    Private _DiskFIleName As String = ""
    Private _FK_QCM_IFiles_InspectionID As SIS.QCM.qcmInspections = Nothing
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
    Public Property SerialNo() As Int32
      Get
        Return _SerialNo
      End Get
      Set(ByVal value As Int32)
        _SerialNo = value
      End Set
    End Property
    Public Property FileName() As String
      Get
        Return _FileName
      End Get
      Set(ByVal value As String)
        _FileName = value
      End Set
    End Property
    Public Property DiskFIleName() As String
      Get
        Return _DiskFIleName
      End Get
      Set(ByVal value As String)
        _DiskFIleName = value
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return ""
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _RequestID & "|" & _InspectionID & "|" & _SerialNo
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
    Public Class PKqcmInspectionFiles
			Private _RequestID As Int32 = 0
			Private _InspectionID As Int32 = 0
			Private _SerialNo As Int32 = 0
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
			Public Property SerialNo() As Int32
				Get
					Return _SerialNo
				End Get
				Set(ByVal value As Int32)
					_SerialNo = value
				End Set
			End Property
    End Class
    Public ReadOnly Property FK_QCM_IFiles_InspectionID() As SIS.QCM.qcmInspections
      Get
        If _FK_QCM_IFiles_InspectionID Is Nothing Then
          _FK_QCM_IFiles_InspectionID = SIS.QCM.qcmInspections.qcmInspectionsGetByID(_RequestID, _InspectionID)
        End If
        Return _FK_QCM_IFiles_InspectionID
      End Get
    End Property
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmInspectionFilesGetNewRecord() As SIS.QCM.qcmInspectionFiles
      Return New SIS.QCM.qcmInspectionFiles()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmInspectionFilesGetByID(ByVal RequestID As Int32, ByVal InspectionID As Int32, ByVal SerialNo As Int32) As SIS.QCM.qcmInspectionFiles
      Dim Results As SIS.QCM.qcmInspectionFiles = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmInspectionFilesSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RequestID",SqlDbType.Int,RequestID.ToString.Length, RequestID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectionID",SqlDbType.Int,InspectionID.ToString.Length, InspectionID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@SerialNo",SqlDbType.Int,SerialNo.ToString.Length, SerialNo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
					If Reader.Read() Then
						Results = New SIS.QCM.qcmInspectionFiles(Reader)
					End If
					Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetByRequestID(ByVal RequestID As Int32, ByVal OrderBy as String) As List(Of SIS.QCM.qcmInspectionFiles)
      Dim Results As List(Of SIS.QCM.qcmInspectionFiles) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmInspectionFilesSelectByRequestID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RequestID",SqlDbType.Int,RequestID.ToString.Length, RequestID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.QCM.qcmInspectionFiles)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCM.qcmInspectionFiles(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function GetByInspectionID(ByVal InspectionID As Int32, ByVal OrderBy as String) As List(Of SIS.QCM.qcmInspectionFiles)
      Dim Results As List(Of SIS.QCM.qcmInspectionFiles) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmInspectionFilesSelectByInspectionID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectionID",SqlDbType.Int,InspectionID.ToString.Length, InspectionID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.QCM.qcmInspectionFiles)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCM.qcmInspectionFiles(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmInspectionFilesSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal RequestID As Int32, ByVal InspectionID As Int32) As List(Of SIS.QCM.qcmInspectionFiles)
      Dim Results As List(Of SIS.QCM.qcmInspectionFiles) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
					If SearchState Then
						Cmd.CommandText = "spqcmInspectionFilesSelectListSearch"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
					Else
						Cmd.CommandText = "spqcmInspectionFilesSelectListFilteres"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_RequestID",SqlDbType.Int,10, IIf(RequestID = Nothing, 0,RequestID))
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_InspectionID",SqlDbType.Int,10, IIf(InspectionID = Nothing, 0,InspectionID))
					End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.QCM.qcmInspectionFiles)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCM.qcmInspectionFiles(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function qcmInspectionFilesSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal RequestID As Int32, ByVal InspectionID As Int32) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmInspectionFilesGetByID(ByVal RequestID As Int32, ByVal InspectionID As Int32, ByVal SerialNo As Int32, ByVal Filter_RequestID As Int32, ByVal Filter_InspectionID As Int32) As SIS.QCM.qcmInspectionFiles
      Return qcmInspectionFilesGetByID(RequestID, InspectionID, SerialNo)
    End Function
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function qcmInspectionFilesInsert(ByVal Record As SIS.QCM.qcmInspectionFiles) As SIS.QCM.qcmInspectionFiles
      Dim _Rec As SIS.QCM.qcmInspectionFiles = SIS.QCM.qcmInspectionFiles.qcmInspectionFilesGetNewRecord()
      With _Rec
        .RequestID = Record.RequestID
        .InspectionID = Record.InspectionID
        .FileName = Record.FileName
        .DiskFIleName = Record.DiskFIleName
      End With
      Return SIS.QCM.qcmInspectionFiles.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.QCM.qcmInspectionFiles) As SIS.QCM.qcmInspectionFiles
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmInspectionFilesInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RequestID",SqlDbType.Int,11, Record.RequestID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectionID",SqlDbType.Int,11, Record.InspectionID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@FileName",SqlDbType.NVarChar,251, Record.FileName)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DiskFIleName",SqlDbType.NVarChar,51, Record.DiskFIleName)
          Cmd.Parameters.Add("@Return_RequestID", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_RequestID").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_InspectionID", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_InspectionID").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_SerialNo", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_SerialNo").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.RequestID = Cmd.Parameters("@Return_RequestID").Value
          Record.InspectionID = Cmd.Parameters("@Return_InspectionID").Value
          Record.SerialNo = Cmd.Parameters("@Return_SerialNo").Value
        End Using
      End Using
      Return Record
    End Function
		<DataObjectMethod(DataObjectMethodType.Delete, True)> _
		Public Shared Function Delete(ByVal Record As SIS.QCM.qcmInspectionFiles) As Int32
			Dim _Result As Integer = 0
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "spqcmInspectionFilesDelete"
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_RequestID", SqlDbType.Int, Record.RequestID.ToString.Length, Record.RequestID)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_InspectionID", SqlDbType.Int, Record.InspectionID.ToString.Length, Record.InspectionID)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_SerialNo", SqlDbType.Int, Record.SerialNo.ToString.Length, Record.SerialNo)
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
      _RequestID = Ctype(Reader("RequestID"),Int32)
      _InspectionID = Ctype(Reader("InspectionID"),Int32)
      _SerialNo = Ctype(Reader("SerialNo"),Int32)
      _FileName = Ctype(Reader("FileName"),String)
      _DiskFIleName = Ctype(Reader("DiskFIleName"),String)
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
