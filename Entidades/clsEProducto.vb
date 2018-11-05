Public Class clsEProducto
    Private mcodigo As String
    Private mnombre As String
    Private mdescripcion As String
    Private mprecio As Integer
    Private mminstock As Integer

    Public Property codigo As String
        Get
            Return mcodigo
        End Get
        Set(value As String)
            mcodigo = value
        End Set
    End Property

    Public Property nombre As String
        Get
            Return mnombre
        End Get
        Set(value As String)
            mnombre = value
        End Set
    End Property

    Public Property descripcion As String
        Get
            Return mdescripcion
        End Get
        Set(value As String)
            mdescripcion = value
        End Set
    End Property

    Public Property precio As Integer
        Get
            Return mprecio
        End Get
        Set(value As Integer)
            mprecio = value
        End Set
    End Property
    Public Property minstock As Integer
        Get
            Return mminstock
        End Get
        Set(value As Integer)
            mminstock = value
        End Set
    End Property

End Class
