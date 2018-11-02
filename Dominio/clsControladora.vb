﻿Imports Entidades

Public Class clsControladora

    'cliente
    Public Function AgregarCliente(uncli As clsECliente) As Boolean
        Dim unDc As New clsDCliente
        Return unDc.AgregarCliente(uncli)
    End Function

    Public Function ListarCliente(parametro As String, usaci As Boolean) As List(Of clsECliente)
        Dim unDc As New clsDCliente
        Return unDc.listarCliente(parametro, usaci)
    End Function

    Public Function ListarAllClientes() As List(Of clsECliente)
        Dim unPc As New clsDCliente
        Return unPc.ListarAllClientes()
    End Function

    Public Function EliminarCliente(ci As Integer) As Boolean
        Dim unDc As New clsDCliente
        Return unDc.eliminarCliente(ci)
    End Function

    Public Function ModificarCliente(cliente As clsECliente) As Boolean
        Dim unDC As New clsDCliente
        Return unDC.modificarCliente(cliente)
    End Function

    Public Function ExisteCliente(ci As Integer) As Boolean
        Dim unDC As New clsDCliente
        Return unDC.ExisteCliente(ci)

    End Function


    'TipoEmpleado
    Public Function AltaTipoEmpleado(tipo As String) As Boolean
        Dim unPte As New clsDTipoEmpleado
        Return unPte.AltaTipoEmpleado(tipo)
    End Function

    Public Function BajaTipoEmpleado(tipo As String) As Boolean
        Dim unPte As New clsDTipoEmpleado
        Return unPte.BajaTipoEmpleado(tipo)
    End Function

    Public Function ListadoTipoEmpleado() As List(Of clsETipoEmpleado)
        Dim unPte As New clsDTipoEmpleado
        Return unPte.ListadoTipoEmpleado
    End Function

    Public Function ExisteTipoEmpleado(tipo As String) As Boolean
        Dim unPte As New clsDTipoEmpleado
        Return unPte.ExisteTipoEmpleado(tipo)
    End Function


    'Empleado
    Public Function login(ci As String, contrasenia As String) As clsEEmpleado
        Dim unPE As New clsDEmpleado
        Return unPE.login(ci, contrasenia)
    End Function

    Public Function AgregarEmpleado(unempl As clsEEmpleado) As Boolean
        Dim unPE As New clsDEmpleado
        Return unPE.AgregarEmpleado(unempl)
    End Function

    Public Function ListarEmpleado(parametro As String, busqueda As Integer) As List(Of clsEEmpleado)
        Dim unPE As New clsDEmpleado
        Return unPE.listarEmpleado(parametro, busqueda)
    End Function

    Public Function EliminarEmpleado(ci As Integer) As Boolean
        Dim unPE As New clsDEmpleado
        Return unPE.eliminarEmpleado(ci)
    End Function

    Public Function ModificarEmpleado(unempl As clsEEmpleado) As Boolean
        Dim unPE As New clsDEmpleado
        Return unPE.modificarEmpleado(unempl)
    End Function

    Public Function ExisteEmpleado(ci As Integer) As Boolean
        Dim unPE As New clsDEmpleado
        Return unPE.ExisteEmpleado(ci)
    End Function


    'Producto

    Public Function AgregarProducto(unprod As clsEProducto) As Boolean
        Dim unPP As New clsDProducto
        Return unPP.AgregarProducto(unprod)
    End Function

    Public Function ListarProducto(parametro As String, busqueda As Integer) As List(Of clsEProducto)
        Dim unPc As New clsDProducto
        Return unPc.ListarProducto(parametro, busqueda)
    End Function

    Public Function EliminarProducto(codigo As Integer) As Boolean
        Dim unPc As New clsDProducto
        Return unPc.EliminarProducto(codigo)
    End Function

    Public Function ModificarProducto(producto As clsEProducto) As Boolean
        Dim unPC As New clsDProducto
        Return unPC.ModificarProducto(producto)
    End Function

    Public Function ExisteProducto(codigo As Integer) As Boolean
        Dim per As New clsDProducto
        Return per.ExisteProducto(codigo)
    End Function


    'Stock
    Public Function AgregarStock(unstock As clsEStock) As Boolean
        Dim unPP As New clsDStock
        Return unPP.AgregarStock(unstock)
    End Function

    Public Function ListarStock(parametro As String, busqueda As Integer) As List(Of clsEStock)
        Dim unSt As New clsDStock
        Return unSt.ListarStock(parametro, busqueda)
    End Function

    Public Function EliminarStock(codigo As Integer) As Boolean
        Dim unSt As New clsDStock
        Return unSt.EliminarStock(codigo)
    End Function

    Public Function ModificarStock(stock As clsEStock) As Boolean
        Dim unSt As New clsDStock
        Return unSt.ModificarStock(stock)
    End Function

    Public Function ExisteStock(stock As clsEStock) As Boolean
        Dim per As New clsDStock
        Return per.ExisteStock(stock)
    End Function

    Public Function GetStocksProd(idprod As Integer) As List(Of clsEStock)
        Dim unSt As New clsDStock
        Return unSt.GetStocksProd(idprod)
    End Function

    'Venta
    Dim unDV As New clsDVenta

    Public Function AltaVenta(fecha As Date, importe As Integer, empl As clsEEmpleado) As Boolean
        Return unDV.AltaVenta(fecha, importe, empl)
    End Function

    Public Function AltaVentaProducto(idventa As Integer, idprod As Integer, cantidad As Integer) As Boolean
        Return unDV.AltaVentaProducto(idventa, idprod, cantidad)
    End Function

    Public Function AltaVentaDeProducto(idventa As Integer, cicli As Integer) As Boolean
        Return unDV.AltaVentaDeProducto(idventa, cicli)
    End Function

    Public Function GetIdVenta(fecha As Date, ciEmpl As Integer) As Integer
        Return unDV.GetIdVenta(fecha, ciEmpl)
    End Function

    Public Function TraerVenta(id As String) As clsEVenta
        Return unDV.TraerVenta(id)
    End Function

End Class
