Imports Entidades
Imports Dominio


Public Class frmAltaCliente
    Private Sub frmAltaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim cli As New clsECliente(CInt(txtCedula.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text)
        Dim dcli As New clsDCliente
        If dcli.AgregarCliente(cli) Then
            MsgBox("Cliente agregado Correctamente")
        Else
            MsgBox("Hubo un error al agregar el cliente")
        End If
    End Sub
End Class