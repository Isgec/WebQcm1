Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.TDPUR
  Partial Public Class tdpur401
    Public Function GetColor() As System.Drawing.Color
      Dim mRet As System.Drawing.Color = Drawing.Color.Blue
      Return mRet
    End Function
    Public Function GetVisible() As Boolean
      Dim mRet As Boolean = True
      Return mRet
    End Function
    Public Function GetEnable() As Boolean
      Dim mRet As Boolean = True
      Return mRet
    End Function
    Public Function GetEditable() As Boolean
      Dim mRet As Boolean = True
      Return mRet
    End Function
    Public Function GetDeleteable() As Boolean
      Dim mRet As Boolean = True
      Return mRet
    End Function
    Public ReadOnly Property Editable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetEditable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public ReadOnly Property Deleteable() As Boolean
      Get
        Dim mRet As Boolean = True
        Try
          mRet = GetDeleteable()
        Catch ex As Exception
        End Try
        Return mRet
      End Get
    End Property
    Public Shared Function UZ_tdpur401SelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.TDPUR.tdpur401)
      Dim Results As List(Of SIS.TDPUR.tdpur401) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "sptdpur_LG_401SelectListSearch"
            Cmd.CommandText = "sptdpur401SelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "sptdpur_LG_401SelectListFilteres"
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
    Public Shared Function SetDefaultValues(ByVal sender As System.Web.UI.WebControls.FormView, ByVal e As System.EventArgs) As System.Web.UI.WebControls.FormView
      With sender
        Try
        CType(.FindControl("F_t_orno"), TextBox).Text = ""
        CType(.FindControl("F_t_pono"), TextBox).Text = 0
        CType(.FindControl("F_t_sqnb"), TextBox).Text = 0
        CType(.FindControl("F_t_corg"), TextBox).Text = 0
        CType(.FindControl("F_t_oltp"), TextBox).Text = 0
        CType(.FindControl("F_t_otbp"), TextBox).Text = ""
        CType(.FindControl("F_t_sfbp"), TextBox).Text = ""
        CType(.FindControl("F_t_sfad"), TextBox).Text = ""
        CType(.FindControl("F_t_sfcn"), TextBox).Text = ""
        CType(.FindControl("F_t_sfwh"), TextBox).Text = ""
        CType(.FindControl("F_t_item"), TextBox).Text = ""
        CType(.FindControl("F_t_effn"), TextBox).Text = 0
        CType(.FindControl("F_t_sdsc"), TextBox).Text = 0
        CType(.FindControl("F_t_crrf"), TextBox).Text = 0
        CType(.FindControl("F_t_citt"), TextBox).Text = ""
        CType(.FindControl("F_t_crit"), TextBox).Text = ""
        CType(.FindControl("F_t_mpnr"), TextBox).Text = ""
        CType(.FindControl("F_t_subc"), TextBox).Text = 0
        CType(.FindControl("F_t_mpsn"), TextBox).Text = ""
        CType(.FindControl("F_t_cmnf"), TextBox).Text = ""
        CType(.FindControl("F_t_mitm"), TextBox).Text = ""
        CType(.FindControl("F_t_revi"), TextBox).Text = ""
        CType(.FindControl("F_t_btsp"), TextBox).Text = 0
        CType(.FindControl("F_t_qual"), TextBox).Text = 0
        CType(.FindControl("F_t_qoor"), TextBox).Text = 0
        CType(.FindControl("F_t_cuqp"), TextBox).Text = ""
        CType(.FindControl("F_t_cvqp"), TextBox).Text = 0
        CType(.FindControl("F_t_leng"), TextBox).Text = 0
        CType(.FindControl("F_t_widt"), TextBox).Text = 0
        CType(.FindControl("F_t_thic"), TextBox).Text = 0
        CType(.FindControl("F_t_odat"), TextBox).Text = ""
        CType(.FindControl("F_t_ddta"), TextBox).Text = ""
        CType(.FindControl("F_t_ddtb"), TextBox).Text = ""
        CType(.FindControl("F_t_ddtc"), TextBox).Text = ""
        CType(.FindControl("F_t_ddtd"), TextBox).Text = ""
        CType(.FindControl("F_t_ddte"), TextBox).Text = ""
        CType(.FindControl("F_t_ddtf"), TextBox).Text = ""
        CType(.FindControl("F_t_rdta"), TextBox).Text = ""
        CType(.FindControl("F_t_pric"), TextBox).Text = 0
        CType(.FindControl("F_t_porg"), TextBox).Text = 0
        CType(.FindControl("F_t_pmde"), TextBox).Text = ""
        CType(.FindControl("F_t_pmse"), TextBox).Text = 0
        CType(.FindControl("F_t_cupp"), TextBox).Text = ""
        CType(.FindControl("F_t_cvpp"), TextBox).Text = 0
        CType(.FindControl("F_t_disc_1"), TextBox).Text = 0
        CType(.FindControl("F_t_disc_2"), TextBox).Text = 0
        CType(.FindControl("F_t_disc_3"), TextBox).Text = 0
        CType(.FindControl("F_t_disc_4"), TextBox).Text = 0
        CType(.FindControl("F_t_disc_5"), TextBox).Text = 0
        CType(.FindControl("F_t_disc_6"), TextBox).Text = 0
        CType(.FindControl("F_t_disc_7"), TextBox).Text = 0
        CType(.FindControl("F_t_disc_8"), TextBox).Text = 0
        CType(.FindControl("F_t_disc_9"), TextBox).Text = 0
        CType(.FindControl("F_t_disc_10"), TextBox).Text = 0
        CType(.FindControl("F_t_disc_11"), TextBox).Text = 0
        CType(.FindControl("F_t_ldam_1"), TextBox).Text = 0
        CType(.FindControl("F_t_ldam_2"), TextBox).Text = 0
        CType(.FindControl("F_t_ldam_3"), TextBox).Text = 0
        CType(.FindControl("F_t_ldam_4"), TextBox).Text = 0
        CType(.FindControl("F_t_ldam_5"), TextBox).Text = 0
        CType(.FindControl("F_t_ldam_6"), TextBox).Text = 0
        CType(.FindControl("F_t_ldam_7"), TextBox).Text = 0
        CType(.FindControl("F_t_ldam_8"), TextBox).Text = 0
        CType(.FindControl("F_t_ldam_9"), TextBox).Text = 0
        CType(.FindControl("F_t_ldam_10"), TextBox).Text = 0
        CType(.FindControl("F_t_ldam_11"), TextBox).Text = 0
        CType(.FindControl("F_t_dorg_1"), TextBox).Text = 0
        CType(.FindControl("F_t_dorg_2"), TextBox).Text = 0
        CType(.FindControl("F_t_dorg_3"), TextBox).Text = 0
        CType(.FindControl("F_t_dorg_4"), TextBox).Text = 0
        CType(.FindControl("F_t_dorg_5"), TextBox).Text = 0
        CType(.FindControl("F_t_dorg_6"), TextBox).Text = 0
        CType(.FindControl("F_t_dorg_7"), TextBox).Text = 0
        CType(.FindControl("F_t_dorg_8"), TextBox).Text = 0
        CType(.FindControl("F_t_dorg_9"), TextBox).Text = 0
        CType(.FindControl("F_t_dorg_10"), TextBox).Text = 0
        CType(.FindControl("F_t_dorg_11"), TextBox).Text = 0
        CType(.FindControl("F_t_dmty_1"), TextBox).Text = 0
        CType(.FindControl("F_t_dmty_2"), TextBox).Text = 0
        CType(.FindControl("F_t_dmty_3"), TextBox).Text = 0
        CType(.FindControl("F_t_dmty_4"), TextBox).Text = 0
        CType(.FindControl("F_t_dmty_5"), TextBox).Text = 0
        CType(.FindControl("F_t_dmty_6"), TextBox).Text = 0
        CType(.FindControl("F_t_dmty_7"), TextBox).Text = 0
        CType(.FindControl("F_t_dmty_8"), TextBox).Text = 0
        CType(.FindControl("F_t_dmty_9"), TextBox).Text = 0
        CType(.FindControl("F_t_dmty_10"), TextBox).Text = 0
        CType(.FindControl("F_t_dmty_11"), TextBox).Text = 0
        CType(.FindControl("F_t_dmde_1"), TextBox).Text = ""
        CType(.FindControl("F_t_dmde_2"), TextBox).Text = ""
        CType(.FindControl("F_t_dmde_3"), TextBox).Text = ""
        CType(.FindControl("F_t_dmde_4"), TextBox).Text = ""
        CType(.FindControl("F_t_dmde_5"), TextBox).Text = ""
        CType(.FindControl("F_t_dmde_6"), TextBox).Text = ""
        CType(.FindControl("F_t_dmde_7"), TextBox).Text = ""
        CType(.FindControl("F_t_dmde_8"), TextBox).Text = ""
        CType(.FindControl("F_t_dmde_9"), TextBox).Text = ""
        CType(.FindControl("F_t_dmde_10"), TextBox).Text = ""
        CType(.FindControl("F_t_dmde_11"), TextBox).Text = ""
        CType(.FindControl("F_t_dmse_1"), TextBox).Text = 0
        CType(.FindControl("F_t_dmse_2"), TextBox).Text = 0
        CType(.FindControl("F_t_dmse_3"), TextBox).Text = 0
        CType(.FindControl("F_t_dmse_4"), TextBox).Text = 0
        CType(.FindControl("F_t_dmse_5"), TextBox).Text = 0
        CType(.FindControl("F_t_dmse_6"), TextBox).Text = 0
        CType(.FindControl("F_t_dmse_7"), TextBox).Text = 0
        CType(.FindControl("F_t_dmse_8"), TextBox).Text = 0
        CType(.FindControl("F_t_dmse_9"), TextBox).Text = 0
        CType(.FindControl("F_t_dmse_10"), TextBox).Text = 0
        CType(.FindControl("F_t_dmse_11"), TextBox).Text = 0
        CType(.FindControl("F_t_dmth_1"), TextBox).Text = 0
        CType(.FindControl("F_t_dmth_2"), TextBox).Text = 0
        CType(.FindControl("F_t_dmth_3"), TextBox).Text = 0
        CType(.FindControl("F_t_dmth_4"), TextBox).Text = 0
        CType(.FindControl("F_t_dmth_5"), TextBox).Text = 0
        CType(.FindControl("F_t_dmth_6"), TextBox).Text = 0
        CType(.FindControl("F_t_dmth_7"), TextBox).Text = 0
        CType(.FindControl("F_t_dmth_8"), TextBox).Text = 0
        CType(.FindControl("F_t_dmth_9"), TextBox).Text = 0
        CType(.FindControl("F_t_dmth_10"), TextBox).Text = 0
        CType(.FindControl("F_t_dmth_11"), TextBox).Text = 0
        CType(.FindControl("F_t_cdis_1"), TextBox).Text = ""
        CType(.FindControl("F_t_cdis_2"), TextBox).Text = ""
        CType(.FindControl("F_t_cdis_3"), TextBox).Text = ""
        CType(.FindControl("F_t_cdis_4"), TextBox).Text = ""
        CType(.FindControl("F_t_cdis_5"), TextBox).Text = ""
        CType(.FindControl("F_t_cdis_6"), TextBox).Text = ""
        CType(.FindControl("F_t_cdis_7"), TextBox).Text = ""
        CType(.FindControl("F_t_cdis_8"), TextBox).Text = ""
        CType(.FindControl("F_t_cdis_9"), TextBox).Text = ""
        CType(.FindControl("F_t_cdis_10"), TextBox).Text = ""
        CType(.FindControl("F_t_cdis_11"), TextBox).Text = ""
        CType(.FindControl("F_t_dtrm"), TextBox).Text = 0
        CType(.FindControl("F_t_elgb"), TextBox).Text = 0
        CType(.FindControl("F_t_stdc"), TextBox).Text = 0
        CType(.FindControl("F_t_oamt"), TextBox).Text = 0
        CType(.FindControl("F_t_rcno"), TextBox).Text = ""
        CType(.FindControl("F_t_rseq"), TextBox).Text = 0
        CType(.FindControl("F_t_dino"), TextBox).Text = ""
        CType(.FindControl("F_t_qips"), TextBox).Text = 0
        CType(.FindControl("F_t_qidl"), TextBox).Text = 0
        CType(.FindControl("F_t_qiap"), TextBox).Text = 0
        CType(.FindControl("F_t_crej"), TextBox).Text = ""
        CType(.FindControl("F_t_qirj"), TextBox).Text = 0
        CType(.FindControl("F_t_qibo"), TextBox).Text = 0
        CType(.FindControl("F_t_qbbc"), TextBox).Text = 0
        CType(.FindControl("F_t_cubp"), TextBox).Text = ""
        CType(.FindControl("F_t_cvbp"), TextBox).Text = 0
        CType(.FindControl("F_t_fire"), TextBox).Text = 0
        CType(.FindControl("F_t_qibp"), TextBox).Text = 0
        CType(.FindControl("F_t_ddon"), TextBox).Text = 0
        CType(.FindControl("F_t_lseq"), TextBox).Text = 0
        CType(.FindControl("F_t_pseq"), TextBox).Text = 0
        CType(.FindControl("F_t_amld"), TextBox).Text = 0
        CType(.FindControl("F_t_amod"), TextBox).Text = 0
        CType(.FindControl("F_t_damt"), TextBox).Text = 0
        CType(.FindControl("F_t_stsc"), TextBox).Text = 0
        CType(.FindControl("F_t_stsd"), TextBox).Text = 0
        CType(.FindControl("F_t_vryn"), TextBox).Text = 0
        CType(.FindControl("F_t_invn"), TextBox).Text = ""
        CType(.FindControl("F_t_invd"), TextBox).Text = ""
        CType(.FindControl("F_t_copr_1"), TextBox).Text = 0
        CType(.FindControl("F_t_copr_2"), TextBox).Text = 0
        CType(.FindControl("F_t_copr_3"), TextBox).Text = 0
        CType(.FindControl("F_t_coop_1"), TextBox).Text = 0
        CType(.FindControl("F_t_coop_2"), TextBox).Text = 0
        CType(.FindControl("F_t_coop_3"), TextBox).Text = 0
        CType(.FindControl("F_t_cpcp"), TextBox).Text = ""
        CType(.FindControl("F_t_cwar"), TextBox).Text = ""
        CType(.FindControl("F_t_cadr"), TextBox).Text = ""
        CType(.FindControl("F_t_lsel"), TextBox).Text = 0
        CType(.FindControl("F_t_clot"), TextBox).Text = ""
        CType(.FindControl("F_t_cprj"), TextBox).Text = ""
        CType(.FindControl("F_t_cspa"), TextBox).Text = ""
        CType(.FindControl("F_t_cact"), TextBox).Text = ""
        CType(.FindControl("F_t_cstl"), TextBox).Text = ""
        CType(.FindControl("F_t_ccco"), TextBox).Text = ""
        CType(.FindControl("F_t_ctrj"), TextBox).Text = ""
        CType(.FindControl("F_t_akcd"), TextBox).Text = ""
        CType(.FindControl("F_t_cfrw"), TextBox).Text = ""
        CType(.FindControl("F_t_crbn"), TextBox).Text = 0
        CType(.FindControl("F_t_clyn"), TextBox).Text = 0
        CType(.FindControl("F_t_cpva"), TextBox).Text = 0
        CType(.FindControl("F_t_crcd"), TextBox).Text = ""
        CType(.FindControl("F_t_ctcd"), TextBox).Text = ""
        CType(.FindControl("F_t_cosn"), TextBox).Text = ""
        CType(.FindControl("F_t_qiiv"), TextBox).Text = 0
        CType(.FindControl("F_t_iamt"), TextBox).Text = 0
        CType(.FindControl("F_t_comm"), TextBox).Text = 0
        CType(.FindControl("F_t_appr"), TextBox).Text = 0
        CType(.FindControl("F_t_ccty"), TextBox).Text = ""
        CType(.FindControl("F_t_cvat"), TextBox).Text = ""
        CType(.FindControl("F_t_bptc"), TextBox).Text = ""
        CType(.FindControl("F_t_exmt"), TextBox).Text = 0
        CType(.FindControl("F_t_ceno"), TextBox).Text = ""
        CType(.FindControl("F_t_rcod"), TextBox).Text = ""
        CType(.FindControl("F_t_bpcl"), TextBox).Text = ""
        CType(.FindControl("F_t_taxp"), TextBox).Text = 0
        CType(.FindControl("F_t_gefo"), TextBox).Text = 0
        CType(.FindControl("F_t_ldat"), TextBox).Text = ""
        CType(.FindControl("F_t_serv"), TextBox).Text = ""
        CType(.FindControl("F_t_casi"), TextBox).Text = ""
        CType(.FindControl("F_t_ptpe"), TextBox).Text = ""
        CType(.FindControl("F_t_glco"), TextBox).Text = ""
        CType(.FindControl("F_t_sbim"), TextBox).Text = 0
        CType(.FindControl("F_t_paft"), TextBox).Text = 0
        CType(.FindControl("F_t_sbmt"), TextBox).Text = ""
        CType(.FindControl("F_t_cuva"), TextBox).Text = 0
        CType(.FindControl("F_t_cono"), TextBox).Text = ""
        CType(.FindControl("F_t_cpon"), TextBox).Text = 0
        CType(.FindControl("F_t_ccof"), TextBox).Text = ""
        CType(.FindControl("F_t_cnig"), TextBox).Text = 0
        CType(.FindControl("F_t_paya"), TextBox).Text = ""
        CType(.FindControl("F_t_cpay"), TextBox).Text = ""
        CType(.FindControl("F_t_cdec"), TextBox).Text = ""
        CType(.FindControl("F_t_ptpa"), TextBox).Text = ""
        CType(.FindControl("F_t_pmnt"), TextBox).Text = 0
        CType(.FindControl("F_t_pmni"), TextBox).Text = 0
        CType(.FindControl("F_t_pmnd"), TextBox).Text = 0
        CType(.FindControl("F_t_owns"), TextBox).Text = 0
        CType(.FindControl("F_t_lccl"), TextBox).Text = ""
        CType(.FindControl("F_t_spcn"), TextBox).Text = ""
        CType(.FindControl("F_t_bgxc"), TextBox).Text = 0
        CType(.FindControl("F_t_cpcl"), TextBox).Text = ""
        CType(.FindControl("F_t_cpln"), TextBox).Text = ""
        CType(.FindControl("F_t_csgp"), TextBox).Text = ""
        CType(.FindControl("F_t_acti"), TextBox).Text = ""
        CType(.FindControl("F_t_pmsk"), TextBox).Text = ""
        CType(.FindControl("F_t_rnso_l"), TextBox).Text = 0
        CType(.FindControl("F_t_rnsb_l"), TextBox).Text = 0
        CType(.FindControl("F_t_ecif_l"), TextBox).Text = 0
        CType(.FindControl("F_t_assv_l"), TextBox).Text = 0
        CType(.FindControl("F_t_elco_l"), TextBox).Text = 0
        CType(.FindControl("F_t_ihsn_l"), TextBox).Text = ""
        CType(.FindControl("F_t_mrpo_l"), TextBox).Text = 0
        CType(.FindControl("F_t_iexb_l"), TextBox).Text = 0
        CType(.FindControl("F_t_icen_l"), TextBox).Text = 0
        CType(.FindControl("F_t_imca_l"), TextBox).Text = 0
        CType(.FindControl("F_t_exca_l"), TextBox).Text = 0
        CType(.FindControl("F_t_mrpe_l"), TextBox).Text = 0
        CType(.FindControl("F_t_hcod_l"), TextBox).Text = ""
        CType(.FindControl("F_t_cenv_l"), TextBox).Text = 0
        CType(.FindControl("F_t_icat_l"), TextBox).Text = 0
        CType(.FindControl("F_t_asoe_l"), TextBox).Text = 0
        CType(.FindControl("F_t_asve_l"), TextBox).Text = 0
        CType(.FindControl("F_t_dise_l"), TextBox).Text = 0
        CType(.FindControl("F_t_fase_l"), TextBox).Text = 0
        CType(.FindControl("F_t_asov_l"), TextBox).Text = 0
        CType(.FindControl("F_t_asvv_l"), TextBox).Text = 0
        CType(.FindControl("F_t_disv_l"), TextBox).Text = 0
        CType(.FindControl("F_t_fasv_l"), TextBox).Text = 0
        CType(.FindControl("F_t_asos_l"), TextBox).Text = 0
        CType(.FindControl("F_t_asvs_l"), TextBox).Text = 0
        CType(.FindControl("F_t_diss_l"), TextBox).Text = 0
        CType(.FindControl("F_t_fass_l"), TextBox).Text = 0
        CType(.FindControl("F_t_iecc_l"), TextBox).Text = 0
        CType(.FindControl("F_t_mrpv_l"), TextBox).Text = 0
        CType(.FindControl("F_t_mrps_l"), TextBox).Text = 0
        CType(.FindControl("F_t_reno_l"), TextBox).Text = ""
        CType(.FindControl("F_t_rcln_l"), TextBox).Text = 0
        CType(.FindControl("F_t_mrpi_l"), TextBox).Text = 0
        CType(.FindControl("F_t_ocim_l"), TextBox).Text = 0
        CType(.FindControl("F_t_ocio_l"), TextBox).Text = 0
        CType(.FindControl("F_t_extx_l"), TextBox).Text = 0
        CType(.FindControl("F_t_cltx_l"), TextBox).Text = 0
        CType(.FindControl("F_t_lacm_l"), TextBox).Text = 0
        CType(.FindControl("F_t_tase_l"), TextBox).Text = 0
        CType(.FindControl("F_t_tasv_l"), TextBox).Text = 0
        CType(.FindControl("F_t_tass_l"), TextBox).Text = 0
        CType(.FindControl("F_t_uiac_l"), TextBox).Text = 0
        CType(.FindControl("F_t_uaig_l"), TextBox).Text = 0
        CType(.FindControl("F_t_txin_l"), TextBox).Text = 0
        CType(.FindControl("F_t_gsub_l"), TextBox).Text = 0
        CType(.FindControl("F_t_txta"), TextBox).Text = 0
        CType(.FindControl("F_t_btx1"), TextBox).Text = 0
        CType(.FindControl("F_t_btx2"), TextBox).Text = 0
        CType(.FindControl("F_t_cdf_ldat"), TextBox).Text = ""
        CType(.FindControl("F_t_Refcntd"), TextBox).Text = 0
        CType(.FindControl("F_t_Refcntu"), TextBox).Text = 0
        CType(.FindControl("F_t_asog_l"), TextBox).Text = 0
        CType(.FindControl("F_t_asoi_l"), TextBox).Text = 0
        CType(.FindControl("F_t_asvg_l"), TextBox).Text = 0
        CType(.FindControl("F_t_atfr_l"), TextBox).Text = 0
        CType(.FindControl("F_t_gsta_l"), TextBox).Text = 0
        CType(.FindControl("F_t_tasg_l"), TextBox).Text = 0
        Catch ex As Exception
        End Try
      End With
      Return sender
    End Function
  End Class
End Namespace
