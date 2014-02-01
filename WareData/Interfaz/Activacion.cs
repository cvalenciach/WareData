using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WareData.Interfaz
{
    public partial class Activacion : Form
    {
        public bool ToRestart = false;
        public string licencia, licencia_expira, licencia_forms, full;
        public string Directorio;
        public int bandera_reinicio = 0;


        public Activacion()
        {
            InitializeComponent();
        }

        private void Activacion_Load(object sender, EventArgs e)
        {
            ValidaArchivoInicialLicencia();
        }

        //FUNCIONES
        private void ValidaArchivoInicialLicencia()
        {
            Directorio = ""; string ruta_final = "";
            DateTime vence = new DateTime();
            DateTime hoy = new DateTime();
            DateTime demo = new DateTime();
            TimeSpan dif = new TimeSpan();
            hoy = DateTime.Today;
            demo = DateTime.Today.AddDays(31);
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
                    Directorio = "C:\\WindowsSys\\SQL MSSQLSv1.0.1\\config\\";
                }
                else
                {
                    Directorio = "C:\\WindowsSys\\SQL MSSQLSv1.0.1\\config\\";
                }
                if (File.Exists(Directorio + FILE_NAME))
                {//EXTRAIGO TODA LA CADENA GUARDADA EN EL ARCHIVO TEXT . KEY
                    texto_licencia = leetxt(Directorio + FILE_NAME);
                    Cadena_licencia = HexToString(texto_licencia);
                    fecha_Expira = ExtraeVence(Cadena_licencia);
                    vence = Convert.ToDateTime(fecha_Expira);
                    if (vence > hoy)
                    {
                        dif = vence - hoy;
                        if (dif.Days > 90)
                        {
                            lblDias_Restantes.Text = "Producto activado";
                        }
                        else
                        {
                            lblDias_Restantes.Text = Convert.ToString(dif.Days + 1);
                        }
                    }
                    else
                    {
                        lblDias_Restantes.Text = "Licencia vencida";
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
            for (int iOffset = 0; iOffset < str.Length; iOffset += 2)
            {
                ABN += Convert.ToChar(int.Parse(str.Substring(iOffset, 2), System.Globalization.NumberStyles.HexNumber));
            }
            return ABN.ToString();
        }
        private string leetxt(string ruta)
        {
            string texto = "";
            try
            {
                using (StreamReader sr = new StreamReader(@ruta, false))
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
        private void ActivaLicencia(string ruta)
        {
            DateTime fecha_Expira = new DateTime();
            DateTime hoy = new DateTime();
            hoy = DateTime.Today;
            TimeSpan dif = new TimeSpan();
            string cadena_hex = "", Cadena_licencia = "";
            try
            {
                cadena_hex = leetxt(ruta);
                Cadena_licencia = HexToString(cadena_hex);
                fecha_Expira = Convert.ToDateTime(ExtraeVence(Cadena_licencia));
                if (fecha_Expira > hoy)
                {//SI LA LICENCIA NUEVA TRAE FECHA DE VENCIMIENTO MAYOR A HOY, ENTONCES ACTUALIZAMOS NUESTRO ARCHIVO SECRETO
                    //StreamWriter writer = File.CreateText(@"C:\Windows\System32\licencia.key");
                    StreamWriter writer = File.CreateText(Directorio + "licencia.key");
                    string lic_to_hex = StringToHex("cliente:Integradores de Tecnologia;expira:" + fecha_Expira.ToString("dd/MM/yyyy") + ";");
                    writer.WriteLine(lic_to_hex);
                    writer.Close();
                    //YA NADAMAS PONEMOS CUANTOS DIAS QUEDAN DE LICENCIA CON LA NUEVA LICENCIA
                    dif = fecha_Expira - hoy;
                    if (dif.Days > 90)
                    {
                        lblDias_Restantes.Text = "Producto activado";
                    }
                    else
                    {
                        lblDias_Restantes.Text = Convert.ToString(dif.Days + 1);
                    }
                    this.lblDias_Restantes.Refresh();
                    txtRutaLicencia.Text = "";
                    MessageBox.Show("Producto activado con éxito");
                    //ValidaArchivoInicialLicencia();
                    MessageBox.Show("A continuacion se reiniciara la aplicación");
                    System.Windows.Forms.Application.Restart();
                }
                else
                {//SI YA ESTA VENCIDA LA LICENCIA NUEVA LA GUARDAMOS
                    StreamWriter writer2 = File.CreateText(Directorio + "licencia.key");
                    string lic_to_hex2 = StringToHex("cliente:Integradores de Tecnologia;expira:" + fecha_Expira.ToString("dd/MM/yyyy") + ";");
                    writer2.WriteLine(lic_to_hex2);
                    writer2.Close();

                    MessageBox.Show("Licencia vencida");
                    lblDias_Restantes.Text = "Licencia vencida";
                    //bandera_reinicio = 1;
                    //AQUI REINICIO LA APLICACION COMPELTA PARA QUE SURGAN EFECTO LOS CAMBIOS
                    MessageBox.Show("A continuacion se reiniciara la aplicación");
                    System.Windows.Forms.Application.Restart();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + " ActivaLicencia");
            }
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            txtRutaLicencia.Text = "";
            this.Close();
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            if (txtRutaLicencia.Text != "")
            {
                ActivaLicencia(txtRutaLicencia.Text);
            }
            else
            {
                MessageBox.Show("Seleccione la ruta del archivo de licencia");
            }
        }

        private void cmdExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "";
            if (DialogResult.OK == ofd.ShowDialog(this))
            {
                txtRutaLicencia.Text = ofd.FileName;
            }
        }


    }
}
