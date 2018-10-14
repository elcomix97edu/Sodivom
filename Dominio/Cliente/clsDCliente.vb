Imports Persistencia
Imports Entidades

Public Class clsDCliente
    Public Function AgregarCliente(uncli As clsECliente) As Boolean
        Dim unPc As New clsPCliente
        Return unPc.AltaCliente(uncli)
    End Function

    Public Function ListarCliente(parametro As String, usaci As Boolean) As List(Of clsECliente)
        Dim unPc As New clsPCliente
        Return unPc.listarCliente(parametro, usaci)
    End Function

    Public Function ListarAllClientes() As List(Of clsECliente)
        Dim unPc As New clsPCliente
        Return unPc.listarallCliente()
    End Function

    Public Function EliminarCliente(ci As Integer) As Boolean
        Dim unPc As New clsPCliente
        Return unPc.eliminarCliente(ci)
    End Function

    Public Function ModificarCliente(cliente As clsECliente) As Boolean
        Dim unPC As New clsPCliente
        Return unPC.modificarCliente(cliente)
    End Function

    Public Function ExisteCliente(ci As Integer) As Boolean
        Dim per As New clsPCliente
        Return per.existe(ci)
    End Function

End Class
