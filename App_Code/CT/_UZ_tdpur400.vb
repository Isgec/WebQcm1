Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.TDPUR
  Partial Public Class tdpur400
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
    Public Shared Function UZ_tdpur400SelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.TDPUR.tdpur400)
      Dim Results As List(Of SIS.TDPUR.tdpur400) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "sptdpur_LG_400SelectListSearch"
            Cmd.CommandText = "sptdpur400SelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "sptdpur_LG_400SelectListFilteres"
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
    Public Shared Function SetDefaultValues(ByVal sender As System.Web.UI.WebControls.FormView, ByVal e As System.EventArgs) As System.Web.UI.WebControls.FormView
      With sender
        Try
        CType(.FindControl("F_t_orno"), TextBox).Text = ""
        CType(.FindControl("F_t_otbp"), TextBox).Text = ""
        CType(.FindControl("F_t_otad"), TextBox).Text = ""
        CType(.FindControl("F_t_otcn"), TextBox).Text = ""
        CType(.FindControl("F_t_sfbp"), TextBox).Text = ""
        CType(.FindControl("F_t_sfad"), TextBox).Text = ""
        CType(.FindControl("F_t_sfcn"), TextBox).Text = ""
        CType(.FindControl("F_t_ifbp"), TextBox).Text = ""
        CType(.FindControl("F_t_ifad"), TextBox).Text = ""
        CType(.FindControl("F_t_ifcn"), TextBox).Text = ""
        CType(.FindControl("F_t_ptbp"), TextBox).Text = ""
        CType(.FindControl("F_t_ptad"), TextBox).Text = ""
        CType(.FindControl("F_t_ptcn"), TextBox).Text = ""
        CType(.FindControl("F_t_corg"), TextBox).Text = 0
        CType(.FindControl("F_t_cotp"), TextBox).Text = ""
        CType(.FindControl("F_t_ragr"), TextBox).Text = ""
        CType(.FindControl("F_t_cpay"), TextBox).Text = ""
        CType(.FindControl("F_t_odat"), TextBox).Text = ""
        CType(.FindControl("F_t_odis"), TextBox).Text = 0
        CType(.FindControl("F_t_ccur"), TextBox).Text = ""
        CType(.FindControl("F_t_mcfr"), TextBox).Text = 0
        CType(.FindControl("F_t_ratp_1"), TextBox).Text = 0
        CType(.FindControl("F_t_ratp_2"), TextBox).Text = 0
        CType(.FindControl("F_t_ratp_3"), TextBox).Text = 0
        CType(.FindControl("F_t_ratf_1"), TextBox).Text = 0
        CType(.FindControl("F_t_ratf_2"), TextBox).Text = 0
        CType(.FindControl("F_t_ratf_3"), TextBox).Text = 0
        CType(.FindControl("F_t_ratd"), TextBox).Text = ""
        CType(.FindControl("F_t_ratt"), TextBox).Text = ""
        CType(.FindControl("F_t_raur"), TextBox).Text = 0
        CType(.FindControl("F_t_cwar"), TextBox).Text = ""
        CType(.FindControl("F_t_cadr"), TextBox).Text = ""
        CType(.FindControl("F_t_ccon"), TextBox).Text = ""
        CType(.FindControl("F_t_plnr"), TextBox).Text = ""
        CType(.FindControl("F_t_ccrs"), TextBox).Text = ""
        CType(.FindControl("F_t_cfrw"), TextBox).Text = ""
        CType(.FindControl("F_t_cplp"), TextBox).Text = ""
        CType(.FindControl("F_t_bppr"), TextBox).Text = ""
        CType(.FindControl("F_t_bptx"), TextBox).Text = ""
        CType(.FindControl("F_t_cdec"), TextBox).Text = ""
        CType(.FindControl("F_t_ptpa"), TextBox).Text = ""
        CType(.FindControl("F_t_ddat"), TextBox).Text = ""
        CType(.FindControl("F_t_ddtc"), TextBox).Text = ""
        CType(.FindControl("F_t_cbrn"), TextBox).Text = ""
        CType(.FindControl("F_t_creg"), TextBox).Text = ""
        CType(.FindControl("F_t_refa"), TextBox).Text = ""
        CType(.FindControl("F_t_refb"), TextBox).Text = ""
        CType(.FindControl("F_t_prno"), TextBox).Text = ""
        CType(.FindControl("F_t_ctrj"), TextBox).Text = ""
        CType(.FindControl("F_t_cofc"), TextBox).Text = ""
        CType(.FindControl("F_t_fdpt"), TextBox).Text = ""
        CType(.FindControl("F_t_odty"), TextBox).Text = 0
        CType(.FindControl("F_t_odno"), TextBox).Text = ""
        CType(.FindControl("F_t_retr"), TextBox).Text = ""
        CType(.FindControl("F_t_sorn"), TextBox).Text = ""
        CType(.FindControl("F_t_cosn"), TextBox).Text = ""
        CType(.FindControl("F_t_akcd"), TextBox).Text = ""
        CType(.FindControl("F_t_crcd"), TextBox).Text = ""
        CType(.FindControl("F_t_ctcd"), TextBox).Text = ""
        CType(.FindControl("F_t_egen"), TextBox).Text = 0
        CType(.FindControl("F_t_sbim"), TextBox).Text = 0
        CType(.FindControl("F_t_paft"), TextBox).Text = 0
        CType(.FindControl("F_t_sbmt"), TextBox).Text = ""
        CType(.FindControl("F_t_bpcl"), TextBox).Text = ""
        CType(.FindControl("F_t_oamt"), TextBox).Text = 0
        CType(.FindControl("F_t_comm"), TextBox).Text = 0
        CType(.FindControl("F_t_iebp"), TextBox).Text = 0
        CType(.FindControl("F_t_iafc"), TextBox).Text = 0
        CType(.FindControl("F_t_lccl"), TextBox).Text = ""
        CType(.FindControl("F_t_hdst"), TextBox).Text = 0
        CType(.FindControl("F_t_hisp"), TextBox).Text = 0
        CType(.FindControl("F_t_hism"), TextBox).Text = 0
        CType(.FindControl("F_t_ccty"), TextBox).Text = ""
        CType(.FindControl("F_t_cvyn"), TextBox).Text = 0
        CType(.FindControl("F_t_bpid_l"), TextBox).Text = ""
        CType(.FindControl("F_t_impo_l"), TextBox).Text = 0
        CType(.FindControl("F_t_ccty_l"), TextBox).Text = ""
        CType(.FindControl("F_t_cvat_l"), TextBox).Text = ""
        CType(.FindControl("F_t_exmt_l"), TextBox).Text = 0
        CType(.FindControl("F_t_catg_l"), TextBox).Text = 0
        CType(.FindControl("F_t_ceno_l"), TextBox).Text = ""
        CType(.FindControl("F_t_bdbt_l"), TextBox).Text = 0
        CType(.FindControl("F_t_bnoo_l"), TextBox).Text = ""
        CType(.FindControl("F_t_txta"), TextBox).Text = 0
        CType(.FindControl("F_t_txtb"), TextBox).Text = 0
        CType(.FindControl("F_t_cdf_adat"), TextBox).Text = ""
        CType(.FindControl("F_t_cdf_alvl"), TextBox).Text = 0
        CType(.FindControl("F_t_cdf_onlr"), TextBox).Text = 0
        CType(.FindControl("F_t_cdf_prty"), TextBox).Text = 0
        CType(.FindControl("F_t_cdf_qap"), TextBox).Text = ""
        CType(.FindControl("F_t_cdf_qdat"), TextBox).Text = ""
        CType(.FindControl("F_t_cdf_refb"), TextBox).Text = ""
        CType(.FindControl("F_t_Refcntd"), TextBox).Text = 0
        CType(.FindControl("F_t_Refcntu"), TextBox).Text = 0
        CType(.FindControl("F_t_cdf_reas"), TextBox).Text = ""
        CType(.FindControl("F_t_cdf_qapa"), TextBox).Text = 0
        CType(.FindControl("F_t_atfr_l"), TextBox).Text = 0
        Catch ex As Exception
        End Try
      End With
      Return sender
    End Function
  End Class
End Namespace
