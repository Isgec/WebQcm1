Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.QCM
  Partial Public Class qcmInspections
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
    Public Shared Function UZ_qcmInspectionsSelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String, ByVal RequestID As Int32) As List(Of SIS.QCM.qcmInspections)
      Dim Results As List(Of SIS.QCM.qcmInspections) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "spqcmInspectionsSelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "spqcmInspectionsSelectListFilteres"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Filter_RequestID", SqlDbType.Int, 10, IIf(RequestID = Nothing, 0, RequestID))
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.QCM.qcmInspections)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.QCM.qcmInspections(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function UZ_qcmInspectionsInsert(ByVal Record As SIS.QCM.qcmInspections) As SIS.QCM.qcmInspections
      If Record.InspectedBy = "" Then
        Record.InspectedBy = HttpContext.Current.Session("LoginID")
        Record.InspectedOn = Now
      End If
      Dim _Result As SIS.QCM.qcmInspections = qcmInspectionsInsert(Record)
      'update inspected
      SIS.QCM.qcmRequests.UpdateInspected(_Result)
      Return _Result
    End Function
    Public Shared Function UZ_qcmInspectionsUpdate(ByVal Record As SIS.QCM.qcmInspections) As SIS.QCM.qcmInspections
      Dim _Result As SIS.QCM.qcmInspections = qcmInspectionsUpdate(Record)
      Return _Result
    End Function
    Public Shared Function UZ_qcmInspectionsDelete(ByVal Record As SIS.QCM.qcmInspections) As Integer
      Dim _Result As Integer = qcmInspections.Delete(Record)
      Return _Result
    End Function
    Public Shared Function GetByRequestIDAndInspectedOn(ByVal RequestID As Int32, ByVal InspectedOn As DateTime) As SIS.QCM.qcmInspections
      Dim Results As SIS.QCM.qcmInspections = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcm_LG_InspectionsSelectByRequestIDAndInspectedOn"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@RequestID", SqlDbType.Int, RequestID.ToString.Length, RequestID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@InspectedOn", SqlDbType.DateTime, 21, InspectedOn)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.QCM.qcmInspections(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function SetDefaultValues(ByVal sender As System.Web.UI.WebControls.FormView, ByVal e As System.EventArgs) As System.Web.UI.WebControls.FormView
      With sender
        Try
          CType(.FindControl("F_InspectedQuantity"), TextBox).Text = "0.00"
          CType(.FindControl("F_OfferedQuantity"), TextBox).Text = "0.00"
          CType(.FindControl("F_ClearedQuantity"), TextBox).Text = "0.00"
          CType(.FindControl("F_InspectedQuantityFinal"), TextBox).Text = "0.00"
          CType(.FindControl("F_OfferedQuantityFinal"), TextBox).Text = "0.00"
          CType(.FindControl("F_ClearedQuantityFinal"), TextBox).Text = "0.00"
          CType(.FindControl("F_InspectedBy"), TextBox).Text = HttpContext.Current.Session("LoginID")
          CType(.FindControl("F_InspectedBy_Display"), Label).Text = ""
          CType(.FindControl("F_InspectedOn"), TextBox).Text = Now.ToString("dd/MM/yyyy")
        Catch ex As Exception
        End Try
      End With
      Return sender
    End Function
  End Class
End Namespace
