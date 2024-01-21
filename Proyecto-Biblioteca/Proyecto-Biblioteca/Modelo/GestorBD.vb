Imports System.Data.SQLite

Public Class GestorBD

    Property conexion As SQLiteConnection

    Public Sub New()
        conexion = conectar()
    End Sub


    Private Function conectar()
        Dim con As SQLiteConnection = New SQLiteConnection(My.Settings.conexion)
        Try
            con.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        Return con
    End Function

    Public Function cargarDatos()

        Dim albums As New List(Of Album)
        Try
            Dim consulta As String = String.Format("SELECT * FROM ALBUM")

            Me.conexion.Open()
            Dim cmd As New SQLiteCommand(consulta, Me.conexion)
            Dim lector As SQLiteDataReader = cmd.ExecuteReader()

            While lector.Read()
                albums.Add(New Album(lector.GetInt64(0), lector.GetString(1), lector.GetString(2), lector.GetInt64(3)))
            End While
            lector.Close()
            Me.conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return albums

    End Function

    Public Sub insertarRegistro(album As Album)

        Try
            Dim sql As String = "INSERT INTO ALBUM (ID, TITULO, AUTOR, ANYO) VALUES (@id, @titulo, @autor, @anyo);"
            Dim con = Me.conexion
            con.Open()
            Dim cmd As New SQLiteCommand(sql, con)

            cmd.Parameters.Add("@id", DbType.String).Value = album.id
            cmd.Parameters.Add("@titulo", DbType.String).Value = album.titulo
            cmd.Parameters.Add("@autor", DbType.String).Value = album.autor
            cmd.Parameters.Add("@anyo", DbType.String).Value = album.año
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message & " No se inserta el album")
        End Try
    End Sub



    Public Sub borrarRegistro(id As Integer)
        Dim sql As String = String.Format("DELETE FROM ALBUM WHERE ID = {0}", id)

        Try
            Dim cmd As New SQLiteCommand(sql, Me.conexion)
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message & "No se ha borrado el registro")
        End Try
    End Sub
End Class
