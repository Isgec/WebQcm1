Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.DMISG
  <DataObject()> _
  Partial Public Class dmisg140
    Private Shared _RecordCount As Integer
    Private _t_pcod As String = ""
    Private _t_cprj As String = ""
    Private _t_uidn As String = ""
    Private _t_revn As String = ""
    Private _t_docn As String = ""
    Private _t_dsca As String = ""
    Private _t_aldo As String = ""
    Private _t_alre As String = ""
    Private _t_cspa As String = ""
    Private _t_type As String = ""
    Private _t_resp As String = ""
    Private _t_size As Int32 = 0
    Private _t_orgn As String = ""
    Private _t_subm As Int32 = 0
    Private _t_intr As Int32 = 0
    Private _t_prod As Int32 = 0
    Private _t_erec As Int32 = 0
    Private _t_info As Int32 = 0
    Private _t_remk As String = ""
    Private _t_soft As String = ""
    Private _t_drwn As String = ""
    Private _t_chec As String = ""
    Private _t_engg As String = ""
    Private _t_dhrs As Double = 0
    Private _t_chrs As Double = 0
    Private _t_ehrs As Double = 0
    Private _t_lmhr As Double = 0
    Private _t_acdt As String = ""
    Private _t_upby As String = ""
    Private _t_updt As String = ""
    Private _t_dwgs As Int32 = 0
    Private _t_genm As String = ""
    Private _t_inpt As Int32 = 0
    Private _t_seqn As Int32 = 0
    Private _t_bssd As String = ""
    Private _t_bsfd As String = ""
    Private _t_rssd As String = ""
    Private _t_rsfd As String = ""
    Private _t_lrrd As String = ""
    Private _t_rfsv As String = ""
    Private _t_irst As String = ""
    Private _t_dref As Single = 0
    Private _t_chef As Single = 0
    Private _t_leef As Single = 0
    Private _t_lmef As Single = 0
    Private _t_drep As String = ""
    Private _t_oscd As Int32 = 0
    Private _t_Refcntd As Int32 = 0
    Private _t_Refcntu As Int32 = 0
    Private _t_pled As String = ""
    Private _t_appr As Int32 = 0
    Private _t_rdat As String = ""
    Private _t_selc As Int32 = 0
    Private _t_acty As String = ""
    Private _t_fadt As String = ""
    Private _t_iadt As String = ""
    Private _t_iref As String = ""
    Private _t_itdt As String = ""
    Private _t_padt As String = ""
    Private _t_pcdt As String = ""
    Private _t_podt As String = ""
    Private _t_prdt As String = ""
    Private _t_psdt As String = ""
    Private _t_dpct As Int32 = 0
    Private _t_dpwt As Double = 0
    Private _t_idct As Int32 = 0
    Private _t_idwt As Double = 0
    Private _t_popt As Int32 = 0
    Private _t_posw As Double = 0
    Private _t_powt As Double = 0
    Private _t_pspt As Int32 = 0
    Private _t_posd As String = ""
    Private _t_upct As Int32 = 0
    Private _t_bgdt As String = ""
    Private _t_vpdt As String = ""
    Private _t_vrdt As String = ""
    Private _t_upon As String = ""
    Private _t_adct As String = ""
    Private _t_piwt As Double = 0
    Private _t_rfqd As String = ""
    Private _t_poic As Int32 = 0
    Private _t_ofdt As String = ""
    Private _t_pois As String = ""
    Private _t_numo As Int32 = 0
    Private _t_cmfd As String = ""
    Private _t_numq As Int32 = 0
    Private _t_poad As String = ""
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
    Public Property t_pcod() As String
      Get
        Return _t_pcod
      End Get
      Set(ByVal value As String)
        _t_pcod = value
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
    Public Property t_uidn() As String
      Get
        Return _t_uidn
      End Get
      Set(ByVal value As String)
        _t_uidn = value
      End Set
    End Property
    Public Property t_revn() As String
      Get
        Return _t_revn
      End Get
      Set(ByVal value As String)
        _t_revn = value
      End Set
    End Property
    Public Property t_docn() As String
      Get
        Return _t_docn
      End Get
      Set(ByVal value As String)
        _t_docn = value
      End Set
    End Property
    Public Property t_dsca() As String
      Get
        Return _t_dsca
      End Get
      Set(ByVal value As String)
        _t_dsca = value
      End Set
    End Property
    Public Property t_aldo() As String
      Get
        Return _t_aldo
      End Get
      Set(ByVal value As String)
        _t_aldo = value
      End Set
    End Property
    Public Property t_alre() As String
      Get
        Return _t_alre
      End Get
      Set(ByVal value As String)
        _t_alre = value
      End Set
    End Property
    Public Property t_cspa() As String
      Get
        Return _t_cspa
      End Get
      Set(ByVal value As String)
        _t_cspa = value
      End Set
    End Property
    Public Property t_type() As String
      Get
        Return _t_type
      End Get
      Set(ByVal value As String)
        _t_type = value
      End Set
    End Property
    Public Property t_resp() As String
      Get
        Return _t_resp
      End Get
      Set(ByVal value As String)
        _t_resp = value
      End Set
    End Property
    Public Property t_size() As Int32
      Get
        Return _t_size
      End Get
      Set(ByVal value As Int32)
        _t_size = value
      End Set
    End Property
    Public Property t_orgn() As String
      Get
        Return _t_orgn
      End Get
      Set(ByVal value As String)
        _t_orgn = value
      End Set
    End Property
    Public Property t_subm() As Int32
      Get
        Return _t_subm
      End Get
      Set(ByVal value As Int32)
        _t_subm = value
      End Set
    End Property
    Public Property t_intr() As Int32
      Get
        Return _t_intr
      End Get
      Set(ByVal value As Int32)
        _t_intr = value
      End Set
    End Property
    Public Property t_prod() As Int32
      Get
        Return _t_prod
      End Get
      Set(ByVal value As Int32)
        _t_prod = value
      End Set
    End Property
    Public Property t_erec() As Int32
      Get
        Return _t_erec
      End Get
      Set(ByVal value As Int32)
        _t_erec = value
      End Set
    End Property
    Public Property t_info() As Int32
      Get
        Return _t_info
      End Get
      Set(ByVal value As Int32)
        _t_info = value
      End Set
    End Property
    Public Property t_remk() As String
      Get
        Return _t_remk
      End Get
      Set(ByVal value As String)
        _t_remk = value
      End Set
    End Property
    Public Property t_soft() As String
      Get
        Return _t_soft
      End Get
      Set(ByVal value As String)
        _t_soft = value
      End Set
    End Property
    Public Property t_drwn() As String
      Get
        Return _t_drwn
      End Get
      Set(ByVal value As String)
        _t_drwn = value
      End Set
    End Property
    Public Property t_chec() As String
      Get
        Return _t_chec
      End Get
      Set(ByVal value As String)
        _t_chec = value
      End Set
    End Property
    Public Property t_engg() As String
      Get
        Return _t_engg
      End Get
      Set(ByVal value As String)
        _t_engg = value
      End Set
    End Property
    Public Property t_dhrs() As Double
      Get
        Return _t_dhrs
      End Get
      Set(ByVal value As Double)
        _t_dhrs = value
      End Set
    End Property
    Public Property t_chrs() As Double
      Get
        Return _t_chrs
      End Get
      Set(ByVal value As Double)
        _t_chrs = value
      End Set
    End Property
    Public Property t_ehrs() As Double
      Get
        Return _t_ehrs
      End Get
      Set(ByVal value As Double)
        _t_ehrs = value
      End Set
    End Property
    Public Property t_lmhr() As Double
      Get
        Return _t_lmhr
      End Get
      Set(ByVal value As Double)
        _t_lmhr = value
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
    Public Property t_upby() As String
      Get
        Return _t_upby
      End Get
      Set(ByVal value As String)
        _t_upby = value
      End Set
    End Property
    Public Property t_updt() As String
      Get
        If Not _t_updt = String.Empty Then
          Return Convert.ToDateTime(_t_updt).ToString("dd/MM/yyyy")
        End If
        Return _t_updt
      End Get
      Set(ByVal value As String)
         _t_updt = value
      End Set
    End Property
    Public Property t_dwgs() As Int32
      Get
        Return _t_dwgs
      End Get
      Set(ByVal value As Int32)
        _t_dwgs = value
      End Set
    End Property
    Public Property t_genm() As String
      Get
        Return _t_genm
      End Get
      Set(ByVal value As String)
        _t_genm = value
      End Set
    End Property
    Public Property t_inpt() As Int32
      Get
        Return _t_inpt
      End Get
      Set(ByVal value As Int32)
        _t_inpt = value
      End Set
    End Property
    Public Property t_seqn() As Int32
      Get
        Return _t_seqn
      End Get
      Set(ByVal value As Int32)
        _t_seqn = value
      End Set
    End Property
    Public Property t_bssd() As String
      Get
        If Not _t_bssd = String.Empty Then
          Return Convert.ToDateTime(_t_bssd).ToString("dd/MM/yyyy")
        End If
        Return _t_bssd
      End Get
      Set(ByVal value As String)
         _t_bssd = value
      End Set
    End Property
    Public Property t_bsfd() As String
      Get
        If Not _t_bsfd = String.Empty Then
          Return Convert.ToDateTime(_t_bsfd).ToString("dd/MM/yyyy")
        End If
        Return _t_bsfd
      End Get
      Set(ByVal value As String)
         _t_bsfd = value
      End Set
    End Property
    Public Property t_rssd() As String
      Get
        If Not _t_rssd = String.Empty Then
          Return Convert.ToDateTime(_t_rssd).ToString("dd/MM/yyyy")
        End If
        Return _t_rssd
      End Get
      Set(ByVal value As String)
         _t_rssd = value
      End Set
    End Property
    Public Property t_rsfd() As String
      Get
        If Not _t_rsfd = String.Empty Then
          Return Convert.ToDateTime(_t_rsfd).ToString("dd/MM/yyyy")
        End If
        Return _t_rsfd
      End Get
      Set(ByVal value As String)
         _t_rsfd = value
      End Set
    End Property
    Public Property t_lrrd() As String
      Get
        If Not _t_lrrd = String.Empty Then
          Return Convert.ToDateTime(_t_lrrd).ToString("dd/MM/yyyy")
        End If
        Return _t_lrrd
      End Get
      Set(ByVal value As String)
         _t_lrrd = value
      End Set
    End Property
    Public Property t_rfsv() As String
      Get
        Return _t_rfsv
      End Get
      Set(ByVal value As String)
        _t_rfsv = value
      End Set
    End Property
    Public Property t_irst() As String
      Get
        Return _t_irst
      End Get
      Set(ByVal value As String)
        _t_irst = value
      End Set
    End Property
    Public Property t_dref() As Single
      Get
        Return _t_dref
      End Get
      Set(ByVal value As Single)
        _t_dref = value
      End Set
    End Property
    Public Property t_chef() As Single
      Get
        Return _t_chef
      End Get
      Set(ByVal value As Single)
        _t_chef = value
      End Set
    End Property
    Public Property t_leef() As Single
      Get
        Return _t_leef
      End Get
      Set(ByVal value As Single)
        _t_leef = value
      End Set
    End Property
    Public Property t_lmef() As Single
      Get
        Return _t_lmef
      End Get
      Set(ByVal value As Single)
        _t_lmef = value
      End Set
    End Property
    Public Property t_drep() As String
      Get
        Return _t_drep
      End Get
      Set(ByVal value As String)
        _t_drep = value
      End Set
    End Property
    Public Property t_oscd() As Int32
      Get
        Return _t_oscd
      End Get
      Set(ByVal value As Int32)
        _t_oscd = value
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
    Public Property t_pled() As String
      Get
        Return _t_pled
      End Get
      Set(ByVal value As String)
        _t_pled = value
      End Set
    End Property
    Public Property t_appr() As Int32
      Get
        Return _t_appr
      End Get
      Set(ByVal value As Int32)
        _t_appr = value
      End Set
    End Property
    Public Property t_rdat() As String
      Get
        If Not _t_rdat = String.Empty Then
          Return Convert.ToDateTime(_t_rdat).ToString("dd/MM/yyyy")
        End If
        Return _t_rdat
      End Get
      Set(ByVal value As String)
         _t_rdat = value
      End Set
    End Property
    Public Property t_selc() As Int32
      Get
        Return _t_selc
      End Get
      Set(ByVal value As Int32)
        _t_selc = value
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
    Public Property t_fadt() As String
      Get
        If Not _t_fadt = String.Empty Then
          Return Convert.ToDateTime(_t_fadt).ToString("dd/MM/yyyy")
        End If
        Return _t_fadt
      End Get
      Set(ByVal value As String)
         _t_fadt = value
      End Set
    End Property
    Public Property t_iadt() As String
      Get
        If Not _t_iadt = String.Empty Then
          Return Convert.ToDateTime(_t_iadt).ToString("dd/MM/yyyy")
        End If
        Return _t_iadt
      End Get
      Set(ByVal value As String)
         _t_iadt = value
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
    Public Property t_itdt() As String
      Get
        If Not _t_itdt = String.Empty Then
          Return Convert.ToDateTime(_t_itdt).ToString("dd/MM/yyyy")
        End If
        Return _t_itdt
      End Get
      Set(ByVal value As String)
         _t_itdt = value
      End Set
    End Property
    Public Property t_padt() As String
      Get
        If Not _t_padt = String.Empty Then
          Return Convert.ToDateTime(_t_padt).ToString("dd/MM/yyyy")
        End If
        Return _t_padt
      End Get
      Set(ByVal value As String)
         _t_padt = value
      End Set
    End Property
    Public Property t_pcdt() As String
      Get
        If Not _t_pcdt = String.Empty Then
          Return Convert.ToDateTime(_t_pcdt).ToString("dd/MM/yyyy")
        End If
        Return _t_pcdt
      End Get
      Set(ByVal value As String)
         _t_pcdt = value
      End Set
    End Property
    Public Property t_podt() As String
      Get
        If Not _t_podt = String.Empty Then
          Return Convert.ToDateTime(_t_podt).ToString("dd/MM/yyyy")
        End If
        Return _t_podt
      End Get
      Set(ByVal value As String)
         _t_podt = value
      End Set
    End Property
    Public Property t_prdt() As String
      Get
        If Not _t_prdt = String.Empty Then
          Return Convert.ToDateTime(_t_prdt).ToString("dd/MM/yyyy")
        End If
        Return _t_prdt
      End Get
      Set(ByVal value As String)
         _t_prdt = value
      End Set
    End Property
    Public Property t_psdt() As String
      Get
        If Not _t_psdt = String.Empty Then
          Return Convert.ToDateTime(_t_psdt).ToString("dd/MM/yyyy")
        End If
        Return _t_psdt
      End Get
      Set(ByVal value As String)
         _t_psdt = value
      End Set
    End Property
    Public Property t_dpct() As Int32
      Get
        Return _t_dpct
      End Get
      Set(ByVal value As Int32)
        _t_dpct = value
      End Set
    End Property
    Public Property t_dpwt() As Double
      Get
        Return _t_dpwt
      End Get
      Set(ByVal value As Double)
        _t_dpwt = value
      End Set
    End Property
    Public Property t_idct() As Int32
      Get
        Return _t_idct
      End Get
      Set(ByVal value As Int32)
        _t_idct = value
      End Set
    End Property
    Public Property t_idwt() As Double
      Get
        Return _t_idwt
      End Get
      Set(ByVal value As Double)
        _t_idwt = value
      End Set
    End Property
    Public Property t_popt() As Int32
      Get
        Return _t_popt
      End Get
      Set(ByVal value As Int32)
        _t_popt = value
      End Set
    End Property
    Public Property t_posw() As Double
      Get
        Return _t_posw
      End Get
      Set(ByVal value As Double)
        _t_posw = value
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
    Public Property t_pspt() As Int32
      Get
        Return _t_pspt
      End Get
      Set(ByVal value As Int32)
        _t_pspt = value
      End Set
    End Property
    Public Property t_posd() As String
      Get
        If Not _t_posd = String.Empty Then
          Return Convert.ToDateTime(_t_posd).ToString("dd/MM/yyyy")
        End If
        Return _t_posd
      End Get
      Set(ByVal value As String)
         _t_posd = value
      End Set
    End Property
    Public Property t_upct() As Int32
      Get
        Return _t_upct
      End Get
      Set(ByVal value As Int32)
        _t_upct = value
      End Set
    End Property
    Public Property t_bgdt() As String
      Get
        If Not _t_bgdt = String.Empty Then
          Return Convert.ToDateTime(_t_bgdt).ToString("dd/MM/yyyy")
        End If
        Return _t_bgdt
      End Get
      Set(ByVal value As String)
         _t_bgdt = value
      End Set
    End Property
    Public Property t_vpdt() As String
      Get
        If Not _t_vpdt = String.Empty Then
          Return Convert.ToDateTime(_t_vpdt).ToString("dd/MM/yyyy")
        End If
        Return _t_vpdt
      End Get
      Set(ByVal value As String)
         _t_vpdt = value
      End Set
    End Property
    Public Property t_vrdt() As String
      Get
        If Not _t_vrdt = String.Empty Then
          Return Convert.ToDateTime(_t_vrdt).ToString("dd/MM/yyyy")
        End If
        Return _t_vrdt
      End Get
      Set(ByVal value As String)
         _t_vrdt = value
      End Set
    End Property
    Public Property t_upon() As String
      Get
        If Not _t_upon = String.Empty Then
          Return Convert.ToDateTime(_t_upon).ToString("dd/MM/yyyy")
        End If
        Return _t_upon
      End Get
      Set(ByVal value As String)
         _t_upon = value
      End Set
    End Property
    Public Property t_adct() As String
      Get
        If Not _t_adct = String.Empty Then
          Return Convert.ToDateTime(_t_adct).ToString("dd/MM/yyyy")
        End If
        Return _t_adct
      End Get
      Set(ByVal value As String)
         _t_adct = value
      End Set
    End Property
    Public Property t_piwt() As Double
      Get
        Return _t_piwt
      End Get
      Set(ByVal value As Double)
        _t_piwt = value
      End Set
    End Property
    Public Property t_rfqd() As String
      Get
        If Not _t_rfqd = String.Empty Then
          Return Convert.ToDateTime(_t_rfqd).ToString("dd/MM/yyyy")
        End If
        Return _t_rfqd
      End Get
      Set(ByVal value As String)
         _t_rfqd = value
      End Set
    End Property
    Public Property t_poic() As Int32
      Get
        Return _t_poic
      End Get
      Set(ByVal value As Int32)
        _t_poic = value
      End Set
    End Property
    Public Property t_ofdt() As String
      Get
        If Not _t_ofdt = String.Empty Then
          Return Convert.ToDateTime(_t_ofdt).ToString("dd/MM/yyyy")
        End If
        Return _t_ofdt
      End Get
      Set(ByVal value As String)
         _t_ofdt = value
      End Set
    End Property
    Public Property t_pois() As String
      Get
        If Not _t_pois = String.Empty Then
          Return Convert.ToDateTime(_t_pois).ToString("dd/MM/yyyy")
        End If
        Return _t_pois
      End Get
      Set(ByVal value As String)
         _t_pois = value
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
    Public Property t_cmfd() As String
      Get
        If Not _t_cmfd = String.Empty Then
          Return Convert.ToDateTime(_t_cmfd).ToString("dd/MM/yyyy")
        End If
        Return _t_cmfd
      End Get
      Set(ByVal value As String)
         _t_cmfd = value
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
    Public Property t_poad() As String
      Get
        If Not _t_poad = String.Empty Then
          Return Convert.ToDateTime(_t_poad).ToString("dd/MM/yyyy")
        End If
        Return _t_poad
      End Get
      Set(ByVal value As String)
         _t_poad = value
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
        Return _t_pcod & "|" & _t_cprj & "|" & _t_uidn
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
    Public Class PKdmisg140
      Private _t_pcod As String = ""
      Private _t_cprj As String = ""
      Private _t_uidn As String = ""
      Public Property t_pcod() As String
        Get
          Return _t_pcod
        End Get
        Set(ByVal value As String)
          _t_pcod = value
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
      Public Property t_uidn() As String
        Get
          Return _t_uidn
        End Get
        Set(ByVal value As String)
          _t_uidn = value
        End Set
      End Property
    End Class
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function dmisg140GetNewRecord() As SIS.DMISG.dmisg140
      Return New SIS.DMISG.dmisg140()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function dmisg140GetByID(ByVal t_pcod As String, ByVal t_cprj As String, ByVal t_uidn As String) As SIS.DMISG.dmisg140
      Dim Results As SIS.DMISG.dmisg140 = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spdmisg140SelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pcod",SqlDbType.VarChar,t_pcod.ToString.Length, t_pcod)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cprj",SqlDbType.VarChar,t_cprj.ToString.Length, t_cprj)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_uidn",SqlDbType.VarChar,t_uidn.ToString.Length, t_uidn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.DMISG.dmisg140(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function dmisg140SelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.DMISG.dmisg140)
      Dim Results As List(Of SIS.DMISG.dmisg140) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spdmisg140SelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spdmisg140SelectListFilteres"
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.DMISG.dmisg140)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.DMISG.dmisg140(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function dmisg140SelectCount(ByVal SearchState As Boolean, ByVal SearchText As String) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
    <DataObjectMethod(DataObjectMethodType.Insert, True)> _
    Public Shared Function dmisg140Insert(ByVal Record As SIS.DMISG.dmisg140) As SIS.DMISG.dmisg140
      Dim _Rec As SIS.DMISG.dmisg140 = SIS.DMISG.dmisg140.dmisg140GetNewRecord()
      With _Rec
        .t_pcod = Record.t_pcod
        .t_cprj = Record.t_cprj
        .t_uidn = Record.t_uidn
        .t_revn = Record.t_revn
        .t_docn = Record.t_docn
        .t_dsca = Record.t_dsca
        .t_aldo = Record.t_aldo
        .t_alre = Record.t_alre
        .t_cspa = Record.t_cspa
        .t_type = Record.t_type
        .t_resp = Record.t_resp
        .t_size = Record.t_size
        .t_orgn = Record.t_orgn
        .t_subm = Record.t_subm
        .t_intr = Record.t_intr
        .t_prod = Record.t_prod
        .t_erec = Record.t_erec
        .t_info = Record.t_info
        .t_remk = Record.t_remk
        .t_soft = Record.t_soft
        .t_drwn = Record.t_drwn
        .t_chec = Record.t_chec
        .t_engg = Record.t_engg
        .t_dhrs = Record.t_dhrs
        .t_chrs = Record.t_chrs
        .t_ehrs = Record.t_ehrs
        .t_lmhr = Record.t_lmhr
        .t_acdt = Record.t_acdt
        .t_upby = Record.t_upby
        .t_updt = Record.t_updt
        .t_dwgs = Record.t_dwgs
        .t_genm = Record.t_genm
        .t_inpt = Record.t_inpt
        .t_seqn = Record.t_seqn
        .t_bssd = Record.t_bssd
        .t_bsfd = Record.t_bsfd
        .t_rssd = Record.t_rssd
        .t_rsfd = Record.t_rsfd
        .t_lrrd = Record.t_lrrd
        .t_rfsv = Record.t_rfsv
        .t_irst = Record.t_irst
        .t_dref = Record.t_dref
        .t_chef = Record.t_chef
        .t_leef = Record.t_leef
        .t_lmef = Record.t_lmef
        .t_drep = Record.t_drep
        .t_oscd = Record.t_oscd
        .t_Refcntd = Record.t_Refcntd
        .t_Refcntu = Record.t_Refcntu
        .t_pled = Record.t_pled
        .t_appr = Record.t_appr
        .t_rdat = Record.t_rdat
        .t_selc = Record.t_selc
        .t_acty = Record.t_acty
        .t_fadt = Record.t_fadt
        .t_iadt = Record.t_iadt
        .t_iref = Record.t_iref
        .t_itdt = Record.t_itdt
        .t_padt = Record.t_padt
        .t_pcdt = Record.t_pcdt
        .t_podt = Record.t_podt
        .t_prdt = Record.t_prdt
        .t_psdt = Record.t_psdt
        .t_dpct = Record.t_dpct
        .t_dpwt = Record.t_dpwt
        .t_idct = Record.t_idct
        .t_idwt = Record.t_idwt
        .t_popt = Record.t_popt
        .t_posw = Record.t_posw
        .t_powt = Record.t_powt
        .t_pspt = Record.t_pspt
        .t_posd = Record.t_posd
        .t_upct = Record.t_upct
        .t_bgdt = Record.t_bgdt
        .t_vpdt = Record.t_vpdt
        .t_vrdt = Record.t_vrdt
        .t_upon = Record.t_upon
        .t_adct = Record.t_adct
        .t_piwt = Record.t_piwt
        .t_rfqd = Record.t_rfqd
        .t_poic = Record.t_poic
        .t_ofdt = Record.t_ofdt
        .t_pois = Record.t_pois
        .t_numo = Record.t_numo
        .t_cmfd = Record.t_cmfd
        .t_numq = Record.t_numq
        .t_poad = Record.t_poad
        .t_numt = Record.t_numt
        .t_numv = Record.t_numv
        .t_nutc = Record.t_nutc
      End With
      Return SIS.DMISG.dmisg140.InsertData(_Rec)
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.DMISG.dmisg140) As SIS.DMISG.dmisg140
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spdmisg140Insert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pcod",SqlDbType.VarChar,10, Record.t_pcod)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cprj",SqlDbType.VarChar,10, Record.t_cprj)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_uidn",SqlDbType.VarChar,26, Record.t_uidn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_revn",SqlDbType.VarChar,33, Record.t_revn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_docn",SqlDbType.VarChar,33, Record.t_docn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dsca",SqlDbType.VarChar,101, Record.t_dsca)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_aldo",SqlDbType.VarChar,33, Record.t_aldo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_alre",SqlDbType.VarChar,21, Record.t_alre)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cspa",SqlDbType.VarChar,9, Record.t_cspa)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_type",SqlDbType.VarChar,8, Record.t_type)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_resp",SqlDbType.VarChar,4, Record.t_resp)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_size",SqlDbType.Int,11, Record.t_size)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_orgn",SqlDbType.VarChar,4, Record.t_orgn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_subm",SqlDbType.Int,11, Record.t_subm)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_intr",SqlDbType.Int,11, Record.t_intr)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_prod",SqlDbType.Int,11, Record.t_prod)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_erec",SqlDbType.Int,11, Record.t_erec)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_info",SqlDbType.Int,11, Record.t_info)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_remk",SqlDbType.VarChar,101, Record.t_remk)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_soft",SqlDbType.VarChar,51, Record.t_soft)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_drwn",SqlDbType.VarChar,10, Record.t_drwn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_chec",SqlDbType.VarChar,10, Record.t_chec)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_engg",SqlDbType.VarChar,10, Record.t_engg)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dhrs",SqlDbType.Float,16, Record.t_dhrs)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_chrs",SqlDbType.Float,16, Record.t_chrs)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_ehrs",SqlDbType.Float,16, Record.t_ehrs)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_lmhr",SqlDbType.Float,16, Record.t_lmhr)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_acdt",SqlDbType.DateTime,21, Record.t_acdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_upby",SqlDbType.VarChar,17, Record.t_upby)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_updt",SqlDbType.DateTime,21, Record.t_updt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dwgs",SqlDbType.Int,11, Record.t_dwgs)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_genm",SqlDbType.VarChar,16, Record.t_genm)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_inpt",SqlDbType.Int,11, Record.t_inpt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_seqn",SqlDbType.Int,11, Record.t_seqn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_bssd",SqlDbType.DateTime,21, Record.t_bssd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_bsfd",SqlDbType.DateTime,21, Record.t_bsfd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rssd",SqlDbType.DateTime,21, Record.t_rssd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rsfd",SqlDbType.DateTime,21, Record.t_rsfd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_lrrd",SqlDbType.DateTime,21, Record.t_lrrd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rfsv",SqlDbType.VarChar,26, Record.t_rfsv)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_irst",SqlDbType.VarChar,21, Record.t_irst)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dref",SqlDbType.Real,8, Record.t_dref)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_chef",SqlDbType.Real,8, Record.t_chef)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_leef",SqlDbType.Real,8, Record.t_leef)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_lmef",SqlDbType.Real,8, Record.t_lmef)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_drep",SqlDbType.VarChar,10, Record.t_drep)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_oscd",SqlDbType.Int,11, Record.t_oscd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntd",SqlDbType.Int,11, Record.t_Refcntd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntu",SqlDbType.Int,11, Record.t_Refcntu)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pled",SqlDbType.VarChar,10, Record.t_pled)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_appr",SqlDbType.Int,11, Record.t_appr)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rdat",SqlDbType.DateTime,21, Record.t_rdat)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_selc",SqlDbType.Int,11, Record.t_selc)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_acty",SqlDbType.VarChar,31, Record.t_acty)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_fadt",SqlDbType.DateTime,21, Record.t_fadt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_iadt",SqlDbType.DateTime,21, Record.t_iadt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_iref",SqlDbType.VarChar,151, Record.t_iref)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_itdt",SqlDbType.DateTime,21, Record.t_itdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_padt",SqlDbType.DateTime,21, Record.t_padt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pcdt",SqlDbType.DateTime,21, Record.t_pcdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_podt",SqlDbType.DateTime,21, Record.t_podt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_prdt",SqlDbType.DateTime,21, Record.t_prdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_psdt",SqlDbType.DateTime,21, Record.t_psdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dpct",SqlDbType.Int,11, Record.t_dpct)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dpwt",SqlDbType.Float,16, Record.t_dpwt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_idct",SqlDbType.Int,11, Record.t_idct)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_idwt",SqlDbType.Float,16, Record.t_idwt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_popt",SqlDbType.Int,11, Record.t_popt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_posw",SqlDbType.Float,16, Record.t_posw)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_powt",SqlDbType.Float,16, Record.t_powt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pspt",SqlDbType.Int,11, Record.t_pspt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_posd",SqlDbType.DateTime,21, Record.t_posd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_upct",SqlDbType.Int,11, Record.t_upct)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_bgdt",SqlDbType.DateTime,21, Record.t_bgdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_vpdt",SqlDbType.DateTime,21, Record.t_vpdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_vrdt",SqlDbType.DateTime,21, Record.t_vrdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_upon",SqlDbType.DateTime,21, Record.t_upon)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_adct",SqlDbType.DateTime,21, Record.t_adct)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_piwt",SqlDbType.Float,16, Record.t_piwt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rfqd",SqlDbType.DateTime,21, Record.t_rfqd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_poic",SqlDbType.Int,11, Record.t_poic)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_ofdt",SqlDbType.DateTime,21, Record.t_ofdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pois",SqlDbType.DateTime,21, Record.t_pois)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_numo",SqlDbType.Int,11, Record.t_numo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cmfd",SqlDbType.DateTime,21, Record.t_cmfd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_numq",SqlDbType.Int,11, Record.t_numq)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_poad",SqlDbType.DateTime,21, Record.t_poad)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_numt",SqlDbType.Int,11, Record.t_numt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_numv",SqlDbType.Int,11, Record.t_numv)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_nutc",SqlDbType.Int,11, Record.t_nutc)
          Cmd.Parameters.Add("@Return_t_pcod", SqlDbType.VarChar, 10)
          Cmd.Parameters("@Return_t_pcod").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_cprj", SqlDbType.VarChar, 10)
          Cmd.Parameters("@Return_t_cprj").Direction = ParameterDirection.Output
          Cmd.Parameters.Add("@Return_t_uidn", SqlDbType.VarChar, 26)
          Cmd.Parameters("@Return_t_uidn").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          Record.t_pcod = Cmd.Parameters("@Return_t_pcod").Value
          Record.t_cprj = Cmd.Parameters("@Return_t_cprj").Value
          Record.t_uidn = Cmd.Parameters("@Return_t_uidn").Value
        End Using
      End Using
      Return Record
    End Function
    <DataObjectMethod(DataObjectMethodType.Update, True)> _
    Public Shared Function dmisg140Update(ByVal Record As SIS.DMISG.dmisg140) As SIS.DMISG.dmisg140
      Dim _Rec As SIS.DMISG.dmisg140 = SIS.DMISG.dmisg140.dmisg140GetByID(Record.t_pcod, Record.t_cprj, Record.t_uidn)
      With _Rec
        .t_revn = Record.t_revn
        .t_docn = Record.t_docn
        .t_dsca = Record.t_dsca
        .t_aldo = Record.t_aldo
        .t_alre = Record.t_alre
        .t_cspa = Record.t_cspa
        .t_type = Record.t_type
        .t_resp = Record.t_resp
        .t_size = Record.t_size
        .t_orgn = Record.t_orgn
        .t_subm = Record.t_subm
        .t_intr = Record.t_intr
        .t_prod = Record.t_prod
        .t_erec = Record.t_erec
        .t_info = Record.t_info
        .t_remk = Record.t_remk
        .t_soft = Record.t_soft
        .t_drwn = Record.t_drwn
        .t_chec = Record.t_chec
        .t_engg = Record.t_engg
        .t_dhrs = Record.t_dhrs
        .t_chrs = Record.t_chrs
        .t_ehrs = Record.t_ehrs
        .t_lmhr = Record.t_lmhr
        .t_acdt = Record.t_acdt
        .t_upby = Record.t_upby
        .t_updt = Record.t_updt
        .t_dwgs = Record.t_dwgs
        .t_genm = Record.t_genm
        .t_inpt = Record.t_inpt
        .t_seqn = Record.t_seqn
        .t_bssd = Record.t_bssd
        .t_bsfd = Record.t_bsfd
        .t_rssd = Record.t_rssd
        .t_rsfd = Record.t_rsfd
        .t_lrrd = Record.t_lrrd
        .t_rfsv = Record.t_rfsv
        .t_irst = Record.t_irst
        .t_dref = Record.t_dref
        .t_chef = Record.t_chef
        .t_leef = Record.t_leef
        .t_lmef = Record.t_lmef
        .t_drep = Record.t_drep
        .t_oscd = Record.t_oscd
        .t_Refcntd = Record.t_Refcntd
        .t_Refcntu = Record.t_Refcntu
        .t_pled = Record.t_pled
        .t_appr = Record.t_appr
        .t_rdat = Record.t_rdat
        .t_selc = Record.t_selc
        .t_acty = Record.t_acty
        .t_fadt = Record.t_fadt
        .t_iadt = Record.t_iadt
        .t_iref = Record.t_iref
        .t_itdt = Record.t_itdt
        .t_padt = Record.t_padt
        .t_pcdt = Record.t_pcdt
        .t_podt = Record.t_podt
        .t_prdt = Record.t_prdt
        .t_psdt = Record.t_psdt
        .t_dpct = Record.t_dpct
        .t_dpwt = Record.t_dpwt
        .t_idct = Record.t_idct
        .t_idwt = Record.t_idwt
        .t_popt = Record.t_popt
        .t_posw = Record.t_posw
        .t_powt = Record.t_powt
        .t_pspt = Record.t_pspt
        .t_posd = Record.t_posd
        .t_upct = Record.t_upct
        .t_bgdt = Record.t_bgdt
        .t_vpdt = Record.t_vpdt
        .t_vrdt = Record.t_vrdt
        .t_upon = Record.t_upon
        .t_adct = Record.t_adct
        .t_piwt = Record.t_piwt
        .t_rfqd = Record.t_rfqd
        .t_poic = Record.t_poic
        .t_ofdt = Record.t_ofdt
        .t_pois = Record.t_pois
        .t_numo = Record.t_numo
        .t_cmfd = Record.t_cmfd
        .t_numq = Record.t_numq
        .t_poad = Record.t_poad
        .t_numt = Record.t_numt
        .t_numv = Record.t_numv
        .t_nutc = Record.t_nutc
      End With
      Return SIS.DMISG.dmisg140.UpdateData(_Rec)
    End Function
    Public Shared Function UpdateData(ByVal Record As SIS.DMISG.dmisg140) As SIS.DMISG.dmisg140
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spdmisg140Update"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_pcod",SqlDbType.VarChar,10, Record.t_pcod)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_cprj",SqlDbType.VarChar,10, Record.t_cprj)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_uidn",SqlDbType.VarChar,26, Record.t_uidn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pcod",SqlDbType.VarChar,10, Record.t_pcod)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cprj",SqlDbType.VarChar,10, Record.t_cprj)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_uidn",SqlDbType.VarChar,26, Record.t_uidn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_revn",SqlDbType.VarChar,33, Record.t_revn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_docn",SqlDbType.VarChar,33, Record.t_docn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dsca",SqlDbType.VarChar,101, Record.t_dsca)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_aldo",SqlDbType.VarChar,33, Record.t_aldo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_alre",SqlDbType.VarChar,21, Record.t_alre)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cspa",SqlDbType.VarChar,9, Record.t_cspa)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_type",SqlDbType.VarChar,8, Record.t_type)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_resp",SqlDbType.VarChar,4, Record.t_resp)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_size",SqlDbType.Int,11, Record.t_size)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_orgn",SqlDbType.VarChar,4, Record.t_orgn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_subm",SqlDbType.Int,11, Record.t_subm)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_intr",SqlDbType.Int,11, Record.t_intr)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_prod",SqlDbType.Int,11, Record.t_prod)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_erec",SqlDbType.Int,11, Record.t_erec)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_info",SqlDbType.Int,11, Record.t_info)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_remk",SqlDbType.VarChar,101, Record.t_remk)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_soft",SqlDbType.VarChar,51, Record.t_soft)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_drwn",SqlDbType.VarChar,10, Record.t_drwn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_chec",SqlDbType.VarChar,10, Record.t_chec)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_engg",SqlDbType.VarChar,10, Record.t_engg)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dhrs",SqlDbType.Float,16, Record.t_dhrs)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_chrs",SqlDbType.Float,16, Record.t_chrs)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_ehrs",SqlDbType.Float,16, Record.t_ehrs)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_lmhr",SqlDbType.Float,16, Record.t_lmhr)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_acdt",SqlDbType.DateTime,21, Record.t_acdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_upby",SqlDbType.VarChar,17, Record.t_upby)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_updt",SqlDbType.DateTime,21, Record.t_updt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dwgs",SqlDbType.Int,11, Record.t_dwgs)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_genm",SqlDbType.VarChar,16, Record.t_genm)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_inpt",SqlDbType.Int,11, Record.t_inpt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_seqn",SqlDbType.Int,11, Record.t_seqn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_bssd",SqlDbType.DateTime,21, Record.t_bssd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_bsfd",SqlDbType.DateTime,21, Record.t_bsfd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rssd",SqlDbType.DateTime,21, Record.t_rssd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rsfd",SqlDbType.DateTime,21, Record.t_rsfd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_lrrd",SqlDbType.DateTime,21, Record.t_lrrd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rfsv",SqlDbType.VarChar,26, Record.t_rfsv)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_irst",SqlDbType.VarChar,21, Record.t_irst)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dref",SqlDbType.Real,8, Record.t_dref)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_chef",SqlDbType.Real,8, Record.t_chef)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_leef",SqlDbType.Real,8, Record.t_leef)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_lmef",SqlDbType.Real,8, Record.t_lmef)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_drep",SqlDbType.VarChar,10, Record.t_drep)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_oscd",SqlDbType.Int,11, Record.t_oscd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntd",SqlDbType.Int,11, Record.t_Refcntd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_Refcntu",SqlDbType.Int,11, Record.t_Refcntu)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pled",SqlDbType.VarChar,10, Record.t_pled)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_appr",SqlDbType.Int,11, Record.t_appr)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rdat",SqlDbType.DateTime,21, Record.t_rdat)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_selc",SqlDbType.Int,11, Record.t_selc)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_acty",SqlDbType.VarChar,31, Record.t_acty)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_fadt",SqlDbType.DateTime,21, Record.t_fadt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_iadt",SqlDbType.DateTime,21, Record.t_iadt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_iref",SqlDbType.VarChar,151, Record.t_iref)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_itdt",SqlDbType.DateTime,21, Record.t_itdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_padt",SqlDbType.DateTime,21, Record.t_padt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pcdt",SqlDbType.DateTime,21, Record.t_pcdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_podt",SqlDbType.DateTime,21, Record.t_podt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_prdt",SqlDbType.DateTime,21, Record.t_prdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_psdt",SqlDbType.DateTime,21, Record.t_psdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dpct",SqlDbType.Int,11, Record.t_dpct)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_dpwt",SqlDbType.Float,16, Record.t_dpwt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_idct",SqlDbType.Int,11, Record.t_idct)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_idwt",SqlDbType.Float,16, Record.t_idwt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_popt",SqlDbType.Int,11, Record.t_popt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_posw",SqlDbType.Float,16, Record.t_posw)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_powt",SqlDbType.Float,16, Record.t_powt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pspt",SqlDbType.Int,11, Record.t_pspt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_posd",SqlDbType.DateTime,21, Record.t_posd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_upct",SqlDbType.Int,11, Record.t_upct)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_bgdt",SqlDbType.DateTime,21, Record.t_bgdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_vpdt",SqlDbType.DateTime,21, Record.t_vpdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_vrdt",SqlDbType.DateTime,21, Record.t_vrdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_upon",SqlDbType.DateTime,21, Record.t_upon)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_adct",SqlDbType.DateTime,21, Record.t_adct)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_piwt",SqlDbType.Float,16, Record.t_piwt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_rfqd",SqlDbType.DateTime,21, Record.t_rfqd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_poic",SqlDbType.Int,11, Record.t_poic)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_ofdt",SqlDbType.DateTime,21, Record.t_ofdt)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pois",SqlDbType.DateTime,21, Record.t_pois)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_numo",SqlDbType.Int,11, Record.t_numo)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_cmfd",SqlDbType.DateTime,21, Record.t_cmfd)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_numq",SqlDbType.Int,11, Record.t_numq)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_poad",SqlDbType.DateTime,21, Record.t_poad)
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
    Public Shared Function dmisg140Delete(ByVal Record As SIS.DMISG.dmisg140) As Int32
      Dim _Result as Integer = 0
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spdmisg140Delete"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_pcod",SqlDbType.VarChar,Record.t_pcod.ToString.Length, Record.t_pcod)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_cprj",SqlDbType.VarChar,Record.t_cprj.ToString.Length, Record.t_cprj)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Original_t_uidn",SqlDbType.VarChar,Record.t_uidn.ToString.Length, Record.t_uidn)
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
