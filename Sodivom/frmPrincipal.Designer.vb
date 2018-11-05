<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DistribuidorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODODIABLOSKEREToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblBienvenida = New System.Windows.Forms.Label()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OfertaWebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VentaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoEmpleadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DistribuidorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PedidoAlDistribuidorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OfertaWebToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtraToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SKEREMODODIABLOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YABASTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.GroupAlertas = New System.Windows.Forms.GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSkere = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtPrecioDolar = New System.Windows.Forms.Label()
        Me.txtPrecioEuro = New System.Windows.Forms.Label()
        Me.txtPrecioArg = New System.Windows.Forms.Label()
        Me.txtPrecioBr = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupAlertas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraTitulo.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.DoubleClickEnabled = True
        Me.EmpleadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoEmpleadoToolStripMenuItem})
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.EmpleadoToolStripMenuItem.Text = "Empleado"
        '
        'TipoEmpleadoToolStripMenuItem
        '
        Me.TipoEmpleadoToolStripMenuItem.Name = "TipoEmpleadoToolStripMenuItem"
        Me.TipoEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TipoEmpleadoToolStripMenuItem.Text = "TipoEmpleado"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'DistribuidorToolStripMenuItem
        '
        Me.DistribuidorToolStripMenuItem.Name = "DistribuidorToolStripMenuItem"
        Me.DistribuidorToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.DistribuidorToolStripMenuItem.Text = "Distribuidor"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.VentaToolStripMenuItem.Text = "Venta"
        '
        'ExtraToolStripMenuItem
        '
        Me.ExtraToolStripMenuItem.Name = "ExtraToolStripMenuItem"
        Me.ExtraToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ExtraToolStripMenuItem.Text = "Extra"
        Me.ExtraToolStripMenuItem.Visible = False
        '
        'MODODIABLOSKEREToolStripMenuItem
        '
        Me.MODODIABLOSKEREToolStripMenuItem.Name = "MODODIABLOSKEREToolStripMenuItem"
        Me.MODODIABLOSKEREToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.MODODIABLOSKEREToolStripMenuItem.Text = "MODO DIABLO SKERE"
        '
        'lblBienvenida
        '
        Me.lblBienvenida.BackColor = System.Drawing.Color.Black
        Me.lblBienvenida.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenida.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBienvenida.Location = New System.Drawing.Point(250, 528)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(1055, 40)
        Me.lblBienvenida.TabIndex = 3
        Me.lblBienvenida.Text = "Bienvenido"
        Me.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'OfertaWebToolStripMenuItem
        '
        Me.OfertaWebToolStripMenuItem.Name = "OfertaWebToolStripMenuItem"
        Me.OfertaWebToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.OfertaWebToolStripMenuItem.Text = "Oferta Web"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentaToolStripMenuItem1, Me.ClienteToolStripMenuItem1, Me.EmpleadoToolStripMenuItem1, Me.ProductoToolStripMenuItem1, Me.StockToolStripMenuItem1, Me.DistribuidorToolStripMenuItem1, Me.OfertaWebToolStripMenuItem1, Me.ExtraToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 140, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(250, 650)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VentaToolStripMenuItem1
        '
        Me.VentaToolStripMenuItem1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentaToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.VentaToolStripMenuItem1.Image = CType(resources.GetObject("VentaToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.VentaToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VentaToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.VentaToolStripMenuItem1.Name = "VentaToolStripMenuItem1"
        Me.VentaToolStripMenuItem1.Size = New System.Drawing.Size(243, 54)
        Me.VentaToolStripMenuItem1.Text = "Ventas"
        '
        'ClienteToolStripMenuItem1
        '
        Me.ClienteToolStripMenuItem1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClienteToolStripMenuItem1.Image = CType(resources.GetObject("ClienteToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ClienteToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClienteToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClienteToolStripMenuItem1.Name = "ClienteToolStripMenuItem1"
        Me.ClienteToolStripMenuItem1.Size = New System.Drawing.Size(243, 54)
        Me.ClienteToolStripMenuItem1.Text = "Clientes"
        '
        'EmpleadoToolStripMenuItem1
        '
        Me.EmpleadoToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoEmpleadoToolStripMenuItem1})
        Me.EmpleadoToolStripMenuItem1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpleadoToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EmpleadoToolStripMenuItem1.Image = CType(resources.GetObject("EmpleadoToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.EmpleadoToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmpleadoToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EmpleadoToolStripMenuItem1.Name = "EmpleadoToolStripMenuItem1"
        Me.EmpleadoToolStripMenuItem1.Size = New System.Drawing.Size(243, 54)
        Me.EmpleadoToolStripMenuItem1.Text = "Empleados"
        '
        'TipoEmpleadoToolStripMenuItem1
        '
        Me.TipoEmpleadoToolStripMenuItem1.Name = "TipoEmpleadoToolStripMenuItem1"
        Me.TipoEmpleadoToolStripMenuItem1.Size = New System.Drawing.Size(139, 26)
        Me.TipoEmpleadoToolStripMenuItem1.Text = "Cargo"
        '
        'ProductoToolStripMenuItem1
        '
        Me.ProductoToolStripMenuItem1.AutoSize = False
        Me.ProductoToolStripMenuItem1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductoToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProductoToolStripMenuItem1.Image = CType(resources.GetObject("ProductoToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ProductoToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProductoToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProductoToolStripMenuItem1.Name = "ProductoToolStripMenuItem1"
        Me.ProductoToolStripMenuItem1.Size = New System.Drawing.Size(243, 54)
        Me.ProductoToolStripMenuItem1.Text = "Productos"
        Me.ProductoToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StockToolStripMenuItem1
        '
        Me.StockToolStripMenuItem1.AutoSize = False
        Me.StockToolStripMenuItem1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.StockToolStripMenuItem1.Image = CType(resources.GetObject("StockToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.StockToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StockToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StockToolStripMenuItem1.Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.StockToolStripMenuItem1.Name = "StockToolStripMenuItem1"
        Me.StockToolStripMenuItem1.Size = New System.Drawing.Size(243, 54)
        Me.StockToolStripMenuItem1.Text = "Stock"
        Me.StockToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DistribuidorToolStripMenuItem1
        '
        Me.DistribuidorToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PedidoAlDistribuidorToolStripMenuItem})
        Me.DistribuidorToolStripMenuItem1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DistribuidorToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DistribuidorToolStripMenuItem1.Image = CType(resources.GetObject("DistribuidorToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.DistribuidorToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DistribuidorToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DistribuidorToolStripMenuItem1.Name = "DistribuidorToolStripMenuItem1"
        Me.DistribuidorToolStripMenuItem1.Size = New System.Drawing.Size(243, 54)
        Me.DistribuidorToolStripMenuItem1.Text = "Distribuidores"
        '
        'PedidoAlDistribuidorToolStripMenuItem
        '
        Me.PedidoAlDistribuidorToolStripMenuItem.Name = "PedidoAlDistribuidorToolStripMenuItem"
        Me.PedidoAlDistribuidorToolStripMenuItem.Size = New System.Drawing.Size(268, 26)
        Me.PedidoAlDistribuidorToolStripMenuItem.Text = "Pedido al distribuidor"
        '
        'OfertaWebToolStripMenuItem1
        '
        Me.OfertaWebToolStripMenuItem1.AutoSize = False
        Me.OfertaWebToolStripMenuItem1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OfertaWebToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OfertaWebToolStripMenuItem1.Image = CType(resources.GetObject("OfertaWebToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.OfertaWebToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OfertaWebToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OfertaWebToolStripMenuItem1.Name = "OfertaWebToolStripMenuItem1"
        Me.OfertaWebToolStripMenuItem1.Size = New System.Drawing.Size(243, 54)
        Me.OfertaWebToolStripMenuItem1.Text = "Ofertas web"
        Me.OfertaWebToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ExtraToolStripMenuItem1
        '
        Me.ExtraToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SKEREMODODIABLOToolStripMenuItem, Me.YABASTAToolStripMenuItem})
        Me.ExtraToolStripMenuItem1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtraToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ExtraToolStripMenuItem1.Name = "ExtraToolStripMenuItem1"
        Me.ExtraToolStripMenuItem1.Size = New System.Drawing.Size(243, 26)
        Me.ExtraToolStripMenuItem1.Text = "Extra"
        Me.ExtraToolStripMenuItem1.Visible = False
        '
        'SKEREMODODIABLOToolStripMenuItem
        '
        Me.SKEREMODODIABLOToolStripMenuItem.Name = "SKEREMODODIABLOToolStripMenuItem"
        Me.SKEREMODODIABLOToolStripMenuItem.Size = New System.Drawing.Size(268, 26)
        Me.SKEREMODODIABLOToolStripMenuItem.Text = "SKEREMODODIABLO"
        '
        'YABASTAToolStripMenuItem
        '
        Me.YABASTAToolStripMenuItem.Name = "YABASTAToolStripMenuItem"
        Me.YABASTAToolStripMenuItem.Size = New System.Drawing.Size(268, 26)
        Me.YABASTAToolStripMenuItem.Text = "YABASTA"
        Me.YABASTAToolStripMenuItem.Visible = False
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.Location = New System.Drawing.Point(6, 19)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(624, 374)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'GroupAlertas
        '
        Me.GroupAlertas.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupAlertas.Controls.Add(Me.ListView1)
        Me.GroupAlertas.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupAlertas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupAlertas.Location = New System.Drawing.Point(270, 67)
        Me.GroupAlertas.Name = "GroupAlertas"
        Me.GroupAlertas.Size = New System.Drawing.Size(635, 399)
        Me.GroupAlertas.TabIndex = 8
        Me.GroupAlertas.TabStop = False
        Me.GroupAlertas.Text = "Alertas"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'TimerSkere
        '
        Me.TimerSkere.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-4, -28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'BarraTitulo
        '
        Me.BarraTitulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BarraTitulo.Controls.Add(Me.PictureBox3)
        Me.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTitulo.Location = New System.Drawing.Point(250, 0)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(1050, 50)
        Me.BarraTitulo.TabIndex = 11
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(6, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(45, 32)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(12, 517)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(107, 108)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(125, 546)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 22)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Desarrollado por"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(149, 568)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 22)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "INTEREX"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(24, 628)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 22)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "equipo1arrayanes2018@gmail.com"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.WindowText
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox7)
        Me.GroupBox1.Controls.Add(Me.PictureBox6)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.PictureBox5)
        Me.GroupBox1.Controls.Add(Me.PictureBox8)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(969, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 399)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cotización"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(50, 344)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 16)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Real"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(19, 272)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Peso Argentino"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(50, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 16)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Euro"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(45, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Dólar"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtPrecioEuro, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPrecioArg, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPrecioBr, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPrecioDolar, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(110, 75)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.15385!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.84615!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(136, 277)
        Me.TableLayoutPanel1.TabIndex = 23
        '
        'txtPrecioDolar
        '
        Me.txtPrecioDolar.AutoSize = True
        Me.txtPrecioDolar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPrecioDolar.Location = New System.Drawing.Point(71, 0)
        Me.txtPrecioDolar.Name = "txtPrecioDolar"
        Me.txtPrecioDolar.Size = New System.Drawing.Size(19, 21)
        Me.txtPrecioDolar.TabIndex = 0
        Me.txtPrecioDolar.Text = "0"
        '
        'txtPrecioEuro
        '
        Me.txtPrecioEuro.AutoSize = True
        Me.txtPrecioEuro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPrecioEuro.Location = New System.Drawing.Point(71, 60)
        Me.txtPrecioEuro.Name = "txtPrecioEuro"
        Me.txtPrecioEuro.Size = New System.Drawing.Size(19, 21)
        Me.txtPrecioEuro.TabIndex = 0
        Me.txtPrecioEuro.Text = "0"
        '
        'txtPrecioArg
        '
        Me.txtPrecioArg.AutoSize = True
        Me.txtPrecioArg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPrecioArg.Location = New System.Drawing.Point(71, 131)
        Me.txtPrecioArg.Name = "txtPrecioArg"
        Me.txtPrecioArg.Size = New System.Drawing.Size(19, 21)
        Me.txtPrecioArg.TabIndex = 0
        Me.txtPrecioArg.Text = "0"
        '
        'txtPrecioBr
        '
        Me.txtPrecioBr.AutoSize = True
        Me.txtPrecioBr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPrecioBr.Location = New System.Drawing.Point(71, 205)
        Me.txtPrecioBr.Name = "txtPrecioBr"
        Me.txtPrecioBr.Size = New System.Drawing.Size(19, 21)
        Me.txtPrecioBr.TabIndex = 0
        Me.txtPrecioBr.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(187, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 21)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(106, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Compra"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.White
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox7.Location = New System.Drawing.Point(22, 291)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(82, 50)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 3
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.Location = New System.Drawing.Point(22, 219)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(82, 50)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 2
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(22, 75)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(82, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(22, 147)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(82, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(263, 374)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 20
        Me.PictureBox8.TabStop = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1300, 650)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupAlertas)
        Me.Controls.Add(Me.lblBienvenida)
        Me.Controls.Add(Me.BarraTitulo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sodivom"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupAlertas.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraTitulo.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DistribuidorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblBienvenida As Label
    Friend WithEvents ExtraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MODODIABLOSKEREToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OfertaWebToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClienteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DistribuidorToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OfertaWebToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExtraToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SKEREMODODIABLOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YABASTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoEmpleadoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListView1 As ListView
    Friend WithEvents GroupAlertas As GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TimerSkere As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BarraTitulo As Panel
    Friend WithEvents PedidoAlDistribuidorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPrecioDolar As Label
    Friend WithEvents txtPrecioEuro As Label
    Friend WithEvents txtPrecioArg As Label
    Friend WithEvents txtPrecioBr As Label
End Class
