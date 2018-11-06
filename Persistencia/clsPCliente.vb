Imports Entidades
Imports MySql.Data.MySqlClient

Public Class clsPCliente
    Inherits clsPersistencia

    Public Function AltaCliente(uncli As clsECliente) As Boolean
        Dim consulta As String
        consulta = "INSERT INTO persona (ci,nombre,apellido,telefono,direccion,email) VALUES (" & uncli.ci & ",'" & uncli.nombre & "','" & uncli.apellido & "','" & uncli.telefono & "', '" & uncli.direccion & "', '" & uncli.email & "')"
        ejecutarSQL(consulta)

        consulta = "INSERT INTO cliente(ci) VALUES(" & uncli.ci & ")"
        Return ejecutarSQL(consulta)
    End Function

    Public Function existe(ci As String) As Boolean
        Dim consultaSQL As String
        consultaSQL = "SELECT * FROM cliente WHERE ci='" & ci & "'"
        Dim datos = ejecutarYdevolver(consultaSQL)
        If datos.HasRows Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function crearCliente(ByVal datos As MySqlDataReader) As clsECliente
        Dim unCliente As New clsECliente(CInt(datos.Item("ci").ToString), datos.Item("nombre").ToString, datos.Item("apellido").ToString, datos.Item("direccion").ToString, datos.Item("telefono").ToString, datos.Item("email").ToString)
        Return unCliente
    End Function

    Public Function listarCliente(parametro As String, usaci As Boolean) As List(Of clsECliente)
        Dim consulta As String
        If usaci Then
            consulta = "SELECT * FROM cliente INNER JOIN persona ON cliente.ci = persona.ci WHERE cliente.ci='" & parametro & "';"
        Else
            'consulta = "SELECT * FROM persona WHERE apellido='" & parametro & "';"
            consulta = "SELECT * FROM cliente INNER JOIN persona ON cliente.ci = persona.ci WHERE persona.apellido='" & parametro & "';"
        End If


        Dim datos As MySqlDataReader
        datos = ejecutarYdevolver(consulta)

        Dim listaclientes As New List(Of clsECliente)

        While datos.Read
            listaclientes.Add(crearCliente(datos))
        End While

        Return listaclientes
    End Function


    Public Function listarallCliente() As List(Of clsECliente)
        Dim consulta As String
        consulta = "SELECT * FROM cliente INNER JOIN persona ON cliente.ci = persona.ci"


        Dim datos As MySqlDataReader
        datos = ejecutarYdevolver(consulta)

        Dim listaclientes As New List(Of clsECliente)

        While datos.Read
            listaclientes.Add(crearCliente(datos))
        End While

        Return listaclientes
    End Function

    Public Function eliminarCliente(ci As Integer) As Boolean
        Dim consulta As String
        consulta = "DELETE FROM cliente WHERE ci =" & ci & ";"
        ejecutarSQL(consulta)
        consulta = "DELETE FROM persona WHERE ci =" & ci & ";"
        Return ejecutarSQL(consulta)
    End Function

    Public Function modificarCliente(uncli As clsECliente) As Boolean
        Dim consulta As String
        consulta = "UPDATE persona SET nombre = '" & uncli.nombre & "' , apellido = '" & uncli.apellido & "' , direccion = '" & uncli.direccion & "', telefono = '" & uncli.telefono & "' , email= '" & uncli.email & "' WHERE ci =" & uncli.ci & "; "
        Return ejecutarSQL(consulta)
    End Function


End Class
