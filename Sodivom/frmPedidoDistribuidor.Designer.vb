<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPedidodistribuidor
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.rdbFecha = New System.Windows.Forms.RadioButton()
        Me.rdbTodo = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechapedido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblFechaPedido = New System.Windows.Forms.Label()
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.lblDescripción = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(255, 30)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(317, 37)
        Me.lblTitulo.TabIndex = 76
        Me.lblTitulo.Text = "Pedido al distribuidor"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(708, 81)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 93
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'rdbFecha
        '
        Me.rdbFecha.AutoSize = True
        Me.rdbFecha.Location = New System.Drawing.Point(220, 379)
        Me.rdbFecha.Name = "rdbFecha"
        Me.rdbFecha.Size = New System.Drawing.Size(55, 17)
        Me.rdbFecha.TabIndex = 91
        Me.rdbFecha.TabStop = True
        Me.rdbFecha.Text = "Fecha"
        Me.rdbFecha.UseVisualStyleBackColor = True
        '
        'rdbTodo
        '
        Me.rdbTodo.AutoSize = True
        Me.rdbTodo.Location = New System.Drawing.Point(220, 356)
        Me.rdbTodo.Name = "rdbTodo"
        Me.rdbTodo.Size = New System.Drawing.Size(50, 17)
        Me.rdbTodo.TabIndex = 90
        Me.rdbTodo.TabStop = True
        Me.rdbTodo.Text = "Todo"
        Me.rdbTodo.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(209, 322)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 20)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Listar por:"
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Descripción, Me.fechapedido, Me.importe})
        Me.dgvDatos.Location = New System.Drawing.Point(336, 117)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.Size = New System.Drawing.Size(447, 267)
        Me.dgvDatos.TabIndex = 88
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'Descripción
        '
        Me.Descripción.HeaderText = "Descripción"
        Me.Descripción.Name = "Descripción"
        Me.Descripción.ReadOnly = True
        '
        'fechapedido
        '
        Me.fechapedido.HeaderText = "Fecha de pedido"
        Me.fechapedido.Name = "fechapedido"
        Me.fechapedido.ReadOnly = True
        '
        'importe
        '
        Me.importe.HeaderText = "Importe total"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(118, 361)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(75, 23)
        Me.btnListar.TabIndex = 87
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(18, 361)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 86
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(118, 322)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 85
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(18, 322)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 84
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(187, 209)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(127, 20)
        Me.txtImporte.TabIndex = 83
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(187, 175)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(127, 20)
        Me.txtFecha.TabIndex = 82
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(187, 148)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(127, 20)
        Me.txtDescripcion.TabIndex = 81
        '
        'lblFechaPedido
        '
        Me.lblFechaPedido.AutoSize = True
        Me.lblFechaPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaPedido.Location = New System.Drawing.Point(22, 175)
        Me.lblFechaPedido.Name = "lblFechaPedido"
        Me.lblFechaPedido.Size = New System.Drawing.Size(128, 20)
        Me.lblFechaPedido.TabIndex = 79
        Me.lblFechaPedido.Text = "Fecha de pedido"
        '
        'lblImporte
        '
        Me.lblImporte.AutoSize = True
        Me.lblImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporte.Location = New System.Drawing.Point(22, 209)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(99, 20)
        Me.lblImporte.TabIndex = 78
        Me.lblImporte.Text = "Importe total"
        '
        'lblDescripción
        '
        Me.lblDescripción.AutoSize = True
        Me.lblDescripción.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripción.Location = New System.Drawing.Point(22, 148)
        Me.lblDescripción.Name = "lblDescripción"
        Me.lblDescripción.Size = New System.Drawing.Size(92, 20)
        Me.lblDescripción.TabIndex = 80
        Me.lblDescripción.Text = "Descripción"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(22, 115)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(23, 20)
        Me.lblId.TabIndex = 77
        Me.lblId.Text = "Id"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(187, 115)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(127, 20)
        Me.TxtId.TabIndex = 94
        '
        'frmPedidodistribuidor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.rdbFecha)
        Me.Controls.Add(Me.rdbTodo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblFechaPedido)
        Me.Controls.Add(Me.lblImporte)
        Me.Controls.Add(Me.lblDescripción)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmPedidodistribuidor"
        Me.Text = "frmPedidodistribuidor"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents rdbFecha As RadioButton
    Friend WithEvents rdbTodo As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents btnListar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblFechaPedido As Label
    Friend WithEvents lblImporte As Label
    Friend WithEvents lblDescripción As Label
    Friend WithEvents lblId As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Descripción As DataGridViewTextBoxColumn
    Friend WithEvents fechapedido As DataGridViewTextBoxColumn
    Friend WithEvents importe As DataGridViewTextBoxColumn
End Class
