Imports Dominio
Imports Entidades


Public Class frmProducto
    Dim unaCon As New clsControladora
    Dim eunempleado As New clsEEmpleado

    Public Property Unempleado As clsEEmpleado
        Get
            Return eunempleado
        End Get
        Set(value As clsEEmpleado)
            eunempleado = value
        End Set
    End Property

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Dim unLim As New clsLimpiar
        unLim.Limpiar(Me)


    End Sub

    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Unempleado.tipoEmpleado = 3 Then ' es reponedor
            btnEliminar.Enabled = False
            btnListar.Enabled = False
            btnModificar.Enabled = False
        End If


    End Sub

    Private Sub Listar()
        If Not (rdbTodo.Checked Or rdbNombre.Checked Or rbdCodigo.Checked) Then
            MsgBox("Seleccione un Parámetro de Búsqueda")
        Else

            Dim res As String
            Dim realiza As Boolean = False
            Dim busqueda As Integer


            If rdbTodo.Checked Then
                busqueda = 1
                realiza = True
            ElseIf rdbNombre.Checked Then

                If txtNombre.Text = "" Then
                    MsgBox("El campo Nombre está vacio")
                Else
                    res = txtNombre.Text
                    busqueda = 2
                    realiza = True
                End If
            ElseIf rbdCodigo.Checked Then

                If txtCodigo.Text = "" Then
                    MsgBox("El campo Código está vacio")
                Else
                    res = txtCodigo.Text
                    busqueda = 3
                    realiza = True
                End If

            End If

            If realiza Then
                Dim lista = unaCon.ListarProducto(res, busqueda)
                dgvDatos.Rows.Clear()

                Dim Row As DataGridViewRow
                Dim Cell As DataGridViewCell
                Dim a As Integer = 0

                For Each unProducto In lista
                    Row = New DataGridViewRow

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unProducto.codigo.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unProducto.nombre.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unProducto.descripcion.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unProducto.precio.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unProducto.minstock.ToString
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


    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim val As New clsValidar
        'validaciones
        If val.VerificarCampos(Me) Then

            If unaCon.ExisteProducto(txtCodigo.Text) = False Then
                If InStr(txtNombre.Text, " ") > 0 Then
                    MsgBox("El nombre del producto contiene espacios, reemplazelos con guion bajo")
                Else
                    'Lo que realmente estas buscando
                    'Dim cli As New clsEEmpleado(CInt(mskCi.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTel.Text, txtEmail.Text)
                    Dim prod As New clsEProducto
                    prod.codigo = txtCodigo.Text
                    prod.nombre = txtNombre.Text
                    prod.descripcion = txtDescripcion.Text
                    prod.precio = txtPrecio.Text
                    prod.minstock = txtMinStock.Text


                    If unaCon.AgregarProducto(prod) Then
                        MsgBox("Producto agregado Correctamente")
                    Else
                        MsgBox("Hubo un error al agregar el producto")
                    End If
                End If




            Else
                MsgBox("Producto existente")

            End If
        Else
            MsgBox("Hay Campos Vacios")
        End If

    End Sub

    Private Sub dgvDatos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDatos.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then 'Verifica que los click no sean el los bordes
            txtCodigo.Text = dgvDatos.CurrentRow.Cells(0).Value.ToString
            txtNombre.Text = dgvDatos.CurrentRow.Cells(1).Value.ToString
            txtDescripcion.Text = dgvDatos.CurrentRow.Cells(2).Value.ToString
            txtPrecio.Text = dgvDatos.CurrentRow.Cells(3).Value.ToString
            txtMinStock.Text = dgvDatos.CurrentRow.Cells(4).Value.ToString
            txtCodigo.Enabled = False
        End If
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Listar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim val As New clsValidar

        If val.VerificarCampos(Me) Then

            Dim codigo As String
            codigo = txtCodigo.Text

            If unaCon.EnUso(codigo) = False Then

                Select Case MsgBox("Desea quitar el producto " & txtNombre.Text & " " & txtDescripcion.Text & " del sistema?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Baja Autor")
                    Case MsgBoxResult.Yes
                        Dim unaC As New clsControladora
                        If unaC.EliminarProducto(codigo) Then
                            MsgBox("Producto Eliminado Correctamente")
                            Listar()
                        Else
                            MsgBox("Ocurrio un error al eliminar el Producto")
                        End If
                        'Case MsgBoxResult.No
                        '    MessageBox.Show("NO button")
                End Select

            Else
                MsgBox("No se puede eliminar este producto porque existen ventas que lo contienen")
            End If





        Else
            MsgBox("Hay Campos Vacios")

        End If



    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim val As New clsValidar

        If val.VerificarCampos(Me) Then

            Select Case MsgBox("Desea actualizar el producto " & txtNombre.Text & " " & txtDescripcion.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Baja Autor")
                Case MsgBoxResult.Yes
                    'Dim uncli As New clsECliente(mskCi.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTel.Text, txtEmail.Text)
                    Dim unprod As New clsEProducto 'Crea el empleado
                    unprod.codigo = txtCodigo.Text 'Carga los datos del empleado
                    unprod.nombre = txtNombre.Text
                    unprod.descripcion = txtDescripcion.Text
                    unprod.precio = txtPrecio.Text
                    unprod.minstock = txtMinStock.Text


                    Dim unaC As New clsControladora
                    If unaC.ModificarProducto(unprod) Then
                        MsgBox("Producto actualizado correctamente")
                        Listar()
                    Else
                        MsgBox("Ocurrio un error al actualizar el producto")
                    End If
                    'Case MsgBoxResult.No
                    '    MessageBox.Show("NO button")
            End Select

        Else
            MsgBox("Hay Campos Vacios")

        End If





    End Sub


    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        If Not IsNumeric(txtCodigo.Text) And txtCodigo.Text <> "" Then
            MsgBox("Se ingresaron caracteres no esperados")

        End If
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged
        If Not IsNumeric(txtPrecio.Text) And txtPrecio.Text <> "" Then
            MsgBox("Se ingresaron caracteres no esperados")

        End If
    End Sub

    Private Sub txtMinStock_TextChanged(sender As Object, e As EventArgs) Handles txtMinStock.TextChanged
        If Not IsNumeric(txtMinStock.Text) And txtMinStock.Text <> "" Then
            MsgBox("Se ingresaron caracteres no esperados")

        End If
    End Sub

End Class