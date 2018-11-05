<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProducto
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rdbNombre = New System.Windows.Forms.RadioButton()
        Me.rdbTodo = New System.Windows.Forms.RadioButton()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.rbdCodigo = New System.Windows.Forms.RadioButton()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblMinStock = New System.Windows.Forms.Label()
        Me.lblCi = New System.Windows.Forms.Label()
        Me.lblDir = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtMinStock = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(375, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(171, 31)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "PRODUCTO"
        '
        'rdbNombre
        '
        Me.rdbNombre.AutoSize = True
        Me.rdbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbNombre.Location = New System.Drawing.Point(143, 311)
        Me.rdbNombre.Name = "rdbNombre"
        Me.rdbNombre.Size = New System.Drawing.Size(80, 22)
        Me.rdbNombre.TabIndex = 7
        Me.rdbNombre.TabStop = True
        Me.rdbNombre.Text = "Nombre"
        Me.rdbNombre.UseVisualStyleBackColor = True
        '
        'rdbTodo
        '
        Me.rdbTodo.AutoSize = True
        Me.rdbTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbTodo.Location = New System.Drawing.Point(143, 288)
        Me.rdbTodo.Name = "rdbTodo"
        Me.rdbTodo.Size = New System.Drawing.Size(61, 22)
        Me.rdbTodo.TabIndex = 6
        Me.rdbTodo.TabStop = True
        Me.rdbTodo.Text = "Todo"
        Me.rdbTodo.UseVisualStyleBackColor = True
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
        Me.btnListar.TabIndex = 12
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
        Me.btnModificar.TabIndex = 11
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
        Me.btnEliminar.TabIndex = 10
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
        Me.btnIngresar.TabIndex = 9
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
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
        Me.btnLimpiar.TabIndex = 13
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'rbdCodigo
        '
        Me.rbdCodigo.AutoSize = True
        Me.rbdCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbdCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rbdCodigo.Location = New System.Drawing.Point(143, 334)
        Me.rbdCodigo.Name = "rbdCodigo"
        Me.rbdCodigo.Size = New System.Drawing.Size(74, 22)
        Me.rbdCodigo.TabIndex = 8
        Me.rbdCodigo.TabStop = True
        Me.rbdCodigo.Text = "Codigo"
        Me.rbdCodigo.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(143, 173)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(149, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(143, 144)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(149, 20)
        Me.txtNombre.TabIndex = 2
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(143, 207)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(149, 20)
        Me.txtPrecio.TabIndex = 4
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(143, 113)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(149, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'lblMinStock
        '
        Me.lblMinStock.AutoSize = True
        Me.lblMinStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinStock.Location = New System.Drawing.Point(45, 243)
        Me.lblMinStock.Name = "lblMinStock"
        Me.lblMinStock.Size = New System.Drawing.Size(123, 20)
        Me.lblMinStock.TabIndex = 39
        Me.lblMinStock.Text = "Minimo de stock"
        '
        'lblCi
        '
        Me.lblCi.AutoSize = True
        Me.lblCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCi.Location = New System.Drawing.Point(45, 113)
        Me.lblCi.Name = "lblCi"
        Me.lblCi.Size = New System.Drawing.Size(59, 20)
        Me.lblCi.TabIndex = 17
        Me.lblCi.Text = "Codigo"
        '
        'lblDir
        '
        Me.lblDir.AutoSize = True
        Me.lblDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDir.Location = New System.Drawing.Point(45, 207)
        Me.lblDir.Name = "lblDir"
        Me.lblDir.Size = New System.Drawing.Size(53, 20)
        Me.lblDir.TabIndex = 18
        Me.lblDir.Text = "Precio"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(45, 144)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(65, 20)
        Me.lblNombre.TabIndex = 22
        Me.lblNombre.Text = "Nombre"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 20)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Listar por:"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(45, 173)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(92, 20)
        Me.lblApellido.TabIndex = 21
        Me.lblApellido.Text = "Descripcion"
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.BackgroundColor = System.Drawing.SystemColors.WindowText
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Nombre, Me.Descripcion, Me.Precio, Me.MinStock})
        Me.dgvDatos.Location = New System.Drawing.Point(381, 90)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.Size = New System.Drawing.Size(503, 291)
        Me.dgvDatos.TabIndex = 14
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'MinStock
        '
        Me.MinStock.HeaderText = "Minimo de stock"
        Me.MinStock.Name = "MinStock"
        Me.MinStock.ReadOnly = True
        '
        'txtMinStock
        '
        Me.txtMinStock.Location = New System.Drawing.Point(174, 243)
        Me.txtMinStock.Name = "txtMinStock"
        Me.txtMinStock.Size = New System.Drawing.Size(118, 20)
        Me.txtMinStock.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(12, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(872, 10)
        Me.Panel1.TabIndex = 41
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(12, 299)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(356, 67)
        Me.Panel2.TabIndex = 42
        '
        'frmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(896, 495)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.txtMinStock)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.lblDir)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.lblCi)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblMinStock)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.rdbNombre)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.rdbTodo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.rbdCodigo)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Producto"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents btnListar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents rdbNombre As RadioButton
    Friend WithEvents rdbTodo As RadioButton
    Friend WithEvents rbdCodigo As RadioButton
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblMinStock As Label
    Friend WithEvents lblCi As Label
    Friend WithEvents lblDir As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents MinStock As DataGridViewTextBoxColumn
    Friend WithEvents txtMinStock As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
