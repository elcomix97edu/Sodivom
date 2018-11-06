Imports Dominio
Imports Entidades

Public Class frmPedidodistribuidor
    Dim unaCon As New clsControladora
    Dim listaDist As New List(Of clsEDistribuidor)

    Private Function GetNomDist(id As String) As String
        Dim selectedValue As clsEDistribuidor
        selectedValue = listaDist.Find(Function(p) p.id = id)
        Return selectedValue.nombre
    End Function

    Private Function Getiddistri(nom As String) As String
        Dim selectedValue As clsEDistribuidor
        selectedValue = listaDist.Find(Function(p) p.nombre = nom)
        Return selectedValue.id
    End Function

    Private Sub frmPedidodistribuidor_Load(sender As Object, e As EventArgs) Handles Me.Load

        txtFecha.Text = Date.Now

        listaDist = unaCon.ListarDistribuidor("", 1)
        For Each dist In listaDist
            cmbDist.Items.Add(dist.nombre)
        Next

    End Sub

    Private Sub dgvDatos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDatos.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then 'Verifica que los click no sean el los bordes


            TxtId.Text = dgvDatos.CurrentRow.Cells(0).Value.ToString
            txtDescripcion.Text = dgvDatos.CurrentRow.Cells(1).Value.ToString
            txtFecha.Text = dgvDatos.CurrentRow.Cells(2).Value.ToString
            txtImporte.Text = dgvDatos.CurrentRow.Cells(3).Value.ToString
            cmbDist.Text = GetNomDist(dgvDatos.CurrentRow.Cells(4).Value.ToString)
            TxtId.Enabled = False

        End If
    End Sub

    Private Sub Listar()
        If Not (rdbTodo.Checked Or rdbFecha.Checked Or rdbDist.Checked) Then
            MsgBox("Seleccione un Parámetro de Búsqueda")
        Else



            Dim res As String
            Dim realiza As Boolean = False
            Dim busqueda As Integer


            If rdbTodo.Checked Then
                busqueda = 1
                realiza = True
            ElseIf rdbFecha.Checked Then

                If txtFecha.Text = "" Then
                    MsgBox("El campo Fecha está vacio")
                Else
                    busqueda = 2
                    res = txtFecha.Text
                    realiza = True
                End If

            ElseIf rdbDist.Checked Then

                If cmbDist.Text = "" Then
                    MsgBox("Seleccione un Distribuidor")
                Else
                    busqueda = 3
                    res = Getiddistri(cmbDist.Text)
                    realiza = True
                End If

            End If

            If realiza Then
                Dim lista = unaCon.ListarPedido(res, busqueda)
                dgvDatos.Rows.Clear()

                Dim Row As DataGridViewRow
                Dim Cell As DataGridViewCell
                Dim a As Integer = 0

                For Each unpedido In lista
                    Row = New DataGridViewRow

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unpedido.id.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unpedido.descripcion.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unpedido.fecha.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unpedido.importe.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unpedido.Dist.ToString
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
        txtFecha.Text = Date.Now
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim val As New clsValidar


        If val.VerificarCampos(Me) Then



            Dim pedido As New clsEPedido
            pedido.id = txtId.Text
            pedido.descripcion = txtDescripcion.Text
            pedido.fecha = txtFecha.Text
            pedido.importe = txtImporte.Text
            pedido.Dist = Getiddistri(cmbDist.Text)


            If unaCon.ExistePedido(CInt(TxtId.Text)) = False Then

                'Lo que realmente estas buscando
                'Dim cli As New clsEEmpleado(CInt(mskCi.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTel.Text, txtEmail.Text)
                Dim unpedido As New clsEPedido
                unpedido.id = TxtId.Text
                unpedido.descripcion = txtDescripcion.Text
                unpedido.fecha = txtFecha.Text
                unpedido.importe = txtImporte.Text
                unpedido.Dist = Getiddistri(cmbDist.Text)

                If unaCon.AgregarPedido(unpedido) Then
                    MsgBox("Pedido agregado Correctamente")
                Else
                    MsgBox("Hubo un error al agregar el Pedido")
                End If


            Else
                MsgBox("Ya se ha ingresado este pedido, desea ingresarlo igualente?", MsgBoxStyle.YesNo)
                If MsgBoxResult.Yes Then
                    unaCon.AgregarPedido(pedido)
                Else
                    MsgBox("Hubo un error al agregar el pedido")

                End If

            End If
        Else
            MsgBox("Hay Campos Vacios")
        End If

    End Sub


    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim val As New clsValidar

        If val.VerificarCampos(Me) Then

            Select Case MsgBox("Desea actualizar el pedido?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical,)
                Case MsgBoxResult.Yes
                    'Dim uncli As New clsECliente(mskCi.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTel.Text, txtEmail.Text)
                    Dim unpedido As New clsEPedido  'Crea el empleado
                    unpedido.id = TxtId.Text 'Carga los datos del empleado
                    unpedido.descripcion = txtDescripcion.Text
                    unpedido.fecha = txtFecha.Text
                    unpedido.importe = txtImporte.Text
                    unpedido.Dist = Getiddistri(cmbDist.Text)

                    Dim unaC As New clsControladora
                    If unaC.ModificarPedido(unpedido) Then
                        MsgBox("Pedido Actualizado Correctamente")
                        Listar()
                    Else
                        MsgBox("Ocurrio un error al actualizar el pedido")
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

            Dim id As Integer
            id = CInt(dgvDatos.CurrentRow.Cells(0).Value.ToString)


            Select Case MsgBox("Desea quitar el pedido del sistema?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical,)
                Case MsgBoxResult.Yes
                    Dim unaC As New clsControladora
                    If unaC.EliminarPedido(id) Then
                        MsgBox("Pedido Eliminado Correctamente")
                        Listar()
                    Else
                        MsgBox("Ocurrio un error al eliminar el Pedido")
                    End If
                    'Case MsgBoxResult.No
                    '    MessageBox.Show("NO button")
            End Select

        Else
            MsgBox("Hay Campos Vacios")

        End If


    End Sub

    Private Sub TxtId_TextChanged(sender As Object, e As EventArgs) Handles TxtId.TextChanged
        If Not IsNumeric(TxtId.Text) And TxtId.Text <> "" Then
            MsgBox("Se ingresaron caracteres no esperados")

        End If


    End Sub

    Private Sub txtImporte_TextChanged(sender As Object, e As EventArgs) Handles txtImporte.TextChanged
        If Not IsNumeric(txtImporte.Text) And txtImporte.Text <> "" Then
            MsgBox("Se ingresaron caracteres no esperados")

        End If
    End Sub

End Class