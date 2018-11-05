<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStock
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
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lbltituloStock = New System.Windows.Forms.Label()
        Me.rdbProducto = New System.Windows.Forms.RadioButton()
        Me.rdbTodo = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaVen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtFechaIng = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.lblFechaIng = New System.Windows.Forms.Label()
        Me.lblFechaVen = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.comboProducto = New System.Windows.Forms.ComboBox()
        Me.DtpFechaVen = New System.Windows.Forms.DateTimePicker()
        Me.ChkNoVence = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLimpiar.Location = New System.Drawing.Point(756, 387)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(128, 34)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'lbltituloStock
        '
        Me.lbltituloStock.AutoSize = True
        Me.lbltituloStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltituloStock.Location = New System.Drawing.Point(396, 34)
        Me.lbltituloStock.Name = "lbltituloStock"
        Me.lbltituloStock.Size = New System.Drawing.Size(108, 31)
        Me.lbltituloStock.TabIndex = 56
        Me.lbltituloStock.Text = "STOCK"
        '
        'rdbProducto
        '
        Me.rdbProducto.AutoSize = True
        Me.rdbProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbProducto.Location = New System.Drawing.Point(137, 342)
        Me.rdbProducto.Name = "rdbProducto"
        Me.rdbProducto.Size = New System.Drawing.Size(87, 22)
        Me.rdbProducto.TabIndex = 7
        Me.rdbProducto.TabStop = True
        Me.rdbProducto.Text = "Producto"
        Me.rdbProducto.UseVisualStyleBackColor = True
        '
        'rdbTodo
        '
        Me.rdbTodo.AutoSize = True
        Me.rdbTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbTodo.Location = New System.Drawing.Point(137, 314)
        Me.rdbTodo.Name = "rdbTodo"
        Me.rdbTodo.Size = New System.Drawing.Size(61, 22)
        Me.rdbTodo.TabIndex = 6
        Me.rdbTodo.TabStop = True
        Me.rdbTodo.Text = "Todo"
        Me.rdbTodo.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 20)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Listar por:"
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.BackgroundColor = System.Drawing.SystemColors.WindowText
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Descripción, Me.Stock, Me.fechaingreso, Me.FechaVen, Me.Id})
        Me.dgvDatos.Location = New System.Drawing.Point(376, 92)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.Size = New System.Drawing.Size(508, 283)
        Me.dgvDatos.TabIndex = 13
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        '
        'Descripción
        '
        Me.Descripción.HeaderText = "Descripción"
        Me.Descripción.Name = "Descripción"
        Me.Descripción.ReadOnly = True
        '
        'Stock
        '
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        Me.Stock.ReadOnly = True
        '
        'fechaingreso
        '
        Me.fechaingreso.HeaderText = "Fecha de ingreso"
        Me.fechaingreso.Name = "fechaingreso"
        Me.fechaingreso.ReadOnly = True
        '
        'FechaVen
        '
        Me.FechaVen.HeaderText = "Fecha de vencimiento"
        Me.FechaVen.Name = "FechaVen"
        Me.FechaVen.ReadOnly = True
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'btnListar
        '
        Me.btnListar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnListar.FlatAppearance.BorderSize = 0
        Me.btnListar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnListar.Location = New System.Drawing.Point(193, 433)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(175, 40)
        Me.btnListar.TabIndex = 11
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnModificar.Location = New System.Drawing.Point(12, 433)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(175, 40)
        Me.btnModificar.TabIndex = 10
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminar.Location = New System.Drawing.Point(193, 387)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(175, 40)
        Me.btnEliminar.TabIndex = 9
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnIngresar.FlatAppearance.BorderSize = 0
        Me.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnIngresar.Location = New System.Drawing.Point(12, 387)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(175, 40)
        Me.btnIngresar.TabIndex = 8
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'txtFechaIng
        '
        Me.txtFechaIng.Location = New System.Drawing.Point(205, 177)
        Me.txtFechaIng.Name = "txtFechaIng"
        Me.txtFechaIng.Size = New System.Drawing.Size(127, 20)
        Me.txtFechaIng.TabIndex = 3
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(205, 150)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(127, 20)
        Me.txtStock.TabIndex = 2
        '
        'lblFechaIng
        '
        Me.lblFechaIng.AutoSize = True
        Me.lblFechaIng.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIng.Location = New System.Drawing.Point(40, 177)
        Me.lblFechaIng.Name = "lblFechaIng"
        Me.lblFechaIng.Size = New System.Drawing.Size(132, 20)
        Me.lblFechaIng.TabIndex = 41
        Me.lblFechaIng.Text = "Fecha de ingreso"
        '
        'lblFechaVen
        '
        Me.lblFechaVen.AutoSize = True
        Me.lblFechaVen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaVen.Location = New System.Drawing.Point(40, 211)
        Me.lblFechaVen.Name = "lblFechaVen"
        Me.lblFechaVen.Size = New System.Drawing.Size(164, 20)
        Me.lblFechaVen.TabIndex = 40
        Me.lblFechaVen.Text = "Fecha de vencimiento"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.Location = New System.Drawing.Point(40, 150)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(50, 20)
        Me.lblStock.TabIndex = 42
        Me.lblStock.Text = "Stock"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.Location = New System.Drawing.Point(40, 117)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(73, 20)
        Me.lblProducto.TabIndex = 39
        Me.lblProducto.Text = "Producto"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(205, 271)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(127, 20)
        Me.txtId.TabIndex = 58
        Me.txtId.TabStop = False
        Me.txtId.Text = "0"
        Me.txtId.Visible = False
        '
        'comboProducto
        '
        Me.comboProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboProducto.FormattingEnabled = True
        Me.comboProducto.Location = New System.Drawing.Point(205, 117)
        Me.comboProducto.Name = "comboProducto"
        Me.comboProducto.Size = New System.Drawing.Size(127, 21)
        Me.comboProducto.TabIndex = 1
        '
        'DtpFechaVen
        '
        Me.DtpFechaVen.Location = New System.Drawing.Point(205, 211)
        Me.DtpFechaVen.Name = "DtpFechaVen"
        Me.DtpFechaVen.Size = New System.Drawing.Size(127, 20)
        Me.DtpFechaVen.TabIndex = 4
        '
        'ChkNoVence
        '
        Me.ChkNoVence.AutoSize = True
        Me.ChkNoVence.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkNoVence.Location = New System.Drawing.Point(205, 237)
        Me.ChkNoVence.Name = "ChkNoVence"
        Me.ChkNoVence.Size = New System.Drawing.Size(90, 22)
        Me.ChkNoVence.TabIndex = 5
        Me.ChkNoVence.Text = "No vence"
        Me.ChkNoVence.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(12, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(872, 10)
        Me.Panel1.TabIndex = 62
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(12, 327)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(356, 54)
        Me.Panel2.TabIndex = 63
        '
        'frmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(896, 495)
        Me.Controls.Add(Me.ChkNoVence)
        Me.Controls.Add(Me.DtpFechaVen)
        Me.Controls.Add(Me.comboProducto)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lbltituloStock)
        Me.Controls.Add(Me.rdbProducto)
        Me.Controls.Add(Me.rdbTodo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtFechaIng)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.lblFechaIng)
        Me.Controls.Add(Me.lblFechaVen)
        Me.Controls.Add(Me.lblStock)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLimpiar As Button
    Friend WithEvents lbltituloStock As Label
    Friend WithEvents rdbProducto As RadioButton
    Friend WithEvents rdbTodo As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents btnListar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents txtFechaIng As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents lblFechaIng As Label
    Friend WithEvents lblFechaVen As Label
    Friend WithEvents lblStock As Label
    Friend WithEvents lblProducto As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents comboProducto As ComboBox
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Descripción As DataGridViewTextBoxColumn
    Friend WithEvents Stock As DataGridViewTextBoxColumn
    Friend WithEvents fechaingreso As DataGridViewTextBoxColumn
    Friend WithEvents FechaVen As DataGridViewTextBoxColumn
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents DtpFechaVen As DateTimePicker
    Friend WithEvents ChkNoVence As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
