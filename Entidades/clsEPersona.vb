Public Class clsEPersona
    Private mci As Integer
    Private mtelefono As String
    Private mnombre As String
    Private mapellido As String
    Private mdir As String
    Private memail As String

    Public Property ci As Integer
        Get
            Return mci
        End Get
        Set(value As Integer)
            mci = value
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

    Public Property nombre As String
        Get
            Return mnombre
        End Get
        Set(value As String)
            mnombre = value
        End Set
    End Property

    Public Property apellido As String
        Get
            Return mapellido
        End Get
        Set(value As String)
            mapellido = value
        End Set
    End Property

    Public Property direccion As String
        Get
            Return mdir
        End Get
        Set(value As String)
            mdir = value
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
