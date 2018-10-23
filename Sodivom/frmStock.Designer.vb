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
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(708, 58)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 57
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'lbltituloStock
        '
        Me.lbltituloStock.AutoSize = True
        Me.lbltituloStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltituloStock.Location = New System.Drawing.Point(329, 32)
        Me.lbltituloStock.Name = "lbltituloStock"
        Me.lbltituloStock.Size = New System.Drawing.Size(97, 37)
        Me.lbltituloStock.TabIndex = 56
        Me.lbltituloStock.Text = "Stock"
        '
        'rdbProducto
        '
        Me.rdbProducto.AutoSize = True
        Me.rdbProducto.Location = New System.Drawing.Point(220, 356)
        Me.rdbProducto.Name = "rdbProducto"
        Me.rdbProducto.Size = New System.Drawing.Size(68, 17)
        Me.rdbProducto.TabIndex = 54
        Me.rdbProducto.TabStop = True
        Me.rdbProducto.Text = "Producto"
        Me.rdbProducto.UseVisualStyleBackColor = True
        '
        'rdbTodo
        '
        Me.rdbTodo.AutoSize = True
        Me.rdbTodo.Location = New System.Drawing.Point(220, 333)
        Me.rdbTodo.Name = "rdbTodo"
        Me.rdbTodo.Size = New System.Drawing.Size(50, 17)
        Me.rdbTodo.TabIndex = 53
        Me.rdbTodo.TabStop = True
        Me.rdbTodo.Text = "Todo"
        Me.rdbTodo.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(209, 299)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 20)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Listar por:"
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Descripción, Me.Stock, Me.fechaingreso, Me.FechaVen, Me.Id})
        Me.dgvDatos.Location = New System.Drawing.Point(336, 94)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.Size = New System.Drawing.Size(447, 267)
        Me.dgvDatos.TabIndex = 51
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
        Me.btnListar.Location = New System.Drawing.Point(118, 338)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(75, 23)
        Me.btnListar.TabIndex = 50
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(18, 338)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 49
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(118, 299)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 48
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(18, 299)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 47
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'txtFechaIng
        '
        Me.txtFechaIng.Location = New System.Drawing.Point(187, 152)
        Me.txtFechaIng.Name = "txtFechaIng"
        Me.txtFechaIng.Size = New System.Drawing.Size(127, 20)
        Me.txtFechaIng.TabIndex = 45
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(187, 125)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(127, 20)
        Me.txtStock.TabIndex = 43
        '
        'lblFechaIng
        '
        Me.lblFechaIng.AutoSize = True
        Me.lblFechaIng.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIng.Location = New System.Drawing.Point(22, 152)
        Me.lblFechaIng.Name = "lblFechaIng"
        Me.lblFechaIng.Size = New System.Drawing.Size(132, 20)
        Me.lblFechaIng.TabIndex = 41
        Me.lblFechaIng.Text = "Fecha de ingreso"
        '
        'lblFechaVen
        '
        Me.lblFechaVen.AutoSize = True
        Me.lblFechaVen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaVen.Location = New System.Drawing.Point(22, 186)
        Me.lblFechaVen.Name = "lblFechaVen"
        Me.lblFechaVen.Size = New System.Drawing.Size(164, 20)
        Me.lblFechaVen.TabIndex = 40
        Me.lblFechaVen.Text = "Fecha de vencimiento"
        '
        'lblStock
        '
        Me.lblStock.AutoSize = True
        Me.lblStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.Location = New System.Drawing.Point(22, 125)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(50, 20)
        Me.lblStock.TabIndex = 42
        Me.lblStock.Text = "Stock"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.Location = New System.Drawing.Point(22, 92)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(73, 20)
        Me.lblProducto.TabIndex = 39
        Me.lblProducto.Text = "Producto"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(133, 245)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(127, 20)
        Me.txtId.TabIndex = 58
        Me.txtId.Text = "0"
        Me.txtId.Visible = False
        '
        'comboProducto
        '
        Me.comboProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.comboProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboProducto.FormattingEnabled = True
        Me.comboProducto.Location = New System.Drawing.Point(187, 92)
        Me.comboProducto.Name = "comboProducto"
        Me.comboProducto.Size = New System.Drawing.Size(127, 21)
        Me.comboProducto.TabIndex = 59
        '
        'DtpFechaVen
        '
        Me.DtpFechaVen.Location = New System.Drawing.Point(187, 186)
        Me.DtpFechaVen.Name = "DtpFechaVen"
        Me.DtpFechaVen.Size = New System.Drawing.Size(127, 20)
        Me.DtpFechaVen.TabIndex = 60
        '
        'ChkNoVence
        '
        Me.ChkNoVence.AutoSize = True
        Me.ChkNoVence.Location = New System.Drawing.Point(187, 212)
        Me.ChkNoVence.Name = "ChkNoVence"
        Me.ChkNoVence.Size = New System.Drawing.Size(73, 17)
        Me.ChkNoVence.TabIndex = 61
        Me.ChkNoVence.Text = "No vence"
        Me.ChkNoVence.UseVisualStyleBackColor = True
        '
        'frmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
        Me.Name = "frmStock"
        Me.Text = "frmStock"
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
End Class
