﻿Imports Entidades
Imports MySql.Data.MySqlClient

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

    Public Function TraerVenta(id As String) As clsEVenta
        Dim unaventa As New clsEVenta
        Dim consulta As String
        '/////////Tabla Venta////////////////////
        consulta = "SELECT * FROM venta WHERE id='" & id & "'"
        Dim datos = ejecutarYdevolver(consulta)
        datos.Read()
        unaventa.total = datos.Item("importeTotal").ToString
        unaventa.fecha = datos.Item("fecha").ToString
        consulta = "SELECT * FROM persona WHERE ci='" & datos.Item("civendedor").ToString & "'"
        datos = ejecutarYdevolver(consulta)
        datos.Read()
        unaventa.Cajero = datos.Item("nombre").ToString & " " & datos.Item("apellido").ToString


        '////////Tabla VentaDeProducto//////////////
        consulta = "SELECT * FROM ventadeproducto WHERE idventa='" & id & "'"
        datos = ejecutarYdevolver(consulta)
        datos.Read()
        unaventa.cliente = datos.Item("cicliente").ToString
        '///////Tabla VentaProducto//////////////
        consulta = "SELECT * FROM ventaproducto WHERE idventa='" & id & "'"
        datos = ejecutarYdevolver(consulta)
        Dim list As New List(Of clsEStock)
        While datos.Read
            list.Add(crearprod(datos))
        End While
        unaventa.listpord = list


        Return unaventa
    End Function

    Private Function crearprod(ByVal datos As MySqlDataReader) As clsEStock
        Dim unstock As New clsEStock
        unstock.stock = datos.Item("cantidadproducto").ToString
        unstock.codigoprod = datos.Item("codigoproducto").ToString
        unstock.fechaing = Date.Now
        unstock.fechaven = Date.Now
        unstock.id = 0
        Return unstock
    End Function


End Class
