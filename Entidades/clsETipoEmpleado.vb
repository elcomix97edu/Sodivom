Public Class clsETipoEmpleado
    Private mid As Integer
    Private mtipoEmpleado As String

    Public Property id As Integer
        Get
            Return mid
        End Get
        Set(value As Integer)
            mid = value
        End Set
    End Property

    Public Property tipoEmpleado As String
        Get
            Return mtipoEmpleado
        End Get
        Set(value As String)
            mtipoEmpleado = value
        End Set
    End Property
End Class
