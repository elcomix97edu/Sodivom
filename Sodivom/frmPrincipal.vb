Imports System.ComponentModel

Public Class frmPrincipal


    Private Sub frmPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()

    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Dim unfrmCli As New frmCliente
        unfrmCli.MdiParent = Me
        unfrmCli.Show()
    End Sub

    Private Sub EmpleadoToolStripMenuItem_DoubleClick(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.DoubleClick
        Dim unfrmEmp As New frmEmpleado
        unfrmEmp.MdiParent = Me
        unfrmEmp.Show()
    End Sub

    Private Sub TipoEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoEmpleadoToolStripMenuItem.Click
        Dim unfrmTEmp As New frmTipoEmpleado
        unfrmTEmp.MdiParent = Me
        unfrmTEmp.Show()
    End Sub

    Private Sub frmPrincipal_MdiChildActivate(sender As Object, e As EventArgs) Handles Me.MdiChildActivate
        Dim activeChild As Form = Me.ActiveMdiChild
        If (Not activeChild Is Nothing) Then
            lblBienvenida.SendToBack()
        Else
            lblBienvenida.BringToFront()
        End If
    End Sub


End Class
