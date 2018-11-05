Imports Persistencia
Imports Entidades

Public Class clsDEmpleado
    Public Function login(ci As String, contrasenia As String) As clsEEmpleado
        Dim unPE As New clsPEmpleado
        Return unPE.login(ci, contrasenia)
    End Function

    Public Function AgregarEmpleado(unempl As clsEEmpleado) As Boolean
        Dim unPE As New clsPEmpleado
        Return unPE.AltaEmpleado(unempl)
    End Function

    Public Function ListarEmpleado(parametro As String, busqueda As Integer) As List(Of clsEEmpleado)
        Dim unPE As New clsPEmpleado
        Return unPE.listarEmpleado(parametro, busqueda)
    End Function

    Public Function EliminarEmpleado(ci As Integer) As Boolean
        Dim unPE As New clsPEmpleado
        Return unPE.eliminarEmpleado(ci)
    End Function

    Public Function ModificarEmpleado(unempl As clsEEmpleado) As Boolean
        Dim unPE As New clsPEmpleado
        Return unPE.modificarEmpleado(unempl)
    End Function

    Public Function ExisteEmpleado(ci As Integer) As Boolean
        Dim unPE As New clsPEmpleado
        Return unPE.existe(ci)
    End Function

    Public Function ExistePersona(ci As Integer) As Boolean
        Dim unPE As New clsPEmpleado
        Return unPE.existePersona(ci)
    End Function
End Class
