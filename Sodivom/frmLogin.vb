Imports Dominio
Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        'cabra
        Dim unDE As New clsDEmpleado
        Dim ok = unDE.login(txtuser.Text, txtpass.Text)
        If ok Then
            'MsgBox("Despliego formulario principal")
            Dim frmp As New frmPrincipal
            frmp.Show()
            Me.Hide()

        Else
            MsgBox("Usuario y/o contraseña incorrectos")
        End If


    End Sub
End Class