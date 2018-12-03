Imports System.Web.Script.Serialization
Partial Class mG_qcmI
  Inherits System.Web.UI.Page
  Private Sub ODSqcmRequestAllotment_Selecting(sender As Object, e As ObjectDataSourceSelectingEventArgs) Handles ODSqcmRequestAllotment.Selecting
    '1. Check To Search
    If e.InputParameters("SearchText") Is Nothing Then e.InputParameters("SearchText") = ""
    If e.InputParameters("SearchText") <> "" Then
      e.InputParameters("SearchState") = True
    End If
  End Sub
  Private Sub GVqcmRequestAllotment_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles GVqcmRequestAllotment.RowCommand
    If e.CommandName.ToLower = "cmdStart".ToLower Then
      Dim RequestID As Integer = GVqcmRequestAllotment.DataKeys(e.CommandArgument).Value
      Dim mRet As String = ""
      Try
        mRet = SIS.QCM.qcmRequestAllotment.RequestStarted(RequestID)
        If mRet <> String.Empty Then
          ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(mRet) & "');", True)
        End If
        GVqcmRequestAllotment.DataBind()
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
    If e.CommandName.ToLower = "cmdData".ToLower Then
      Dim RequestID As Integer = GVqcmRequestAllotment.DataKeys(e.CommandArgument).Value
      Dim mRet As String = ""
      Try
        Dim RedirectURL As String = "~/QcmData.aspx?data=" & RequestID & "&src=mapp&emp=" & HttpContext.Current.Session("LoginID")
        Response.Redirect(RedirectURL)
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
    If e.CommandName.ToLower = "cmdPause".ToLower Then
      Dim RequestID As Integer = GVqcmRequestAllotment.DataKeys(e.CommandArgument).Value
      Dim mRet As String = ""
      Try
        mRet = SIS.QCM.qcmRequestAllotment.RequestPaused(RequestID)
        If mRet <> String.Empty Then
          ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(mRet) & "');", True)
        End If
        GVqcmRequestAllotment.DataBind()
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
    If e.CommandName.ToLower = "cmdResume".ToLower Then
      Dim RequestID As Integer = GVqcmRequestAllotment.DataKeys(e.CommandArgument).Value
      Dim mRet As String = ""
      Try
        mRet = SIS.QCM.qcmRequestAllotment.RequestResumed(RequestID)
        If mRet <> String.Empty Then
          ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(mRet) & "');", True)
        End If
        GVqcmRequestAllotment.DataBind()
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
    If e.CommandName.ToLower = "cmdClose".ToLower Then
      Dim RequestID As Integer = GVqcmRequestAllotment.DataKeys(e.CommandArgument).Value
      Dim mRet As String = ""
      Try
        mRet = SIS.QCM.qcmRequestAllotment.RequestClosed(RequestID)
        If mRet <> String.Empty Then
          ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(mRet) & "');", True)
        End If
        GVqcmRequestAllotment.DataBind()
      Catch ex As Exception
        ScriptManager.RegisterClientScriptBlock(Page, Page.GetType(), "", "alert('" & New JavaScriptSerializer().Serialize(ex.Message) & "');", True)
      End Try
    End If
  End Sub

  Private Sub mG_qcmI_Init(sender As Object, e As EventArgs) Handles Me.Init
    HttpContext.Current.Session("LoginID") = Request.QueryString("LoginID")
  End Sub
End Class
