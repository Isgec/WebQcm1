Imports System
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.UserControl
Imports System.Web.UI.HtmlControls
Imports System.Collections

Partial Class lgTemplate
  Inherits System.Web.UI.UserControl

  <TemplateContainer(GetType(SimpleTemplateItem))>
  Public Property ItemTemplate As ITemplate
  <TemplateContainer(GetType(SimpleTemplateItem))>
  Public Property AlternateItemTemplate As ITemplate
  <TemplateContainer(GetType(SimpleTemplateItem))>
  Public Property HeaderTemplate As ITemplate
  <TemplateContainer(GetType(SimpleTemplateItem))>
  Public Property FooterTemplate As ITemplate

  <TemplateContainer(GetType(SimpleTemplateItem))>
  Public Property Flip1Template As ITemplate

  <TemplateContainer(GetType(SimpleTemplateItem))>
  Public Property Flip2Template As ITemplate


  Public Property DataSource As IEnumerable

  Public Property ShowFlip1 As Boolean = False
  Public Property ShowFlip2 As Boolean = False

  Public Sub Show1()
    AddTemplateAsControl(Flip1Template, Nothing)
  End Sub
  Public Sub Show2()
    AddTemplateAsControl(Flip2Template, Nothing)
  End Sub
  Public Overrides Sub DataBind()
    If _DataSource Is Nothing Then Exit Sub
    If ShowFlip1 Then
      AddTemplateAsControl(Flip1Template, Nothing)
    End If
    If ShowFlip2 Then
      AddTemplateAsControl(Flip2Template, Nothing)
    End If
    AddTemplateAsControl(HeaderTemplate, Nothing)
    Dim ie As IEnumerator = DataSource.GetEnumerator
    Dim renderAlternateTemplate As Boolean = False
    While ie.MoveNext
      If renderAlternateTemplate AndAlso AlternateItemTemplate IsNot Nothing Then
        AddTemplateAsControl(ItemTemplate, ie.Current)
      ElseIf AlternateItemTemplate IsNot Nothing Then
        AddTemplateAsControl(AlternateItemTemplate, ie.Current)
      Else
        'nothing to render
      End If
      renderAlternateTemplate = Not renderAlternateTemplate
    End While
    AddTemplateAsControl(FooterTemplate, Nothing)
    MyBase.DataBind()
  End Sub
  Private Sub AddTemplateAsControl(ByVal anyTemplate As ITemplate, currentItem As Object)
    Dim tcHolder As SimpleTemplateItem = New SimpleTemplateItem(currentItem)
    anyTemplate.InstantiateIn(tcHolder)
    Me.Controls.Add(tcHolder)
  End Sub
End Class

