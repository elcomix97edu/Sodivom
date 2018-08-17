Imports MySql.Data.MySqlClient
Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim bd As New clsPersistencia
        Dim consulta As String
        Dim res As MySqlDataReader
        Dim ress As String = ""
        consulta = "SELECT pass FROM usuarios WHERE user= '" & txtuser.Text & "' "
        res = bd.ejecutarYdevolver(consulta)
        While res.Read
            ress = res.Item("pass").ToString
        End While
        If ress = txtpass.Text Then
            MsgBox("Tas RE puto")
        Else
            MsgBox("Usuario y/o contraseña incorrectos")
        End If


    End Sub
End Class