<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
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
        Me.MenuStrip1.SuspendLayout()
        Me.GroupAlertas.SuspendLayout()
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
        Me.lblBienvenida.AutoSize = True
        Me.lblBienvenida.BackColor = System.Drawing.Color.Transparent
        Me.lblBienvenida.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenida.Location = New System.Drawing.Point(284, 555)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(148, 31)
        Me.lblBienvenida.TabIndex = 3
        Me.lblBienvenida.Text = "Bienvenido"
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem1, Me.EmpleadoToolStripMenuItem1, Me.ProductoToolStripMenuItem1, Me.DistribuidorToolStripMenuItem1, Me.StockToolStripMenuItem1, Me.VentaToolStripMenuItem1, Me.OfertaWebToolStripMenuItem1, Me.ExtraToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(964, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClienteToolStripMenuItem1
        '
        Me.ClienteToolStripMenuItem1.Name = "ClienteToolStripMenuItem1"
        Me.ClienteToolStripMenuItem1.Size = New System.Drawing.Size(56, 20)
        Me.ClienteToolStripMenuItem1.Text = "Cliente"
        '
        'EmpleadoToolStripMenuItem1
        '
        Me.EmpleadoToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoEmpleadoToolStripMenuItem1})
        Me.EmpleadoToolStripMenuItem1.Name = "EmpleadoToolStripMenuItem1"
        Me.EmpleadoToolStripMenuItem1.Size = New System.Drawing.Size(72, 20)
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
        Me.ProductoToolStripMenuItem1.Name = "ProductoToolStripMenuItem1"
        Me.ProductoToolStripMenuItem1.Size = New System.Drawing.Size(68, 20)
        Me.ProductoToolStripMenuItem1.Text = "Producto"
        '
        'DistribuidorToolStripMenuItem1
        '
        Me.DistribuidorToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PedidoAlDistribuidorToolStripMenuItem})
        Me.DistribuidorToolStripMenuItem1.Name = "DistribuidorToolStripMenuItem1"
        Me.DistribuidorToolStripMenuItem1.Size = New System.Drawing.Size(81, 20)
        Me.DistribuidorToolStripMenuItem1.Text = "Distribuidor"
        '
        'StockToolStripMenuItem1
        '
        Me.StockToolStripMenuItem1.Name = "StockToolStripMenuItem1"
        Me.StockToolStripMenuItem1.Size = New System.Drawing.Size(48, 20)
        Me.StockToolStripMenuItem1.Text = "Stock"
        '
        'VentaToolStripMenuItem1
        '
        Me.VentaToolStripMenuItem1.Name = "VentaToolStripMenuItem1"
        Me.VentaToolStripMenuItem1.Size = New System.Drawing.Size(49, 20)
        Me.VentaToolStripMenuItem1.Text = "Venta"
        '
        'OfertaWebToolStripMenuItem1
        '
        Me.OfertaWebToolStripMenuItem1.Name = "OfertaWebToolStripMenuItem1"
        Me.OfertaWebToolStripMenuItem1.Size = New System.Drawing.Size(76, 20)
        Me.OfertaWebToolStripMenuItem1.Text = "OfertaWeb"
        '
        'ExtraToolStripMenuItem1
        '
        Me.ExtraToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SKEREMODODIABLOToolStripMenuItem, Me.YABASTAToolStripMenuItem})
        Me.ExtraToolStripMenuItem1.Name = "ExtraToolStripMenuItem1"
        Me.ExtraToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.ExtraToolStripMenuItem1.Text = "Extra"
        Me.ExtraToolStripMenuItem1.Visible = False
        '
        'SKEREMODODIABLOToolStripMenuItem
        '
        Me.SKEREMODODIABLOToolStripMenuItem.Name = "SKEREMODODIABLOToolStripMenuItem"
        Me.SKEREMODODIABLOToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.SKEREMODODIABLOToolStripMenuItem.Text = "SKEREMODODIABLO"
        '
        'YABASTAToolStripMenuItem
        '
        Me.YABASTAToolStripMenuItem.Name = "YABASTAToolStripMenuItem"
        Me.YABASTAToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.YABASTAToolStripMenuItem.Text = "YABASTA"
        Me.YABASTAToolStripMenuItem.Visible = False
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(6, 19)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(430, 215)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'GroupAlertas
        '
        Me.GroupAlertas.Controls.Add(Me.ListView1)
        Me.GroupAlertas.Location = New System.Drawing.Point(52, 57)
        Me.GroupAlertas.Name = "GroupAlertas"
        Me.GroupAlertas.Size = New System.Drawing.Size(442, 240)
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
        Me.ClientSize = New System.Drawing.Size(964, 607)
        Me.Controls.Add(Me.GroupAlertas)
        Me.Controls.Add(Me.lblBienvenida)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "frmPrincipal"
        Me.Text = "Sodivom"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupAlertas.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents PedidoAlDistribuidorToolStripMenuItem As ToolStripMenuItem
End Class
