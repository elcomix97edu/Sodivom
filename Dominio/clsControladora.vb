Imports Entidades

Public Class clsControladora

    'cliente
    Public Function AgregarCliente(uncli As clsECliente) As Boolean
        Dim unDc As New clsDCliente
        Return unDc.AgregarCliente(uncli)
    End Function

    Public Function ListarCliente(parametro As String, usaci As Boolean) As List(Of clsECliente)
        Dim unDc As New clsDCliente
        Return unDc.listarCliente(parametro, usaci)
    End Function

    Public Function EliminarCliente(ci As Integer) As Boolean
        Dim unDc As New clsDCliente
        Return unDc.eliminarCliente(ci)
    End Function

    Public Function ModificarCliente(cliente As clsECliente) As Boolean
        Dim unDC As New clsDCliente
        Return unDC.modificarCliente(cliente)
    End Function


    'Empleado
    Public Function login(usuario As String, contrasenia As String) As Boolean
        Dim unPE As New clsDEmpleado
        Return unPE.login(usuario, contrasenia)
    End Function
End Class
