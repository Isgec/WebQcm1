Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

<ValidationProperty("SelectedValue")> _
Partial Class LC_comFinanceCompany
  Inherits System.Web.UI.UserControl
  Private _OrderBy As String = String.Empty
  Private _IncludeDefault As Boolean = True
  Private _DefaultText As String = "-- Select --"
  Private _DefaultValue As String = String.Empty
  Public Event SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
  Public ReadOnly Property LCClientID() As String
    Get
      Return DDLcomFinanceCompany.ClientID
    End Get
  End Property
  Public Property AddAttributes() As String
    Get
      Return DDLcomFinanceCompany.Attributes.ToString
    End Get
    Set(ByVal value As String)
      Try
        Dim aVal() As String = value.Split(",".ToCharArray)
        DDLcomFinanceCompany.Attributes.Add(aVal(0), aVal(1))
      Catch ex As Exception
      End Try
    End Set
  End Property
  Public Property CssClass() As String
    Get
      Return DDLcomFinanceCompany.CssClass
    End Get
    Set(ByVal value As String)
      DDLcomFinanceCompany.CssClass = value
    End Set
  End Property
  Public Property Width() As System.Web.UI.WebControls.Unit
    Get
      Return DDLcomFinanceCompany.Width
    End Get
    Set(ByVal value As System.Web.UI.WebControls.Unit)
      DDLcomFinanceCompany.Width = value
    End Set
  End Property
  Public Property RequiredFieldErrorMessage() As String
    Get
      Return RequiredFieldValidatorcomFinanceCompany.Text
    End Get
    Set(ByVal value As String)
      If value = String.Empty Then
        RequiredFieldValidatorcomFinanceCompany.Enabled = False
      Else
        RequiredFieldValidatorcomFinanceCompany.Text = value
      End If
    End Set
  End Property
  Public Property ValidationGroup() As String
    Get
      Return RequiredFieldValidatorcomFinanceCompany.ValidationGroup
    End Get
    Set(ByVal value As String)
      RequiredFieldValidatorcomFinanceCompany.ValidationGroup = value
    End Set
  End Property
  Public Property Enabled() As Boolean
    Get
      Return DDLcomFinanceCompany.Enabled
    End Get
    Set(ByVal value As Boolean)
      DDLcomFinanceCompany.Enabled = value
      RequiredFieldValidatorcomFinanceCompany.Enabled = value
    End Set
  End Property
  Public Property AutoPostBack() As Boolean
    Get
      Return DDLcomFinanceCompany.AutoPostBack
    End Get
    Set(ByVal value As Boolean)
      DDLcomFinanceCompany.AutoPostBack = value
    End Set
  End Property
  Public Property DataTextField() As String
    Get
      Return DDLcomFinanceCompany.DataTextField
    End Get
    Set(ByVal value As String)
      DDLcomFinanceCompany.DataTextField = value
    End Set
  End Property
  Public Property DataValueField() As String
    Get
      Return DDLcomFinanceCompany.DataValueField
    End Get
    Set(ByVal value As String)
      DDLcomFinanceCompany.DataValueField = value
    End Set
  End Property
  Public Property SelectedValue() As String
    Get
      Return DDLcomFinanceCompany.SelectedValue
    End Get
    Set(ByVal value As String)
      If Convert.IsDBNull(value) Then
        DDLcomFinanceCompany.SelectedValue = String.Empty
      Else
        DDLcomFinanceCompany.SelectedValue = value
      End If
    End Set
  End Property
  Public Property OrderBy() As String
    Get
      Return _OrderBy
    End Get
    Set(ByVal value As String)
      _OrderBy = value
    End Set
  End Property
  Public Property IncludeDefault() As Boolean
    Get
      Return _IncludeDefault
    End Get
    Set(ByVal value As Boolean)
      _IncludeDefault = value
    End Set
  End Property
  Public Property DefaultText() As String
    Get
      Return _DefaultText
    End Get
    Set(ByVal value As String)
      _DefaultText = value
    End Set
  End Property
  Public Property DefaultValue() As String
    Get
      Return _DefaultValue
    End Get
    Set(ByVal value As String)
      _DefaultValue = value
    End Set
  End Property
  Protected Sub OdsDdlcomFinanceCompany_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceSelectingEventArgs) Handles OdsDdlcomFinanceCompany.Selecting
    e.Arguments.SortExpression = _OrderBy
  End Sub
  Protected Sub DDLcomFinanceCompany_DataBinding(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDLcomFinanceCompany.DataBinding
    If _IncludeDefault Then
      DDLcomFinanceCompany.Items.Add(new ListItem(_DefaultText, _DefaultValue))
    End If
    DDLcomFinanceCompany.Items.Add(New ListItem("REDECAM", "700"))
  End Sub
  Protected Sub DDLcomFinanceCompany_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDLcomFinanceCompany.SelectedIndexChanged
    HttpContext.Current.Session("FinanceCompany") = DDLcomFinanceCompany.SelectedValue
    RaiseEvent SelectedIndexChanged(sender, e)
  End Sub

  Private Sub DDLcomFinanceCompany_PreRender(sender As Object, e As EventArgs) Handles DDLcomFinanceCompany.PreRender
    Try
      DDLcomFinanceCompany.SelectedValue = HttpContext.Current.Session("FinanceCompany")
    Catch ex As Exception
      HttpContext.Current.Session("FinanceCompany") = "200"
      DDLcomFinanceCompany.SelectedValue = HttpContext.Current.Session("FinanceCompany")
    End Try
  End Sub
End Class
