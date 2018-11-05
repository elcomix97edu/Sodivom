Imports Dominio
Imports Entidades

Public Class frmStock
    Dim unaCon As New clsControladora
    Dim munempl As New clsEEmpleado

    Public Property unempl As clsEEmpleado
        Get
            Return munempl
        End Get
        Set(value As clsEEmpleado)
            munempl = value
        End Set
    End Property

    Private Sub frmStock_Load(sender As Object, e As EventArgs) Handles Me.Load

        txtFechaIng.Text = Date.Now
        If unempl.tipoEmpleado = 4 Then 'Es Vendedor
            btnEliminar.Enabled = False
            btnIngresar.Enabled = False
            btnModificar.Enabled = False

        End If

        listaProd = unaCon.ListarProducto("", 1) 'Lista todos los productos
        For Each Prod In listaProd
            comboProducto.Items.Add(Prod.nombre.ToString & " (" & Prod.descripcion.ToString & ")")
        Next

    End Sub

    Dim listaProd As New List(Of clsEProducto)

    Private Function GetCodProd(nombre As String, desc As String) As String
        Dim selectedValue As clsEProducto
        selectedValue = listaProd.Find(Function(p) p.nombre = nombre And p.descripcion = desc)
        Return selectedValue.codigo
    End Function

    Private Function GetNomProd(id As String) As String
        Dim selectedValue As clsEProducto
        selectedValue = listaProd.Find(Function(p) p.codigo = id)
        Return selectedValue.nombre
    End Function

    Private Function GetDescProd(id As String) As String
        Dim selectedValue As clsEProducto
        selectedValue = listaProd.Find(Function(p) p.codigo = id)
        Return selectedValue.descripcion
    End Function

    Private Sub dgvDatos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDatos.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then 'Verifica que los click no sean el los bordes

            comboProducto.Text = dgvDatos.CurrentRow.Cells(0).Value.ToString & " (" & dgvDatos.CurrentRow.Cells(1).Value.ToString & ")"
            txtStock.Text = dgvDatos.CurrentRow.Cells(2).Value.ToString
            txtFechaIng.Text = dgvDatos.CurrentRow.Cells(3).Value.ToString
            DtpFechaVen.Text = dgvDatos.CurrentRow.Cells(4).Value.ToString
            txtId.Text = dgvDatos.CurrentRow.Cells(5).Value.ToString
            comboProducto.Enabled = False
            txtFechaIng.Enabled = False
        End If
    End Sub

    Private Sub Listar()
        If Not (rdbTodo.Checked Or rdbProducto.Checked) Then
            MsgBox("Seleccione un Parámetro de Búsqueda")
        Else



            Dim res As String
            Dim realiza As Boolean = False
            Dim busqueda As Integer


            If rdbTodo.Checked Then
                busqueda = 1
                realiza = True
            ElseIf rdbProducto.Checked Then

                If comboProducto.Text = "" Then
                    MsgBox("El campo Producto está vacio")
                Else
                    Dim conjunto As String = comboProducto.Text
                    Dim palabras As String() = conjunto.Split(New Char() {" "c})
                    Dim nombre As String = palabras.GetValue(0).ToString
                    Dim desc As String = palabras.GetValue(1).ToString.Replace("(", "")
                    desc = desc.Replace(")", "")
                    Dim cod As String = GetCodProd(nombre, desc)

                    res = cod
                    busqueda = 2
                    realiza = True
                End If
            End If

            If realiza Then
                Dim lista = unaCon.ListarStock(res, busqueda)
                dgvDatos.Rows.Clear()

                Dim Row As DataGridViewRow
                Dim Cell As DataGridViewCell
                Dim a As Integer = 0

                For Each unStock In lista
                    Row = New DataGridViewRow

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = GetNomProd(unStock.codigoprod.ToString)
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = GetDescProd(unStock.codigoprod.ToString)
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unStock.stock.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unStock.fechaing.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unStock.fechaven.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unStock.id.ToString
                    Row.Cells.Add(Cell)


                    dgvDatos.Rows.Add(Row)
                    a = a + 1

                Next
                If a = 0 Then
                    MsgBox("No se encontró ningun resultado", MsgBoxStyle.Exclamation)

                End If
            End If

        End If

    End Sub


    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Dim unLim As New clsLimpiar
        unLim.Limpiar(Me)
        txtFechaIng.Text = Date.Now
        txtId.Text = "0"
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim val As New clsValidar

        If val.VerificarCampos(Me) Then

            Dim conjunto As String = comboProducto.Text
            Dim palabras As String() = conjunto.Split(New Char() {" "c})
            Dim nombre As String = palabras.GetValue(0).ToString
            Dim desc As String = palabras.GetValue(1).ToString.Replace("(", "")
            desc = desc.Replace(")", "")
            Dim cod As String = GetCodProd(nombre, desc)

            Dim sto As New clsEStock
            sto.codigoprod = cod
            sto.stock = txtStock.Text
            sto.fechaing = txtFechaIng.Text
            sto.fechaven = DtpFechaVen.Text
            sto.id = txtId.Text


            If unaCon.ExisteStock(sto) = False Then

                'Lo que realmente estas buscando
                'Dim cli As New clsEEmpleado(CInt(mskCi.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTel.Text, txtEmail.Text)


                If unaCon.AgregarStock(sto) Then
                    MsgBox("Stock agregado Correctamente")
                Else
                    MsgBox("Hubo un error al agregar el stock")
                End If


            Else
                MsgBox("Ya se a ingresado este stock, desea ingresarlo igualmente?", MsgBoxStyle.YesNo)
                If MsgBoxResult.Yes Then
                    unaCon.AgregarStock(sto)
                Else
                    MsgBox("Hubo un error al agregar el stock")

                End If

            End If
        Else
            MsgBox("Hay Campos Vacios")
        End If

    End Sub


    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim val As New clsValidar


        If val.VerificarCampos(Me) Then

            Dim codigo As String
            codigo = GetCodProd(dgvDatos.CurrentRow.Cells(0).Value.ToString, dgvDatos.CurrentRow.Cells(1).Value.ToString)

            Select Case MsgBox("Desea actualizar el stock del producto " & comboProducto.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical,)
                Case MsgBoxResult.Yes
                    'Dim uncli As New clsECliente(mskCi.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTel.Text, txtEmail.Text)
                    Dim unstock As New clsEStock  'Crea el empleado
                    unstock.codigoprod = codigo 'Carga los datos del empleado
                    unstock.stock = txtStock.Text
                    unstock.fechaing = txtFechaIng.Text
                    unstock.fechaven = DtpFechaVen.Text
                    unstock.id = txtId.Text


                    Dim unaC As New clsControladora
                    If unaC.ModificarStock(unstock) Then
                        MsgBox("Stock Actualizado Correctamente")
                        Listar()
                    Else
                        MsgBox("Ocurrio un error al actualizar el stock")
                    End If
                    'Case MsgBoxResult.No
                    '    MessageBox.Show("NO button")
            End Select

        Else
            MsgBox("Hay Campos Vacios")

        End If




    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Listar()
    End Sub

    Private Sub btnEliminar_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim val As New clsValidar

        If val.VerificarCampos(Me) Then

            Dim id As String
            id = dgvDatos.CurrentRow.Cells(5).Value.ToString


            Select Case MsgBox("Desea quitar el stock del producto" & comboProducto.Text & " del sistema?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical,)
                Case MsgBoxResult.Yes
                    Dim unaC As New clsControladora
                    If unaC.EliminarStock(id) Then
                        MsgBox("Stock Eliminado Correctamente")
                        Listar()
                    Else
                        MsgBox("Ocurrio un error al eliminar el stock")
                    End If
                    'Case MsgBoxResult.No
                    '    MessageBox.Show("NO button")
            End Select

        Else
            MsgBox("Hay Campos Vacios")

        End If


    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ChkNoVence.CheckedChanged
        If ChkNoVence.Checked Then
            DtpFechaVen.Text = "jueves, 01 de enero de 1920"
        Else

        End If
    End Sub


    Private Sub txtStock_TextChanged(sender As Object, e As EventArgs) Handles txtStock.TextChanged
        If Not IsNumeric(txtStock.Text) And txtStock.Text <> "" Then
            MsgBox("Se ingresaron caracteres no esperados")

        End If
    End Sub
End Class