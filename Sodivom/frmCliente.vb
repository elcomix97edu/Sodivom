Imports Entidades
Imports Dominio

Public Class frmCliente
    Dim unacon As New clsControladora

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim val As New clsValidar
        'validaciones
        If val.VerificarCampos(Me) Then

            If val.VerificarCI(CInt(mskCi.Text)) Then
                If unacon.ExisteCliente(CInt(mskCi.Text)) = False Then

                    If unacon.ExistePersona(mskCi.Text) = False Then


                        'Lo que realmente estas buscando
                        Dim cli As New clsECliente(CInt(mskCi.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text)
                        Dim dcli As New clsDCliente
                        If dcli.AgregarCliente(cli) Then
                            MsgBox("Cliente agregado Correctamente")
                        Else
                            MsgBox("Hubo un error al agregar el cliente")
                        End If

                    Else

                        MsgBox("Persona registrada como Empleado")
                    End If



                Else
                    MsgBox("Cliente existente")

                End If
            Else
                MsgBox("Cédula Inválida")
            End If
        Else
            MsgBox("Hay Campos Vacios")
        End If
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Listar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'If dgvCliente.CurrentRow.Equals(Nothing) Then
        '    MsgBox("Seleccione un cliente para borrar en la tabla")
        'Else

        'End If
        If mskCi.Text = "" Then
            MsgBox("Por favor, complete CI para eliminar un cliente")
        Else
            Dim val As New clsValidar

            If val.VerificarCampos(Me) Then

                Dim ci As Integer
                ci = CInt(mskCi.Text)



                Select Case MsgBox("Desea quitar el cliente " & txtNombre.Text & " " & txtApellido.Text & " del sistema?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Baja Cliente")
                    Case MsgBoxResult.Yes
                        Dim unaC As New clsControladora
                        If unaC.EliminarCliente(ci) Then
                            MsgBox("Cliente Eliminado Correctamente")
                            Listar()
                        Else
                            MsgBox("Ocurrio un error al eliminar el Cliente")
                        End If
                        'Case MsgBoxResult.No
                        '    MessageBox.Show("NO button")
                End Select

            Else

                MsgBox("Hay Campos Vacios")
            End If


        End If

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim val As New clsValidar

        If val.VerificarCampos(Me) Then

            Select Case MsgBox("Desea actualizar el cliente " & txtNombre.Text & " " & txtApellido.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Baja Autor")
                Case MsgBoxResult.Yes
                    Dim uncli As New clsECliente(mskCi.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text)
                    Dim unaC As New clsControladora
                    If unaC.ModificarCliente(uncli) Then
                        MsgBox("Cliente Actualizado Correctamente")
                        Listar()
                    Else
                        MsgBox("Ocurrio un error al actualizar el Cliente")
                    End If
                    'Case MsgBoxResult.No
                    '    MessageBox.Show("NO button")
            End Select

        Else
            MsgBox("Hay Campos Vacios")
        End If




    End Sub

    Private Sub dgvCliente_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCliente.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then 'Verifica que los click no sean el los bordes
            mskCi.Text = dgvCliente.CurrentRow.Cells(0).Value.ToString
            txtNombre.Text = dgvCliente.CurrentRow.Cells(1).Value.ToString
            txtApellido.Text = dgvCliente.CurrentRow.Cells(2).Value.ToString
            txtDireccion.Text = dgvCliente.CurrentRow.Cells(3).Value.ToString
            txtTelefono.Text = dgvCliente.CurrentRow.Cells(4).Value.ToString
            txtEmail.Text = dgvCliente.CurrentRow.Cells(5).Value.ToString
            mskCi.Enabled = False
        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Dim unLimpiar As New clsLimpiar
        unLimpiar.Limpiar(Me)
    End Sub


    Public Sub Listar()
        If Not (rdbCi.Checked Or rdbApellido.Checked) Then
            MsgBox("Seleccione un Parámetro de Búsqueda")
        Else

            Dim res As String
            Dim realiza As Boolean = False

            If rdbCi.Checked Then
                If mskCi.Text = "" Then
                    MsgBox("El campo Ci está vacio")
                Else
                    res = mskCi.Text
                    realiza = True
                End If

            Else
                If txtApellido.Text = "" Then
                    MsgBox("El campo Apellido está vacio")
                Else
                    res = txtApellido.Text
                    realiza = True
                End If

            End If
            If realiza Then
                Dim lista = unacon.ListarCliente(res, rdbCi.Checked)
                dgvCliente.Rows.Clear()

                Dim Row As DataGridViewRow
                Dim Cell As DataGridViewCell
                Dim a As Integer = 0

                For Each unCliente In lista
                    Row = New DataGridViewRow

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unCliente.ci.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unCliente.nombre.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unCliente.apellido.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unCliente.direccion.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unCliente.telefono.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unCliente.email.ToString
                    Row.Cells.Add(Cell)



                    dgvCliente.Rows.Add(Row)
                    a = a + 1

                Next
                If a = 0 Then
                    MsgBox("No se encontró ningun resultado", MsgBoxStyle.Exclamation)

                End If
            End If

        End If
    End Sub

    Private Sub mskCi_MouseClick(sender As Object, e As MouseEventArgs) Handles mskCi.MouseClick
        mskCi.Select(0, 0)
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        If IsNumeric(txtNombre.Text) Then
            MsgBox("Se ingresaron caracteres no esperados")

        End If
    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged
        If IsNumeric(txtApellido.Text) Then
            MsgBox("Se ingresaron caracteres no esperados")

        End If
    End Sub

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged
        If Not IsNumeric(txtTelefono.Text) And txtTelefono.Text <> "" Then
            MsgBox("Se ingresaron caracteres no esperados")

        End If
    End Sub
End Class