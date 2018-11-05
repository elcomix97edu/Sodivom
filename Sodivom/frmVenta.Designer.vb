<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenta))
        Me.lblVenta = New System.Windows.Forms.Label()
        Me.CheckBoxReparto = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.TextReparto = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.txtIdVenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.contReparto = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNumFecha = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRealizarVenta = New System.Windows.Forms.Button()
        Me.mskRUT = New System.Windows.Forms.MaskedTextBox()
        Me.lblPrecioSub = New System.Windows.Forms.Label()
        Me.lblPrecioIva = New System.Windows.Forms.Label()
        Me.lblPrecioTotal = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblIva = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.chkRUT = New System.Windows.Forms.CheckBox()
        Me.chkAnonimo = New System.Windows.Forms.CheckBox()
        Me.ComboProd = New System.Windows.Forms.ComboBox()
        Me.comboCliente = New System.Windows.Forms.ComboBox()
        Me.lblNombreCajero = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblCajero = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.contReparto.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVenta
        '
        Me.lblVenta.AutoSize = True
        Me.lblVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenta.Location = New System.Drawing.Point(391, 39)
        Me.lblVenta.Name = "lblVenta"
        Me.lblVenta.Size = New System.Drawing.Size(105, 31)
        Me.lblVenta.TabIndex = 0
        Me.lblVenta.Text = "VENTA"
        '
        'CheckBoxReparto
        '
        Me.CheckBoxReparto.AutoSize = True
        Me.CheckBoxReparto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxReparto.Location = New System.Drawing.Point(506, 199)
        Me.CheckBoxReparto.Name = "CheckBoxReparto"
        Me.CheckBoxReparto.Size = New System.Drawing.Size(95, 28)
        Me.CheckBoxReparto.TabIndex = 9
        Me.CheckBoxReparto.Text = "Reparto"
        Me.CheckBoxReparto.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Dirección"
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(102, 41)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(202, 20)
        Me.txtDireccion.TabIndex = 10
        '
        'TextReparto
        '
        Me.TextReparto.Location = New System.Drawing.Point(88, 44)
        Me.TextReparto.Name = "TextReparto"
        Me.TextReparto.Size = New System.Drawing.Size(100, 20)
        Me.TextReparto.TabIndex = 0
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "Factura"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'txtIdVenta
        '
        Me.txtIdVenta.Location = New System.Drawing.Point(102, 25)
        Me.txtIdVenta.Name = "txtIdVenta"
        Me.txtIdVenta.Size = New System.Drawing.Size(100, 22)
        Me.txtIdVenta.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "IdVenta"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscar.Location = New System.Drawing.Point(655, 426)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(175, 40)
        Me.btnBuscar.TabIndex = 13
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'contReparto
        '
        Me.contReparto.Controls.Add(Me.Label7)
        Me.contReparto.Controls.Add(Me.txtDireccion)
        Me.contReparto.Controls.Add(Me.Label1)
        Me.contReparto.Enabled = False
        Me.contReparto.Location = New System.Drawing.Point(506, 213)
        Me.contReparto.Name = "contReparto"
        Me.contReparto.Size = New System.Drawing.Size(337, 94)
        Me.contReparto.TabIndex = 12
        Me.contReparto.TabStop = False
        Me.contReparto.Text = "Reparto"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtIdVenta)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(506, 331)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 73)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda"
        '
        'lblNumFecha
        '
        Me.lblNumFecha.AutoSize = True
        Me.lblNumFecha.Location = New System.Drawing.Point(242, 94)
        Me.lblNumFecha.Name = "lblNumFecha"
        Me.lblNumFecha.Size = New System.Drawing.Size(34, 13)
        Me.lblNumFecha.TabIndex = 50
        Me.lblNumFecha.Text = "fecha"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(166, 85)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(74, 24)
        Me.lblFecha.TabIndex = 49
        Me.lblFecha.Text = "Fecha :"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(655, 122)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(562, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Nombre empresa"
        '
        'btnRealizarVenta
        '
        Me.btnRealizarVenta.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnRealizarVenta.FlatAppearance.BorderSize = 0
        Me.btnRealizarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnRealizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRealizarVenta.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRealizarVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRealizarVenta.Location = New System.Drawing.Point(16, 426)
        Me.btnRealizarVenta.Name = "btnRealizarVenta"
        Me.btnRealizarVenta.Size = New System.Drawing.Size(175, 40)
        Me.btnRealizarVenta.TabIndex = 11
        Me.btnRealizarVenta.Text = "Realizar Venta"
        Me.btnRealizarVenta.UseVisualStyleBackColor = False
        '
        'mskRUT
        '
        Me.mskRUT.Enabled = False
        Me.mskRUT.Location = New System.Drawing.Point(451, 122)
        Me.mskRUT.Mask = "000000000000"
        Me.mskRUT.Name = "mskRUT"
        Me.mskRUT.Size = New System.Drawing.Size(100, 20)
        Me.mskRUT.TabIndex = 4
        '
        'lblPrecioSub
        '
        Me.lblPrecioSub.AutoSize = True
        Me.lblPrecioSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioSub.Location = New System.Drawing.Point(436, 366)
        Me.lblPrecioSub.Name = "lblPrecioSub"
        Me.lblPrecioSub.Size = New System.Drawing.Size(20, 24)
        Me.lblPrecioSub.TabIndex = 44
        Me.lblPrecioSub.Text = "0"
        '
        'lblPrecioIva
        '
        Me.lblPrecioIva.AutoSize = True
        Me.lblPrecioIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioIva.Location = New System.Drawing.Point(436, 392)
        Me.lblPrecioIva.Name = "lblPrecioIva"
        Me.lblPrecioIva.Size = New System.Drawing.Size(20, 24)
        Me.lblPrecioIva.TabIndex = 43
        Me.lblPrecioIva.Text = "0"
        '
        'lblPrecioTotal
        '
        Me.lblPrecioTotal.AutoSize = True
        Me.lblPrecioTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioTotal.Location = New System.Drawing.Point(436, 416)
        Me.lblPrecioTotal.Name = "lblPrecioTotal"
        Me.lblPrecioTotal.Size = New System.Drawing.Size(20, 24)
        Me.lblPrecioTotal.TabIndex = 42
        Me.lblPrecioTotal.Text = "0"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(330, 366)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(110, 24)
        Me.lblSubTotal.TabIndex = 40
        Me.lblSubTotal.Text = "SubTotal : $"
        '
        'lblIva
        '
        Me.lblIva.AutoSize = True
        Me.lblIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIva.Location = New System.Drawing.Point(375, 392)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(65, 24)
        Me.lblIva.TabIndex = 39
        Me.lblIva.Text = "IVA : $"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(364, 416)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(76, 24)
        Me.lblTotal.TabIndex = 41
        Me.lblTotal.Text = "Total : $"
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.BackgroundColor = System.Drawing.SystemColors.WindowText
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Producto, Me.Cantidad, Me.PrecioUnidad})
        Me.dgvProductos.Location = New System.Drawing.Point(13, 197)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(443, 166)
        Me.dgvProductos.TabIndex = 38
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'PrecioUnidad
        '
        Me.PrecioUnidad.HeaderText = "Precio Unidad"
        Me.PrecioUnidad.Name = "PrecioUnidad"
        Me.PrecioUnidad.ReadOnly = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(420, 158)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(67, 20)
        Me.txtCantidad.TabIndex = 7
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregar.Location = New System.Drawing.Point(506, 154)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(128, 32)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'chkRUT
        '
        Me.chkRUT.AutoSize = True
        Me.chkRUT.Location = New System.Drawing.Point(328, 125)
        Me.chkRUT.Name = "chkRUT"
        Me.chkRUT.Size = New System.Drawing.Size(49, 17)
        Me.chkRUT.TabIndex = 3
        Me.chkRUT.Text = "RUT"
        Me.chkRUT.UseVisualStyleBackColor = True
        '
        'chkAnonimo
        '
        Me.chkAnonimo.AutoSize = True
        Me.chkAnonimo.Checked = True
        Me.chkAnonimo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAnonimo.Location = New System.Drawing.Point(255, 124)
        Me.chkAnonimo.Name = "chkAnonimo"
        Me.chkAnonimo.Size = New System.Drawing.Size(67, 17)
        Me.chkAnonimo.TabIndex = 2
        Me.chkAnonimo.Text = "Anónimo"
        Me.chkAnonimo.UseVisualStyleBackColor = True
        '
        'ComboProd
        '
        Me.ComboProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboProd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboProd.FormattingEnabled = True
        Me.ComboProd.Location = New System.Drawing.Point(110, 159)
        Me.ComboProd.Name = "ComboProd"
        Me.ComboProd.Size = New System.Drawing.Size(222, 21)
        Me.ComboProd.TabIndex = 6
        '
        'comboCliente
        '
        Me.comboCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboCliente.FormattingEnabled = True
        Me.comboCliente.Location = New System.Drawing.Point(110, 121)
        Me.comboCliente.Name = "comboCliente"
        Me.comboCliente.Size = New System.Drawing.Size(121, 21)
        Me.comboCliente.TabIndex = 1
        Me.comboCliente.Text = "Anónimo -"
        '
        'lblNombreCajero
        '
        Me.lblNombreCajero.AutoSize = True
        Me.lblNombreCajero.Location = New System.Drawing.Point(85, 93)
        Me.lblNombreCajero.Name = "lblNombreCajero"
        Me.lblNombreCajero.Size = New System.Drawing.Size(36, 13)
        Me.lblNombreCajero.TabIndex = 31
        Me.lblNombreCajero.Text = "cajero"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(351, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 24)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Cant. :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(387, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 24)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "RUT :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 24)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Producto :"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(12, 121)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(78, 24)
        Me.lblCliente.TabIndex = 30
        Me.lblCliente.Text = "Cliente :"
        '
        'lblCajero
        '
        Me.lblCajero.AutoSize = True
        Me.lblCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCajero.Location = New System.Drawing.Point(12, 85)
        Me.lblCajero.Name = "lblCajero"
        Me.lblCajero.Size = New System.Drawing.Size(75, 24)
        Me.lblCajero.TabIndex = 26
        Me.lblCajero.Text = "Cajero :"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(12, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(872, 10)
        Me.Panel1.TabIndex = 51
        '
        'frmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(896, 495)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblNumFecha)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.CheckBoxReparto)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnRealizarVenta)
        Me.Controls.Add(Me.mskRUT)
        Me.Controls.Add(Me.lblPrecioSub)
        Me.Controls.Add(Me.lblPrecioIva)
        Me.Controls.Add(Me.lblPrecioTotal)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lblIva)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.chkRUT)
        Me.Controls.Add(Me.chkAnonimo)
        Me.Controls.Add(Me.ComboProd)
        Me.Controls.Add(Me.comboCliente)
        Me.Controls.Add(Me.lblNombreCajero)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.lblCajero)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.contReparto)
        Me.Controls.Add(Me.lblVenta)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta"
        Me.contReparto.ResumeLayout(False)
        Me.contReparto.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVenta As Label
    Friend WithEvents CheckBoxReparto As CheckBox
    Friend WithEvents TextReparto As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtIdVenta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents contReparto As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNumFecha As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRealizarVenta As Button
    Friend WithEvents mskRUT As MaskedTextBox
    Friend WithEvents lblPrecioSub As Label
    Friend WithEvents lblPrecioIva As Label
    Friend WithEvents lblPrecioTotal As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblIva As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnidad As DataGridViewTextBoxColumn
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents chkRUT As CheckBox
    Friend WithEvents chkAnonimo As CheckBox
    Friend WithEvents ComboProd As ComboBox
    Friend WithEvents comboCliente As ComboBox
    Friend WithEvents lblNombreCajero As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblCajero As Label
    Friend WithEvents Panel1 As Panel
End Class
