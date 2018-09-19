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
End Class