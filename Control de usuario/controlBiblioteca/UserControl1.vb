Public Class controlUsuario

    Private Event ClickBotonMod()
    Private Event ClickBotonEliminar()
    Private _minimunSize As Size
    Private _titulo As String
    Private _autor As String
    Private _año As Integer

    Property titulo As String
        Get
            Return tbAlbum.Text
        End Get
        Set
            tbAlbum.Text = Value
        End Set
    End Property

    Property autor As String
        Get
            Return tbAutor.Text
        End Get
        Set
            tbAutor.Text = Value
        End Set
    End Property

    Property año As Integer
        Get
            Return tbAño.Text
        End Get
        Set
            tbAño.Text = Value
        End Set
    End Property

    Property minimunSize As Size
        Get
            Return _minimunSize
        End Get
        Set
            _minimunSize = New Size(583, 50)
        End Set
    End Property

    Overridable Sub bEditar_Click(sender As Object, e As EventArgs) Handles bEditar.Click
        RaiseEvent ClickBotonMod()
    End Sub

    Overridable Sub bBorrar_Click(sender As Object, e As EventArgs) Handles bBorrar.Click
        RaiseEvent ClickBotonEliminar()
    End Sub
End Class
