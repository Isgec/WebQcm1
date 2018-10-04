Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.QCM
  Partial Public Class qcmProjects
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
    Public Shared Function GetProjectFromERP(ByVal ProjectID As String) As SIS.QCM.qcmProjects
      Dim Ret As SIS.QCM.qcmProjects = Nothing
      Dim Sql As String = ""
      Sql &= "select top 1  "
      Sql &= "  prh.t_cprj as ProjectID,  "
      Sql &= "  prd.t_dsca as Description, "
      Sql &= "  prb.t_ofbp as BusinessPartnerID "
      Sql &= "  from ttppdm600200 as prh  "
      Sql &= "  right outer join ttcmcs052200 as prd on prd.t_cprj=prh.t_cprj"
      Sql &= "  right outer join ttppdm740200 as prb on prb.t_cprj=prh.t_cprj"
      Sql &= "  where prh.t_cprj ='" & ProjectID & "'"
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          If (Reader.Read()) Then
            Ret = New SIS.QCM.qcmProjects(Reader)
          End If
          Reader.Close()
        End Using
      End Using
      If Ret IsNot Nothing Then
        SIS.QCM.qcmProjects.InsertData(Ret)
      End If
      Return Ret
    End Function
    Public Shared Function InsertData(ByVal Record As SIS.QCM.qcmProjects) As String
      Dim _Result As String = Record.ProjectID
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          Cmd.CommandText = "spqcmProjectsInsert"
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@ProjectID", SqlDbType.NVarChar, 7, Record.ProjectID)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@Description", SqlDbType.NVarChar, 51, Record.Description)
          Cmd.Parameters.Add("@Return_ProjectID", SqlDbType.NVarChar, 6)
          Cmd.Parameters("@Return_ProjectID").Direction = ParameterDirection.Output
          Con.Open()
          Cmd.ExecuteNonQuery()
          _Result = Cmd.Parameters("@Return_ProjectID").Value
        End Using
      End Using
      Return _Result
    End Function
  End Class
End Namespace
