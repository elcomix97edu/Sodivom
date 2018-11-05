Imports Entidades
Imports MySql.Data.MySqlClient

Public Class clsPStock
    Inherits clsPersistencia

    Public Function AltaStock(unstock As clsEStock) As Boolean
        Dim consulta As String
        consulta = "INSERT INTO stock (idproducto,stock,fechaing,fechaven) VALUES ('" & unstock.codigoprod & "','" & unstock.stock & "','" & unstock.fechaing.ToString("yyyy-MM-dd") & "','" & unstock.fechaven.ToString("yyyy-MM-dd") & "')"

        Return ejecutarSQL(consulta)
    End Function

    Public Function existe(stock As clsEStock) As Boolean
        Dim consultaSQL As String
        consultaSQL = "SELECT * FROM stock  WHERE idproducto='" & stock.codigoprod & "' and stock='" & stock.stock & "' and  fechaing='" & stock.fechaing.ToString("yyyy-MM-dd") & "' and fechaven='" & stock.fechaven.ToString("yyyy-MM-dd") & "';"
        Dim datos = ejecutarYdevolver(consultaSQL)
        If datos.HasRows Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function crearStock(ByVal datos As MySqlDataReader) As clsEStock
        Dim unStock As New clsEStock
        unStock.codigoprod = datos.Item("idproducto").ToString
        unStock.stock = CInt(datos.Item("stock").ToString)
        unStock.fechaing = datos.Item("fechaing").ToString
        unStock.fechaven = datos.Item("fechaven").ToString
        unStock.id = datos.Item("id").ToString


        Return unStock
    End Function

    Public Function listarStock(parametro As String, busqueda As Integer) As List(Of clsEStock)
        Dim consulta As String
        If busqueda = 1 Then 'Todo
            consulta = "SELECT * FROM stock ;"
        ElseIf busqueda = 2 Then 'Por Codigo
            consulta = "SELECT * FROM stock WHERE idproducto ='" & parametro & "';"
        End If

        Dim datos As MySqlDataReader
        datos = ejecutarYdevolver(consulta)

        Dim listastock As New List(Of clsEStock)

        While datos.Read
            listastock.Add(crearStock(datos))
        End While

        Return listastock
    End Function

    Public Function eliminarstock(id As String) As Boolean
        Dim consulta As String
        consulta = "DELETE FROM stock WHERE id =" & id & ";"
        Return ejecutarSQL(consulta)
    End Function

    Public Function modificarstock(unstock As clsEStock) As Boolean
        Dim consulta As String
        consulta = "UPDATE stock SET stock = '" & unstock.stock & "' , fechaing = '" & unstock.fechaing.ToString("yyyy-MM-dd") & "' , fechaven = '" & unstock.fechaven.ToString("yyyy-MM-dd") & "'  WHERE id =" & unstock.id & "; "
        Return ejecutarSQL(consulta)
    End Function

    Public Function GetStocksProd(idprod As String) As List(Of clsEStock)
        Dim consulta As String
        consulta = "SELECT * FROM stock WHERE idproducto = '" & idprod & "' ORDER BY fechaing ASC LIMIT 2"
        Dim datos As MySqlDataReader
        datos = ejecutarYdevolver(consulta)

        Dim listastock As New List(Of clsEStock)

        While datos.Read
            listastock.Add(crearStock(datos))
        End While

        Return listastock
    End Function

    Public Function SumStock(codprod As String) As Integer
        Dim consulta As String
        consulta = "SELECT SUM(stock) FROM stock WHERE idproducto = '" & codprod & "'"
        Dim datos = ejecutarYdevolver(consulta)
        datos.Read()
        Return CInt(datos.Item("SUM(stock)").ToString)
    End Function

End Class
