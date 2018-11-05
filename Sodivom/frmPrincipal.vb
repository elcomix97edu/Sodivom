Imports System.ComponentModel
Imports Newtonsoft.Json
Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions
Imports Dominio
Imports Entidades
Imports Newtonsoft.Json.Linq

Public Class Inicio
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
            GroupBox1.SendToBack()
        Else
            lblBienvenida.BringToFront()
            GroupAlertas.BringToFront()
            GroupBox1.BringToFront()
        End If
    End Sub

    Private Sub lblBienvenida_DoubleClick(sender As Object, e As EventArgs) Handles lblBienvenida.DoubleClick
        ExtraToolStripMenuItem1.Visible = True

    End Sub







    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblBienvenida.Text = "Bienvenid@ " & empleado.nombre & "" 'Carga el nombre del empleado en la etiqueta de bienvenida

        AlertaBajoStock()
        AlertaFechaVencimiento()
        Cotizacion()


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

    Public Sub Cotizacion()
        Try

            Dim request As HttpWebRequest
            Dim response As HttpWebResponse = Nothing
            Dim reader As StreamReader
            Dim rawresp As String
            Dim jResults As Object
            Dim valor As Decimal

            '////////Dolar
            request = DirectCast(WebRequest.Create("https://free.currencyconverterapi.com/api/v5/convert?q=USD_UYU&compact=ultra"), HttpWebRequest)

            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())


            rawresp = reader.ReadToEnd()

            jResults = JObject.Parse(rawresp)
            valor = If(jResults("USD_UYU") Is Nothing, "", jResults("USD_UYU").ToString())
            txtPrecioDolar.Text = valor.ToString("F2")


            '////////Euro
            request = DirectCast(WebRequest.Create("https://free.currencyconverterapi.com/api/v5/convert?q=EUR_UYU&compact=ultra"), HttpWebRequest)

            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())


            rawresp = reader.ReadToEnd()

            jResults = JObject.Parse(rawresp)
            valor = If(jResults("EUR_UYU") Is Nothing, "", jResults("EUR_UYU").ToString())
            txtPrecioEuro.Text = valor.ToString("F2")



            '////////Peso Argentino
            request = DirectCast(WebRequest.Create("https://free.currencyconverterapi.com/api/v5/convert?q=ARS_UYU&compact=ultra"), HttpWebRequest)

            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())


            rawresp = reader.ReadToEnd()

            jResults = JObject.Parse(rawresp)
            valor = If(jResults("ARS_UYU") Is Nothing, "", jResults("ARS_UYU").ToString())
            txtPrecioArg.Text = valor.ToString("F2")


            '////////Real
            request = DirectCast(WebRequest.Create("https://free.currencyconverterapi.com/api/v5/convert?q=BRL_UYU&compact=ultra"), HttpWebRequest)

            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())


            rawresp = reader.ReadToEnd()

            jResults = JObject.Parse(rawresp)
            valor = If(jResults("BRL_UYU") Is Nothing, "", jResults("BRL_UYU").ToString())
            txtPrecioBr.Text = valor.ToString("F2")

        Catch ex As Exception
            MsgBox("No se podrá cargar las cotizaciones actuales, no hay conexión a internet")
        End Try




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
        GroupAlertas.SendToBack()
        GroupBox1.SendToBack()
        Timer1.Enabled = True
        lblBienvenida.Text = "SKEREEEEEE!!!!!!!"
        MsgBox("Agradesco al trapsito por permitirme culminar este programa :D")

        Dim song_path As String = My.Computer.FileSystem.GetTempFileName
        Dim bytes(CInt(My.Resources.Skere2.Length - 1)) As Byte
        My.Resources.Skere2.Read(bytes, 0, CInt(My.Resources.Skere2.Length))
        IO.File.WriteAllBytes(song_path, bytes)


        player.SoundLocation = song_path
        player.PlayLooping()

        TimerSkere.Enabled = True

    End Sub

    'Public Function CurrencyConvert() As String

    '    'Grab your values and build your Web Request to the API
    '    Dim apiURL As String = String.Format("https://free.currencyconverterapi.com/api/v5/convert?q=USD_UYU&compact=ultra")

    '    'Make your Web Request and grab the results
    '    Dim request = WebRequest.Create(apiURL)

    '    'Get the Response
    '    Dim streamReader = New StreamReader(request.GetResponse().GetResponseStream(), System.Text.Encoding.ASCII)

    '    'Grab your converted value (ie 2.45 USD)
    '    Dim result = JsonReade

    '    'Get the Result
    '    Return result
    'End Function


    Private Sub YABASTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YABASTAToolStripMenuItem.Click
        My.Computer.Audio.Stop()
        lblBienvenida.Location = New Point(250, 528)
        lblBienvenida.Text = "Bienvenid@ " & empleado.nombre & ""
        GroupAlertas.BringToFront()
        GroupBox1.BringToFront()
        Timer1.Enabled = False
        TimerSkere.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If posX > maxX Then
            sumarX = False
        ElseIf posX < 0 Then
            sumarX = True
        End If

        If posY < 0 Then
            SumarY = True
        ElseIf posY > maxY Then
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

    Private Sub PedidoAlDistribuidorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidoAlDistribuidorToolStripMenuItem.Click
        Dim unfrmpedido As New frmPedidodistribuidor
        unfrmpedido.MdiParent = Me
        unfrmpedido.Show()
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

                aviso = "El stock de " & prod.nombre & " esta por debajo del minimo definido (" & prod.minstock & "), " & stock & "."
                Dim lista As ListViewItem = New ListViewItem(aviso)
                ListView1.Items.Add(lista)
            End If
            stock = 0

        Next
    End Sub

    Private Sub AlertaFechaVencimiento()
        Dim con As New clsControladora
        Dim ListaProd = con.ListarProducto("", 1)

        For Each prod In ListaProd
            Dim stocksPord = con.GetStocksProd(prod.codigo) 'Stocks del mismo producto
            Dim fechacomparacion As Date = Date.Now
            fechacomparacion = fechacomparacion.AddDays(15)
            Dim aviso As String
            Dim novence As Date
            novence = CDate("1/1/1920")


            For Each lote In stocksPord
                If lote.fechaven <> novence Then

                    If lote.fechaven < fechacomparacion Then

                        aviso = "La fecha de caducidad de " & prod.nombre & " se acerca, se vence el" & lote.fechaven & "."
                        Dim lista As ListViewItem = New ListViewItem(aviso)
                        ListView1.Items.Add(lista)
                    End If
                End If



            Next


        Next
    End Sub


    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        For Each frm In Me.MdiChildren
            frm.Close()
        Next
    End Sub
End Class

