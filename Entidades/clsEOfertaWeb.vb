Public Class clsEOfertaWeb
    Private eProucto As Integer
    Private ePrecioOrig As Integer
    Private ePrecioOferta As Integer

    Public Property Proucto As Integer
        Get
            Return eProucto
        End Get
        Set(value As Integer)
            eProucto = value
        End Set
    End Property

    Public Property PrecioOrig As Integer
        Get
            Return ePrecioOrig
        End Get
        Set(value As Integer)
            ePrecioOrig = value
        End Set
    End Property

    Public Property PrecioOferta As Integer
        Get
            Return ePrecioOferta
        End Get
        Set(value As Integer)
            ePrecioOferta = value
        End Set
    End Property
End Class
