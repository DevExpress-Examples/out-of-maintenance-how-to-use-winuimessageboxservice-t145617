Imports DevExpress.Mvvm

Namespace Example.ViewModel

    Public Class MainViewModel

        Protected Overridable ReadOnly Property MessageBoxService As IMessageBoxService
            Get
                Return Nothing
            End Get
        End Property

        Public Sub ShowMessage()
            MessageBoxService.Show("This is MainView!")
        End Sub
    End Class
End Namespace
