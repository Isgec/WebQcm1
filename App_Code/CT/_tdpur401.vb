Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.TDPUR
  <DataObject()> _
  Partial Public Class tdpur401
    Private Shared _RecordCount As Integer
    Private _t_orno As String = ""
    Private _t_pono As Int32 = 0
    Private _t_sqnb As Int32 = 0
    Private _t_corg As Int32 = 0
    Private _t_oltp As Int32 = 0
    Private _t_otbp As String = ""
    Private _t_sfbp As String = ""
    Private _t_sfad As String = ""
    Private _t_sfcn As String = ""
    Private _t_sfwh As String = ""
    Private _t_item As String = ""
    Private _t_effn As Int32 = 0
    Private _t_sdsc As Int32 = 0
    Private _t_crrf As Int32 = 0
    Private _t_citt As String = ""
    Private _t_crit As String = ""
    Private _t_mpnr As String = ""
    Private _t_subc As Int32 = 0
    Private _t_mpsn As String = ""
    Private _t_cmnf As String = ""
    Private _t_mitm As String = ""
    Private _t_revi As String = ""
    Private _t_btsp As Int32 = 0
    Private _t_qual As Int32 = 0
    Private _t_qoor As Double = 0
    Private _t_cuqp As String = ""
    Private _t_cvqp As Double = 0
    Private _t_leng As Double = 0
    Private _t_widt As Double = 0
    Private _t_thic As Double = 0
    Private _t_odat As String = ""
    Private _t_ddta As String = ""
    Private _t_ddtb As String = ""
    Private _t_ddtc As String = ""
    Private _t_ddtd As String = ""
    Private _t_ddte As String = ""
    Private _t_ddtf As String = ""
    Private _t_rdta As String = ""
    Private _t_pric As Double = 0
    Private _t_porg As Int32 = 0
    Private _t_pmde As String = ""
    Private _t_pmse As Int32 = 0
    Private _t_cupp As String = ""
    Private _t_cvpp As Double = 0
    Private _t_disc_1 As Single = 0
    Private _t_disc_2 As Single = 0
    Private _t_disc_3 As Single = 0
    Private _t_disc_4 As Single = 0
    Private _t_disc_5 As Single = 0
    Private _t_disc_6 As Single = 0
    Private _t_disc_7 As Single = 0
    Private _t_disc_8 As Single = 0
    Private _t_disc_9 As Single = 0
    Private _t_disc_10 As Single = 0
    Private _t_disc_11 As Single = 0
    Private _t_ldam_1 As Double = 0
    Private _t_ldam_2 As Double = 0
    Private _t_ldam_3 As Double = 0
    Private _t_ldam_4 As Double = 0
    Private _t_ldam_5 As Double = 0
    Private _t_ldam_6 As Double = 0
    Private _t_ldam_7 As Double = 0
    Private _t_ldam_8 As Double = 0
    Private _t_ldam_9 As Double = 0
    Private _t_ldam_10 As Double = 0
    Private _t_ldam_11 As Double = 0
    Private _t_dorg_1 As Int32 = 0
    Private _t_dorg_2 As Int32 = 0
    Private _t_dorg_3 As Int32 = 0
    Private _t_dorg_4 As Int32 = 0
    Private _t_dorg_5 As Int32 = 0
    Private _t_dorg_6 As Int32 = 0
    Private _t_dorg_7 As Int32 = 0
    Private _t_dorg_8 As Int32 = 0
    Private _t_dorg_9 As Int32 = 0
    Private _t_dorg_10 As Int32 = 0
    Private _t_dorg_11 As Int32 = 0
    Private _t_dmty_1 As Int32 = 0
    Private _t_dmty_2 As Int32 = 0
    Private _t_dmty_3 As Int32 = 0
    Private _t_dmty_4 As Int32 = 0
    Private _t_dmty_5 As Int32 = 0
    Private _t_dmty_6 As Int32 = 0
    Private _t_dmty_7 As Int32 = 0
    Private _t_dmty_8 As Int32 = 0
    Private _t_dmty_9 As Int32 = 0
    Private _t_dmty_10 As Int32 = 0
    Private _t_dmty_11 As Int32 = 0
    Private _t_dmde_1 As String = ""
    Private _t_dmde_2 As String = ""
    Private _t_dmde_3 As String = ""
    Private _t_dmde_4 As String = ""
    Private _t_dmde_5 As String = ""
    Private _t_dmde_6 As String = ""
    Private _t_dmde_7 As String = ""
    Private _t_dmde_8 As String = ""
    Private _t_dmde_9 As String = ""
    Private _t_dmde_10 As String = ""
    Private _t_dmde_11 As String = ""
    Private _t_dmse_1 As Int32 = 0
    Private _t_dmse_2 As Int32 = 0
    Private _t_dmse_3 As Int32 = 0
    Private _t_dmse_4 As Int32 = 0
    Private _t_dmse_5 As Int32 = 0
    Private _t_dmse_6 As Int32 = 0
    Private _t_dmse_7 As Int32 = 0
    Private _t_dmse_8 As Int32 = 0
    Private _t_dmse_9 As Int32 = 0
    Private _t_dmse_10 As Int32 = 0
    Private _t_dmse_11 As Int32 = 0
    Private _t_dmth_1 As Int32 = 0
    Private _t_dmth_2 As Int32 = 0
    Private _t_dmth_3 As Int32 = 0
    Private _t_dmth_4 As Int32 = 0
    Private _t_dmth_5 As Int32 = 0
    Private _t_dmth_6 As Int32 = 0
    Private _t_dmth_7 As Int32 = 0
    Private _t_dmth_8 As Int32 = 0
    Private _t_dmth_9 As Int32 = 0
    Private _t_dmth_10 As Int32 = 0
    Private _t_dmth_11 As Int32 = 0
    Private _t_cdis_1 As String = ""
    Private _t_cdis_2 As String = ""
    Private _t_cdis_3 As String = ""
    Private _t_cdis_4 As String = ""
    Private _t_cdis_5 As String = ""
    Private _t_cdis_6 As String = ""
    Private _t_cdis_7 As String = ""
    Private _t_cdis_8 As String = ""
    Private _t_cdis_9 As String = ""
    Private _t_cdis_10 As String = ""
    Private _t_cdis_11 As String = ""
    Private _t_dtrm As Int32 = 0
    Private _t_elgb As Int32 = 0
    Private _t_stdc As Double = 0
    Private _t_oamt As Double = 0
    Private _t_rcno As String = ""
    Private _t_rseq As Int32 = 0
    Private _t_dino As String = ""
    Private _t_qips As Double = 0
    Private _t_qidl As Double = 0
    Private _t_qiap As Double = 0
    Private _t_crej As String = ""
    Private _t_qirj As Double = 0
    Private _t_qibo As Double = 0
    Private _t_qbbc As Double = 0
    Private _t_cubp As String = ""
    Private _t_cvbp As Double = 0
    Private _t_fire As Int32 = 0
    Private _t_qibp As Double = 0
    Private _t_ddon As Int32 = 0
    Private _t_lseq As Int32 = 0
    Private _t_pseq As Int32 = 0
    Private _t_amld As Double = 0
    Private _t_amod As Double = 0
    Private _t_damt As Double = 0
    Private _t_stsc As Int32 = 0
    Private _t_stsd As Int32 = 0
    Private _t_vryn As Int32 = 0
    Private _t_invn As String = ""
    Private _t_invd As String = ""
    Private _t_copr_1 As Double = 0
    Private _t_copr_2 As Double = 0
    Private _t_copr_3 As Double = 0
    Private _t_coop_1 As Double = 0
    Private _t_coop_2 As Double = 0
    Private _t_coop_3 As Double = 0
    Private _t_cpcp As String = ""
    Private _t_cwar As String = ""
    Private _t_cadr As String = ""
    Private _t_lsel As Int32 = 0
    Private _t_clot As String = ""
    Private _t_cprj As String = ""
    Private _t_cspa As String = ""
    Private _t_cact As String = ""
    Private _t_cstl As String = ""
    Private _t_ccco As String = ""
    Private _t_ctrj As String = ""
    Private _t_akcd As String = ""
    Private _t_cfrw As String = ""
    Private _t_crbn As Int32 = 0
    Private _t_clyn As Int32 = 0
    Private _t_cpva As Int32 = 0
    Private _t_crcd As String = ""
    Private _t_ctcd As String = ""
    Private _t_cosn As String = ""
    Private _t_qiiv As Double = 0
    Private _t_iamt As Double = 0
    Private _t_comm As Int32 = 0
    Private _t_appr As Int32 = 0
    Private _t_ccty As String = ""
    Private _t_cvat As String = ""
    Private _t_bptc As String = ""
    Private _t_exmt As Int32 = 0
    Private _t_ceno As String = ""
    Private _t_rcod As String = ""
    Private _t_bpcl As String = ""
    Private _t_taxp As Int32 = 0
    Private _t_gefo As Int32 = 0
    Private _t_ldat As String = ""
    Private _t_serv As String = ""
    Private _t_casi As String = ""
    Private _t_ptpe As String = ""
    Private _t_glco As String = ""
    Private _t_sbim As Int32 = 0
    Private _t_paft As Int32 = 0
    Private _t_sbmt As String = ""
    Private _t_cuva As Double = 0
    Private _t_cono As String = ""
    Private _t_cpon As Int32 = 0
    Private _t_ccof As String = ""
    Private _t_cnig As Int32 = 0
    Private _t_paya As String = ""
    Private _t_cpay As String = ""
    Private _t_cdec As String = ""
    Private _t_ptpa As String = ""
    Private _t_pmnt As Int32 = 0
    Private _t_pmni As Int32 = 0
    Private _t_pmnd As Int32 = 0
    Private _t_owns As Int32 = 0
    Private _t_lccl As String = ""
    Private _t_spcn As String = ""
    Private _t_bgxc As Int32 = 0
    Private _t_cpcl As String = ""
    Private _t_cpln As String = ""
    Private _t_csgp As String = ""
    Private _t_acti As String = ""
    Private _t_pmsk As String = ""
    Private _t_rnso_l As Int32 = 0
    Private _t_rnsb_l As Int32 = 0
    Private _t_ecif_l As Double = 0
    Private _t_assv_l As Double = 0
    Private _t_elco_l As Double = 0
    Private _t_ihsn_l As String = ""
    Private _t_mrpo_l As Int32 = 0
    Private _t_iexb_l As Int32 = 0
    Private _t_icen_l As Int32 = 0
    Private _t_imca_l As Int32 = 0
    Private _t_exca_l As Int32 = 0
    Private _t_mrpe_l As Int32 = 0
    Private _t_hcod_l As String = ""
    Private _t_cenv_l As Int32 = 0
    Private _t_icat_l As Int32 = 0
    Private _t_asoe_l As Int32 = 0
    Private _t_asve_l As Double = 0
    Private _t_dise_l As Single = 0
    Private _t_fase_l As Double = 0
    Private _t_asov_l As Int32 = 0
    Private _t_asvv_l As Double = 0
    Private _t_disv_l As Single = 0
    Private _t_fasv_l As Double = 0
    Private _t_asos_l As Int32 = 0
    Private _t_asvs_l As Double = 0
    Private _t_diss_l As Single = 0
    Private _t_fass_l As Double = 0
    Private _t_iecc_l As Int32 = 0
    Private _t_mrpv_l As Int32 = 0
    Private _t_mrps_l As Int32 = 0
    Private _t_reno_l As String = ""
    Private _t_rcln_l As Int32 = 0
    Private _t_mrpi_l As Double = 0
    Private _t_ocim_l As Double = 0
    Private _t_ocio_l As Double = 0
    Private _t_extx_l As Double = 0
    Private _t_cltx_l As Double = 0
    Private _t_lacm_l As Double = 0
    Private _t_tase_l As Double = 0
    Private _t_tasv_l As Double = 0
    Private _t_tass_l As Double = 0
    Private _t_uiac_l As Int32 = 0
    Private _t_uaig_l As Int32 = 0
    Private _t_txin_l As Int32 = 0
    Private _t_gsub_l As Int32 = 0
    Private _t_txta As Int32 = 0
    Private _t_btx1 As Int32 = 0
    Private _t_btx2 As Int32 = 0
    Private _t_cdf_ldat As String = ""
    Private _t_Refcntd As Int32 = 0
    Private _t_Refcntu As Int32 = 0
    Private _t_asog_l As Int32 = 0
    Private _t_asoi_l As Int32 = 0
    Private _t_asvg_l As Double = 0
    Private _t_atfr_l As Int32 = 0
    Private _t_gsta_l As Int32 = 0
    Private _t_tasg_l As Double = 0
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
    Public Property t_pono() As Int32
      Get
        Return _t_pono
      End Get
      Set(ByVal value As Int32)
        _t_pono = value
      End Set
    End Property
    Public Property t_sqnb() As Int32
      Get
        Return _t_sqnb
      End Get
      Set(ByVal value As Int32)
        _t_sqnb = value
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
    Public Property t_oltp() As Int32
      Get
        Return _t_oltp
      End Get
      Set(ByVal value As Int32)
        _t_oltp = value
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
    Public Property t_sfwh() As String
      Get
        Return _t_sfwh
      End Get
      Set(ByVal value As String)
        _t_sfwh = value
      End Set
    End Property
    Public Property t_item() As String
      Get
        Return _t_item
      End Get
      Set(ByVal value As String)
        _t_item = value
      End Set
    End Property
    Public Property t_effn() As Int32
      Get
        Return _t_effn
      End Get
      Set(ByVal value As Int32)
        _t_effn = value
      End Set
    End Property
    Public Property t_sdsc() As Int32
      Get
        Return _t_sdsc
      End Get
      Set(ByVal value As Int32)
        _t_sdsc = value
      End Set
    End Property
    Public Property t_crrf() As Int32
      Get
        Return _t_crrf
      End Get
      Set(ByVal value As Int32)
        _t_crrf = value
      End Set
    End Property
    Public Property t_citt() As String
      Get
        Return _t_citt
      End Get
      Set(ByVal value As String)
        _t_citt = value
      End Set
    End Property
    Public Property t_crit() As String
      Get
        Return _t_crit
      End Get
      Set(ByVal value As String)
        _t_crit = value
      End Set
    End Property
    Public Property t_mpnr() As String
      Get
        Return _t_mpnr
      End Get
      Set(ByVal value As String)
        _t_mpnr = value
      End Set
    End Property
    Public Property t_subc() As Int32
      Get
        Return _t_subc
      End Get
      Set(ByVal value As Int32)
        _t_subc = value
      End Set
    End Property
    Public Property t_mpsn() As String
      Get
        Return _t_mpsn
      End Get
      Set(ByVal value As String)
        _t_mpsn = value
      End Set
    End Property
    Public Property t_cmnf() As String
      Get
        Return _t_cmnf
      End Get
      Set(ByVal value As String)
        _t_cmnf = value
      End Set
    End Property
    Public Property t_mitm() As String
      Get
        Return _t_mitm
      End Get
      Set(ByVal value As String)
        _t_mitm = value
      End Set
    End Property
    Public Property t_revi() As String
      Get
        Return _t_revi
      End Get
      Set(ByVal value As String)
        _t_revi = value
      End Set
    End Property
    Public Property t_btsp() As Int32
      Get
        Return _t_btsp
      End Get
      Set(ByVal value As Int32)
        _t_btsp = value
      End Set
    End Property
    Public Property t_qual() As Int32
      Get
        Return _t_qual
      End Get
      Set(ByVal value As Int32)
        _t_qual = value
      End Set
    End Property
    Public Property t_qoor() As Double
      Get
        Return _t_qoor
      End Get
      Set(ByVal value As Double)
        _t_qoor = value
      End Set
    End Property
    Public Property t_cuqp() As String
      Get
        Return _t_cuqp
      End Get
      Set(ByVal value As String)
        _t_cuqp = value
      End Set
    End Property
    Public Property t_cvqp() As Double
      Get
        Return _t_cvqp
      End Get
      Set(ByVal value As Double)
        _t_cvqp = value
      End Set
    End Property
    Public Property t_leng() As Double
      Get
        Return _t_leng
      End Get
      Set(ByVal value As Double)
        _t_leng = value
      End Set
    End Property
    Public Property t_widt() As Double
      Get
        Return _t_widt
      End Get
      Set(ByVal value As Double)
        _t_widt = value
      End Set
    End Property
    Public Property t_thic() As Double
      Get
        Return _t_thic
      End Get
      Set(ByVal value As Double)
        _t_thic = value
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
    Public Property t_ddta() As String
      Get
        If Not _t_ddta = String.Empty Then
          Return Convert.ToDateTime(_t_ddta).ToString("dd/MM/yyyy")
        End If
        Return _t_ddta
      End Get
      Set(ByVal value As String)
         _t_ddta = value
      End Set
    End Property
    Public Property t_ddtb() As String
      Get
        If Not _t_ddtb = String.Empty Then
          Return Convert.ToDateTime(_t_ddtb).ToString("dd/MM/yyyy")
        End If
        Return _t_ddtb
      End Get
      Set(ByVal value As String)
         _t_ddtb = value
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
    Public Property t_ddtd() As String
      Get
        If Not _t_ddtd = String.Empty Then
          Return Convert.ToDateTime(_t_ddtd).ToString("dd/MM/yyyy")
        End If
        Return _t_ddtd
      End Get
      Set(ByVal value As String)
         _t_ddtd = value
      End Set
    End Property
    Public Property t_ddte() As String
      Get
        If Not _t_ddte = String.Empty Then
          Return Convert.ToDateTime(_t_ddte).ToString("dd/MM/yyyy")
        End If
        Return _t_ddte
      End Get
      Set(ByVal value As String)
         _t_ddte = value
      End Set
    End Property
    Public Property t_ddtf() As String
      Get
        If Not _t_ddtf = String.Empty Then
          Return Convert.ToDateTime(_t_ddtf).ToString("dd/MM/yyyy")
        End If
        Return _t_ddtf
      End Get
      Set(ByVal value As String)
         _t_ddtf = value
      End Set
    End Property
    Public Property t_rdta() As String
      Get
        If Not _t_rdta = String.Empty Then
          Return Convert.ToDateTime(_t_rdta).ToString("dd/MM/yyyy")
        End If
        Return _t_rdta
      End Get
      Set(ByVal value As String)
         _t_rdta = value
      End Set
    End Property
    Public Property t_pric() As Double
      Get
        Return _t_pric
      End Get
      Set(ByVal value As Double)
        _t_pric = value
      End Set
    End Property
    Public Property t_porg() As Int32
      Get
        Return _t_porg
      End Get
      Set(ByVal value As Int32)
        _t_porg = value
      End Set
    End Property
    Public Property t_pmde() As String
      Get
        Return _t_pmde
      End Get
      Set(ByVal value As String)
        _t_pmde = value
      End Set
    End Property
    Public Property t_pmse() As Int32
      Get
        Return _t_pmse
      End Get
      Set(ByVal value As Int32)
        _t_pmse = value
      End Set
    End Property
    Public Property t_cupp() As String
      Get
        Return _t_cupp
      End Get
      Set(ByVal value As String)
        _t_cupp = value
      End Set
    End Property
    Public Property t_cvpp() As Double
      Get
        Return _t_cvpp
      End Get
      Set(ByVal value As Double)
        _t_cvpp = value
      End Set
    End Property
    Public Property t_disc_1() As Single
      Get
        Return _t_disc_1
      End Get
      Set(ByVal value As Single)
        _t_disc_1 = value
      End Set
    End Property
    Public Property t_disc_2() As Single
      Get
        Return _t_disc_2
      End Get
      Set(ByVal value As Single)
        _t_disc_2 = value
      End Set
    End Property
    Public Property t_disc_3() As Single
      Get
        Return _t_disc_3
      End Get
      Set(ByVal value As Single)
        _t_disc_3 = value
      End Set
    End Property
    Public Property t_disc_4() As Single
      Get
        Return _t_disc_4
      End Get
      Set(ByVal value As Single)
        _t_disc_4 = value
      End Set
    End Property
    Public Property t_disc_5() As Single
      Get
        Return _t_disc_5
      End Get
      Set(ByVal value As Single)
        _t_disc_5 = value
      End Set
    End Property
    Public Property t_disc_6() As Single
      Get
        Return _t_disc_6
      End Get
      Set(ByVal value As Single)
        _t_disc_6 = value
      End Set
    End Property
    Public Property t_disc_7() As Single
      Get
        Return _t_disc_7
      End Get
      Set(ByVal value As Single)
        _t_disc_7 = value
      End Set
    End Property
    Public Property t_disc_8() As Single
      Get
        Return _t_disc_8
      End Get
      Set(ByVal value As Single)
        _t_disc_8 = value
      End Set
    End Property
    Public Property t_disc_9() As Single
      Get
        Return _t_disc_9
      End Get
      Set(ByVal value As Single)
        _t_disc_9 = value
      End Set
    End Property
    Public Property t_disc_10() As Single
      Get
        Return _t_disc_10
      End Get
      Set(ByVal value As Single)
        _t_disc_10 = value
      End Set
    End Property
    Public Property t_disc_11() As Single
      Get
        Return _t_disc_11
      End Get
      Set(ByVal value As Single)
        _t_disc_11 = value
      End Set
    End Property
    Public Property t_ldam_1() As Double
      Get
        Return _t_ldam_1
      End Get
      Set(ByVal value As Double)
        _t_ldam_1 = value
      End Set
    End Property
    Public Property t_ldam_2() As Double
      Get
        Return _t_ldam_2
      End Get
      Set(ByVal value As Double)
        _t_ldam_2 = value
      End Set
    End Property
    Public Property t_ldam_3() As Double
      Get
        Return _t_ldam_3
      End Get
      Set(ByVal value As Double)
        _t_ldam_3 = value
      End Set
    End Property
    Public Property t_ldam_4() As Double
      Get
        Return _t_ldam_4
      End Get
      Set(ByVal value As Double)
        _t_ldam_4 = value
      End Set
    End Property
    Public Property t_ldam_5() As Double
      Get
        Return _t_ldam_5
      End Get
      Set(ByVal value As Double)
        _t_ldam_5 = value
      End Set
    End Property
    Public Property t_ldam_6() As Double
      Get
        Return _t_ldam_6
      End Get
      Set(ByVal value As Double)
        _t_ldam_6 = value
      End Set
    End Property
    Public Property t_ldam_7() As Double
      Get
        Return _t_ldam_7
      End Get
      Set(ByVal value As Double)
        _t_ldam_7 = value
      End Set
    End Property
    Public Property t_ldam_8() As Double
      Get
        Return _t_ldam_8
      End Get
      Set(ByVal value As Double)
        _t_ldam_8 = value
      End Set
    End Property
    Public Property t_ldam_9() As Double
      Get
        Return _t_ldam_9
      End Get
      Set(ByVal value As Double)
        _t_ldam_9 = value
      End Set
    End Property
    Public Property t_ldam_10() As Double
      Get
        Return _t_ldam_10
      End Get
      Set(ByVal value As Double)
        _t_ldam_10 = value
      End Set
    End Property
    Public Property t_ldam_11() As Double
      Get
        Return _t_ldam_11
      End Get
      Set(ByVal value As Double)
        _t_ldam_11 = value
      End Set
    End Property
    Public Property t_dorg_1() As Int32
      Get
        Return _t_dorg_1
      End Get
      Set(ByVal value As Int32)
        _t_dorg_1 = value
      End Set
    End Property
    Public Property t_dorg_2() As Int32
      Get
        Return _t_dorg_2
      End Get
      Set(ByVal value As Int32)
        _t_dorg_2 = value
      End Set
    End Property
    Public Property t_dorg_3() As Int32
      Get
        Return _t_dorg_3
      End Get
      Set(ByVal value As Int32)
        _t_dorg_3 = value
      End Set
    End Property
    Public Property t_dorg_4() As Int32
      Get
        Return _t_dorg_4
      End Get
      Set(ByVal value As Int32)
        _t_dorg_4 = value
      End Set
    End Property
    Public Property t_dorg_5() As Int32
      Get
        Return _t_dorg_5
      End Get
      Set(ByVal value As Int32)
        _t_dorg_5 = value
      End Set
    End Property
    Public Property t_dorg_6() As Int32
      Get
        Return _t_dorg_6
      End Get
      Set(ByVal value As Int32)
        _t_dorg_6 = value
      End Set
    End Property
    Public Property t_dorg_7() As Int32
      Get
        Return _t_dorg_7
      End Get
      Set(ByVal value As Int32)
        _t_dorg_7 = value
      End Set
    End Property
    Public Property t_dorg_8() As Int32
      Get
        Return _t_dorg_8
      End Get
      Set(ByVal value As Int32)
        _t_dorg_8 = value
      End Set
    End Property
    Public Property t_dorg_9() As Int32
      Get
        Return _t_dorg_9
      End Get
      Set(ByVal value As Int32)
        _t_dorg_9 = value
      End Set
    End Property
    Public Property t_dorg_10() As Int32
      Get
        Return _t_dorg_10
      End Get
      Set(ByVal value As Int32)
        _t_dorg_10 = value
      End Set
    End Property
    Public Property t_dorg_11() As Int32
      Get
        Return _t_dorg_11
      End Get
      Set(ByVal value As Int32)
        _t_dorg_11 = value
      End Set
    End Property
    Public Property t_dmty_1() As Int32
      Get
        Return _t_dmty_1
      End Get
      Set(ByVal value As Int32)
        _t_dmty_1 = value
      End Set
    End Property
    Public Property t_dmty_2() As Int32
      Get
        Return _t_dmty_2
      End Get
      Set(ByVal value As Int32)
        _t_dmty_2 = value
      End Set
    End Property
    Public Property t_dmty_3() As Int32
      Get
        Return _t_dmty_3
      End Get
      Set(ByVal value As Int32)
        _t_dmty_3 = value
      End Set
    End Property
    Public Property t_dmty_4() As Int32
      Get
        Return _t_dmty_4
      End Get
      Set(ByVal value As Int32)
        _t_dmty_4 = value
      End Set
    End Property
    Public Property t_dmty_5() As Int32
      Get
        Return _t_dmty_5
      End Get
      Set(ByVal value As Int32)
        _t_dmty_5 = value
      End Set
    End Property
    Public Property t_dmty_6() As Int32
      Get
        Return _t_dmty_6
      End Get
      Set(ByVal value As Int32)
        _t_dmty_6 = value
      End Set
    End Property
    Public Property t_dmty_7() As Int32
      Get
        Return _t_dmty_7
      End Get
      Set(ByVal value As Int32)
        _t_dmty_7 = value
      End Set
    End Property
    Public Property t_dmty_8() As Int32
      Get
        Return _t_dmty_8
      End Get
      Set(ByVal value As Int32)
        _t_dmty_8 = value
      End Set
    End Property
    Public Property t_dmty_9() As Int32
      Get
        Return _t_dmty_9
      End Get
      Set(ByVal value As Int32)
        _t_dmty_9 = value
      End Set
    End Property
    Public Property t_dmty_10() As Int32
      Get
        Return _t_dmty_10
      End Get
      Set(ByVal value As Int32)
        _t_dmty_10 = value
      End Set
    End Property
    Public Property t_dmty_11() As Int32
      Get
        Return _t_dmty_11
      End Get
      Set(ByVal value As Int32)
        _t_dmty_11 = value
      End Set
    End Property
    Public Property t_dmde_1() As String
      Get
        Return _t_dmde_1
      End Get
      Set(ByVal value As String)
        _t_dmde_1 = value
      End Set
    End Property
    Public Property t_dmde_2() As String
      Get
        Return _t_dmde_2
      End Get
      Set(ByVal value As String)
        _t_dmde_2 = value
      End Set
    End Property
    Public Property t_dmde_3() As String
      Get
        Return _t_dmde_3
      End Get
      Set(ByVal value As String)
        _t_dmde_3 = value
      End Set
    End Property
    Public Property t_dmde_4() As String
      Get
        Return _t_dmde_4
      End Get
      Set(ByVal value As String)
        _t_dmde_4 = value
      End Set
    End Property
    Public Property t_dmde_5() As String
      Get
        Return _t_dmde_5
      End Get
      Set(ByVal value As String)
        _t_dmde_5 = value
      End Set
    End Property
    Public Property t_dmde_6() As String
      Get
        Return _t_dmde_6
      End Get
      Set(ByVal value As String)
        _t_dmde_6 = value
      End Set
    End Property
    Public Property t_dmde_7() As String
      Get
        Return _t_dmde_7
      End Get
      Set(ByVal value As String)
        _t_dmde_7 = value
      End Set
    End Property
    Public Property t_dmde_8() As String
      Get
        Return _t_dmde_8
      End Get
      Set(ByVal value As String)
        _t_dmde_8 = value
      End Set
    End Property
    Public Property t_dmde_9() As String
      Get
        Return _t_dmde_9
      End Get
      Set(ByVal value As String)
        _t_dmde_9 = value
      End Set
    End Property
    Public Property t_dmde_10() As String
      Get
        Return _t_dmde_10
      End Get
      Set(ByVal value As String)
        _t_dmde_10 = value
      End Set
    End Property
    Public Property t_dmde_11() As String
      Get
        Return _t_dmde_11
      End Get
      Set(ByVal value As String)
        _t_dmde_11 = value
      End Set
    End Property
    Public Property t_dmse_1() As Int32
      Get
        Return _t_dmse_1
      End Get
      Set(ByVal value As Int32)
        _t_dmse_1 = value
      End Set
    End Property
    Public Property t_dmse_2() As Int32
      Get
        Return _t_dmse_2
      End Get
      Set(ByVal value As Int32)
        _t_dmse_2 = value
      End Set
    End Property
    Public Property t_dmse_3() As Int32
      Get
        Return _t_dmse_3
      End Get
      Set(ByVal value As Int32)
        _t_dmse_3 = value
      End Set
    End Property
    Public Property t_dmse_4() As Int32
      Get
        Return _t_dmse_4
      End Get
      Set(ByVal value As Int32)
        _t_dmse_4 = value
      End Set
    End Property
    Public Property t_dmse_5() As Int32
      Get
        Return _t_dmse_5
      End Get
      Set(ByVal value As Int32)
        _t_dmse_5 = value
      End Set
    End Property
    Public Property t_dmse_6() As Int32
      Get
        Return _t_dmse_6
      End Get
      Set(ByVal value As Int32)
        _t_dmse_6 = value
      End Set
    End Property
    Public Property t_dmse_7() As Int32
      Get
        Return _t_dmse_7
      End Get
      Set(ByVal value As Int32)
        _t_dmse_7 = value
      End Set
    End Property
    Public Property t_dmse_8() As Int32
      Get
        Return _t_dmse_8
      End Get
      Set(ByVal value As Int32)
        _t_dmse_8 = value
      End Set
    End Property
    Public Property t_dmse_9() As Int32
      Get
        Return _t_dmse_9
      End Get
      Set(ByVal value As Int32)
        _t_dmse_9 = value
      End Set
    End Property
    Public Property t_dmse_10() As Int32
      Get
        Return _t_dmse_10
      End Get
      Set(ByVal value As Int32)
        _t_dmse_10 = value
      End Set
    End Property
    Public Property t_dmse_11() As Int32
      Get
        Return _t_dmse_11
      End Get
      Set(ByVal value As Int32)
        _t_dmse_11 = value
      End Set
    End Property
    Public Property t_dmth_1() As Int32
      Get
        Return _t_dmth_1
      End Get
      Set(ByVal value As Int32)
        _t_dmth_1 = value
      End Set
    End Property
    Public Property t_dmth_2() As Int32
      Get
        Return _t_dmth_2
      End Get
      Set(ByVal value As Int32)
        _t_dmth_2 = value
      End Set
    End Property
    Public Property t_dmth_3() As Int32
      Get
        Return _t_dmth_3
      End Get
      Set(ByVal value As Int32)
        _t_dmth_3 = value
      End Set
    End Property
    Public Property t_dmth_4() As Int32
      Get
        Return _t_dmth_4
      End Get
      Set(ByVal value As Int32)
        _t_dmth_4 = value
      End Set
    End Property
    Public Property t_dmth_5() As Int32
      Get
        Return _t_dmth_5
      End Get
      Set(ByVal value As Int32)
        _t_dmth_5 = value
      End Set
    End Property
    Public Property t_dmth_6() As Int32
      Get
        Return _t_dmth_6
      End Get
      Set(ByVal value As Int32)
        _t_dmth_6 = value
      End Set
    End Property
    Public Property t_dmth_7() As Int32
      Get
        Return _t_dmth_7
      End Get
      Set(ByVal value As Int32)
        _t_dmth_7 = value
      End Set
    End Property
    Public Property t_dmth_8() As Int32
      Get
        Return _t_dmth_8
      End Get
      Set(ByVal value As Int32)
        _t_dmth_8 = value
      End Set
    End Property
    Public Property t_dmth_9() As Int32
      Get
        Return _t_dmth_9
      End Get
      Set(ByVal value As Int32)
        _t_dmth_9 = value
      End Set
    End Property
    Public Property t_dmth_10() As Int32
      Get
        Return _t_dmth_10
      End Get
      Set(ByVal value As Int32)
        _t_dmth_10 = value
      End Set
    End Property
    Public Property t_dmth_11() As Int32
      Get
        Return _t_dmth_11
      End Get
      Set(ByVal value As Int32)
        _t_dmth_11 = value
      End Set
    End Property
    Public Property t_cdis_1() As String
      Get
        Return _t_cdis_1
      End Get
      Set(ByVal value As String)
        _t_cdis_1 = value
      End Set
    End Property
    Public Property t_cdis_2() As String
      Get
        Return _t_cdis_2
      End Get
      Set(ByVal value As String)
        _t_cdis_2 = value
      End Set
    End Property
    Public Property t_cdis_3() As String
      Get
        Return _t_cdis_3
      End Get
      Set(ByVal value As String)
        _t_cdis_3 = value
      End Set
    End Property
    Public Property t_cdis_4() As String
      Get
        Return _t_cdis_4
      End Get
      Set(ByVal value As String)
        _t_cdis_4 = value
      End Set
    End Property
    Public Property t_cdis_5() As String
      Get
        Return _t_cdis_5
      End Get
      Set(ByVal value As String)
        _t_cdis_5 = value
      End Set
    End Property
    Public Property t_cdis_6() As String
      Get
        Return _t_cdis_6
      End Get
      Set(ByVal value As String)
        _t_cdis_6 = value
      End Set
    End Property
    Public Property t_cdis_7() As String
      Get
        Return _t_cdis_7
      End Get
      Set(ByVal value As String)
        _t_cdis_7 = value
      End Set
    End Property
    Public Property t_cdis_8() As String
      Get
        Return _t_cdis_8
      End Get
      Set(ByVal value As String)
        _t_cdis_8 = value
      End Set
    End Property
    Public Property t_cdis_9() As String
      Get
        Return _t_cdis_9
      End Get
      Set(ByVal value As String)
        _t_cdis_9 = value
      End Set
    End Property
    Public Property t_cdis_10() As String
      Get
        Return _t_cdis_10
      End Get
      Set(ByVal value As String)
        _t_cdis_10 = value
      End Set
    End Property
    Public Property t_cdis_11() As String
      Get
        Return _t_cdis_11
      End Get
      Set(ByVal value As String)
        _t_cdis_11 = value
      End Set
    End Property
    Public Property t_dtrm() As Int32
      Get
        Return _t_dtrm
      End Get
      Set(ByVal value As Int32)
        _t_dtrm = value
      End Set
    End Property
    Public Property t_elgb() As Int32
      Get
        Return _t_elgb
      End Get
      Set(ByVal value As Int32)
        _t_elgb = value
      End Set
    End Property
    Public Property t_stdc() As Double
      Get
        Return _t_stdc
      End Get
      Set(ByVal value As Double)
        _t_stdc = value
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
    Public Property t_rcno() As String
      Get
        Return _t_rcno
      End Get
      Set(ByVal value As String)
        _t_rcno = value
      End Set
    End Property
    Public Property t_rseq() As Int32
      Get
        Return _t_rseq
      End Get
      Set(ByVal value As Int32)
        _t_rseq = value
      End Set
    End Property
    Public Property t_dino() As String
      Get
        Return _t_dino
      End Get
      Set(ByVal value As String)
        _t_dino = value
      End Set
    End Property
    Public Property t_qips() As Double
      Get
        Return _t_qips
      End Get
      Set(ByVal value As Double)
        _t_qips = value
      End Set
    End Property
    Public Property t_qidl() As Double
      Get
        Return _t_qidl
      End Get
      Set(ByVal value As Double)
        _t_qidl = value
      End Set
    End Property
    Public Property t_qiap() As Double
      Get
        Return _t_qiap
      End Get
      Set(ByVal value As Double)
        _t_qiap = value
      End Set
    End Property
    Public Property t_crej() As String
      Get
        Return _t_crej
      End Get
      Set(ByVal value As String)
        _t_crej = value
      End Set
    End Property
    Public Property t_qirj() As Double
      Get
        Return _t_qirj
      End Get
      Set(ByVal value As Double)
        _t_qirj = value
      End Set
    End Property
    Public Property t_qibo() As Double
      Get
        Return _t_qibo
      End Get
      Set(ByVal value As Double)
        _t_qibo = value
      End Set
    End Property
    Public Property t_qbbc() As Double
      Get
        Return _t_qbbc
      End Get
      Set(ByVal value As Double)
        _t_qbbc = value
      End Set
    End Property
    Public Property t_cubp() As String
      Get
        Return _t_cubp
      End Get
      Set(ByVal value As String)
        _t_cubp = value
      End Set
    End Property
    Public Property t_cvbp() As Double
      Get
        Return _t_cvbp
      End Get
      Set(ByVal value As Double)
        _t_cvbp = value
      End Set
    End Property
    Public Property t_fire() As Int32
      Get
        Return _t_fire
      End Get
      Set(ByVal value As Int32)
        _t_fire = value
      End Set
    End Property
    Public Property t_qibp() As Double
      Get
        Return _t_qibp
      End Get
      Set(ByVal value As Double)
        _t_qibp = value
      End Set
    End Property
    Public Property t_ddon() As Int32
      Get
        Return _t_ddon
      End Get
      Set(ByVal value As Int32)
        _t_ddon = value
      End Set
    End Property
    Public Property t_lseq() As Int32
      Get
        Return _t_lseq
      End Get
      Set(ByVal value As Int32)
        _t_lseq = value
      End Set
    End Property
    Public Property t_pseq() As Int32
      Get
        Return _t_pseq
      End Get
      Set(ByVal value As Int32)
        _t_pseq = value
      End Set
    End Property
    Public Property t_amld() As Double
      Get
        Return _t_amld
      End Get
      Set(ByVal value As Double)
        _t_amld = value
      End Set
    End Property
    Public Property t_amod() As Double
      Get
        Return _t_amod
      End Get
      Set(ByVal value As Double)
        _t_amod = value
      End Set
    End Property
    Public Property t_damt() As Double
      Get
        Return _t_damt
      End Get
      Set(ByVal value As Double)
        _t_damt = value
      End Set
    End Property
    Public Property t_stsc() As Int32
      Get
        Return _t_stsc
      End Get
      Set(ByVal value As Int32)
        _t_stsc = value
      End Set
    End Property
    Public Property t_stsd() As Int32
      Get
        Return _t_stsd
      End Get
      Set(ByVal value As Int32)
        _t_stsd = value
      End Set
    End Property
    Public Property t_vryn() As Int32
      Get
        Return _t_vryn
      End Get
      Set(ByVal value As Int32)
        _t_vryn = value
      End Set
    End Property
    Public Property t_invn() As String
      Get
        Return _t_invn
      End Get
      Set(ByVal value As String)
        _t_invn = value
      End Set
    End Property
    Public Property t_invd() As String
      Get
        If Not _t_invd = String.Empty Then
          Return Convert.ToDateTime(_t_invd).ToString("dd/MM/yyyy")
        End If
        Return _t_invd
      End Get
      Set(ByVal value As String)
         _t_invd = value
      End Set
    End Property
    Public Property t_copr_1() As Double
      Get
        Return _t_copr_1
      End Get
      Set(ByVal value As Double)
        _t_copr_1 = value
      End Set
    End Property
    Public Property t_copr_2() As Double
      Get
        Return _t_copr_2
      End Get
      Set(ByVal value As Double)
        _t_copr_2 = value
      End Set
    End Property
    Public Property t_copr_3() As Double
      Get
        Return _t_copr_3
      End Get
      Set(ByVal value As Double)
        _t_copr_3 = value
      End Set
    End Property
    Public Property t_coop_1() As Double
      Get
        Return _t_coop_1
      End Get
      Set(ByVal value As Double)
        _t_coop_1 = value
      End Set
    End Property
    Public Property t_coop_2() As Double
      Get
        Return _t_coop_2
      End Get
      Set(ByVal value As Double)
        _t_coop_2 = value
      End Set
    End Property
    Public Property t_coop_3() As Double
      Get
        Return _t_coop_3
      End Get
      Set(ByVal value As Double)
        _t_coop_3 = value
      End Set
    End Property
    Public Property t_cpcp() As String
      Get
        Return _t_cpcp
      End Get
      Set(ByVal value As String)
        _t_cpcp = value
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
    Public Property t_lsel() As Int32
      Get
        Return _t_lsel
      End Get
      Set(ByVal value As Int32)
        _t_lsel = value
      End Set
    End Property
    Public Property t_clot() As String
      Get
        Return _t_clot
      End Get
      Set(ByVal value As String)
        _t_clot = value
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
    Public Property t_cspa() As String
      Get
        Return _t_cspa
      End Get
      Set(ByVal value As String)
        _t_cspa = value
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
    Public Property t_cstl() As String
      Get
        Return _t_cstl
      End Get
      Set(ByVal value As String)
        _t_cstl = value
      End Set
    End Property
    Public Property t_ccco() As String
      Get
        Return _t_ccco
      End Get
      Set(ByVal value As String)
        _t_ccco = value
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
    Public Property t_akcd() As String
      Get
        Return _t_akcd
      End Get
      Set(ByVal value As String)
        _t_akcd = value
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
    Public Property t_crbn() As Int32
      Get
        Return _t_crbn
      End Get
      Set(ByVal value As Int32)
        _t_crbn = value
      End Set
    End Property
    Public Property t_clyn() As Int32
      Get
        Return _t_clyn
      End Get
      Set(ByVal value As Int32)
        _t_clyn = value
      End Set
    End Property
    Public Property t_cpva() As Int32
      Get
        Return _t_cpva
      End Get
      Set(ByVal value As Int32)
        _t_cpva = value
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
    Public Property t_cosn() As String
      Get
        Return _t_cosn
      End Get
      Set(ByVal value As String)
        _t_cosn = value
      End Set
    End Property
    Public Property t_qiiv() As Double
      Get
        Return _t_qiiv
      End Get
      Set(ByVal value As Double)
        _t_qiiv = value
      End Set
    End Property
    Public Property t_iamt() As Double
      Get
        Return _t_iamt
      End Get
      Set(ByVal value As Double)
        _t_iamt = value
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
    Public Property t_appr() As Int32
      Get
        Return _t_appr
      End Get
      Set(ByVal value As Int32)
        _t_appr = value
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
    Public Property t_cvat() As String
      Get
        Return _t_cvat
      End Get
      Set(ByVal value As String)
        _t_cvat = value
      End Set
    End Property
    Public Property t_bptc() As String
      Get
        Return _t_bptc
      End Get
      Set(ByVal value As String)
        _t_bptc = value
      End Set
    End Property
    Public Property t_exmt() As Int32
      Get
        Return _t_exmt
      End Get
      Set(ByVal value As Int32)
        _t_exmt = value
      End Set
    End Property
    Public Property t_ceno() As String
      Get
        Return _t_ceno
      End Get
      Set(ByVal value As String)
        _t_ceno = value
      End Set
    End Property
    Public Property t_rcod() As String
      Get
        Return _t_rcod
      End Get
      Set(ByVal value As String)
        _t_rcod = value
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
    Public Property t_taxp() As Int32
      Get
        Return _t_taxp
      End Get
      Set(ByVal value As Int32)
        _t_taxp = value
      End Set
    End Property
    Public Property t_gefo() As Int32
      Get
        Return _t_gefo
      End Get
      Set(ByVal value As Int32)
        _t_gefo = value
      End Set
    End Property
    Public Property t_ldat() As String
      Get
        If Not _t_ldat = String.Empty Then
          Return Convert.ToDateTime(_t_ldat).ToString("dd/MM/yyyy")
        End If
        Return _t_ldat
      End Get
      Set(ByVal value As String)
         _t_ldat = value
      End Set
    End Property
    Public Property t_serv() As String
      Get
        Return _t_serv
      End Get
      Set(ByVal value As String)
        _t_serv = value
      End Set
    End Property
    Public Property t_casi() As String
      Get
        Return _t_casi
      End Get
      Set(ByVal value As String)
        _t_casi = value
      End Set
    End Property
    Public Property t_ptpe() As String
      Get
        Return _t_ptpe
      End Get
      Set(ByVal value As String)
        _t_ptpe = value
      End Set
    End Property
    Public Property t_glco() As String
      Get
        Return _t_glco
      End Get
      Set(ByVal value As String)
        _t_glco = value
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
    Public Property t_cuva() As Double
      Get
        Return _t_cuva
      End Get
      Set(ByVal value As Double)
        _t_cuva = value
      End Set
    End Property
    Public Property t_cono() As String
      Get
        Return _t_cono
      End Get
      Set(ByVal value As String)
        _t_cono = value
      End Set
    End Property
    Public Property t_cpon() As Int32
      Get
        Return _t_cpon
      End Get
      Set(ByVal value As Int32)
        _t_cpon = value
      End Set
    End Property
    Public Property t_ccof() As String
      Get
        Return _t_ccof
      End Get
      Set(ByVal value As String)
        _t_ccof = value
      End Set
    End Property
    Public Property t_cnig() As Int32
      Get
        Return _t_cnig
      End Get
      Set(ByVal value As Int32)
        _t_cnig = value
      End Set
    End Property
    Public Property t_paya() As String
      Get
        Return _t_paya
      End Get
      Set(ByVal value As String)
        _t_paya = value
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
    Public Property t_pmnt() As Int32
      Get
        Return _t_pmnt
      End Get
      Set(ByVal value As Int32)
        _t_pmnt = value
      End Set
    End Property
    Public Property t_pmni() As Int32
      Get
        Return _t_pmni
      End Get
      Set(ByVal value As Int32)
        _t_pmni = value
      End Set
    End Property
    Public Property t_pmnd() As Int32
      Get
        Return _t_pmnd
      End Get
      Set(ByVal value As Int32)
        _t_pmnd = value
      End Set
    End Property
    Public Property t_owns() As Int32
      Get
        Return _t_owns
      End Get
      Set(ByVal value As Int32)
        _t_owns = value
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
    Public Property t_spcn() As String
      Get
        Return _t_spcn
      End Get
      Set(ByVal value As String)
        _t_spcn = value
      End Set
    End Property
    Public Property t_bgxc() As Int32
      Get
        Return _t_bgxc
      End Get
      Set(ByVal value As Int32)
        _t_bgxc = value
      End Set
    End Property
    Public Property t_cpcl() As String
      Get
        Return _t_cpcl
      End Get
      Set(ByVal value As String)
        _t_cpcl = value
      End Set
    End Property
    Public Property t_cpln() As String
      Get
        Return _t_cpln
      End Get
      Set(ByVal value As String)
        _t_cpln = value
      End Set
    End Property
    Public Property t_csgp() As String
      Get
        Return _t_csgp
      End Get
      Set(ByVal value As String)
        _t_csgp = value
      End Set
    End Property
    Public Property t_acti() As String
      Get
        Return _t_acti
      End Get
      Set(ByVal value As String)
        _t_acti = value
      End Set
    End Property
    Public Property t_pmsk() As String
      Get
        Return _t_pmsk
      End Get
      Set(ByVal value As String)
        _t_pmsk = value
      End Set
    End Property
    Public Property t_rnso_l() As Int32
      Get
        Return _t_rnso_l
      End Get
      Set(ByVal value As Int32)
        _t_rnso_l = value
      End Set
    End Property
    Public Property t_rnsb_l() As Int32
      Get
        Return _t_rnsb_l
      End Get
      Set(ByVal value As Int32)
        _t_rnsb_l = value
      End Set
    End Property
    Public Property t_ecif_l() As Double
      Get
        Return _t_ecif_l
      End Get
      Set(ByVal value As Double)
        _t_ecif_l = value
      End Set
    End Property
    Public Property t_assv_l() As Double
      Get
        Return _t_assv_l
      End Get
      Set(ByVal value As Double)
        _t_assv_l = value
      End Set
    End Property
    Public Property t_elco_l() As Double
      Get
        Return _t_elco_l
      End Get
      Set(ByVal value As Double)
        _t_elco_l = value
      End Set
    End Property
    Public Property t_ihsn_l() As String
      Get
        Return _t_ihsn_l
      End Get
      Set(ByVal value As String)
        _t_ihsn_l = value
      End Set
    End Property
    Public Property t_mrpo_l() As Int32
      Get
        Return _t_mrpo_l
      End Get
      Set(ByVal value As Int32)
        _t_mrpo_l = value
      End Set
    End Property
    Public Property t_iexb_l() As Int32
      Get
        Return _t_iexb_l
      End Get
      Set(ByVal value As Int32)
        _t_iexb_l = value
      End Set
    End Property
    Public Property t_icen_l() As Int32
      Get
        Return _t_icen_l
      End Get
      Set(ByVal value As Int32)
        _t_icen_l = value
      End Set
    End Property
    Public Property t_imca_l() As Int32
      Get
        Return _t_imca_l
      End Get
      Set(ByVal value As Int32)
        _t_imca_l = value
      End Set
    End Property
    Public Property t_exca_l() As Int32
      Get
        Return _t_exca_l
      End Get
      Set(ByVal value As Int32)
        _t_exca_l = value
      End Set
    End Property
    Public Property t_mrpe_l() As Int32
      Get
        Return _t_mrpe_l
      End Get
      Set(ByVal value As Int32)
        _t_mrpe_l = value
      End Set
    End Property
    Public Property t_hcod_l() As String
      Get
        Return _t_hcod_l
      End Get
      Set(ByVal value As String)
        _t_hcod_l = value
      End Set
    End Property
    Public Property t_cenv_l() As Int32
      Get
        Return _t_cenv_l
      End Get
      Set(ByVal value As Int32)
        _t_cenv_l = value
      End Set
    End Property
    Public Property t_icat_l() As Int32
      Get
        Return _t_icat_l
      End Get
      Set(ByVal value As Int32)
        _t_icat_l = value
      End Set
    End Property
    Public Property t_asoe_l() As Int32
      Get
        Return _t_asoe_l
      End Get
      Set(ByVal value As Int32)
        _t_asoe_l = value
      End Set
    End Property
    Public Property t_asve_l() As Double
      Get
        Return _t_asve_l
      End Get
      Set(ByVal value As Double)
        _t_asve_l = value
      End Set
    End Property
    Public Property t_dise_l() As Single
      Get
        Return _t_dise_l
      End Get
      Set(ByVal value As Single)
        _t_dise_l = value
      End Set
    End Property
    Public Property t_fase_l() As Double
      Get
        Return _t_fase_l
      End Get
      Set(ByVal value As Double)
        _t_fase_l = value
      End Set
    End Property
    Public Property t_asov_l() As Int32
      Get
        Return _t_asov_l
      End Get
      Set(ByVal value As Int32)
        _t_asov_l = value
      End Set
    End Property
    Public Property t_asvv_l() As Double
      Get
        Return _t_asvv_l
      End Get
      Set(ByVal value As Double)
        _t_asvv_l = value
      End Set
    End Property
    Public Property t_disv_l() As Single
      Get
        Return _t_disv_l
      End Get
      Set(ByVal value As Single)
        _t_disv_l = value
      End Set
    End Property
    Public Property t_fasv_l() As Double
      Get
        Return _t_fasv_l
      End Get
      Set(ByVal value As Double)
        _t_fasv_l = value
      End Set
    End Property
    Public Property t_asos_l() As Int32
      Get
        Return _t_asos_l
      End Get
      Set(ByVal value As Int32)
        _t_asos_l = value
      End Set
    End Property
    Public Property t_asvs_l() As Double
      Get
        Return _t_asvs_l
      End Get
      Set(ByVal value As Double)
        _t_asvs_l = value
      End Set
    End Property
    Public Property t_diss_l() As Single
      Get
        Return _t_diss_l
      End Get
      Set(ByVal value As Single)
        _t_diss_l = value
      End Set
    End Property
    Public Property t_fass_l() As Double
      Get
        Return _t_fass_l
      End Get
      Set(ByVal value As Double)
        _t_fass_l = value
      End Set
    End Property
    Public Property t_iecc_l() As Int32
      Get
        Return _t_iecc_l
      End Get
      Set(ByVal value As Int32)
        _t_iecc_l = value
      End Set
    End Property
    Public Property t_mrpv_l() As Int32
      Get
        Return _t_mrpv_l
      End Get
      Set(ByVal value As Int32)
        _t_mrpv_l = value
      End Set
    End Property
    Public Property t_mrps_l() As Int32
      Get
        Return _t_mrps_l
      End Get
      Set(ByVal value As Int32)
        _t_mrps_l = value
      End Set
    End Property
    Public Property t_reno_l() As String
      Get
        Return _t_reno_l
      End Get
      Set(ByVal value As String)
        _t_reno_l = value
      End Set
    End Property
    Public Property t_rcln_l() As Int32
      Get
        Return _t_rcln_l
      End Get
      Set(ByVal value As Int32)
        _t_rcln_l = value
      End Set
    End Property
    Public Property t_mrpi_l() As Double
      Get
        Return _t_mrpi_l
      End Get
      Set(ByVal value As Double)
        _t_mrpi_l = value
      End Set
    End Property
    Public Property t_ocim_l() As Double
      Get
        Return _t_ocim_l
      End Get
      Set(ByVal value As Double)
        _t_ocim_l = value
      End Set
    End Property
    Public Property t_ocio_l() As Double
      Get
        Return _t_ocio_l
      End Get
      Set(ByVal value As Double)
        _t_ocio_l = value
      End Set
    End Property
    Public Property t_extx_l() As Double
      Get
        Return _t_extx_l
      End Get
      Set(ByVal value As Double)
        _t_extx_l = value
      End Set
    End Property
    Public Property t_cltx_l() As Double
      Get
        Return _t_cltx_l
      End Get
      Set(ByVal value As Double)
        _t_cltx_l = value
      End Set
    End Property
    Public Property t_lacm_l() As Double
      Get
        Return _t_lacm_l
      End Get
      Set(ByVal value As Double)
        _t_lacm_l = value
      End Set
    End Property
    Public Property t_tase_l() As Double
      Get
        Return _t_tase_l
      End Get
      Set(ByVal value As Double)
        _t_tase_l = value
      End Set
    End Property
    Public Property t_tasv_l() As Double
      Get
        Return _t_tasv_l
      End Get
      Set(ByVal value As Double)
        _t_tasv_l = value
      End Set
    End Property
    Public Property t_tass_l() As Double
      Get
        Return _t_tass_l
      End Get
      Set(ByVal value As Double)
        _t_tass_l = value
      End Set
    End Property
    Public Property t_uiac_l() As Int32
      Get
        Return _t_uiac_l
      End Get
      Set(ByVal value As Int32)
        _t_uiac_l = value
      End Set
    End Property
    Public Property t_uaig_l() As Int32
      Get
        Return _t_uaig_l
      End Get
      Set(ByVal value As Int32)
        _t_uaig_l = value
      End Set
    End Property
    Public Property t_txin_l() As Int32
      Get
        Return _t_txin_l
      End Get
      Set(ByVal value As Int32)
        _t_txin_l = value
      End Set
    End Property
    Public Property t_gsub_l() As Int32
      Get
        Return _t_gsub_l
      End Get
      Set(ByVal value As Int32)
        _t_gsub_l = value
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
    Public Property t_btx1() As Int32
      Get
        Return _t_btx1
      End Get
      Set(ByVal value As Int32)
        _t_btx1 = value
      End Set
    End Property
    Public Property t_btx2() As Int32
      Get
        Return _t_btx2
      End Get
      Set(ByVal value As Int32)
        _t_btx2 = value
      End Set
    End Property
    Public Property t_cdf_ldat() As String
      Get
        If Not _t_cdf_ldat = String.Empty Then
          Return Convert.ToDateTime(_t_cdf_ldat).ToString("dd/MM/yyyy")
        End If
        Return _t_cdf_ldat
      End Get
      Set(ByVal value As String)
         _t_cdf_ldat = value
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
    Public Property t_asog_l() As Int32
      Get
        Return _t_asog_l
      End Get
      Set(ByVal value As Int32)
        _t_asog_l = value
      End Set
    End Property
    Public Property t_asoi_l() As Int32
      Get
        Return _t_asoi_l
      End Get
      Set(ByVal value As Int32)
        _t_asoi_l = value
      End Set
    End Property
    Public Property t_asvg_l() As Double
      Get
        Return _t_asvg_l
      End Get
      Set(ByVal value As Double)
        _t_asvg_l = value
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
    Public Property t_gsta_l() As Int32
      Get
        Return _t_gsta_l
      End Get
      Set(ByVal value As Int32)
        _t_gsta_l = value
      End Set
    End Property
    Public Property t_tasg_l() As Double
      Get
        Return _t_tasg_l
      End Get
      Set(ByVal value As Double)
        _t_tasg_l = value
      End Set
    End Property
    Public Readonly Property DisplayField() As String
      Get
        Return "" & _t_item.ToString.PadRight(47, " ")
      End Get
    End Property
    Public Readonly Property PrimaryKey() As String
      Get
        Return _t_orno & "|" & _t_pono & "|" & _t_sqnb
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
    Public Class PKtdpur401
      Private _t_orno As String = ""
      Private _t_pono As Int32 = 0
      Private _t_sqnb As Int32 = 0
      Public Property t_orno() As String
        Get
          Return _t_orno
        End Get
        Set(ByVal value As String)
          _t_orno = value
        End Set
      End Property
      Public Property t_pono() As Int32
        Get
          Return _t_pono
        End Get
        Set(ByVal value As Int32)
          _t_pono = value
        End Set
      End Property
      Public Property t_sqnb() As Int32
        Get
          Return _t_sqnb
        End Get
        Set(ByVal value As Int32)
          _t_sqnb = value
        End Set
      End Property
    End Class
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function tdpur401SelectList(ByVal OrderBy As String) As List(Of SIS.TDPUR.tdpur401)
      Dim Results As List(Of SIS.TDPUR.tdpur401) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sptdpur401SelectList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.TDPUR.tdpur401)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.TDPUR.tdpur401(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function tdpur401GetNewRecord() As SIS.TDPUR.tdpur401
      Return New SIS.TDPUR.tdpur401()
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function tdpur401GetByID(ByVal t_orno As String, ByVal t_pono As Int32, ByVal t_sqnb As Int32) As SIS.TDPUR.tdpur401
      Dim Results As SIS.TDPUR.tdpur401 = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sptdpur401SelectByID"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_orno",SqlDbType.VarChar,t_orno.ToString.Length, t_orno)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_pono",SqlDbType.Int,t_pono.ToString.Length, t_pono)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@t_sqnb",SqlDbType.Int,t_sqnb.ToString.Length, t_sqnb)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.TDPUR.tdpur401(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    <DataObjectMethod(DataObjectMethodType.Select)> _
    Public Shared Function tdpur401SelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.TDPUR.tdpur401)
      Dim Results As List(Of SIS.TDPUR.tdpur401) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "sptdpur401SelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "sptdpur401SelectListFilteres"
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.TDPUR.tdpur401)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.TDPUR.tdpur401(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function tdpur401SelectCount(ByVal SearchState As Boolean, ByVal SearchText As String) As Integer
      Return _RecordCount
    End Function
      'Select By ID One Record Filtered Overloaded GetByID
'    Autocomplete Method
    Public Shared Function Selecttdpur401AutoCompleteList(ByVal Prefix As String, ByVal count As Integer, ByVal contextKey As String) As String()
      Dim Results As List(Of String) = Nothing
      Dim aVal() As String = contextKey.Split("|".ToCharArray)
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "sptdpur401AutoCompleteList"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@DF_t_orno",SqlDbType.VarChar,9, aVal(0))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NvarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@prefix", SqlDbType.NVarChar, 50, Prefix)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@records", SqlDbType.Int, -1, count)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@bycode", SqlDbType.Int, 1, IIf(IsNumeric(Prefix),0,IIf(Prefix.ToLower=Prefix, 0, 1)))
          Results = New List(Of String)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Not Reader.HasRows Then
            Results.Add(AjaxControlToolkit.AutoCompleteExtender.CreateAutoCompleteItem("---Select Value---".PadRight(47, " "),"" & "|" & "" & "|" & ""))
          End If
          While (Reader.Read())
            Dim Tmp As SIS.TDPUR.tdpur401 = New SIS.TDPUR.tdpur401(Reader)
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
