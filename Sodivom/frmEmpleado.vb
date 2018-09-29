Imports Dominio
Imports Entidades
Public Class frmEmpleado
    Dim listaCargos As New List(Of clsETipoEmpleado)
    Dim unaCon As New clsControladora

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Dim unLim As New clsLimpiar
        unLim.Limpiar(Me)


    End Sub

    Private Sub frmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaCargos = unaCon.ListadoTipoEmpleado()
        For Each tipoEmpleado In listaCargos
            comboCargo.Items.Add(tipoEmpleado.TipoEmpleado.ToString)
        Next


    End Sub
End Class