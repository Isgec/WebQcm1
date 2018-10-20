Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.TPISG
  <DataObject()> _
  Partial Public Class tpisg220
    Private Shared _RecordCount As Integer
    Private _t_cprj As String = ""
    Private _t_pcod As String = ""
    Private _t_schd As Int32 = 0
    Private _t_cact As String = ""
    Private _t_actp As Int32 = 0
    Private _t_pact As String = ""
    Private _t_bcod As String = ""
    Private _t_dura As Int32 = 0
    Private _t_sdst As String = ""
    Private _t_sdfn As String = ""
    Private _t_acsd As String = ""
    Private _t_acfn As String = ""
    Private _t_bohd As String = ""
    Private _t_pred As String = ""
    Private _t_succ As String = ""
    Private _t_desc As String = ""
    Private _t_acty As String = ""
    Private _t_dept As String = ""
    Private _t_vali As Int32 = 0
    Private _t_outl As Int32 = 0
    Private _t_sub1 As String = ""
    Private _t_sub2 As String = ""
    Private _t_sub3 As String = ""
    Private _t_sub4 As String = ""
    Private _t_amod As String = ""
    Private _t_pcbs As String = ""
    Private _t_exdo As Int32 = 0
    Private _t_cpgv As Double = 0
    Private _t_otsd As String = ""
    Private _t_oted As String = ""
    Private _t_rmks As String = ""
    Private _t_gps1 As String = ""
    Private _t_gps2 As String = ""
    Private _t_gps3 As String = ""
    Private _t_gps4 As String = ""
    Private _t_pper As Single = 0
    Private _t_valu As Double = 0
    Private _t_sele As Int32 = 0
    Private _t_Refcntd As Int32 = 0
    Private _t_Refcntu As Int32 = 0
    Private _t_numo As Int32 = 0
    Private _t_numq As Int32 = 0
    Private _t_numt As Int32 = 0
    Private _t_numv As Int32 = 0
    Private _t_nutc As Int32 = 0
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
    Public Property t_cprj() As String
      Get
        Return _t_cprj
      End Get
      Set(ByVal value As String)
        _t_cprj = value
      End Set
    End Property
    Public Property t_pcod() As String
      Get
        Return _t_pcod
      End Get
      Set(ByVal value As String)
        _t_pcod = value
      End Set
    End Property
    Public Property t_schd() As Int32
      Get
        Return _t_schd
      End Get
      Set(ByVal value As Int32)
        _t_schd = value
      End Set
    End Property
    Public Property t_cact() As String
      Get
        Return _t_cact
      End Get
      Set(ByVal value As String)
        _t_cact = value
      End Set
    End Property
    Public Property t_actp() As Int32
      Get
        Return _t_actp
      End Get
      Set(ByVal value As Int32)
        _t_actp = value
      End Set
    End Property
    Public Property t_pact() As String
      Get
        Return _t_pact
      End Get
      Set(ByVal value As String)
        _t_pact = value
      End Set
    End Property
    Public Property t_bcod() As String
      Get
        Return _t_bcod
      End Get
      Set(ByVal value As String)
        _t_bcod = value
      End Set
    End Property
    Public Property t_dura() As Int32
      Get
        Return _t_dura
      End Get
      Set(ByVal value As Int32)
        _t_dura = value
      End Set
    End Property
    Public Property t_sdst() As String
      Get
        If Not _t_sdst = String.Empty Then
          Return Convert.ToDateTime(_t_sdst).ToString("dd/MM/yyyy")
        End If
        Return _t_sdst
      End Get
      Set(ByVal value As String)
         _t_sdst = value
      End Set
    End Property
    Public Property t_sdfn() As String
      Get
        If Not _t_sdfn = String.Empty Then
          Return Convert.ToDateTime(_t_sdfn).ToString("dd/MM/yyyy")
        End If
        Return _t_sdfn
      End Get
      Set(ByVal value As String)
         _t_sdfn = value
      End Set
    End Property
    Public Property t_acsd() As String
      Get
        If Not _t_acsd = String.Empty Then
          Return Convert.ToDateTime(_t_acsd).ToString("dd/MM/yyyy")
        End If
        Return _t_acsd
      End Get
      Set(ByVal value As String)
         _t_acsd = value
      End Set
    End Property
    Public Property t_acfn() As String
      Get
        If Not _t_acfn = String.Empty Then
          Return Convert.ToDateTime(_t_acfn).ToString("dd/MM/yyyy")
        End If
        Return _t_acfn
      End Get
      Set(ByVal value As String)
         _t_acfn = value
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
    Public Property t_pred() As String
      Get
        Return _t_pred
      End Get
      Set(ByVal value As String)
        _t_pred = value
      End Set
    End Property
    Public Property t_succ() As String
      Get
        Return _t_succ
      End Get
      Set(ByVal value As String)
        _t_succ = value
      End Set
    End Property
    Public Property t_desc() As String
      Get
        Return _t_desc
      End Get
      Set(ByVal value As String)
        _t_desc = value
      End Set
    End Property
    Public Property t_acty() As String
      Get
        Return _t_acty
      End Get
      Set(ByVal value As String)
        _t_acty = value
      End Set
    End Property
    Public Property t_dept() As String
      Get
        Return _t_dept
      End Get
      Set(ByVal value As String)
        _t_dept = value
      End Set
    End Property
    Public Property t_vali() As Int32
      Get
        Return _t_vali
      End Get
      Set(ByVal value As Int32)
        _t_vali = value
      End Set
    End Property
    Public Property t_outl() As Int32
      Get
        Return _t_outl
      End Get
      Set(ByVal value As Int32)
        _t_outl = value
      End Set
    End Property
    Public Property t_sub1() As String
      Get
        Return _t_sub1
      End Get
      Set(ByVal value As String)
        _t_sub1 = value
      End Set
    End Property
    Public Property t_sub2() As String
      Get
        Return _t_sub2
      End Get
      Set(ByVal value As String)
        _t_sub2 = value
      End Set
    End Property
    Public Property t_sub3() As String
      Get
        Return _t_sub3
      End Get
      Set(ByVal value As String)
        _t_sub3 = value
      End Set
    End Property
    Public Property t_sub4() As String
      Get
        Return _t_sub4
      End Get
      Set(ByVal value As String)
        _t_sub4 = value
      End Set
    End Property
    Public Property t_amod() As String
      Get
        Return _t_amod
      End Get
      Set(ByVal value As String)
        _t_amod = value
      End Set
    End Property
    Public Property t_pcbs() As String
      Get
        Return _t_pcbs
      End Get
      Set(ByVal value As String)
        _t_pcbs = value
      End Set
    End Property
    Public Property t_exdo() As Int32
      Get
        Return _t_exdo
      End Get
      Set(ByVal value As Int32)
        _t_exdo = value
      End Set
    End Property
    Public Property t_cpgv() As Double
      Get
        Return _t_cpgv
      End Get
      Set(ByVal value As Double)
        _t_cpgv = value
      End Set
    End Property
    Public Property t_otsd() As String
      Get
        If Not _t_otsd = String.Empty Then
          Return Convert.ToDateTime(_t_otsd).ToString("dd/MM/yyyy")
        End If
        Return _t_otsd
      End Get
      Set(ByVal value As String)
         _t_otsd = value
      End Set
    End Property
    Public Property t_oted() As String
      Get
        If Not _t_oted = String.Empty Then
          Return Convert.ToDateTime(_t_oted).ToString("dd/MM/yyyy")
        End If
        Return _t_oted
      End Get
      Set(ByVal value As String)
         _t_oted = value
      End Set
    End Property
    Public Property t_rmks() As String
      Get
        Return _t_rmks
      End Get
      Set(ByVal value As String)
        _t_rmks = value
      End Set
    End Property
    Public Property t_gps1() As String
      Get
        Return _t_gps1
      End Get
      Set(ByVal value As String)
        _t_gps1 = value
      End Set
    End Property
    Public Property t_gps2() As String
      Get
        Return _t_gps2
      End Get
      Set(ByVal value As String)
        _t_gps2 = value
      End Set
    End Property
    Public Property t_gps3() As String
      Get
        Return _t_gps3
      End Get
      Set(ByVal value As String)
        _t_gps3 = value
      End Set
    End Property
    Public Property t_gps4() As String
      Get
        Return _t_gps4
      End Get
      Set(ByVal value As String)
        _t_gps4 = value
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
    Public Property t_valu() As Double
      Get
        Return _t_valu
      End Get
      Set(ByVal value As Double)
        _t_valu = value
      End Set
    End Property
    Public Property t_sele() As Int32
      Get
        Return _t_sele
      End Get
      Set(ByVal value As Int32)
        _t_sele = value
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
    Public Readonly Property DisplayField() As String
      Get
        Return ""
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _t_cprj & "|" & _t_pcod & "|" & _t_cact
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
    Public Class PKtpisg220
      Private _t_cprj As String = ""
      Private _t_pcod As String = ""
      Private _t_cact As String = ""
      Public Property t_cprj() As String
        Get
          Return _t_cprj
        End Get
        Set(ByVal value As String)
          _t_cprj = value
        End Set
      End Property
      Public Property t_pcod() As String
        Get
          Return _t_pcod
        End Get
        Set(ByVal value As String)
          _t_pcod = value
        End Set
      End Property
      Public Property t_cact() As String
        Get
          Return _t_cact
        End Get
        Set(ByVal value As String)
          _t_cact = value
        End Set
      End Property
    End Class
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function tpisg220GetNewRecord() As SIS.TPISG.tpisg220
      Return New SIS.TPISG.tpisg220()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function tpisg220GetByID(ByVal t_cprj As String, ByVal t_pcod As String, ByVal t_cact As String) As SIS.TPISG.tpisg220
      Dim Results As SIS.TPISG.tpisg220 = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sptpisg220SelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cprj",SqlDbType.VarChar,t_cprj.ToString.Length, t_cprj)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pcod",SqlDbType.VarChar,t_pcod.ToString.Length, t_pcod)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cact",SqlDbType.VarChar,t_cact.ToString.Length, t_cact)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.TPISG.tpisg220(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function tpisg220SelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.TPISG.tpisg220)
      Dim Results As List(Of SIS.TPISG.tpisg220) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "sptpisg220SelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "sptpisg220SelectListFilteres"
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.TPISG.tpisg220)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.TPISG.tpisg220(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function tpisg220SelectCount(ByVal SearchState As Boolean, ByVal SearchText As String) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function tpisg220Insert(ByVal Record As SIS.TPISG.tpisg220) As SIS.TPISG.tpisg220
      Dim _Rec As SIS.TPISG.tpisg220 = SIS.TPISG.tpisg220.tpisg220GetNewRecord()
      With _Rec
        .t_cprj = Record.t_cprj
        .t_pcod = Record.t_pcod
        .t_schd = Record.t_schd
        .t_cact = Record.t_cact
        .t_actp = Record.t_actp
        .t_pact = Record.t_pact
        .t_bcod = Record.t_bcod
        .t_dura = Record.t_dura
        .t_sdst = Record.t_sdst
        .t_sdfn = Record.t_sdfn
        .t_acsd = Record.t_acsd
        .t_acfn = Record.t_acfn
        .t_bohd = Record.t_bohd
        .t_pred = Record.t_pred
        .t_succ = Record.t_succ
        .t_desc = Record.t_desc
        .t_acty = Record.t_acty
        .t_dept = Record.t_dept
        .t_vali = Record.t_vali
        .t_outl = Record.t_outl
        .t_sub1 = Record.t_sub1
        .t_sub2 = Record.t_sub2
        .t_sub3 = Record.t_sub3
        .t_sub4 = Record.t_sub4
        .t_amod = Record.t_amod
        .t_pcbs = Record.t_pcbs
        .t_exdo = Record.t_exdo
        .t_cpgv = Record.t_cpgv
        .t_otsd = Record.t_otsd
        .t_oted = Record.t_oted
        .t_rmks = Record.t_rmks
        .t_gps1 = Record.t_gps1
        .t_gps2 = Record.t_gps2
        .t_gps3 = Record.t_gps3
        .t_gps4 = Record.t_gps4
        .t_pper = Record.t_pper
        .t_valu = Record.t_valu
        .t_sele = Record.t_sele
        .t_Refcntd = Record.t_Refcntd
        .t_Refcntu = Record.t_Refcntu
        .t_numo = Record.t_numo
        .t_numq = Record.t_numq
        .t_numt = Record.t_numt
        .t_numv = Record.t_numv
        .t_nutc = Record.t_nutc
      End With
      Return SIS.TPISG.tpisg220.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.TPISG.tpisg220) As SIS.TPISG.tpisg220
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sptpisg220Insert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cprj",SqlDbType.VarChar,10, Record.t_cprj)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pcod",SqlDbType.VarChar,10, Record.t_pcod)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_schd",SqlDbType.Int,11, Record.t_schd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cact",SqlDbType.VarChar,31, Record.t_cact)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_actp",SqlDbType.Int,11, Record.t_actp)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pact",SqlDbType.VarChar,31, Record.t_pact)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_bcod",SqlDbType.VarChar,10, Record.t_bcod)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dura",SqlDbType.Int,11, Record.t_dura)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sdst",SqlDbType.DateTime,21, Record.t_sdst)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sdfn",SqlDbType.DateTime,21, Record.t_sdfn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_acsd",SqlDbType.DateTime,21, Record.t_acsd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_acfn",SqlDbType.DateTime,21, Record.t_acfn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_bohd",SqlDbType.VarChar,21, Record.t_bohd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pred",SqlDbType.VarChar,201, Record.t_pred)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_succ",SqlDbType.VarChar,201, Record.t_succ)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_desc",SqlDbType.VarChar,257, Record.t_desc)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_acty",SqlDbType.VarChar,10, Record.t_acty)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dept",SqlDbType.VarChar,10, Record.t_dept)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_vali",SqlDbType.Int,11, Record.t_vali)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_outl",SqlDbType.Int,11, Record.t_outl)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sub1",SqlDbType.VarChar,201, Record.t_sub1)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sub2",SqlDbType.VarChar,151, Record.t_sub2)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sub3",SqlDbType.VarChar,151, Record.t_sub3)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sub4",SqlDbType.VarChar,151, Record.t_sub4)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_amod",SqlDbType.VarChar,21, Record.t_amod)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pcbs",SqlDbType.VarChar,21, Record.t_pcbs)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_exdo",SqlDbType.Int,11, Record.t_exdo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cpgv",SqlDbType.Float,16, Record.t_cpgv)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_otsd",SqlDbType.DateTime,21, Record.t_otsd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_oted",SqlDbType.DateTime,21, Record.t_oted)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rmks",SqlDbType.VarChar,501, Record.t_rmks)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_gps1",SqlDbType.VarChar,101, Record.t_gps1)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_gps2",SqlDbType.VarChar,101, Record.t_gps2)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_gps3",SqlDbType.VarChar,101, Record.t_gps3)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_gps4",SqlDbType.VarChar,251, Record.t_gps4)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pper",SqlDbType.Real,8, Record.t_pper)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_valu",SqlDbType.Float,16, Record.t_valu)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sele",SqlDbType.Int,11, Record.t_sele)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntd",SqlDbType.Int,11, Record.t_Refcntd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntu",SqlDbType.Int,11, Record.t_Refcntu)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_numo",SqlDbType.Int,11, Record.t_numo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_numq",SqlDbType.Int,11, Record.t_numq)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_numt",SqlDbType.Int,11, Record.t_numt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_numv",SqlDbType.Int,11, Record.t_numv)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_nutc",SqlDbType.Int,11, Record.t_nutc)
          Cmd.Parameters.Add("@Return_t_cprj", SqlDbType.VarChar, 10)
          Cmd.Parameters("@Return_t_cprj").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_pcod", SqlDbType.VarChar, 10)
          Cmd.Parameters("@Return_t_pcod").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_cact", SqlDbType.VarChar, 31)
          Cmd.Parameters("@Return_t_cact").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.t_cprj = Cmd.Parameters("@Return_t_cprj").Value
          Record.t_pcod = Cmd.Parameters("@Return_t_pcod").Value
          Record.t_cact = Cmd.Parameters("@Return_t_cact").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function tpisg220Update(ByVal Record As SIS.TPISG.tpisg220) As SIS.TPISG.tpisg220
      Dim _Rec As SIS.TPISG.tpisg220 = SIS.TPISG.tpisg220.tpisg220GetByID(Record.t_cprj, Record.t_pcod, Record.t_cact)
      With _Rec
        .t_schd = Record.t_schd
        .t_actp = Record.t_actp
        .t_pact = Record.t_pact
        .t_bcod = Record.t_bcod
        .t_dura = Record.t_dura
        .t_sdst = Record.t_sdst
        .t_sdfn = Record.t_sdfn
        .t_acsd = Record.t_acsd
        .t_acfn = Record.t_acfn
        .t_bohd = Record.t_bohd
        .t_pred = Record.t_pred
        .t_succ = Record.t_succ
        .t_desc = Record.t_desc
        .t_acty = Record.t_acty
        .t_dept = Record.t_dept
        .t_vali = Record.t_vali
        .t_outl = Record.t_outl
        .t_sub1 = Record.t_sub1
        .t_sub2 = Record.t_sub2
        .t_sub3 = Record.t_sub3
        .t_sub4 = Record.t_sub4
        .t_amod = Record.t_amod
        .t_pcbs = Record.t_pcbs
        .t_exdo = Record.t_exdo
        .t_cpgv = Record.t_cpgv
        .t_otsd = Record.t_otsd
        .t_oted = Record.t_oted
        .t_rmks = Record.t_rmks
        .t_gps1 = Record.t_gps1
        .t_gps2 = Record.t_gps2
        .t_gps3 = Record.t_gps3
        .t_gps4 = Record.t_gps4
        .t_pper = Record.t_pper
        .t_valu = Record.t_valu
        .t_sele = Record.t_sele
        .t_Refcntd = Record.t_Refcntd
        .t_Refcntu = Record.t_Refcntu
        .t_numo = Record.t_numo
        .t_numq = Record.t_numq
        .t_numt = Record.t_numt
        .t_numv = Record.t_numv
        .t_nutc = Record.t_nutc
      End With
      Return SIS.TPISG.tpisg220.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.TPISG.tpisg220) As SIS.TPISG.tpisg220
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sptpisg220Update"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_cprj",SqlDbType.VarChar,10, Record.t_cprj)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_pcod",SqlDbType.VarChar,10, Record.t_pcod)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_cact",SqlDbType.VarChar,31, Record.t_cact)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cprj",SqlDbType.VarChar,10, Record.t_cprj)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pcod",SqlDbType.VarChar,10, Record.t_pcod)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_schd",SqlDbType.Int,11, Record.t_schd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cact",SqlDbType.VarChar,31, Record.t_cact)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_actp",SqlDbType.Int,11, Record.t_actp)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pact",SqlDbType.VarChar,31, Record.t_pact)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_bcod",SqlDbType.VarChar,10, Record.t_bcod)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dura",SqlDbType.Int,11, Record.t_dura)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sdst",SqlDbType.DateTime,21, Record.t_sdst)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sdfn",SqlDbType.DateTime,21, Record.t_sdfn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_acsd",SqlDbType.DateTime,21, Record.t_acsd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_acfn",SqlDbType.DateTime,21, Record.t_acfn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_bohd",SqlDbType.VarChar,21, Record.t_bohd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pred",SqlDbType.VarChar,201, Record.t_pred)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_succ",SqlDbType.VarChar,201, Record.t_succ)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_desc",SqlDbType.VarChar,257, Record.t_desc)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_acty",SqlDbType.VarChar,10, Record.t_acty)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dept",SqlDbType.VarChar,10, Record.t_dept)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_vali",SqlDbType.Int,11, Record.t_vali)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_outl",SqlDbType.Int,11, Record.t_outl)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sub1",SqlDbType.VarChar,201, Record.t_sub1)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sub2",SqlDbType.VarChar,151, Record.t_sub2)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sub3",SqlDbType.VarChar,151, Record.t_sub3)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sub4",SqlDbType.VarChar,151, Record.t_sub4)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_amod",SqlDbType.VarChar,21, Record.t_amod)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pcbs",SqlDbType.VarChar,21, Record.t_pcbs)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_exdo",SqlDbType.Int,11, Record.t_exdo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cpgv",SqlDbType.Float,16, Record.t_cpgv)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_otsd",SqlDbType.DateTime,21, Record.t_otsd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_oted",SqlDbType.DateTime,21, Record.t_oted)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rmks",SqlDbType.VarChar,501, Record.t_rmks)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_gps1",SqlDbType.VarChar,101, Record.t_gps1)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_gps2",SqlDbType.VarChar,101, Record.t_gps2)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_gps3",SqlDbType.VarChar,101, Record.t_gps3)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_gps4",SqlDbType.VarChar,251, Record.t_gps4)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pper",SqlDbType.Real,8, Record.t_pper)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_valu",SqlDbType.Float,16, Record.t_valu)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sele",SqlDbType.Int,11, Record.t_sele)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntd",SqlDbType.Int,11, Record.t_Refcntd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntu",SqlDbType.Int,11, Record.t_Refcntu)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_numo",SqlDbType.Int,11, Record.t_numo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_numq",SqlDbType.Int,11, Record.t_numq)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_numt",SqlDbType.Int,11, Record.t_numt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_numv",SqlDbType.Int,11, Record.t_numv)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_nutc",SqlDbType.Int,11, Record.t_nutc)
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
    Public Shared Function tpisg220Delete(ByVal Record As SIS.TPISG.tpisg220) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sptpisg220Delete"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_cprj",SqlDbType.VarChar,Record.t_cprj.ToString.Length, Record.t_cprj)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_pcod",SqlDbType.VarChar,Record.t_pcod.ToString.Length, Record.t_pcod)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_cact",SqlDbType.VarChar,Record.t_cact.ToString.Length, Record.t_cact)
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
