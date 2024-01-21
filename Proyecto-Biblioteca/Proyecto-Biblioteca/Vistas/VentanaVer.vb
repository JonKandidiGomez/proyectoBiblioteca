Public Class VentanaVer

    Private gestor As New Controlador()
    Private albums = gestor.albums

    Private Sub VentanaVer_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim i = 1

        For Each album In albums
            Dim nuevoControl As New MiControl(album)
            AddHandler nuevoControl.bEditarClick, AddressOf MiControl_bEditarClick
            AddHandler nuevoControl.bBorrarClick, AddressOf MiControl_bBorrarClick
            nuevoControl.Location = New Point(10, (nuevoControl.Height + 10) * (i - 1))
            pDatos.Controls.Add(nuevoControl)
            i += 1
        Next
    End Sub

    Private Sub MiControl_bEditarClick(sender As Object, e As EventArgs)

    End Sub

    Private Sub MiControl_bBorrarClick(sender As Object, e As EventArgs)

    End Sub
End Class