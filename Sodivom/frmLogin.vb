Imports Dominio
Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim unValidar As New clsValidar

        If unValidar.Valido(mskCi.Text) Then

            If unValidar.Valido(txtpass.Text) Then

                'cabra
                Dim unDE As New clsControladora
                Dim empleado = unDE.login(mskCi.Text, txtpass.Text)
                If empleado IsNot Nothing Then
                    'MsgBox("Despliego formulario principal")
                    Dim frmp As New frmPrincipal
                    frmp.empleado = empleado
                    frmp.Show()
                    Me.Hide()

                Else
                    MsgBox("Usuario y/o contraseña incorrectos")
                End If

            Else
                MsgBox("Contraseña en blanco")
            End If

        Else
            MsgBox("Usuario en blanco")
        End If




    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub mskCi_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskCi.MaskInputRejected

    End Sub

    Private Sub txtpass_TextChanged(sender As Object, e As EventArgs) Handles txtpass.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class