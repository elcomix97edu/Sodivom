Imports Entidades
Imports MySql.Data.MySqlClient

Public Class clsPPedidoDistribuidor
    Inherits clsPersistencia

    Public Function AltaPedido(unpedido As clsEPedido) As Boolean
        Dim consulta As String
        consulta = "INSERT INTO pedidodistribuidor (id,descripcion,fecha,importeTotal,iddist) VALUES (" & unpedido.id & ",'" & unpedido.descripcion & "','" & unpedido.fecha.ToString("yyyy-MM-dd") & "','" & unpedido.importe & "','" & unpedido.Dist & "')"

        Return ejecutarSQL(consulta)
    End Function

    Public Function existe(id As String) As Boolean
        Dim consultaSQL As String
        consultaSQL = "SELECT * FROM pedidodistribuidor  WHERE id= " & id & ""
        Dim datos = ejecutarYdevolver(consultaSQL)
        If datos.HasRows Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function crearpedido(ByVal datos As MySqlDataReader) As clsEPedido
        Dim unpedido As New clsEPedido
        unpedido.id = CInt(datos.Item("id").ToString)
        unpedido.descripcion = datos.Item("descripcion").ToString
        unpedido.fecha = datos.Item("fecha").ToString
        unpedido.importe = datos.Item("importeTotal").ToString
        unpedido.Dist = datos.Item("iddist").ToString
        Return unpedido
    End Function

    Public Function listarpedido(parametro As String, busqueda As Integer) As List(Of clsEPedido)
        Dim consulta As String
        If busqueda = 1 Then 'Todo
            consulta = "SELECT * FROM pedidodistribuidor ;"
        ElseIf busqueda = 2 Then 'Por fecha
            Dim fecha As Date
            fecha = CDate(parametro)
            consulta = "SELECT * FROM pedidodistribuidor WHERE fecha ='" & fecha.ToString("yyyy-MM-dd") & "';"
        ElseIf busqueda = 3 Then 'Por Distribuidor
            consulta = "SELECT * FROM pedidodistribuidor WHERE iddist = '" & parametro & "'"
        End If

        Dim datos As MySqlDataReader
        datos = ejecutarYdevolver(consulta)

        Dim listapedido As New List(Of clsEPedido)

        While datos.Read
            listapedido.Add(crearpedido(datos))
        End While

        Return listapedido
    End Function

    Public Function eliminarpedido(id As Integer) As Boolean
        Dim consulta As String
        consulta = "DELETE FROM pedidodistribuidor WHERE id =" & id & ";"
        Return ejecutarSQL(consulta)
    End Function

    Public Function modificarpedido(unpedido As clsEPedido) As Boolean
        Dim consulta As String
        consulta = "UPDATE pedidodistribuidor SET descripcion = '" & unpedido.descripcion & "' , fecha = '" & unpedido.fecha.ToString("yyyy-MM-dd") & "' , importeTotal = '" & unpedido.importe & "' , iddist = '" & unpedido.Dist & "'  WHERE id =" & unpedido.id & "; "
        Return ejecutarSQL(consulta)
    End Function


End Class
