Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.TDPUR
  <DataObject()> _
  Partial Public Class tdpur400
    Private Shared _RecordCount As Integer
    Private _t_orno As String = ""
    Private _t_otbp As String = ""
    Private _t_otad As String = ""
    Private _t_otcn As String = ""
    Private _t_sfbp As String = ""
    Private _t_sfad As String = ""
    Private _t_sfcn As String = ""
    Private _t_ifbp As String = ""
    Private _t_ifad As String = ""
    Private _t_ifcn As String = ""
    Private _t_ptbp As String = ""
    Private _t_ptad As String = ""
    Private _t_ptcn As String = ""
    Private _t_corg As Int32 = 0
    Private _t_cotp As String = ""
    Private _t_ragr As String = ""
    Private _t_cpay As String = ""
    Private _t_odat As String = ""
    Private _t_odis As Single = 0
    Private _t_ccur As String = ""
    Private _t_mcfr As Int32 = 0
    Private _t_ratp_1 As Double = 0
    Private _t_ratp_2 As Double = 0
    Private _t_ratp_3 As Double = 0
    Private _t_ratf_1 As Int32 = 0
    Private _t_ratf_2 As Int32 = 0
    Private _t_ratf_3 As Int32 = 0
    Private _t_ratd As String = ""
    Private _t_ratt As String = ""
    Private _t_raur As Int32 = 0
    Private _t_cwar As String = ""
    Private _t_cadr As String = ""
    Private _t_ccon As String = ""
    Private _t_plnr As String = ""
    Private _t_ccrs As String = ""
    Private _t_cfrw As String = ""
    Private _t_cplp As String = ""
    Private _t_bppr As String = ""
    Private _t_bptx As String = ""
    Private _t_cdec As String = ""
    Private _t_ptpa As String = ""
    Private _t_ddat As String = ""
    Private _t_ddtc As String = ""
    Private _t_cbrn As String = ""
    Private _t_creg As String = ""
    Private _t_refa As String = ""
    Private _t_refb As String = ""
    Private _t_prno As String = ""
    Private _t_ctrj As String = ""
    Private _t_cofc As String = ""
    Private _t_fdpt As String = ""
    Private _t_odty As Int32 = 0
    Private _t_odno As String = ""
    Private _t_retr As String = ""
    Private _t_sorn As String = ""
    Private _t_cosn As String = ""
    Private _t_akcd As String = ""
    Private _t_crcd As String = ""
    Private _t_ctcd As String = ""
    Private _t_egen As Int32 = 0
    Private _t_sbim As Int32 = 0
    Private _t_paft As Int32 = 0
    Private _t_sbmt As String = ""
    Private _t_bpcl As String = ""
    Private _t_oamt As Double = 0
    Private _t_comm As Int32 = 0
    Private _t_iebp As Int32 = 0
    Private _t_iafc As Int32 = 0
    Private _t_lccl As String = ""
    Private _t_hdst As Int32 = 0
    Private _t_hisp As Int32 = 0
    Private _t_hism As Int32 = 0
    Private _t_ccty As String = ""
    Private _t_cvyn As Int32 = 0
    Private _t_bpid_l As String = ""
    Private _t_impo_l As Int32 = 0
    Private _t_ccty_l As String = ""
    Private _t_cvat_l As String = ""
    Private _t_exmt_l As Int32 = 0
    Private _t_catg_l As Int32 = 0
    Private _t_ceno_l As String = ""
    Private _t_bdbt_l As Int32 = 0
    Private _t_bnoo_l As String = ""
    Private _t_txta As Int32 = 0
    Private _t_txtb As Int32 = 0
    Private _t_cdf_adat As String = ""
    Private _t_cdf_alvl As Int32 = 0
    Private _t_cdf_onlr As Double = 0
    Private _t_cdf_prty As Int32 = 0
    Private _t_cdf_qap As String = ""
    Private _t_cdf_qdat As String = ""
    Private _t_cdf_refb As String = ""
    Private _t_Refcntd As Int32 = 0
    Private _t_Refcntu As Int32 = 0
    Private _t_cdf_reas As String = ""
    Private _t_cdf_qapa As Int32 = 0
    Private _t_atfr_l As Int32 = 0
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
    Public Property t_orno() As String
      Get
        Return _t_orno
      End Get
      Set(ByVal value As String)
        _t_orno = value
      End Set
    End Property
    Public Property t_otbp() As String
      Get
        Return _t_otbp
      End Get
      Set(ByVal value As String)
        _t_otbp = value
      End Set
    End Property
    Public Property t_otad() As String
      Get
        Return _t_otad
      End Get
      Set(ByVal value As String)
        _t_otad = value
      End Set
    End Property
    Public Property t_otcn() As String
      Get
        Return _t_otcn
      End Get
      Set(ByVal value As String)
        _t_otcn = value
      End Set
    End Property
    Public Property t_sfbp() As String
      Get
        Return _t_sfbp
      End Get
      Set(ByVal value As String)
        _t_sfbp = value
      End Set
    End Property
    Public Property t_sfad() As String
      Get
        Return _t_sfad
      End Get
      Set(ByVal value As String)
        _t_sfad = value
      End Set
    End Property
    Public Property t_sfcn() As String
      Get
        Return _t_sfcn
      End Get
      Set(ByVal value As String)
        _t_sfcn = value
      End Set
    End Property
    Public Property t_ifbp() As String
      Get
        Return _t_ifbp
      End Get
      Set(ByVal value As String)
        _t_ifbp = value
      End Set
    End Property
    Public Property t_ifad() As String
      Get
        Return _t_ifad
      End Get
      Set(ByVal value As String)
        _t_ifad = value
      End Set
    End Property
    Public Property t_ifcn() As String
      Get
        Return _t_ifcn
      End Get
      Set(ByVal value As String)
        _t_ifcn = value
      End Set
    End Property
    Public Property t_ptbp() As String
      Get
        Return _t_ptbp
      End Get
      Set(ByVal value As String)
        _t_ptbp = value
      End Set
    End Property
    Public Property t_ptad() As String
      Get
        Return _t_ptad
      End Get
      Set(ByVal value As String)
        _t_ptad = value
      End Set
    End Property
    Public Property t_ptcn() As String
      Get
        Return _t_ptcn
      End Get
      Set(ByVal value As String)
        _t_ptcn = value
      End Set
    End Property
    Public Property t_corg() As Int32
      Get
        Return _t_corg
      End Get
      Set(ByVal value As Int32)
        _t_corg = value
      End Set
    End Property
    Public Property t_cotp() As String
      Get
        Return _t_cotp
      End Get
      Set(ByVal value As String)
        _t_cotp = value
      End Set
    End Property
    Public Property t_ragr() As String
      Get
        Return _t_ragr
      End Get
      Set(ByVal value As String)
        _t_ragr = value
      End Set
    End Property
    Public Property t_cpay() As String
      Get
        Return _t_cpay
      End Get
      Set(ByVal value As String)
        _t_cpay = value
      End Set
    End Property
    Public Property t_odat() As String
      Get
        If Not _t_odat = String.Empty Then
          Return Convert.ToDateTime(_t_odat).ToString("dd/MM/yyyy")
        End If
        Return _t_odat
      End Get
      Set(ByVal value As String)
         _t_odat = value
      End Set
    End Property
    Public Property t_odis() As Single
      Get
        Return _t_odis
      End Get
      Set(ByVal value As Single)
        _t_odis = value
      End Set
    End Property
    Public Property t_ccur() As String
      Get
        Return _t_ccur
      End Get
      Set(ByVal value As String)
        _t_ccur = value
      End Set
    End Property
    Public Property t_mcfr() As Int32
      Get
        Return _t_mcfr
      End Get
      Set(ByVal value As Int32)
        _t_mcfr = value
      End Set
    End Property
    Public Property t_ratp_1() As Double
      Get
        Return _t_ratp_1
      End Get
      Set(ByVal value As Double)
        _t_ratp_1 = value
      End Set
    End Property
    Public Property t_ratp_2() As Double
      Get
        Return _t_ratp_2
      End Get
      Set(ByVal value As Double)
        _t_ratp_2 = value
      End Set
    End Property
    Public Property t_ratp_3() As Double
      Get
        Return _t_ratp_3
      End Get
      Set(ByVal value As Double)
        _t_ratp_3 = value
      End Set
    End Property
    Public Property t_ratf_1() As Int32
      Get
        Return _t_ratf_1
      End Get
      Set(ByVal value As Int32)
        _t_ratf_1 = value
      End Set
    End Property
    Public Property t_ratf_2() As Int32
      Get
        Return _t_ratf_2
      End Get
      Set(ByVal value As Int32)
        _t_ratf_2 = value
      End Set
    End Property
    Public Property t_ratf_3() As Int32
      Get
        Return _t_ratf_3
      End Get
      Set(ByVal value As Int32)
        _t_ratf_3 = value
      End Set
    End Property
    Public Property t_ratd() As String
      Get
        If Not _t_ratd = String.Empty Then
          Return Convert.ToDateTime(_t_ratd).ToString("dd/MM/yyyy")
        End If
        Return _t_ratd
      End Get
      Set(ByVal value As String)
         _t_ratd = value
      End Set
    End Property
    Public Property t_ratt() As String
      Get
        Return _t_ratt
      End Get
      Set(ByVal value As String)
        _t_ratt = value
      End Set
    End Property
    Public Property t_raur() As Int32
      Get
        Return _t_raur
      End Get
      Set(ByVal value As Int32)
        _t_raur = value
      End Set
    End Property
    Public Property t_cwar() As String
      Get
        Return _t_cwar
      End Get
      Set(ByVal value As String)
        _t_cwar = value
      End Set
    End Property
    Public Property t_cadr() As String
      Get
        Return _t_cadr
      End Get
      Set(ByVal value As String)
        _t_cadr = value
      End Set
    End Property
    Public Property t_ccon() As String
      Get
        Return _t_ccon
      End Get
      Set(ByVal value As String)
        _t_ccon = value
      End Set
    End Property
    Public Property t_plnr() As String
      Get
        Return _t_plnr
      End Get
      Set(ByVal value As String)
        _t_plnr = value
      End Set
    End Property
    Public Property t_ccrs() As String
      Get
        Return _t_ccrs
      End Get
      Set(ByVal value As String)
        _t_ccrs = value
      End Set
    End Property
    Public Property t_cfrw() As String
      Get
        Return _t_cfrw
      End Get
      Set(ByVal value As String)
        _t_cfrw = value
      End Set
    End Property
    Public Property t_cplp() As String
      Get
        Return _t_cplp
      End Get
      Set(ByVal value As String)
        _t_cplp = value
      End Set
    End Property
    Public Property t_bppr() As String
      Get
        Return _t_bppr
      End Get
      Set(ByVal value As String)
        _t_bppr = value
      End Set
    End Property
    Public Property t_bptx() As String
      Get
        Return _t_bptx
      End Get
      Set(ByVal value As String)
        _t_bptx = value
      End Set
    End Property
    Public Property t_cdec() As String
      Get
        Return _t_cdec
      End Get
      Set(ByVal value As String)
        _t_cdec = value
      End Set
    End Property
    Public Property t_ptpa() As String
      Get
        Return _t_ptpa
      End Get
      Set(ByVal value As String)
        _t_ptpa = value
      End Set
    End Property
    Public Property t_ddat() As String
      Get
        If Not _t_ddat = String.Empty Then
          Return Convert.ToDateTime(_t_ddat).ToString("dd/MM/yyyy")
        End If
        Return _t_ddat
      End Get
      Set(ByVal value As String)
         _t_ddat = value
      End Set
    End Property
    Public Property t_ddtc() As String
      Get
        If Not _t_ddtc = String.Empty Then
          Return Convert.ToDateTime(_t_ddtc).ToString("dd/MM/yyyy")
        End If
        Return _t_ddtc
      End Get
      Set(ByVal value As String)
         _t_ddtc = value
      End Set
    End Property
    Public Property t_cbrn() As String
      Get
        Return _t_cbrn
      End Get
      Set(ByVal value As String)
        _t_cbrn = value
      End Set
    End Property
    Public Property t_creg() As String
      Get
        Return _t_creg
      End Get
      Set(ByVal value As String)
        _t_creg = value
      End Set
    End Property
    Public Property t_refa() As String
      Get
        Return _t_refa
      End Get
      Set(ByVal value As String)
        _t_refa = value
      End Set
    End Property
    Public Property t_refb() As String
      Get
        Return _t_refb
      End Get
      Set(ByVal value As String)
        _t_refb = value
      End Set
    End Property
    Public Property t_prno() As String
      Get
        Return _t_prno
      End Get
      Set(ByVal value As String)
        _t_prno = value
      End Set
    End Property
    Public Property t_ctrj() As String
      Get
        Return _t_ctrj
      End Get
      Set(ByVal value As String)
        _t_ctrj = value
      End Set
    End Property
    Public Property t_cofc() As String
      Get
        Return _t_cofc
      End Get
      Set(ByVal value As String)
        _t_cofc = value
      End Set
    End Property
    Public Property t_fdpt() As String
      Get
        Return _t_fdpt
      End Get
      Set(ByVal value As String)
        _t_fdpt = value
      End Set
    End Property
    Public Property t_odty() As Int32
      Get
        Return _t_odty
      End Get
      Set(ByVal value As Int32)
        _t_odty = value
      End Set
    End Property
    Public Property t_odno() As String
      Get
        Return _t_odno
      End Get
      Set(ByVal value As String)
        _t_odno = value
      End Set
    End Property
    Public Property t_retr() As String
      Get
        Return _t_retr
      End Get
      Set(ByVal value As String)
        _t_retr = value
      End Set
    End Property
    Public Property t_sorn() As String
      Get
        Return _t_sorn
      End Get
      Set(ByVal value As String)
        _t_sorn = value
      End Set
    End Property
    Public Property t_cosn() As String
      Get
        Return _t_cosn
      End Get
      Set(ByVal value As String)
        _t_cosn = value
      End Set
    End Property
    Public Property t_akcd() As String
      Get
        Return _t_akcd
      End Get
      Set(ByVal value As String)
        _t_akcd = value
      End Set
    End Property
    Public Property t_crcd() As String
      Get
        Return _t_crcd
      End Get
      Set(ByVal value As String)
        _t_crcd = value
      End Set
    End Property
    Public Property t_ctcd() As String
      Get
        Return _t_ctcd
      End Get
      Set(ByVal value As String)
        _t_ctcd = value
      End Set
    End Property
    Public Property t_egen() As Int32
      Get
        Return _t_egen
      End Get
      Set(ByVal value As Int32)
        _t_egen = value
      End Set
    End Property
    Public Property t_sbim() As Int32
      Get
        Return _t_sbim
      End Get
      Set(ByVal value As Int32)
        _t_sbim = value
      End Set
    End Property
    Public Property t_paft() As Int32
      Get
        Return _t_paft
      End Get
      Set(ByVal value As Int32)
        _t_paft = value
      End Set
    End Property
    Public Property t_sbmt() As String
      Get
        Return _t_sbmt
      End Get
      Set(ByVal value As String)
        _t_sbmt = value
      End Set
    End Property
    Public Property t_bpcl() As String
      Get
        Return _t_bpcl
      End Get
      Set(ByVal value As String)
        _t_bpcl = value
      End Set
    End Property
    Public Property t_oamt() As Double
      Get
        Return _t_oamt
      End Get
      Set(ByVal value As Double)
        _t_oamt = value
      End Set
    End Property
    Public Property t_comm() As Int32
      Get
        Return _t_comm
      End Get
      Set(ByVal value As Int32)
        _t_comm = value
      End Set
    End Property
    Public Property t_iebp() As Int32
      Get
        Return _t_iebp
      End Get
      Set(ByVal value As Int32)
        _t_iebp = value
      End Set
    End Property
    Public Property t_iafc() As Int32
      Get
        Return _t_iafc
      End Get
      Set(ByVal value As Int32)
        _t_iafc = value
      End Set
    End Property
    Public Property t_lccl() As String
      Get
        Return _t_lccl
      End Get
      Set(ByVal value As String)
        _t_lccl = value
      End Set
    End Property
    Public Property t_hdst() As Int32
      Get
        Return _t_hdst
      End Get
      Set(ByVal value As Int32)
        _t_hdst = value
      End Set
    End Property
    Public Property t_hisp() As Int32
      Get
        Return _t_hisp
      End Get
      Set(ByVal value As Int32)
        _t_hisp = value
      End Set
    End Property
    Public Property t_hism() As Int32
      Get
        Return _t_hism
      End Get
      Set(ByVal value As Int32)
        _t_hism = value
      End Set
    End Property
    Public Property t_ccty() As String
      Get
        Return _t_ccty
      End Get
      Set(ByVal value As String)
        _t_ccty = value
      End Set
    End Property
    Public Property t_cvyn() As Int32
      Get
        Return _t_cvyn
      End Get
      Set(ByVal value As Int32)
        _t_cvyn = value
      End Set
    End Property
    Public Property t_bpid_l() As String
      Get
        Return _t_bpid_l
      End Get
      Set(ByVal value As String)
        _t_bpid_l = value
      End Set
    End Property
    Public Property t_impo_l() As Int32
      Get
        Return _t_impo_l
      End Get
      Set(ByVal value As Int32)
        _t_impo_l = value
      End Set
    End Property
    Public Property t_ccty_l() As String
      Get
        Return _t_ccty_l
      End Get
      Set(ByVal value As String)
        _t_ccty_l = value
      End Set
    End Property
    Public Property t_cvat_l() As String
      Get
        Return _t_cvat_l
      End Get
      Set(ByVal value As String)
        _t_cvat_l = value
      End Set
    End Property
    Public Property t_exmt_l() As Int32
      Get
        Return _t_exmt_l
      End Get
      Set(ByVal value As Int32)
        _t_exmt_l = value
      End Set
    End Property
    Public Property t_catg_l() As Int32
      Get
        Return _t_catg_l
      End Get
      Set(ByVal value As Int32)
        _t_catg_l = value
      End Set
    End Property
    Public Property t_ceno_l() As String
      Get
        Return _t_ceno_l
      End Get
      Set(ByVal value As String)
        _t_ceno_l = value
      End Set
    End Property
    Public Property t_bdbt_l() As Int32
      Get
        Return _t_bdbt_l
      End Get
      Set(ByVal value As Int32)
        _t_bdbt_l = value
      End Set
    End Property
    Public Property t_bnoo_l() As String
      Get
        Return _t_bnoo_l
      End Get
      Set(ByVal value As String)
        _t_bnoo_l = value
      End Set
    End Property
    Public Property t_txta() As Int32
      Get
        Return _t_txta
      End Get
      Set(ByVal value As Int32)
        _t_txta = value
      End Set
    End Property
    Public Property t_txtb() As Int32
      Get
        Return _t_txtb
      End Get
      Set(ByVal value As Int32)
        _t_txtb = value
      End Set
    End Property
    Public Property t_cdf_adat() As String
      Get
        If Not _t_cdf_adat = String.Empty Then
          Return Convert.ToDateTime(_t_cdf_adat).ToString("dd/MM/yyyy")
        End If
        Return _t_cdf_adat
      End Get
      Set(ByVal value As String)
         _t_cdf_adat = value
      End Set
    End Property
    Public Property t_cdf_alvl() As Int32
      Get
        Return _t_cdf_alvl
      End Get
      Set(ByVal value As Int32)
        _t_cdf_alvl = value
      End Set
    End Property
    Public Property t_cdf_onlr() As Double
      Get
        Return _t_cdf_onlr
      End Get
      Set(ByVal value As Double)
        _t_cdf_onlr = value
      End Set
    End Property
    Public Property t_cdf_prty() As Int32
      Get
        Return _t_cdf_prty
      End Get
      Set(ByVal value As Int32)
        _t_cdf_prty = value
      End Set
    End Property
    Public Property t_cdf_qap() As String
      Get
        Return _t_cdf_qap
      End Get
      Set(ByVal value As String)
        _t_cdf_qap = value
      End Set
    End Property
    Public Property t_cdf_qdat() As String
      Get
        If Not _t_cdf_qdat = String.Empty Then
          Return Convert.ToDateTime(_t_cdf_qdat).ToString("dd/MM/yyyy")
        End If
        Return _t_cdf_qdat
      End Get
      Set(ByVal value As String)
         _t_cdf_qdat = value
      End Set
    End Property
    Public Property t_cdf_refb() As String
      Get
        Return _t_cdf_refb
      End Get
      Set(ByVal value As String)
        _t_cdf_refb = value
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
    Public Property t_cdf_reas() As String
      Get
        Return _t_cdf_reas
      End Get
      Set(ByVal value As String)
        _t_cdf_reas = value
      End Set
    End Property
    Public Property t_cdf_qapa() As Int32
      Get
        Return _t_cdf_qapa
      End Get
      Set(ByVal value As Int32)
        _t_cdf_qapa = value
      End Set
    End Property
    Public Property t_atfr_l() As Int32
      Get
        Return _t_atfr_l
      End Get
      Set(ByVal value As Int32)
        _t_atfr_l = value
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return "" & _t_refa.ToString.PadRight(30, " ")
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _t_orno
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
    Public Class PKtdpur400
      Private _t_orno As String = ""
      Public Property t_orno() As String
        Get
          Return _t_orno
        End Get
        Set(ByVal value As String)
          _t_orno = value
        End Set
      End Property
    End Class
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function tdpur400SelectList(ByVal OrderBy As String) As List(Of SIS.TDPUR.tdpur400)
      Dim Results As List(Of SIS.TDPUR.tdpur400) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sptdpur400SelectList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.TDPUR.tdpur400)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.TDPUR.tdpur400(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function tdpur400GetNewRecord() As SIS.TDPUR.tdpur400
      Return New SIS.TDPUR.tdpur400()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function tdpur400GetByID(ByVal t_orno As String) As SIS.TDPUR.tdpur400
      Dim Results As SIS.TDPUR.tdpur400 = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sptdpur400SelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_orno",SqlDbType.VarChar,t_orno.ToString.Length, t_orno)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.TDPUR.tdpur400(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function tdpur400SelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.TDPUR.tdpur400)
      Dim Results As List(Of SIS.TDPUR.tdpur400) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "sptdpur400SelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "sptdpur400SelectListFilteres"
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.TDPUR.tdpur400)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.TDPUR.tdpur400(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function tdpur400SelectCount(ByVal SearchState As Boolean, ByVal SearchText As String) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
'    Autocomplete Method
    Public Shared Function Selecttdpur400AutoCompleteList(ByVal Prefix As String, ByVal count As Integer, ByVal contextKey As String) As String()
      Dim Results As List(Of String) = Nothing
      Dim aVal() As String = contextKey.Split("|".ToCharArray)
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sptdpur400AutoCompleteList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@prefix", SqlDbType.NVarChar, 50, Prefix)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@records", SqlDbType.Int, -1, count)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@bycode", SqlDbType.Int, 1, IIf(IsNumeric(Prefix),0,IIf(Prefix.ToLower=Prefix, 0, 1)))
          Results = New List(Of String)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Not Reader.HasRows Then
            Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem("---Select Value---".PadRight(30, " "),""))
          End If
          While (Reader.Read())
            Dim Tmp As SIS.TDPUR.tdpur400 = New SIS.TDPUR.tdpur400(Reader)
            Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem(Tmp.DisplayField, Tmp.PrimaryKey))
          End While
          Reader.Close()
        End Using
      End Using
      Return Results.ToArray
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
