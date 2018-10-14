Imports Entidades
Public Class clsPVenta
    Inherits clsPersistencia

    Public Function AltaVenta(fecha As Date, importe As Integer, empl As clsEEmpleado) As Boolean
        Dim consulta As String
        consulta = "INSERT INTO venta (civendedor,fecha,importeTotal) VALUES (" & empl.ci & ",'" & fecha.ToString("yyyy-MM-dd hh:mm:ss") & "'," & importe & ")"
        Return ejecutarSQL(consulta)
    End Function

    Public Function AltaVentaProducto(idventa As Integer, idprod As Integer, cantidad As Integer) As Boolean
        Dim consulta As String
        consulta = "INSERT INTO ventaproducto (idventa,codigoproducto,cantidadproducto) VALUES (" & idventa & "," & idprod & "," & cantidad & ")"
        Return ejecutarSQL(consulta)
    End Function

    Public Function AltaVentaDeProducto(idventa As Integer, cicli As Integer) As Boolean
        Dim consulta As String
        consulta = "INSERT INTO ventadeproducto (idventa,cicliente) VALUES (" & idventa & "," & cicli & ")"
        Return ejecutarSQL(consulta)
    End Function

    Public Function GetIdVenta(fecha As Date, ciEmpl As Integer) As Integer
        Dim consulta As String = " SELECT id FROM venta WHERE fecha='" & fecha.ToString("yyyy-MM-dd hh:mm:ss") & "' AND civendedor=" & ciEmpl & ";"
        Dim datos = ejecutarYdevolver(consulta)
        datos.Read()
        Return datos.Item("id").ToString
    End Function



End Class
