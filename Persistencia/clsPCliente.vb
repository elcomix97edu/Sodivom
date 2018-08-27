Imports Entidades
Public Class clsPCliente
    Inherits clsPersistencia

    Public Function AltaCliente(uncli As clsECliente) As Boolean
        Dim consulta As String
        consulta = "INSERT INTO cliente (ci,nombre,apellido,telefono,direccion,email) VALUES (" & uncli.ci & ",'" & uncli.nombre & "','" & uncli.apellido & "',' " & uncli.telefono & "', '" & uncli.direccion & "', '" & uncli.email & "')"

        Return ejecutarSQL(consulta)
    End Function

End Class
