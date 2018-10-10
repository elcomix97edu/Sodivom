Imports Entidades
Public Class frmVenta
    Dim munempl As New clsEEmpleado

    Public Property unempl As clsEEmpleado
        Get
            Return munempl
        End Get
        Set(value As clsEEmpleado)
            munempl = value
        End Set
    End Property
End Class