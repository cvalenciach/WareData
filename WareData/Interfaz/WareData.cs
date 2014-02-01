using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using WareData.LogicaNegocio;
using System.IO.Ports;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using System.Xml;

namespace WareData.Interfaz
{
    public partial class WareData : Form
    {
        //CONSTRUCTOR PARA LLAMAR A MIS METODOS EN LOGICANEGOCIO
        Metodos obj = new Metodos();
        //VARIABLES PUBLICAS
        public string RutaArchivoDAT;
        DataTable dtTablaDat = new DataTable();
        DataTable dtTablasMySQL = new DataTable();
        public string gestor, host, user, pass, puerto, bd;
        private string DispString;
        

        //VARIABLES ASISTENTE ARCHIVO .DAT
        public int pagina = 0, columna_seleccionada = 0, pnlAsistDATOK = 0, mLineaInicial = 0;
        //public char[] delimiterChars = { ',', ';', ' ' };
        public char[] delimiterChars = { ' ' };
        public static DataTable dt = new DataTable();
        DataTable dtAsistFinal = new DataTable(); 
        

        //VARIABLES DE LLAMADAS A OTROS FORMULARIOS
        ConfigDB configdb;
        Grafica grafica;
        Activacion activacion;

        public WareData()
        {
            InitializeComponent();
        }
        private void WareData_Load(object sender, EventArgs e)
        {
            configdb = new ConfigDB();
            grafica = new Grafica();
            activacion = new Activacion();
            ValidaArchivoInicialLicencia();
            //ABRO PUERTO SERIAL
            //serialPort1.Open();
            //CheckForIllegalCrossThreadCalls = false;
        }

        #region FUNCIONES DE PRESENTACION
        //FUNCIONES DE PRESENTACION
        private int ExtraeConfigXML()
        {
            int status = 0;
            try
            {
                DataSet ds2 = new DataSet();
                string ruta_xml2 = Environment.CurrentDirectory;// Application.StartupPath;
                ruta_xml2 = ruta_xml2 + "\\Config.xml";
                if (System.IO.File.Exists(ruta_xml2))
                {
                    string ruta_xml = Application.StartupPath;
                    ruta_xml = ruta_xml + "\\Config.xml";
                    //MessageBox.Show(ruta_xml);
                    DataSet ds = new DataSet();
                    ds.ReadXml(ruta_xml);
                    gestor = ds.Tables["Preferencias"].Rows[0]["GestorBD"].ToString();
                    host = ds.Tables["Preferencias"].Rows[0]["Host"].ToString();
                    user = ds.Tables["Preferencias"].Rows[0]["User"].ToString();
                    pass = ds.Tables["Preferencias"].Rows[0]["Pass"].ToString();
                    puerto = ds.Tables["Preferencias"].Rows[0]["Puerto"].ToString();
                    bd = ds.Tables["Preferencias"].Rows[0]["BD"].ToString();
                    status = 1;
                }
                else
                {
                    status = 2;
                }
            }
            catch (Exception ex)
            {

            }
            return status;
        }
        public void FormatoGridDAT()
        {
            if (GridFileDAT.ColumnCount > 0)
            {
                for (int i = 0; i <= GridFileDAT.Columns.Count - 1; i++)
                {
                    if (GridFileDAT.Columns[i].Name == "#")
                    { GridFileDAT.Columns[i].Width = 40; GridFileDAT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; GridFileDAT.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; }

                    if (GridFileDAT.Columns[i].Name == "FECHA")
                    { GridFileDAT.Columns[i].Width = 100; GridFileDAT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; GridFileDAT.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; }

                    if (GridFileDAT.Columns[i].Name == "HORA")
                    { GridFileDAT.Columns[i].Width = 70; GridFileDAT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; GridFileDAT.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; }

                    if (GridFileDAT.Columns[i].Name == "DELTA T")
                    { GridFileDAT.Columns[i].Width = 100; GridFileDAT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; GridFileDAT.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; }

                    if (GridFileDAT.Columns[i].Name == "FONDO PRESION 92540 PSIA")
                    { GridFileDAT.Columns[i].Width = 140; GridFileDAT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; GridFileDAT.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; }

                    if (GridFileDAT.Columns[i].Name == "FONDO TEMP 92540 °C")
                    { GridFileDAT.Columns[i].Width = 100; GridFileDAT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; GridFileDAT.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; }

                    if (GridFileDAT.Columns[i].Name == "SUP PRESION 92525 PSIA")
                    { GridFileDAT.Columns[i].Width = 100; GridFileDAT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; GridFileDAT.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; }

                    if (GridFileDAT.Columns[i].Name == "SUP TEMP 92525 °C")
                    { GridFileDAT.Columns[i].Width = 100; GridFileDAT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; GridFileDAT.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; }

                    if (GridFileDAT.Columns[i].Name == "PROFUNDIDAD MTS")
                    { GridFileDAT.Columns[i].Width = 100; GridFileDAT.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; GridFileDAT.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; }
                }
                this.Refresh();
            }
        }
        private void smnExportarBD_Click(object sender, EventArgs e)
        {
            /*int Estado = 0;
            if (dtTablaDat.DefaultView.Count > 0)
            {
                Estado = ExtraeConfigXML();
                if (Estado == 1 && (host != "" && host != null))
                {

                }
            }*/
            txtInstanciaMySQL.Text = txtInstancia.Text;
            txtUsuarioMySQL.Text = txtUsuario.Text;
            txtPassMySQL.Text = txtPass.Text;
            txtPuertoMySQL.Text = txtPuerto.Text;
            cmbMySQL.Text = cmbBD.Text;
            txtDBNuevaMySQL.Text = txtNuevaBD.Text;
            MenuPrin.Enabled = false;
            pnlExportaBD.Visible = true;
            pnlExportaBD.BringToFront();
        }        
        private void GetPortsCOM(string mPort, string mBitSegundo, string mParidad, string mBitParidad)
        {
            try
            {
                /*serialPort1.PortName = "COM5";
                serialPort1.BaudRate = 9600;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;//Parada*/
                serialPort1.PortName = mPort;
                serialPort1.BaudRate = Convert.ToInt32(mBitSegundo);
                if (mParidad == "Ninguno") { serialPort1.Parity = Parity.None; }
                if (mBitSegundo == "1") { serialPort1.StopBits = StopBits.One; }//Parada }
                serialPort1.Handshake = Handshake.None;

                //serialPort1.ReadTimeout = 500;
                //serialPort1.WriteTimeout = 500;

                if (serialPort1.IsOpen)
                    serialPort1.Close();

                serialPort1.Open(); //opens the port
                serialPort1.ReadTimeout = 200;
                if (serialPort1.IsOpen)
                {
                    DispString = "";
                    //txtReceptor.Text = "";
                }
                lblStatusSerial.Text = "Escuchando por: " + mPort + " a " + mBitSegundo + "/seg";
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            /*if (textBox1.Text.Length >= 12)
            {
                serialPort1.Close(); //call your own method to perform some operation
            }
            else
            {
                DispString = serialPort1.ReadExisting();
                this.Invoke(new EventHandler(DisplayText));
            }*/
            DispString = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(DisplayText));
        }
        private void DisplayText(object sender, EventArgs e)
        {
            txtDataEscucha.AppendText(DispString);
            GridMatrizDatos.Rows.Add(DispString);

            string strPathLog = @"C:\Reportes\LogCOM.txt";
            TextWriter tw = new StreamWriter(strPathLog, true);
            tw.WriteLine(DispString);
            tw.Close();
            //sr.WriteLine(DispString);
        }
        private void cmdNuevaConfigSerial_Click(object sender, EventArgs e)
        {
            cmbPuertoCOM.Enabled = true;
            cmbBitSegundo.Enabled = true;
            txtBitDatos.Enabled = true;
            cmbParidad.Enabled = true;
            txtBitsParidad.Enabled = true;
            cmdAceptarSerial.Enabled = true;
            cmdNuevaConfigSerial.Enabled = false;
            cmbPuertoCOM.Focus();
        }
        private void cmdAceptarSerial_Click(object sender, EventArgs e)
        {
            string Port, BitSegundo, Paridad, BitParidad;
            if (cmbPuertoCOM.Text != "")
            {
                if (cmbBitSegundo.Text != "")
                {
                    if (txtBitDatos.Text != "")
                    {
                        if (cmbParidad.Text != "")
                        {
                            if (txtBitsParidad.Text != "")
                            {
                                cmbPuertoCOM.Enabled = false;
                                cmbBitSegundo.Enabled = false;
                                txtBitDatos.Enabled = false;
                                cmbParidad.Enabled = false;
                                txtBitsParidad.Enabled = false;
                                cmdAceptarSerial.Enabled = false;
                                cmdDesconectarSerial.Enabled = true;
                                GetPortsCOM(cmbPuertoCOM.Text, cmbBitSegundo.Text, cmbParidad.Text, txtBitsParidad.Text);
                            }
                            else
                            {
                                MessageBox.Show("Ingrese los bits de Paridad");
                                txtBitsParidad.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Seleccione la Paridad");
                            cmbParidad.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese los Bits de Datos");
                        txtBitDatos.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione los bits por Segundo");
                    cmbBitSegundo.Focus();
                }
            }
            else
            {
                MessageBox.Show("Seleccione el Puerto Serial");
                cmbPuertoCOM.Focus();
            }
        }
        private void tlSerial_Click(object sender, EventArgs e)
        {
            pnlSERIAL.Visible = true;
            //cmbPuertoCOM.Text = "COM2";
            cmbBitSegundo.Text = "2400";
            cmbParidad.Text = "Ninguno";
            cmdAceptarSerial.Enabled = false;
            cmdDesconectarSerial.Enabled = false;
            //MessageBox.Show(String.Join(",", System.IO.Ports.SerialPort.GetPortNames()) + " are found on your machine.");
            string[] theSerialPortNames = System.IO.Ports.SerialPort.GetPortNames();
            cmbPuertoCOM.Items.Clear();
            for (int i = 0; i <= theSerialPortNames.Length - 1; i++)
            {
                cmbPuertoCOM.Items.Add(theSerialPortNames.GetValue(i));
            }
        }
        private string HEXtoASCII(string hexString)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= hexString.Length - 2; i += 2)
            {
                sb.Append(Convert.ToString(Convert.ToChar(Int32.Parse(hexString.Substring(i, 2), System.Globalization.NumberStyles.HexNumber))));
            }
            return sb.ToString();
        }
        public string HEXtoASCII_2(String hexString)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hexString.Length; i += 2)
            {
                String hs = hexString.Substring(i, i + 2);
                System.Convert.ToChar(System.Convert.ToUInt32(hexString.Substring(0, 2), 16)).ToString();
            }
            String ascii = sb.ToString();
            return ascii;
        }
        private void RellenoGridOriginal()
        {
            int contador = 1;
            //PREPARO EL NUEVO GRID MOSTRANDO SOLO DE LA LINEA SELECCIONADA ANTERIORMEMNTE
            AsistGridDAT2.Columns.Clear();
            //AsistGridDAT2.Rows.Clear();
            AsistGridDAT2.DataSource = null;
            StreamReader objReader = new StreamReader(txtRutaDAT.Text);
            string sLine = "";
            AsistGridDAT2.Columns.Add("Datos", "Datos");
            for (int i = 0; i <= AsistGridDAT2.Columns.Count - 1; i++)
            {
                if (AsistGridDAT2.Columns[i].Name == "Datos") { AsistGridDAT2.Columns[i].Width = 480; }
            }
            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null && sLine != "")
                {
                    if (contador >= mLineaInicial)
                    {
                        if (sLine != null)
                            AsistGridDAT2.Rows.Add(sLine);
                    }
                }
                contador++;
            }
            this.Refresh();
            /////////
        }
        private bool ImportaDATOK()
        {
            bool ok = false;
            if (dt.DefaultView.Count > 0)
            {
                if (AsistGridDAT3.Rows.Count > 0)
                {
                    ok = true;
                }
            }
            return ok;
        }
        private bool ConfBD()
        {
            bool ok = false;
            if (txtInstancia.Text != "")
            {
                if (txtUsuario.Text != "")
                {
                    if (txtPass.Text != "")
                    {
                        if (cmbBD.Text != "" || txtNuevaBD.Text != "")
                        {
                            ok = true;
                        }
                        else
                        {
                            MessageBox.Show("Seleccione o ingrese el nombre de la BD a usar");
                            cmdSeleccionBD.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el Password del Gestor de BD");
                        txtPass.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Usuario del Gestor de BD");
                    txtUsuario.Focus();
                }
            }
            else
            {
                MessageBox.Show("Seleccione la instancia o host de SQL a usar");
                txtInstancia.Focus();
            }
            return ok;
        }
        private bool Encabezados()
        {
            bool ok = false;
            if (lblCompania.Text != "COMPAÑIA")
            {
                ok = true;
            }
            return ok;
        }
        private int BuscaBDRepetida(string mNomBD)
        {
            int op = 1;
            try
            {
                //TRASPASO TODAS LAS BASES DEL PRIMER COMBO AL SEGUNDO COMBO  cmbMySQL
                cmbMySQL.Items.Clear();
                for (int i = 0; i <= cmbBD.Items.Count - 1; i++)
                {
                    cmbMySQL.Items.Add(cmbBD.Items[i].ToString());
                }
                for (int i = 0; i <= cmbMySQL.Items.Count - 1; i++)
                {
                    if (mNomBD.Trim() == cmbMySQL.Items[i].ToString())
                    {
                        op = 0;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return op;
        }
        private int BuscaTablasRepetida(string mTabla)
        {
            int op = 1;
            try
            {
                for (int i = 0; i <= dtTablasMySQL.Rows.Count - 1; i++)
                {
                    if (mTabla.Trim() == dtTablasMySQL.Rows[i].ItemArray[0].ToString().Trim())
                    {
                        op = 0;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return op;
        }
        private string ExtraeCampoPozo(string mCadena)
        {
            string Campo = "", op = "";
            mCadena = mCadena.ToLower();
            try
            {
                int num = mCadena.Length;
                for (int i = 0; i <= num; i++)
                {
                    op = mCadena.Substring(i, 1);
                    if (mCadena.Substring(i, 1) == ":")
                    {
                        Campo = mCadena.Substring(i + 2, num - (i + 2));                        
                        break;
                    }
                }
                Campo = Campo.Replace(" ","");
            }
            catch (Exception ex)
            {

            }
            return Campo;
        }
        private bool VerificaPozosRegistrados(string mPozo)
        {
            string mDevice = "";
            bool crear = false;
            DataSet ds = new DataSet();
            DataSet ds2 = new DataSet();
            try
            {                
                string ruta_xml2 = Application.StartupPath;
                
                //EXTRAIGO EL NUM DE XML EN RUTA
                string[] dirs = Directory.GetFiles(ruta_xml2 + "\\RegPozos\\","*.xml");
                int cantidad = dirs.Length;                

                ruta_xml2 = ruta_xml2 + "\\RegPozos\\" + mPozo.Trim() + ".xml";
                if (!System.IO.File.Exists(ruta_xml2))
                {
                    mDevice = "device_" + Convert.ToString(cantidad + 1);
                    using (XmlWriter writer = XmlWriter.Create(ruta_xml2))
                    {
                        writer.WriteStartElement("pozos");
                        writer.WriteElementString("pozo", mPozo.Trim());
                        writer.WriteElementString("device", mDevice.Trim());
                        writer.WriteEndElement();
                        writer.Flush();
                        crear = true;
                    }
                }
                else
                {
                    ds2.Clear();
                    ds2.ReadXml(ruta_xml2);
                    ////GUARDAMOS LOS NUEVOS DATOS AL XML
                    //string nueva_instancia = QuitaCaracteresDiagonal(cmbInstancias.Text);
                    ds2.Tables["pozos"].Rows[0]["pozo"] = mPozo.Trim();// instanciaAux;// nueva_instancia;
                    ds2.WriteXml(ruta_xml2);//GUARDAMOS EL XML NUEVO CON LOS DATOS NUEVOS INGRESADOS AL DATASET    
                    crear = false;
                }
            }
            catch (Exception ex)
            {

            }
            return crear;
        }
        private string ExtraeDevice(string mPozo)
        {
            string mDevice = "";
            try
            {
                DataSet ds = new DataSet();
                string ruta_xml = Application.StartupPath;

                //EXTRAIGO EL NUM DE XML EN RUTA
                string[] dirs = Directory.GetFiles(ruta_xml + "\\RegPozos\\", "*.xml");
                int cantidad = dirs.Length;


                ruta_xml = ruta_xml + "\\RegPozos\\" + mPozo + ".xml";
                if (System.IO.File.Exists(ruta_xml))
                {
                    ds.ReadXml(ruta_xml);
                    ////LEEMOS LOS DATOS ORIGINALES DEL XML
                    mDevice = ds.Tables["pozos"].Rows[0]["device"].ToString();
                }
                else
                {
                    mDevice = "device_" + Convert.ToString(cantidad + 1);
                }
            }
            catch (Exception ex)
            {

            }
            return mDevice;
        }
        private void DespuesDeExaminarArchivoDAT()
        {
            if (pagina == 3)
            {
                grpAsistPag3.BringToFront();
                cmdFinalizaConfiguracion.BringToFront();
                cmdAsistAtras.Visible = false;
            }
            else
            {
                pagina = 1;                
                StreamReader objReader = new StreamReader(txtRutaDAT.Text);
                StreamReader objReader2 = new StreamReader(txtRutaDAT.Text);
                string sLine = "", sLine2 = "";
                AsistGridDAT1.DataSource = null;
                AsistGridDAT1.Columns.Add("Datos", "Datos");
                for (int i = 0; i <= AsistGridDAT1.Columns.Count - 1; i++)
                {
                    if (AsistGridDAT1.Columns[i].Name == "Datos") { AsistGridDAT1.Columns[i].Width = 480; }
                }
                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    if (sLine != null)
                        AsistGridDAT1.Rows.Add(sLine);
                }
                int contador = 1;

                while (sLine2 != null)
                {
                    sLine2 = objReader2.ReadLine();
                    if (sLine2 != null && sLine2 != "")
                    {
                        if (contador == 1) { lblCompania.Text = sLine2; }
                        if (contador == 2) { lblCliente.Text = sLine2; }
                        if (contador == 3) { lblPlataforma.Text = sLine2; }
                        if (contador == 4) { lblCampo.Text = sLine2; }
                        if (contador == 5) { lblPozo.Text = sLine2; }
                        if (contador == 6) { lblOperador.Text = sLine2; }
                        if (contador == 7) { lblComentario.Text = sLine2; break; }
                        contador++;
                    }
                }
                pnlAsistDAT.Visible = true;
                pnlAsistDAT.BringToFront();
                cmdAsistSiguiente1.BringToFront();
                grpAsistPag1.BringToFront();
                cmdAsistAtras.Visible = false;
                this.Refresh();
            }
        }
        //LICENCIA
        private void ValidaArchivoInicialLicencia()
        {
            string Directorio = "";
            DateTime vence = new DateTime();
            DateTime hoy = new DateTime();
            DateTime demo = new DateTime();
            hoy = DateTime.Today;
            demo = DateTime.Today.AddDays(29);
            string texto_licencia = "", fecha_Expira = "", Cadena_licencia = "";
            try
            {
                string FILE_NAME = "licencia.key";
                //string Directorio = @"C:\Windows\System32\";                
                if (Directory.Exists("C:\\WindowsSys\\SQL MSSQLSv1.0.1\\config\\"))
                {
                    Directorio = "C:\\WindowsSys\\SQL MSSQLSv1.0.1\\config\\";
                }
                if (!Directory.Exists("C:\\WindowsSys\\SQL MSSQLSv1.0.1\\config\\"))
                {
                    Directory.CreateDirectory(@"C:\WindowsSys\SQL MSSQLSv1.0.1\config\");
                    Directorio = @"C:\WindowsSys\SQL MSSQLSv1.0.1\config\";// ruta_final + "\\SQLXMLv1.0.1\\";
                }
                else
                {
                    Directorio = "C:\\WindowsSys\\SQL MSSQLSv1.0.1\\config\\";
                }
                if (File.Exists(Directorio + FILE_NAME))
                {//EXTRAIGO TODA LA CADENA GUARDADA EN EL ARCHIVO TEXT . KEY
                    texto_licencia = leetxt();
                    Cadena_licencia = HexToString(texto_licencia);
                    fecha_Expira = ExtraeVence(Cadena_licencia);
                    vence = Convert.ToDateTime(fecha_Expira);
                    if (vence <= hoy)
                    {//SI YA VENCIO LA LICENCIA APAGO TODOS MIS MENUS Y SUBMENUS
                        //dif = vence - hoy;
                        smnRealTime.Enabled = false;
                        smnHistorico.Enabled = false;
                        smnmsImportarMedicion.Enabled = false;
                        smnImportarMedicion.Enabled = false;
                        smnExportarBD.Enabled = false;
                        smnGraficar.Enabled = false;
                        smnConfigSerial.Enabled = false;
                        smnUsuarios.Enabled = false;
                        tlSerial.Enabled = false;
                        tlExportarDB.Enabled = false;
                        tlImportarMedicion.Enabled = false;
                        MessageBox.Show("Licencia vencida");
                    }
                    else
                    {//SI AUN NO VENCE LA LICENCIA

                    }
                }
                else
                {
                    //File.CreateText(Directorio + FILE_NAME);
                    StreamWriter writer = File.CreateText(Directorio + FILE_NAME);
                    string lic_to_hex = StringToHex("cliente:IPM OIL SA DE CV;expira:" + demo.ToString("dd/MM/yyyy") + ";");
                    writer.WriteLine(lic_to_hex);
                    writer.Close();
                    ValidaArchivoInicialLicencia();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString() + " Crea Archivo inical licencia");
            }
        }
        private string StringToHex(string str)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(str);
                foreach (byte b in inputBytes)
                {
                    sb.Append(string.Format("{0:x2}", b));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + " StringToAscii");
            }
            return sb.ToString();
        }
        private string HexToString(string str)
        {
            string ABN = "";
            try
            {
                for (int iOffset = 0; iOffset < str.Length; iOffset += 2)
                {
                    ABN += Convert.ToChar(int.Parse(str.Substring(iOffset, 2), System.Globalization.NumberStyles.HexNumber));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + " HexToString");
            }
            return ABN.ToString();
        }
        private string leetxt()
        {
            string texto = "";
            try
            {
                using (StreamReader sr = new StreamReader("C:\\WindowsSys\\SQL MSSQLSv1.0.1\\config\\licencia.key", false))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        texto = line;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + " leetxt");
            }
            return texto;
        }
        private string ExtraeVence(string cadena)
        {
            int tamano;
            string regresa = "";
            try
            {
                tamano = cadena.Length;
                for (int i = 0; i < tamano; i++)
                {
                    if (cadena.Substring(i, 1) == ";")
                    {
                        regresa = cadena.Substring(i + 8, 10);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + " ExtraeVence");
            }
            return regresa;
        }
#endregion


        public void ConvertHex(String hexString)
        {
            string hex = "";
            foreach (char c in hexString)
            {
                int tmp = c;
                hex += String.Format("{0:X2}", (uint)System.Convert.ToUInt32(tmp.ToString()));
            }
            MessageBox.Show(hex);
        }
        public void ConvertHextoAscii(string HexString)
        {
            string asciiString = "";
            for (int i = 0; i < HexString.Length; i += 2)
            {
                if (HexString.Length >= i + 2)
                {
                    String hs = HexString.Substring(i, 2);
                    asciiString = asciiString + System.Convert.ToChar(System.Convert.ToUInt32(HexString.Substring(i, 2), 16)).ToString();
                }
            }
            MessageBox.Show(asciiString);
        }
        private void ascii(string mCadena)
        {
            //string str = "HOLA MUNDO"; // It should be converted to Müller,J.A.
            string inputString = mCadena;// textBox15.Text;
            Encoding encoder = ASCIIEncoding.GetEncoding("us-ascii", new EncoderReplacementFallback(string.Empty), new DecoderExceptionFallback());
            byte[] bAsciiString = encoder.GetBytes(inputString);
            string cleanString = Encoding.ASCII.GetString(bAsciiString);
            MessageBox.Show(cleanString);
        }
        private void toANSI(string mcadena)
        {
            const string fic = @"C:\Reportes2\ANSI.txt";

            System.IO.StreamWriter sw = new System.IO.StreamWriter(fic, false, System.Text.Encoding.Default);
            sw.WriteLine(mcadena);
            sw.Close();
        }
        private void tlExportarDB_Click(object sender, EventArgs e)
        {
            txtInstanciaMySQL.Text = txtInstancia.Text;
            txtUsuarioMySQL.Text = txtUsuario.Text;
            txtPassMySQL.Text = txtPass.Text;
            txtPuertoMySQL.Text = txtPuerto.Text;
            cmbMySQL.Text = cmbBD.Text;
            txtDBNuevaMySQL.Text = txtNuevaBD.Text;
            pnlExportaBD.Visible = true;
            pnlExportaBD.BringToFront();
        }
        private void pruebas(string mCadena)
        {
            string original = mCadena;
            string file = @"C:\users\fgomez\utf16test.txt";

            StreamWriter writer = new StreamWriter(file, false, Encoding.Unicode);
            writer.Write(original);
            writer.Close();

            StreamReader reader = new StreamReader(file, Encoding.UTF8, false);
            string text = reader.ReadToEnd();
            reader.Close();

            Console.WriteLine(original);
            Console.WriteLine(text);
        }                
        private void mnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void smnImportarMedicion_Click(object sender, EventArgs e)
        {
            /*stRuta.Text = "Ruta:";
            GridFileDAT.DataSource = null;
            this.Refresh();
            DataTable dtTablaDat = new DataTable();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "";
            if (DialogResult.OK == ofd.ShowDialog(this))
            {
                RutaArchivoDAT = ofd.FileName;
                stRuta.Text = RutaArchivoDAT.Trim();
                dtTablaDat = obj.LoadDAT(dtTablaDat, RutaArchivoDAT);
            }
            GridFileDAT.DataSource = dtTablaDat;
            FormatoGridDAT();*/


            pnlConfigImportar.Visible = true;
            MenuPrin.Enabled = false;


        }
        private void tlImportarMedicion_Click(object sender, EventArgs e)
        {
            stRuta.Text = "Ruta:";
            GridFileDAT.DataSource = null;
            dtTablaDat.Clear();
            this.Refresh();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "";
            if (DialogResult.OK == ofd.ShowDialog(this))
            {
                RutaArchivoDAT = ofd.FileName;
                stRuta.Text = RutaArchivoDAT.Trim();
                dtTablaDat = obj.LoadDAT(dtTablaDat, RutaArchivoDAT);
            }
            GridFileDAT.DataSource = dtTablaDat;
            pnlMatrizDatos.Visible = true;
            FormatoGridDAT();


            /*txtInstancia.Enabled = true;
            txtUsuario.Enabled = true;
            txtPass.Enabled = true;
            txtPuerto.Enabled = true;
            cmdConectar.Enabled = true;
            cmdCreaConexion.Enabled = true;

            pnlConfigImportar.Visible = true;
            MenuPrin.Enabled = false;*/
        }
        private void smnConfiguracionBD_Click(object sender, EventArgs e)
        {
            configdb.ShowDialog();
        }
        private void tlGrafica_Click(object sender, EventArgs e)
        {

        }
        private void smnConfigSerial_Click(object sender, EventArgs e)
        {
            pnlSERIAL.Visible = true;
            pnlSERIAL.BringToFront();
            //cmbPuertoCOM.Text = "COM2";
            cmbBitSegundo.Text = "2400";
            cmbParidad.Text = "Ninguno";
            cmdAceptarSerial.Enabled = false;
            cmdDesconectarSerial.Enabled = false;
            //MessageBox.Show(String.Join(",", System.IO.Ports.SerialPort.GetPortNames()) + " are found on your machine.");
            string[] theSerialPortNames = System.IO.Ports.SerialPort.GetPortNames();
            cmbPuertoCOM.Items.Clear();
            for (int i = 0; i <= theSerialPortNames.Length - 1; i++)
            {
                cmbPuertoCOM.Items.Add(theSerialPortNames.GetValue(i));
            }
        }
        private void cmdSalirpnlSERIAL_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                cmbPuertoCOM.Enabled = false;
                cmbBitSegundo.Enabled = false;
                txtBitDatos.Enabled = false;
                cmbParidad.Enabled = false;
                txtBitsParidad.Enabled = false;
                lblStatusSerial.Text = "Puerto Serial Desconectado";
                cmdAceptarSerial.Enabled = false;
                cmdDesconectarSerial.Enabled = false;
                cmdNuevaConfigSerial.Enabled = true;                
            }            
            pnlSERIAL.Visible = false;
        }
        private void smnEscucharSerial_Click(object sender, EventArgs e)
        {
            pnlSERIAL.Visible = true;
            cmbPuertoCOM.Text = "COM2";
            cmbBitSegundo.Text = "2400";
            cmbParidad.Text = "Ninguno";
            cmdAceptarSerial.Enabled = false;
            cmdDesconectarSerial.Enabled = false;
        }
        private void cmdDesconectarSerial_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                cmbPuertoCOM.Enabled = false;
                cmbBitSegundo.Enabled = false;
                txtBitDatos.Enabled = false;
                cmbParidad.Enabled = false;
                txtBitsParidad.Enabled = false;
                lblStatusSerial.Text = "Puerto Serial Desconectado";
                cmdAceptarSerial.Enabled = false;
                cmdDesconectarSerial.Enabled = false;
                cmdNuevaConfigSerial.Enabled = true;
                txtDataEscucha.Text = "";
                GridMatrizDatos.Columns.Clear(); GridMatrizDatos.Rows.Clear();
                GridMatrizDatos.DataSource = null;
                GridMatrizDatos.Columns.Add("INFORMACION", "INFORMACION");
                this.Refresh();
            }
            else
            {
                cmbPuertoCOM.Enabled = false;
                cmbBitSegundo.Enabled = false;
                txtBitDatos.Enabled = false;
                cmbParidad.Enabled = false;
                txtBitsParidad.Enabled = false;
                lblStatusSerial.Text = "Puerto Serial Desconectado";
                cmdAceptarSerial.Enabled = false;
                cmdDesconectarSerial.Enabled = false;
                cmdNuevaConfigSerial.Enabled = true;
                txtDataEscucha.Text = "";
                GridMatrizDatos.Columns.Clear(); GridMatrizDatos.Rows.Clear();
                GridMatrizDatos.DataSource = null;
                GridMatrizDatos.Columns.Add("INFORMACION", "INFORMACION");
                this.Refresh();
            }
        }
        private void smnHistorico_Click(object sender, EventArgs e)
        {

        }
        private void chkImportaDAT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkImportaDAT.Checked == true)
            {
                DialogResult dialogResult1 = MessageBox.Show("¿Desea Configurar el Archivo?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult1 == DialogResult.Yes)
                {
                    this.tabConfiguraciones.SelectedTab = tabArchivoTexto;
                }
            }
            else
            {
                chkImportaDAT.Checked = false;
            }
        }
        private void cmdSalirpnlConfImportar_Click(object sender, EventArgs e)
        {
            pnlConfigImportar.Visible = false;
            MenuPrin.Enabled = true;
        }
        private void chklSQLServer_CheckedChanged(object sender, EventArgs e)
        {
            if (chklSQLServer.Checked == true)
            {
                DialogResult dialogResult1 = MessageBox.Show("¿Desea Configurar la BD?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult1 == DialogResult.Yes)
                {
                    txtInstancia.Enabled = true;
                    txtUsuario.Enabled = true;
                    txtPass.Enabled = true;
                    txtPuerto.Enabled = true;
                    cmdConectar.Enabled = true;
                    cmdCreaConexion.Enabled = true;
                    this.tabConfiguraciones.SelectedTab = tabBD;
                }
            }
            else
            {
                chklSQLServer.Checked = false;
            }
        }
        private void cmdExaminarDAT_Click(object sender, EventArgs e)
        {
            string ruta = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "";
            if (DialogResult.OK == ofd.ShowDialog(this))
            {
                ruta = ofd.FileName;
                txtRutaDAT.Text = ruta.Trim();
                grpAsistPag1.BringToFront();
                DespuesDeExaminarArchivoDAT();
            }
        }
        private void cmdAsistImportacion_Click(object sender, EventArgs e)
        {
            
        }
        private void numAPartirLinea_ValueChanged(object sender, EventArgs e)
        {
            StreamReader objReader = new StreamReader(txtRutaDAT.Text);
            string sLine = "", sLine2 = "";
            int LineaInicio = Convert.ToInt32(numAPartirLinea.Value);
            int contador = 1;
            /*while (sLine2 != null)
            {
                sLine2 = objReader.ReadLine();
                if (sLine2 != null && sLine2 != "")
                {
                    if (contador == 1) { lblCompañia.Text = sLine2; }
                    if (contador == 2) { lblCliente.Text = sLine2; }
                    if (contador == 3) { lblPlataforma.Text = sLine2; }
                    if (contador == 4) { lblCampo.Text = sLine2; }
                    if (contador == 5) { lblPozo.Text = sLine2; }
                    if (contador == 6) { lblOperador.Text = sLine2; }
                    if (contador == 7) { lblComentario.Text = sLine2; break; }
                    contador++;
                }
            }*/
            contador = 1;
            if (LineaInicio > 0)
            {
                AsistGridDAT1.Columns.Clear();
                AsistGridDAT1.Rows.Clear();
                AsistGridDAT1.DataSource = null;                
                sLine = "";
                AsistGridDAT1.Columns.Add("Datos", "Datos");
                for (int i = 0; i <= AsistGridDAT1.Columns.Count - 1; i++)
                {
                    if (AsistGridDAT1.Columns[i].Name == "Datos") { AsistGridDAT1.Columns[i].Width = 480; }
                }                
                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    if (sLine != null && sLine != "")
                    {
                        if (contador >= LineaInicio)
                        {
                            if (sLine != null)
                                AsistGridDAT1.Rows.Add(sLine);                            
                        }                        
                    }
                    contador++;
                }                              
                this.Refresh();
            }
            else
            {
                MessageBox.Show("El valor debe ser mayor a cero");
                numAPartirLinea.Focus();
            }              
        }        
        private void cmdAsistSiguiente1_Click(object sender, EventArgs e)
        {
            int contador = 1;
            int LineaInicio = Convert.ToInt32(numAPartirLinea.Value);
            mLineaInicial = LineaInicio;
            if (pagina == 1)
            {
                pagina = 2;
                grpAsistPag1.Visible = false;
                grpAsistPag2.Visible = true;
                grpAsistPag2.BringToFront();
                cmdAsistAtras.Visible = true;
                //PREPARO EL NUEVO GRID MOSTRANDO SOLO DE LA LINEA SELECCIONADA ANTERIORMEMNTE
                AsistGridDAT2.Columns.Clear();
                AsistGridDAT2.Rows.Clear();
                AsistGridDAT2.DataSource = null;
                StreamReader objReader = new StreamReader(txtRutaDAT.Text);
                string sLine = "";
                AsistGridDAT2.Columns.Add("Datos", "Datos");
                for (int i = 0; i <= AsistGridDAT2.Columns.Count - 1; i++)
                {
                    if (AsistGridDAT2.Columns[i].Name == "Datos") { AsistGridDAT2.Columns[i].Width = 480; }
                }
                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    if (sLine != null && sLine != "")
                    {
                        if (contador >= LineaInicio)
                        {
                            if (sLine != null)
                                AsistGridDAT2.Rows.Add(sLine);
                        }
                    }
                    contador++;
                }
                this.Refresh();
                /////////
            }
            else
            {
                if (pagina == 2)
                {
                    pagina = 3;
                    grpAsistPag2.Visible = false;
                    grpAsistPag1.Visible = false;
                    grpAsistPag3.BringToFront();
                    grpAsistPag3.Visible = true;

                    //AsistGridDAT3.Columns.Clear();
                    //AsistGridDAT3.Rows.Clear();
                    //AsistGridDAT3.DataSource = null;

                    //AsistGridDAT3.DataSource = dt;
                    
                    cmdAsistFinalizar.BringToFront();                    

                    this.Refresh();
                }
            }
        }

        private void optComa_CheckedChanged(object sender, EventArgs e)
        {
            RellenoGridOriginal();
            int contador_Col = 0;
            //DataTable dt = new DataTable();
            //DataColumn column;
            //column = new DataColumn(); column.DataType = System.Type.GetType("System.String"); column.ColumnName = "DATOS"; column.ReadOnly = true; dt.Columns.Add(column);
            try
            {
                string cadena = "";
                if (optComa.Checked == true)
                {
                    int filas = AsistGridDAT2.Rows.Count;
                    int filasTabla = dt.DefaultView.Count;
                    int columnas = 0;
                    //AQUI HAGO LA CONVERSION DE TODAS LAS LINEAS AL FORMATO DE
                    //SEPARACION DE COLUMNAS POR COMAS SIMPLES
                    cadena = AsistGridDAT2.Rows[0].Cells[0].Value.ToString();
                    string[] words1 = cadena.Split(' ');
                    foreach (string s in words1)
                    {
                        if (s != "" && s != ",")
                        {
                            columnas++;
                        }
                    }
                    dt.Columns.Clear(); dt.Rows.Clear();
                    dt.Clear();
                    DataColumn column;
                    for (int j = 1; j <= columnas; j++)
                    {
                        column = new DataColumn(); column.ColumnName = j.ToString(); dt.Columns.Add(column);
                    }
                    for (int i = 0; i <= AsistGridDAT2.Rows.Count -5; i++)
                    {
                        ////ESTO SE HACE UNA VEZ POR RENGLON DEL GRID ORIGINAL
                        cadena = AsistGridDAT2.Rows[i].Cells[0].Value.ToString();
                        //cadena = cadena.Replace(' ', ',');
                        string[] words = cadena.Split(' ');
                        string[] reales = new string[columnas];
                        int colx = 0;
                        for (int y = 0; y <= words.Length - 1; y++)
                        {
                            if (words.GetValue(y).ToString() != "")
                            {
                                reales.SetValue(words.GetValue(y).ToString(), colx);
                                colx++;
                            }
                        }
                        for (int k = 0; k <= reales.Length -1; k++)
                        {
                            if (reales.Length == 1) { dt.Rows.Add(reales.GetValue(k).ToString()); }

                            if (reales.Length == 2) { dt.Rows.Add(reales.GetValue(k).ToString(),
                                                     reales.GetValue(k+1).ToString()); }

                            if (reales.Length == 3) { dt.Rows.Add(reales.GetValue(k).ToString(),
                                                     reales.GetValue(k+1).ToString(),
                                                     reales.GetValue(k+2).ToString()); }

                            if (reales.Length == 4) { dt.Rows.Add(reales.GetValue(k).ToString(),
                                                     reales.GetValue(k+1).ToString(),
                                                     reales.GetValue(k+2).ToString(),
                                                     reales.GetValue(k+3).ToString()); }

                            if (reales.Length == 5) { dt.Rows.Add(reales.GetValue(k).ToString(),
                                                     reales.GetValue(k+1).ToString(),
                                                     reales.GetValue(k+2).ToString(),
                                                     reales.GetValue(k+3).ToString(),
                                                     reales.GetValue(k+4).ToString()); }

                            if (reales.Length == 6) { dt.Rows.Add(reales.GetValue(k).ToString(),
                                                     reales.GetValue(k+1).ToString(),
                                                     reales.GetValue(k+2).ToString(),
                                                     reales.GetValue(k+3).ToString(),
                                                     reales.GetValue(k+4).ToString(),
                                                     reales.GetValue(k+5).ToString()); }

                            if (reales.Length == 7) { dt.Rows.Add(reales.GetValue(k).ToString(),
                                                     reales.GetValue(k+1).ToString(),
                                                     reales.GetValue(k+2).ToString(),
                                                     reales.GetValue(k+3).ToString(),
                                                     reales.GetValue(k+4).ToString(),
                                                     reales.GetValue(k+5).ToString(),
                                                     reales.GetValue(k+6).ToString()); }

                            if (reales.Length == 8) { dt.Rows.Add(reales.GetValue(k).ToString(),
                                                     reales.GetValue(k+1).ToString(),
                                                     reales.GetValue(k+2).ToString(),
                                                     reales.GetValue(k+3).ToString(),
                                                     reales.GetValue(k+4).ToString(),
                                                     reales.GetValue(k+5).ToString(),
                                                     reales.GetValue(k+6).ToString(),
                                                     reales.GetValue(k+7).ToString()); }

                            if (reales.Length == 9) { dt.Rows.Add(reales.GetValue(k).ToString(),
                                                     reales.GetValue(k+1).ToString(),
                                                     reales.GetValue(k+2).ToString(),
                                                     reales.GetValue(k+3).ToString(),
                                                     reales.GetValue(k+4).ToString(),
                                                     reales.GetValue(k+5).ToString(),
                                                     reales.GetValue(k+6).ToString(),
                                                     reales.GetValue(k+7).ToString(),
                                                     reales.GetValue(k+8).ToString()); }

                            if (reales.Length == 10) {dt.Rows.Add(reales.GetValue(k).ToString(),
                                                     reales.GetValue(k+1).ToString(),
                                                     reales.GetValue(k+2).ToString(),
                                                     reales.GetValue(k+3).ToString(),
                                                     reales.GetValue(k+4).ToString(),
                                                     reales.GetValue(k+5).ToString(),
                                                     reales.GetValue(k+6).ToString(),
                                                     reales.GetValue(k+7).ToString(),
                                                     reales.GetValue(k+8).ToString(),
                                                     reales.GetValue(k+9).ToString()); }
                            break;
                        }                        
                    }
                    AsistGridDAT2.Columns.Clear(); //AsistGridDAT2.Rows.Clear();
                    AsistGridDAT2.DataSource = null;
                    AsistGridDAT2.DataSource = dt;
                    AsistGridDAT3.Columns.Clear(); //AsistGridDAT3.Rows.Clear();
                    AsistGridDAT3.DataSource = null;
                    AsistGridDAT3.DataSource = dt;
                    this.Refresh();
                    ///////////////////////////////////////////////////////
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void optDobleComa_CheckedChanged(object sender, EventArgs e)
        {
            RellenoGridOriginal();
            int contador_Col = 0;
            //DataTable dt = new DataTable();
            //DataColumn column;
            //column = new DataColumn(); column.DataType = System.Type.GetType("System.String"); column.ColumnName = "DATOS"; column.ReadOnly = true; dt.Columns.Add(column);
            try
            {
                string cadena = "";
                if (optComa.Checked == true)
                {
                    int filas = AsistGridDAT2.Rows.Count;
                    int filasTabla = dt.DefaultView.Count;
                    int columnas = 0;
                    //AQUI HAGO LA CONVERSION DE TODAS LAS LINEAS AL FORMATO DE
                    //SEPARACION DE COLUMNAS POR COMAS SIMPLES
                    cadena = AsistGridDAT2.Rows[0].Cells[0].Value.ToString();
                    string[] words1 = cadena.Split(' ');
                    foreach (string s in words1)
                    {
                        if (s != "" && s != ",")
                        {
                            columnas++;
                        }
                    }
                    dt.Columns.Clear(); dt.Rows.Clear();
                    dt.Clear();
                    DataColumn column;
                    for (int j = 1; j <= columnas; j++)
                    {
                        column = new DataColumn(); column.ColumnName = j.ToString(); dt.Columns.Add(column);
                    }
                    for (int i = 0; i <= AsistGridDAT2.Rows.Count - 2; i++)
                    {
                        ////ESTO SE HACE UNA VEZ POR RENGLON DEL GRID ORIGINAL
                        cadena = AsistGridDAT2.Rows[i].Cells[0].Value.ToString();
                        //cadena = cadena.Replace(' ', ',');
                        string[] words = cadena.Split(' ');
                        string[] reales = new string[columnas];
                        int colx = 0;
                        for (int y = 0; y <= words.Length - 1; y++)
                        {
                            if (words.GetValue(y).ToString() != "")
                            {
                                reales.SetValue(words.GetValue(y).ToString(), colx);
                                colx++;
                            }
                        }
                        for (int k = 0; k <= reales.Length - 1; k++)
                        {
                            if (reales.Length == 1) { dt.Rows.Add(reales.GetValue(k).ToString()); }

                            if (reales.Length == 2)
                            {
                                dt.Rows.Add(reales.GetValue(k).ToString(),
                                    reales.GetValue(k + 1).ToString());
                            }

                            if (reales.Length == 3)
                            {
                                dt.Rows.Add(reales.GetValue(k).ToString(),
                                    reales.GetValue(k + 1).ToString(),
                                    reales.GetValue(k + 2).ToString());
                            }

                            if (reales.Length == 4)
                            {
                                dt.Rows.Add(reales.GetValue(k).ToString(),
                                    reales.GetValue(k + 1).ToString(),
                                    reales.GetValue(k + 2).ToString(),
                                    reales.GetValue(k + 3).ToString());
                            }

                            if (reales.Length == 5)
                            {
                                dt.Rows.Add(reales.GetValue(k).ToString(),
                                    reales.GetValue(k + 1).ToString(),
                                    reales.GetValue(k + 2).ToString(),
                                    reales.GetValue(k + 3).ToString(),
                                    reales.GetValue(k + 4).ToString());
                            }

                            if (reales.Length == 6)
                            {
                                dt.Rows.Add(reales.GetValue(k).ToString(),
                                    reales.GetValue(k + 1).ToString(),
                                    reales.GetValue(k + 2).ToString(),
                                    reales.GetValue(k + 3).ToString(),
                                    reales.GetValue(k + 4).ToString(),
                                    reales.GetValue(k + 5).ToString());
                            }

                            if (reales.Length == 7)
                            {
                                dt.Rows.Add(reales.GetValue(k).ToString(),
                                    reales.GetValue(k + 1).ToString(),
                                    reales.GetValue(k + 2).ToString(),
                                    reales.GetValue(k + 3).ToString(),
                                    reales.GetValue(k + 4).ToString(),
                                    reales.GetValue(k + 5).ToString(),
                                    reales.GetValue(k + 6).ToString());
                            }

                            if (reales.Length == 8)
                            {
                                dt.Rows.Add(reales.GetValue(k).ToString(),
                                    reales.GetValue(k + 1).ToString(),
                                    reales.GetValue(k + 2).ToString(),
                                    reales.GetValue(k + 3).ToString(),
                                    reales.GetValue(k + 4).ToString(),
                                    reales.GetValue(k + 5).ToString(),
                                    reales.GetValue(k + 6).ToString(),
                                    reales.GetValue(k + 7).ToString());
                            }

                            if (reales.Length == 9)
                            {
                                dt.Rows.Add(reales.GetValue(k).ToString(),
                                    reales.GetValue(k + 1).ToString(),
                                    reales.GetValue(k + 2).ToString(),
                                    reales.GetValue(k + 3).ToString(),
                                    reales.GetValue(k + 4).ToString(),
                                    reales.GetValue(k + 5).ToString(),
                                    reales.GetValue(k + 6).ToString(),
                                    reales.GetValue(k + 7).ToString(),
                                    reales.GetValue(k + 8).ToString());
                            }

                            if (reales.Length == 10)
                            {
                                dt.Rows.Add(reales.GetValue(k).ToString(),
                                    reales.GetValue(k + 1).ToString(),
                                    reales.GetValue(k + 2).ToString(),
                                    reales.GetValue(k + 3).ToString(),
                                    reales.GetValue(k + 4).ToString(),
                                    reales.GetValue(k + 5).ToString(),
                                    reales.GetValue(k + 6).ToString(),
                                    reales.GetValue(k + 7).ToString(),
                                    reales.GetValue(k + 8).ToString(),
                                    reales.GetValue(k + 9).ToString());
                            }
                            break;
                        }
                    }
                    AsistGridDAT2.Columns.Clear(); //AsistGridDAT2.Rows.Clear();
                    AsistGridDAT2.DataSource = null;
                    AsistGridDAT2.DataSource = dt;
                    AsistGridDAT3.Columns.Clear(); //AsistGridDAT3.Rows.Clear();
                    AsistGridDAT3.DataSource = null;
                    AsistGridDAT3.DataSource = dt;
                    this.Refresh();
                    ///////////////////////////////////////////////////////
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void optEspacio_CheckedChanged(object sender, EventArgs e)
        {
            RellenoGridOriginal();
            int contador_Col = 0;
            //DataTable dt = new DataTable();
            //DataColumn column;
            //column = new DataColumn(); column.DataType = System.Type.GetType("System.String"); column.ColumnName = "DATOS"; column.ReadOnly = true; dt.Columns.Add(column);
            try
            {
                string cadena = "";
                if (optComa.Checked == true)
                {
                    int filas = AsistGridDAT2.Rows.Count;
                    int filasTabla = dt.DefaultView.Count;
                    int columnas = 0;
                    //AQUI HAGO LA CONVERSION DE TODAS LAS LINEAS AL FORMATO DE
                    //SEPARACION DE COLUMNAS POR COMAS SIMPLES
                    cadena = AsistGridDAT2.Rows[0].Cells[0].Value.ToString();
                    string[] words1 = cadena.Split(' ');
                    foreach (string s in words1)
                    {
                        if (s != "" && s != ",")
                        {
                            columnas++;
                        }
                    }
                    dt.Columns.Clear(); dt.Rows.Clear();
                    dt.Clear();
                    DataColumn column;
                    for (int j = 1; j <= columnas; j++)
                    {
                        column = new DataColumn(); column.ColumnName = j.ToString(); dt.Columns.Add(column);
                    }
                    for (int i = 0; i <= AsistGridDAT2.Rows.Count - 2; i++)
                    {
                        ////ESTO SE HACE UNA VEZ POR RENGLON DEL GRID ORIGINAL
                        cadena = AsistGridDAT2.Rows[i].Cells[0].Value.ToString();
                        //cadena = cadena.Replace(' ', ',');
                        string[] words = cadena.Split(' ');
                        string[] reales = new string[columnas];
                        int colx = 0;
                        for (int y = 0; y <= words.Length - 1; y++)
                        {
                            if (words.GetValue(y).ToString() != "")
                            {
                                reales.SetValue(words.GetValue(y).ToString(), colx);
                                colx++;
                            }
                        }
                        for (int k = 0; k <= reales.Length - 1; k++)
                        {
                            if (reales.Length == 1) { dt.Rows.Add(reales.GetValue(k).ToString()); }

                            if (reales.Length == 2)
                            {
                                dt.Rows.Add(reales.GetValue(k).ToString(),
                                    reales.GetValue(k + 1).ToString());
                            }

                            if (reales.Length == 3)
                            {
                                dt.Rows.Add(reales.GetValue(k).ToString(),
                                    reales.GetValue(k + 1).ToString(),
                                    reales.GetValue(k + 2).ToString());
                            }

                            if (reales.Length == 4)
                            {
                                dt.Rows.Add(reales.GetValue(k).ToString(),
                                    reales.GetValue(k + 1).ToString(),
                                    reales.GetValue(k + 2).ToString(),
                                    reales.GetValue(k + 3).ToString());
                            }

                            if (reales.Length == 5)
                            {
                                dt.Rows.Add(reales.GetValue(k).ToString(),
                                    reales.GetValue(k + 1).ToString(),
                                    reales.GetValue(k + 2).ToString(),
                                    reales.GetValue(k + 3).ToString(),
                                    reales.GetValue(k + 4).ToString());
                            }

                            if (reales.Length == 6)
                            {
                                dt.Rows.Add(reales.GetValue(k).ToString(),
                                    reales.GetValue(k + 1).ToString(),
                                    reales.GetValue(k + 2).ToString(),
                                    reales.GetValue(k + 3).ToString(),
                                    reales.GetValue(k + 4).ToString(),
                                    reales.GetValue(k + 5).ToString());
                            }

                            if (reales.Length == 7)
                            {
                                dt.Rows.Add(reales.GetValue(k).ToString(),
                                    reales.GetValue(k + 1).ToString(),
                                    reales.GetValue(k + 2).ToString(),
                                    reales.GetValue(k + 3).ToString(),
                                    reales.GetValue(k + 4).ToString(),
                                    reales.GetValue(k + 5).ToString(),
                                    reales.GetValue(k + 6).ToString());
                            }

                            if (reales.Length == 8)
                            {
                                dt.Rows.Add(reales.GetValue(k).ToString(),
                                    reales.GetValue(k + 1).ToString(),
                                    reales.GetValue(k + 2).ToString(),
                                    reales.GetValue(k + 3).ToString(),
                                    reales.GetValue(k + 4).ToString(),
                                    reales.GetValue(k + 5).ToString(),
                                    reales.GetValue(k + 6).ToString(),
                                    reales.GetValue(k + 7).ToString());
                            }

                            if (reales.Length == 9)
                            {
                                dt.Rows.Add(reales.GetValue(k).ToString(),
                                    reales.GetValue(k + 1).ToString(),
                                    reales.GetValue(k + 2).ToString(),
                                    reales.GetValue(k + 3).ToString(),
                                    reales.GetValue(k + 4).ToString(),
                                    reales.GetValue(k + 5).ToString(),
                                    reales.GetValue(k + 6).ToString(),
                                    reales.GetValue(k + 7).ToString(),
                                    reales.GetValue(k + 8).ToString());
                            }

                            if (reales.Length == 10)
                            {
                                dt.Rows.Add(reales.GetValue(k).ToString(),
                                    reales.GetValue(k + 1).ToString(),
                                    reales.GetValue(k + 2).ToString(),
                                    reales.GetValue(k + 3).ToString(),
                                    reales.GetValue(k + 4).ToString(),
                                    reales.GetValue(k + 5).ToString(),
                                    reales.GetValue(k + 6).ToString(),
                                    reales.GetValue(k + 7).ToString(),
                                    reales.GetValue(k + 8).ToString(),
                                    reales.GetValue(k + 9).ToString());
                            }
                            break;
                        }
                    }
                    AsistGridDAT2.Columns.Clear(); //AsistGridDAT2.Rows.Clear();
                    AsistGridDAT2.DataSource = null;
                    AsistGridDAT2.DataSource = dt;
                    AsistGridDAT3.Columns.Clear(); //AsistGridDAT3.Rows.Clear();
                    AsistGridDAT3.DataSource = null;
                    AsistGridDAT3.DataSource = dt;
                    this.Refresh();
                    ///////////////////////////////////////////////////////
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            columna_seleccionada = AsistGridDAT3.CurrentCell.ColumnIndex;
            /*AsistGridDAT3.DefaultCellStyle.BackColor = Color.White;
            AsistGridDAT3.DefaultCellStyle.ForeColor = Color.Black;
            AsistGridDAT3.Columns[Col].DefaultCellStyle.BackColor = Color.Black;
            AsistGridDAT3.Columns[Col].DefaultCellStyle.ForeColor = Color.White;*/
        }
        private void cmdAsistAplicar_Click(object sender, EventArgs e)
        {
            if (columna_seleccionada >= 0 && (string)listAsistEncabezados.SelectedItem != "")
            {
                AsistGridDAT3.Columns[columna_seleccionada].HeaderText = (string)listAsistEncabezados.SelectedItem;
            }
        }
        private void cmdAsistFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (pagina == 3)
                {
                    /*dtAsistFinal.Columns.Clear(); dtAsistFinal.Rows.Clear();
                    dtAsistFinal.Clear();
                    DataColumn column;
                    for (int i = 0; i <= AsistGridDAT3.Columns.Count - 1; i++)
                    {
                        column = new DataColumn(); column.ColumnName = AsistGridDAT3.Columns[i].HeaderText; column.ReadOnly = true; dtAsistFinal.Columns.Add(column);
                    }*/
                    #region FOR PASAR GRID3 A DATATABLE FINAL
                    /*for (int j = 0; j <= AsistGridDAT3.Rows.Count - 3; j++)
                    {
                        if (AsistGridDAT3.Columns.Count == 1) { dtAsistFinal.Rows.Add(AsistGridDAT3.Rows[j].Cells[0].Value.ToString()); }

                        if (AsistGridDAT3.Columns.Count == 2)
                        {
                            dtAsistFinal.Rows.Add(AsistGridDAT3.Rows[j].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 1].Cells[0].Value.ToString());
                        }

                        if (AsistGridDAT3.Columns.Count == 3)
                        {
                            dtAsistFinal.Rows.Add(AsistGridDAT3.Rows[j].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 1].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 2].Cells[0].Value.ToString());
                        }

                        if (AsistGridDAT3.Columns.Count == 4)
                        {
                            dtAsistFinal.Rows.Add(AsistGridDAT3.Rows[j].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 1].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 2].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 3].Cells[0].Value.ToString());
                        }

                        if (AsistGridDAT3.Columns.Count == 5)
                        {
                            dtAsistFinal.Rows.Add(AsistGridDAT3.Rows[j].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 1].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 2].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 3].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 4].Cells[0].Value.ToString());
                        }

                        if (AsistGridDAT3.Columns.Count == 6)
                        {
                            dtAsistFinal.Rows.Add(AsistGridDAT3.Rows[j].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 1].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 2].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 3].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 4].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 5].Cells[0].Value.ToString());
                        }

                        if (AsistGridDAT3.Columns.Count == 7)
                        {
                            dtAsistFinal.Rows.Add(AsistGridDAT3.Rows[j].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 1].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 2].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 3].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 4].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 5].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 6].Cells[0].Value.ToString());
                        }

                        if (AsistGridDAT3.Columns.Count == 8)
                        {
                            dtAsistFinal.Rows.Add(AsistGridDAT3.Rows[j].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 1].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 2].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 3].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 4].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 5].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 6].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 7].Cells[0].Value.ToString());
                        }

                        if (AsistGridDAT3.Columns.Count == 9)
                        {
                            dtAsistFinal.Rows.Add(AsistGridDAT3.Rows[j].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 1].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 2].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 3].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 4].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 5].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 6].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 7].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 8].Cells[0].Value.ToString());
                        }

                        if (AsistGridDAT3.Columns.Count == 10)
                        {
                            dtAsistFinal.Rows.Add(AsistGridDAT3.Rows[j].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 1].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 2].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 3].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 4].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 5].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 6].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 7].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 8].Cells[0].Value.ToString(),
                                AsistGridDAT2.Rows[j + 9].Cells[0].Value.ToString());
                        }
                    }*/
#endregion
                    pnlAsistDAT.Visible = false;
                    smnExportarBD.Enabled = true;
                    smnGraficar.Enabled = true;
                    pnlAsistDATOK = 1;//BANDERA INDICA QUE EL ASISTENTE DE IMPORTAR MEDICION SALIO TODO BIEN
                    this.tabConfiguraciones.SelectedTab = tabInicio;
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void cmdConectar_Click(object sender, EventArgs e)
        {
            if (txtInstancia.Text != "")
            {
                if (txtUsuario.Text != "")
                {
                    if (txtPass.Text != "")
                    {
                        bool MiConexion = obj.PruebaConexionMySQL(txtInstancia.Text.Trim(), txtUsuario.Text.Trim(), txtPass.Text.Trim(), txtPuerto.Text.Trim());
                        if (MiConexion == true)
                        {
                            cmbBD.Items.Clear();
                            cmbBD = obj.LlenaComboBDMySQL(cmbBD, txtInstancia.Text.Trim(), txtUsuario.Text.Trim(), txtPass.Text.Trim(), txtPuerto.Text.Trim());
                            cmdSeleccionBD.Enabled = true; cmdNuevaBD.Enabled = true;
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el Password del Gestor de BD");
                        txtPass.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Usuario del Gestor de BD");
                    txtUsuario.Focus();
                }
            }
            else
            {
                MessageBox.Show("Seleccione la instancia o host de SQL a usar");
                txtInstancia.Focus();
            }
        }
        private void cmdSeleccionBD_Click(object sender, EventArgs e)
        {
            cmbBD.Enabled = true; cmbBD.Focus(); txtNuevaBD.Enabled = false; txtNuevaBD.Text = "";
        }
        private void cmdNuevaBD_Click(object sender, EventArgs e)
        {
            txtNuevaBD.Enabled = true; txtNuevaBD.Focus(); cmbBD.Enabled = false; cmbBD.Text = "";
        }
        private void cmdCreaConexion_Click(object sender, EventArgs e)
        {
            if (txtInstancia.Text != "")
            {
                if (txtUsuario.Text != "")
                {
                    if (txtPass.Text != "")
                    {
                        if (cmbBD.Text != "" || txtNuevaBD.Text != "")
                        {
                            txtInstancia.Enabled = false; txtUsuario.Enabled = false; txtPass.Enabled = false;
                            txtPuerto.Enabled = false; cmbBD.Enabled = false; txtNuevaBD.Enabled = false;
                            cmdConectar.Enabled = false; cmdSeleccionBD.Enabled = false; cmdNuevaBD.Enabled = false;
                            cmdCreaConexion.Enabled = false; 
                        }
                        else
                        {
                            MessageBox.Show("Seleccione o ingrese el nombre de la Base de Datos");
                            cmdSeleccionBD.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el Password del Gestor de BD");
                        txtPass.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Usuario del Gestor de BD");
                    txtUsuario.Focus();
                }
            }
            else
            {
                MessageBox.Show("Seleccione la instancia o host de SQL a usar");
                txtInstancia.Focus();
            }            
        }
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            txtInstancia.Enabled = true; txtUsuario.Enabled = true; txtPass.Enabled = true;
            txtPuerto.Enabled = true; cmbBD.Enabled = true; txtNuevaBD.Enabled = true;
            txtInstancia.Text = ""; txtUsuario.Text = ""; txtPass.Text = "";
            txtPuerto.Text = ""; cmbBD.Text = ""; txtNuevaBD.Text = "";

            cmdConectar.Enabled = true; cmdSeleccionBD.Enabled = false; cmdNuevaBD.Enabled = false;
            cmdCreaConexion.Enabled = true; 
        }
        private void cmdAsistAtras_Click(object sender, EventArgs e)
        {
            if (pagina == 2)
            {
                pagina = 1;
                grpAsistPag2.Visible = false;
                grpAsistPag1.Visible = true;
                cmdAsistAtras.Enabled = false;
                AsistGridDAT1.Columns.Clear(); AsistGridDAT1.Rows.Clear(); AsistGridDAT1.DataSource = null;
                StreamReader objReader = new StreamReader(txtRutaDAT.Text);
                string sLine = "";
                AsistGridDAT1.Columns.Add("Datos", "Datos");
                for (int i = 0; i <= AsistGridDAT1.Columns.Count - 1; i++)
                {
                    if (AsistGridDAT1.Columns[i].Name == "Datos") { AsistGridDAT1.Columns[i].Width = 480; }
                }
                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    if (sLine != null)
                        AsistGridDAT1.Rows.Add(sLine);
                }
            }
            else
            {
                if (pagina == 3)
                {
                    pagina = 2;
                    grpAsistPag3.Visible = false;
                    grpAsistPag2.Visible = true;
                    cmdAsistSiguiente1.BringToFront();
                }
            }
        }
        private void cmdFinalizaConfiguracion_Click(object sender, EventArgs e)
        {
            int bandera1 = 0, bandera2 = 0, bandera3 = 0;
            bool DAT = false, BD = false;
            if (chkImportaDAT.Checked == true)
            {
                DAT = ImportaDATOK();
                if (DAT == true)
                {
                    bandera1 = 1;
                }
                else
                {
                    bandera1 = 0;
                }
            }
            if (chklSQLServer.Checked == true)
            {
                BD = ConfBD();
                if (BD == true)
                {
                    bandera2 = 1;
                }
                else
                {
                    bandera2 = 0;
                }
            }            
            BD = Encabezados();
            if (BD == true)
            {
                bandera3 = 1;
            }
            else
            {
                bandera3 = 0;
            }            
            if (bandera1 == 1 && bandera2 == 1)
            {
                if (bandera3 == 1)
                {
                    //APAGO MI MODULO DE PREPARACION PARA CARGAR DATOS EN MEMORIA
                    //PARA TODO TIPO DE OPERACIONES, REPORTES, GRAFICAS, ETC..
                    //DOY AVISO Y DEJO TODO PREPARADO.
                    MessageBox.Show("Configuracion Terminada, Se activaron nuevas opciones de MENU");
                    this.tabConfiguraciones.SelectedTab = tabInicio;
                    pnlConfigImportar.Visible = false;
                    MenuPrin.Enabled = true;
                    smnExportarBD.Enabled = true;
                    tlExportarDB.Enabled = true;
                    smnGraficar.Enabled = true;
                    //PREPARO EL GRID DE LA MATRIZ PARA MOSTRARLA
                    stRuta.Text = "Ruta:";
                    GridFileDAT.DataSource = null;
                    dtTablaDat.Clear();
                    this.Refresh();
                    GridFileDAT.DataSource = dt;
                    pnlMatrizDatos.Visible = true;
                    FormatoGridDAT();
                }
                else
                {
                    MessageBox.Show("Aun no se ha importado correctamente el archivo .DAT, Verifique el Asistente");
                }
            }
            else
            {
                MessageBox.Show("Aun no se ha configurado la Conexion a BD ni datos de Importacion de archivo .DAT");
            }            
        }
        private void smnGraficar_Click(object sender, EventArgs e)
        {
            grafica.ShowDialog();
        }
        private void cmdAsistSalir_Click(object sender, EventArgs e)
        {
            pnlAsistDAT.Visible = false;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (txtInstanciaMySQL.Text != "")
            {
                if (txtUsuarioMySQL.Text != "")
                {
                    if (txtPassMySQL.Text != "")
                    {//MySQL
                        bool MiConexion = obj.PruebaConexionMySQL(txtInstanciaMySQL.Text.Trim(), txtUsuarioMySQL.Text.Trim(), txtPassMySQL.Text.Trim(), txtPuertoMySQL.Text.Trim());
                        if (MiConexion == true)
                        {
                            cmbMySQL.Items.Clear();
                            cmbMySQL = obj.LlenaComboBDMySQL(cmbMySQL, txtInstanciaMySQL.Text.Trim(), txtUsuarioMySQL.Text.Trim(), txtPassMySQL.Text.Trim(), txtPuertoMySQL.Text.Trim());
                            cmdSeleccionDBMySQL.Enabled = true; cmdNuevaDBMySQL.Enabled = true; cmdExportarDAT.Enabled = true;
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el Password");
                        txtPassMySQL.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Usuario");
                    txtUsuarioMySQL.Focus();
                }
            }
            else
            {
                MessageBox.Show("ingrese la instancia o IP de MySQL");
                txtInstanciaMySQL.Focus();
            }
        }
        private void cmdSeleccionDBMySQL_Click(object sender, EventArgs e)
        {
            cmbMySQL.Enabled = true; cmbMySQL.Focus(); txtDBNuevaMySQL.Enabled = false; txtDBNuevaMySQL.Text = "";
        }
        private void cmdNuevaDBMySQL_Click(object sender, EventArgs e)
        {
            cmbMySQL.Enabled = false; txtDBNuevaMySQL.Focus(); txtDBNuevaMySQL.Enabled = true; cmbMySQL.Text = "";
        }
        private void cmdSalirDAT_Click(object sender, EventArgs e)
        {
            pnlExportaBD.Visible = false;
        }

        private void cmdExportarDAT_Click(object sender, EventArgs e)
        {
            dtTablasMySQL.Columns.Clear(); dtTablasMySQL.Rows.Clear(); dtTablasMySQL.Clear();
            //DataColumn column;
            //column = new DataColumn(); column.DataType = System.Type.GetType("System.String"); column.ColumnName = "DATO"; column.ReadOnly = true; dtTablasMySQL.Columns.Add(column);

            string Campo = "", Pozo = "", BD = "", NumDevice = "";
            int BDRepetida = 0, BDMonitor = 0, Residuo = 0;
            bool PFOK = false, TFOK = false, PSOK = false, TSOK = false;
            bool BDOK = false, RegPozo = false, TablaMonitor = false;
            int PF, TF, PS, TS;
            if (txtInstanciaMySQL.Text != "")
            {
                if (txtUsuarioMySQL.Text != "")
                {
                    if (txtPassMySQL.Text != "")
                    {
                        if (cmbMySQL.Text != "")
                        {
                            BD = cmbMySQL.Text.Trim();
                            BDRepetida = BuscaBDRepetida(cmbMySQL.Text.Trim());
                            if (BDRepetida == 1)
                            {
                                BDOK = obj.CreaBDMySQL(txtInstanciaMySQL.Text.Trim(), txtUsuarioMySQL.Text.Trim(), txtPassMySQL.Text.Trim(), txtPuertoMySQL.Text.Trim(), cmbMySQL.Text.Trim());
                            }
                            else
                            {
                                BDOK = true;
                            }
                        }
                        else
                        {
                            if (txtDBNuevaMySQL.Text != "")
                            {
                                BD = txtDBNuevaMySQL.Text.Trim();
                                BDRepetida = BuscaBDRepetida(txtDBNuevaMySQL.Text.Trim());
                                if (BDRepetida == 1)
                                {
                                    BDOK = obj.CreaBDMySQL(txtInstanciaMySQL.Text.Trim(), txtUsuarioMySQL.Text.Trim(), txtPassMySQL.Text.Trim(), txtPuertoMySQL.Text.Trim(), txtDBNuevaMySQL.Text.Trim());
                                }
                                else
                                {
                                    BDOK = true;
                                }
                            }                            
                        }
                        if (BDOK == true)//SI LA BD EXISTA O
                        {
                            //MessageBox.Show("Base de Datos Creada Con Éxito");
                            //SI LA BD SE CREO CORRECTAMENTE, CREO AHORA LAS CUATRO TABLAS PARA LAS 4 VARIABLES POR POZO: PSI FDO, TEMP FDO, PSI SUP, TEMP SUP
                            //Campo = ExtraeCampoPozo(lblCampo.Text);
                            Pozo = ExtraeCampoPozo(lblPozo.Text);
                            //AQUI EXTRAIGO TODAS LAS TABLAS DE LA BASE DE DATOS SELECCIONADA
                            dtTablasMySQL = obj.ExtraeTablasMySQL(dtTablasMySQL, txtInstanciaMySQL.Text.Trim(), txtUsuarioMySQL.Text.Trim(), txtPassMySQL.Text.Trim(), txtPuertoMySQL.Text.Trim(), BD);
                            PF = 0; TF = 0; PS = 0; TS = 0;
                            int NumTablas = dtTablasMySQL.Rows.Count;//EXTRAIGO EL NUMERO DE TABLAS, ESTE SIEMPRE SERA MULTIPLO DE 4, PUES POR CADA POZO SE CREAN 4 TABLAS QUE CORRESPONDEN A SUS 4 VARIABLES
                            /*if (NumTablas == 0)
                            {
                                Residuo = (NumTablas) / 4;//EL % ES PARA RESIDUO, AQUI OBTENGO EL DIVIDENDO DE LA DIVISION, PUESTO SI DIVIDO N TABLAS ENTRE 4, ME DARA EXACTAMENTE CUANTOS POZOZ HAN SIDO REGISTRADOS
                            }
                            else
                            {
                                Residuo = (NumTablas - 1) / 4;//EL % ES PARA RESIDUO, AQUI OBTENGO EL DIVIDENDO DE LA DIVISION, PUESTO SI DIVIDO N TABLAS ENTRE 4, ME DARA EXACTAMENTE CUANTOS POZOZ HAN SIDO REGISTRADOS
                            }*/
                            NumDevice = ExtraeDevice(Pozo);
                            RegPozo = VerificaPozosRegistrados(Pozo);                            
                            //PF = BuscaTablasRepetida("Device_" + NumDevice + "_PF");//UNA VEZ OBTENIDO EL DIVIDENDO, VERIFICO SI EL NOM DE LAS TABLAS CON NUEVA NUMERACION DE DEVICE YA EXISTEN
                            //TF = BuscaTablasRepetida("Device_" + NumDevice + "_TF");
                            //PS = BuscaTablasRepetida("Device_" + NumDevice + "_PS");
                            //TS = BuscaTablasRepetida("Device_" + NumDevice + "_TS");
                            //if (PF == 1 && TF == 1 && PS == 1 && TS == 1)//SI NINGUNA TABLA DEL NUEVO POZO EXISTEN, ENTRAMOS A CREARLAS
                            if (RegPozo == true)
                            {//AQUI SIGNIFICA QUE LAS TABLA NO EXISTEN, ENTONCES ANTES DE ESCRIBIR, CREAMOS LAS TABLAS
                                //CREAMOS LAS 4 TABLAS
                                //NumDevice = Convert.ToString(Residuo + 1);

                                PFOK = obj.CreaTablaMySQL(txtInstanciaMySQL.Text.Trim(), txtUsuarioMySQL.Text.Trim(), txtPassMySQL.Text.Trim(), txtPuertoMySQL.Text.Trim(), NumDevice + "_pf", BD);
                                TFOK = obj.CreaTablaMySQL(txtInstanciaMySQL.Text.Trim(), txtUsuarioMySQL.Text.Trim(), txtPassMySQL.Text.Trim(), txtPuertoMySQL.Text.Trim(), NumDevice + "_tf", BD);
                                PSOK = obj.CreaTablaMySQL(txtInstanciaMySQL.Text.Trim(), txtUsuarioMySQL.Text.Trim(), txtPassMySQL.Text.Trim(), txtPuertoMySQL.Text.Trim(), NumDevice + "_ps", BD);
                                TSOK = obj.CreaTablaMySQL(txtInstanciaMySQL.Text.Trim(), txtUsuarioMySQL.Text.Trim(), txtPassMySQL.Text.Trim(), txtPuertoMySQL.Text.Trim(), NumDevice + "_ts", BD);
                                if (PFOK == true && TFOK == true && PSOK == true && TSOK == true)
                                {//AQUI ES SI LAS 4 TABLAS FUERON CREADAS CON EXITO, AHORA ESCRIBIMOS DEL .DAT LOS 4 VALORES, CADA UNO EN SU TABLA CORRESPONDIENTE
                                    //AQUI MANDAMOS A LLAMAR A UNA FUNCION, MANDANDOLE LA TABLA DONDE ESTA TODO EL ARCHIVO .DAT
                                    //PARA QUE ESTA FUNCION EXTRAIGA CADA DATO PARA CADA TABLA Y VAYA LLENANDO LAS 4 TABLAS
                                    obj.LlenaTablaPF(dt, txtInstanciaMySQL.Text.Trim(), txtUsuarioMySQL.Text.Trim(), txtPassMySQL.Text.Trim(), txtPuertoMySQL.Text.Trim(), BD, NumDevice + "_pf", Pozo, NumDevice);
                                    obj.LlenaTablaTF(dt, txtInstanciaMySQL.Text.Trim(), txtUsuarioMySQL.Text.Trim(), txtPassMySQL.Text.Trim(), txtPuertoMySQL.Text.Trim(), BD, NumDevice + "_tf", Pozo, NumDevice);
                                    obj.LlenaTablaPS(dt, txtInstanciaMySQL.Text.Trim(), txtUsuarioMySQL.Text.Trim(), txtPassMySQL.Text.Trim(), txtPuertoMySQL.Text.Trim(), BD, NumDevice + "_ps", Pozo, NumDevice);
                                    obj.LlenaTablaTS(dt, txtInstanciaMySQL.Text.Trim(), txtUsuarioMySQL.Text.Trim(), txtPassMySQL.Text.Trim(), txtPuertoMySQL.Text.Trim(), BD, NumDevice + "_ts", Pozo, NumDevice);
                                    //AQUI HAY QUE ENVIAR EL ULTIMO DATO DE CADA VARIABLE A LA TABLA MONITOR
                                    //BDMonitor = BuscaTablasRepetida("monitor");
                                    if (NumTablas == 0)
                                    {//NO EXISTE LA TABLA MONITOR
                                        TablaMonitor = obj.CreaTablaMonitorMySQL(txtInstanciaMySQL.Text.Trim(), txtUsuarioMySQL.Text.Trim(), txtPassMySQL.Text.Trim(), txtPuertoMySQL.Text.Trim(),"monitor", BD);
                                    }
                                    //YA SEGUROS DE EXISTIR LA TABLA MONITOR, AHORA SOLO INSERTAMOS EL ULTIMO REGISTRO DE CADA UNA DE LAS 4 VARIABLES
                                    //SI SE LLENA MONITOR AQUI, ENTONCES SON NUEVAS VARIABLES, QUIERE DECIR QUE SON INSERTS
                                    obj.LlenaTablaMonitor(dt, txtInstanciaMySQL.Text.Trim(), txtUsuarioMySQL.Text.Trim(), txtPassMySQL.Text.Trim(), txtPuertoMySQL.Text.Trim(), BD, "monitor", Pozo, NumDevice);
                                }
                            }
                            else
                            {//AQUI SIGNIFICA QUE LAS TABLAS DEL NUEVO DEVICE YA EXISTEN, SOLO ACTUALIZAMOS
                                //NumDevice = Convert.ToString(Residuo);

                                obj.LlenaTablaPF(dt, txtInstanciaMySQL.Text.Trim(), txtUsuarioMySQL.Text.Trim(), txtPassMySQL.Text.Trim(), txtPuertoMySQL.Text.Trim(), BD, NumDevice + "_pf", Pozo, NumDevice);
                                obj.LlenaTablaTF(dt, txtInstanciaMySQL.Text.Trim(), txtUsuarioMySQL.Text.Trim(), txtPassMySQL.Text.Trim(), txtPuertoMySQL.Text.Trim(), BD, NumDevice + "_tf", Pozo, NumDevice);
                                obj.LlenaTablaPS(dt, txtInstanciaMySQL.Text.Trim(), txtUsuarioMySQL.Text.Trim(), txtPassMySQL.Text.Trim(), txtPuertoMySQL.Text.Trim(), BD, NumDevice + "_ps", Pozo, NumDevice);
                                obj.LlenaTablaTS(dt, txtInstanciaMySQL.Text.Trim(), txtUsuarioMySQL.Text.Trim(), txtPassMySQL.Text.Trim(), txtPuertoMySQL.Text.Trim(), BD, NumDevice + "_ts", Pozo, NumDevice);
                                //AQUI LA TABLA MONITOR POR LOGICA YA EXISTE, SOLO INSERTAMOS EL ULTIMO REGISTRO DE CADA UNA DE LAS 4 VARIABLES
                                //SI SE LLENA MONITOR AQUI, ENTONCES SON VARIABLES DE ALGUN DISPOSITIVO EXISTENTE, ENTONCES SOLO SE ACTUALIZA UPDATE
                                obj.ActualizaTablaMonitor(dt, txtInstanciaMySQL.Text.Trim(), txtUsuarioMySQL.Text.Trim(), txtPassMySQL.Text.Trim(), txtPuertoMySQL.Text.Trim(), BD, "monitor", Pozo, NumDevice);
                            }
                            MessageBox.Show("Información Exportada con Éxito");
                            //ME SALGO DE TODOS LOS PANELES
                            pnlExportaBD.Visible = false;
                            GridFileDAT.DataSource = null;
                            pnlMatrizDatos.Visible = false;
                            //LIMPIO TODOS MIS GRIDS
                            AsistGridDAT1.DataSource = null;
                            AsistGridDAT2.DataSource = null;
                            AsistGridDAT3.DataSource = null;
                            dt.Columns.Clear(); dt.Rows.Clear(); dt.Clear();
                            chkImportaDAT.Checked = false; chklSQLServer.Checked = false;
                            txtRutaDAT.Text = "";
                            txtInstancia.Text = ""; txtUsuario.Text = ""; txtPass.Text = ""; txtPuerto.Text = "";
                            cmbBD.Text = ""; txtNuevaBD.Text = "";
                            lblCompania.Text = "COMPAÑIA:";
                            lblCliente.Text = "CLIENTE:";
                            lblPlataforma.Text = "PLATAFORMA:";
                            lblCampo.Text = "CAMPO:";
                            lblPozo.Text = "POZO:";
                            lblOperador.Text = "OPERADOR:";
                            lblComentario.Text = "COMENTARIO:";
                            chkGuardaPreferencias.Checked = false;
                            txtPerfil.Text = ""; txtPerfil.Enabled = false;
                            cmdGuardaPreferencias.Enabled = false;
                            smnExportarBD.Enabled = false;
                            tlExportarDB.Enabled = false;
                            pnlAsistDATOK = 0;
                            pagina = 0;
                            //ACTIVO MENU PRINCIPAL
                            MenuPrin.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Seleccione o Ingrese el nombre de la Base de Datos");
                            cmdSeleccionBD.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese el Password");
                        txtPassMySQL.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Usuario");
                    txtUsuarioMySQL.Focus();
                }
            }
            else
            {
                MessageBox.Show("ingrese la instancia o IP de MySQL");
                txtInstanciaMySQL.Focus();
            }
        }

        private void cmdGuardaPreferencias_Click(object sender, EventArgs e)
        {
            string BD = "";
            if (txtPerfil.Text != "")
            {
                if (cmbBD.Text != "") { BD = cmbBD.Text.Trim(); }
                if (txtNuevaBD.Text != "") { BD = txtNuevaBD.Text.Trim(); }
                obj.GeneraActualizaXMLPreferencias(txtPerfil.Text, txtInstancia.Text, txtUsuario.Text, txtPass.Text, txtPuerto.Text, BD);
                txtPerfil.Enabled = false;
                MessageBox.Show("Preferencia Guardada Con Éxito");
            }
            else
            {
                MessageBox.Show("Ingrese un Nombre de Perfil para la Preferencia");
                txtPerfil.Focus();
            }
        }

        private void chkGuardaPreferencias_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGuardaPreferencias.Checked == true)
            {
                txtPerfil.Enabled = true; cmdGuardaPreferencias.Enabled = true;
                txtPerfil.Focus();
            }
            if (chkGuardaPreferencias.Checked == false)
            {
                txtPerfil.Enabled = false; cmdGuardaPreferencias.Enabled = false;
                txtPerfil.Text = ""; chkGuardaPreferencias.Focus();
            }
        }

        private void activacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activacion.ShowDialog();
        }

        private void smnmsImportarMedicion_Click(object sender, EventArgs e)
        {
            txtInstancia.Enabled = true;
            txtUsuario.Enabled = true;
            txtPass.Enabled = true;
            txtPuerto.Enabled = true;
            cmdConectar.Enabled = true;
            cmdCreaConexion.Enabled = true;
            pnlConfigImportar.Visible = true;
            MenuPrin.Enabled = false;
        }
    }
}