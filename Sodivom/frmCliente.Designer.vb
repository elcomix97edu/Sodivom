<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCliente
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
        Me.lblCi = New System.Windows.Forms.Label()
        Me.mskCi = New System.Windows.Forms.MaskedTextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDir = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.Ci = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rdbApellido = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdbCi = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCi
        '
        Me.lblCi.AutoSize = True
        Me.lblCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCi.Location = New System.Drawing.Point(36, 115)
        Me.lblCi.Name = "lblCi"
        Me.lblCi.Size = New System.Drawing.Size(25, 20)
        Me.lblCi.TabIndex = 0
        Me.lblCi.Text = "CI"
        '
        'mskCi
        '
        Me.mskCi.Location = New System.Drawing.Point(134, 117)
        Me.mskCi.Mask = "00000000"
        Me.mskCi.Name = "mskCi"
        Me.mskCi.Size = New System.Drawing.Size(149, 20)
        Me.mskCi.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(134, 148)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(149, 20)
        Me.txtNombre.TabIndex = 2
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(36, 148)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(65, 20)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'lblDir
        '
        Me.lblDir.AutoSize = True
        Me.lblDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDir.Location = New System.Drawing.Point(36, 209)
        Me.lblDir.Name = "lblDir"
        Me.lblDir.Size = New System.Drawing.Size(75, 20)
        Me.lblDir.TabIndex = 0
        Me.lblDir.Text = "Dirección"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(36, 175)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(65, 20)
        Me.lblApellido.TabIndex = 0
        Me.lblApellido.Text = "Apellido"
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.Location = New System.Drawing.Point(36, 243)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(71, 20)
        Me.lblTel.TabIndex = 0
        Me.lblTel.Text = "Teléfono"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(36, 276)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(53, 20)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "E-mail"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(134, 177)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(149, 20)
        Me.txtApellido.TabIndex = 3
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(134, 211)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(149, 20)
        Me.txtDireccion.TabIndex = 4
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(134, 245)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(149, 20)
        Me.txtTelefono.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(134, 278)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(149, 20)
        Me.txtEmail.TabIndex = 6
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
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToAddRows = False
        Me.dgvCliente.AllowUserToDeleteRows = False
        Me.dgvCliente.BackgroundColor = System.Drawing.SystemColors.WindowText
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ci, Me.Nombre, Me.Apellido, Me.Direccion, Me.Telefono, Me.Email})
        Me.dgvCliente.Location = New System.Drawing.Point(381, 96)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.ReadOnly = True
        Me.dgvCliente.Size = New System.Drawing.Size(499, 279)
        Me.dgvCliente.TabIndex = 14
        '
        'Ci
        '
        Me.Ci.HeaderText = "Ci"
        Me.Ci.Name = "Ci"
        Me.Ci.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Dirección"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Teléfono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'Email
        '
        Me.Email.HeaderText = "E-mail"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'rdbApellido
        '
        Me.rdbApellido.AutoSize = True
        Me.rdbApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbApellido.Location = New System.Drawing.Point(148, 341)
        Me.rdbApellido.Name = "rdbApellido"
        Me.rdbApellido.Size = New System.Drawing.Size(77, 22)
        Me.rdbApellido.TabIndex = 8
        Me.rdbApellido.TabStop = True
        Me.rdbApellido.Text = "Apellido"
        Me.rdbApellido.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(375, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 31)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "CLIENTE"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(12, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(872, 10)
        Me.Panel1.TabIndex = 18
        '
        'rdbCi
        '
        Me.rdbCi.AutoSize = True
        Me.rdbCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCi.Location = New System.Drawing.Point(148, 313)
        Me.rdbCi.Name = "rdbCi"
        Me.rdbCi.Size = New System.Drawing.Size(40, 22)
        Me.rdbCi.TabIndex = 7
        Me.rdbCi.TabStop = True
        Me.rdbCi.Text = "Ci"
        Me.rdbCi.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(37, 313)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Listar por:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(13, 325)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(356, 50)
        Me.Panel2.TabIndex = 19
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(896, 495)
        Me.Controls.Add(Me.rdbApellido)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.rdbCi)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgvCliente)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.mskCi)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.lblDir)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblCi)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCi As Label
    Friend WithEvents mskCi As MaskedTextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblDir As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblTel As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnListar As Button
    Friend WithEvents dgvCliente As DataGridView
    Friend WithEvents Ci As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents rdbApellido As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rdbCi As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
End Class
