Imports Entidades
Imports Dominio

Public Class frmCliente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim val As New clsValidar

        'validaciones
        If val.VerificarCampos(Me) Then

            If val.VerificarCI(CInt(mskCi.Text)) Then
                If val.ExisteCliente(CInt(mskCi.Text)) = False Then

                    'Lo que realmente estas buscando
                    Dim cli As New clsECliente(CInt(mskCi.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text)
                    Dim dcli As New clsDCliente
                    If dcli.AgregarCliente(cli) Then
                        MsgBox("Cliente agregado Correctamente")
                    Else
                        MsgBox("Hubo un error al agregar el cliente")
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Not (RadioButton1.Checked Or RadioButton2.Checked) Then
            MsgBox("Seleccione un Parámetro de Búsqueda")
        Else
            Dim unacon As New clsControladora
            Dim res As String

            If RadioButton1.Checked Then
                res = mskCi.Text
            Else
                res = txtNombre.Text
            End If
            Dim lista = unacon.ListarCliente(res, RadioButton1.Checked)
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
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'If dgvCliente.CurrentRow.Equals(Nothing) Then
        '    MsgBox("Seleccione un cliente para borrar en la tabla")
        'Else

        'End If

        Dim ci As Integer
        Dim nombre, apellido As String
        ci = CInt(dgvCliente.CurrentRow.Cells(0).Value.ToString)
        nombre = dgvCliente.CurrentRow.Cells(1).Value.ToString
        apellido = dgvCliente.CurrentRow.Cells(2).Value.ToString


        Select Case MsgBox("Desea quitar el cliente " & txtNombre.Text & " " & txtApellido.Text & " del sistema?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Baja Autor")
            Case MsgBoxResult.Yes
                Dim unaC As New clsControladora
                If unaC.EliminarCliente(ci) Then
                    MsgBox("Cliente Eliminado Correctamente")
                Else
                    MsgBox("Ocurrio un error al eliminar el Cliente")
                End If
                'Case MsgBoxResult.No
                '    MessageBox.Show("NO button")
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim ci As Integer
        Dim nombre, apellido As String
        ci = CInt(dgvCliente.CurrentRow.Cells(0).Value.ToString)
        nombre = dgvCliente.CurrentRow.Cells(1).Value.ToString
        apellido = dgvCliente.CurrentRow.Cells(2).Value.ToString


        Select Case MsgBox("Desea actualizar el cliente " & txtNombre.Text & " " & txtApellido.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Baja Autor")
            Case MsgBoxResult.Yes
                Dim uncli As New clsECliente(mskCi.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text)
                Dim unaC As New clsControladora
                If unaC.ModificarCliente(uncli) Then
                    MsgBox("Cliente Actualizado Correctamente")
                Else
                    MsgBox("Ocurrio un error al actualizar el Cliente")
                End If
                'Case MsgBoxResult.No
                '    MessageBox.Show("NO button")
        End Select


    End Sub

    Private Sub dgvCliente_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvCliente.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then 'Verifica que los click no sean el los bordes
            mskCi.Text = dgvCliente.CurrentRow.Cells(0).Value.ToString
            txtNombre.Text = dgvCliente.CurrentRow.Cells(1).Value.ToString
            txtApellido.Text = dgvCliente.CurrentRow.Cells(2).Value.ToString
            txtDireccion.Text = dgvCliente.CurrentRow.Cells(3).Value.ToString
            txtTelefono.Text = dgvCliente.CurrentRow.Cells(4).Value.ToString
            txtEmail.Text = dgvCliente.CurrentRow.Cells(5).Value.ToString
        End If

    End Sub
End Class