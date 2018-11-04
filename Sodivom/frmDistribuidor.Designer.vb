<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDistribuidor
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
        Me.Distribuidor = New System.Windows.Forms.Label()
        Me.rdbNombre = New System.Windows.Forms.RadioButton()
        Me.rdbTodo = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
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
        'Distribuidor
        '
        Me.Distribuidor.AutoSize = True
        Me.Distribuidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Distribuidor.Location = New System.Drawing.Point(317, 54)
        Me.Distribuidor.Name = "Distribuidor"
        Me.Distribuidor.Size = New System.Drawing.Size(180, 37)
        Me.Distribuidor.TabIndex = 56
        Me.Distribuidor.Text = "Distribuidor"
        '
        'rdbNombre
        '
        Me.rdbNombre.AutoSize = True
        Me.rdbNombre.Location = New System.Drawing.Point(220, 356)
        Me.rdbNombre.Name = "rdbNombre"
        Me.rdbNombre.Size = New System.Drawing.Size(62, 17)
        Me.rdbNombre.TabIndex = 54
        Me.rdbNombre.TabStop = True
        Me.rdbNombre.Text = "Nombre"
        Me.rdbNombre.UseVisualStyleBackColor = True
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
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Nombre, Me.Descripcion, Me.Email, Me.Telefono})
        Me.dgvDatos.Location = New System.Drawing.Point(353, 94)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.Size = New System.Drawing.Size(435, 267)
        Me.dgvDatos.TabIndex = 51
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
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
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
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
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(120, 188)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(149, 20)
        Me.txtEmail.TabIndex = 46
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(120, 154)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(149, 20)
        Me.txtDescripcion.TabIndex = 45
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(120, 94)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(149, 20)
        Me.txtId.TabIndex = 44
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(120, 125)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(149, 20)
        Me.txtNombre.TabIndex = 43
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(22, 154)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(92, 20)
        Me.lblDescripcion.TabIndex = 41
        Me.lblDescripcion.Text = "Descripcion"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(22, 186)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 20)
        Me.lblEmail.TabIndex = 40
        Me.lblEmail.Text = "Email"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(22, 125)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(65, 20)
        Me.lblNombre.TabIndex = 42
        Me.lblNombre.Text = "Nombre"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(22, 92)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(23, 20)
        Me.lblId.TabIndex = 39
        Me.lblId.Text = "Id"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(22, 220)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(71, 20)
        Me.lblTelefono.TabIndex = 58
        Me.lblTelefono.Text = "Telefono"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(120, 220)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(149, 20)
        Me.txtTelefono.TabIndex = 59
        '
        'frmDistribuidor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Distribuidor)
        Me.Controls.Add(Me.rdbNombre)
        Me.Controls.Add(Me.rdbTodo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblId)
        Me.Name = "frmDistribuidor"
        Me.Text = "frmDistribuidor"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Distribuidor As Label
    Friend WithEvents rdbNombre As RadioButton
    Friend WithEvents rdbTodo As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents btnListar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblId As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
End Class
