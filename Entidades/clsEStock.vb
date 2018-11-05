Public Class clsEStock
    Private mcodigo As String
    Private mstock As Integer
    Private mfechaing As Date
    Private mfechaven As Date
    Private mid As Integer

    Public Property codigoprod As String
        Get
            Return mcodigo
        End Get
        Set(value As String)
            mcodigo = value
        End Set
    End Property

    Public Property stock As String
        Get
            Return mstock
        End Get
        Set(value As String)
            mstock = value
        End Set
    End Property

    Public Property fechaing As Date
        Get
            Return mfechaing
        End Get
        Set(value As Date)
            mfechaing = value
        End Set
    End Property

    Public Property fechaven As Date
        Get
            Return mfechaven
        End Get
        Set(value As Date)
            mfechaven = value
        End Set
    End Property

    Public Property id As String
        Get
            Return mid
        End Get
        Set(value As String)
            mid = value
        End Set
    End Property
End Class
