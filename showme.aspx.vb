Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Net

Partial Class showme
  Inherits System.Web.UI.Page

  Private Sub showme_Load(sender As Object, e As EventArgs) Handles Me.Load
    Try
      Dim Sql As String = ""
      Dim rq As HttpRequest = HttpContext.Current.Request
      Dim rqStr As String = rq.ToString
      Dim hName As String = rq.UserHostName & ", " & (Dns.GetHostEntry(Request.ServerVariables("remote_addr")).HostName)
      Dim ip As String = rq.UserHostAddress
      Dim ua As String = rq.UserAgent

      Try
        For Each pi As System.Reflection.PropertyInfo In rq.GetType.GetProperties
          If pi.MemberType = Reflection.MemberTypes.Property Then
            Try
              rqStr &= pi.Name
              rqStr &= ":" & CallByName(rq, pi.Name, CallType.Get)
            Catch ex As Exception
            End Try
          End If
        Next
      Catch ex As Exception
      End Try

      Sql &= ""
      Sql &= " INSERT INTO [dbo].[TMP_Showme]"
      Sql &= "([description]"
      Sql &= " ,[HostName]"
      Sql &= " ,[IPAddress]"
      Sql &= " ,[UserAgent])"
      Sql &= " VALUES  "
      Sql &= " ('" & rqStr & "'"
      Sql &= " ,'" & hName & "'"
      Sql &= " ,'" & ip & "'"
      Sql &= " ,'" & ua & "')"
      Using Con As SqlConnection = New SqlConnection("Data Source=192.9.200.150;Initial Catalog=IJTPerks;Integrated Security=False;User Instance=False;Persist Security Info=True;User ID=sa;Password=isgec12345")
        Using Cmd As SqlCommand = Con.CreateCommand()
          Cmd.CommandType = CommandType.Text
          Cmd.CommandText = Sql
          Con.Open()
          Cmd.ExecuteNonQuery()
        End Using
      End Using

    Catch ex As Exception

    End Try

  End Sub
End Class
