Imports System.Data
Imports System.Data.SqlClient

Partial Class QcmCallInspected
  Inherits System.Web.UI.Page
  Protected Function CreateLog() As Boolean
    Dim Blocked As Boolean = False
    Dim Prop As String = ""
    Dim head As String = ""
    Dim Req As String = ""
    Dim emp As String = ""
    Dim action As String = ""
    Dim mMailID As String = "0"
    Dim mLinkID As String = "0"

    For Each pi As System.Reflection.PropertyInfo In Request.GetType.GetProperties
      If pi.MemberType = Reflection.MemberTypes.Property Then
        Try
          Prop &= "<br/> " & pi.Name & " : " & pi.GetValue(Request, Nothing)
        Catch ex As Exception
        End Try
      End If
    Next
    For I As Integer = 0 To Request.Headers.Count - 1
      head &= "<br/> " & Request.Headers.Keys(I) & " : " & Request.Headers.Item(I)
    Next
    If Request.QueryString.Count > 0 Then
      If Request.QueryString.Keys(0).ToLower <> "emp" Then
        action = Request.QueryString.Keys(0)
        Req = Request.QueryString.Item(0)
        If Request.QueryString("emp") IsNot Nothing Then
          emp = Request.QueryString("emp")
        End If
      Else
        action = "Pending"
        Req = 0
        If Request.QueryString("emp") IsNot Nothing Then
          emp = Request.QueryString("emp")
        End If
      End If
    End If
    Dim RemoteIP As String = ""
    Dim ip As String = String.Empty
    ip = Request.ServerVariables("HTTP_X_FORWARDED_FOR")
    If Not String.IsNullOrEmpty(ip) Then
      Dim ipRange As String() = ip.Split(","c)
      Dim le As Integer = ipRange.Length - 1
      RemoteIP = ipRange(le)
    Else
      RemoteIP = Request.ServerVariables("REMOTE_ADDR")
    End If
    mMailID = Request.QueryString("MailID")
    mLinkID = Request.QueryString("LinkID")

    If head.Trim.StartsWith("<br/> Accept : */*") Then
      Blocked = True
    End If

    Dim mSql As String = " INSERT QCM_Log "
    mSql &= " ("
    mSql &= " UserID,"
    mSql &= " Action,"
    mSql &= " RequestID,"
    mSql &= " LoggedOn,"
    mSql &= " RequestProp,"
    mSql &= " RequestHeader,"
    mSql &= " MailSrNo,"
    mSql &= " LinkSrNo"
    mSql &= " )"
    mSql &= " VALUES ("
    mSql &= "'" & emp & "',"
    mSql &= "'" & action & "',"
    mSql &= Req & ",GetDate()"
    mSql &= ",'" & Prop & "',"
    If Blocked Then
      mSql &= "'BLOCKED " & head & "REMOTE_ADDRESS : " & RemoteIP & "',"
    Else
      mSql &= "'" & head & "REMOTE_ADDRESS : " & RemoteIP & "',"
    End If
    mSql &= mMailID & ","
    mSql &= mLinkID
    mSql &= ")"
    Using Con As SqlConnection = New SqlConnection(SIS.SYS.SQLDatabase.DBCommon.GetConnectionString())
      Using Cmd As SqlCommand = Con.CreateCommand()
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = mSql
        Con.Open()
        Cmd.ExecuteNonQuery()
      End Using
    End Using
    Return Blocked
  End Function

  Private Sub QcmCallInspected_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
    Dim Blocked As Boolean = False
    Try
      Blocked = CreateLog()
    Catch ex As Exception
      Dim xx As String = ex.Message
    End Try
    If Blocked Then Exit Sub
    Dim typ As String = ""
    Dim Action As String = ""
    Dim RequestID As String = ""
    Dim Emp As String = "0340"
    If Request.QueryString("start") IsNot Nothing Then
      If Request.QueryString("start").ToString <> String.Empty Then
        RequestID = Request.QueryString("start")
        Action = "Start"
      End If
    End If
    If Request.QueryString("pause") IsNot Nothing Then
      If Request.QueryString("pause").ToString <> String.Empty Then
        RequestID = Request.QueryString("pause")
        Action = "Pause"
      End If
    End If
    If Request.QueryString("resume") IsNot Nothing Then
      If Request.QueryString("resume").ToString <> String.Empty Then
        RequestID = Request.QueryString("resume")
        Action = "Resume"
      End If
    End If
    If Request.QueryString("stop") IsNot Nothing Then
      If Request.QueryString("stop").ToString <> String.Empty Then
        RequestID = Request.QueryString("stop")
        Action = "Stop"
      End If
    End If
    If Request.QueryString("emp") IsNot Nothing Then
      If Request.QueryString("emp").ToString <> String.Empty Then
        Emp = Request.QueryString("emp")
      End If
    End If

    Select Case Action.ToLower
      Case "start"
        Try
          Dim mErr As Boolean = False
          Dim emsg As String = ""
          HttpContext.Current.Session("LoginID") = Emp
          Dim tmp As SIS.QCM.qcmRequestAllotment = SIS.QCM.qcmRequestAllotment.qcmRequestAllotmentGetByID(RequestID)
          If tmp.AllotedTo <> Emp Then
            mErr = True
            emsg = "Inspection Call is re-alloted to someone else."
          Else
            Select Case tmp.RequestStateID
              Case "ALLOTED", "REALLOTED"
              Case "INSPECTED"
                mErr = True
                emsg = "Inspection already started"
              Case "CLOSED"
                mErr = True
                emsg = "Inspection is closed"
            End Select
          End If
          If Not mErr Then
            HttpContext.Current.Session("LoginID") = tmp.AllotedTo
            Dim mRet As String = ""
            mRet = SIS.QCM.qcmRequestAllotment.RequestStarted(tmp.RequestID)
            If mRet = String.Empty Then
              msg.Text = "<h1>Started successfully.</h1>"
            End If
          Else
            msg.Text = "<h1>" & emsg & "</h1>"
          End If
        Catch ex As Exception
          msg.Text = ex.Message
        End Try
      Case "pause"
        Try
          Dim mErr As Boolean = False
          Dim emsg As String = ""
          HttpContext.Current.Session("LoginID") = Emp
          Dim tmp As SIS.QCM.qcmRequestAllotment = SIS.QCM.qcmRequestAllotment.qcmRequestAllotmentGetByID(RequestID)
          If tmp.AllotedTo <> Emp Then
            mErr = True
            emsg = "Inspection Call is re-alloted to someone else."
          Else
            Select Case tmp.RequestStateID
              Case "ALLOTED", "REALLOTED"
                mErr = True
                emsg = "Inspection not started"
              Case "INSPECTED"
                If tmp.Paused Then
                  mErr = True
                  emsg = "Inspection already paused"
                End If
              Case "CLOSED"
                mErr = True
                emsg = "Inspection is closed"
            End Select
          End If
          If Not mErr Then
            HttpContext.Current.Session("LoginID") = tmp.AllotedTo
            Dim mRet As String = ""
            mRet = SIS.QCM.qcmRequestAllotment.RequestPaused(tmp.RequestID)
            If mRet = String.Empty Then
              msg.Text = "<h1>Paused successfully.</h1>"
            End If
          Else
            msg.Text = "<h1>" & emsg & "</h1>"
          End If
        Catch ex As Exception
          msg.Text = ex.Message
        End Try
      Case "resume"
        Try
          Dim mErr As Boolean = False
          Dim emsg As String = ""
          HttpContext.Current.Session("LoginID") = Emp
          Dim tmp As SIS.QCM.qcmRequestAllotment = SIS.QCM.qcmRequestAllotment.qcmRequestAllotmentGetByID(RequestID)
          If tmp.AllotedTo <> Emp Then
            mErr = True
            emsg = "Inspection Call is re-alloted to someone else."
          Else
            Select Case tmp.RequestStateID
              Case "ALLOTED", "REALLOTED"
                mErr = True
                emsg = "Inspection not started"
              Case "INSPECTED"
                If Not tmp.Paused Then
                  mErr = True
                  emsg = "Inspection not paused"
                End If
              Case "CLOSED"
                mErr = True
                emsg = "Inspection is closed"
            End Select
          End If
          If Not mErr Then
            HttpContext.Current.Session("LoginID") = tmp.AllotedTo
            Dim mRet As String = ""
            mRet = SIS.QCM.qcmRequestAllotment.RequestResumed(tmp.RequestID)
            If mRet = String.Empty Then
              msg.Text = "<h1>Resumed successfully.</h1>"
            End If
          Else
            msg.Text = "<h1>" & emsg & "</h1>"
          End If
        Catch ex As Exception
          msg.Text = ex.Message
        End Try
      Case "stop"
        Try
          Dim mErr As Boolean = False
          Dim emsg As String = ""
          HttpContext.Current.Session("LoginID") = Emp
          Dim mRet As String = ""
          Dim tmp As SIS.QCM.qcmRequestAllotment = SIS.QCM.qcmRequestAllotment.qcmRequestAllotmentGetByID(RequestID)
          Select Case tmp.RequestStateID
            Case "ALLOTED", "REALLOTED"
              mErr = True
              emsg = "Inspection not started"
            Case "INSPECTED"
            Case "CLOSED"
              mErr = True
              emsg = "Inspection already closed"
          End Select
          If Not mErr Then
            HttpContext.Current.Session("LoginID") = tmp.AllotedTo
            mRet = SIS.QCM.qcmRequestAllotment.RequestClosed(tmp.RequestID)
            If mRet = String.Empty Then
              msg.Text = "<h1>Closed successfully.</h1>"
            End If
          Else
            msg.Text = "<h1>" & emsg & "</h1>"
          End If
        Catch ex As Exception
          msg.Text = ex.Message
        End Try
    End Select
    If Emp <> "" AndAlso Emp <> "0340" Then
      Try
        HttpContext.Current.Session("LoginID") = Emp
        Dim mRet As String = SIS.QCM.qcmRequestAllotment.SendPendingCallEMail(Emp)
        If mRet = String.Empty Then
          If Action = "" Then
            msg.Text = "<h1>Request submitted successfully.</h1>"
          End If
        End If
      Catch ex As Exception
        msg.Text = ex.Message
      End Try
    End If
    If SIS.SYS.Utilities.ApplicationSpacific.IsTesting Then
      Try
        HttpContext.Current.Session("LoginID") = Emp
        Dim mRet As String = SIS.QCM.qcmRequestAllotment.SendPendingCallEMail(Emp)
        If mRet = String.Empty Then
          If Action = "" Then
            msg.Text = "<h1>Request submitted successfully.</h1>"
          End If
        End If
      Catch ex As Exception
        msg.Text = ex.Message
      End Try
    End If
  End Sub
End Class
