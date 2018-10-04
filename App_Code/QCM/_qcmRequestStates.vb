Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.QCM
  <DataObject()> _
  Partial Public Class qcmRequestStates
    Private Shared _RecordCount As Integer
    Private _StateID As String = ""
    Private _Description As String = ""
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
    Public Property StateID() As String
      Get
        Return _StateID
      End Get
      Set(ByVal value As String)
        _StateID = value
      End Set
    End Property
    Public Property Description() As String
      Get
        Return _Description
      End Get
      Set(ByVal value As String)
        _Description = value
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return "" & _Description.ToString.PadRight(50, " ")
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _StateID
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
    Public Class PKqcmRequestStates
			Private _StateID As String = ""
			Public Property StateID() As String
				Get
					Return _StateID
				End Get
				Set(ByVal value As String)
					_StateID = value
				End Set
			End Property
    End Class
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmRequestStatesSelectList(ByVal OrderBy As String) As List(Of SIS.QCM.qcmRequestStates)
      Dim Results As List(Of SIS.QCM.qcmRequestStates) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmRequestStatesSelectList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.QCM.qcmRequestStates)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCM.qcmRequestStates(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmRequestStatesGetNewRecord() As SIS.QCM.qcmRequestStates
      Return New SIS.QCM.qcmRequestStates()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmRequestStatesGetByID(ByVal StateID As String) As SIS.QCM.qcmRequestStates
      Dim Results As SIS.QCM.qcmRequestStates = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmRequestStatesSelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StateID",SqlDbType.NVarChar,StateID.ToString.Length, StateID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
					If Reader.Read() Then
						Results = New SIS.QCM.qcmRequestStates(Reader)
					End If
					Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmRequestStatesSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal StateID As String) As List(Of SIS.QCM.qcmRequestStates)
      Dim Results As List(Of SIS.QCM.qcmRequestStates) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
					If SearchState Then
						Cmd.CommandText = "spqcmRequestStatesSelectListSearch"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
					Else
						Cmd.CommandText = "spqcmRequestStatesSelectListFilteres"
						SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_StateID",SqlDbType.NVarChar,10, IIf(StateID Is Nothing, String.Empty,StateID))
					End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.QCM.qcmRequestStates)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCM.qcmRequestStates(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function qcmRequestStatesSelectCount(ByVal SearchState As Boolean, ByVal SearchText As String, ByVal StateID As String) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function qcmRequestStatesGetByID(ByVal StateID As String, ByVal Filter_StateID As String) As SIS.QCM.qcmRequestStates
      Return qcmRequestStatesGetByID(StateID)
    End Function
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function qcmRequestStatesInsert(ByVal Record As SIS.QCM.qcmRequestStates) As SIS.QCM.qcmRequestStates
      Dim _Rec As SIS.QCM.qcmRequestStates = SIS.QCM.qcmRequestStates.qcmRequestStatesGetNewRecord()
      With _Rec
        .StateID = Record.StateID
        .Description = Record.Description
      End With
      Return SIS.QCM.qcmRequestStates.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.QCM.qcmRequestStates) As SIS.QCM.qcmRequestStates
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmRequestStatesInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StateID",SqlDbType.NVarChar,11, Record.StateID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Description",SqlDbType.NVarChar,51, Record.Description)
          Cmd.Parameters.Add("@Return_StateID", SqlDbType.NVarChar, 11)
          Cmd.Parameters("@Return_StateID").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.StateID = Cmd.Parameters("@Return_StateID").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function qcmRequestStatesUpdate(ByVal Record As SIS.QCM.qcmRequestStates) As SIS.QCM.qcmRequestStates
      Dim _Rec As SIS.QCM.qcmRequestStates = SIS.QCM.qcmRequestStates.qcmRequestStatesGetByID(Record.StateID)
      With _Rec
        .Description = Record.Description
      End With
      Return SIS.QCM.qcmRequestStates.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.QCM.qcmRequestStates) As SIS.QCM.qcmRequestStates
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmRequestStatesUpdate"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_StateID",SqlDbType.NVarChar,11, Record.StateID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StateID",SqlDbType.NVarChar,11, Record.StateID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Description",SqlDbType.NVarChar,51, Record.Description)
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
		Public Shared Function Delete(ByVal Record As SIS.QCM.qcmRequestStates) As Int32
			Dim _Result As Integer = 0
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "spqcmRequestStatesDelete"
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_StateID", SqlDbType.NVarChar, Record.StateID.ToString.Length, Record.StateID)
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
'		Autocomplete Method
		Public Shared Function SelectqcmRequestStatesAutoCompleteList(ByVal Prefix As String, ByVal count As Integer, ByVal contextKey As String) As String()
			Dim Results As List(Of String) = Nothing
      Dim aVal() As String = contextKey.Split("|".ToCharArray)
			Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
				Using Cmd As SqlCommand = Con.CreateCommand()
					Cmd.CommandType = CommandType.StoredProcedure
					Cmd.CommandText = "spqcmRequestStatesAutoCompleteList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@prefix", SqlDbType.NVarChar, 50, Prefix)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@records", SqlDbType.Int, -1, count)
					SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@bycode", SqlDbType.Int, 1, IIf(IsNumeric(Prefix),0,IIf(Prefix.ToLower=Prefix, 0, 1)))
					Results = New List(Of String)()
					Con.Open()
					Dim Reader As SqlDataReader = Cmd.ExecuteReader()
					If Not Reader.HasRows Then
					  Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem("---Select Value---".PadRight(50, " "),""))
					End If
					While (Reader.Read())
            Dim Tmp As SIS.QCM.qcmRequestStates = New SIS.QCM.qcmRequestStates(Reader)
					  Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem(Tmp.DisplayField, Tmp.PrimaryKey))
					End While
					Reader.Close()
				End Using
			End Using
			Return Results.ToArray
		End Function
    Public Sub New(ByVal Reader As SqlDataReader)
      On Error Resume Next
      _StateID = Ctype(Reader("StateID"),String)
      _Description = Ctype(Reader("Description"),String)
    End Sub
    Public Sub New()
    End Sub
  End Class
End Namespace
