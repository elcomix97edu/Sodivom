Imports Entidades
Imports MySql.Data.MySqlClient

Public Class clsPDistribuidor
    Inherits clsPersistencia

    Public Function AltaDistribuidor(undis As clsEDistribuidor) As Boolean
        Dim consulta As String
        consulta = "INSERT INTO distribuidor (telefono,id,email,descripcion,nombre) VALUES (" & undis.telefono & ",'" & undis.id & "','" & undis.email & "','" & undis.descripcion & "','" & undis.nombre & "')"

        Return ejecutarSQL(consulta)
    End Function

    Public Function existe(id As String) As Boolean
        Dim consultaSQL As String
        consultaSQL = "SELECT * FROM distribuidor WHERE id='" & id & "'"
        Dim datos = ejecutarYdevolver(consultaSQL)
        If datos.HasRows Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function crearEmpleado(ByVal datos As MySqlDataReader) As clsEDistribuidor
        'Dim unEmpleado As New clsEEmpleado(CInt(datos.Item("ci").ToString), datos.Item("nombre").ToString, datos.Item("apellido").ToString, datos.Item("direccion").ToString, datos.Item("telefono").ToString, datos.Item("email").ToString)
        Dim unDistribuidor As New clsEDistribuidor

        unDistribuidor.telefono = datos.Item("telefono").ToString
        unDistribuidor.id = datos.Item("id").ToString
        unDistribuidor.email = datos.Item("email").ToString
        unDistribuidor.descripcion = datos.Item("descripcion").ToString
        unDistribuidor.nombre = datos.Item("nombre").ToString


        Return unDistribuidor
    End Function

    Public Function listarDistribuidor(parametro As String, busqueda As Integer) As List(Of clsEDistribuidor)
        Dim consulta As String
        If busqueda = 1 Then 'Todo
            consulta = "SELECT * FROM distribuidor ;"
        ElseIf busqueda = 2 Then 'Por Nombre
            consulta = "SELECT * FROM distribuidor WHERE nombre ='" & parametro & "';"
        End If


        Dim datos As MySqlDataReader
        datos = ejecutarYdevolver(consulta)

        Dim listadistribuidor As New List(Of clsEDistribuidor)

        While datos.Read
            listadistribuidor.Add(crearEmpleado(datos))
        End While

        Return listadistribuidor
    End Function

    Public Function eliminardistribuidor(id As Integer) As Boolean
        Dim consulta As String
        consulta = "DELETE FROM distribuidor WHERE id =" & id & ";"
        Return ejecutarSQL(consulta)
    End Function

    Public Function modificarDistribuidor(undis As clsEDistribuidor) As Boolean
        Dim consulta As String
        consulta = "UPDATE distribuidor SET telefono = '" & undis.telefono & "' , descripcion = '" & undis.descripcion & "' , email = '" & undis.email & "' , nombre = '" & undis.nombre & "'  WHERE id = '" & undis.id & "'; "
        Return ejecutarSQL(consulta)
    End Function
End Class
