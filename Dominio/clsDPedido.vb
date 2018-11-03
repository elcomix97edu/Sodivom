Imports Entidades
Imports Persistencia

Public Class clsDPedido
    Public Function AgregarPedido(unped As clsEPedido) As Boolean
        Dim unPc As New clsPPedidoDistribuidor
        Return unPc.AltaPedido(unped)
    End Function

    Public Function ListarPedido(parametro As String, busqueda As Integer) As List(Of clsEPedido)
        Dim unPc As New clsPPedidoDistribuidor
        Return unPc.listarPedido(parametro, busqueda)
    End Function

    Public Function EliminarPedido(id As Integer) As Boolean
        Dim unPc As New clsPPedidoDistribuidor
        Return unPc.eliminarpedido(id)
    End Function

    Public Function ModificarPedido(Pedido As clsEPedido) As Boolean
        Dim unPC As New clsPPedidoDistribuidor
        Return unPC.modificarpedido(Pedido)
    End Function

    Public Function ExistePedido(id As Integer) As Boolean
        Dim per As New clsPPedidoDistribuidor
        Return per.existe(id)
    End Function

End Class
