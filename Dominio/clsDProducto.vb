Imports Entidades
Imports Persistencia
Public Class clsDProducto
    Public Function AgregarProducto(unprod As clsEProducto) As Boolean
        Dim unPc As New clsPProducto
        Return unPc.AltaProducto(unprod)
    End Function

    Public Function ListarProducto(parametro As String, busqueda As Integer) As List(Of clsEProducto)
        Dim unPc As New clsPProducto
        Return unPc.listarProducto(parametro, busqueda)
    End Function

    Public Function EliminarProducto(codigo As Integer) As Boolean
        Dim unPc As New clsPProducto
        Return unPc.eliminarproducto(codigo)
    End Function

    Public Function ModificarProducto(producto As clsEProducto) As Boolean
        Dim unPC As New clsPProducto
        Return unPC.modificarProducto(producto)
    End Function

    Public Function ExisteProducto(codigo As Integer) As Boolean
        Dim per As New clsPProducto
        Return per.existe(codigo)
    End Function

    Public Function GetMinStock(codigo As Integer) As Integer
        Dim unPP As New clsPProducto
        Return unPP.GetMinStock(codigo)
    End Function
End Class
