Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.TPISG
  Partial Public Class tpisg220
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
    Public Shared Function UZ_tpisg220SelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.TPISG.tpisg220)
      Dim Results As List(Of SIS.TPISG.tpisg220) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "sptpisg_LG_220SelectListSearch"
            Cmd.CommandText = "sptpisg220SelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "sptpisg_LG_220SelectListFilteres"
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
    Public Shared Function GetByIrefHandle(ByVal t_cprj As String, ByVal t_iref As String, ByVal t_bohd As String) As SIS.TPISG.tpisg220
      Dim Results As SIS.TPISG.tpisg220 = Nothing
      Dim Sql As String = ""
      Sql &= " select top 1 * from ttpisg220200"
      Sql &= " where t_cprj='" & t_cprj & "'"
      Sql &= "   and t_sub1='" & t_iref & "'"
      Sql &= "   and t_bohd='" & t_bohd & "'"
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
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
    Public Shared Function UZ_tpisg220Insert(ByVal Record As SIS.TPISG.tpisg220) As SIS.TPISG.tpisg220
      Dim _Result As SIS.TPISG.tpisg220 = tpisg220Insert(Record)
      Return _Result
    End Function
    Public Shared Function UZ_tpisg220Update(ByVal Record As SIS.TPISG.tpisg220) As SIS.TPISG.tpisg220
      Dim _Result As SIS.TPISG.tpisg220 = tpisg220Update(Record)
      Return _Result
    End Function
    Public Shared Function UZ_tpisg220Delete(ByVal Record As SIS.TPISG.tpisg220) As Integer
      Dim _Result As Integer = tpisg220Delete(Record)
      Return _Result
    End Function
    Public Shared Function SetDefaultValues(ByVal sender As System.Web.UI.WebControls.FormView, ByVal e As System.EventArgs) As System.Web.UI.WebControls.FormView
      With sender
        Try
          CType(.FindControl("F_t_cprj"), TextBox).Text = ""
          CType(.FindControl("F_t_pcod"), TextBox).Text = ""
          CType(.FindControl("F_t_schd"), TextBox).Text = 0
          CType(.FindControl("F_t_cact"), TextBox).Text = ""
          CType(.FindControl("F_t_actp"), TextBox).Text = 0
          CType(.FindControl("F_t_pact"), TextBox).Text = ""
          CType(.FindControl("F_t_bcod"), TextBox).Text = ""
          CType(.FindControl("F_t_dura"), TextBox).Text = 0
          CType(.FindControl("F_t_sdst"), TextBox).Text = ""
          CType(.FindControl("F_t_sdfn"), TextBox).Text = ""
          CType(.FindControl("F_t_acsd"), TextBox).Text = ""
          CType(.FindControl("F_t_acfn"), TextBox).Text = ""
          CType(.FindControl("F_t_bohd"), TextBox).Text = ""
          CType(.FindControl("F_t_pred"), TextBox).Text = ""
          CType(.FindControl("F_t_succ"), TextBox).Text = ""
          CType(.FindControl("F_t_desc"), TextBox).Text = ""
          CType(.FindControl("F_t_acty"), TextBox).Text = ""
          CType(.FindControl("F_t_dept"), TextBox).Text = ""
          CType(.FindControl("F_t_vali"), TextBox).Text = 0
          CType(.FindControl("F_t_outl"), TextBox).Text = 0
          CType(.FindControl("F_t_sub1"), TextBox).Text = ""
          CType(.FindControl("F_t_sub2"), TextBox).Text = ""
          CType(.FindControl("F_t_sub3"), TextBox).Text = ""
          CType(.FindControl("F_t_sub4"), TextBox).Text = ""
          CType(.FindControl("F_t_amod"), TextBox).Text = ""
          CType(.FindControl("F_t_pcbs"), TextBox).Text = ""
          CType(.FindControl("F_t_exdo"), TextBox).Text = 0
          CType(.FindControl("F_t_cpgv"), TextBox).Text = 0
          CType(.FindControl("F_t_otsd"), TextBox).Text = ""
          CType(.FindControl("F_t_oted"), TextBox).Text = ""
          CType(.FindControl("F_t_rmks"), TextBox).Text = ""
          CType(.FindControl("F_t_gps1"), TextBox).Text = ""
          CType(.FindControl("F_t_gps2"), TextBox).Text = ""
          CType(.FindControl("F_t_gps3"), TextBox).Text = ""
          CType(.FindControl("F_t_gps4"), TextBox).Text = ""
          CType(.FindControl("F_t_pper"), TextBox).Text = 0
          CType(.FindControl("F_t_valu"), TextBox).Text = 0
          CType(.FindControl("F_t_sele"), TextBox).Text = 0
          CType(.FindControl("F_t_Refcntd"), TextBox).Text = 0
          CType(.FindControl("F_t_Refcntu"), TextBox).Text = 0
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
    Public Shared Function GetIRefActivities(ByVal t_cprj As String, ByVal t_iref As String) As List(Of SIS.TPISG.tpisg220)
      Dim Results As New List(Of SIS.TPISG.tpisg220)
      Dim Comp As String = "200" ' It should be byval parameter latter
      If Comp Is Nothing Then Comp = "200"
      If Comp = "" Then Comp = "200"
      Dim Sql As String = ""
      Sql &= " select * from ttpisg220" & Comp
      Sql &= " where t_cprj='" & t_cprj & "'"
      Sql &= "   and t_sub1='" & t_iref & "'"
      Sql &= "   and t_bohd='CT_POISSUE'"
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.TPISG.tpisg220(Reader))
          End While
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function UpdateProgress(ByVal t_cprj As String, ByVal t_iref As String, ByVal ProgressPercent As Decimal, ByVal Handle As String) As Boolean
      Dim mRet As Boolean = False
      Dim Comp As String = "200" ' It should be byval parameter latter
      If Comp Is Nothing Then Comp = "200"
      If Comp = "" Then Comp = "200"
      Dim Sql As String = ""
      Sql &= " update ttpisg220" & Comp
      Sql &= "    set t_cpgv=" & ProgressPercent
      Sql &= " where t_cprj='" & t_cprj & "'"
      Sql &= "   and t_sub1='" & t_iref & "'"
      Sql &= "   and t_bohd='" & Handle & "'"
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Con.Open()
          Try
            Cmd.ExecuteNonQuery()
            mRet = True
          Catch ex As Exception
          End Try
        End Using
      End Using
      Return mRet
    End Function
  End Class
End Namespace
