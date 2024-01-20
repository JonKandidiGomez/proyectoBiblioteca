Imports controlBiblioteca

Public Class VentanaVer

    Private albums As List(Of Album)
    Private gestor As New GestorBD


    Private Sub VentanaVer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        albums = gestor.cargarDatos()

    End Sub

    Private Sub ControlUsuario1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub pDatos_Paint(sender As Object, e As PaintEventArgs) Handles pDatos.Paint
        For Each album In albums
            Dim nuevoControl As New MiControl(album)
            nuevoControl.titulo = album.titulo
            nuevoControl.autor = album.autor
            nuevoControl.año = album.año


            pDatos.Controls.Add(nuevoControl)

        Next

    End Sub
End Class