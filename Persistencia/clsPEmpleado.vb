Public Class clsPEmpleado
    Inherits clsPersistencia
    Public Function login(usuario As String, contrasenia As String) As Boolean
        Dim consultaSQL As String
        consultaSQL = "SELECT * FROM usuarios WHERE user='" & usuario & "' AND pass='" & contrasenia & "';"
        Dim datos = ejecutarYdevolver(consultaSQL)
        If datos.HasRows Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
