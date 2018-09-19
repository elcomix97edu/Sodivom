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

    'Public Function AltaTipo(tipo As String) As Boolean
    '    Dim consulta As String
    '    consulta = "INSERT INTO cliente (ci,nombre,apellido,telefono,direccion,email) VALUES (" & uncli.ci & ",'" & uncli.nombre & "','" & uncli.apellido & "',' " & uncli.telefono & "', '" & uncli.direccion & "', '" & uncli.email & "')"

    '    Return ejecutarSQL(consulta)

    'End Function
End Class
