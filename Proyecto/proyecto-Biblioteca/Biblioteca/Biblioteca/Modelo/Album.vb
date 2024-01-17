Imports Microsoft.VisualBasic

Public Class Album
    Private _id As System.Int32
    Private _autor As System.String
    Private _titulo As System.String
    Private _año As System.Int32

    Property id As Integer
        Get
            Return _id
        End Get
        Set
            _id = Value
        End Set
    End Property

    Property autor As String
        Get
            Return _autor
        End Get
        Set
            _autor = Value
        End Set
    End Property

    Property titulo As String
        Get
            Return _titulo
        End Get
        Set
            _titulo = Value
        End Set
    End Property

    Property año As Integer
        Get
            Return _año
        End Get
        Set
            _año = Value
        End Set
    End Property

    Public Sub New(id As Integer, autor As String, titulo As String, año As Integer)
        Me.id = id
        Me.autor = autor
        Me.titulo = titulo
        Me.año = año
    End Sub
End Class
