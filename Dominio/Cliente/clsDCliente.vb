Imports Persistencia
Imports Entidades

Public Class clsDCliente
    Public Function AgregarCliente(uncli As clsECliente) As Boolean
        Dim unPc As New clsPCliente
        Return unPc.AltaCliente(uncli)
    End Function

End Class
