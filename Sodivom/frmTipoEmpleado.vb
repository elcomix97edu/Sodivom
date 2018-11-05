Imports Dominio
Public Class frmTipoEmpleado
    Dim unaControladora As New clsControladora

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim val As New clsValidar

        If val.VerificarCampos(Me) Then

            If unaControladora.ExisteTipoEmpleado(txtTipo.Text) Then
                MsgBox("TipoEmpleado Existente")
            Else
                If unaControladora.AltaTipoEmpleado(txtTipo.Text) Then
                    MsgBox("TipoEmpleado Agregado Correctamente")
                    listar()
                Else
                    MsgBox("Error al agregar TipoEmpleado")
                End If
            End If

        Else
            MsgBox("Hay Campos Vacios")
        End If


    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        listar()
    End Sub

    Private Sub listar()
        Dim lista = unaControladora.ListadoTipoEmpleado()
        dgvDatos.Rows.Clear()

        Dim Row As DataGridViewRow
        Dim Cell As DataGridViewCell

        For Each unTipoEmpleado In lista
            Row = New DataGridViewRow

            Cell = New DataGridViewTextBoxCell
            Cell.Value = unTipoEmpleado.Id.ToString
            Row.Cells.Add(Cell)

            Cell = New DataGridViewTextBoxCell
            Cell.Value = unTipoEmpleado.TipoEmpleado.ToString
            Row.Cells.Add(Cell)

            dgvDatos.Rows.Add(Row)

        Next
    End Sub

    Private Sub frmTipoEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listar()

    End Sub


    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim val As New clsValidar

        If val.VerificarCampos(Me) Then

            Select Case MsgBox("Desea eliminar el TipoEmpleado " & txtTipo.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "TipoEmpleado")
                Case MsgBoxResult.Yes
                    unaControladora.BajaTipoEmpleado(txtTipo.Text)
                    MsgBox("Tipo Empleado Eliminado Correctamente")
                    listar()
            End Select

        Else
            MsgBox("Hay Campos Vacios")
        End If



    End Sub

    Private Sub dgvDatos_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvDatos.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then 'Verifica que los click no sean el los bordes
            txtTipo.Text = dgvDatos.CurrentRow.Cells(1).Value.ToString

        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) 

    End Sub
End Class