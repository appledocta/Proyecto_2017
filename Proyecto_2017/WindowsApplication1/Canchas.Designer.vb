<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Canchas
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
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnInhabilitar_cancha = New System.Windows.Forms.Button()
        Me.BtnCancelar_cancha = New System.Windows.Forms.Button()
        Me.BtnModificar_cancha = New System.Windows.Forms.Button()
        Me.BtnNuevo_cancha = New System.Windows.Forms.Button()
        Me.BtnGuardar_cli = New System.Windows.Forms.Button()
        Me.BtnHabilitar_cancha = New System.Windows.Forms.Button()
        Me.Inexistente = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DTPFecActPre = New System.Windows.Forms.DateTimePicker()
        Me.TxtPreCancha = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblNumCancha = New System.Windows.Forms.Label()
        Me.LblTamChancha = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbHabilitar_Cancha = New System.Windows.Forms.CheckBox()
        Me.CbInhabilitar_Cancha = New System.Windows.Forms.CheckBox()
        Me.DataListado_Cancha = New System.Windows.Forms.DataGridView()
        Me.Inhabilitar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Habilitar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TxtBuscar_Cancha = New System.Windows.Forms.TextBox()
        Me.CboNumCancha = New System.Windows.Forms.ComboBox()
        Me.TxtNumCancha = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.CBTamCancha = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataListado_Cancha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(376, 365)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(185, 13)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Marcados en color estan inhabilitados"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnInhabilitar_cancha)
        Me.Panel2.Controls.Add(Me.BtnCancelar_cancha)
        Me.Panel2.Controls.Add(Me.BtnModificar_cancha)
        Me.Panel2.Controls.Add(Me.BtnNuevo_cancha)
        Me.Panel2.Controls.Add(Me.BtnGuardar_cli)
        Me.Panel2.Controls.Add(Me.BtnHabilitar_cancha)
        Me.Panel2.Location = New System.Drawing.Point(3, 298)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(355, 55)
        Me.Panel2.TabIndex = 32
        '
        'BtnInhabilitar_cancha
        '
        Me.BtnInhabilitar_cancha.Location = New System.Drawing.Point(264, 3)
        Me.BtnInhabilitar_cancha.Name = "BtnInhabilitar_cancha"
        Me.BtnInhabilitar_cancha.Size = New System.Drawing.Size(75, 29)
        Me.BtnInhabilitar_cancha.TabIndex = 18
        Me.BtnInhabilitar_cancha.Text = "Inhabilitar"
        Me.BtnInhabilitar_cancha.UseVisualStyleBackColor = True
        '
        'BtnCancelar_cancha
        '
        Me.BtnCancelar_cancha.Location = New System.Drawing.Point(183, 14)
        Me.BtnCancelar_cancha.Name = "BtnCancelar_cancha"
        Me.BtnCancelar_cancha.Size = New System.Drawing.Size(75, 29)
        Me.BtnCancelar_cancha.TabIndex = 17
        Me.BtnCancelar_cancha.Text = "Cancelar"
        Me.BtnCancelar_cancha.UseVisualStyleBackColor = True
        '
        'BtnModificar_cancha
        '
        Me.BtnModificar_cancha.Location = New System.Drawing.Point(102, 14)
        Me.BtnModificar_cancha.Name = "BtnModificar_cancha"
        Me.BtnModificar_cancha.Size = New System.Drawing.Size(75, 29)
        Me.BtnModificar_cancha.TabIndex = 15
        Me.BtnModificar_cancha.Text = "Modificar"
        Me.BtnModificar_cancha.UseVisualStyleBackColor = True
        '
        'BtnNuevo_cancha
        '
        Me.BtnNuevo_cancha.Location = New System.Drawing.Point(19, 14)
        Me.BtnNuevo_cancha.Name = "BtnNuevo_cancha"
        Me.BtnNuevo_cancha.Size = New System.Drawing.Size(75, 29)
        Me.BtnNuevo_cancha.TabIndex = 14
        Me.BtnNuevo_cancha.Text = "Nuevo"
        Me.BtnNuevo_cancha.UseVisualStyleBackColor = True
        '
        'BtnGuardar_cli
        '
        Me.BtnGuardar_cli.Location = New System.Drawing.Point(102, 14)
        Me.BtnGuardar_cli.Name = "BtnGuardar_cli"
        Me.BtnGuardar_cli.Size = New System.Drawing.Size(75, 29)
        Me.BtnGuardar_cli.TabIndex = 16
        Me.BtnGuardar_cli.Text = "Guardar"
        Me.BtnGuardar_cli.UseVisualStyleBackColor = True
        '
        'BtnHabilitar_cancha
        '
        Me.BtnHabilitar_cancha.Location = New System.Drawing.Point(264, 14)
        Me.BtnHabilitar_cancha.Name = "BtnHabilitar_cancha"
        Me.BtnHabilitar_cancha.Size = New System.Drawing.Size(75, 29)
        Me.BtnHabilitar_cancha.TabIndex = 19
        Me.BtnHabilitar_cancha.Text = "Habilitar"
        Me.BtnHabilitar_cancha.UseVisualStyleBackColor = True
        '
        'Inexistente
        '
        Me.Inexistente.AutoSize = True
        Me.Inexistente.Location = New System.Drawing.Point(546, 130)
        Me.Inexistente.Name = "Inexistente"
        Me.Inexistente.Size = New System.Drawing.Size(94, 13)
        Me.Inexistente.TabIndex = 30
        Me.Inexistente.TabStop = True
        Me.Inexistente.Text = "Datos Inexistentes"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtDescripcion)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CBTamCancha)
        Me.Panel1.Controls.Add(Me.BtnBuscar)
        Me.Panel1.Controls.Add(Me.TxtNumCancha)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.DTPFecActPre)
        Me.Panel1.Controls.Add(Me.TxtPreCancha)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LblNumCancha)
        Me.Panel1.Controls.Add(Me.LblTamChancha)
        Me.Panel1.Location = New System.Drawing.Point(3, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 231)
        Me.Panel1.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(340, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 20)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(340, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(340, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(340, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "*"
        '
        'DTPFecActPre
        '
        Me.DTPFecActPre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecActPre.Location = New System.Drawing.Point(135, 110)
        Me.DTPFecActPre.Name = "DTPFecActPre"
        Me.DTPFecActPre.Size = New System.Drawing.Size(200, 20)
        Me.DTPFecActPre.TabIndex = 12
        '
        'TxtPreCancha
        '
        Me.TxtPreCancha.Location = New System.Drawing.Point(134, 81)
        Me.TxtPreCancha.Name = "TxtPreCancha"
        Me.TxtPreCancha.Size = New System.Drawing.Size(199, 20)
        Me.TxtPreCancha.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(-1, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Ult Actualizacion de Precio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio de Cancha"
        '
        'LblNumCancha
        '
        Me.LblNumCancha.AutoSize = True
        Me.LblNumCancha.Location = New System.Drawing.Point(34, 27)
        Me.LblNumCancha.Name = "LblNumCancha"
        Me.LblNumCancha.Size = New System.Drawing.Size(99, 13)
        Me.LblNumCancha.TabIndex = 1
        Me.LblNumCancha.Text = "Numero de Cancha"
        '
        'LblTamChancha
        '
        Me.LblTamChancha.AutoSize = True
        Me.LblTamChancha.Location = New System.Drawing.Point(24, 56)
        Me.LblTamChancha.Name = "LblTamChancha"
        Me.LblTamChancha.Size = New System.Drawing.Size(101, 13)
        Me.LblTamChancha.TabIndex = 0
        Me.LblTamChancha.Text = "Tamaño de Cancha"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CbHabilitar_Cancha)
        Me.GroupBox1.Controls.Add(Me.CbInhabilitar_Cancha)
        Me.GroupBox1.Controls.Add(Me.DataListado_Cancha)
        Me.GroupBox1.Controls.Add(Me.TxtBuscar_Cancha)
        Me.GroupBox1.Controls.Add(Me.CboNumCancha)
        Me.GroupBox1.Location = New System.Drawing.Point(372, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 357)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Vendedores"
        '
        'CbHabilitar_Cancha
        '
        Me.CbHabilitar_Cancha.AutoSize = True
        Me.CbHabilitar_Cancha.Location = New System.Drawing.Point(145, 45)
        Me.CbHabilitar_Cancha.Name = "CbHabilitar_Cancha"
        Me.CbHabilitar_Cancha.Size = New System.Drawing.Size(64, 17)
        Me.CbHabilitar_Cancha.TabIndex = 23
        Me.CbHabilitar_Cancha.Text = "Habilitar"
        Me.CbHabilitar_Cancha.UseVisualStyleBackColor = True
        '
        'CbInhabilitar_Cancha
        '
        Me.CbInhabilitar_Cancha.AutoSize = True
        Me.CbInhabilitar_Cancha.Location = New System.Drawing.Point(20, 46)
        Me.CbInhabilitar_Cancha.Name = "CbInhabilitar_Cancha"
        Me.CbInhabilitar_Cancha.Size = New System.Drawing.Size(71, 17)
        Me.CbInhabilitar_Cancha.TabIndex = 22
        Me.CbInhabilitar_Cancha.Text = "Inhabilitar"
        Me.CbInhabilitar_Cancha.UseVisualStyleBackColor = True
        '
        'DataListado_Cancha
        '
        Me.DataListado_Cancha.AllowUserToAddRows = False
        Me.DataListado_Cancha.AllowUserToDeleteRows = False
        Me.DataListado_Cancha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListado_Cancha.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Inhabilitar, Me.Habilitar})
        Me.DataListado_Cancha.Location = New System.Drawing.Point(7, 70)
        Me.DataListado_Cancha.Name = "DataListado_Cancha"
        Me.DataListado_Cancha.ReadOnly = True
        Me.DataListado_Cancha.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataListado_Cancha.Size = New System.Drawing.Size(498, 281)
        Me.DataListado_Cancha.TabIndex = 2
        '
        'Inhabilitar
        '
        Me.Inhabilitar.HeaderText = "Inhabilitar"
        Me.Inhabilitar.Name = "Inhabilitar"
        Me.Inhabilitar.ReadOnly = True
        '
        'Habilitar
        '
        Me.Habilitar.HeaderText = "Habilitar"
        Me.Habilitar.Name = "Habilitar"
        Me.Habilitar.ReadOnly = True
        '
        'TxtBuscar_Cancha
        '
        Me.TxtBuscar_Cancha.Location = New System.Drawing.Point(145, 19)
        Me.TxtBuscar_Cancha.Name = "TxtBuscar_Cancha"
        Me.TxtBuscar_Cancha.Size = New System.Drawing.Size(162, 20)
        Me.TxtBuscar_Cancha.TabIndex = 21
        '
        'CboNumCancha
        '
        Me.CboNumCancha.FormattingEnabled = True
        Me.CboNumCancha.Items.AddRange(New Object() {"Num_Cancha"})
        Me.CboNumCancha.Location = New System.Drawing.Point(20, 19)
        Me.CboNumCancha.Name = "CboNumCancha"
        Me.CboNumCancha.Size = New System.Drawing.Size(107, 21)
        Me.CboNumCancha.TabIndex = 20
        Me.CboNumCancha.Text = "Num_Cancha"
        '
        'TxtNumCancha
        '
        Me.TxtNumCancha.Location = New System.Drawing.Point(134, 22)
        Me.TxtNumCancha.Name = "TxtNumCancha"
        Me.TxtNumCancha.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumCancha.TabIndex = 27
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(240, 22)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(51, 23)
        Me.BtnBuscar.TabIndex = 28
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'CBTamCancha
        '
        Me.CBTamCancha.FormattingEnabled = True
        Me.CBTamCancha.Location = New System.Drawing.Point(135, 51)
        Me.CBTamCancha.Name = "CBTamCancha"
        Me.CBTamCancha.Size = New System.Drawing.Size(198, 21)
        Me.CBTamCancha.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Descripcion"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(134, 140)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(199, 54)
        Me.TxtDescripcion.TabIndex = 31
        '
        'Canchas
        '
        Me.ClientSize = New System.Drawing.Size(890, 382)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Inexistente)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Canchas"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataListado_Cancha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnInhabilitar_cancha As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar_cancha As System.Windows.Forms.Button
    Friend WithEvents BtnModificar_cancha As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo_cancha As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar_cli As System.Windows.Forms.Button
    Friend WithEvents BtnHabilitar_cancha As System.Windows.Forms.Button
    Friend WithEvents Inexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DTPFecActPre As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtPreCancha As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblNumCancha As System.Windows.Forms.Label
    Friend WithEvents LblTamChancha As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CbHabilitar_Cancha As System.Windows.Forms.CheckBox
    Friend WithEvents CbInhabilitar_Cancha As System.Windows.Forms.CheckBox
    Friend WithEvents DataListado_Cancha As System.Windows.Forms.DataGridView
    Friend WithEvents Inhabilitar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Habilitar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TxtBuscar_Cancha As System.Windows.Forms.TextBox
    Friend WithEvents CboNumCancha As System.Windows.Forms.ComboBox
    Friend WithEvents CBTamCancha As System.Windows.Forms.ComboBox
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents TxtNumCancha As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
