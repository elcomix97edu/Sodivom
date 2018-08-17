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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DistribuidorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitarToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepartoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitarToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClienteToolStripMenuItem, Me.EmpleadoToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.DistribuidorToolStripMenuItem, Me.VentaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(882, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem, Me.QuitarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.ListarToolStripMenuItem})
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem1, Me.QuitarToolStripMenuItem1, Me.ModificarToolStripMenuItem1, Me.ListarToolStripMenuItem1, Me.TipoEmpleadoToolStripMenuItem})
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.EmpleadoToolStripMenuItem.Text = "Empleado"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem2, Me.QuitarToolStripMenuItem2, Me.ModificarToolStripMenuItem2, Me.ListarToolStripMenuItem2})
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'DistribuidorToolStripMenuItem
        '
        Me.DistribuidorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem3, Me.QuitarToolStripMenuItem3, Me.ModificarToolStripMenuItem3, Me.ListarToolStripMenuItem3})
        Me.DistribuidorToolStripMenuItem.Name = "DistribuidorToolStripMenuItem"
        Me.DistribuidorToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.DistribuidorToolStripMenuItem.Text = "Distribuidor"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarToolStripMenuItem4, Me.RepartoToolStripMenuItem})
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.VentaToolStripMenuItem.Text = "Venta"
        '
        'AgregarToolStripMenuItem
        '
        Me.AgregarToolStripMenuItem.Name = "AgregarToolStripMenuItem"
        Me.AgregarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AgregarToolStripMenuItem.Text = "Agregar"
        '
        'QuitarToolStripMenuItem
        '
        Me.QuitarToolStripMenuItem.Name = "QuitarToolStripMenuItem"
        Me.QuitarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuitarToolStripMenuItem.Text = "Quitar"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'ListarToolStripMenuItem
        '
        Me.ListarToolStripMenuItem.Name = "ListarToolStripMenuItem"
        Me.ListarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ListarToolStripMenuItem.Text = "Listar"
        '
        'AgregarToolStripMenuItem1
        '
        Me.AgregarToolStripMenuItem1.Name = "AgregarToolStripMenuItem1"
        Me.AgregarToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AgregarToolStripMenuItem1.Text = "Agregar"
        '
        'QuitarToolStripMenuItem1
        '
        Me.QuitarToolStripMenuItem1.Name = "QuitarToolStripMenuItem1"
        Me.QuitarToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.QuitarToolStripMenuItem1.Text = "Quitar"
        '
        'ModificarToolStripMenuItem1
        '
        Me.ModificarToolStripMenuItem1.Name = "ModificarToolStripMenuItem1"
        Me.ModificarToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ModificarToolStripMenuItem1.Text = "Modificar"
        '
        'ListarToolStripMenuItem1
        '
        Me.ListarToolStripMenuItem1.Name = "ListarToolStripMenuItem1"
        Me.ListarToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ListarToolStripMenuItem1.Text = "Listar"
        '
        'AgregarToolStripMenuItem2
        '
        Me.AgregarToolStripMenuItem2.Name = "AgregarToolStripMenuItem2"
        Me.AgregarToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.AgregarToolStripMenuItem2.Text = "Agregar"
        '
        'QuitarToolStripMenuItem2
        '
        Me.QuitarToolStripMenuItem2.Name = "QuitarToolStripMenuItem2"
        Me.QuitarToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.QuitarToolStripMenuItem2.Text = "Quitar"
        '
        'ModificarToolStripMenuItem2
        '
        Me.ModificarToolStripMenuItem2.Name = "ModificarToolStripMenuItem2"
        Me.ModificarToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.ModificarToolStripMenuItem2.Text = "Modificar"
        '
        'ListarToolStripMenuItem2
        '
        Me.ListarToolStripMenuItem2.Name = "ListarToolStripMenuItem2"
        Me.ListarToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.ListarToolStripMenuItem2.Text = "Listar"
        '
        'AgregarToolStripMenuItem3
        '
        Me.AgregarToolStripMenuItem3.Name = "AgregarToolStripMenuItem3"
        Me.AgregarToolStripMenuItem3.Size = New System.Drawing.Size(180, 22)
        Me.AgregarToolStripMenuItem3.Text = "Agregar"
        '
        'QuitarToolStripMenuItem3
        '
        Me.QuitarToolStripMenuItem3.Name = "QuitarToolStripMenuItem3"
        Me.QuitarToolStripMenuItem3.Size = New System.Drawing.Size(180, 22)
        Me.QuitarToolStripMenuItem3.Text = "Quitar"
        '
        'ModificarToolStripMenuItem3
        '
        Me.ModificarToolStripMenuItem3.Name = "ModificarToolStripMenuItem3"
        Me.ModificarToolStripMenuItem3.Size = New System.Drawing.Size(180, 22)
        Me.ModificarToolStripMenuItem3.Text = "Modificar"
        '
        'ListarToolStripMenuItem3
        '
        Me.ListarToolStripMenuItem3.Name = "ListarToolStripMenuItem3"
        Me.ListarToolStripMenuItem3.Size = New System.Drawing.Size(180, 22)
        Me.ListarToolStripMenuItem3.Text = "Listar"
        '
        'ListarToolStripMenuItem4
        '
        Me.ListarToolStripMenuItem4.Name = "ListarToolStripMenuItem4"
        Me.ListarToolStripMenuItem4.Size = New System.Drawing.Size(180, 22)
        Me.ListarToolStripMenuItem4.Text = "Listar"
        '
        'RepartoToolStripMenuItem
        '
        Me.RepartoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarToolStripMenuItem5})
        Me.RepartoToolStripMenuItem.Name = "RepartoToolStripMenuItem"
        Me.RepartoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RepartoToolStripMenuItem.Text = "Reparto"
        '
        'ListarToolStripMenuItem5
        '
        Me.ListarToolStripMenuItem5.Name = "ListarToolStripMenuItem5"
        Me.ListarToolStripMenuItem5.Size = New System.Drawing.Size(180, 22)
        Me.ListarToolStripMenuItem5.Text = "Listar"
        '
        'TipoEmpleadoToolStripMenuItem
        '
        Me.TipoEmpleadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarToolStripMenuItem4, Me.QuitarToolStripMenuItem4, Me.ListarToolStripMenuItem6})
        Me.TipoEmpleadoToolStripMenuItem.Name = "TipoEmpleadoToolStripMenuItem"
        Me.TipoEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TipoEmpleadoToolStripMenuItem.Text = "TipoEmpleado"
        '
        'AgregarToolStripMenuItem4
        '
        Me.AgregarToolStripMenuItem4.Name = "AgregarToolStripMenuItem4"
        Me.AgregarToolStripMenuItem4.Size = New System.Drawing.Size(180, 22)
        Me.AgregarToolStripMenuItem4.Text = "Agregar"
        '
        'QuitarToolStripMenuItem4
        '
        Me.QuitarToolStripMenuItem4.Name = "QuitarToolStripMenuItem4"
        Me.QuitarToolStripMenuItem4.Size = New System.Drawing.Size(180, 22)
        Me.QuitarToolStripMenuItem4.Text = "Quitar"
        '
        'ListarToolStripMenuItem6
        '
        Me.ListarToolStripMenuItem6.Name = "ListarToolStripMenuItem6"
        Me.ListarToolStripMenuItem6.Size = New System.Drawing.Size(180, 22)
        Me.ListarToolStripMenuItem6.Text = "Listar"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 520)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "Sodivom"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents QuitarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TipoEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents QuitarToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents QuitarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents DistribuidorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents QuitarToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents RepartoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem5 As ToolStripMenuItem
End Class
