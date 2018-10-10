Imports System.ComponentModel
Imports Entidades

Public Class frmPrincipal
    Private mempleado As New clsEEmpleado

    Public Property empleado As clsEEmpleado
        Get
            Return mempleado
        End Get
        Set(value As clsEEmpleado)
            mempleado = value
        End Set
    End Property

    Private Sub frmPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()

    End Sub

    Private Sub frmPrincipal_MdiChildActivate(sender As Object, e As EventArgs) Handles Me.MdiChildActivate
        Dim activeChild As Form = Me.ActiveMdiChild
        If (Not activeChild Is Nothing) Then
            lblBienvenida.SendToBack()
        Else
            lblBienvenida.BringToFront()
        End If
    End Sub

    Private Sub lblBienvenida_DoubleClick(sender As Object, e As EventArgs) Handles lblBienvenida.DoubleClick
        ExtraToolStripMenuItem1.Visible = True

    End Sub





    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblBienvenida.Text = "Bienvenido " & empleado.nombre & "" 'Carga el nombre del empleado en la etiqueta de bienvenida

        Select Case empleado.tipoEmpleado
            Case 1 'Administrador
                'Realiza todo
                'ClienteToolStripMenuItem.Visible = True
                'EmpleadoToolStripMenuItem.Visible = True
                'ProductoToolStripMenuItem.Visible = True
                'StockToolStripMenuItem.Visible = True
                'DistribuidorToolStripMenuItem.Visible = True
                'VentaToolStripMenuItem.Visible = True
                'OfertaWebToolStripMenuItem.Visible = True
            Case 2 'Cajero
                ClienteToolStripMenuItem1.Visible = False
                EmpleadoToolStripMenuItem1.Visible = False
                ProductoToolStripMenuItem1.Visible = False
                StockToolStripMenuItem1.Visible = False
                DistribuidorToolStripMenuItem1.Visible = False
                OfertaWebToolStripMenuItem1.Visible = False
            Case 3 ' Reponedor
                ClienteToolStripMenuItem1.Visible = False
                EmpleadoToolStripMenuItem1.Visible = False
                DistribuidorToolStripMenuItem1.Visible = False
                VentaToolStripMenuItem1.Visible = False
                OfertaWebToolStripMenuItem1.Visible = False
            Case 4 ' Vendedor
                ClienteToolStripMenuItem1.Visible = False
                EmpleadoToolStripMenuItem1.Visible = False
                DistribuidorToolStripMenuItem1.Visible = False
                VentaToolStripMenuItem1.Visible = False
                ProductoToolStripMenuItem1.Visible = False
            Case 5 'Administrativo

            Case Else ' Tiene los mismos permisos que un vendedor
                ClienteToolStripMenuItem1.Visible = False
                EmpleadoToolStripMenuItem1.Visible = False
                DistribuidorToolStripMenuItem1.Visible = False
                VentaToolStripMenuItem1.Visible = False
                ProductoToolStripMenuItem1.Visible = False
                empleado.tipoEmpleado = 4


        End Select


        'ClienteToolStripMenuItem.Visible = True
        'EmpleadoToolStripMenuItem.Visible = True
        'ProductoToolStripMenuItem.Visible = True
        'StockToolStripMenuItem.Visible = True
        'DistribuidorToolStripMenuItem.Visible = True
        'VentaToolStripMenuItem.Visible = True
        'OfertaWebToolStripMenuItem.Visible = True
    End Sub

    Private Sub ClienteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem1.Click
        Dim unfrmCli As New frmCliente
        unfrmCli.MdiParent = Me
        unfrmCli.Show()
    End Sub

    Private Sub EmpleadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem1.Click
        Dim unfrmEmp As New frmEmpleado
        unfrmEmp.MdiParent = Me
        unfrmEmp.unempl = empleado 'Envia datos del empleado al formulario
        unfrmEmp.Show()
    End Sub

    Private Sub TipoEmpleadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TipoEmpleadoToolStripMenuItem1.Click
        Dim unfrmTEmp As New frmTipoEmpleado
        unfrmTEmp.MdiParent = Me
        unfrmTEmp.Show()
    End Sub

    Private Sub ProductoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem1.Click
        Dim unfrmProd As New frmProducto
        unfrmProd.MdiParent = Me
        unfrmProd.Unempleado = empleado 'Envia datos del empleado al formulario
        unfrmProd.Show()
    End Sub

    Private Sub ProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DistribuidorToolStripMenuItem1.Click
        Dim unfrmDist As New frmDistribuidor
        unfrmDist.MdiParent = Me
        unfrmDist.Show()
    End Sub

    Private Sub StockToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem1.Click
        Dim unfrmStk As New frmStock
        unfrmStk.MdiParent = Me
        unfrmStk.unempl = empleado 'Envia datos del empleado al formulario
        unfrmStk.Show()
    End Sub

    Private Sub VentaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VentaToolStripMenuItem1.Click
        Dim unfrmVenta As New frmVenta
        unfrmVenta.MdiParent = Me
        unfrmVenta.unempl = empleado
        unfrmVenta.Show()
    End Sub

    Private Sub OfertaWebToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OfertaWebToolStripMenuItem1.Click
        Dim unfrmOW As New frmOfertaWeb
        unfrmOW.MdiParent = Me
        unfrmOW.Show()
    End Sub

    Private Sub SKEREMODODIABLOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SKEREMODODIABLOToolStripMenuItem.Click
        Me.BackgroundImage = My.Resources._274976300bafcabe798a4da051f8fb62b6c99fbbv2_00
        My.Computer.Audio.Play(My.Resources.Skere, AudioPlayMode.BackgroundLoop)
        YABASTAToolStripMenuItem.Visible = True
    End Sub

    Private Sub YABASTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YABASTAToolStripMenuItem.Click
        My.Computer.Audio.Stop()
    End Sub
End Class
