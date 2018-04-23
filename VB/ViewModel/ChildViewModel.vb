Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations

Namespace Example.ViewModel
    Public Class ChildViewModel
        <ServiceProperty(SearchMode:=ServiceSearchMode.PreferParents)> _
        Protected Overridable ReadOnly Property MessageBoxService() As IMessageBoxService
            Get
                Return Nothing
            End Get
        End Property
        Public Sub ShowMessage()
            MessageBoxService.Show("This is ChildView")
        End Sub
    End Class
End Namespace
