Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.TPISG
  <DataObject()> _
  Partial Public Class tpisg230
    Private Shared _RecordCount As Integer
    Private _t_trdt As String = ""
    Private _t_bohd As String = ""
    Private _t_indv As String = ""
    Private _t_srno As Int32 = 0
    Private _t_dsno As Int32 = 0
    Private _t_stat As String = ""
    Private _t_proj As String = ""
    Private _t_elem As String = ""
    Private _t_dwno As String = ""
    Private _t_pitc As Int32 = 0
    Private _t_wght As Double = 0
    Private _t_atcd As String = ""
    Private _t_scup As Int32 = 0
    Private _t_acdt As String = ""
    Private _t_acfh As String = ""
    Private _t_pper As Single = 0
    Private _t_lupd As String = ""
    Private _t_Refcntd As Int32 = 0
    Private _t_Refcntu As Int32 = 0
    Private _t_numo As Int32 = 0
    Private _t_numq As Int32 = 0
    Private _t_numt As Int32 = 0
    Private _t_numv As Int32 = 0
    Private _t_nutc As Int32 = 0
    Private _t_cuni As String = ""
    Private _t_iref As String = ""
    Private _t_quan As Double = 0
    Private _t_iuom As String = ""
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
    Public Property t_dsno() As Int32
      Get
        Return _t_dsno
      End Get
      Set(ByVal value As Int32)
        _t_dsno = value
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
    Public Property t_dwno() As String
      Get
        Return _t_dwno
      End Get
      Set(ByVal value As String)
        _t_dwno = value
      End Set
    End Property
    Public Property t_pitc() As Int32
      Get
        Return _t_pitc
      End Get
      Set(ByVal value As Int32)
        _t_pitc = value
      End Set
    End Property
    Public Property t_wght() As Double
      Get
        Return _t_wght
      End Get
      Set(ByVal value As Double)
        _t_wght = value
      End Set
    End Property
    Public Property t_atcd() As String
      Get
        Return _t_atcd
      End Get
      Set(ByVal value As String)
        _t_atcd = value
      End Set
    End Property
    Public Property t_scup() As Int32
      Get
        Return _t_scup
      End Get
      Set(ByVal value As Int32)
        _t_scup = value
      End Set
    End Property
    Public Property t_acdt() As String
      Get
        If Not _t_acdt = String.Empty Then
          Return Convert.ToDateTime(_t_acdt).ToString("dd/MM/yyyy")
        End If
        Return _t_acdt
      End Get
      Set(ByVal value As String)
        _t_acdt = value
      End Set
    End Property
    Public Property t_acfh() As String
      Get
        If Not _t_acfh = String.Empty Then
          Return Convert.ToDateTime(_t_acfh).ToString("dd/MM/yyyy")
        End If
        Return _t_acfh
      End Get
      Set(ByVal value As String)
        _t_acfh = value
      End Set
    End Property
    Public Property t_pper() As Single
      Get
        Return _t_pper
      End Get
      Set(ByVal value As Single)
        _t_pper = value
      End Set
    End Property
    Public Property t_lupd() As String
      Get
        If Not _t_lupd = String.Empty Then
          Return Convert.ToDateTime(_t_lupd).ToString("dd/MM/yyyy")
        End If
        Return _t_lupd
      End Get
      Set(ByVal value As String)
        _t_lupd = value
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
    Public Property t_numo() As Int32
      Get
        Return _t_numo
      End Get
      Set(ByVal value As Int32)
        _t_numo = value
      End Set
    End Property
    Public Property t_numq() As Int32
      Get
        Return _t_numq
      End Get
      Set(ByVal value As Int32)
        _t_numq = value
      End Set
    End Property
    Public Property t_numt() As Int32
      Get
        Return _t_numt
      End Get
      Set(ByVal value As Int32)
        _t_numt = value
      End Set
    End Property
    Public Property t_numv() As Int32
      Get
        Return _t_numv
      End Get
      Set(ByVal value As Int32)
        _t_numv = value
      End Set
    End Property
    Public Property t_nutc() As Int32
      Get
        Return _t_nutc
      End Get
      Set(ByVal value As Int32)
        _t_nutc = value
      End Set
    End Property
    Public Property t_cuni() As String
      Get
        Return _t_cuni
      End Get
      Set(ByVal value As String)
        _t_cuni = value
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
    Public Property t_quan() As Double
      Get
        Return _t_quan
      End Get
      Set(ByVal value As Double)
        _t_quan = value
      End Set
    End Property
    Public Property t_iuom() As String
      Get
        Return _t_iuom
      End Get
      Set(ByVal value As String)
        _t_iuom = value
      End Set
    End Property
    Public ReadOnly Property DisplayField() As String
      Get
        Return ""
      End Get
    End Property
    Public ReadOnly Property PrimaryKey() As String
      Get
        Return _t_trdt & "|" & _t_bohd & "|" & _t_indv & "|" & _t_srno & "|" & _t_dsno
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
    Public Class PKtpisg230
      Private _t_trdt As String = ""
      Private _t_bohd As String = ""
      Private _t_indv As String = ""
      Private _t_srno As Int32 = 0
      Private _t_dsno As Int32 = 0
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
      Public Property t_dsno() As Int32
        Get
          Return _t_dsno
        End Get
        Set(ByVal value As Int32)
          _t_dsno = value
        End Set
      End Property
    End Class
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function tpisg230GetNewRecord() As SIS.TPISG.tpisg230
      Return New SIS.TPISG.tpisg230()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function tpisg230GetByID(ByVal t_trdt As DateTime, ByVal t_bohd As String, ByVal t_indv As String, ByVal t_srno As Int32, ByVal t_dsno As Int32) As SIS.TPISG.tpisg230
      Dim Results As SIS.TPISG.tpisg230 = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sptpisg230SelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_trdt", SqlDbType.DateTime, t_trdt.ToString.Length, t_trdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_bohd", SqlDbType.VarChar, t_bohd.ToString.Length, t_bohd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_indv", SqlDbType.VarChar, t_indv.ToString.Length, t_indv)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_srno", SqlDbType.Int, t_srno.ToString.Length, t_srno)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dsno", SqlDbType.Int, t_dsno.ToString.Length, t_dsno)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.TPISG.tpisg230(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)>
    Public Shared Function tpisg230SelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.TPISG.tpisg230)
      Dim Results As List(Of SIS.TPISG.tpisg230) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "sptpisg230SelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "sptpisg230SelectListFilteres"
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.TPISG.tpisg230)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.TPISG.tpisg230(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function tpisg230SelectCount(ByVal SearchState As Boolean, ByVal SearchText As String) As Integer
      Return _RecordCount
    End Function
    'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Insert, True)>
    Public Shared Function tpisg230Insert(ByVal Record As SIS.TPISG.tpisg230) As SIS.TPISG.tpisg230
      Dim _Rec As SIS.TPISG.tpisg230 = SIS.TPISG.tpisg230.tpisg230GetNewRecord()
      With _Rec
        .t_trdt = Record.t_trdt
        .t_bohd = Record.t_bohd
        .t_indv = Record.t_indv
        .t_srno = Record.t_srno
        .t_dsno = Record.t_dsno
        .t_stat = Record.t_stat
        .t_proj = Record.t_proj
        .t_elem = Record.t_elem
        .t_dwno = Record.t_dwno
        .t_pitc = Record.t_pitc
        .t_wght = Record.t_wght
        .t_atcd = Record.t_atcd
        .t_scup = Record.t_scup
        .t_acdt = Record.t_acdt
        .t_acfh = Record.t_acfh
        .t_pper = Record.t_pper
        .t_lupd = Record.t_lupd
        .t_Refcntd = Record.t_Refcntd
        .t_Refcntu = Record.t_Refcntu
        .t_numo = Record.t_numo
        .t_numq = Record.t_numq
        .t_numt = Record.t_numt
        .t_numv = Record.t_numv
        .t_nutc = Record.t_nutc
        .t_cuni = Record.t_cuni
        .t_iref = Record.t_iref
        .t_quan = Record.t_quan
        .t_iuom = Record.t_iuom
      End With
      Return SIS.TPISG.tpisg230.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.TPISG.tpisg230) As SIS.TPISG.tpisg230
      Dim Comp As String = "200"
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sptpisg230" & Comp & "Insert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_trdt", SqlDbType.DateTime, 21, Record.t_trdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_bohd", SqlDbType.VarChar, 51, Record.t_bohd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_indv", SqlDbType.VarChar, 101, Record.t_indv)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_srno", SqlDbType.Int, 11, Record.t_srno)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dsno", SqlDbType.Int, 11, Record.t_dsno)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_stat", SqlDbType.VarChar, 51, Record.t_stat)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_proj", SqlDbType.VarChar, 10, Record.t_proj)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_elem", SqlDbType.VarChar, 9, Record.t_elem)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dwno", SqlDbType.VarChar, 33, Record.t_dwno)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pitc", SqlDbType.Int, 11, Record.t_pitc)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_wght", SqlDbType.Float, 16, Record.t_wght)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_atcd", SqlDbType.VarChar, 9, Record.t_atcd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_scup", SqlDbType.Int, 11, Record.t_scup)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_acdt", SqlDbType.DateTime, 21, Record.t_acdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_acfh", SqlDbType.DateTime, 21, Record.t_acfh)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pper", SqlDbType.Real, 8, Record.t_pper)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_lupd", SqlDbType.DateTime, 21, Record.t_lupd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntd", SqlDbType.Int, 11, Record.t_Refcntd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntu", SqlDbType.Int, 11, Record.t_Refcntu)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_numo", SqlDbType.Int, 11, Record.t_numo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_numq", SqlDbType.Int, 11, Record.t_numq)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_numt", SqlDbType.Int, 11, Record.t_numt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_numv", SqlDbType.Int, 11, Record.t_numv)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_nutc", SqlDbType.Int, 11, Record.t_nutc)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cuni", SqlDbType.VarChar, 4, Record.t_cuni)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_iref", SqlDbType.VarChar, 151, Record.t_iref)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_quan", SqlDbType.Float, 16, Record.t_quan)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_iuom", SqlDbType.VarChar, 4, Record.t_iuom)
          Cmd.Parameters.Add("@Return_t_trdt", SqlDbType.DateTime, 21)
          Cmd.Parameters("@Return_t_trdt").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_bohd", SqlDbType.VarChar, 51)
          Cmd.Parameters("@Return_t_bohd").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_indv", SqlDbType.VarChar, 101)
          Cmd.Parameters("@Return_t_indv").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_srno", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_t_srno").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_dsno", SqlDbType.Int, 11)
          Cmd.Parameters("@Return_t_dsno").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.t_trdt = Cmd.Parameters("@Return_t_trdt").Value
          Record.t_bohd = Cmd.Parameters("@Return_t_bohd").Value
          Record.t_indv = Cmd.Parameters("@Return_t_indv").Value
          Record.t_srno = Cmd.Parameters("@Return_t_srno").Value
          Record.t_dsno = Cmd.Parameters("@Return_t_dsno").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)>
    Public Shared Function tpisg230Update(ByVal Record As SIS.TPISG.tpisg230) As SIS.TPISG.tpisg230
      Dim _Rec As SIS.TPISG.tpisg230 = SIS.TPISG.tpisg230.tpisg230GetByID(Record.t_trdt, Record.t_bohd, Record.t_indv, Record.t_srno, Record.t_dsno)
      With _Rec
        .t_stat = Record.t_stat
        .t_proj = Record.t_proj
        .t_elem = Record.t_elem
        .t_dwno = Record.t_dwno
        .t_pitc = Record.t_pitc
        .t_wght = Record.t_wght
        .t_atcd = Record.t_atcd
        .t_scup = Record.t_scup
        .t_acdt = Record.t_acdt
        .t_acfh = Record.t_acfh
        .t_pper = Record.t_pper
        .t_lupd = Record.t_lupd
        .t_Refcntd = Record.t_Refcntd
        .t_Refcntu = Record.t_Refcntu
        .t_numo = Record.t_numo
        .t_numq = Record.t_numq
        .t_numt = Record.t_numt
        .t_numv = Record.t_numv
        .t_nutc = Record.t_nutc
        .t_cuni = Record.t_cuni
        .t_iref = Record.t_iref
        .t_quan = Record.t_quan
        .t_iuom = Record.t_iuom
      End With
      Return SIS.TPISG.tpisg230.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.TPISG.tpisg230) As SIS.TPISG.tpisg230
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sptpisg230Update"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_trdt", SqlDbType.DateTime, 21, Record.t_trdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_bohd", SqlDbType.VarChar, 51, Record.t_bohd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_indv", SqlDbType.VarChar, 101, Record.t_indv)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_srno", SqlDbType.Int, 11, Record.t_srno)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_dsno", SqlDbType.Int, 11, Record.t_dsno)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_trdt", SqlDbType.DateTime, 21, Record.t_trdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_bohd", SqlDbType.VarChar, 51, Record.t_bohd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_indv", SqlDbType.VarChar, 101, Record.t_indv)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_srno", SqlDbType.Int, 11, Record.t_srno)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dsno", SqlDbType.Int, 11, Record.t_dsno)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_stat", SqlDbType.VarChar, 51, Record.t_stat)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_proj", SqlDbType.VarChar, 10, Record.t_proj)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_elem", SqlDbType.VarChar, 9, Record.t_elem)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dwno", SqlDbType.VarChar, 33, Record.t_dwno)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pitc", SqlDbType.Int, 11, Record.t_pitc)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_wght", SqlDbType.Float, 16, Record.t_wght)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_atcd", SqlDbType.VarChar, 9, Record.t_atcd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_scup", SqlDbType.Int, 11, Record.t_scup)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_acdt", SqlDbType.DateTime, 21, Record.t_acdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_acfh", SqlDbType.DateTime, 21, Record.t_acfh)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pper", SqlDbType.Real, 8, Record.t_pper)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_lupd", SqlDbType.DateTime, 21, Record.t_lupd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntd", SqlDbType.Int, 11, Record.t_Refcntd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntu", SqlDbType.Int, 11, Record.t_Refcntu)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_numo", SqlDbType.Int, 11, Record.t_numo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_numq", SqlDbType.Int, 11, Record.t_numq)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_numt", SqlDbType.Int, 11, Record.t_numt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_numv", SqlDbType.Int, 11, Record.t_numv)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_nutc", SqlDbType.Int, 11, Record.t_nutc)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cuni", SqlDbType.VarChar, 4, Record.t_cuni)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_iref", SqlDbType.VarChar, 151, Record.t_iref)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_quan", SqlDbType.Float, 16, Record.t_quan)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_iuom", SqlDbType.VarChar, 4, Record.t_iuom)
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
    Public Shared Function tpisg230Delete(ByVal Record As SIS.TPISG.tpisg230) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sptpisg230Delete"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_trdt",SqlDbType.DateTime,Record.t_trdt.ToString.Length, Record.t_trdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_bohd",SqlDbType.VarChar,Record.t_bohd.ToString.Length, Record.t_bohd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_indv",SqlDbType.VarChar,Record.t_indv.ToString.Length, Record.t_indv)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_srno",SqlDbType.Int,Record.t_srno.ToString.Length, Record.t_srno)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_dsno",SqlDbType.Int,Record.t_dsno.ToString.Length, Record.t_dsno)
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
