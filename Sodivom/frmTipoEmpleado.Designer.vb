<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTipoEmpleado
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
        Me.dgvDatos = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(168, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(235, 31)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "TIPO EMPLEADO"
        '
        'dgvDatos
        '
        Me.dgvDatos.AllowUserToAddRows = False
        Me.dgvDatos.AllowUserToDeleteRows = False
        Me.dgvDatos.BackgroundColor = System.Drawing.SystemColors.WindowText
        Me.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.TipoEmpleado})
        Me.dgvDatos.Location = New System.Drawing.Point(327, 140)
        Me.dgvDatos.Name = "dgvDatos"
        Me.dgvDatos.ReadOnly = True
        Me.dgvDatos.Size = New System.Drawing.Size(243, 294)
        Me.dgvDatos.TabIndex = 5
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'TipoEmpleado
        '
        Me.TipoEmpleado.HeaderText = "Cargo"
        Me.TipoEmpleado.Name = "TipoEmpleado"
        Me.TipoEmpleado.ReadOnly = True
        '
        'btnListar
        '
        Me.btnListar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnListar.FlatAppearance.BorderSize = 0
        Me.btnListar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnListar.Location = New System.Drawing.Point(80, 314)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(175, 40)
        Me.btnListar.TabIndex = 4
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnBorrar.FlatAppearance.BorderSize = 0
        Me.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBorrar.Location = New System.Drawing.Point(80, 255)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(175, 40)
        Me.btnBorrar.TabIndex = 3
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnIngresar.FlatAppearance.BorderSize = 0
        Me.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnIngresar.Location = New System.Drawing.Point(80, 197)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(175, 40)
        Me.btnIngresar.TabIndex = 2
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Cargo"
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(85, 141)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(208, 20)
        Me.txtTipo.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(12, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(558, 10)
        Me.Panel1.TabIndex = 65
        '
        'frmTipoEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(580, 449)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dgvDatos)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmTipoEmpleado"
        Me.Text = "frmCargo"
        CType(Me.dgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents btnListar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents TipoEmpleado As DataGridViewTextBoxColumn
    'Friend WithEvents txtTipo As TextBox
    Friend WithEvents Panel1 As Panel
End Class
