namespace WareData.Interfaz
{
    partial class WareData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WareData));
            this.MenuPrin = new System.Windows.Forms.MenuStrip();
            this.mnAplicacion = new System.Windows.Forms.ToolStripMenuItem();
            this.smnRealTime = new System.Windows.Forms.ToolStripMenuItem();
            this.smnHistorico = new System.Windows.Forms.ToolStripMenuItem();
            this.smnImportarMedicion = new System.Windows.Forms.ToolStripMenuItem();
            this.smnEscucharSerial = new System.Windows.Forms.ToolStripMenuItem();
            this.smnExportarBD = new System.Windows.Forms.ToolStripMenuItem();
            this.smnGraficar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.smnUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.smnConfiguracionBD = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smnConfigSerial = new System.Windows.Forms.ToolStripMenuItem();
            this.mnReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.activacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeWareDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolAccesosDirectos = new System.Windows.Forms.ToolStrip();
            this.GridFileDAT = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.Equipo = new System.Windows.Forms.ToolStripStatusLabel();
            this.stRuta = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusSerial = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlSERIAL = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.optText = new System.Windows.Forms.RadioButton();
            this.optHex = new System.Windows.Forms.RadioButton();
            this.GridMatrizDatos = new System.Windows.Forms.DataGridView();
            this.INFORMACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdDesconectarSerial = new System.Windows.Forms.Button();
            this.cmdAceptarSerial = new System.Windows.Forms.Button();
            this.cmdSalirSERIAL = new System.Windows.Forms.Button();
            this.cmdNuevaConfigSerial = new System.Windows.Forms.Button();
            this.txtDataEscucha = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbParidad = new System.Windows.Forms.ComboBox();
            this.cmbBitSegundo = new System.Windows.Forms.ComboBox();
            this.cmbPuertoCOM = new System.Windows.Forms.ComboBox();
            this.txtBitsParidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBitDatos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tabConfiguraciones = new System.Windows.Forms.TabControl();
            this.tabInicio = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chkImportaDAT = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chklSQLServer = new System.Windows.Forms.CheckBox();
            this.tabArchivoTexto = new System.Windows.Forms.TabPage();
            this.cmdAsistImportacion = new System.Windows.Forms.Button();
            this.cmdExaminarDAT = new System.Windows.Forms.Button();
            this.txtRutaDAT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabBD = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.cmdCreaConexion = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblBDActual = new System.Windows.Forms.Label();
            this.cmdNuevaBD = new System.Windows.Forms.Button();
            this.txtNuevaBD = new System.Windows.Forms.TextBox();
            this.cmbBD = new System.Windows.Forms.ComboBox();
            this.cmdSeleccionBD = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.cmdConectar = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtInstancia = new System.Windows.Forms.TextBox();
            this.tabEncabezados = new System.Windows.Forms.TabPage();
            this.lblOperador = new System.Windows.Forms.Label();
            this.lblComentario = new System.Windows.Forms.Label();
            this.lblPozo = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblPlataforma = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCompania = new System.Windows.Forms.Label();
            this.tabPreferencias = new System.Windows.Forms.TabPage();
            this.cmdGuardaPreferencias = new System.Windows.Forms.Button();
            this.txtPerfil = new System.Windows.Forms.TextBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.chkGuardaPreferencias = new System.Windows.Forms.CheckBox();
            this.pnlConfigImportar = new System.Windows.Forms.Panel();
            this.cmdFinalizaConfiguracion = new System.Windows.Forms.Button();
            this.cmdSalirpnlConfImportar = new System.Windows.Forms.Button();
            this.pnlAsistDAT = new System.Windows.Forms.Panel();
            this.cmdAsistAtras = new System.Windows.Forms.Button();
            this.cmdAsistSalir = new System.Windows.Forms.Button();
            this.grpAsistPag1 = new System.Windows.Forms.GroupBox();
            this.numAPartirLinea = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.AsistGridDAT1 = new System.Windows.Forms.DataGridView();
            this.cmdAsistSiguiente1 = new System.Windows.Forms.Button();
            this.cmdAsistFinalizar = new System.Windows.Forms.Button();
            this.grpAsistPag3 = new System.Windows.Forms.GroupBox();
            this.cmdAsistAplicar = new System.Windows.Forms.Button();
            this.listAsistEncabezados = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AsistGridDAT3 = new System.Windows.Forms.DataGridView();
            this.grpAsistPag2 = new System.Windows.Forms.GroupBox();
            this.AsistGridDAT2 = new System.Windows.Forms.DataGridView();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.optComa = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.optDobleComa = new System.Windows.Forms.RadioButton();
            this.optOtros = new System.Windows.Forms.Label();
            this.optEspacio = new System.Windows.Forms.RadioButton();
            this.pnlMatrizDatos = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlExportaBD = new System.Windows.Forms.Panel();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.cmdExportarDAT = new System.Windows.Forms.Button();
            this.cmdSalirDAT = new System.Windows.Forms.Button();
            this.cmdCancelarDAT = new System.Windows.Forms.Button();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.txtDBNuevaMySQL = new System.Windows.Forms.TextBox();
            this.cmbMySQL = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cmdNuevaDBMySQL = new System.Windows.Forms.Button();
            this.cmdSeleccionDBMySQL = new System.Windows.Forms.Button();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtPuertoMySQL = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cmdTestMySQL = new System.Windows.Forms.Button();
            this.txtPassMySQL = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtUsuarioMySQL = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtInstanciaMySQL = new System.Windows.Forms.TextBox();
            this.tlImportarMedicion = new System.Windows.Forms.ToolStripButton();
            this.tlExportarDB = new System.Windows.Forms.ToolStripButton();
            this.tlSerial = new System.Windows.Forms.ToolStripButton();
            this.tlExportaExcel = new System.Windows.Forms.ToolStripButton();
            this.tlReportePersonalizado = new System.Windows.Forms.ToolStripButton();
            this.tlGrafica = new System.Windows.Forms.ToolStripButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.smnmsImportarMedicion = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrin.SuspendLayout();
            this.ToolAccesosDirectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFileDAT)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.pnlSERIAL.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMatrizDatos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabConfiguraciones.SuspendLayout();
            this.tabInicio.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabArchivoTexto.SuspendLayout();
            this.tabBD.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabEncabezados.SuspendLayout();
            this.tabPreferencias.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.pnlConfigImportar.SuspendLayout();
            this.pnlAsistDAT.SuspendLayout();
            this.grpAsistPag1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAPartirLinea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsistGridDAT1)).BeginInit();
            this.grpAsistPag3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsistGridDAT3)).BeginInit();
            this.grpAsistPag2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsistGridDAT2)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.pnlMatrizDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlExportaBD.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrin
            // 
            this.MenuPrin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAplicacion,
            this.mnAdministracion,
            this.mnReportes,
            this.mnAyuda,
            this.mnSalir});
            this.MenuPrin.Location = new System.Drawing.Point(0, 0);
            this.MenuPrin.Name = "MenuPrin";
            this.MenuPrin.Size = new System.Drawing.Size(758, 24);
            this.MenuPrin.TabIndex = 0;
            this.MenuPrin.Text = "menuStrip1";
            // 
            // mnAplicacion
            // 
            this.mnAplicacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnRealTime,
            this.smnHistorico,
            this.smnImportarMedicion,
            this.smnEscucharSerial,
            this.smnExportarBD,
            this.smnGraficar});
            this.mnAplicacion.Name = "mnAplicacion";
            this.mnAplicacion.Size = new System.Drawing.Size(51, 20);
            this.mnAplicacion.Text = "Modo";
            // 
            // smnRealTime
            // 
            this.smnRealTime.Name = "smnRealTime";
            this.smnRealTime.Size = new System.Drawing.Size(182, 22);
            this.smnRealTime.Text = "Real Time...";
            // 
            // smnHistorico
            // 
            this.smnHistorico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnmsImportarMedicion});
            this.smnHistorico.Name = "smnHistorico";
            this.smnHistorico.Size = new System.Drawing.Size(182, 22);
            this.smnHistorico.Text = "Historico...";
            this.smnHistorico.Click += new System.EventHandler(this.smnHistorico_Click);
            // 
            // smnImportarMedicion
            // 
            this.smnImportarMedicion.Name = "smnImportarMedicion";
            this.smnImportarMedicion.Size = new System.Drawing.Size(182, 22);
            this.smnImportarMedicion.Text = "Importar Medición...";
            this.smnImportarMedicion.Visible = false;
            this.smnImportarMedicion.Click += new System.EventHandler(this.smnImportarMedicion_Click);
            // 
            // smnEscucharSerial
            // 
            this.smnEscucharSerial.Enabled = false;
            this.smnEscucharSerial.Name = "smnEscucharSerial";
            this.smnEscucharSerial.Size = new System.Drawing.Size(182, 22);
            this.smnEscucharSerial.Text = "Escuchar Serial...";
            this.smnEscucharSerial.Click += new System.EventHandler(this.smnEscucharSerial_Click);
            // 
            // smnExportarBD
            // 
            this.smnExportarBD.Enabled = false;
            this.smnExportarBD.Name = "smnExportarBD";
            this.smnExportarBD.Size = new System.Drawing.Size(182, 22);
            this.smnExportarBD.Text = "Exportar a BD";
            this.smnExportarBD.Click += new System.EventHandler(this.smnExportarBD_Click);
            // 
            // smnGraficar
            // 
            this.smnGraficar.Enabled = false;
            this.smnGraficar.Name = "smnGraficar";
            this.smnGraficar.Size = new System.Drawing.Size(182, 22);
            this.smnGraficar.Text = "Graficar";
            this.smnGraficar.Visible = false;
            this.smnGraficar.Click += new System.EventHandler(this.smnGraficar_Click);
            // 
            // mnAdministracion
            // 
            this.mnAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnUsuarios,
            this.smnConfiguracionBD,
            this.mantenimientoToolStripMenuItem,
            this.smnConfigSerial});
            this.mnAdministracion.Name = "mnAdministracion";
            this.mnAdministracion.Size = new System.Drawing.Size(100, 20);
            this.mnAdministracion.Text = "Administracion";
            // 
            // smnUsuarios
            // 
            this.smnUsuarios.Name = "smnUsuarios";
            this.smnUsuarios.Size = new System.Drawing.Size(190, 22);
            this.smnUsuarios.Text = "Usuarios...";
            // 
            // smnConfiguracionBD
            // 
            this.smnConfiguracionBD.Enabled = false;
            this.smnConfiguracionBD.Name = "smnConfiguracionBD";
            this.smnConfiguracionBD.Size = new System.Drawing.Size(190, 22);
            this.smnConfiguracionBD.Text = "Configuracion BD...";
            this.smnConfiguracionBD.Click += new System.EventHandler(this.smnConfiguracionBD_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.Enabled = false;
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento...";
            // 
            // smnConfigSerial
            // 
            this.smnConfigSerial.Name = "smnConfigSerial";
            this.smnConfigSerial.Size = new System.Drawing.Size(190, 22);
            this.smnConfigSerial.Text = "Configuracion Serial...";
            this.smnConfigSerial.Click += new System.EventHandler(this.smnConfigSerial_Click);
            // 
            // mnReportes
            // 
            this.mnReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historicoToolStripMenuItem,
            this.logsToolStripMenuItem});
            this.mnReportes.Name = "mnReportes";
            this.mnReportes.Size = new System.Drawing.Size(65, 20);
            this.mnReportes.Text = "Reportes";
            // 
            // historicoToolStripMenuItem
            // 
            this.historicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem,
            this.personalizadoToolStripMenuItem});
            this.historicoToolStripMenuItem.Enabled = false;
            this.historicoToolStripMenuItem.Name = "historicoToolStripMenuItem";
            this.historicoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.historicoToolStripMenuItem.Text = "Historico";
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Enabled = false;
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.dToolStripMenuItem.Text = "Mensual...";
            // 
            // personalizadoToolStripMenuItem
            // 
            this.personalizadoToolStripMenuItem.Enabled = false;
            this.personalizadoToolStripMenuItem.Name = "personalizadoToolStripMenuItem";
            this.personalizadoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.personalizadoToolStripMenuItem.Text = "Personalizado...";
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Enabled = false;
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logsToolStripMenuItem.Text = "Logs...";
            // 
            // mnAyuda
            // 
            this.mnAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activacionToolStripMenuItem,
            this.ayudaToolStripMenuItem1,
            this.acercaDeWareDataToolStripMenuItem});
            this.mnAyuda.Name = "mnAyuda";
            this.mnAyuda.Size = new System.Drawing.Size(53, 20);
            this.mnAyuda.Text = "Ayuda";
            // 
            // activacionToolStripMenuItem
            // 
            this.activacionToolStripMenuItem.Name = "activacionToolStripMenuItem";
            this.activacionToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.activacionToolStripMenuItem.Text = "Activacion...";
            this.activacionToolStripMenuItem.Click += new System.EventHandler(this.activacionToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Enabled = false;
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.ayudaToolStripMenuItem1.Text = "Ayuda...";
            // 
            // acercaDeWareDataToolStripMenuItem
            // 
            this.acercaDeWareDataToolStripMenuItem.Name = "acercaDeWareDataToolStripMenuItem";
            this.acercaDeWareDataToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.acercaDeWareDataToolStripMenuItem.Text = "Acerca de WareData...";
            // 
            // mnSalir
            // 
            this.mnSalir.Name = "mnSalir";
            this.mnSalir.Size = new System.Drawing.Size(41, 20);
            this.mnSalir.Text = "Salir";
            this.mnSalir.Click += new System.EventHandler(this.mnSalir_Click);
            // 
            // ToolAccesosDirectos
            // 
            this.ToolAccesosDirectos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlImportarMedicion,
            this.tlExportarDB,
            this.tlSerial,
            this.tlExportaExcel,
            this.tlReportePersonalizado,
            this.tlGrafica});
            this.ToolAccesosDirectos.Location = new System.Drawing.Point(0, 24);
            this.ToolAccesosDirectos.Name = "ToolAccesosDirectos";
            this.ToolAccesosDirectos.Size = new System.Drawing.Size(758, 25);
            this.ToolAccesosDirectos.TabIndex = 1;
            this.ToolAccesosDirectos.Text = "toolStrip1";
            // 
            // GridFileDAT
            // 
            this.GridFileDAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFileDAT.Location = new System.Drawing.Point(8, 28);
            this.GridFileDAT.Name = "GridFileDAT";
            this.GridFileDAT.ReadOnly = true;
            this.GridFileDAT.Size = new System.Drawing.Size(703, 420);
            this.GridFileDAT.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stUsuario,
            this.Equipo,
            this.stRuta,
            this.lblStatusSerial});
            this.statusStrip1.Location = new System.Drawing.Point(0, 554);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(758, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stUsuario
            // 
            this.stUsuario.Name = "stUsuario";
            this.stUsuario.Size = new System.Drawing.Size(104, 17);
            this.stUsuario.Text = "Usuario                   ";
            // 
            // Equipo
            // 
            this.Equipo.Name = "Equipo";
            this.Equipo.Size = new System.Drawing.Size(131, 17);
            this.Equipo.Text = "Equipo                             ";
            // 
            // stRuta
            // 
            this.stRuta.Name = "stRuta";
            this.stRuta.Size = new System.Drawing.Size(280, 17);
            this.stRuta.Text = "Ruta:                                                                            " +
                "      ";
            // 
            // lblStatusSerial
            // 
            this.lblStatusSerial.Name = "lblStatusSerial";
            this.lblStatusSerial.Size = new System.Drawing.Size(67, 17);
            this.lblStatusSerial.Text = "StatusSerial";
            // 
            // pnlSERIAL
            // 
            this.pnlSERIAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlSERIAL.Controls.Add(this.groupBox4);
            this.pnlSERIAL.Controls.Add(this.GridMatrizDatos);
            this.pnlSERIAL.Controls.Add(this.label7);
            this.pnlSERIAL.Controls.Add(this.label6);
            this.pnlSERIAL.Controls.Add(this.groupBox3);
            this.pnlSERIAL.Controls.Add(this.txtDataEscucha);
            this.pnlSERIAL.Controls.Add(this.groupBox2);
            this.pnlSERIAL.Location = new System.Drawing.Point(183, 64);
            this.pnlSERIAL.Name = "pnlSERIAL";
            this.pnlSERIAL.Size = new System.Drawing.Size(410, 467);
            this.pnlSERIAL.TabIndex = 5;
            this.pnlSERIAL.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.optText);
            this.groupBox4.Controls.Add(this.optHex);
            this.groupBox4.Location = new System.Drawing.Point(318, 178);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(82, 60);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Text Mode";
            // 
            // optText
            // 
            this.optText.AutoSize = true;
            this.optText.Location = new System.Drawing.Point(16, 15);
            this.optText.Name = "optText";
            this.optText.Size = new System.Drawing.Size(46, 17);
            this.optText.TabIndex = 13;
            this.optText.TabStop = true;
            this.optText.Text = "Text";
            this.optText.UseVisualStyleBackColor = true;
            // 
            // optHex
            // 
            this.optHex.AutoSize = true;
            this.optHex.Location = new System.Drawing.Point(16, 34);
            this.optHex.Name = "optHex";
            this.optHex.Size = new System.Drawing.Size(44, 17);
            this.optHex.TabIndex = 12;
            this.optHex.TabStop = true;
            this.optHex.Text = "Hex";
            this.optHex.UseVisualStyleBackColor = true;
            // 
            // GridMatrizDatos
            // 
            this.GridMatrizDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMatrizDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.INFORMACION});
            this.GridMatrizDatos.Location = new System.Drawing.Point(12, 264);
            this.GridMatrizDatos.Name = "GridMatrizDatos";
            this.GridMatrizDatos.Size = new System.Drawing.Size(388, 190);
            this.GridMatrizDatos.TabIndex = 11;
            // 
            // INFORMACION
            // 
            this.INFORMACION.HeaderText = "INFORMACION";
            this.INFORMACION.Name = "INFORMACION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Matriz de Datos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mensaje Entrante:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdDesconectarSerial);
            this.groupBox3.Controls.Add(this.cmdAceptarSerial);
            this.groupBox3.Controls.Add(this.cmdSalirSERIAL);
            this.groupBox3.Controls.Add(this.cmdNuevaConfigSerial);
            this.groupBox3.Location = new System.Drawing.Point(252, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 152);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones";
            // 
            // cmdDesconectarSerial
            // 
            this.cmdDesconectarSerial.Location = new System.Drawing.Point(11, 83);
            this.cmdDesconectarSerial.Name = "cmdDesconectarSerial";
            this.cmdDesconectarSerial.Size = new System.Drawing.Size(126, 28);
            this.cmdDesconectarSerial.TabIndex = 6;
            this.cmdDesconectarSerial.Text = "Desconectar";
            this.cmdDesconectarSerial.UseVisualStyleBackColor = true;
            this.cmdDesconectarSerial.Click += new System.EventHandler(this.cmdDesconectarSerial_Click);
            // 
            // cmdAceptarSerial
            // 
            this.cmdAceptarSerial.Location = new System.Drawing.Point(11, 51);
            this.cmdAceptarSerial.Name = "cmdAceptarSerial";
            this.cmdAceptarSerial.Size = new System.Drawing.Size(126, 28);
            this.cmdAceptarSerial.TabIndex = 5;
            this.cmdAceptarSerial.Text = "Conectar";
            this.cmdAceptarSerial.UseVisualStyleBackColor = true;
            this.cmdAceptarSerial.Click += new System.EventHandler(this.cmdAceptarSerial_Click);
            // 
            // cmdSalirSERIAL
            // 
            this.cmdSalirSERIAL.Location = new System.Drawing.Point(11, 115);
            this.cmdSalirSERIAL.Name = "cmdSalirSERIAL";
            this.cmdSalirSERIAL.Size = new System.Drawing.Size(126, 27);
            this.cmdSalirSERIAL.TabIndex = 3;
            this.cmdSalirSERIAL.Text = "Salir";
            this.cmdSalirSERIAL.UseVisualStyleBackColor = true;
            this.cmdSalirSERIAL.Click += new System.EventHandler(this.cmdSalirpnlSERIAL_Click);
            // 
            // cmdNuevaConfigSerial
            // 
            this.cmdNuevaConfigSerial.Location = new System.Drawing.Point(11, 18);
            this.cmdNuevaConfigSerial.Name = "cmdNuevaConfigSerial";
            this.cmdNuevaConfigSerial.Size = new System.Drawing.Size(126, 28);
            this.cmdNuevaConfigSerial.TabIndex = 4;
            this.cmdNuevaConfigSerial.Text = "Nueva Configuracion";
            this.cmdNuevaConfigSerial.UseVisualStyleBackColor = true;
            this.cmdNuevaConfigSerial.Click += new System.EventHandler(this.cmdNuevaConfigSerial_Click);
            // 
            // txtDataEscucha
            // 
            this.txtDataEscucha.Enabled = false;
            this.txtDataEscucha.Location = new System.Drawing.Point(12, 188);
            this.txtDataEscucha.Multiline = true;
            this.txtDataEscucha.Name = "txtDataEscucha";
            this.txtDataEscucha.Size = new System.Drawing.Size(300, 50);
            this.txtDataEscucha.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbParidad);
            this.groupBox2.Controls.Add(this.cmbBitSegundo);
            this.groupBox2.Controls.Add(this.cmbPuertoCOM);
            this.groupBox2.Controls.Add(this.txtBitsParidad);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBitDatos);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 152);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuracion COM";
            // 
            // cmbParidad
            // 
            this.cmbParidad.Enabled = false;
            this.cmbParidad.FormattingEnabled = true;
            this.cmbParidad.Items.AddRange(new object[] {
            "Par",
            "Impar",
            "Ninguno",
            "Marca",
            "Espacio"});
            this.cmbParidad.Location = new System.Drawing.Point(107, 97);
            this.cmbParidad.Name = "cmbParidad";
            this.cmbParidad.Size = new System.Drawing.Size(101, 21);
            this.cmbParidad.TabIndex = 12;
            // 
            // cmbBitSegundo
            // 
            this.cmbBitSegundo.Enabled = false;
            this.cmbBitSegundo.FormattingEnabled = true;
            this.cmbBitSegundo.Items.AddRange(new object[] {
            "110",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600",
            "",
            ""});
            this.cmbBitSegundo.Location = new System.Drawing.Point(107, 46);
            this.cmbBitSegundo.Name = "cmbBitSegundo";
            this.cmbBitSegundo.Size = new System.Drawing.Size(101, 21);
            this.cmbBitSegundo.TabIndex = 11;
            // 
            // cmbPuertoCOM
            // 
            this.cmbPuertoCOM.Enabled = false;
            this.cmbPuertoCOM.FormattingEnabled = true;
            this.cmbPuertoCOM.Items.AddRange(new object[] {
            "COM2"});
            this.cmbPuertoCOM.Location = new System.Drawing.Point(107, 21);
            this.cmbPuertoCOM.Name = "cmbPuertoCOM";
            this.cmbPuertoCOM.Size = new System.Drawing.Size(101, 21);
            this.cmbPuertoCOM.TabIndex = 10;
            // 
            // txtBitsParidad
            // 
            this.txtBitsParidad.Enabled = false;
            this.txtBitsParidad.Location = new System.Drawing.Point(108, 122);
            this.txtBitsParidad.Name = "txtBitsParidad";
            this.txtBitsParidad.Size = new System.Drawing.Size(100, 20);
            this.txtBitsParidad.TabIndex = 9;
            this.txtBitsParidad.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Puerto COM:";
            // 
            // txtBitDatos
            // 
            this.txtBitDatos.Enabled = false;
            this.txtBitDatos.Location = new System.Drawing.Point(108, 71);
            this.txtBitDatos.Name = "txtBitDatos";
            this.txtBitDatos.Size = new System.Drawing.Size(100, 20);
            this.txtBitDatos.TabIndex = 6;
            this.txtBitDatos.Text = "8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bits de paridad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paridad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bits de datos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bit por segundo:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tabConfiguraciones);
            this.groupBox5.Location = new System.Drawing.Point(11, 88);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(394, 262);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Configuraciones";
            // 
            // tabConfiguraciones
            // 
            this.tabConfiguraciones.Controls.Add(this.tabInicio);
            this.tabConfiguraciones.Controls.Add(this.tabArchivoTexto);
            this.tabConfiguraciones.Controls.Add(this.tabBD);
            this.tabConfiguraciones.Controls.Add(this.tabEncabezados);
            this.tabConfiguraciones.Controls.Add(this.tabPreferencias);
            this.tabConfiguraciones.Location = new System.Drawing.Point(7, 22);
            this.tabConfiguraciones.Name = "tabConfiguraciones";
            this.tabConfiguraciones.SelectedIndex = 0;
            this.tabConfiguraciones.Size = new System.Drawing.Size(378, 233);
            this.tabConfiguraciones.TabIndex = 0;
            // 
            // tabInicio
            // 
            this.tabInicio.Controls.Add(this.groupBox7);
            this.tabInicio.Controls.Add(this.groupBox6);
            this.tabInicio.Location = new System.Drawing.Point(4, 22);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicio.Size = new System.Drawing.Size(370, 207);
            this.tabInicio.TabIndex = 0;
            this.tabInicio.Text = "Inicio";
            this.tabInicio.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chkImportaDAT);
            this.groupBox7.Location = new System.Drawing.Point(82, 24);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 63);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Escritura en Base de Datos";
            // 
            // chkImportaDAT
            // 
            this.chkImportaDAT.AutoSize = true;
            this.chkImportaDAT.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkImportaDAT.Location = new System.Drawing.Point(28, 27);
            this.chkImportaDAT.Name = "chkImportaDAT";
            this.chkImportaDAT.Size = new System.Drawing.Size(131, 17);
            this.chkImportaDAT.TabIndex = 0;
            this.chkImportaDAT.Text = "Importar Archivo .DAT";
            this.chkImportaDAT.UseVisualStyleBackColor = true;
            this.chkImportaDAT.CheckedChanged += new System.EventHandler(this.chkImportaDAT_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chklSQLServer);
            this.groupBox6.Location = new System.Drawing.Point(82, 100);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 63);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Escritura en Base de Datos";
            // 
            // chklSQLServer
            // 
            this.chklSQLServer.AutoSize = true;
            this.chklSQLServer.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chklSQLServer.Location = new System.Drawing.Point(55, 28);
            this.chklSQLServer.Name = "chklSQLServer";
            this.chklSQLServer.Size = new System.Drawing.Size(95, 17);
            this.chklSQLServer.TabIndex = 1;
            this.chklSQLServer.Text = "MySQL Server";
            this.chklSQLServer.UseVisualStyleBackColor = true;
            this.chklSQLServer.CheckedChanged += new System.EventHandler(this.chklSQLServer_CheckedChanged);
            // 
            // tabArchivoTexto
            // 
            this.tabArchivoTexto.Controls.Add(this.cmdAsistImportacion);
            this.tabArchivoTexto.Controls.Add(this.cmdExaminarDAT);
            this.tabArchivoTexto.Controls.Add(this.txtRutaDAT);
            this.tabArchivoTexto.Controls.Add(this.label8);
            this.tabArchivoTexto.Location = new System.Drawing.Point(4, 22);
            this.tabArchivoTexto.Name = "tabArchivoTexto";
            this.tabArchivoTexto.Size = new System.Drawing.Size(370, 207);
            this.tabArchivoTexto.TabIndex = 2;
            this.tabArchivoTexto.Text = "Archivo de Texto";
            this.tabArchivoTexto.UseVisualStyleBackColor = true;
            // 
            // cmdAsistImportacion
            // 
            this.cmdAsistImportacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAsistImportacion.Location = new System.Drawing.Point(15, 153);
            this.cmdAsistImportacion.Name = "cmdAsistImportacion";
            this.cmdAsistImportacion.Size = new System.Drawing.Size(159, 23);
            this.cmdAsistImportacion.TabIndex = 29;
            this.cmdAsistImportacion.Text = "Asistente de Importacion...";
            this.cmdAsistImportacion.UseVisualStyleBackColor = true;
            this.cmdAsistImportacion.Visible = false;
            this.cmdAsistImportacion.Click += new System.EventHandler(this.cmdAsistImportacion_Click);
            // 
            // cmdExaminarDAT
            // 
            this.cmdExaminarDAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExaminarDAT.Location = new System.Drawing.Point(287, 94);
            this.cmdExaminarDAT.Name = "cmdExaminarDAT";
            this.cmdExaminarDAT.Size = new System.Drawing.Size(71, 23);
            this.cmdExaminarDAT.TabIndex = 28;
            this.cmdExaminarDAT.Text = "Examinar";
            this.cmdExaminarDAT.UseVisualStyleBackColor = true;
            this.cmdExaminarDAT.Click += new System.EventHandler(this.cmdExaminarDAT_Click);
            // 
            // txtRutaDAT
            // 
            this.txtRutaDAT.Enabled = false;
            this.txtRutaDAT.Location = new System.Drawing.Point(15, 68);
            this.txtRutaDAT.Name = "txtRutaDAT";
            this.txtRutaDAT.Size = new System.Drawing.Size(343, 20);
            this.txtRutaDAT.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "Arhivo:";
            // 
            // tabBD
            // 
            this.tabBD.Controls.Add(this.groupBox11);
            this.tabBD.Controls.Add(this.groupBox9);
            this.tabBD.Controls.Add(this.groupBox8);
            this.tabBD.Location = new System.Drawing.Point(4, 22);
            this.tabBD.Name = "tabBD";
            this.tabBD.Padding = new System.Windows.Forms.Padding(3);
            this.tabBD.Size = new System.Drawing.Size(370, 207);
            this.tabBD.TabIndex = 1;
            this.tabBD.Text = "Bases de Datos";
            this.tabBD.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.cmdCreaConexion);
            this.groupBox11.Location = new System.Drawing.Point(195, 152);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(169, 44);
            this.groupBox11.TabIndex = 20;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Opciones";
            // 
            // cmdCreaConexion
            // 
            this.cmdCreaConexion.Enabled = false;
            this.cmdCreaConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCreaConexion.Location = new System.Drawing.Point(45, 15);
            this.cmdCreaConexion.Name = "cmdCreaConexion";
            this.cmdCreaConexion.Size = new System.Drawing.Size(83, 23);
            this.cmdCreaConexion.TabIndex = 26;
            this.cmdCreaConexion.Text = "Guardar";
            this.cmdCreaConexion.UseVisualStyleBackColor = true;
            this.cmdCreaConexion.Click += new System.EventHandler(this.cmdCreaConexion_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label17);
            this.groupBox9.Controls.Add(this.lblBDActual);
            this.groupBox9.Controls.Add(this.cmdNuevaBD);
            this.groupBox9.Controls.Add(this.txtNuevaBD);
            this.groupBox9.Controls.Add(this.cmbBD);
            this.groupBox9.Controls.Add(this.cmdSeleccionBD);
            this.groupBox9.Location = new System.Drawing.Point(195, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(169, 148);
            this.groupBox9.TabIndex = 17;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Acceso a Base de Datos";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkGray;
            this.label17.Location = new System.Drawing.Point(19, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 15);
            this.label17.TabIndex = 41;
            this.label17.Text = "BD Actual:";
            this.label17.Visible = false;
            // 
            // lblBDActual
            // 
            this.lblBDActual.AutoSize = true;
            this.lblBDActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBDActual.ForeColor = System.Drawing.Color.DarkGray;
            this.lblBDActual.Location = new System.Drawing.Point(117, 16);
            this.lblBDActual.Name = "lblBDActual";
            this.lblBDActual.Size = new System.Drawing.Size(26, 15);
            this.lblBDActual.TabIndex = 40;
            this.lblBDActual.Text = "BD";
            this.lblBDActual.Visible = false;
            // 
            // cmdNuevaBD
            // 
            this.cmdNuevaBD.Enabled = false;
            this.cmdNuevaBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevaBD.Location = new System.Drawing.Point(22, 90);
            this.cmdNuevaBD.Name = "cmdNuevaBD";
            this.cmdNuevaBD.Size = new System.Drawing.Size(121, 23);
            this.cmdNuevaBD.TabIndex = 24;
            this.cmdNuevaBD.Text = "Nueva BD";
            this.cmdNuevaBD.UseVisualStyleBackColor = true;
            this.cmdNuevaBD.Click += new System.EventHandler(this.cmdNuevaBD_Click);
            // 
            // txtNuevaBD
            // 
            this.txtNuevaBD.Enabled = false;
            this.txtNuevaBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaBD.Location = new System.Drawing.Point(22, 119);
            this.txtNuevaBD.Name = "txtNuevaBD";
            this.txtNuevaBD.Size = new System.Drawing.Size(121, 20);
            this.txtNuevaBD.TabIndex = 25;
            // 
            // cmbBD
            // 
            this.cmbBD.Enabled = false;
            this.cmbBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBD.FormattingEnabled = true;
            this.cmbBD.ItemHeight = 13;
            this.cmbBD.Location = new System.Drawing.Point(22, 63);
            this.cmbBD.Name = "cmbBD";
            this.cmbBD.Size = new System.Drawing.Size(121, 21);
            this.cmbBD.TabIndex = 12;
            // 
            // cmdSeleccionBD
            // 
            this.cmdSeleccionBD.Enabled = false;
            this.cmdSeleccionBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSeleccionBD.Location = new System.Drawing.Point(22, 34);
            this.cmdSeleccionBD.Name = "cmdSeleccionBD";
            this.cmdSeleccionBD.Size = new System.Drawing.Size(121, 23);
            this.cmdSeleccionBD.TabIndex = 22;
            this.cmdSeleccionBD.Text = "Seleccionar BD";
            this.cmdSeleccionBD.UseVisualStyleBackColor = true;
            this.cmdSeleccionBD.Click += new System.EventHandler(this.cmdSeleccionBD_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.txtPuerto);
            this.groupBox8.Controls.Add(this.lblPuerto);
            this.groupBox8.Controls.Add(this.cmdConectar);
            this.groupBox8.Controls.Add(this.txtPass);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.txtUsuario);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.txtInstancia);
            this.groupBox8.Location = new System.Drawing.Point(6, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(183, 149);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Acceso a Base de Datos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(1, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(1, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(1, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "*";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Enabled = false;
            this.txtPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuerto.Location = new System.Drawing.Point(59, 96);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(116, 20);
            this.txtPuerto.TabIndex = 20;
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuerto.Location = new System.Drawing.Point(18, 99);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(41, 13);
            this.lblPuerto.TabIndex = 18;
            this.lblPuerto.Text = "Puerto:";
            this.lblPuerto.Visible = false;
            // 
            // cmdConectar
            // 
            this.cmdConectar.Enabled = false;
            this.cmdConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConectar.Location = new System.Drawing.Point(91, 122);
            this.cmdConectar.Name = "cmdConectar";
            this.cmdConectar.Size = new System.Drawing.Size(84, 23);
            this.cmdConectar.TabIndex = 21;
            this.cmdConectar.Text = "Test";
            this.cmdConectar.UseVisualStyleBackColor = true;
            this.cmdConectar.Click += new System.EventHandler(this.cmdConectar_Click);
            // 
            // txtPass
            // 
            this.txtPass.Enabled = false;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(59, 71);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(116, 20);
            this.txtPass.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(26, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Pass:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(59, 45);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(116, 20);
            this.txtUsuario.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Usuario:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(27, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Host:";
            // 
            // txtInstancia
            // 
            this.txtInstancia.Enabled = false;
            this.txtInstancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstancia.Location = new System.Drawing.Point(59, 19);
            this.txtInstancia.Name = "txtInstancia";
            this.txtInstancia.Size = new System.Drawing.Size(116, 20);
            this.txtInstancia.TabIndex = 17;
            // 
            // tabEncabezados
            // 
            this.tabEncabezados.Controls.Add(this.lblOperador);
            this.tabEncabezados.Controls.Add(this.lblComentario);
            this.tabEncabezados.Controls.Add(this.lblPozo);
            this.tabEncabezados.Controls.Add(this.lblCampo);
            this.tabEncabezados.Controls.Add(this.lblPlataforma);
            this.tabEncabezados.Controls.Add(this.lblCliente);
            this.tabEncabezados.Controls.Add(this.lblCompania);
            this.tabEncabezados.Location = new System.Drawing.Point(4, 22);
            this.tabEncabezados.Name = "tabEncabezados";
            this.tabEncabezados.Size = new System.Drawing.Size(370, 207);
            this.tabEncabezados.TabIndex = 3;
            this.tabEncabezados.Text = "Encabezados";
            this.tabEncabezados.UseVisualStyleBackColor = true;
            // 
            // lblOperador
            // 
            this.lblOperador.AutoSize = true;
            this.lblOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperador.Location = new System.Drawing.Point(-6, 144);
            this.lblOperador.Name = "lblOperador";
            this.lblOperador.Size = new System.Drawing.Size(69, 13);
            this.lblOperador.TabIndex = 12;
            this.lblOperador.Text = "OPERADOR:";
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.Location = new System.Drawing.Point(-42, 170);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(78, 13);
            this.lblComentario.TabIndex = 11;
            this.lblComentario.Text = "COMENTARIO:";
            // 
            // lblPozo
            // 
            this.lblPozo.AutoSize = true;
            this.lblPozo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPozo.Location = new System.Drawing.Point(29, 118);
            this.lblPozo.Name = "lblPozo";
            this.lblPozo.Size = new System.Drawing.Size(39, 13);
            this.lblPozo.TabIndex = 10;
            this.lblPozo.Text = "POZO:";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(19, 92);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(48, 13);
            this.lblCampo.TabIndex = 9;
            this.lblCampo.Text = "CAMPO:";
            // 
            // lblPlataforma
            // 
            this.lblPlataforma.AutoSize = true;
            this.lblPlataforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlataforma.Location = new System.Drawing.Point(-17, 67);
            this.lblPlataforma.Name = "lblPlataforma";
            this.lblPlataforma.Size = new System.Drawing.Size(79, 13);
            this.lblPlataforma.TabIndex = 8;
            this.lblPlataforma.Text = "PLATAFORMA:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(-13, 44);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(52, 13);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "CLIENTE:";
            // 
            // lblCompania
            // 
            this.lblCompania.AutoSize = true;
            this.lblCompania.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompania.Location = new System.Drawing.Point(13, 21);
            this.lblCompania.Name = "lblCompania";
            this.lblCompania.Size = new System.Drawing.Size(65, 13);
            this.lblCompania.TabIndex = 6;
            this.lblCompania.Text = "COMPANIA:";
            // 
            // tabPreferencias
            // 
            this.tabPreferencias.Controls.Add(this.cmdGuardaPreferencias);
            this.tabPreferencias.Controls.Add(this.txtPerfil);
            this.tabPreferencias.Controls.Add(this.lblPerfil);
            this.tabPreferencias.Controls.Add(this.groupBox12);
            this.tabPreferencias.Location = new System.Drawing.Point(4, 22);
            this.tabPreferencias.Name = "tabPreferencias";
            this.tabPreferencias.Size = new System.Drawing.Size(370, 207);
            this.tabPreferencias.TabIndex = 4;
            this.tabPreferencias.Text = "Preferencias";
            this.tabPreferencias.UseVisualStyleBackColor = true;
            // 
            // cmdGuardaPreferencias
            // 
            this.cmdGuardaPreferencias.Enabled = false;
            this.cmdGuardaPreferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardaPreferencias.Location = new System.Drawing.Point(127, 138);
            this.cmdGuardaPreferencias.Name = "cmdGuardaPreferencias";
            this.cmdGuardaPreferencias.Size = new System.Drawing.Size(126, 23);
            this.cmdGuardaPreferencias.TabIndex = 23;
            this.cmdGuardaPreferencias.Text = "Guardar Preferencias";
            this.cmdGuardaPreferencias.UseVisualStyleBackColor = true;
            this.cmdGuardaPreferencias.Click += new System.EventHandler(this.cmdGuardaPreferencias_Click);
            // 
            // txtPerfil
            // 
            this.txtPerfil.Enabled = false;
            this.txtPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerfil.Location = new System.Drawing.Point(69, 114);
            this.txtPerfil.Name = "txtPerfil";
            this.txtPerfil.Size = new System.Drawing.Size(247, 20);
            this.txtPerfil.TabIndex = 22;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(25, 117);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(38, 15);
            this.lblPerfil.TabIndex = 21;
            this.lblPerfil.Text = "Perfil:";
            this.lblPerfil.Visible = false;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.chkGuardaPreferencias);
            this.groupBox12.Location = new System.Drawing.Point(80, 33);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(200, 63);
            this.groupBox12.TabIndex = 4;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Preferencias";
            // 
            // chkGuardaPreferencias
            // 
            this.chkGuardaPreferencias.AutoSize = true;
            this.chkGuardaPreferencias.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkGuardaPreferencias.Location = new System.Drawing.Point(28, 27);
            this.chkGuardaPreferencias.Name = "chkGuardaPreferencias";
            this.chkGuardaPreferencias.Size = new System.Drawing.Size(126, 17);
            this.chkGuardaPreferencias.TabIndex = 0;
            this.chkGuardaPreferencias.Text = "Guardar Preferencias";
            this.chkGuardaPreferencias.UseVisualStyleBackColor = true;
            this.chkGuardaPreferencias.CheckedChanged += new System.EventHandler(this.chkGuardaPreferencias_CheckedChanged);
            // 
            // pnlConfigImportar
            // 
            this.pnlConfigImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlConfigImportar.Controls.Add(this.cmdFinalizaConfiguracion);
            this.pnlConfigImportar.Controls.Add(this.cmdSalirpnlConfImportar);
            this.pnlConfigImportar.Controls.Add(this.pictureBox1);
            this.pnlConfigImportar.Controls.Add(this.groupBox5);
            this.pnlConfigImportar.Location = new System.Drawing.Point(186, 110);
            this.pnlConfigImportar.Name = "pnlConfigImportar";
            this.pnlConfigImportar.Size = new System.Drawing.Size(418, 384);
            this.pnlConfigImportar.TabIndex = 7;
            this.pnlConfigImportar.Visible = false;
            // 
            // cmdFinalizaConfiguracion
            // 
            this.cmdFinalizaConfiguracion.Location = new System.Drawing.Point(180, 357);
            this.cmdFinalizaConfiguracion.Name = "cmdFinalizaConfiguracion";
            this.cmdFinalizaConfiguracion.Size = new System.Drawing.Size(144, 23);
            this.cmdFinalizaConfiguracion.TabIndex = 9;
            this.cmdFinalizaConfiguracion.Text = "Finalizar Configuracion";
            this.cmdFinalizaConfiguracion.UseVisualStyleBackColor = true;
            this.cmdFinalizaConfiguracion.Click += new System.EventHandler(this.cmdFinalizaConfiguracion_Click);
            // 
            // cmdSalirpnlConfImportar
            // 
            this.cmdSalirpnlConfImportar.Location = new System.Drawing.Point(330, 357);
            this.cmdSalirpnlConfImportar.Name = "cmdSalirpnlConfImportar";
            this.cmdSalirpnlConfImportar.Size = new System.Drawing.Size(75, 23);
            this.cmdSalirpnlConfImportar.TabIndex = 8;
            this.cmdSalirpnlConfImportar.Text = "Salir";
            this.cmdSalirpnlConfImportar.UseVisualStyleBackColor = true;
            this.cmdSalirpnlConfImportar.Click += new System.EventHandler(this.cmdSalirpnlConfImportar_Click);
            // 
            // pnlAsistDAT
            // 
            this.pnlAsistDAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlAsistDAT.Controls.Add(this.grpAsistPag1);
            this.pnlAsistDAT.Controls.Add(this.cmdAsistAtras);
            this.pnlAsistDAT.Controls.Add(this.cmdAsistSalir);
            this.pnlAsistDAT.Controls.Add(this.pictureBox2);
            this.pnlAsistDAT.Controls.Add(this.grpAsistPag3);
            this.pnlAsistDAT.Controls.Add(this.grpAsistPag2);
            this.pnlAsistDAT.Controls.Add(this.cmdAsistSiguiente1);
            this.pnlAsistDAT.Controls.Add(this.cmdAsistFinalizar);
            this.pnlAsistDAT.Location = new System.Drawing.Point(100, 103);
            this.pnlAsistDAT.Name = "pnlAsistDAT";
            this.pnlAsistDAT.Size = new System.Drawing.Size(559, 398);
            this.pnlAsistDAT.TabIndex = 8;
            this.pnlAsistDAT.Visible = false;
            // 
            // cmdAsistAtras
            // 
            this.cmdAsistAtras.Location = new System.Drawing.Point(306, 368);
            this.cmdAsistAtras.Name = "cmdAsistAtras";
            this.cmdAsistAtras.Size = new System.Drawing.Size(75, 23);
            this.cmdAsistAtras.TabIndex = 10;
            this.cmdAsistAtras.Text = "Atras";
            this.cmdAsistAtras.UseVisualStyleBackColor = true;
            this.cmdAsistAtras.Visible = false;
            this.cmdAsistAtras.Click += new System.EventHandler(this.cmdAsistAtras_Click);
            // 
            // cmdAsistSalir
            // 
            this.cmdAsistSalir.Location = new System.Drawing.Point(476, 368);
            this.cmdAsistSalir.Name = "cmdAsistSalir";
            this.cmdAsistSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdAsistSalir.TabIndex = 8;
            this.cmdAsistSalir.Text = "Salir";
            this.cmdAsistSalir.UseVisualStyleBackColor = true;
            this.cmdAsistSalir.Click += new System.EventHandler(this.cmdAsistSalir_Click);
            // 
            // grpAsistPag1
            // 
            this.grpAsistPag1.Controls.Add(this.numAPartirLinea);
            this.grpAsistPag1.Controls.Add(this.label9);
            this.grpAsistPag1.Controls.Add(this.AsistGridDAT1);
            this.grpAsistPag1.Location = new System.Drawing.Point(11, 92);
            this.grpAsistPag1.Name = "grpAsistPag1";
            this.grpAsistPag1.Size = new System.Drawing.Size(538, 273);
            this.grpAsistPag1.TabIndex = 6;
            this.grpAsistPag1.TabStop = false;
            this.grpAsistPag1.Text = "Configuraciones";
            // 
            // numAPartirLinea
            // 
            this.numAPartirLinea.Location = new System.Drawing.Point(143, 47);
            this.numAPartirLinea.Name = "numAPartirLinea";
            this.numAPartirLinea.Size = new System.Drawing.Size(50, 20);
            this.numAPartirLinea.TabIndex = 28;
            this.numAPartirLinea.ValueChanged += new System.EventHandler(this.numAPartirLinea_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 18);
            this.label9.TabIndex = 27;
            this.label9.Text = "A partir de la Linea:";
            // 
            // AsistGridDAT1
            // 
            this.AsistGridDAT1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AsistGridDAT1.Location = new System.Drawing.Point(5, 101);
            this.AsistGridDAT1.Name = "AsistGridDAT1";
            this.AsistGridDAT1.Size = new System.Drawing.Size(524, 148);
            this.AsistGridDAT1.TabIndex = 0;
            // 
            // cmdAsistSiguiente1
            // 
            this.cmdAsistSiguiente1.Location = new System.Drawing.Point(387, 368);
            this.cmdAsistSiguiente1.Name = "cmdAsistSiguiente1";
            this.cmdAsistSiguiente1.Size = new System.Drawing.Size(83, 23);
            this.cmdAsistSiguiente1.TabIndex = 9;
            this.cmdAsistSiguiente1.Text = "Siguiente";
            this.cmdAsistSiguiente1.UseVisualStyleBackColor = true;
            this.cmdAsistSiguiente1.Click += new System.EventHandler(this.cmdAsistSiguiente1_Click);
            // 
            // cmdAsistFinalizar
            // 
            this.cmdAsistFinalizar.Location = new System.Drawing.Point(387, 368);
            this.cmdAsistFinalizar.Name = "cmdAsistFinalizar";
            this.cmdAsistFinalizar.Size = new System.Drawing.Size(83, 23);
            this.cmdAsistFinalizar.TabIndex = 12;
            this.cmdAsistFinalizar.Text = "Finalizar";
            this.cmdAsistFinalizar.UseVisualStyleBackColor = true;
            this.cmdAsistFinalizar.Click += new System.EventHandler(this.cmdAsistFinalizar_Click);
            // 
            // grpAsistPag3
            // 
            this.grpAsistPag3.Controls.Add(this.cmdAsistAplicar);
            this.grpAsistPag3.Controls.Add(this.listAsistEncabezados);
            this.grpAsistPag3.Controls.Add(this.label11);
            this.grpAsistPag3.Controls.Add(this.AsistGridDAT3);
            this.grpAsistPag3.Location = new System.Drawing.Point(11, 91);
            this.grpAsistPag3.Name = "grpAsistPag3";
            this.grpAsistPag3.Size = new System.Drawing.Size(538, 272);
            this.grpAsistPag3.TabIndex = 14;
            this.grpAsistPag3.TabStop = false;
            this.grpAsistPag3.Text = "Configuraciones";
            this.grpAsistPag3.Visible = false;
            // 
            // cmdAsistAplicar
            // 
            this.cmdAsistAplicar.Location = new System.Drawing.Point(250, 87);
            this.cmdAsistAplicar.Name = "cmdAsistAplicar";
            this.cmdAsistAplicar.Size = new System.Drawing.Size(75, 23);
            this.cmdAsistAplicar.TabIndex = 29;
            this.cmdAsistAplicar.Text = "Aplicar";
            this.cmdAsistAplicar.UseVisualStyleBackColor = true;
            this.cmdAsistAplicar.Click += new System.EventHandler(this.cmdAsistAplicar_Click);
            // 
            // listAsistEncabezados
            // 
            this.listAsistEncabezados.FormattingEnabled = true;
            this.listAsistEncabezados.Items.AddRange(new object[] {
            "FECHA",
            "HORA",
            "DELTA T",
            "FDO P 92540 PSIA",
            "FDO T 92540 °C",
            "SUP P 92525 PSIA",
            "SUP T 92525 °C",
            "MTS"});
            this.listAsistEncabezados.Location = new System.Drawing.Point(92, 28);
            this.listAsistEncabezados.Name = "listAsistEncabezados";
            this.listAsistEncabezados.Size = new System.Drawing.Size(152, 82);
            this.listAsistEncabezados.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 18);
            this.label11.TabIndex = 27;
            this.label11.Text = "Columnas:";
            // 
            // AsistGridDAT3
            // 
            this.AsistGridDAT3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AsistGridDAT3.Location = new System.Drawing.Point(8, 120);
            this.AsistGridDAT3.Name = "AsistGridDAT3";
            this.AsistGridDAT3.ReadOnly = true;
            this.AsistGridDAT3.Size = new System.Drawing.Size(524, 145);
            this.AsistGridDAT3.TabIndex = 0;
            this.AsistGridDAT3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // grpAsistPag2
            // 
            this.grpAsistPag2.Controls.Add(this.AsistGridDAT2);
            this.grpAsistPag2.Controls.Add(this.groupBox10);
            this.grpAsistPag2.Location = new System.Drawing.Point(11, 92);
            this.grpAsistPag2.Name = "grpAsistPag2";
            this.grpAsistPag2.Size = new System.Drawing.Size(538, 273);
            this.grpAsistPag2.TabIndex = 13;
            this.grpAsistPag2.TabStop = false;
            this.grpAsistPag2.Text = "Configuraciones";
            this.grpAsistPag2.Visible = false;
            // 
            // AsistGridDAT2
            // 
            this.AsistGridDAT2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AsistGridDAT2.Location = new System.Drawing.Point(12, 120);
            this.AsistGridDAT2.Name = "AsistGridDAT2";
            this.AsistGridDAT2.Size = new System.Drawing.Size(517, 145);
            this.AsistGridDAT2.TabIndex = 36;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.optComa);
            this.groupBox10.Controls.Add(this.textBox1);
            this.groupBox10.Controls.Add(this.optDobleComa);
            this.groupBox10.Controls.Add(this.optOtros);
            this.groupBox10.Controls.Add(this.optEspacio);
            this.groupBox10.Location = new System.Drawing.Point(11, 18);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(213, 92);
            this.groupBox10.TabIndex = 35;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Separadores";
            // 
            // optComa
            // 
            this.optComa.AutoSize = true;
            this.optComa.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optComa.Location = new System.Drawing.Point(35, 14);
            this.optComa.Name = "optComa";
            this.optComa.Size = new System.Drawing.Size(63, 17);
            this.optComa.TabIndex = 29;
            this.optComa.TabStop = true;
            this.optComa.Text = "Espacio";
            this.optComa.UseVisualStyleBackColor = true;
            this.optComa.CheckedChanged += new System.EventHandler(this.optComa_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 20);
            this.textBox1.TabIndex = 34;
            // 
            // optDobleComa
            // 
            this.optDobleComa.AutoSize = true;
            this.optDobleComa.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optDobleComa.Location = new System.Drawing.Point(15, 32);
            this.optDobleComa.Name = "optDobleComa";
            this.optDobleComa.Size = new System.Drawing.Size(83, 17);
            this.optDobleComa.TabIndex = 30;
            this.optDobleComa.TabStop = true;
            this.optDobleComa.Text = "Doble Coma";
            this.optDobleComa.UseVisualStyleBackColor = true;
            this.optDobleComa.CheckedChanged += new System.EventHandler(this.optDobleComa_CheckedChanged);
            // 
            // optOtros
            // 
            this.optOtros.AutoSize = true;
            this.optOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optOtros.Location = new System.Drawing.Point(48, 71);
            this.optOtros.Name = "optOtros";
            this.optOtros.Size = new System.Drawing.Size(35, 13);
            this.optOtros.TabIndex = 33;
            this.optOtros.Text = "Otros:";
            // 
            // optEspacio
            // 
            this.optEspacio.AutoSize = true;
            this.optEspacio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.optEspacio.Location = new System.Drawing.Point(46, 49);
            this.optEspacio.Name = "optEspacio";
            this.optEspacio.Size = new System.Drawing.Size(52, 17);
            this.optEspacio.TabIndex = 31;
            this.optEspacio.TabStop = true;
            this.optEspacio.Text = "Coma";
            this.optEspacio.UseVisualStyleBackColor = true;
            this.optEspacio.CheckedChanged += new System.EventHandler(this.optEspacio_CheckedChanged);
            // 
            // pnlMatrizDatos
            // 
            this.pnlMatrizDatos.BackColor = System.Drawing.Color.Transparent;
            this.pnlMatrizDatos.Controls.Add(this.groupBox1);
            this.pnlMatrizDatos.Location = new System.Drawing.Point(0, 60);
            this.pnlMatrizDatos.Name = "pnlMatrizDatos";
            this.pnlMatrizDatos.Size = new System.Drawing.Size(749, 483);
            this.pnlMatrizDatos.TabIndex = 9;
            this.pnlMatrizDatos.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GridFileDAT);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 454);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matriz de Datos";
            // 
            // pnlExportaBD
            // 
            this.pnlExportaBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlExportaBD.Controls.Add(this.pictureBox3);
            this.pnlExportaBD.Controls.Add(this.groupBox13);
            this.pnlExportaBD.Location = new System.Drawing.Point(173, 120);
            this.pnlExportaBD.Name = "pnlExportaBD";
            this.pnlExportaBD.Size = new System.Drawing.Size(418, 331);
            this.pnlExportaBD.TabIndex = 10;
            this.pnlExportaBD.Visible = false;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.groupBox14);
            this.groupBox13.Controls.Add(this.groupBox15);
            this.groupBox13.Controls.Add(this.groupBox16);
            this.groupBox13.Location = new System.Drawing.Point(11, 88);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(394, 234);
            this.groupBox13.TabIndex = 6;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Exportar .DAT a BD";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.cmdExportarDAT);
            this.groupBox14.Controls.Add(this.cmdSalirDAT);
            this.groupBox14.Controls.Add(this.cmdCancelarDAT);
            this.groupBox14.Location = new System.Drawing.Point(18, 184);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(358, 44);
            this.groupBox14.TabIndex = 23;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Opciones";
            // 
            // cmdExportarDAT
            // 
            this.cmdExportarDAT.Location = new System.Drawing.Point(28, 15);
            this.cmdExportarDAT.Name = "cmdExportarDAT";
            this.cmdExportarDAT.Size = new System.Drawing.Size(144, 23);
            this.cmdExportarDAT.TabIndex = 18;
            this.cmdExportarDAT.Text = "Exportar Informacion";
            this.cmdExportarDAT.UseVisualStyleBackColor = true;
            this.cmdExportarDAT.Click += new System.EventHandler(this.cmdExportarDAT_Click);
            // 
            // cmdSalirDAT
            // 
            this.cmdSalirDAT.Location = new System.Drawing.Point(271, 15);
            this.cmdSalirDAT.Name = "cmdSalirDAT";
            this.cmdSalirDAT.Size = new System.Drawing.Size(75, 23);
            this.cmdSalirDAT.TabIndex = 8;
            this.cmdSalirDAT.Text = "Salir";
            this.cmdSalirDAT.UseVisualStyleBackColor = true;
            this.cmdSalirDAT.Click += new System.EventHandler(this.cmdSalirDAT_Click);
            // 
            // cmdCancelarDAT
            // 
            this.cmdCancelarDAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelarDAT.Location = new System.Drawing.Point(179, 15);
            this.cmdCancelarDAT.Name = "cmdCancelarDAT";
            this.cmdCancelarDAT.Size = new System.Drawing.Size(83, 23);
            this.cmdCancelarDAT.TabIndex = 17;
            this.cmdCancelarDAT.Text = "Cancelar";
            this.cmdCancelarDAT.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.txtDBNuevaMySQL);
            this.groupBox15.Controls.Add(this.cmbMySQL);
            this.groupBox15.Controls.Add(this.label18);
            this.groupBox15.Controls.Add(this.label19);
            this.groupBox15.Controls.Add(this.cmdNuevaDBMySQL);
            this.groupBox15.Controls.Add(this.cmdSeleccionDBMySQL);
            this.groupBox15.Location = new System.Drawing.Point(207, 36);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(169, 148);
            this.groupBox15.TabIndex = 22;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Acceso a Base de Datos";
            // 
            // txtDBNuevaMySQL
            // 
            this.txtDBNuevaMySQL.Enabled = false;
            this.txtDBNuevaMySQL.Location = new System.Drawing.Point(22, 118);
            this.txtDBNuevaMySQL.Name = "txtDBNuevaMySQL";
            this.txtDBNuevaMySQL.Size = new System.Drawing.Size(121, 20);
            this.txtDBNuevaMySQL.TabIndex = 43;
            // 
            // cmbMySQL
            // 
            this.cmbMySQL.Enabled = false;
            this.cmbMySQL.FormattingEnabled = true;
            this.cmbMySQL.Location = new System.Drawing.Point(22, 63);
            this.cmbMySQL.Name = "cmbMySQL";
            this.cmbMySQL.Size = new System.Drawing.Size(121, 21);
            this.cmbMySQL.TabIndex = 42;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DarkGray;
            this.label18.Location = new System.Drawing.Point(19, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 15);
            this.label18.TabIndex = 41;
            this.label18.Text = "BD Actual:";
            this.label18.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DarkGray;
            this.label19.Location = new System.Drawing.Point(117, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 15);
            this.label19.TabIndex = 40;
            this.label19.Text = "BD";
            this.label19.Visible = false;
            // 
            // cmdNuevaDBMySQL
            // 
            this.cmdNuevaDBMySQL.Enabled = false;
            this.cmdNuevaDBMySQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNuevaDBMySQL.Location = new System.Drawing.Point(22, 90);
            this.cmdNuevaDBMySQL.Name = "cmdNuevaDBMySQL";
            this.cmdNuevaDBMySQL.Size = new System.Drawing.Size(121, 23);
            this.cmdNuevaDBMySQL.TabIndex = 14;
            this.cmdNuevaDBMySQL.Text = "Nueva BD";
            this.cmdNuevaDBMySQL.UseVisualStyleBackColor = true;
            this.cmdNuevaDBMySQL.Click += new System.EventHandler(this.cmdNuevaDBMySQL_Click);
            // 
            // cmdSeleccionDBMySQL
            // 
            this.cmdSeleccionDBMySQL.Enabled = false;
            this.cmdSeleccionDBMySQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSeleccionDBMySQL.Location = new System.Drawing.Point(22, 34);
            this.cmdSeleccionDBMySQL.Name = "cmdSeleccionDBMySQL";
            this.cmdSeleccionDBMySQL.Size = new System.Drawing.Size(121, 23);
            this.cmdSeleccionDBMySQL.TabIndex = 13;
            this.cmdSeleccionDBMySQL.Text = "Seleccionar BD";
            this.cmdSeleccionDBMySQL.UseVisualStyleBackColor = true;
            this.cmdSeleccionDBMySQL.Click += new System.EventHandler(this.cmdSeleccionDBMySQL_Click);
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.label20);
            this.groupBox16.Controls.Add(this.label21);
            this.groupBox16.Controls.Add(this.label22);
            this.groupBox16.Controls.Add(this.txtPuertoMySQL);
            this.groupBox16.Controls.Add(this.label23);
            this.groupBox16.Controls.Add(this.cmdTestMySQL);
            this.groupBox16.Controls.Add(this.txtPassMySQL);
            this.groupBox16.Controls.Add(this.label24);
            this.groupBox16.Controls.Add(this.txtUsuarioMySQL);
            this.groupBox16.Controls.Add(this.label25);
            this.groupBox16.Controls.Add(this.label26);
            this.groupBox16.Controls.Add(this.txtInstanciaMySQL);
            this.groupBox16.Location = new System.Drawing.Point(18, 35);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(183, 149);
            this.groupBox16.TabIndex = 21;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Acceso a Base de Datos";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(1, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 17);
            this.label20.TabIndex = 22;
            this.label20.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(1, 47);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 17);
            this.label21.TabIndex = 21;
            this.label21.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(1, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 17);
            this.label22.TabIndex = 20;
            this.label22.Text = "*";
            // 
            // txtPuertoMySQL
            // 
            this.txtPuertoMySQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuertoMySQL.Location = new System.Drawing.Point(59, 96);
            this.txtPuertoMySQL.Name = "txtPuertoMySQL";
            this.txtPuertoMySQL.Size = new System.Drawing.Size(116, 20);
            this.txtPuertoMySQL.TabIndex = 19;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(18, 99);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 13);
            this.label23.TabIndex = 18;
            this.label23.Text = "Puerto:";
            this.label23.Visible = false;
            // 
            // cmdTestMySQL
            // 
            this.cmdTestMySQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTestMySQL.Location = new System.Drawing.Point(91, 122);
            this.cmdTestMySQL.Name = "cmdTestMySQL";
            this.cmdTestMySQL.Size = new System.Drawing.Size(84, 23);
            this.cmdTestMySQL.TabIndex = 11;
            this.cmdTestMySQL.Text = "Test";
            this.cmdTestMySQL.UseVisualStyleBackColor = true;
            this.cmdTestMySQL.Visible = false;
            this.cmdTestMySQL.Click += new System.EventHandler(this.button8_Click);
            // 
            // txtPassMySQL
            // 
            this.txtPassMySQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassMySQL.Location = new System.Drawing.Point(59, 71);
            this.txtPassMySQL.Name = "txtPassMySQL";
            this.txtPassMySQL.PasswordChar = '*';
            this.txtPassMySQL.Size = new System.Drawing.Size(116, 20);
            this.txtPassMySQL.TabIndex = 10;
            this.txtPassMySQL.Text = "2888850871";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(26, 74);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(33, 13);
            this.label24.TabIndex = 9;
            this.label24.Text = "Pass:";
            // 
            // txtUsuarioMySQL
            // 
            this.txtUsuarioMySQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioMySQL.Location = new System.Drawing.Point(59, 45);
            this.txtUsuarioMySQL.Name = "txtUsuarioMySQL";
            this.txtUsuarioMySQL.Size = new System.Drawing.Size(116, 20);
            this.txtUsuarioMySQL.TabIndex = 8;
            this.txtUsuarioMySQL.Text = "root";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(13, 48);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(46, 13);
            this.label25.TabIndex = 7;
            this.label25.Text = "Usuario:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(27, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(32, 13);
            this.label26.TabIndex = 5;
            this.label26.Text = "Host:";
            // 
            // txtInstanciaMySQL
            // 
            this.txtInstanciaMySQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstanciaMySQL.Location = new System.Drawing.Point(59, 19);
            this.txtInstanciaMySQL.Name = "txtInstanciaMySQL";
            this.txtInstanciaMySQL.Size = new System.Drawing.Size(116, 20);
            this.txtInstanciaMySQL.TabIndex = 17;
            this.txtInstanciaMySQL.Text = "192.168.2.196";
            // 
            // tlImportarMedicion
            // 
            this.tlImportarMedicion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlImportarMedicion.Image = global::WareData.Properties.Resources.Nuevo;
            this.tlImportarMedicion.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.tlImportarMedicion.Name = "tlImportarMedicion";
            this.tlImportarMedicion.Size = new System.Drawing.Size(23, 22);
            this.tlImportarMedicion.ToolTipText = "Importar Medición";
            this.tlImportarMedicion.Click += new System.EventHandler(this.tlImportarMedicion_Click);
            // 
            // tlExportarDB
            // 
            this.tlExportarDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlExportarDB.Enabled = false;
            this.tlExportarDB.Image = ((System.Drawing.Image)(resources.GetObject("tlExportarDB.Image")));
            this.tlExportarDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlExportarDB.Name = "tlExportarDB";
            this.tlExportarDB.Size = new System.Drawing.Size(23, 22);
            this.tlExportarDB.Text = "Exportar a Base de Datos";
            this.tlExportarDB.Click += new System.EventHandler(this.tlExportarDB_Click);
            // 
            // tlSerial
            // 
            this.tlSerial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlSerial.Image = ((System.Drawing.Image)(resources.GetObject("tlSerial.Image")));
            this.tlSerial.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlSerial.Name = "tlSerial";
            this.tlSerial.Size = new System.Drawing.Size(23, 22);
            this.tlSerial.Text = "Crear Conexion Serial";
            this.tlSerial.Click += new System.EventHandler(this.tlSerial_Click);
            // 
            // tlExportaExcel
            // 
            this.tlExportaExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlExportaExcel.Image = ((System.Drawing.Image)(resources.GetObject("tlExportaExcel.Image")));
            this.tlExportaExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlExportaExcel.Name = "tlExportaExcel";
            this.tlExportaExcel.Size = new System.Drawing.Size(23, 22);
            this.tlExportaExcel.Text = "Exportar a Excel";
            this.tlExportaExcel.Visible = false;
            // 
            // tlReportePersonalizado
            // 
            this.tlReportePersonalizado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlReportePersonalizado.Image = ((System.Drawing.Image)(resources.GetObject("tlReportePersonalizado.Image")));
            this.tlReportePersonalizado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlReportePersonalizado.Name = "tlReportePersonalizado";
            this.tlReportePersonalizado.Size = new System.Drawing.Size(23, 22);
            this.tlReportePersonalizado.Text = "Reportes";
            this.tlReportePersonalizado.Visible = false;
            // 
            // tlGrafica
            // 
            this.tlGrafica.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlGrafica.Image = ((System.Drawing.Image)(resources.GetObject("tlGrafica.Image")));
            this.tlGrafica.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlGrafica.Name = "tlGrafica";
            this.tlGrafica.Size = new System.Drawing.Size(23, 22);
            this.tlGrafica.Text = "Graficar";
            this.tlGrafica.Visible = false;
            this.tlGrafica.Click += new System.EventHandler(this.tlGrafica_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(418, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(581, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // smnmsImportarMedicion
            // 
            this.smnmsImportarMedicion.Name = "smnmsImportarMedicion";
            this.smnmsImportarMedicion.Size = new System.Drawing.Size(182, 22);
            this.smnmsImportarMedicion.Text = "Importar Medicion...";
            this.smnmsImportarMedicion.Click += new System.EventHandler(this.smnmsImportarMedicion_Click);
            // 
            // WareData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(758, 576);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ToolAccesosDirectos);
            this.Controls.Add(this.MenuPrin);
            this.Controls.Add(this.pnlAsistDAT);
            this.Controls.Add(this.pnlSERIAL);
            this.Controls.Add(this.pnlConfigImportar);
            this.Controls.Add(this.pnlExportaBD);
            this.Controls.Add(this.pnlMatrizDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuPrin;
            this.MaximizeBox = false;
            this.Name = "WareData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WareData";
            this.Load += new System.EventHandler(this.WareData_Load);
            this.MenuPrin.ResumeLayout(false);
            this.MenuPrin.PerformLayout();
            this.ToolAccesosDirectos.ResumeLayout(false);
            this.ToolAccesosDirectos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridFileDAT)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlSERIAL.ResumeLayout(false);
            this.pnlSERIAL.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMatrizDatos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.tabConfiguraciones.ResumeLayout(false);
            this.tabInicio.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabArchivoTexto.ResumeLayout(false);
            this.tabArchivoTexto.PerformLayout();
            this.tabBD.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabEncabezados.ResumeLayout(false);
            this.tabEncabezados.PerformLayout();
            this.tabPreferencias.ResumeLayout(false);
            this.tabPreferencias.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.pnlConfigImportar.ResumeLayout(false);
            this.pnlAsistDAT.ResumeLayout(false);
            this.grpAsistPag1.ResumeLayout(false);
            this.grpAsistPag1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAPartirLinea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsistGridDAT1)).EndInit();
            this.grpAsistPag3.ResumeLayout(false);
            this.grpAsistPag3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsistGridDAT3)).EndInit();
            this.grpAsistPag2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AsistGridDAT2)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.pnlMatrizDatos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnlExportaBD.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrin;
        private System.Windows.Forms.ToolStripMenuItem mnAplicacion;
        private System.Windows.Forms.ToolStripMenuItem smnImportarMedicion;
        private System.Windows.Forms.ToolStripMenuItem smnExportarBD;
        private System.Windows.Forms.ToolStripMenuItem mnAdministracion;
        private System.Windows.Forms.ToolStripMenuItem smnUsuarios;
        private System.Windows.Forms.ToolStripMenuItem smnConfiguracionBD;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnReportes;
        private System.Windows.Forms.ToolStripMenuItem historicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnAyuda;
        private System.Windows.Forms.ToolStripMenuItem activacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeWareDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnSalir;
        private System.Windows.Forms.ToolStrip ToolAccesosDirectos;
        private System.Windows.Forms.ToolStripButton tlImportarMedicion;
        private System.Windows.Forms.ToolStripButton tlExportarDB;
        private System.Windows.Forms.ToolStripButton tlExportaExcel;
        private System.Windows.Forms.ToolStripButton tlReportePersonalizado;
        private System.Windows.Forms.DataGridView GridFileDAT;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stUsuario;
        private System.Windows.Forms.ToolStripStatusLabel Equipo;
        private System.Windows.Forms.ToolStripStatusLabel stRuta;
        private System.Windows.Forms.ToolStripButton tlGrafica;
        private System.Windows.Forms.ToolStripMenuItem smnEscucharSerial;
        private System.Windows.Forms.ToolStripMenuItem smnConfigSerial;
        private System.Windows.Forms.Panel pnlSERIAL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBitDatos;
        private System.Windows.Forms.TextBox txtBitsParidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPuertoCOM;
        private System.Windows.Forms.TextBox txtDataEscucha;
        private System.Windows.Forms.Button cmdSalirSERIAL;
        private System.Windows.Forms.ComboBox cmbBitSegundo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdAceptarSerial;
        private System.Windows.Forms.Button cmdNuevaConfigSerial;
        private System.Windows.Forms.ComboBox cmbParidad;
        private System.Windows.Forms.Button cmdDesconectarSerial;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStripMenuItem smnGraficar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusSerial;
        private System.Windows.Forms.DataGridView GridMatrizDatos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn INFORMACION;
        private System.Windows.Forms.ToolStripButton tlSerial;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton optText;
        private System.Windows.Forms.RadioButton optHex;
        private System.Windows.Forms.ToolStripMenuItem smnRealTime;
        private System.Windows.Forms.ToolStripMenuItem smnHistorico;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TabControl tabConfiguraciones;
        private System.Windows.Forms.TabPage tabInicio;
        private System.Windows.Forms.TabPage tabBD;
        private System.Windows.Forms.TabPage tabArchivoTexto;
        private System.Windows.Forms.TabPage tabEncabezados;
        private System.Windows.Forms.TabPage tabPreferencias;
        private System.Windows.Forms.Panel pnlConfigImportar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdSalirpnlConfImportar;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox chkImportaDAT;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chklSQLServer;
        private System.Windows.Forms.Button cmdExaminarDAT;
        private System.Windows.Forms.TextBox txtRutaDAT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdAsistImportacion;
        private System.Windows.Forms.Panel pnlAsistDAT;
        private System.Windows.Forms.Button cmdAsistSalir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox grpAsistPag1;
        private System.Windows.Forms.NumericUpDown numAPartirLinea;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView AsistGridDAT1;
        private System.Windows.Forms.Button cmdAsistFinalizar;
        private System.Windows.Forms.Button cmdAsistAtras;
        private System.Windows.Forms.Button cmdAsistSiguiente1;
        private System.Windows.Forms.GroupBox grpAsistPag3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView AsistGridDAT3;
        private System.Windows.Forms.GroupBox grpAsistPag2;
        private System.Windows.Forms.DataGridView AsistGridDAT2;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.RadioButton optComa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton optDobleComa;
        private System.Windows.Forms.Label optOtros;
        private System.Windows.Forms.RadioButton optEspacio;
        private System.Windows.Forms.ListBox listAsistEncabezados;
        private System.Windows.Forms.Button cmdAsistAplicar;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.Button cmdConectar;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtInstancia;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblBDActual;
        private System.Windows.Forms.Button cmdNuevaBD;
        private System.Windows.Forms.TextBox txtNuevaBD;
        private System.Windows.Forms.ComboBox cmbBD;
        private System.Windows.Forms.Button cmdSeleccionBD;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button cmdCreaConexion;
        private System.Windows.Forms.TextBox txtPerfil;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.CheckBox chkGuardaPreferencias;
        private System.Windows.Forms.Button cmdGuardaPreferencias;
        private System.Windows.Forms.Button cmdFinalizaConfiguracion;
        private System.Windows.Forms.Panel pnlMatrizDatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlExportaBD;
        private System.Windows.Forms.Button cmdSalirDAT;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Button cmdCancelarDAT;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button cmdNuevaDBMySQL;
        private System.Windows.Forms.Button cmdSeleccionDBMySQL;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtPuertoMySQL;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button cmdTestMySQL;
        private System.Windows.Forms.TextBox txtPassMySQL;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtUsuarioMySQL;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtInstanciaMySQL;
        private System.Windows.Forms.TextBox txtDBNuevaMySQL;
        private System.Windows.Forms.ComboBox cmbMySQL;
        private System.Windows.Forms.Button cmdExportarDAT;
        private System.Windows.Forms.Label lblOperador;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.Label lblPozo;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblPlataforma;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCompania;
        private System.Windows.Forms.ToolStripMenuItem smnmsImportarMedicion;
    }
}