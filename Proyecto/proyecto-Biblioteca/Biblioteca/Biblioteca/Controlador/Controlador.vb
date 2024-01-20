Public Class Controlador

    Property gestorBD As GestorBD
    Property albums As New List(Of Album)

    Public Sub New()
        gestorBD = New GestorBD()
        albums = gestorBD.cargarDatos()
    End Sub

    Private Sub borrarRegistro(id As Integer)
        GestorBD.borrarRegistro(id)
    End Sub

    Private Sub insertarRegirtro(album As Album)
        gestorBD.insertarRegistro(album)
    End Sub
End Class
