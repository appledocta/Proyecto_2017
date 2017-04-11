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
        Me.BtnInhabilitar_cli = New System.Windows.Forms.Button()
        Me.BtnCancelar_cli = New System.Windows.Forms.Button()
        Me.BtnModificar_cli = New System.Windows.Forms.Button()
        Me.BtnNuevo_cli = New System.Windows.Forms.Button()
        Me.BtnGuardar_cli = New System.Windows.Forms.Button()
        Me.BtnHabilitar_cli = New System.Windows.Forms.Button()
        Me.Inexistente = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DTPFecAlta = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBNacionalidad_cli = New System.Windows.Forms.ComboBox()
        Me.DTPFecNac_cli = New System.Windows.Forms.DateTimePicker()
        Me.CbEstCivil_cli = New System.Windows.Forms.ComboBox()
        Me.TxtApellido_cli = New System.Windows.Forms.TextBox()
        Me.TxtNombre_cli = New System.Windows.Forms.TextBox()
        Me.CbTDni_cli = New System.Windows.Forms.ComboBox()
        Me.TxtDni_cli = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblNumCancha = New System.Windows.Forms.Label()
        Me.LblTamChancha = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbHabilitar_cli = New System.Windows.Forms.CheckBox()
        Me.CbInhabilitar_cli = New System.Windows.Forms.CheckBox()
        Me.DataListado_cli = New System.Windows.Forms.DataGridView()
        Me.Inhabilitar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Habilitar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TxtBuscar_cli = New System.Windows.Forms.TextBox()
        Me.CboCampo_cli = New System.Windows.Forms.ComboBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataListado_cli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(377, 375)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(185, 13)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Marcados en color estan inhabilitados"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnInhabilitar_cli)
        Me.Panel2.Controls.Add(Me.BtnCancelar_cli)
        Me.Panel2.Controls.Add(Me.BtnModificar_cli)
        Me.Panel2.Controls.Add(Me.BtnNuevo_cli)
        Me.Panel2.Controls.Add(Me.BtnGuardar_cli)
        Me.Panel2.Controls.Add(Me.BtnHabilitar_cli)
        Me.Panel2.Location = New System.Drawing.Point(4, 308)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(355, 55)
        Me.Panel2.TabIndex = 27
        '
        'BtnInhabilitar_cli
        '
        Me.BtnInhabilitar_cli.Location = New System.Drawing.Point(264, 14)
        Me.BtnInhabilitar_cli.Name = "BtnInhabilitar_cli"
        Me.BtnInhabilitar_cli.Size = New System.Drawing.Size(75, 29)
        Me.BtnInhabilitar_cli.TabIndex = 18
        Me.BtnInhabilitar_cli.Text = "Inhabilitar"
        Me.BtnInhabilitar_cli.UseVisualStyleBackColor = True
        '
        'BtnCancelar_cli
        '
        Me.BtnCancelar_cli.Location = New System.Drawing.Point(183, 14)
        Me.BtnCancelar_cli.Name = "BtnCancelar_cli"
        Me.BtnCancelar_cli.Size = New System.Drawing.Size(75, 29)
        Me.BtnCancelar_cli.TabIndex = 17
        Me.BtnCancelar_cli.Text = "Cancelar"
        Me.BtnCancelar_cli.UseVisualStyleBackColor = True
        '
        'BtnModificar_cli
        '
        Me.BtnModificar_cli.Location = New System.Drawing.Point(102, 14)
        Me.BtnModificar_cli.Name = "BtnModificar_cli"
        Me.BtnModificar_cli.Size = New System.Drawing.Size(75, 29)
        Me.BtnModificar_cli.TabIndex = 15
        Me.BtnModificar_cli.Text = "Modificar"
        Me.BtnModificar_cli.UseVisualStyleBackColor = True
        '
        'BtnNuevo_cli
        '
        Me.BtnNuevo_cli.Location = New System.Drawing.Point(19, 14)
        Me.BtnNuevo_cli.Name = "BtnNuevo_cli"
        Me.BtnNuevo_cli.Size = New System.Drawing.Size(75, 29)
        Me.BtnNuevo_cli.TabIndex = 14
        Me.BtnNuevo_cli.Text = "Nuevo"
        Me.BtnNuevo_cli.UseVisualStyleBackColor = True
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
        'BtnHabilitar_cli
        '
        Me.BtnHabilitar_cli.Location = New System.Drawing.Point(264, 14)
        Me.BtnHabilitar_cli.Name = "BtnHabilitar_cli"
        Me.BtnHabilitar_cli.Size = New System.Drawing.Size(75, 29)
        Me.BtnHabilitar_cli.TabIndex = 19
        Me.BtnHabilitar_cli.Text = "Habilitar"
        Me.BtnHabilitar_cli.UseVisualStyleBackColor = True
        '
        'Inexistente
        '
        Me.Inexistente.AutoSize = True
        Me.Inexistente.Location = New System.Drawing.Point(547, 140)
        Me.Inexistente.Name = "Inexistente"
        Me.Inexistente.Size = New System.Drawing.Size(94, 13)
        Me.Inexistente.TabIndex = 25
        Me.Inexistente.TabStop = True
        Me.Inexistente.Text = "Datos Inexistentes"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.DTPFecAlta)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.CBNacionalidad_cli)
        Me.Panel1.Controls.Add(Me.DTPFecNac_cli)
        Me.Panel1.Controls.Add(Me.CbEstCivil_cli)
        Me.Panel1.Controls.Add(Me.TxtApellido_cli)
        Me.Panel1.Controls.Add(Me.TxtNombre_cli)
        Me.Panel1.Controls.Add(Me.CbTDni_cli)
        Me.Panel1.Controls.Add(Me.TxtDni_cli)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LblNumCancha)
        Me.Panel1.Controls.Add(Me.LblTamChancha)
        Me.Panel1.Location = New System.Drawing.Point(4, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(355, 284)
        Me.Panel1.TabIndex = 24
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(323, 206)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 20)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "*"
        '
        'DTPFecAlta
        '
        Me.DTPFecAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecAlta.Location = New System.Drawing.Point(117, 199)
        Me.DTPFecAlta.Name = "DTPFecAlta"
        Me.DTPFecAlta.Size = New System.Drawing.Size(200, 20)
        Me.DTPFecAlta.TabIndex = 25
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(34, 204)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 13)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Fecha de Alta"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(322, 229)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(15, 20)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(322, 177)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 20)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(322, 147)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 20)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(322, 114)
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
        Me.Label10.Location = New System.Drawing.Point(322, 75)
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
        Me.Label9.Location = New System.Drawing.Point(322, 49)
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
        Me.Label8.Location = New System.Drawing.Point(322, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "*"
        '
        'CBNacionalidad_cli
        '
        Me.CBNacionalidad_cli.FormattingEnabled = True
        Me.CBNacionalidad_cli.Items.AddRange(New Object() {"ARGENTINA", "AFGANISTAN", "ALBANIA", "ALEMANIA", "ANDORRA", "ANGOLA", "ANGUILLA", "ANTIGUA Y BARBUDA", "ANTILLAS HOLANDESAS", "ARABIA SAUDI", "ARGELIA", "ARMENIA", "ARUBA", "AUSTRALIA", "AUSTRIA", "AZERBAIYAN", "BAHAMAS", "BAHREIN", "BANGLADESH", "BARBADOS", "BELARUS", "BELGICA", "BELICE", "BENIN", "BERMUDAS", "BHUTÁN", "BOLIVIA", "BOSNIA Y HERZEGOVINA", "BOTSWANA", "BRASIL", "BRUNEI", "BULGARIA", "BURKINA FASO", "BURUNDI", "CABO VERDE", "CAMBOYA", "CAMERUN", "CANADA", "CHAD", "CHILE", "CHINA", "CHIPRE", "COLOMBIA", "COMORES", "CONGO", "COREA", "COREA DEL NORTE ", "COSTA DE MARFIL", "COSTA RICA", "CROACIA", "CUBA", "DINAMARCA", "DJIBOUTI", "DOMINICA", "ECUADOR", "EGIPTO", "EL SALVADOR", "EMIRATOS ARABES UNIDOS", "ERITREA", "ESLOVENIA", "ESPAÑA", "ESTADOS UNIDOS DE AMERICA", "ESTONIA", "ETIOPIA", "FIJI", "FILIPINAS", "FINLANDIA", "FRANCIA", "GABON", "GAMBIA", "GEORGIA", "GHANA", "GIBRALTAR", "GRANADA", "GRECIA", "GROENLANDIA", "GUADALUPE", "GUAM", "GUATEMALA", "GUAYANA FRANCESA", "GUERNESEY", "GUINEA", "GUINEA ECUATORIAL", "GUINEA-BISSAU", "GUYANA", "HAITI", "HONDURAS", "HONG KONG", "HUNGRIA", "INDIA", "INDONESIA", "IRAN", "IRAQ", "IRLANDA", "ISLA DE MAN", "ISLA NORFOLK", "ISLANDIA", "ISLAS ALAND", "ISLAS CAIMÁN", "ISLAS COOK", "ISLAS DEL CANAL", "ISLAS FEROE", "ISLAS MALVINAS", "ISLAS MARIANAS DEL NORTE", "ISLAS MARSHALL", "ISLAS PITCAIRN", "ISLAS SALOMON", "ISLAS TURCAS Y CAICOS", "ISLAS VIRGENES BRITANICAS", "ISLAS VÍRGENES DE LOS ESTADOS UNIDOS", "ISRAEL", "ITALIA", "JAMAICA", "JAPON", "JERSEY", "JORDANIA", "KAZAJSTAN", "KENIA", "KIRGUISTAN", "KIRIBATI", "KUWAIT", "LAOS", "LESOTHO", "LETONIA", "LIBANO", "LIBERIA", "LIBIA", "LIECHTENSTEIN", "LITUANIA", "LUXEMBURGO", "MACAO", "MACEDONIA ", "MADAGASCAR", "MALASIA", "MALAWI", "MALDIVAS", "MALI", "MALTA", "MARRUECOS", "MARTINICA", "MAURICIO", "MAURITANIA", "MAYOTTE", "MEXICO", "MICRONESIA", "MOLDAVIA", "MONACO", "MONGOLIA", "MONTENEGRO", "MONTSERRAT", "MOZAMBIQUE", "MYANMAR", "NAMIBIA", "NAURU", "NEPAL", "NICARAGUA", "NIGER", "NIGERIA", "NIUE", "NORUEGA", "NUEVA CALEDONIA", "NUEVA ZELANDA", "OMAN", "OTROS PAISES  O TERRITORIOS DE AMERICA DEL NORTE", "OTROS PAISES O TERRITORIOS  DE SUDAMERICA", "OTROS PAISES O TERRITORIOS DE AFRICA", "OTROS PAISES O TERRITORIOS DE ASIA", "OTROS PAISES O TERRITORIOS DE LA UNION EUROPEA", "OTROS PAISES O TERRITORIOS DE OCEANIA", "OTROS PAISES O TERRITORIOS DEL CARIBE Y AMERICA CENTRAL", "OTROS PAISES O TERRITORIOS DEL RESTO DE EUROPA", "PAISES BAJOS", "PAKISTAN", "PALAOS", "PALESTINA", "PANAMA", "PAPUA NUEVA GUINEA", "PARAGUAY", "PERU", "POLINESIA FRANCESA", "POLONIA", "PORTUGAL", "PUERTO RICO", "QATAR", "REINO UNIDO", "REP.DEMOCRATICA DEL CONGO", "REPUBLICA CENTROAFRICANA", "REPUBLICA CHECA", "REPUBLICA DOMINICANA", "REPUBLICA ESLOVACA", "REUNION", "RUANDA", "RUMANIA", "RUSIA", "SAHARA OCCIDENTAL", "SAMOA", "SAMOA AMERICANA", "SAN BARTOLOME", "SAN CRISTOBAL Y NIEVES", "SAN MARINO", "SAN MARTIN (PARTE FRANCESA)", "SAN PEDRO Y MIQUELON ", "SAN VICENTE Y LAS GRANADINAS", "SANTA HELENA", "SANTA LUCIA", "SANTA SEDE", "SANTO TOME Y PRINCIPE", "SENEGAL", "SERBIA", "SEYCHELLES", "SIERRA LEONA", "SINGAPUR", "SIRIA", "SOMALIA", "SRI LANKA", "SUDAFRICA", "SUDAN", "SUECIA", "SUIZA", "SURINAM", "SVALBARD Y JAN MAYEN", "SWAZILANDIA", "TADYIKISTAN", "TAILANDIA", "TANZANIA", "TIMOR ORIENTAL", "TOGO", "TOKELAU", "TONGA", "TRINIDAD Y TOBAGO", "TUNEZ", "TURKMENISTAN", "TURQUIA", "TUVALU", "UCRANIA", "UGANDA", "URUGUAY", "UZBEKISTAN", "VANUATU", "VENEZUELA", "VIETNAM", "WALLIS Y FORTUNA", "YEMEN", "ZAMBIA", "ZIMBABWE"})
        Me.CBNacionalidad_cli.Location = New System.Drawing.Point(116, 225)
        Me.CBNacionalidad_cli.Name = "CBNacionalidad_cli"
        Me.CBNacionalidad_cli.Size = New System.Drawing.Size(199, 21)
        Me.CBNacionalidad_cli.TabIndex = 13
        '
        'DTPFecNac_cli
        '
        Me.DTPFecNac_cli.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFecNac_cli.Location = New System.Drawing.Point(116, 170)
        Me.DTPFecNac_cli.Name = "DTPFecNac_cli"
        Me.DTPFecNac_cli.Size = New System.Drawing.Size(200, 20)
        Me.DTPFecNac_cli.TabIndex = 12
        '
        'CbEstCivil_cli
        '
        Me.CbEstCivil_cli.FormattingEnabled = True
        Me.CbEstCivil_cli.Items.AddRange(New Object() {"Soltero/a", "Casado/a", "Divorciado/a", "Viudo/a"})
        Me.CbEstCivil_cli.Location = New System.Drawing.Point(116, 139)
        Me.CbEstCivil_cli.Name = "CbEstCivil_cli"
        Me.CbEstCivil_cli.Size = New System.Drawing.Size(199, 21)
        Me.CbEstCivil_cli.TabIndex = 11
        '
        'TxtApellido_cli
        '
        Me.TxtApellido_cli.Location = New System.Drawing.Point(116, 109)
        Me.TxtApellido_cli.Name = "TxtApellido_cli"
        Me.TxtApellido_cli.Size = New System.Drawing.Size(199, 20)
        Me.TxtApellido_cli.TabIndex = 10
        '
        'TxtNombre_cli
        '
        Me.TxtNombre_cli.Location = New System.Drawing.Point(116, 79)
        Me.TxtNombre_cli.Name = "TxtNombre_cli"
        Me.TxtNombre_cli.Size = New System.Drawing.Size(199, 20)
        Me.TxtNombre_cli.TabIndex = 9
        '
        'CbTDni_cli
        '
        Me.CbTDni_cli.FormattingEnabled = True
        Me.CbTDni_cli.Items.AddRange(New Object() {"L.C.", "L.E.", "DNI", "PAS."})
        Me.CbTDni_cli.Location = New System.Drawing.Point(116, 18)
        Me.CbTDni_cli.Name = "CbTDni_cli"
        Me.CbTDni_cli.Size = New System.Drawing.Size(199, 21)
        Me.CbTDni_cli.TabIndex = 7
        '
        'TxtDni_cli
        '
        Me.TxtDni_cli.Location = New System.Drawing.Point(117, 49)
        Me.TxtDni_cli.MaxLength = 9
        Me.TxtDni_cli.Name = "TxtDni_cli"
        Me.TxtDni_cli.Size = New System.Drawing.Size(199, 20)
        Me.TxtDni_cli.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = " Nacionalidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha de nac."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = " Estado civil"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'LblNumCancha
        '
        Me.LblNumCancha.AutoSize = True
        Me.LblNumCancha.Location = New System.Drawing.Point(16, 25)
        Me.LblNumCancha.Name = "LblNumCancha"
        Me.LblNumCancha.Size = New System.Drawing.Size(99, 13)
        Me.LblNumCancha.TabIndex = 1
        Me.LblNumCancha.Text = "Numero de Cancha"
        '
        'LblTamChancha
        '
        Me.LblTamChancha.AutoSize = True
        Me.LblTamChancha.Location = New System.Drawing.Point(6, 54)
        Me.LblTamChancha.Name = "LblTamChancha"
        Me.LblTamChancha.Size = New System.Drawing.Size(101, 13)
        Me.LblTamChancha.TabIndex = 0
        Me.LblTamChancha.Text = "Tamaño de Cancha"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CbHabilitar_cli)
        Me.GroupBox1.Controls.Add(Me.CbInhabilitar_cli)
        Me.GroupBox1.Controls.Add(Me.DataListado_cli)
        Me.GroupBox1.Controls.Add(Me.TxtBuscar_cli)
        Me.GroupBox1.Controls.Add(Me.CboCampo_cli)
        Me.GroupBox1.Location = New System.Drawing.Point(373, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 357)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listado de Vendedores"
        '
        'CbHabilitar_cli
        '
        Me.CbHabilitar_cli.AutoSize = True
        Me.CbHabilitar_cli.Location = New System.Drawing.Point(145, 45)
        Me.CbHabilitar_cli.Name = "CbHabilitar_cli"
        Me.CbHabilitar_cli.Size = New System.Drawing.Size(64, 17)
        Me.CbHabilitar_cli.TabIndex = 23
        Me.CbHabilitar_cli.Text = "Habilitar"
        Me.CbHabilitar_cli.UseVisualStyleBackColor = True
        '
        'CbInhabilitar_cli
        '
        Me.CbInhabilitar_cli.AutoSize = True
        Me.CbInhabilitar_cli.Location = New System.Drawing.Point(20, 46)
        Me.CbInhabilitar_cli.Name = "CbInhabilitar_cli"
        Me.CbInhabilitar_cli.Size = New System.Drawing.Size(71, 17)
        Me.CbInhabilitar_cli.TabIndex = 22
        Me.CbInhabilitar_cli.Text = "Inhabilitar"
        Me.CbInhabilitar_cli.UseVisualStyleBackColor = True
        '
        'DataListado_cli
        '
        Me.DataListado_cli.AllowUserToAddRows = False
        Me.DataListado_cli.AllowUserToDeleteRows = False
        Me.DataListado_cli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataListado_cli.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Inhabilitar, Me.Habilitar})
        Me.DataListado_cli.Location = New System.Drawing.Point(7, 70)
        Me.DataListado_cli.Name = "DataListado_cli"
        Me.DataListado_cli.ReadOnly = True
        Me.DataListado_cli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataListado_cli.Size = New System.Drawing.Size(498, 281)
        Me.DataListado_cli.TabIndex = 2
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
        'TxtBuscar_cli
        '
        Me.TxtBuscar_cli.Location = New System.Drawing.Point(145, 19)
        Me.TxtBuscar_cli.Name = "TxtBuscar_cli"
        Me.TxtBuscar_cli.Size = New System.Drawing.Size(162, 20)
        Me.TxtBuscar_cli.TabIndex = 21
        '
        'CboCampo_cli
        '
        Me.CboCampo_cli.FormattingEnabled = True
        Me.CboCampo_cli.Items.AddRange(New Object() {"DNI_Cliente", "Apellido", "Nombre"})
        Me.CboCampo_cli.Location = New System.Drawing.Point(20, 19)
        Me.CboCampo_cli.Name = "CboCampo_cli"
        Me.CboCampo_cli.Size = New System.Drawing.Size(107, 21)
        Me.CboCampo_cli.TabIndex = 20
        Me.CboCampo_cli.Text = "DNI_Cliente"
        '
        'Canchas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 395)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Inexistente)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Canchas"
        Me.Text = "Canchas"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataListado_cli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnInhabilitar_cli As System.Windows.Forms.Button
    Friend WithEvents BtnCancelar_cli As System.Windows.Forms.Button
    Friend WithEvents BtnModificar_cli As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo_cli As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar_cli As System.Windows.Forms.Button
    Friend WithEvents BtnHabilitar_cli As System.Windows.Forms.Button
    Friend WithEvents Inexistente As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents DTPFecAlta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CBNacionalidad_cli As System.Windows.Forms.ComboBox
    Friend WithEvents DTPFecNac_cli As System.Windows.Forms.DateTimePicker
    Friend WithEvents CbEstCivil_cli As System.Windows.Forms.ComboBox
    Friend WithEvents TxtApellido_cli As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre_cli As System.Windows.Forms.TextBox
    Friend WithEvents CbTDni_cli As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDni_cli As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblNumCancha As System.Windows.Forms.Label
    Friend WithEvents LblTamChancha As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CbHabilitar_cli As System.Windows.Forms.CheckBox
    Friend WithEvents CbInhabilitar_cli As System.Windows.Forms.CheckBox
    Friend WithEvents DataListado_cli As System.Windows.Forms.DataGridView
    Friend WithEvents Inhabilitar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Habilitar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TxtBuscar_cli As System.Windows.Forms.TextBox
    Friend WithEvents CboCampo_cli As System.Windows.Forms.ComboBox
End Class
