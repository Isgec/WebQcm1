
Partial Class QcmData
  Inherits System.Web.UI.Page
  Dim DataUpdated As Boolean = False

  Private Sub FVqcmInspections_ItemCommand(sender As Object, e As FormViewCommandEventArgs) Handles FVqcmInspections.ItemCommand
    If e.CommandName = "cmdCancel" Then
      If Request.QueryString("src") IsNot Nothing Then
        Dim RedirectURL As String = "~/QCM_Main/App_Forms/mGqcmI.aspx?LoginID=" & HttpContext.Current.Session("LoginID")
        Response.Redirect(RedirectURL)
      End If
    End If
  End Sub

  Private Sub FVqcmInspections_ItemInserted(sender As Object, e As FormViewInsertedEventArgs) Handles FVqcmInspections.ItemInserted
    If Request.QueryString("src") IsNot Nothing Then
      Dim RedirectURL As String = "~/QCM_Main/App_Forms/mGqcmI.aspx?LoginID=" & HttpContext.Current.Session("LoginID")
      Response.Redirect(RedirectURL)
    End If
    maindiv.Visible = False
    If e.Exception IsNot Nothing Then
      msg.Text = e.Exception.Message
    Else
      msg.Text = "Updated Successfully"
    End If
    subDiv.Visible = True
    DataUpdated = True
  End Sub
  Private Sub QcmData_PreRender(sender As Object, e As EventArgs) Handles Me.PreRender
    If DataUpdated Then Exit Sub
    HttpContext.Current.Session("LoginID") = "0340"
    If Request.QueryString("data") IsNot Nothing Then
      Dim ReqID As String = Request.QueryString("data")
      Dim Comp As String = Request.QueryString("comp")
      If ReqID <> "" AndAlso Comp <> "" Then
        Dim mErr As Boolean = False
        Dim emsg As String = ""
        Dim tmp As SIS.QCM.qcmRequestAllotment = SIS.QCM.qcmRequestAllotment.qcmRequestAllotmentGetByID(ReqID, Comp)
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
          CType(FVqcmInspections.FindControl("F_RequestID"), TextBox).Text = tmp.RequestID
          CType(FVqcmInspections.FindControl("F_Company"), TextBox).Text = Comp
          If tmp.TotalRequestedQuantity.Trim = "" Then
            tmp.TotalRequestedQuantity = "0.00"
          End If
          If tmp.LotSize.Trim = "" Then
            tmp.LotSize = "0.00"
          End If
          Dim roq As RequiredFieldValidator = CType(FVqcmInspections.FindControl("RFVOfferedQuantity"), RequiredFieldValidator)
          Dim riq As RequiredFieldValidator = CType(FVqcmInspections.FindControl("RFVInspectedQuantity"), RequiredFieldValidator)
          Dim rcq As RequiredFieldValidator = CType(FVqcmInspections.FindControl("RFVClearedQuantity"), RequiredFieldValidator)
          Dim roqf As RequiredFieldValidator = CType(FVqcmInspections.FindControl("RFVOfferedQuantityFinal"), RequiredFieldValidator)
          Dim riqf As RequiredFieldValidator = CType(FVqcmInspections.FindControl("RFVInspectedQuantityFinal"), RequiredFieldValidator)
          Dim rcqf As RequiredFieldValidator = CType(FVqcmInspections.FindControl("RFVClearedQuantityFinal"), RequiredFieldValidator)
          Dim oq As TextBox = CType(FVqcmInspections.FindControl("F_OfferedQuantity"), TextBox)
          Dim iq As TextBox = CType(FVqcmInspections.FindControl("F_InspectedQuantity"), TextBox)
          Dim cq As TextBox = CType(FVqcmInspections.FindControl("F_ClearedQuantity"), TextBox)
          Dim oqf As TextBox = CType(FVqcmInspections.FindControl("F_OfferedQuantityFinal"), TextBox)
          Dim iqf As TextBox = CType(FVqcmInspections.FindControl("F_InspectedQuantityFinal"), TextBox)
          Dim cqf As TextBox = CType(FVqcmInspections.FindControl("F_ClearedQuantityFinal"), TextBox)
          Try
            CType(FVqcmInspections.FindControl("F_UOM"), DropDownList).SelectedValue = tmp.UOM
          Catch ex As Exception
          End Try
          Try
            oq.Text = tmp.TotalRequestedQuantity
          Catch ex As Exception
          End Try
          Try
            iq.Text = tmp.TotalRequestedQuantity
          Catch ex As Exception
          End Try
          Try
            cq.Text = tmp.TotalRequestedQuantity
          Catch ex As Exception
          End Try
          Try
            oqf.Text = tmp.LotSize
          Catch ex As Exception
          End Try
          Try
            iqf.Text = tmp.LotSize
          Catch ex As Exception
          End Try
          Try
            cqf.Text = tmp.LotSize
          Catch ex As Exception
          End Try
          If tmp.InspectionStatusID = "1" Then
            oqf.Enabled = False
            iqf.Enabled = False
            cqf.Enabled = False
            roqf.Enabled = False
            riqf.Enabled = False
            rcqf.Enabled = False
          End If
          If tmp.InspectionStatusID = "2" Then
            oq.Enabled = False
            iq.Enabled = False
            cq.Enabled = False
            roq.Enabled = False
            riq.Enabled = False
            rcq.Enabled = False
          End If
        Else
          maindiv.Visible = False
          msg.Text = emsg
          subDiv.Visible = True
        End If
      End If
    End If


  End Sub
End Class
