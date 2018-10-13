Imports Entidades
Imports Persistencia

Public Class clsDStock
    Dim unSt As New clsPStock
    Public Function AgregarStock(unstock As clsEStock) As Boolean
        Return unSt.AltaStock(unstock)
    End Function

    Public Function ListarStock(parametro As String, busqueda As Integer) As List(Of clsEStock)
        Return unSt.listarStock(parametro, busqueda)
    End Function

    Public Function EliminarStock(codigo As Integer) As Boolean
        Return unSt.eliminarstock(codigo)
    End Function

    Public Function ModificarStock(stock As clsEStock) As Boolean
        Return unSt.modificarStock(stock)
    End Function

    Public Function ExisteStock(Stock As clsEStock) As Boolean
        Return unSt.existe(Stock)
    End Function
End Class
