Imports controlBiblioteca

Public Class MiControl
    Inherits controlUsuario

    Private album As Album
    Public Event bEditarClick As EventHandler
    Public Event bBorrarClick As EventHandler

    Public Sub New()

    End Sub
    Public Sub New(album As Album)
        album = album
        titulo = album.titulo
        autor = album.autor
        año = album.año
    End Sub

    Private Function GetID()
        Return album.id
    End Function
End Class
