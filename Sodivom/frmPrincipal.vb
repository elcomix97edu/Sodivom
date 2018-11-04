Imports System.ComponentModel
Imports Dominio
Imports Entidades

Public Class frmPrincipal
    Private mempleado As New clsEEmpleado
    '//////Some Things in case of a nuclear war
    Dim maxX As Integer
    Dim maxY As Integer
    Dim posX As Integer
    Dim posY As Integer
    Dim sumarX As Boolean = True
    Dim SumarY As Boolean = False
    Dim rnd As New Random
    Dim player As New Media.SoundPlayer
    '///////////

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
            GroupAlertas.SendToBack()
        Else
            lblBienvenida.BringToFront()
            GroupAlertas.BringToFront()
        End If
    End Sub

    Private Sub lblBienvenida_DoubleClick(sender As Object, e As EventArgs) Handles lblBienvenida.DoubleClick
        ExtraToolStripMenuItem1.Visible = True

    End Sub





    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblBienvenida.Text = "Bienvenido " & empleado.nombre & "" 'Carga el nombre del empleado en la etiqueta de bienvenida

        AlertaBajoStock()

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
        '///////////Why are you looking this code??////////////
        maxX = Me.Size.Width
        maxX = maxX - lblBienvenida.Size.Width

        maxY = Me.Size.Height
        maxY = maxY - lblBienvenida.Size.Height

        posX = lblBienvenida.Location.X
        posY = lblBienvenida.Location.Y
        '//////////////////////////////////


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
        My.Computer.Audio.Play(My.Resources.Skere2, AudioPlayMode.BackgroundLoop)
        YABASTAToolStripMenuItem.Visible = True
        Timer1.Enabled = True
        lblBienvenida.Text = "SKEREEEEEE!!!!!!!"

        Dim song_path As String = My.Computer.FileSystem.GetTempFileName
        Dim bytes(CInt(My.Resources.Skere2.Length - 1)) As Byte
        My.Resources.Skere2.Read(bytes, 0, CInt(My.Resources.Skere2.Length))
        IO.File.WriteAllBytes(song_path, bytes)


        player.SoundLocation = song_path
        player.PlayLooping()

        TimerSkere.Enabled = True

    End Sub


    Private Sub YABASTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YABASTAToolStripMenuItem.Click
        My.Computer.Audio.Stop()
        lblBienvenida.Text = "Bienvenid@ " & empleado.nombre & ""
        Timer1.Enabled = False
        TimerSkere.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If posX = maxX Then
            sumarX = False
        ElseIf posX < 0 Then
            sumarX = True
        End If

        If posY < 0 Then
            SumarY = True
        ElseIf posY = maxY Then
            SumarY = False
        End If

        If sumarX Then
            posX = posX + 5
        Else
            posX = posX - 5

        End If

        If SumarY Then
            posY = posY + 5
        Else
            posY = posY - 5
        End If

        lblBienvenida.Location = New Point(posX, posY)
        lblBienvenida.ForeColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
        'Me.BackColor = Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255))
    End Sub

    Private Sub TimerSkere_Tick(sender As Object, e As EventArgs) Handles TimerSkere.Tick
        Dim song_path As String = My.Computer.FileSystem.GetTempFileName
        Dim bytes(CInt(My.Resources.SKEREEEEEEEE.Length - 1)) As Byte
        My.Resources.SKEREEEEEEEE.Read(bytes, 0, CInt(My.Resources.SKEREEEEEEEE.Length))
        IO.File.WriteAllBytes(song_path, bytes)

        Dim player2 As New Media.SoundPlayer
        player2.SoundLocation = song_path
        player2.Play()

        System.Threading.Thread.Sleep(1800)
        player.PlayLooping()

        TimerSkere.Interval = (rnd.Next(9) + 1) * 1000

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged



    End Sub

    Private Sub AlertaBajoStock()
        Dim con As New clsControladora
        Dim ListaProd = con.ListarProducto("", 1)

        For Each prod In ListaProd
            Dim minstock = con.GetMinStock(prod.codigo) 'Minimo de stock en productos
            Dim stocksPord = con.GetStocksProd(prod.codigo) 'Stocks del mismo producto
            Dim stock As Integer

            Dim aviso As String


            For Each cosa In stocksPord
                stock += cosa.stock
            Next
            If stock < minstock Then

                aviso = "El stock de " & prod.nombre & " esta por debajo del minimo definido (" & prod.minstock & "), quedan " & stock & "."
                Dim lista As ListViewItem = New ListViewItem(aviso)
                ListView1.Items.Add(lista)
            End If

        Next
    End Sub

    Private Sub lblBienvenida_Click(sender As Object, e As EventArgs) Handles lblBienvenida.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub
End Class
