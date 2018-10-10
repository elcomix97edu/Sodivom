﻿Imports Entidades
Imports MySql.Data.MySqlClient

Public Class clsPProducto
    Inherits clsPersistencia

    Public Function AltaProducto(unprod As clsEProducto) As Boolean
        Dim consulta As String
        consulta = "INSERT INTO producto (codigo,descripcion,nombre,precio) VALUES (" & unprod.codigo & ",'" & unprod.descripcion & "','" & unprod.nombre & "'," & unprod.precio & ")"

        Return ejecutarSQL(consulta)
    End Function

    Public Function existe(codigo As String) As Boolean
        Dim consultaSQL As String
        consultaSQL = "SELECT * FROM producto WHERE codigo='" & codigo & "'"
        Dim datos = ejecutarYdevolver(consultaSQL)
        If datos.HasRows Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function crearEmpleado(ByVal datos As MySqlDataReader) As clsEProducto
        'Dim unEmpleado As New clsEEmpleado(CInt(datos.Item("ci").ToString), datos.Item("nombre").ToString, datos.Item("apellido").ToString, datos.Item("direccion").ToString, datos.Item("telefono").ToString, datos.Item("email").ToString)
        Dim unProducto As New clsEProducto

        unProducto.codigo = CInt(datos.Item("codigo").ToString)
        unProducto.nombre = datos.Item("nombre").ToString
        unProducto.descripcion = datos.Item("descripcion").ToString
        unProducto.precio = CInt(datos.Item("precio").ToString)


        Return unProducto
    End Function

    Public Function listarProducto(parametro As String, busqueda As Integer) As List(Of clsEProducto)
        Dim consulta As String
        If busqueda = 1 Then 'Todo
            consulta = "SELECT * FROM producto ;"
        ElseIf busqueda = 2 Then 'Por Nombre
            consulta = "SELECT * FROM producto WHERE nombre ='" & parametro & "';"
        ElseIf busqueda = 3 Then 'Por codigo
            consulta = "SELECT * FROM producto WHERE codigo ='" & parametro & "';"
        End If


        Dim datos As MySqlDataReader
        datos = ejecutarYdevolver(consulta)

        Dim listaproducto As New List(Of clsEProducto)

        While datos.Read
            listaproducto.Add(crearEmpleado(datos))
        End While

        Return listaproducto
    End Function

    Public Function eliminarproducto(codigo As Integer) As Boolean
        Dim consulta As String
        consulta = "DELETE FROM producto WHERE codigo =" & codigo & ";"
        Return ejecutarSQL(consulta)
    End Function

    Public Function modificarProducto(unprod As clsEProducto) As Boolean
        Dim consulta As String
        consulta = "UPDATE producto SET nombre = '" & unprod.nombre & "' , descripcion = '" & unprod.descripcion & "' , precio = " & unprod.precio & "  WHERE codigo =" & unprod.codigo & "; "
        Return ejecutarSQL(consulta)
    End Function
End Class