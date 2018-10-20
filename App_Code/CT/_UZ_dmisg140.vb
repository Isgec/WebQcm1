Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.DMISG
  Partial Public Class dmisg140
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
    Public Shared Function UZ_dmisg140SelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.DMISG.dmisg140)
      Dim Results As List(Of SIS.DMISG.dmisg140) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spdmisg_LG_140SelectListSearch"
            Cmd.CommandText = "spdmisg140SelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spdmisg_LG_140SelectListFilteres"
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
    Public Shared Function UZ_dmisg140Insert(ByVal Record As SIS.DMISG.dmisg140) As SIS.DMISG.dmisg140
      Dim _Result As SIS.DMISG.dmisg140 = dmisg140Insert(Record)
      Return _Result
    End Function
    Public Shared Function UZ_dmisg140Update(ByVal Record As SIS.DMISG.dmisg140) As SIS.DMISG.dmisg140
      Dim _Result As SIS.DMISG.dmisg140 = dmisg140Update(Record)
      Return _Result
    End Function
    Public Shared Function UZ_dmisg140Delete(ByVal Record As SIS.DMISG.dmisg140) As Integer
      Dim _Result As Integer = dmisg140Delete(Record)
      Return _Result
    End Function
    Public Shared Function SetDefaultValues(ByVal sender As System.Web.UI.WebControls.FormView, ByVal e As System.EventArgs) As System.Web.UI.WebControls.FormView
      With sender
        Try
          CType(.FindControl("F_t_pcod"), TextBox).Text = ""
          CType(.FindControl("F_t_cprj"), TextBox).Text = ""
          CType(.FindControl("F_t_uidn"), TextBox).Text = ""
          CType(.FindControl("F_t_revn"), TextBox).Text = ""
          CType(.FindControl("F_t_docn"), TextBox).Text = ""
          CType(.FindControl("F_t_dsca"), TextBox).Text = ""
          CType(.FindControl("F_t_aldo"), TextBox).Text = ""
          CType(.FindControl("F_t_alre"), TextBox).Text = ""
          CType(.FindControl("F_t_cspa"), TextBox).Text = ""
          CType(.FindControl("F_t_type"), TextBox).Text = ""
          CType(.FindControl("F_t_resp"), TextBox).Text = ""
          CType(.FindControl("F_t_size"), TextBox).Text = 0
          CType(.FindControl("F_t_orgn"), TextBox).Text = ""
          CType(.FindControl("F_t_subm"), TextBox).Text = 0
          CType(.FindControl("F_t_intr"), TextBox).Text = 0
          CType(.FindControl("F_t_prod"), TextBox).Text = 0
          CType(.FindControl("F_t_erec"), TextBox).Text = 0
          CType(.FindControl("F_t_info"), TextBox).Text = 0
          CType(.FindControl("F_t_remk"), TextBox).Text = ""
          CType(.FindControl("F_t_soft"), TextBox).Text = ""
          CType(.FindControl("F_t_drwn"), TextBox).Text = ""
          CType(.FindControl("F_t_chec"), TextBox).Text = ""
          CType(.FindControl("F_t_engg"), TextBox).Text = ""
          CType(.FindControl("F_t_dhrs"), TextBox).Text = 0
          CType(.FindControl("F_t_chrs"), TextBox).Text = 0
          CType(.FindControl("F_t_ehrs"), TextBox).Text = 0
          CType(.FindControl("F_t_lmhr"), TextBox).Text = 0
          CType(.FindControl("F_t_acdt"), TextBox).Text = ""
          CType(.FindControl("F_t_upby"), TextBox).Text = ""
          CType(.FindControl("F_t_updt"), TextBox).Text = ""
          CType(.FindControl("F_t_dwgs"), TextBox).Text = 0
          CType(.FindControl("F_t_genm"), TextBox).Text = ""
          CType(.FindControl("F_t_inpt"), TextBox).Text = 0
          CType(.FindControl("F_t_seqn"), TextBox).Text = 0
          CType(.FindControl("F_t_bssd"), TextBox).Text = ""
          CType(.FindControl("F_t_bsfd"), TextBox).Text = ""
          CType(.FindControl("F_t_rssd"), TextBox).Text = ""
          CType(.FindControl("F_t_rsfd"), TextBox).Text = ""
          CType(.FindControl("F_t_lrrd"), TextBox).Text = ""
          CType(.FindControl("F_t_rfsv"), TextBox).Text = ""
          CType(.FindControl("F_t_irst"), TextBox).Text = ""
          CType(.FindControl("F_t_dref"), TextBox).Text = 0
          CType(.FindControl("F_t_chef"), TextBox).Text = 0
          CType(.FindControl("F_t_leef"), TextBox).Text = 0
          CType(.FindControl("F_t_lmef"), TextBox).Text = 0
          CType(.FindControl("F_t_drep"), TextBox).Text = ""
          CType(.FindControl("F_t_oscd"), TextBox).Text = 0
          CType(.FindControl("F_t_Refcntd"), TextBox).Text = 0
          CType(.FindControl("F_t_Refcntu"), TextBox).Text = 0
          CType(.FindControl("F_t_pled"), TextBox).Text = ""
          CType(.FindControl("F_t_appr"), TextBox).Text = 0
          CType(.FindControl("F_t_rdat"), TextBox).Text = ""
          CType(.FindControl("F_t_selc"), TextBox).Text = 0
          CType(.FindControl("F_t_acty"), TextBox).Text = ""
          CType(.FindControl("F_t_fadt"), TextBox).Text = ""
          CType(.FindControl("F_t_iadt"), TextBox).Text = ""
          CType(.FindControl("F_t_iref"), TextBox).Text = ""
          CType(.FindControl("F_t_itdt"), TextBox).Text = ""
          CType(.FindControl("F_t_padt"), TextBox).Text = ""
          CType(.FindControl("F_t_pcdt"), TextBox).Text = ""
          CType(.FindControl("F_t_podt"), TextBox).Text = ""
          CType(.FindControl("F_t_prdt"), TextBox).Text = ""
          CType(.FindControl("F_t_psdt"), TextBox).Text = ""
          CType(.FindControl("F_t_dpct"), TextBox).Text = 0
          CType(.FindControl("F_t_dpwt"), TextBox).Text = 0
          CType(.FindControl("F_t_idct"), TextBox).Text = 0
          CType(.FindControl("F_t_idwt"), TextBox).Text = 0
          CType(.FindControl("F_t_popt"), TextBox).Text = 0
          CType(.FindControl("F_t_posw"), TextBox).Text = 0
          CType(.FindControl("F_t_powt"), TextBox).Text = 0
          CType(.FindControl("F_t_pspt"), TextBox).Text = 0
          CType(.FindControl("F_t_posd"), TextBox).Text = ""
          CType(.FindControl("F_t_upct"), TextBox).Text = 0
          CType(.FindControl("F_t_bgdt"), TextBox).Text = ""
          CType(.FindControl("F_t_vpdt"), TextBox).Text = ""
          CType(.FindControl("F_t_vrdt"), TextBox).Text = ""
          CType(.FindControl("F_t_upon"), TextBox).Text = ""
          CType(.FindControl("F_t_adct"), TextBox).Text = ""
          CType(.FindControl("F_t_piwt"), TextBox).Text = 0
          CType(.FindControl("F_t_poic"), TextBox).Text = 0
          CType(.FindControl("F_t_pois"), TextBox).Text = ""
          CType(.FindControl("F_t_numo"), TextBox).Text = 0
          CType(.FindControl("F_t_numq"), TextBox).Text = 0
          CType(.FindControl("F_t_numt"), TextBox).Text = 0
          CType(.FindControl("F_t_numv"), TextBox).Text = 0
          CType(.FindControl("F_t_nutc"), TextBox).Text = 0
        Catch ex As Exception
        End Try
      End With
      Return sender
    End Function
    Public Shared Function dmisg140GetByDocumentID(ByVal t_docn As String) As SIS.DMISG.dmisg140
      Dim Results As SIS.DMISG.dmisg140 = Nothing
      Dim Comp As String = "200" ' It should be byval parameter latter
      If Comp Is Nothing Then Comp = "200"
      If Comp = "" Then Comp = "200"
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = "select * from tdmisg140" & Comp & " where t_docn='" & t_docn & "'"
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
    Public Shared Function UpdatePOAD(ByVal t_docn As String) As SIS.DMISG.dmisg140
      Dim Results As SIS.DMISG.dmisg140 = Nothing
      Dim Comp As String = "200" ' It should be byval parameter latter
      If Comp Is Nothing Then Comp = "200"
      If Comp = "" Then Comp = "200"
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = "update tdmisg140" & Comp & " set t_poad = convert(datetime,'" & Now.ToString("dd/MM/yyyy HH:mm") & "',103) where t_docn='" & t_docn & "' and t_poad < convert(datetime,'31/12/2000',103)"
          Con.Open()
          Cmd.ExecuteNonQuery()
        End Using
      End Using
      Return Results
    End Function

    Public Shared Function UpdatePOIS(ByVal t_docn As String) As SIS.DMISG.dmisg140
      Dim Results As SIS.DMISG.dmisg140 = Nothing
      Dim Comp As String = "200" ' It should be byval parameter latter
      If Comp Is Nothing Then Comp = "200"
      If Comp = "" Then Comp = "200"
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = "update tdmisg140" & Comp & " set t_pois = convert(datetime,'" & Now.ToString("dd/MM/yyyy HH:mm") & "',103) where t_docn='" & t_docn & "' and t_pois < convert(datetime,'31/12/2000',103)"
          Con.Open()
          Cmd.ExecuteNonQuery()
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function GetIREFDocuments(ByVal t_cprj As String, ByVal t_iref As String) As List(Of SIS.DMISG.dmisg140)
      Dim Results As New List(Of SIS.DMISG.dmisg140)
      Dim Comp As String = "200" ' It should be byval parameter latter
      If Comp Is Nothing Then Comp = "200"
      If Comp = "" Then Comp = "200"
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = "select * from tdmisg140" & Comp & " where t_cprj='" & t_cprj & "' and t_iref='" & t_iref & "'"
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.DMISG.dmisg140(Reader))
          End While
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
  End Class
End Namespace
