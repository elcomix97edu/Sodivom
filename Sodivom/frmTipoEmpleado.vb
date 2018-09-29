Imports Dominio
Public Class frmTipoEmpleado
    Dim unaControladora As New clsControladora

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If unaControladora.AltaTipoEmpleado(txtTipo.Text) Then
            MsgBox("TipoEmpleado Agregado Correctamente")
        Else
            MsgBox("Error al agregar TipoEmpleado")
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
        Select Case MsgBox("Desea eliminar el TipoEmpleado " & txtTipo.Text & "?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "TipoEmpleado")
            Case MsgBoxResult.Yes
                unaControladora.BajaTipoEmpleado(txtTipo.Text)
                listar()
        End Select

    End Sub
End Class