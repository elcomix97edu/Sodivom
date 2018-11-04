Public Class clsEPedido
    Private mid As Integer
    Private mdescripcion As String
    Private mfecha As Date
    Private mimporte As Integer

    Public Property id As Integer
        Get
            Return mid
        End Get
        Set(value As Integer)
            mid = value
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

    Public Property fecha As Date
        Get
            Return mfecha
        End Get
        Set(value As Date)
            mfecha = value
        End Set
    End Property

    Public Property importe As Integer
        Get
            Return mimporte
        End Get
        Set(value As Integer)
            mimporte = value
        End Set
    End Property

End Class
