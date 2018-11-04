<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
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
        Me.ClienteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoEmpleadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DistribuidorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OfertaWebToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtraToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SKEREMODODIABLOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YABASTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.GroupAlertas = New System.Windows.Forms.GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSkere = New System.Windows.Forms.Timer(Me.components)
        Me.PedidoAlDistribuidorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupAlertas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblBienvenida.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblBienvenida.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenida.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblBienvenida.Location = New System.Drawing.Point(906, 67)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(394, 40)
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem1, Me.EmpleadoToolStripMenuItem1, Me.ProductoToolStripMenuItem1, Me.DistribuidorToolStripMenuItem1, Me.StockToolStripMenuItem1, Me.VentaToolStripMenuItem1, Me.OfertaWebToolStripMenuItem1, Me.ExtraToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 130, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(250, 650)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClienteToolStripMenuItem1
        '
        Me.ClienteToolStripMenuItem1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClienteToolStripMenuItem1.Image = CType(resources.GetObject("ClienteToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ClienteToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClienteToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClienteToolStripMenuItem1.Name = "ClienteToolStripMenuItem1"
        Me.ClienteToolStripMenuItem1.Size = New System.Drawing.Size(243, 54)
        Me.ClienteToolStripMenuItem1.Text = "Cliente"
        '
        'EmpleadoToolStripMenuItem1
        '
        Me.EmpleadoToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoEmpleadoToolStripMenuItem1})
        Me.EmpleadoToolStripMenuItem1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpleadoToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EmpleadoToolStripMenuItem1.Image = CType(resources.GetObject("EmpleadoToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.EmpleadoToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EmpleadoToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EmpleadoToolStripMenuItem1.Name = "EmpleadoToolStripMenuItem1"
        Me.EmpleadoToolStripMenuItem1.Size = New System.Drawing.Size(243, 54)
        Me.EmpleadoToolStripMenuItem1.Text = "Empleado"
        '
        'TipoEmpleadoToolStripMenuItem1
        '
        Me.TipoEmpleadoToolStripMenuItem1.Name = "TipoEmpleadoToolStripMenuItem1"
        Me.TipoEmpleadoToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.TipoEmpleadoToolStripMenuItem1.Text = "Cargo"
        '
        'ProductoToolStripMenuItem1
        '
        Me.ProductoToolStripMenuItem1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductoToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProductoToolStripMenuItem1.Name = "ProductoToolStripMenuItem1"
        Me.ProductoToolStripMenuItem1.Size = New System.Drawing.Size(243, 34)
        Me.ProductoToolStripMenuItem1.Text = "Producto"
        '
        'DistribuidorToolStripMenuItem1
        '
        Me.DistribuidorToolStripMenuItem1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DistribuidorToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DistribuidorToolStripMenuItem1.Image = CType(resources.GetObject("DistribuidorToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.DistribuidorToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DistribuidorToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DistribuidorToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PedidoAlDistribuidorToolStripMenuItem})
        Me.DistribuidorToolStripMenuItem1.Name = "DistribuidorToolStripMenuItem1"
        Me.DistribuidorToolStripMenuItem1.Size = New System.Drawing.Size(243, 54)
        Me.DistribuidorToolStripMenuItem1.Text = "Distribuidor"
        '
        'StockToolStripMenuItem1
        '
        Me.StockToolStripMenuItem1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.StockToolStripMenuItem1.Name = "StockToolStripMenuItem1"
        Me.StockToolStripMenuItem1.Size = New System.Drawing.Size(243, 34)
        Me.StockToolStripMenuItem1.Text = "Stock"
        '
        'VentaToolStripMenuItem1
        '
        Me.VentaToolStripMenuItem1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentaToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.VentaToolStripMenuItem1.Image = CType(resources.GetObject("VentaToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.VentaToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VentaToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.VentaToolStripMenuItem1.Name = "VentaToolStripMenuItem1"
        Me.VentaToolStripMenuItem1.Size = New System.Drawing.Size(243, 54)
        Me.VentaToolStripMenuItem1.Text = "Venta"
        '
        'OfertaWebToolStripMenuItem1
        '
        Me.OfertaWebToolStripMenuItem1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OfertaWebToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.OfertaWebToolStripMenuItem1.Name = "OfertaWebToolStripMenuItem1"
        Me.OfertaWebToolStripMenuItem1.Size = New System.Drawing.Size(243, 34)
        Me.OfertaWebToolStripMenuItem1.Text = "OfertaWeb"
        '
        'ExtraToolStripMenuItem1
        '
        Me.ExtraToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SKEREMODODIABLOToolStripMenuItem, Me.YABASTAToolStripMenuItem})
        Me.ExtraToolStripMenuItem1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtraToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ExtraToolStripMenuItem1.Name = "ExtraToolStripMenuItem1"
        Me.ExtraToolStripMenuItem1.Size = New System.Drawing.Size(243, 34)
        Me.ExtraToolStripMenuItem1.Text = "Extra"
        Me.ExtraToolStripMenuItem1.Visible = False
        '
        'SKEREMODODIABLOToolStripMenuItem
        '
        Me.SKEREMODODIABLOToolStripMenuItem.Name = "SKEREMODODIABLOToolStripMenuItem"
        Me.SKEREMODODIABLOToolStripMenuItem.Size = New System.Drawing.Size(323, 34)
        Me.SKEREMODODIABLOToolStripMenuItem.Text = "SKEREMODODIABLO"
        '
        'YABASTAToolStripMenuItem
        '
        Me.YABASTAToolStripMenuItem.Name = "YABASTAToolStripMenuItem"
        Me.YABASTAToolStripMenuItem.Size = New System.Drawing.Size(323, 34)
        Me.YABASTAToolStripMenuItem.Text = "YABASTA"
        Me.YABASTAToolStripMenuItem.Visible = False
        '
        'ListView1
        '
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
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(218, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'BarraTitulo
        '
        Me.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTitulo.Location = New System.Drawing.Point(250, 0)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(1050, 50)
        Me.BarraTitulo.TabIndex = 11
        '
        'PedidoAlDistribuidorToolStripMenuItem
        '
        Me.PedidoAlDistribuidorToolStripMenuItem.Name = "PedidoAlDistribuidorToolStripMenuItem"
        Me.PedidoAlDistribuidorToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.PedidoAlDistribuidorToolStripMenuItem.Text = "Pedido al distribuidor"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1300, 650)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupAlertas)
        Me.Controls.Add(Me.lblBienvenida)
        Me.Controls.Add(Me.BarraTitulo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sodivom"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupAlertas.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
