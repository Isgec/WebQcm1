Public Class SimpleTemplateItem
  Inherits Control
  Implements INamingContainer
  Implements IDataItemContainer

  Private _tmpDataItem As Object = Nothing
  Public Sub New(ByVal tmpItem As Object)
    _tmpDataItem = tmpItem
  End Sub
  Public Sub New()
    'dummy  
  End Sub

  Public ReadOnly Property DataItem As Object Implements IDataItemContainer.DataItem
    Get
      Return _tmpDataItem
    End Get
  End Property

  Public ReadOnly Property DataItemIndex As Integer Implements IDataItemContainer.DataItemIndex
    Get
      Return 0
    End Get
  End Property

  Public ReadOnly Property DisplayIndex As Integer Implements IDataItemContainer.DisplayIndex
    Get
      Return 0
    End Get
  End Property
End Class