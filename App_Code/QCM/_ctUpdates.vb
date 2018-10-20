Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.CT
  Public Class ctUpdates
    Public Shared Sub CT_ManualQCRequest(ByVal pp As SIS.QCM.qcmRequests)
      Dim hndl As String = "CT_INSPECTIONCALLRAISED"
      Dim trdt As String = Now.ToString("dd/MM/yyyy HH:mm:ss")
      Dim POIrefs As List(Of SIS.QCMCT.qcmctRequest) = SIS.QCMCT.qcmctRequest.UZ_qcmctRequestSelectList(0, 99999, "", False, "", pp.RequestID)
      For Each iref As SIS.QCMCT.qcmctRequest In POIrefs
        Select Case iref.InspectionStageiD
          Case "2", "3"
          Case Else
            Continue For
        End Select
        If iref.ProgressPercent = "" Then iref.ProgressPercent = "0"
        If iref.ProgressWeight = "" Then iref.ProgressWeight = "0"
        If Convert.ToDecimal(iref.ProgressPercent) = 0 AndAlso Convert.ToDecimal(iref.ProgressWeight) = 0 Then Continue For
        Dim tmp As New SIS.TPISG.tpisg207
        With tmp
          .t_bohd = hndl
          .t_date = trdt
          .t_inid = pp.RequestID
          .t_iref = iref.ItemReference
          .t_mode = 1  '=>Manual, 2=>Packing List
          .t_pono = pp.OrderNo
          .t_prpo = iref.ProgressPercent
          .t_powt = iref.ProgressWeight
          .t_Refcntd = 0
          .t_Refcntu = 0
          .t_cprj = pp.ProjectID
          .t_sitm = iref.ActivityID
        End With
        SIS.TPISG.tpisg207.InsertData(tmp)
      Next
    End Sub
    Public Shared Sub CT_InspectedInBlackCondition(ByVal pp As SIS.QCM.qcmRequests)
      Dim hndl As String = "CT_INSPECTIONBLACKCONDITION"
      Dim trdt As String = Now.ToString("dd/MM/yyyy HH:mm:ss")
      'First Check Offered QC List Available or NOT
      Dim OfferedListFound As Boolean = False
      Dim qcDs As List(Of SIS.PAK.pakQCListDIRef) = SIS.PAK.pakQCListDIRef.GetOfferedQCListDIref(pp.RequestID)
      If qcDs.Count > 0 Then
        OfferedListFound = True
      End If
      For Each qcD As SIS.PAK.pakQCListDIRef In qcDs
        Dim tmp207 As New SIS.TPISG.tpisg207
        With tmp207
          .t_bohd = hndl
          .t_date = trdt
          .t_inid = pp.RequestID
          .t_iref = qcD.ItemReference
          .t_mode = 2  '=>Manual, 2=>Packing List
          .t_pono = pp.OrderNo
          If SelfEngineered(pp.ProjectID, qcD.ItemReference) Then
            .t_prpo = qcD.ProgressPercent
          Else
            .t_prpo = qcD.ProgressPercentByQuantity
          End If
          .t_powt = qcD.TotalWeight
          .t_Refcntd = 0
          .t_Refcntu = 0
          .t_cprj = pp.ProjectID
          .t_sitm = qcD.SubItem
        End With
        SIS.TPISG.tpisg207.InsertData(tmp207)
      Next

      If Not OfferedListFound Then
        Dim POIrefs As List(Of SIS.QCMCT.qcmctRequest) = SIS.QCMCT.qcmctRequest.UZ_qcmctRequestSelectList(0, 99999, "", False, "", pp.RequestID)
        For Each iref As SIS.QCMCT.qcmctRequest In POIrefs
          Select Case iref.InspectionStageiD
            Case "2", "3"
            Case Else
              Continue For
          End Select
          If iref.ProgressPercent = "" Then iref.ProgressPercent = "0"
          If iref.ProgressWeight = "" Then iref.ProgressWeight = "0"
          If Convert.ToDecimal(iref.ProgressPercent) = 0 AndAlso Convert.ToDecimal(iref.ProgressWeight) = 0 Then Continue For
          Dim tmp As New SIS.TPISG.tpisg207
          With tmp
            .t_bohd = hndl
            .t_date = trdt
            .t_inid = pp.RequestID
            .t_iref = iref.ItemReference
            .t_mode = 1  '=>Manual, 2=>Packing List
            .t_pono = pp.OrderNo
            .t_prpo = iref.ProgressPercent
            .t_powt = iref.ProgressWeight
            .t_Refcntd = 0
            .t_Refcntu = 0
            .t_cprj = pp.ProjectID
            .t_sitm = iref.ActivityID
          End With
          SIS.TPISG.tpisg207.InsertData(tmp)
        Next
      End If
    End Sub
    Public Shared Function SelfEngineered(ByVal Project As String, ByVal ItemReference As String) As Boolean
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
    End Function

  End Class
End Namespace
