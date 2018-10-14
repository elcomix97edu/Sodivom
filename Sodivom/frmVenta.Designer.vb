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
        Me.lblVenta = New System.Windows.Forms.Label()
        Me.lblCajero = New System.Windows.Forms.Label()
        Me.lblNombreCajero = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.comboCliente = New System.Windows.Forms.ComboBox()
        Me.chkAnonimo = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboProd = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.contReparto = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPrecioTotal = New System.Windows.Forms.Label()
        Me.lblIva = New System.Windows.Forms.Label()
        Me.lblPrecioIva = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblPrecioSub = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkRUT = New System.Windows.Forms.CheckBox()
        Me.mskRUT = New System.Windows.Forms.MaskedTextBox()
        Me.btnRealizarVenta = New System.Windows.Forms.Button()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contReparto.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblVenta
        '
        Me.lblVenta.AutoSize = True
        Me.lblVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenta.Location = New System.Drawing.Point(325, 9)
        Me.lblVenta.Name = "lblVenta"
        Me.lblVenta.Size = New System.Drawing.Size(101, 37)
        Me.lblVenta.TabIndex = 0
        Me.lblVenta.Text = "Venta"
        '
        'lblCajero
        '
        Me.lblCajero.AutoSize = True
        Me.lblCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCajero.Location = New System.Drawing.Point(12, 49)
        Me.lblCajero.Name = "lblCajero"
        Me.lblCajero.Size = New System.Drawing.Size(75, 24)
        Me.lblCajero.TabIndex = 1
        Me.lblCajero.Text = "Cajero :"
        '
        'lblNombreCajero
        '
        Me.lblNombreCajero.AutoSize = True
        Me.lblNombreCajero.Location = New System.Drawing.Point(83, 57)
        Me.lblNombreCajero.Name = "lblNombreCajero"
        Me.lblNombreCajero.Size = New System.Drawing.Size(36, 13)
        Me.lblNombreCajero.TabIndex = 2
        Me.lblNombreCajero.Text = "cajero"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.Location = New System.Drawing.Point(12, 85)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(78, 24)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "Cliente :"
        '
        'comboCliente
        '
        Me.comboCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboCliente.FormattingEnabled = True
        Me.comboCliente.Location = New System.Drawing.Point(97, 84)
        Me.comboCliente.Name = "comboCliente"
        Me.comboCliente.Size = New System.Drawing.Size(121, 21)
        Me.comboCliente.TabIndex = 3
        Me.comboCliente.Text = "Anónimo -"
        '
        'chkAnonimo
        '
        Me.chkAnonimo.AutoSize = True
        Me.chkAnonimo.Checked = True
        Me.chkAnonimo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAnonimo.Location = New System.Drawing.Point(240, 87)
        Me.chkAnonimo.Name = "chkAnonimo"
        Me.chkAnonimo.Size = New System.Drawing.Size(67, 17)
        Me.chkAnonimo.TabIndex = 4
        Me.chkAnonimo.Text = "Anónimo"
        Me.chkAnonimo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(531, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(441, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(486, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 24)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Producto :"
        '
        'ComboProd
        '
        Me.ComboProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboProd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboProd.FormattingEnabled = True
        Me.ComboProd.Location = New System.Drawing.Point(114, 126)
        Me.ComboProd.Name = "ComboProd"
        Me.ComboProd.Size = New System.Drawing.Size(193, 21)
        Me.ComboProd.TabIndex = 3
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(450, 124)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(380, 126)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(46, 20)
        Me.txtCantidad.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(316, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 24)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Cant :"
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Producto, Me.Cantidad, Me.PrecioUnidad})
        Me.dgvProductos.Location = New System.Drawing.Point(16, 165)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(509, 166)
        Me.dgvProductos.TabIndex = 10
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
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
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(552, 122)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(95, 28)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Reparto"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'contReparto
        '
        Me.contReparto.Controls.Add(Me.TextBox2)
        Me.contReparto.Enabled = False
        Me.contReparto.Location = New System.Drawing.Point(552, 165)
        Me.contReparto.Name = "contReparto"
        Me.contReparto.Size = New System.Drawing.Size(281, 166)
        Me.contReparto.TabIndex = 12
        Me.contReparto.TabStop = False
        Me.contReparto.Text = "Reparto"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(88, 44)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 0
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(404, 384)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(76, 24)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.Text = "Total : $"
        '
        'lblPrecioTotal
        '
        Me.lblPrecioTotal.AutoSize = True
        Me.lblPrecioTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioTotal.Location = New System.Drawing.Point(476, 384)
        Me.lblPrecioTotal.Name = "lblPrecioTotal"
        Me.lblPrecioTotal.Size = New System.Drawing.Size(20, 24)
        Me.lblPrecioTotal.TabIndex = 14
        Me.lblPrecioTotal.Text = "0"
        '
        'lblIva
        '
        Me.lblIva.AutoSize = True
        Me.lblIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIva.Location = New System.Drawing.Point(415, 360)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(65, 24)
        Me.lblIva.TabIndex = 13
        Me.lblIva.Text = "IVA : $"
        '
        'lblPrecioIva
        '
        Me.lblPrecioIva.AutoSize = True
        Me.lblPrecioIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioIva.Location = New System.Drawing.Point(476, 360)
        Me.lblPrecioIva.Name = "lblPrecioIva"
        Me.lblPrecioIva.Size = New System.Drawing.Size(20, 24)
        Me.lblPrecioIva.TabIndex = 14
        Me.lblPrecioIva.Text = "0"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(370, 334)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(110, 24)
        Me.lblSubTotal.TabIndex = 13
        Me.lblSubTotal.Text = "SubTotal : $"
        '
        'lblPrecioSub
        '
        Me.lblPrecioSub.AutoSize = True
        Me.lblPrecioSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioSub.Location = New System.Drawing.Point(476, 334)
        Me.lblPrecioSub.Name = "lblPrecioSub"
        Me.lblPrecioSub.Size = New System.Drawing.Size(20, 24)
        Me.lblPrecioSub.TabIndex = 14
        Me.lblPrecioSub.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(368, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 24)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "RUT :"
        '
        'chkRUT
        '
        Me.chkRUT.AutoSize = True
        Me.chkRUT.Location = New System.Drawing.Point(313, 87)
        Me.chkRUT.Name = "chkRUT"
        Me.chkRUT.Size = New System.Drawing.Size(49, 17)
        Me.chkRUT.TabIndex = 4
        Me.chkRUT.Text = "RUT"
        Me.chkRUT.UseVisualStyleBackColor = True
        '
        'mskRUT
        '
        Me.mskRUT.Enabled = False
        Me.mskRUT.Location = New System.Drawing.Point(433, 84)
        Me.mskRUT.Mask = "000000000000"
        Me.mskRUT.Name = "mskRUT"
        Me.mskRUT.Size = New System.Drawing.Size(100, 20)
        Me.mskRUT.TabIndex = 15
        '
        'btnRealizarVenta
        '
        Me.btnRealizarVenta.Location = New System.Drawing.Point(396, 431)
        Me.btnRealizarVenta.Name = "btnRealizarVenta"
        Me.btnRealizarVenta.Size = New System.Drawing.Size(120, 23)
        Me.btnRealizarVenta.TabIndex = 16
        Me.btnRealizarVenta.Text = "Realizar Venta"
        Me.btnRealizarVenta.UseVisualStyleBackColor = True
        '
        'frmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 466)
        Me.Controls.Add(Me.btnRealizarVenta)
        Me.Controls.Add(Me.mskRUT)
        Me.Controls.Add(Me.lblPrecioSub)
        Me.Controls.Add(Me.lblPrecioIva)
        Me.Controls.Add(Me.lblPrecioTotal)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lblIva)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.contReparto)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
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
        Me.Controls.Add(Me.lblVenta)
        Me.Name = "frmVenta"
        Me.Text = "frmVenta"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contReparto.ResumeLayout(False)
        Me.contReparto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVenta As Label
    Friend WithEvents lblCajero As Label
    Friend WithEvents lblNombreCajero As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents comboCliente As ComboBox
    Friend WithEvents chkAnonimo As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboProd As ComboBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnidad As DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents contReparto As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblPrecioTotal As Label
    Friend WithEvents lblIva As Label
    Friend WithEvents lblPrecioIva As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblPrecioSub As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents chkRUT As CheckBox
    Friend WithEvents mskRUT As MaskedTextBox
    Friend WithEvents btnRealizarVenta As Button
End Class
