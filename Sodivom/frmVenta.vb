﻿Imports Entidades
Imports Dominio

Public Class frmVenta
    Dim munempl As New clsEEmpleado
    Dim listaCli As New List(Of clsECliente)
    Dim unaCon As New clsControladora
    Dim listaProd As New List(Of clsEProducto)
    Dim ProdIng As Integer = 0 'Contador de Productos Ingresados
    Dim preciototal As Integer = 0


    Private Function GetCiCliente(nombre As String, apellido As String) As Integer
        Dim selectedValue As clsECliente
        selectedValue = listaCli.Find(Function(p) p.nombre = nombre And p.apellido = apellido)
        Return selectedValue.ci
    End Function

    Private Function GetCodProd(nombre As String, desc As String) As Integer
        Dim selectedValue As clsEProducto
        selectedValue = listaProd.Find(Function(p) p.nombre = nombre And p.descripcion = desc)
        Return selectedValue.codigo
    End Function

    Private Function GetPrecioProd(cod As Integer) As Integer
        Dim selectedValue As clsEProducto
        selectedValue = listaProd.Find(Function(p) p.codigo = cod)
        Return selectedValue.precio
    End Function

    'Private Function GetNombreCli(id As Integer) As String
    '    Dim selectedValue As clsETipoEmpleado
    '    selectedValue = listaCargos.Find(Function(p) p.id = id)
    '    Return selectedValue.tipoEmpleado
    'End Function

    Public Property unempl As clsEEmpleado
        Get
            Return munempl
        End Get
        Set(value As clsEEmpleado)
            munempl = value
        End Set
    End Property

    Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombreCajero.Text = unempl.nombre & " " & unempl.apellido
        listaCli = unaCon.ListarAllClientes() 'Lista todos los clientes
        listaProd = unaCon.ListarProducto("", 1) 'Lista todos los productos
        'Dim nomcli As String 'Variable para tener nombre completo de cliente
        For Each Cliente In listaCli
            comboCliente.Items.Add(Cliente.nombre.ToString & " " & Cliente.apellido.ToString)
        Next
        For Each Prod In listaProd
            ComboProd.Items.Add(Prod.nombre.ToString & " (" & Prod.descripcion.ToString & ")")
        Next
    End Sub

    Private Sub chkAnonimo_CheckedChanged(sender As Object, e As EventArgs) Handles chkAnonimo.CheckedChanged
        If chkAnonimo.Checked Then
            comboCliente.Text = "Anónimo -"
        Else
            comboCliente.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim conjunto As String = comboCliente.Text   
        'Dim palabras As String() = conjunto.Split(New Char() {" "c})
        'Label1.Text = palabras.GetValue(0).ToString
        'Label2.Text = palabras.GetValue(1).ToString
        'Label1.Text = GetCiCliente(palabras.GetValue(0).ToString, palabras.GetValue(1).ToString)

        Dim conjunto As String = ComboProd.Text
        Dim palabras As String() = conjunto.Split(New Char() {" "c})
        Label1.Text = palabras.GetValue(0).ToString
        Label2.Text = palabras.GetValue(1).ToString.Replace("(", "")
        'Label1.Text = GetCiCliente(palabras.GetValue(0).ToString, palabras.GetValue(1).ToString)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            contReparto.Enabled = True
        Else
            contReparto.Enabled = False
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        If Not IsNumeric(txtCantidad.Text) And txtCantidad.Text <> "" Then
            MsgBox("Se ingresaron caracteres no válidos")
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim Row As DataGridViewRow
        Dim Cell As DataGridViewCell
        Dim a As Integer = 0
        Dim conjunto As String = ComboProd.Text
        Dim palabras As String() = conjunto.Split(New Char() {" "c})
        Dim nombre As String = palabras.GetValue(0).ToString
        Dim desc As String = palabras.GetValue(1).ToString.Replace("(", "")
        desc = desc.Replace(")", "")
        Dim cod As Integer = GetCodProd(nombre, desc)

        '/////////VERIFICACION DE STOCK/////////////////
        Dim listastock As New List(Of clsEStock)
        Dim stockprod As Integer = 0
        listastock = unaCon.ListarStock(cod, 2)
        For Each stock In listastock
            stockprod += stock.stock
        Next
        '//////////////////////////////////////////////


        If CInt(txtCantidad.Text) > stockprod Then
            MsgBox("Stock insuficiente")
        Else

            Row = New DataGridViewRow

            Cell = New DataGridViewTextBoxCell
            Cell.Value = cod
            Row.Cells.Add(Cell)

            Cell = New DataGridViewTextBoxCell
            Cell.Value = nombre
            Row.Cells.Add(Cell)

            Cell = New DataGridViewTextBoxCell
            Cell.Value = txtCantidad.Text
            Row.Cells.Add(Cell)

            Cell = New DataGridViewTextBoxCell
            Cell.Value = GetPrecioProd(cod)
            Row.Cells.Add(Cell)

            dgvProductos.Rows.Add(Row)



            '''''''Desglose del Precio
            preciototal = preciototal + (CInt(dgvProductos.Rows(ProdIng).Cells(2).Value.ToString) * CInt(dgvProductos.Rows(ProdIng).Cells(3).Value.ToString))
            lblPrecioTotal.Text = preciototal
            lblPrecioIva.Text = preciototal * 0.22
            lblPrecioSub.Text = preciototal * 0.78


            ProdIng = ProdIng + 1

        End If




    End Sub

    Private Sub chkRUT_CheckedChanged(sender As Object, e As EventArgs) Handles chkRUT.CheckedChanged
        If chkRUT.Checked Then
            mskRUT.Enabled = True
            chkAnonimo.Enabled = False
            comboCliente.Enabled = False
        Else
            mskRUT.Enabled = False
            chkAnonimo.Enabled = True
            comboCliente.Enabled = True
        End If
    End Sub

    Private Sub btnRealizarVenta_Click(sender As Object, e As EventArgs) Handles btnRealizarVenta.Click
        Dim unaCon As New clsControladora
        Dim fecha As Date = Date.Now
        Dim idventa As Integer
        Dim stocks As New List(Of clsEStock)


        unaCon.AltaVenta(fecha, CInt(lblPrecioTotal.Text), unempl)

        idventa = unaCon.GetIdVenta(fecha, unempl.ci)


        For i As Integer = 0 To ProdIng - 1
            '//////////BAJA DEL STOCK///////////////
            stocks = unaCon.GetStocksProd(CInt(dgvProductos.Rows(i).Cells(0).Value.ToString)) 'Trae de la bd los 2 stock con fecha de ingreso mas vieja
            If stocks.ElementAt(0).stock < CInt(dgvProductos.Rows(i).Cells(2).Value.ToString) Then 'Si la compra es mayor al stock mas viejo
                Dim restante As Integer = CInt(dgvProductos.Rows(i).Cells(2).Value.ToString) - stocks.ElementAt(0).stock 'Se calcula la diferencia entre la compra y el stock mas viejo
                unaCon.EliminarStock(stocks.ElementAt(0).id) 'Se elimina el stock mas viejo
                Dim unModStock As New clsEStock 'Genera un objeto stock para cargar los datos de otro stock para modificarlos
                unModStock = stocks.ElementAt(1) 'Carga los datos
                unModStock.stock = unModStock.stock - restante 'Se le resta al stock el restante de la compra
                unaCon.ModificarStock(unModStock) 'Se envia a la bd
            ElseIf stocks.ElementAt(0).stock = CInt(dgvProductos.Rows(i).Cells(2).Value.ToString) Then 'Si la compra es igual al stock mas viejo
                unaCon.EliminarStock(stocks.ElementAt(0).id) 'Se elimina el stock
            Else 'Si la compra es menor al stock mas viejo
                Dim unModStock As New clsEStock 'Se genera un objeto stock para cargar los datos y modificarlos
                unModStock = stocks.ElementAt(0) 'Se cargan los datos
                unModStock.stock = unModStock.stock - CInt(dgvProductos.Rows(i).Cells(2).Value.ToString) 'Se le resta la cantiad de la compra al stock
                unaCon.ModificarStock(unModStock) 'Se envia a la bd
            End If
            '//////////////////////////////////////

            unaCon.AltaVentaProducto(idventa, CInt(dgvProductos.Rows(i).Cells(0).Value.ToString), CInt(dgvProductos.Rows(i).Cells(2).Value.ToString))
        Next

        Dim conjunto As String = comboCliente.Text
        Dim palabras As String() = conjunto.Split(New Char() {" "c})


        unaCon.AltaVentaDeProducto(idventa, GetCiCliente(palabras.GetValue(0).ToString, palabras.GetValue(1).ToString))
    End Sub
End Class