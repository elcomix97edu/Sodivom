Imports Entidades
Imports Persistencia

Public Class clsDOfertaWeb

    Public Function ModificarOfertaWeb(ListaOfertas As List(Of clsEOfertaWeb)) As Boolean
        Dim unPOW As New clsPOfertaWeb
        Return unPOW.ModificarOfertaWeb(ListaOfertas)
    End Function

End Class
