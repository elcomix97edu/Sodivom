Imports Dominio
Imports Entidades
Public Class frmEmpleado
    Dim listaCargos As New List(Of clsETipoEmpleado)
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

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Dim unLim As New clsLimpiar
        unLim.Limpiar(Me)


    End Sub

    Private Sub frmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaCargos = unaCon.ListadoTipoEmpleado()
        For Each tipoEmpleado In listaCargos
            comboCargo.Items.Add(tipoEmpleado.TipoEmpleado.ToString)
        Next

        If unempl.tipoEmpleado = 5 Then ' Si es Administrativo
            btnEliminar.Enabled = False
            btnModificar.Enabled = False
        End If

    End Sub

    Private Function GetIdTipoEmpl(tipo As String) As Integer
        Dim selectedValue As clsETipoEmpleado
        selectedValue = listaCargos.Find(Function(p) p.tipoEmpleado = tipo)
        Return selectedValue.id
    End Function

    Private Function GetNameTipoEmpl(id As Integer) As String
        Dim selectedValue As clsETipoEmpleado
        selectedValue = listaCargos.Find(Function(p) p.id = id)
        Return selectedValue.tipoEmpleado
    End Function

    Private Sub Listar()
        If Not (rdbCi.Checked Or rdbApellido.Checked Or rdbCargo.Checked) Then
            MsgBox("Seleccione un Parámetro de Búsqueda")
        Else

            Dim res As String
            Dim realiza As Boolean = False
            Dim busqueda As Integer

            If rdbCi.Checked Then
                If mskCi.Text = "" Then
                    MsgBox("El campo Ci está vacio")
                Else
                    res = mskCi.Text
                    busqueda = 1
                    realiza = True
                End If

            ElseIf rdbApellido.Checked Then

                If txtApellido.Text = "" Then
                    MsgBox("El campo Apellido está vacio")
                Else
                    res = txtApellido.Text
                    busqueda = 2
                    realiza = True
                End If
            Else
                If comboCargo.Text = "" Then
                    MsgBox("El campo Cargo está vacio")
                Else
                    res = GetIdTipoEmpl(comboCargo.Text)
                    busqueda = 3
                    realiza = True
                End If

            End If
            If realiza Then
                Dim lista = unaCon.ListarEmpleado(res, busqueda)
                dgvDatos.Rows.Clear()

                Dim Row As DataGridViewRow
                Dim Cell As DataGridViewCell
                Dim a As Integer = 0

                For Each unEmpleado In lista
                    Row = New DataGridViewRow

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unEmpleado.ci.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unEmpleado.nombre.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unEmpleado.apellido.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unEmpleado.direccion.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unEmpleado.telefono.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unEmpleado.email.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unEmpleado.sueldo.ToString
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = GetNameTipoEmpl(unEmpleado.tipoEmpleado.ToString)
                    Row.Cells.Add(Cell)

                    Cell = New DataGridViewTextBoxCell
                    Cell.Value = unEmpleado.contrseña.ToString
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

            If val.VerificarCI(CInt(mskCi.Text)) Then
                If unaCon.ExisteEmpleado(CInt(mskCi.Text)) = False Then

                    If unaCon.ExistePersona(mskCi.Text) = False Then

                        'Lo que realmente estas buscando
                        'Dim cli As New clsEEmpleado(CInt(mskCi.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTel.Text, txtEmail.Text)
                        Dim empl As New clsEEmpleado
                        empl.ci = mskCi.Text
                        empl.nombre = txtNombre.Text
                        empl.apellido = txtApellido.Text
                        empl.direccion = txtDireccion.Text
                        empl.telefono = txtTel.Text
                        empl.email = txtEmail.Text
                        empl.sueldo = txtSueldo.Text
                        empl.contrseña = txtContraseña.Text
                        empl.tipoEmpleado = GetIdTipoEmpl(comboCargo.Text)

                        If unaCon.AgregarEmpleado(empl) Then
                            MsgBox("Empleado agregado Correctamente")
                        Else
                            MsgBox("Hubo un error al agregar el Empleado")
                        End If

                    Else
                        MsgBox("Persona registrada como Cliente")
                    End If




                Else
                    MsgBox("Empleado existente")

                End If
            Else
                MsgBox("Cédula Inválida")
            End If
        Else
            MsgBox("Hay Campos Vacios")
        End If

    End Sub

    Private Sub dgvDatos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDatos.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then 'Verifica que los click no sean el los bordes
            mskCi.Text = dgvDatos.CurrentRow.Cells(0).Value.ToString
            txtNombre.Text = dgvDatos.CurrentRow.Cells(1).Value.ToString
            txtApellido.Text = dgvDatos.CurrentRow.Cells(2).Value.ToString
            txtDireccion.Text = dgvDatos.CurrentRow.Cells(3).Value.ToString
            txtTel.Text = dgvDatos.CurrentRow.Cells(4).Value.ToString
            txtEmail.Text = dgvDatos.CurrentRow.Cells(5).Value.ToString
            txtSueldo.Text = dgvDatos.CurrentRow.Cells(6).Value.ToString
            comboCargo.Text = dgvDatos.CurrentRow.Cells(7).Value.ToString
            txtContraseña.Text = dgvDatos.CurrentRow.Cells(8).Value.ToString
            mskCi.Enabled = False
        End If
    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Listar()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim val As New clsValidar

        If val.VerificarCampos(Me) Then

            Dim ci As Integer
            ci = CInt(mskCi.Text)


            Select Case MsgBox("Desea quitar el empleado " & txtNombre.Text & " " & txtApellido.Text & " del sistema?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Baja Empleado")
                Case MsgBoxResult.Yes
                    Dim unaC As New clsControladora
                    If unaC.EliminarEmpleado(ci) Then
                        MsgBox("Empleado Eliminado Correctamente")
                        Listar()
                    Else
                        MsgBox("Ocurrio un error al eliminar el Empleado")
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

            Select Case MsgBox("Desea actualizar el empleado " & txtNombre.Text & " " & txtApellido.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Baja Autor")
                Case MsgBoxResult.Yes
                    'Dim uncli As New clsECliente(mskCi.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTel.Text, txtEmail.Text)
                    Dim unempl As New clsEEmpleado 'Crea el empleado
                    unempl.ci = mskCi.Text 'Carga los datos del empleado
                    unempl.nombre = txtNombre.Text
                    unempl.apellido = txtApellido.Text
                    unempl.direccion = txtDireccion.Text
                    unempl.email = txtEmail.Text
                    unempl.telefono = txtTel.Text
                    unempl.sueldo = txtSueldo.Text
                    unempl.contrseña = txtContraseña.Text
                    unempl.tipoEmpleado = GetIdTipoEmpl(comboCargo.Text)

                    Dim unaC As New clsControladora
                    If unaC.ModificarEmpleado(unempl) Then
                        MsgBox("Empleado Actualizado Correctamente")
                        Listar()
                    Else
                        MsgBox("Ocurrio un error al actualizar el Empleado")
                    End If
                    'Case MsgBoxResult.No
                    '    MessageBox.Show("NO button")
            End Select

        Else
            MsgBox("Hay Campos Vacios")

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

    Private Sub txtTel_TextChanged(sender As Object, e As EventArgs) Handles txtTel.TextChanged
        If Not IsNumeric(txtTel.Text) And txtTel.Text <> "" Then
            MsgBox("Se ingresaron caracteres no esperados")

        End If
    End Sub

    Private Sub txtSueldo_TextChanged(sender As Object, e As EventArgs) Handles txtSueldo.TextChanged
        If Not IsNumeric(txtSueldo.Text) And txtSueldo.Text <> "" Then
            MsgBox("Se ingresaron caracteres no esperados")

        End If
    End Sub
End Class