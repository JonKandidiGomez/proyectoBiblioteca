Imports Microsoft.VisualBasic
Imports System.Data.SQLite

Public Class GestorBD

    Property conexion As SQLiteConnection

    Public Sub New()
        con = conectar()
    End Sub


    Private Function conectar()
        Dim con As SQLiteConnection = New SQLiteConnection(My.Settings.conexion)
        Try
            con.Open()
            Return con
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Function

    Private Function cargarDatos()

        Try
            Dim albums As New List(Of Album)

            Dim conexion = Me.conexion
            Dim consulta As String = String.format("SELECT * FROM ALBUM")

            conexion.Open()
            Dim cmd As New SQLiteCommand(consulta, conexion)

            Dim lector As SQLiteDataReader = cmd.ExecuteReader()
            While lector.Read()
                albums.Add(New Album(lector.GetInt16(0), lector.GetString(1), lector.GetString(2), lector.GetInt16(3))
            End While
            Return albums
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
End Class
