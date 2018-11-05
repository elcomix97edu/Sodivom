Public Class clsEDistribuidor
    Private mid As String
    Private mnombre As String
    Private mdescripcion As String
    Private mtelefono As String
    Private memail As String

    Public Property id As String
        Get
            Return mid
        End Get
        Set(value As String)
            mid = value
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

    Public Property telefono As String
        Get
            Return mtelefono
        End Get
        Set(value As String)
            mtelefono = value
        End Set
    End Property

    Public Property email As String
        Get
            Return memail
        End Get
        Set(value As String)
            memail = value
        End Set
    End Property
End Class
