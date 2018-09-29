Public Class clsEEmpleado
    Inherits clsEPersona

    Private mcontrseña As String
    Private msueldo As Integer
    Private mtipoEmpleado As Integer

    Public Property contrseña As String
        Get
            Return mcontrseña
        End Get
        Set(value As String)
            mcontrseña = value
        End Set
    End Property

    Public Property sueldo As Integer
        Get
            Return msueldo
        End Get
        Set(value As Integer)
            msueldo = value
        End Set
    End Property

    Public Property tipoEmpleado As Integer
        Get
            Return mtipoEmpleado
        End Get
        Set(value As Integer)
            mtipoEmpleado = value
        End Set
    End Property

End Class
