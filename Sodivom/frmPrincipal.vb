Imports System.ComponentModel

Public Class frmPrincipal


    Private Sub frmPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()

    End Sub

    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarToolStripMenuItem.Click
        Dim unfrmaltacliente As New frmAltaCliente
        unfrmaltacliente.MdiParent = Me
        unfrmaltacliente.Show()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        Dim unfrmmodcliente As New frmModificarCliente
        unfrmmodcliente.MdiParent = Me
        unfrmmodcliente.Show()
    End Sub
End Class
