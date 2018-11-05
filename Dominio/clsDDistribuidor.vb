Imports Entidades
Imports Persistencia
Public Class clsDDistribuidor
    Public Function AgregarDistribuidor(undis As clsEDistribuidor) As Boolean
        Dim unPc As New clsPDistribuidor
        Return unPc.AltaDistribuidor(undis)
    End Function

    Public Function ListarDistribuidor(parametro As String, busqueda As Integer) As List(Of clsEDistribuidor)
        Dim unPc As New clsPDistribuidor
        Return unPc.listarDistribuidor(parametro, busqueda)
    End Function

    Public Function EliminarDistribuidor(id As Integer) As Boolean
        Dim unPc As New clsPDistribuidor
        Return unPc.eliminardistribuidor(id)
    End Function

    Public Function ModificarDistribuidor(Distribuidor As clsEDistribuidor) As Boolean
        Dim unPC As New clsPDistribuidor
        Return unPC.modificarDistribuidor(Distribuidor)
    End Function

    Public Function ExisteDistribuidor(id As String) As Boolean
        Dim per As New clsPDistribuidor
        Return per.existe(id)
    End Function
End Class
