Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.QCM
  Partial Public Class qcmVendors
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
    Public Shared Function GetBPFromERP(ByVal BPID As String) As SIS.QCM.qcmVendors
      Dim Results As SIS.QCM.qcmVendors = Nothing
      Dim Sql As String = ""
      Sql &= "select                                                           "
      Sql &= "  suh.t_bpid as VendorID,                                        "
      Sql &= "  suh.t_nama as Description,                                     "
      Sql &= "  adh.t_ln01 as Address1,                                        "
      Sql &= "  adh.t_ln02 as Address2,                                        "
      Sql &= "  adh.t_ln03 as Address3,                                        "
      Sql &= "  adh.t_ln04 as Address4,                                        "
      Sql &= "  adh.t_ln05 as City,                                            "
      Sql &= "  adh.t_ln06 as State,                                           "
      Sql &= "  adh.t_pstc as Zip,                                             "
      Sql &= "  adh.t_ccty as Country,                                         "
      Sql &= "  cnh.t_fuln as ContactPerson,                                   "
      Sql &= "  cnh.t_telp as ContactNo,                                       "
      Sql &= "  cnh.t_info as EMailID                                          "
      Sql &= "  from ttccom100200 as suh                                       "
      Sql &= "  left outer join ttccom130200 as adh on suh.t_cadr = adh.t_cadr "
      Sql &= "  left outer join ttccom140200 as cnh on suh.t_ccnt = cnh.t_ccnt "
      Sql &= "  where suh.t_bpid ='" & BPID & "'"
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If Reader.Read() Then
            Results = New SIS.QCM.qcmVendors(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      If Results IsNot Nothing Then
        Results = SIS.QCM.qcmVendors.InsertData(Results)
      End If
      Return Results
    End Function
  End Class
End Namespace
