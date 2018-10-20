Imports System.Web.Script.Serialization
Partial Class EF_qcmctRequest
  Inherits SIS.SYS.UpdateBase

  Public Property POWeight() As Decimal
    Get
      If ViewState("POWeight") IsNot Nothing Then
        Return CType(ViewState("POWeight"), Decimal)
      End If
      Return True
    End Get
    Set(ByVal value As Decimal)
      ViewState.Add("POWeight", value)
    End Set
  End Property
  Public Property Editable() As Boolean
    Get
      If ViewState("Editable") IsNot Nothing Then
        Return CType(ViewState("Editable"), Boolean)
      End If
      Return True
    End Get
    Set(ByVal value As Boolean)
      ViewState.Add("Editable", value)
    End Set
  End Property
  Public Property Deleteable() As Boolean
    Get
      If ViewState("Deleteable") IsNot Nothing Then
        Return CType(ViewState("Deleteable"), Boolean)
      End If
      Return True
    End Get
    Set(ByVal value As Boolean)
      ViewState.Add("Deleteable", value)
    End Set
  End Property
  Public Property PrimaryKey() As String
    Get
      If ViewState("PrimaryKey") IsNot Nothing Then
        Return CType(ViewState("PrimaryKey"), String)
      End If
      Return True
    End Get
    Set(ByVal value As String)
      ViewState.Add("PrimaryKey", value)
    End Set
  End Property
  Protected Sub ODSqcmctRequest_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles ODSqcmctRequest.Selected
    Dim tmp As SIS.QCMCT.qcmctRequest = CType(e.ReturnValue, SIS.QCMCT.qcmctRequest)
    Editable = tmp.Editable
    Deleteable = tmp.Deleteable
    PrimaryKey = tmp.PrimaryKey
    POWeight = SIS.QCM.qcmRequests.qcmRequestsGetByID(tmp.QCRequestNo).POWeight
  End Sub
  Protected Sub FVqcmctRequest_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmctRequest.Init
    DataClassName = "EqcmctRequest"
    SetFormView = FVqcmctRequest
  End Sub
  Protected Sub TBLqcmctRequest_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles TBLqcmctRequest.Init
    SetToolBar = TBLqcmctRequest
  End Sub
  Protected Sub FVqcmctRequest_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles FVqcmctRequest.PreRender
    TBLqcmctRequest.EnableSave = Editable
    TBLqcmctRequest.EnableDelete = Deleteable
    Dim mStr As String = ""
    Dim oTR As IO.StreamReader = New IO.StreamReader(HttpContext.Current.Server.MapPath("~/QCMCT_Main/App_Edit") & "/EF_qcmctRequest.js")
    mStr = oTR.ReadToEnd
    oTR.Close()
    oTR.Dispose()
    If Not Page.ClientScript.IsClientScriptBlockRegistered("scriptqcmctRequest") Then
      Page.ClientScript.RegisterClientScriptBlock(GetType(System.String), "scriptqcmctRequest", mStr)
    End If
  End Sub

End Class
