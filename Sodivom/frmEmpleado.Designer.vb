<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleado
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rdbApellido = New System.Windows.Forms.RadioButton()
        Me.rdbCi = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.Ci = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sueldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contraseña = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.mskCi = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.comboCargo = New System.Windows.Forms.ComboBox()
        Me.rdbCargo = New System.Windows.Forms.RadioButton()
        Me.btnLimpiar = New System.Windows.Forms.Button()
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
        Me.Label8.Size = New System.Drawing.Size(164, 31)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "EMPLEADO"
        '
        'rdbApellido
        '
        Me.rdbApellido.AutoSize = True
        Me.rdbApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbApellido.Location = New System.Drawing.Point(193, 328)
        Me.rdbApellido.Name = "rdbApellido"
        Me.rdbApellido.Size = New System.Drawing.Size(77, 22)
        Me.rdbApellido.TabIndex = 11
        Me.rdbApellido.TabStop = True
        Me.rdbApellido.Text = "Apellido"
        Me.rdbApellido.UseVisualStyleBackColor = True
        '
        'rdbCi
        '
        Me.rdbCi.AutoSize = True
        Me.rdbCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCi.Location = New System.Drawing.Point(193, 305)
        Me.rdbCi.Name = "rdbCi"
        Me.rdbCi.Size = New System.Drawing.Size(40, 22)
        Me.rdbCi.TabIndex = 10
        Me.rdbCi.TabStop = True
        Me.rdbCi.Text = "CI"
        Me.rdbCi.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(86, 305)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 20)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Listar por:"
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.BackgroundColor = System.Drawing.SystemColors.WindowText
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ci, Me.Nombre, Me.Apellido, Me.Direccion, Me.Telefono, Me.Email, Me.Sueldo, Me.Cargo, Me.Contraseña})
        Me.dgvDatos.Location = New System.Drawing.Point(381, 96)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.Size = New System.Drawing.Size(499, 279)
        Me.dgvDatos.TabIndex = 18
        Me.dgvDatos.TabStop = False
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
        'Sueldo
        '
        Me.Sueldo.HeaderText = "Sueldo"
        Me.Sueldo.Name = "Sueldo"
        Me.Sueldo.ReadOnly = True
        '
        'Cargo
        '
        Me.Cargo.HeaderText = "Cargo"
        Me.Cargo.Name = "Cargo"
        Me.Cargo.ReadOnly = True
        '
        'Contraseña
        '
        Me.Contraseña.HeaderText = "Contraseña"
        Me.Contraseña.Name = "Contraseña"
        Me.Contraseña.ReadOnly = True
        Me.Contraseña.Visible = False
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
        Me.btnListar.TabIndex = 16
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
        Me.btnModificar.TabIndex = 15
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
        Me.btnEliminar.TabIndex = 14
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
        Me.btnIngresar.TabIndex = 13
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(248, 183)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(120, 20)
        Me.txtEmail.TabIndex = 8
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(90, 249)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(93, 20)
        Me.txtTel.TabIndex = 5
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(90, 217)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(93, 20)
        Me.txtDireccion.TabIndex = 4
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(90, 181)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(93, 20)
        Me.txtApellido.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(90, 154)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(93, 20)
        Me.txtNombre.TabIndex = 2
        '
        'mskCi
        '
        Me.mskCi.Location = New System.Drawing.Point(90, 123)
        Me.mskCi.Mask = "00000000"
        Me.mskCi.Name = "mskCi"
        Me.mskCi.Size = New System.Drawing.Size(93, 20)
        Me.mskCi.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(189, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "E-mail"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Teléfono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Dirección"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "CI"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(189, 216)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Contraseña"
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(287, 218)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(81, 20)
        Me.txtContraseña.TabIndex = 9
        Me.txtContraseña.UseSystemPasswordChar = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(198, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 20)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Sueldo"
        '
        'txtSueldo
        '
        Me.txtSueldo.Location = New System.Drawing.Point(275, 122)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(93, 20)
        Me.txtSueldo.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(198, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 20)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Cargo"
        '
        'comboCargo
        '
        Me.comboCargo.FormattingEnabled = True
        Me.comboCargo.Location = New System.Drawing.Point(275, 153)
        Me.comboCargo.Name = "comboCargo"
        Me.comboCargo.Size = New System.Drawing.Size(93, 21)
        Me.comboCargo.TabIndex = 7
        '
        'rdbCargo
        '
        Me.rdbCargo.AutoSize = True
        Me.rdbCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbCargo.Location = New System.Drawing.Point(193, 351)
        Me.rdbCargo.Name = "rdbCargo"
        Me.rdbCargo.Size = New System.Drawing.Size(67, 22)
        Me.rdbCargo.TabIndex = 12
        Me.rdbCargo.TabStop = True
        Me.rdbCargo.Text = "Cargo"
        Me.rdbCargo.UseVisualStyleBackColor = True
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
        Me.btnLimpiar.TabIndex = 17
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(12, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(872, 10)
        Me.Panel1.TabIndex = 36
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(12, 316)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(356, 59)
        Me.Panel2.TabIndex = 37
        '
        'frmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(896, 495)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.comboCargo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.rdbCargo)
        Me.Controls.Add(Me.rdbApellido)
        Me.Controls.Add(Me.rdbCi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.mskCi)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleado"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents rdbApellido As RadioButton
    Friend WithEvents rdbCi As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents btnListar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents mskCi As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSueldo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents comboCargo As ComboBox
    Friend WithEvents rdbCargo As RadioButton
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Ci As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Sueldo As DataGridViewTextBoxColumn
    Friend WithEvents Cargo As DataGridViewTextBoxColumn
    Friend WithEvents Contraseña As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
