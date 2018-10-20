Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.QCMCT
  Partial Public Class qcmctRequest
    Public ReadOnly Property RowProgressPercent As Boolean
      Get
        Return Not RowProgressWeight
      End Get
    End Property

    Public ReadOnly Property RowProgressWeight As Boolean
      Get
        Dim Sql As String = ""
        Sql &= " select t_icls "
        Sql &= " from ttpisg239200 "
        Sql &= " where  "
        Sql &= " t_cprj='" & Project & "'"
        Sql &= " and t_iref='" & ItemReference & "'"
        Dim mRet As Boolean = False
        Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
          Using Cmd As SqlCommand = Con.CreateCommand()
            Cmd.CommandType = CommandType.Text
            Cmd.CommandText = Sql
            Con.Open()
            Dim tmpX As String = Cmd.ExecuteScalar
            Try
              Select Case tmpX
                Case "1", "3" '1=>Boughtout, 3=>Package
                  mRet = False
                Case "4" 'Self Engineered
                  mRet = True
              End Select
            Catch ex As Exception
              Throw New Exception("Item Reference Type B/S/P not defined in tpisg239")
            End Try
          End Using
        End Using
        Return mRet
      End Get
    End Property
    Public ReadOnly Property ClearedWt As Decimal
      Get
        Dim Sql As String = ""
        Sql &= " select isnull(sum(qcd.QualityClearedWt),0) As ClearedWt "
        Sql &= " from pak_qclistd as qcd "
        Sql &= " inner join PAK_POBItems as itm on qcd.serialno = itm.serialno and qcd.ItemNo=itm.itemno "
        Sql &= " inner join Pak_po as po on qcd.serialno = po.serialno "
        Sql &= " where po.POFOR='PK' "
        Sql &= " and po.PONumber='" & PONumber & "'"
        Sql &= " and itm.ItemReference='" & ItemReference & "'"
        Dim mRet As Decimal = 0
        Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
          Using Cmd As SqlCommand = Con.CreateCommand()
            Cmd.CommandType = CommandType.Text
            Cmd.CommandText = Sql
            Con.Open()
            mRet = Cmd.ExecuteScalar
          End Using
        End Using
        Return mRet
      End Get
    End Property
    Public Function GetColor() As System.Drawing.Color
      Dim mRet As System.Drawing.Color = Drawing.Color.Red
      If Convert.ToDecimal(ProgressPercent) > 0 Then
        mRet = Drawing.Color.Green
      End If
      Return mRet
    End Function
    Public ReadOnly Property SubItemDesc As String
      Get
        Dim mRet As String = ""
        mRet = Activity2Desc
        If Activity3Desc <> "" Then
          mRet &= "=>" & Activity3Desc
        End If
        If Activity4Desc <> "" Then
          mRet &= "=>" & Activity4Desc
        End If
        Return mRet
      End Get
    End Property
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
      Dim mRet As Boolean = False
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
    Public Shared Function UZ_qcmctRequestSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal QCRequestNo As Int32) As List(Of SIS.QCMCT.qcmctRequest)
      Dim Results As List(Of SIS.QCMCT.qcmctRequest) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spqcmct_LG_RequestSelectListSearch"
            Cmd.CommandText = "spqcmctRequestSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spqcmct_LG_RequestSelectListFilteres"
            Cmd.CommandText = "spqcmctRequestSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_QCRequestNo", SqlDbType.Int, 10, IIf(QCRequestNo = Nothing, 0, QCRequestNo))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.QCMCT.qcmctRequest)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCMCT.qcmctRequest(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function GetERPItemReference(ByVal ProjectID As String, ByVal OrNo As String, ByVal Handle As String) As List(Of SIS.QCMCT.qcmctRequest)
      Dim Results As List(Of SIS.QCMCT.qcmctRequest) = Nothing
      'CT_INSPECTIONCALLRAISED
      Dim Sql As String = ""

      Sql &= " select distinct    "
      Sql &= " tp2.t_pcod As Product,    "
      Sql &= " tp3.t_sub2 As Activity2Desc,    "
      Sql &= " tp3.t_sub3 As Activity3Desc,    "
      Sql &= " tp3.t_sub4 As Activity4Desc,    "
      Sql &= " tp2.t_sub1 As ItemReference,    "
      Sql &= " tp2.t_sitm As ActivityID,    "
      Sql &= " sum(td2.t_wght)  As IrefWeight      "
      Sql &= " from ttdisg002200 as td2    "
      Sql &= " inner join tdmisg002200 as dm2 on td2.t_docn = dm2.t_docn and td2.t_revi = dm2.t_revn and td2.t_item = dm2.t_item    "
      Sql &= " inner join tdmisg140200 as dm4 on td2.t_docn = dm4.t_docn    "
      Sql &= " inner join ttpisg220200 as tp2 on dm4.t_iref = tp2.t_sub1 and dm4.t_cprj = tp2.t_cprj and tp2.t_sitm = case when dm2.t_sitm = '' then tp2.t_sitm else  dm2.t_sitm end  "
      Sql &= " left outer join ttpisg243200 as tp3 on tp2.t_sub1 = tp3.t_iref and tp2.t_sitm = tp3.t_sitm and tp2.t_pcod = tp3.t_cprd    "
      Sql &= " where td2.t_orno = '" & OrNo & "'"
      Sql &= "   and tp2.t_bohd = '" & Handle & "'"
      Sql &= " group by tp2.t_pcod,tp3.t_sub2, tp3.t_sub3,tp3.t_sub4, tp2.t_sub1, tp2.t_sitm  "

      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Results = New List(Of SIS.QCMCT.qcmctRequest)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCMCT.qcmctRequest(Reader))
          End While
          Reader.Close()
          _RecordCount = Results.Count
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function UZ_qcmctRequestInsert(ByVal Record As SIS.QCMCT.qcmctRequest) As SIS.QCMCT.qcmctRequest
      Dim _Result As SIS.QCMCT.qcmctRequest = qcmctRequestInsert(Record)
      Return _Result
    End Function
    Public Shared Function UZ_qcmctRequestUpdate(ByVal Record As SIS.QCMCT.qcmctRequest) As SIS.QCMCT.qcmctRequest
      Dim _Rec As SIS.QCMCT.qcmctRequest = SIS.QCMCT.qcmctRequest.qcmctRequestGetByID(Record.QCRequestNo, Record.SerialNo, Record.PONumber, Record.ItemReference, Record.ActivityID)
      With _Rec
        .Quantity = Record.Quantity
        .PartialOrFull = Record.PartialOrFull
        .NotSelectedList = Record.NotSelectedList
        .SelectedList = Record.SelectedList
        .InspectionStageiD = Record.InspectionStageiD
        If Record.ProgressPercent = "" Then Record.ProgressPercent = "0.0000"
        If Record.ProgressWeight = "" Then Record.ProgressWeight = "0.0000"
        If _Rec.RowProgressPercent Then
          .ProgressWeight = _Rec.IrefWeight * Record.ProgressPercent * 0.01
          .ProgressPercent = Record.ProgressPercent
        Else
          Try
            .ProgressPercent = (Convert.ToDecimal(Record.ProgressWeight) / Convert.ToDecimal(_Rec.IrefWeight)) * 100
          Catch ex As Exception
            .ProgressPercent = "0.0000"
          End Try
          .ProgressWeight = Record.ProgressWeight
        End If
      End With
      _Rec = SIS.QCMCT.qcmctRequest.UpdateData(_Rec)
      Return _Rec
    End Function
    Public Shared Function UZ_qcmctRequestDelete(ByVal Record As SIS.QCMCT.qcmctRequest) As Integer
      Dim _Result As Integer = qcmctRequestDelete(Record)
      Return _Result
    End Function
    Public Shared Function SetDefaultValues(ByVal sender As System.Web.UI.WebControls.FormView, ByVal e As System.EventArgs) As System.Web.UI.WebControls.FormView
      With sender
        Try
          CType(.FindControl("F_PONumber"), TextBox).Text = ""
          CType(.FindControl("F_ItemReference"), TextBox).Text = ""
          CType(.FindControl("F_Activity2Desc"), TextBox).Text = ""
          CType(.FindControl("F_Quantity"), TextBox).Text = 0
          CType(.FindControl("F_PartialOrFull"), DropDownList).SelectedValue = ""
          CType(.FindControl("F_PercentOfQuantity"), TextBox).Text = 0
          CType(.FindControl("F_NotSelectedList"), TextBox).Text = ""
          CType(.FindControl("F_SelectedList"), TextBox).Text = ""
          CType(.FindControl("F_GridLineStatus"), TextBox).Text = 0
          CType(.FindControl("F_Project"), TextBox).Text = ""
          CType(.FindControl("F_Product"), TextBox).Text = ""
          CType(.FindControl("F_ActivityID"), TextBox).Text = ""
          CType(.FindControl("F_ItemUnit"), TextBox).Text = ""
          CType(.FindControl("F_QCRequestNo"), TextBox).Text = 0
          CType(.FindControl("F_SerialNo"), TextBox).Text = 0
          CType(.FindControl("F_Handle"), TextBox).Text = ""
          CType(.FindControl("F_ProgressPercent"), TextBox).Text = 0
          CType(.FindControl("F_Activity3Desc"), TextBox).Text = ""
          CType(.FindControl("F_Activity4Desc"), TextBox).Text = ""
        Catch ex As Exception
        End Try
      End With
      Return sender
    End Function
  End Class
End Namespace
