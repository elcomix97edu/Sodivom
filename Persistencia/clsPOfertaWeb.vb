Imports Entidades

Public Class clsPOfertaWeb
    Inherits clsPersistencia

    Public Function ModificarOfertaWeb(ListaOferta As List(Of clsEOfertaWeb)) As Boolean
        Dim consulta As String
        Dim res As Boolean
        For i As Integer = 1 To 5
            consulta = "UPDATE ofertaweb SET producto = " & ListaOferta.Item(i - 1).Proucto & ", preciooferta = " & ListaOferta.Item(i - 1).PrecioOferta & " WHERE id = " & i & ""
            res = ejecutarSQL(consulta)
        Next

        Return res
    End Function

End Class
