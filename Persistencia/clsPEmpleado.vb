Imports Entidades
Imports MySql.Data.MySqlClient

Public Class clsPEmpleado
    Inherits clsPersistencia
    Public Function login(ci As String, contrasenia As String) As clsEEmpleado
        Dim consultaSQL As String
        'consultaSQL = "SELECT * FROM emple WHERE user='" & usuario & "' AND pass='" & contrasenia & "';"
        consultaSQL = "SELECT * FROM empleado INNER JOIN persona ON empleado.ci = persona.ci WHERE persona.ci='" & ci & "' AND empleado.contrasenia='" & contrasenia & "';"
        Dim datos = ejecutarYdevolver(consultaSQL)
        If datos.Read() Then
            Return crearEmpleado(datos)
        Else
            Return Nothing
        End If

    End Function

    'Public Function AltaTipo(tipo As String) As Boolean
    '    Dim consulta As String
    '    consulta = "INSERT INTO cliente (ci,nombre,apellido,telefono,direccion,email) VALUES (" & uncli.ci & ",'" & uncli.nombre & "','" & uncli.apellido & "',' " & uncli.telefono & "', '" & uncli.direccion & "', '" & uncli.email & "')"

    '    Return ejecutarSQL(consulta)

    'End Function

    Public Function AltaEmpleado(unempl As clsEEmpleado) As Boolean
        Dim consulta As String
        consulta = "INSERT INTO persona (ci,nombre,apellido,telefono,direccion,email) VALUES (" & unempl.ci & ",'" & unempl.nombre & "','" & unempl.apellido & "','" & unempl.telefono & "', '" & unempl.direccion & "', '" & unempl.email & "')"
        ejecutarSQL(consulta)

        consulta = "INSERT INTO empleado (ci,contrasenia,sueldo,idtipoempleado) VALUES (" & unempl.ci & ",'" & unempl.contrseña & "'," & unempl.sueldo & "," & unempl.tipoEmpleado & ")"

        Return ejecutarSQL(consulta)
    End Function

    Public Function existe(ci As String) As Boolean
        Dim consultaSQL As String
        consultaSQL = "SELECT * FROM empleado WHERE ci='" & ci & "'"
        Dim datos = ejecutarYdevolver(consultaSQL)
        If datos.HasRows Then
            Return True
        Else
            Return False
        End If

    End Function


    Public Function existePersona(ci As String) As Boolean
        Dim consultaSQL As String
        consultaSQL = "SELECT * FROM persona WHERE ci='" & ci & "'"
        Dim datos = ejecutarYdevolver(consultaSQL)
        If datos.HasRows Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function crearEmpleado(ByVal datos As MySqlDataReader) As clsEEmpleado
        'Dim unEmpleado As New clsEEmpleado(CInt(datos.Item("ci").ToString), datos.Item("nombre").ToString, datos.Item("apellido").ToString, datos.Item("direccion").ToString, datos.Item("telefono").ToString, datos.Item("email").ToString)
        Dim unEmpleado As New clsEEmpleado

        unEmpleado.ci = CInt(datos.Item("ci").ToString)
        unEmpleado.nombre = datos.Item("nombre").ToString
        unEmpleado.apellido = datos.Item("apellido").ToString
        unEmpleado.direccion = datos.Item("direccion").ToString
        unEmpleado.email = datos.Item("email").ToString
        unEmpleado.telefono = datos.Item("telefono").ToString
        unEmpleado.contrseña = datos.Item("contrasenia").ToString
        unEmpleado.sueldo = CInt(datos.Item("sueldo").ToString)
        unEmpleado.tipoEmpleado = CInt(datos.Item("idtipoEmpleado").ToString)

        Return unEmpleado
    End Function

    Public Function listarEmpleado(parametro As String, busqueda As Integer) As List(Of clsEEmpleado)
        Dim consulta As String
        If busqueda = 1 Then 'Por ci
            consulta = "SELECT * FROM empleado INNER JOIN persona ON empleado.ci = persona.ci WHERE persona.ci='" & parametro & "';"
        ElseIf busqueda = 2 Then 'Por Apellido
            consulta = "SELECT * FROM empleado INNER JOIN persona ON empleado.ci = persona.ci WHERE persona.apellido='" & parametro & "';"
        ElseIf busqueda = 3 Then 'Por Cargo
            consulta = "SELECT * FROM empleado INNER JOIN persona ON empleado.ci = persona.ci WHERE empleado.idtipoEmpleado='" & parametro & "';"
        End If


        Dim datos As MySqlDataReader
        datos = ejecutarYdevolver(consulta)

        Dim listaempleado As New List(Of clsEEmpleado)

        While datos.Read
            listaempleado.Add(crearEmpleado(datos))
        End While

        Return listaempleado
    End Function

    Public Function eliminarEmpleado(ci As Integer) As Boolean
        Dim consulta As String
        consulta = "DELETE FROM empleado WHERE ci =" & ci & ";"
        ejecutarSQL(consulta)
        consulta = "DELETE FROM persona WHERE ci =" & ci & ";"
        Return ejecutarSQL(consulta)
    End Function

    Public Function modificarEmpleado(unempl As clsEEmpleado) As Boolean
        Dim consulta As String
        consulta = "UPDATE persona SET nombre = '" & unempl.nombre & "' , apellido = '" & unempl.apellido & "' , direccion = '" & unempl.direccion & "', telefono = '" & unempl.telefono & "', email= '" & unempl.email & "' WHERE ci =" & unempl.ci & "; "
        ejecutarSQL(consulta)

        consulta = "UPDATE empleado SET sueldo= " & unempl.sueldo & " , contrasenia = '" & unempl.contrseña & "' , idtipoEmpleado = " & unempl.tipoEmpleado & " WHERE ci =" & unempl.ci & "; "
        Return ejecutarSQL(consulta)
    End Function

End Class
