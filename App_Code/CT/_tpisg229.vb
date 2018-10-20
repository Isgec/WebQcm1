Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.TPISG
  <DataObject()> _
  Partial Public Class tpisg229
    Private Shared _RecordCount As Integer
    Private _t_trdt As String = ""
    Private _t_bohd As String = ""
    Private _t_indv As String = ""
    Private _t_srno As Int32 = 0
    Private _t_stat As String = ""
    Private _t_proj As String = ""
    Private _t_elem As String = ""
    Private _t_user As String = ""
    Private _t_Refcntd As Int32 = 0
    Private _t_Refcntu As Int32 = 0
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
    Public Property t_trdt() As String
      Get
        If Not _t_trdt = String.Empty Then
          Return Convert.ToDateTime(_t_trdt).ToString("dd/MM/yyyy HH:mm:ss")
        End If
        Return _t_trdt
      End Get
      Set(ByVal value As String)
         _t_trdt = value
      End Set
    End Property
    Public Property t_bohd() As String
      Get
        Return _t_bohd
      End Get
      Set(ByVal value As String)
        _t_bohd = value
      End Set
    End Property
    Public Property t_indv() As String
      Get
        Return _t_indv
      End Get
      Set(ByVal value As String)
        _t_indv = value
      End Set
    End Property
    Public Property t_srno() As Int32
      Get
        Return _t_srno
      End Get
      Set(ByVal value As Int32)
        _t_srno = value
      End Set
    End Property
    Public Property t_stat() As String
      Get
        Return _t_stat
      End Get
      Set(ByVal value As String)
        _t_stat = value
      End Set
    End Property
    Public Property t_proj() As String
      Get
        Return _t_proj
      End Get
      Set(ByVal value As String)
        _t_proj = value
      End Set
    End Property
    Public Property t_elem() As String
      Get
        Return _t_elem
      End Get
      Set(ByVal value As String)
        _t_elem = value
      End Set
    End Property
    Public Property t_user() As String
      Get
        Return _t_user
      End Get
      Set(ByVal value As String)
        _t_user = value
      End Set
    End Property
    Public Property t_Refcntd() As Int32
      Get
        Return _t_Refcntd
      End Get
      Set(ByVal value As Int32)
        _t_Refcntd = value
      End Set
    End Property
    Public Property t_Refcntu() As Int32
      Get
        Return _t_Refcntu
      End Get
      Set(ByVal value As Int32)
        _t_Refcntu = value
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return ""
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _t_trdt & "|" & _t_bohd & "|" & _t_indv & "|" & _t_srno
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
    Public Class PKtpisg229
      Private _t_trdt As String = ""
      Private _t_bohd As String = ""
      Private _t_indv As String = ""
      Private _t_srno As Int32 = 0
      Public Property t_trdt() As String
        Get
          If Not _t_trdt = String.Empty Then
            Return Convert.ToDateTime(_t_trdt).ToString("dd/MM/yyyy")
          End If
          Return _t_trdt
        End Get
        Set(ByVal value As String)
          _t_trdt = value
        End Set
      End Property
      Public Property t_bohd() As String
        Get
          Return _t_bohd
        End Get
        Set(ByVal value As String)
          _t_bohd = value
        End Set
      End Property
      Public Property t_indv() As String
        Get
          Return _t_indv
        End Get
        Set(ByVal value As String)
          _t_indv = value
        End Set
      End Property
      Public Property t_srno() As Int32
        Get
          Return _t_srno
        End Get
        Set(ByVal value As Int32)
          _t_srno = value
        End Set
      End Property
    End Class
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function tpisg229GetNewRecord() As SIS.TPISG.tpisg229
      Return New SIS.TPISG.tpisg229()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function tpisg229GetByID(ByVal t_trdt As DateTime, ByVal t_bohd As String, ByVal t_indv As String, ByVal t_srno As Int32) As SIS.TPISG.tpisg229
      Dim Results As SIS.TPISG.tpisg229 = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sptpisg229SelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_trdt",SqlDbType.DateTime,t_trdt.ToString.Length, t_trdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_bohd",SqlDbType.VarChar,t_bohd.ToString.Length, t_bohd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_indv",SqlDbType.VarChar,t_indv.ToString.Length, t_indv)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_srno",SqlDbType.Int,t_srno.ToString.Length, t_srno)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.TPISG.tpisg229(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function tpisg229SelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.TPISG.tpisg229)
      Dim Results As List(Of SIS.TPISG.tpisg229) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "sptpisg229SelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "sptpisg229SelectListFilteres"
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.TPISG.tpisg229)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.TPISG.tpisg229(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function tpisg229SelectCount(ByVal SearchState As Boolean, ByVal SearchText As String) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function tpisg229Insert(ByVal Record As SIS.TPISG.tpisg229) As SIS.TPISG.tpisg229
      Dim _Rec As SIS.TPISG.tpisg229 = SIS.TPISG.tpisg229.tpisg229GetNewRecord()
      With _Rec
        .t_trdt = Record.t_trdt
        .t_bohd = Record.t_bohd
        .t_indv = Record.t_indv
        .t_srno = Record.t_srno
        .t_stat = Record.t_stat
        .t_proj = Record.t_proj
        .t_elem = Record.t_elem
        .t_user = Record.t_user
        .t_Refcntd = Record.t_Refcntd
        .t_Refcntu = Record.t_Refcntu
      End With
      Return SIS.TPISG.tpisg229.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.TPISG.tpisg229) As SIS.TPISG.tpisg229
      Dim comp As String = "200"
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sptpisg229" & comp & "Insert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_trdt", SqlDbType.DateTime, 21, Record.t_trdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_bohd", SqlDbType.VarChar, 51, Record.t_bohd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_indv", SqlDbType.VarChar, 51, Record.t_indv)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_srno", SqlDbType.Int, 11, Record.t_srno)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_stat", SqlDbType.VarChar, 21, Record.t_stat)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_proj", SqlDbType.VarChar, 10, Record.t_proj)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_elem", SqlDbType.VarChar, 9, Record.t_elem)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_user", SqlDbType.VarChar, 10, Record.t_user)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntd", SqlDbType.Int, 11, 0)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntu", SqlDbType.Int, 11, 0)
          Cmd.Parameters.Add("@Return_t_trdt", SqlDbType.DateTime, 21)
          Cmd.Parameters("@Return_t_trdt").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_bohd", SqlDbType.VarChar, 51)
          Cmd.Parameters("@Return_t_bohd").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_indv", SqlDbType.VarChar, 51)
          Cmd.Parameters("@Return_t_indv").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_srno", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_t_srno").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.t_trdt = Cmd.Parameters("@Return_t_trdt").Value
          Record.t_bohd = Cmd.Parameters("@Return_t_bohd").Value
          Record.t_indv = Cmd.Parameters("@Return_t_indv").Value
          Record.t_srno = Cmd.Parameters("@Return_t_srno").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)>
    Public Shared Function tpisg229Update(ByVal Record As SIS.TPISG.tpisg229) As SIS.TPISG.tpisg229
      Dim _Rec As SIS.TPISG.tpisg229 = SIS.TPISG.tpisg229.tpisg229GetByID(Record.t_trdt, Record.t_bohd, Record.t_indv, Record.t_srno)
      With _Rec
        .t_stat = Record.t_stat
        .t_proj = Record.t_proj
        .t_elem = Record.t_elem
        .t_user = Record.t_user
        .t_Refcntd = Record.t_Refcntd
        .t_Refcntu = Record.t_Refcntu
      End With
      Return SIS.TPISG.tpisg229.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.TPISG.tpisg229) As SIS.TPISG.tpisg229
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sptpisg229Update"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_trdt",SqlDbType.DateTime,21, Record.t_trdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_bohd",SqlDbType.VarChar,51, Record.t_bohd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_indv",SqlDbType.VarChar,51, Record.t_indv)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_srno",SqlDbType.Int,11, Record.t_srno)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_trdt",SqlDbType.DateTime,21, Record.t_trdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_bohd",SqlDbType.VarChar,51, Record.t_bohd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_indv",SqlDbType.VarChar,51, Record.t_indv)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_srno",SqlDbType.Int,11, Record.t_srno)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_stat",SqlDbType.VarChar,21, Record.t_stat)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_proj",SqlDbType.VarChar,10, Record.t_proj)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_elem",SqlDbType.VarChar,9, Record.t_elem)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_user",SqlDbType.VarChar,10, Record.t_user)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntd",SqlDbType.Int,11, Record.t_Refcntd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntu",SqlDbType.Int,11, Record.t_Refcntu)
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
    Public Shared Function tpisg229Delete(ByVal Record As SIS.TPISG.tpisg229) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sptpisg229Delete"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_trdt",SqlDbType.DateTime,Record.t_trdt.ToString.Length, Record.t_trdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_bohd",SqlDbType.VarChar,Record.t_bohd.ToString.Length, Record.t_bohd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_indv",SqlDbType.VarChar,Record.t_indv.ToString.Length, Record.t_indv)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_srno",SqlDbType.Int,Record.t_srno.ToString.Length, Record.t_srno)
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
