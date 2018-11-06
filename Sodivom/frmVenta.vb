Imports Entidades
Imports Dominio

Public Class frmVenta
    Dim munempl As New clsEEmpleado
    Dim listaCli As New List(Of clsECliente)
    Dim unaCon As New clsControladora
    Dim listaProd As New List(Of clsEProducto)
    Dim ProdIng As Integer = 0 'Contador de Productos Ingresados
    Dim preciototal As Integer = 0
    Dim idventa As Integer


    Private Function GetCiCliente(nombre As String, apellido As String) As Integer
        Dim selectedValue As clsECliente
        selectedValue = listaCli.Find(Function(p) p.nombre = nombre And p.apellido = apellido)
        Return selectedValue.ci
    End Function

    Private Function GetCodProd(nombre As String, desc As String) As String
        Dim selectedValue As clsEProducto
        selectedValue = listaProd.Find(Function(p) p.nombre = nombre And p.descripcion = desc)
        Return selectedValue.codigo
    End Function

    Private Function GetPrecioProd(cod As String) As Integer
        Dim selectedValue As clsEProducto
        selectedValue = listaProd.Find(Function(p) p.codigo = cod)
        Return selectedValue.precio
    End Function

    Private Function GetNomProd(cod As String) As String
        Dim selectedValue As clsEProducto
        selectedValue = listaProd.Find(Function(p) p.codigo = cod)
        Return selectedValue.nombre
    End Function

    Private Function GetDirCli(ci As Integer) As String
        Dim selectedValue As clsECliente
        selectedValue = listaCli.Find(Function(p) p.ci = ci)
        Return selectedValue.direccion
    End Function

    Private Function GetNomCli(ci As String) As String
        Dim selectedValue As clsECliente
        selectedValue = listaCli.Find(Function(p) p.ci = ci)
        Dim res As String
        res = selectedValue.nombre & " " & selectedValue.apellido
        Return res
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
        lblNumFecha.Text = Date.Now
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

        End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        If Not IsNumeric(txtCantidad.Text) And txtCantidad.Text <> "" Then
            MsgBox("Se ingresaron caracteres no válidos")
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If ComboProd.Text <> "" And txtCantidad.Text <> "" Then

            Dim Row As DataGridViewRow
            Dim Cell As DataGridViewCell
            Dim a As Integer = 0
            Dim conjunto As String = ComboProd.Text
            Dim palabras As String() = conjunto.Split(New Char() {" "c})
            Dim nombre As String = palabras.GetValue(0).ToString
            Dim desc As String = palabras.GetValue(1).ToString.Replace("(", "")
            desc = desc.Replace(")", "")
            Dim cod As String = GetCodProd(nombre, desc)

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

            ComboProd.Text = ""
            txtCantidad.Text = ""

        Else
            MsgBox("Debe de seleccionar un producto y establecer una cantidad para agregarlo")
        End If



    End Sub

    Private Sub CheckBoxReparto_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxReparto.CheckedChanged
        If CheckBoxReparto.Checked Then
            contReparto.Enabled = True
            txtDireccion.Enabled = True
        Else
            contReparto.Enabled = False
            txtDireccion.Enabled = False
        End If
    End Sub

    Private Sub btnRealizarVenta_Click(sender As Object, e As EventArgs) Handles btnRealizarVenta.Click

        'Try

        If dgvProductos.Rows.Count <> 0 Then

                Dim unaCon As New clsControladora
                Dim fecha As Date = Date.Now
                Dim stocks As New List(Of clsEStock)
                Dim ok As Boolean


                unaCon.AltaVenta(fecha, CInt(lblPrecioTotal.Text), unempl)

                idventa = unaCon.GetIdVenta(fecha, unempl.ci)


                For i As Integer = 0 To ProdIng - 1
                '//////////BAJA DEL STOCK///////////////
                stocks = unaCon.GetStocksProd(dgvProductos.Rows(i).Cells(0).Value.ToString) 'Trae de la bd los 2 stock con fecha de ingreso mas vieja
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

                unaCon.AltaVentaProducto(idventa, dgvProductos.Rows(i).Cells(0).Value.ToString, CInt(dgvProductos.Rows(i).Cells(2).Value.ToString))
            Next



                Dim conjunto As String = comboCliente.Text
                Dim palabras As String() = conjunto.Split(New Char() {" "c}) 'profe si ves esto me arruinaste un fin de semana mejor dicho un año entero 


                ok = unaCon.AltaVentaDeProducto(idventa, GetCiCliente(palabras.GetValue(0).ToString, palabras.GetValue(1).ToString))

                If CheckBoxReparto.Checked Then
                    unaCon.AltaReparto(idventa, txtDireccion.Text)
                End If
                '/////////Impresion de la factura
                PrintDialog1.Document = PrintDocument1
                PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
                With PrintDocument1
                    .PrinterSettings.DefaultPageSettings.Landscape = False
                    .Print()

                End With

                '////////////////

                If ok Then
                MsgBox("Venta Realizada Exisosamente")
                Dim lim As New clsLimpiar
                lim.Limpiar(Me)
            Else
                    MsgBox("Hubo un error al realizar la Venta")
                End If


            Else

                MsgBox("Para realizar una venta es necesario agregar productos")
            End If


        'Catch ex As Exception
        '    MsgBox(ex)
        'End Try



    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim espacio As Integer = 345
        e.Graphics.DrawImage(ResizeImage(My.Resources.Any_City_Resort___Presented_by_Mark_Allen__Markting_Head), 20, 20) ' Cuerpo de la factura
        e.Graphics.DrawString("N° de Venta: " & idventa, New Drawing.Font("Times New Roman", 12), Brushes.Black, 670, 75) 'ID Venta
        If chkRUT.Checked Then 'Si usa RUT
            e.Graphics.DrawString(mskRUT.Text, New Drawing.Font("Times New Roman", 12), Brushes.Black, 90, 155) 'RUT
            e.Graphics.DrawString(txtNombre.Text, New Drawing.Font("Times New Roman", 12), Brushes.Black, 125, 183) 'Nombre Empresa
        Else
            e.Graphics.DrawString("X", New Drawing.Font("Times New Roman", 12), Brushes.Black, 287, 153) 'Escribe X en comprador final
            e.Graphics.DrawString(comboCliente.Text, New Drawing.Font("Times New Roman", 12), Brushes.Black, 125, 183) 'Nombre Cliente
        End If
        If CheckBoxReparto.Checked Then
            e.Graphics.DrawString(TextReparto.Text, New Drawing.Font("Times New Roman", 12), Brushes.Black, 138, 207) 'Direccion de Reparto
        End If
        e.Graphics.DrawString(Date.Now.Day, New Drawing.Font("Times New Roman", 12), Brushes.Black, 675, 125) 'Dia
        e.Graphics.DrawString(Date.Now.Month, New Drawing.Font("Times New Roman", 12), Brushes.Black, 735, 125) 'Mes
        e.Graphics.DrawString(Date.Now.Year, New Drawing.Font("Times New Roman", 12), Brushes.Black, 785, 125) 'Año
        e.Graphics.DrawString("Cajero: " & lblNombreCajero.Text, New Drawing.Font("Times New Roman", 12), Brushes.Black, 670, 165) 'Nombre Vendedor

        For i As Integer = 0 To ProdIng - 1 'Lista de Productos
            e.Graphics.DrawString(dgvProductos.Rows(i).Cells(2).Value.ToString, New Drawing.Font("Times New Roman", 12), Brushes.Black, 85, espacio) 'Cantidad
            e.Graphics.DrawString(dgvProductos.Rows(i).Cells(1).Value.ToString, New Drawing.Font("Times New Roman", 12), Brushes.Black, 180, espacio) 'Producto
            e.Graphics.DrawString(dgvProductos.Rows(i).Cells(3).Value.ToString, New Drawing.Font("Times New Roman", 12), Brushes.Black, 700, espacio) 'Precio Uni
            e.Graphics.DrawString(CInt(dgvProductos.Rows(i).Cells(3).Value.ToString) * CInt(dgvProductos.Rows(i).Cells(2).Value.ToString), New Drawing.Font("Times New Roman", 12), Brushes.Black, 765, espacio) 'Precio Total Producti
            espacio += 35
        Next

        e.Graphics.DrawString(lblPrecioSub.Text, New Drawing.Font("Times New Roman", 12), Brushes.Black, 750, 527) 'SubTotal
        e.Graphics.DrawString(lblPrecioIva.Text, New Drawing.Font("Times New Roman", 12), Brushes.Black, 750, 550) 'IVA
        e.Graphics.DrawString(lblPrecioTotal.Text, New Drawing.Font("Times New Roman", 12), Brushes.Black, 750, 573) 'Total

        If CheckBoxReparto.Checked Then 'Si usa reparto
            e.Graphics.DrawString(txtDireccion.Text, New Drawing.Font("Times New Roman", 12), Brushes.Black, 132, 218) 'rEPARTo
        Else
            e.Graphics.DrawString("X", New Drawing.Font("Times New Roman", 12), Brushes.Black, 132, 218) 'Escribe X el campo del repartowe

        End If
    End Sub

    Public Shared Function ResizeImage(ByVal InputImage As Image) As Image
        Return New Bitmap(InputImage, New Size(800, 600))
    End Function


    Private Sub dgvProductos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductos.CellEndEdit

        '/////////VERIFICACION DE STOCK/////////////////
        Dim listastock As New List(Of clsEStock)
        Dim stockprod As Integer = 0
        listastock = unaCon.ListarStock(dgvProductos.CurrentRow.Cells(0).Value.ToString, 2)
        For Each stock In listastock
            stockprod += stock.stock
        Next
        '//////////////////////////////////////////////


        If CInt(dgvProductos.CurrentRow.Cells(2).Value.ToString) > stockprod Then
            MsgBox("Stock insuficiente")
        Else

            ProdIng = dgvProductos.Rows.Count
            preciototal = 0
            For i As Integer = 0 To ProdIng - 1
                preciototal += CInt(dgvProductos.Rows(i).Cells(3).Value.ToString) * CInt(dgvProductos.Rows(i).Cells(2).Value.ToString)
            Next
            lblPrecioTotal.Text = preciototal
            lblPrecioIva.Text = preciototal * 0.22
            lblPrecioSub.Text = preciototal * 0.78

        End If





    End Sub

    Private Sub dgvProductos_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvProductos.RowsRemoved
        ProdIng = dgvProductos.Rows.Count
        preciototal = 0
        For i As Integer = 0 To ProdIng - 1
            preciototal += CInt(dgvProductos.Rows(i).Cells(3).Value.ToString) * CInt(dgvProductos.Rows(i).Cells(2).Value.ToString)
        Next
        lblPrecioTotal.Text = preciototal
        lblPrecioIva.Text = preciototal * 0.22
        lblPrecioSub.Text = preciototal * 0.78

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim unacon As New clsControladora

        If txtIdVenta.Text <> "" Then

            If unacon.existeID(txtIdVenta.Text) Then
                dgvProductos.Rows.Clear()

                Dim unaventa As New clsEVenta
                Dim Row As DataGridViewRow
                Dim Cell As DataGridViewCell

                unaventa = unacon.TraerVenta(txtIdVenta.Text)

                lblNombreCajero.Text = unaventa.Cajero
                comboCliente.Text = GetNomCli(unaventa.cliente)
                Dim listaprod As New List(Of clsEStock)
                listaprod = unaventa.listprod
                For Each prod In unaventa.listprod


                    Row = New DataGridViewRow

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = prod.codigoprod
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = GetNomProd(prod.codigoprod)
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = prod.stock
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = GetPrecioProd(prod.codigoprod)
                    Row.Cells.Add(Cell)

                    dgvProductos.Rows.Add(Row)

                Next

                txtDireccion.Text = unaventa.dir
                If txtDireccion.Text <> "" Then
                    CheckBoxReparto.Checked = True
                End If
                lblPrecioTotal.Text = unaventa.total
                lblPrecioSub.Text = lblPrecioTotal.Text * 0.78
                lblPrecioIva.Text = lblPrecioTotal.Text * 0.22
                lblNumFecha.Text = unaventa.fecha

            Else
                MsgBox("ID de venta no encontrado")
            End If



        Else
            MsgBox("Debe de ingresar un ID para realizar la búsqueda")

        End If




    End Sub

    Private Sub chkRUT_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkRUT.CheckedChanged
        If chkRUT.Checked Then
            mskRUT.Enabled = True
            txtNombre.Enabled = True
            chkAnonimo.Enabled = False
            comboCliente.Enabled = False
        Else
            mskRUT.Enabled = False
            txtNombre.Enabled = False
            chkAnonimo.Enabled = True
            comboCliente.Enabled = True
        End If
    End Sub

    Private Sub comboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCliente.SelectedIndexChanged
        If comboCliente.Text = "Anónimo -" Then
            chkAnonimo.Checked = True
        Else
            chkAnonimo.Checked = False
        End If

        Dim conjunto As String = comboCliente.Text
        Dim palabras As String() = conjunto.Split(New Char() {" "c})


        'ok = unaCon.AltaVentaDeProducto(idventa, GetCiCliente(palabras.GetValue(0).ToString, palabras.GetValue(1).ToString))

        txtDireccion.Text = GetDirCli(GetCiCliente(palabras.GetValue(0).ToString, palabras.GetValue(1).ToString))
    End Sub


    Private Sub mskRUT_MouseClick(sender As Object, e As MouseEventArgs) Handles mskRUT.MouseClick
        mskRUT.Select(0, 0)
    End Sub




    'Private Sub TextRepartoo_TextChanged(sender As Object, e As EventArgs) Handles TextRepartoo.TextChanged

    'End Sub
End Class

