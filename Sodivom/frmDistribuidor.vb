Imports Dominio
Imports Entidades

Public Class frmDistribuidor
    Dim unaCon As New clsControladora
    Dim munempleado As New clsEEmpleado

    Public Property Unempleado As clsEEmpleado
        Get
            Return munempleado
        End Get
        Set(value As clsEEmpleado)
            munempleado = value
        End Set
    End Property

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Dim unLim As New clsLimpiar
        unLim.Limpiar(Me)


    End Sub

    Private Sub Listar()
        If Not (rdbTodo.Checked Or rdbNombre.Checked) Then
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
            End If

            If realiza Then
                Dim lista = unaCon.ListarDistribuidor(res, busqueda)
                dgvDatos.Rows.Clear()

                Dim Row As DataGridViewRow
                Dim Cell As DataGridViewCell
                Dim a As Integer = 0

                For Each unDistribuidor In lista
                    Row = New DataGridViewRow

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unDistribuidor.id.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unDistribuidor.nombre.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unDistribuidor.descripcion.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unDistribuidor.email.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unDistribuidor.telefono.ToString
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

            If unaCon.ExisteDistribuidor(txtId.Text) = False Then

                'Lo que realmente estas buscando
                'Dim cli As New clsEEmpleado(CInt(mskCi.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTel.Text, txtEmail.Text)
                Dim dis As New clsEDistribuidor
                dis.id = txtId.Text
                dis.nombre = txtNombre.Text
                dis.descripcion = txtDescripcion.Text
                dis.email = txtEmail.Text
                dis.telefono = txtTelefono.Text

                If unaCon.AgregarDistribuidor(dis) Then
                    MsgBox("Distribuidor agregado Correctamente")
                Else
                    MsgBox("Hubo un error al agregar el Distribuidor")
                End If


            Else
                MsgBox("Distribuidor existente")

            End If
        Else
            MsgBox("Hay Campos Vacios")
        End If

    End Sub

    Private Sub dgvDatos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDatos.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then 'Verifica que los click no sean el los bordes
            txtId.Text = dgvDatos.CurrentRow.Cells(0).Value.ToString
            txtNombre.Text = dgvDatos.CurrentRow.Cells(1).Value.ToString
            txtDescripcion.Text = dgvDatos.CurrentRow.Cells(2).Value.ToString
            txtEmail.Text = dgvDatos.CurrentRow.Cells(3).Value.ToString
            txtTelefono.Text = dgvDatos.CurrentRow.Cells(4).Value.ToString
            txtId.Enabled = False
        End If
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Listar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim val As New clsValidar

        If val.VerificarCampos(Me) Then

            Dim id As Integer
            Dim nombre As String
            id = CInt(dgvDatos.CurrentRow.Cells(0).Value.ToString)
            nombre = dgvDatos.CurrentRow.Cells(1).Value.ToString


            Select Case MsgBox("Desea quitar el distribuidor " & txtNombre.Text & " " & txtDescripcion.Text & " del sistema?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Baja Autor")
                Case MsgBoxResult.Yes
                    Dim unaC As New clsControladora
                    If unaC.EliminarDistribuidor(id) Then
                        MsgBox("Distribuidor Eliminado Correctamente")
                        Listar()
                    Else
                        MsgBox("Ocurrio un error al eliminar el Distribuidor")
                    End If
                    'Case MsgBoxResult.No
                    '    MessageBox.Show("NO button")
            End Select

        Else
            MsgBox("Hay Campos Vacios")

        End If



    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim val As New clsValidar

        If val.VerificarCampos(Me) Then

            Dim id As String
            Dim nombre As String
            id = dgvDatos.CurrentRow.Cells(0).Value.ToString
            nombre = dgvDatos.CurrentRow.Cells(1).Value.ToString



            Select Case MsgBox("Desea actualizar el distribuidor" & txtNombre.Text & " " & txtDescripcion.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Baja Autor")
                Case MsgBoxResult.Yes
                    'Dim uncli As New clsECliente(mskCi.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTel.Text, txtEmail.Text)
                    Dim undis As New clsEDistribuidor 'Crea el empleado
                    undis.id = txtId.Text 'Carga los datos del empleado
                    undis.nombre = txtNombre.Text
                    undis.descripcion = txtDescripcion.Text
                    undis.email = txtEmail.Text
                    undis.telefono = txtTelefono.Text

                    Dim unaC As New clsControladora
                    If unaC.ModificarDistribuidor(undis) Then
                        MsgBox("Distribuidor Actualizado Correctamente")
                        Listar()
                    Else
                        MsgBox("Ocurrio un error al actualizar el Distribuidor")
                    End If
                    'Case MsgBoxResult.No
                    '    MessageBox.Show("NO button")
            End Select

        Else
            MsgBox("Hay Campos Vacios")

        End If



    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs)
        If Not IsNumeric(txtId.Text) And txtId.Text <> "" Then
            MsgBox("Se ingresaron caracteres no esperados")

        End If
    End Sub

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged
        If Not IsNumeric(txtTelefono.Text) And txtTelefono.Text <> "" Then
            MsgBox("Se ingresaron caracteres no esperados")

        End If
    End Sub

    Private Sub txtId_MouseClick(sender As Object, e As MouseEventArgs) Handles txtId.MouseClick
        txtId.Select(0, 0)
    End Sub
End Class