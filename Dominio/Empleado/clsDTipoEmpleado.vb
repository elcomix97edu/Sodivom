Imports Persistencia
Imports Entidades
Public Class clsDTipoEmpleado
    Public Function AltaTipoEmpleado(tipo As String) As Boolean
        Dim unPte As New clsPTipoEmpleado
        Return unPte.AltaTipoEmpleado(tipo)
    End Function

    Public Function BajaTipoEmpleado(tipo As String) As Boolean
        Dim unPte As New clsPTipoEmpleado
        Return unPte.eliminarTipoEmpleado(tipo)
    End Function

    Public Function ListadoTipoEmpleado() As List(Of clsETipoEmpleado)
        Dim unPte As New clsPTipoEmpleado
        Return unPte.listarTipoEmpleado
    End Function

    Public Function ExisteTipoEmpleado(tipo As String) As Boolean
        Dim unPte As New clsPTipoEmpleado
        Return unPte.existe(tipo)
    End Function

End Class
