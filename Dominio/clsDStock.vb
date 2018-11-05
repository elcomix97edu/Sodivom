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

    Public Function EliminarStock(codigo As String) As Boolean
        Return unSt.eliminarstock(codigo)
    End Function

    Public Function ModificarStock(stock As clsEStock) As Boolean
        Return unSt.modificarStock(stock)
    End Function

    Public Function ExisteStock(Stock As clsEStock) As Boolean
        Return unSt.existe(Stock)
    End Function

    Public Function GetStocksProd(idprod As String) As List(Of clsEStock)
        Return unSt.GetStocksProd(idprod)
    End Function

    Public Function SumStock(idprod As String) As Integer
        Return unSt.SumStock(idprod)
    End Function
End Class
