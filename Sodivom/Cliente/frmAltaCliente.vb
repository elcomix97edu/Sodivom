Imports Entidades
Imports Dominio


Public Class frmAltaCliente
    Private Sub frmAltaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim val As New clsValidar
        Dim unacon As New clsControladora

        'validaciones
        If val.Valido(txtCedula.Text) Then

            If val.VerificarCI(CInt(txtCedula.Text)) Then
                If unacon.ExisteCliente(CInt(txtCedula.Text)) = False Then

                    If val.Valido(txtNombre.Text) Then

                        If val.Valido(txtApellido.Text) Then

                            If val.Valido(txtDireccion.Text) Then

                                If val.Valido(txtTelefono.Text) Then

                                    If val.Valido(txtEmail.Text) Then

                                        'Lo que realmente estas buscando
                                        Dim cli As New clsECliente(CInt(txtCedula.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text)
                                        Dim dcli As New clsDCliente
                                        If dcli.AgregarCliente(cli) Then
                                            MsgBox("Cliente agregado Correctamente")
                                        Else
                                            MsgBox("Hubo un error al agregar el cliente")
                                        End If

                                    Else
                                        MsgBox("Email en blanco")
                                    End If
                                Else
                                    MsgBox("Teléfono en blanco")
                                End If
                            Else
                                MsgBox("Dirección en blanco")
                            End If
                        Else
                            MsgBox("Apellido en blanco")
                        End If
                    Else
                        MsgBox("Nombre en blanco")
                    End If
                Else
                    MsgBox("Cliente existente")

                End If
            Else
                MsgBox("Cédula Inválida")
            End If
        Else
            MsgBox("Cédula en blanco")
        End If

    End Sub
End Class