Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.TPISG
  <DataObject()> _
  Partial Public Class tpisg207
    Private Shared _RecordCount As Integer
    Private _t_inid As Int32 = 0
    Private _t_date As String = ""
    Private _t_pono As String = ""
    Private _t_iref As String = ""
    Private _t_sitm As String = ""
    Private _t_prpo As Single = 0
    Private _t_mode As Int32 = 0
    Private _t_bohd As String = ""
    Private _t_Refcntd As Int32 = 0
    Private _t_Refcntu As Int32 = 0
    Private _t_powt As Double = 0
    Private _t_cprj As String = ""
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
    Public Property t_inid() As Int32
      Get
        Return _t_inid
      End Get
      Set(ByVal value As Int32)
        _t_inid = value
      End Set
    End Property
    Public Property t_date() As String
      Get
        If Not _t_date = String.Empty Then
          Return Convert.ToDateTime(_t_date).ToString("dd/MM/yyyy HH:mm:ss")
        End If
        Return _t_date
      End Get
      Set(ByVal value As String)
         _t_date = value
      End Set
    End Property
    Public Property t_pono() As String
      Get
        Return _t_pono
      End Get
      Set(ByVal value As String)
        _t_pono = value
      End Set
    End Property
    Public Property t_iref() As String
      Get
        Return _t_iref
      End Get
      Set(ByVal value As String)
        _t_iref = value
      End Set
    End Property
    Public Property t_sitm() As String
      Get
        Return _t_sitm
      End Get
      Set(ByVal value As String)
        _t_sitm = value
      End Set
    End Property
    Public Property t_prpo() As Single
      Get
        Return _t_prpo
      End Get
      Set(ByVal value As Single)
        _t_prpo = value
      End Set
    End Property
    Public Property t_mode() As Int32
      Get
        Return _t_mode
      End Get
      Set(ByVal value As Int32)
        _t_mode = value
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
    Public Property t_powt() As Double
      Get
        Return _t_powt
      End Get
      Set(ByVal value As Double)
        _t_powt = value
      End Set
    End Property
    Public Property t_cprj() As String
      Get
        Return _t_cprj
      End Get
      Set(ByVal value As String)
        _t_cprj = value
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return ""
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _t_inid & "|" & _t_pono & "|" & _t_iref & "|" & _t_sitm & "|" & _t_mode & "|" & _t_bohd
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
    Public Class PKtpisg207
      Private _t_inid As Int32 = 0
      Private _t_pono As String = ""
      Private _t_iref As String = ""
      Private _t_sitm As String = ""
      Private _t_mode As Int32 = 0
      Private _t_bohd As String = ""
      Public Property t_inid() As Int32
        Get
          Return _t_inid
        End Get
        Set(ByVal value As Int32)
          _t_inid = value
        End Set
      End Property
      Public Property t_pono() As String
        Get
          Return _t_pono
        End Get
        Set(ByVal value As String)
          _t_pono = value
        End Set
      End Property
      Public Property t_iref() As String
        Get
          Return _t_iref
        End Get
        Set(ByVal value As String)
          _t_iref = value
        End Set
      End Property
      Public Property t_sitm() As String
        Get
          Return _t_sitm
        End Get
        Set(ByVal value As String)
          _t_sitm = value
        End Set
      End Property
      Public Property t_mode() As Int32
        Get
          Return _t_mode
        End Get
        Set(ByVal value As Int32)
          _t_mode = value
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
    End Class
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function tpisg207GetNewRecord() As SIS.TPISG.tpisg207
      Return New SIS.TPISG.tpisg207()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function tpisg207GetByID(ByVal t_inid As Int32, ByVal t_pono As String, ByVal t_iref As String, ByVal t_sitm As String, ByVal t_mode As Int32, ByVal t_bohd As String) As SIS.TPISG.tpisg207
      Dim Results As SIS.TPISG.tpisg207 = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sptpisg207SelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_inid",SqlDbType.Int,t_inid.ToString.Length, t_inid)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pono",SqlDbType.VarChar,t_pono.ToString.Length, t_pono)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_iref",SqlDbType.VarChar,t_iref.ToString.Length, t_iref)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sitm",SqlDbType.VarChar,t_sitm.ToString.Length, t_sitm)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_mode",SqlDbType.Int,t_mode.ToString.Length, t_mode)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_bohd",SqlDbType.VarChar,t_bohd.ToString.Length, t_bohd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.TPISG.tpisg207(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function tpisg207SelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.TPISG.tpisg207)
      Dim Results As List(Of SIS.TPISG.tpisg207) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "sptpisg207SelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "sptpisg207SelectListFilteres"
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.TPISG.tpisg207)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.TPISG.tpisg207(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function tpisg207SelectCount(ByVal SearchState As Boolean, ByVal SearchText As String) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function tpisg207Insert(ByVal Record As SIS.TPISG.tpisg207) As SIS.TPISG.tpisg207
      Dim _Rec As SIS.TPISG.tpisg207 = SIS.TPISG.tpisg207.tpisg207GetNewRecord()
      With _Rec
        .t_inid = Record.t_inid
        .t_date = Record.t_date
        .t_pono = Record.t_pono
        .t_iref = Record.t_iref
        .t_sitm = Record.t_sitm
        .t_prpo = Record.t_prpo
        .t_mode = Record.t_mode
        .t_bohd = Record.t_bohd
        .t_Refcntd = Record.t_Refcntd
        .t_Refcntu = Record.t_Refcntu
        .t_powt = Record.t_powt
        .t_cprj = Record.t_cprj
      End With
      Return SIS.TPISG.tpisg207.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.TPISG.tpisg207) As SIS.TPISG.tpisg207
      Dim Comp As String = "200"
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sptpisg207" & Comp & "Insert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_inid",SqlDbType.Int,11, Record.t_inid)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_date",SqlDbType.DateTime,21, Record.t_date)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pono",SqlDbType.VarChar,10, Record.t_pono)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_iref",SqlDbType.VarChar,201, Record.t_iref)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sitm",SqlDbType.VarChar,10, Record.t_sitm)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_prpo",SqlDbType.Real,8, Record.t_prpo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_mode",SqlDbType.Int,11, Record.t_mode)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_bohd",SqlDbType.VarChar,51, Record.t_bohd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntd",SqlDbType.Int,11, Record.t_Refcntd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntu",SqlDbType.Int,11, Record.t_Refcntu)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_powt",SqlDbType.Float,16, Record.t_powt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cprj",SqlDbType.VarChar,10, Record.t_cprj)
          Cmd.Parameters.Add("@Return_t_inid", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_t_inid").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_pono", SqlDbType.VarChar, 10)
          Cmd.Parameters("@Return_t_pono").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_iref", SqlDbType.VarChar, 201)
          Cmd.Parameters("@Return_t_iref").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_sitm", SqlDbType.VarChar, 10)
          Cmd.Parameters("@Return_t_sitm").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_mode", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_t_mode").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_bohd", SqlDbType.VarChar, 51)
          Cmd.Parameters("@Return_t_bohd").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.t_inid = Cmd.Parameters("@Return_t_inid").Value
          Record.t_pono = Cmd.Parameters("@Return_t_pono").Value
          Record.t_iref = Cmd.Parameters("@Return_t_iref").Value
          Record.t_sitm = Cmd.Parameters("@Return_t_sitm").Value
          Record.t_mode = Cmd.Parameters("@Return_t_mode").Value
          Record.t_bohd = Cmd.Parameters("@Return_t_bohd").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function tpisg207Update(ByVal Record As SIS.TPISG.tpisg207) As SIS.TPISG.tpisg207
      Dim _Rec As SIS.TPISG.tpisg207 = SIS.TPISG.tpisg207.tpisg207GetByID(Record.t_inid, Record.t_pono, Record.t_iref, Record.t_sitm, Record.t_mode, Record.t_bohd)
      With _Rec
        .t_date = Record.t_date
        .t_prpo = Record.t_prpo
        .t_Refcntd = Record.t_Refcntd
        .t_Refcntu = Record.t_Refcntu
        .t_powt = Record.t_powt
        .t_cprj = Record.t_cprj
      End With
      Return SIS.TPISG.tpisg207.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.TPISG.tpisg207) As SIS.TPISG.tpisg207
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sptpisg207Update"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_inid",SqlDbType.Int,11, Record.t_inid)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_pono",SqlDbType.VarChar,10, Record.t_pono)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_iref",SqlDbType.VarChar,201, Record.t_iref)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_sitm",SqlDbType.VarChar,10, Record.t_sitm)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_mode",SqlDbType.Int,11, Record.t_mode)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_bohd",SqlDbType.VarChar,51, Record.t_bohd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_inid",SqlDbType.Int,11, Record.t_inid)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_date",SqlDbType.DateTime,21, Record.t_date)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pono",SqlDbType.VarChar,10, Record.t_pono)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_iref",SqlDbType.VarChar,201, Record.t_iref)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sitm",SqlDbType.VarChar,10, Record.t_sitm)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_prpo",SqlDbType.Real,8, Record.t_prpo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_mode",SqlDbType.Int,11, Record.t_mode)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_bohd",SqlDbType.VarChar,51, Record.t_bohd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntd",SqlDbType.Int,11, Record.t_Refcntd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntu",SqlDbType.Int,11, Record.t_Refcntu)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_powt",SqlDbType.Float,16, Record.t_powt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cprj",SqlDbType.VarChar,10, Record.t_cprj)
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
    Public Shared Function tpisg207Delete(ByVal Record As SIS.TPISG.tpisg207) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sptpisg207Delete"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_inid",SqlDbType.Int,Record.t_inid.ToString.Length, Record.t_inid)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_pono",SqlDbType.VarChar,Record.t_pono.ToString.Length, Record.t_pono)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_iref",SqlDbType.VarChar,Record.t_iref.ToString.Length, Record.t_iref)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_sitm",SqlDbType.VarChar,Record.t_sitm.ToString.Length, Record.t_sitm)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_mode",SqlDbType.Int,Record.t_mode.ToString.Length, Record.t_mode)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_bohd",SqlDbType.VarChar,Record.t_bohd.ToString.Length, Record.t_bohd)
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
