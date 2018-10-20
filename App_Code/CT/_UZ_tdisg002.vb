Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Namespace SIS.TDISG
  Partial Public Class ttdisg002
    Public Shared Function UZ_ttdisg002SelectList(ByVal StartRowIndex As Integer, ByVal MaximumRows As Integer, ByVal OrderBy As String, ByVal SearchState As Boolean, ByVal SearchText As String) As List(Of SIS.TDISG.ttdisg002)
      Dim Results As List(Of SIS.TDISG.ttdisg002) = Nothing
      Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetBaaNConnectionString())
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.StoredProcedure
          If SearchState Then
            Cmd.CommandText = "sptdisg_LG_t002SelectListSearch"
            Cmd.CommandText = "sptdisgt002SelectListSearch"
            SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@KeyWord", SqlDbType.NVarChar, 250, SearchText)
          Else
            Cmd.CommandText = "sptdisg_LG_t002SelectListFilteres"
            Cmd.CommandText = "sptdisgt002SelectListFilteres"
          End If
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@StartRowIndex", SqlDbType.Int, -1, StartRowIndex)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@MaximumRows", SqlDbType.Int, -1, MaximumRows)
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@LoginID", SqlDbType.NVarChar, 9, HttpContext.Current.Session("LoginID"))
          SIS.SYS.SQLDatabase.DBCommon.AddDBParameter(Cmd, "@OrderBy", SqlDbType.NVarChar, 50, OrderBy)
          Cmd.Parameters.Add("@RecordCount", SqlDbType.Int)
          Cmd.Parameters("@RecordCount").Direction = ParameterDirection.Output
          _RecordCount = -1
          Results = New List(Of SIS.TDISG.ttdisg002)()
          Con.Open()
          Dim Reader As SqlDataReader = Cmd.ExecuteReader()
          While (Reader.Read())
            Results.Add(New SIS.TDISG.ttdisg002(Reader))
          End While
          Reader.Close()
          _RecordCount = Cmd.Parameters("@RecordCount").Value
        End Using
      End Using
      Return Results
    End Function
    Public Shared Function UZ_ttdisg002Insert(ByVal Record As SIS.TDISG.ttdisg002) As SIS.TDISG.ttdisg002
      Dim _Result As SIS.TDISG.ttdisg002 = ttdisg002Insert(Record)
      Return _Result
    End Function
    Public Shared Function UZ_ttdisg002Update(ByVal Record As SIS.TDISG.ttdisg002) As SIS.TDISG.ttdisg002
      Dim _Result As SIS.TDISG.ttdisg002 = ttdisg002Update(Record)
      Return _Result
    End Function
    Public Shared Function UZ_ttdisg002Delete(ByVal Record As SIS.TDISG.ttdisg002) As Integer
      Dim _Result As Integer = ttdisg002Delete(Record)
      Return _Result
    End Function
  End Class
End Namespace
