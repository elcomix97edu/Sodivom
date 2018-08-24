Imports Persistencia

Public Class clsDEmpleado
    Public Function login(usuario As String, contrasenia As String) As Boolean
        Dim unPE As New clsPEmpleado
        Return unPE.login(usuario, contrasenia)
    End Function
End Class
