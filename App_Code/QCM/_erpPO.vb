Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.ERP
  Public Class ERPPo
    Public Property ERPPoNumber As String = ""
    Public Property SupplierID As String = ""
    Public Property SupplierName As String = ""
    Public Property SupplierAddress As String = ""
    Public Property BuyerID As String = ""
    Public Property BuyerName As String = ""
    Public Property BuyerEMailID As String = ""
    Public Property ProjectID As String = ""
    Public Property ProjectName As String = ""
    Public Property POWeight As String = "0.0000"
    Public Shared Function ERPPoGetByID(ByVal PONumber As String) As SIS.ERP.ERPPo
      Dim mSql As String = ""
      Dim mComp As String = "200"
      If PONumber.StartsWith("P701") Then
        mComp = "700"
      End If
      mSql = mSql & "select distinct "
      mSql = mSql & "ordh.t_orno as ERPPoNumber,"
      mSql = mSql & "(select top 1 t_cprj from ttdpur401" & mComp & " where t_orno=ordh.t_orno) as ProjectID,"
      mSql = mSql & "ordh.t_otbp as SupplierID,"
      mSql = mSql & "ordh.t_ccon as BuyerID,    "
      mSql = mSql & "'' as SupplierAddress,    "
      mSql = mSql & "emp3.t_nama as BuyerName,"
      mSql = mSql & "bpe3.t_mail as BuyerEMailID, "
      mSql = mSql & "  isnull((select sum(case when t_wght=0 then t_qnty else t_wght end) from ttdisg002" & mComp & " where t_orno='" & PONumber & "'),0) As POWeight, "
      mSql = mSql & "bp01.t_nama as SupplierName "
      mSql = mSql & "from ttdpur400" & mComp & " as ordh "
      mSql = mSql & "left outer join ttccom001" & mComp & " as emp3 on ordh.t_ccon=emp3.t_emno "
      mSql = mSql & "left outer join tbpmdm001" & mComp & " as bpe3 on ordh.t_ccon=bpe3.t_emno "
      mSql = mSql & "left outer join ttccom100" & mComp & " as bp01 on ordh.t_otbp=bp01.t_bpid "
      mSql = mSql & "where ordh.t_orno = '" & PONumber & "'"
      Dim Results As SIS.ERP.ERPPo = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = mSql
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results = New SIS.ERP.ERPPo(Reader)
          End While
          Reader.Close()
        End Using
      End Using
      If Results IsNot Nothing Then
        If Results.BuyerID.Length < 4 Then Results.BuyerID = Results.BuyerID.PadLeft(4, "0")
        Dim tmpSupplierID As String = Results.SupplierID
        If mComp <> "200" Then Results.SupplierID = "S" & mComp & Right(Results.SupplierID, 5)
        Dim oVar As SIS.QCM.qcmVendors = SIS.QCM.qcmVendors.qcmVendorsGetByID(Results.SupplierID)
        If oVar Is Nothing Then oVar = SIS.QCM.qcmVendors.GetBPFromERP(tmpSupplierID, mComp)
        Results.SupplierAddress = oVar.Address1.Trim & " " & oVar.Address2 & " " & oVar.Address3 & " " & oVar.Address4
        Dim oPVar As SIS.QCM.qcmProjects = SIS.QCM.qcmProjects.qcmProjectsGetByID(Results.ProjectID)
        If oPVar Is Nothing Then oPVar = SIS.QCM.qcmProjects.GetProjectFromERP(Results.ProjectID, mComp)
        Results.ProjectName = oPVar.Description
      End If
      Return Results
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

    'Sub New(ByVal Reader As SqlDataReader)
    '  If Convert.IsDBNull(Reader("ERPPoNumber")) Then ERPPoNumber = String.Empty Else ERPPoNumber = CType(Reader("ERPPoNumber"), String)
    '  If Convert.IsDBNull(Reader("ProjectID")) Then ProjectID = String.Empty Else ProjectID = CType(Reader("ProjectID"), String)
    '  If Convert.IsDBNull(Reader("SupplierID")) Then SupplierID = String.Empty Else SupplierID = CType(Reader("SupplierID"), String)
    '  If Convert.IsDBNull(Reader("SupplierName")) Then SupplierName = String.Empty Else SupplierName = CType(Reader("SupplierName"), String)
    '  If Convert.IsDBNull(Reader("SupplierAddress")) Then SupplierAddress = String.Empty Else SupplierAddress = CType(Reader("SupplierAddress"), String)
    '  If Convert.IsDBNull(Reader("BuyerID")) Then
    '    BuyerID = String.Empty
    '  Else
    '    Dim X As String = Reader("BuyerID")
    '    If X.Length > 4 Then
    '      BuyerID = X
    '    Else
    '      BuyerID = Right("0000" & X, 4)
    '    End If
    '  End If
    '  If Convert.IsDBNull(Reader("BuyerName")) Then BuyerName = String.Empty Else BuyerName = CType(Reader("BuyerName"), String)
    '  If Convert.IsDBNull(Reader("BuyerEMailID")) Then BuyerEMailID = String.Empty Else BuyerEMailID = CType(Reader("BuyerEMailID"), String)
    '  If Convert.IsDBNull(Reader("POWeight")) Then POWeight = "0.0000" Else POWeight = String.Format("{0:f4}", CType(Reader("POWeight"), Double))
    'End Sub
    Sub New()
      'dummy
    End Sub
  End Class

End Namespace
