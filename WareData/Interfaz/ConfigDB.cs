using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WareData.LogicaNegocio;
using System.Xml;

namespace WareData.Interfaz
{
    public partial class ConfigDB : Form
    {
        //CONSTRUCTOR PARA LLAMAR A MIS METODOS EN LOGICANEGOCIO
        Metodos obj = new Metodos();

        //VARIABLES PUBLICAS
        public string gestor, host, user, pass, puerto, bd;

        //MAIN
        public ConfigDB()
        {
            InitializeComponent();
        }
        private void ConfigDB_Load(object sender, EventArgs e)
        {
            int Estado = 0;
            LimpiaFormulario();
            Estado = ExtraeConfigXML();
            if (Estado == 1)
            {
                //PrepararObjetos();
            }
        } 

        private void cmdSeleccionBD_Click(object sender, EventArgs e)
        {
            cmbBD.Items.Clear();
            cmbBD = obj.ListaBDPostgres(cmbBD, txtInstancia.Text.Trim(), txtUsuario.Text.Trim(), txtPass.Text.Trim());
            cmbBD.Enabled = true; txtNuevaBD.Enabled = false;
        }
        private void cmdConectar_Click(object sender, EventArgs e)
        {            
            if (txtInstancia.Text != "")
            {
                if (txtUsuario.Text != "")
                {
                    if (txtPass.Text != "")
                    {
                        bool conexion = obj.PruebaConexionPostgres(txtInstancia.Text.Trim(), txtUsuario.Text.Trim(), txtPass.Text.Trim());
                        if (conexion == true)
                        {
                            MessageBox.Show("Conexion Exitosa");
                            cmdSeleccionBD.Enabled = true; cmdNuevaBD.Enabled = true; cmdCreaConexion.Enabled = true; cmdModificar.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo establecer la conexion, Verifique su configuracion");
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
                MessageBox.Show("Ingrese el Host del Gestor de BD");
                txtInstancia.Focus();
            }                      
        }
        private void cmdNuevaBD_Click(object sender, EventArgs e)
        {
            cmbBD.Enabled = false; txtNuevaBD.Enabled = true;
        }
        private void cmdCreaConexion_Click(object sender, EventArgs e)
        {
            string xBD = "";
            bool ok = false;
            if (txtInstancia.Text != "")
            {
                if (txtUsuario.Text != "")
                {
                    if (txtPass.Text != "")
                    {
                        if (cmbBD.Text != "" || txtNuevaBD.Text != "")
                        {
                            if (cmbBD.Text != "" && (txtNuevaBD.Text == "" || txtNuevaBD.Text == null))
                            {
                                xBD = cmbBD.Text.Trim();
                            }
                            else
                            {
                                xBD = txtNuevaBD.Text.Trim();
                            }
                            ok = obj.ConfiguraConexionBD(ok, txtInstancia.Text.Trim(), txtUsuario.Text.Trim(), txtPass.Text.Trim(), txtPuerto.Text.Trim(), xBD);
                            if (ok == true)
                            {
                                LimpiaFormulario();
                                ExtraeConfigXML();
                            }                            
                        }
                        else
                        {
                            MessageBox.Show("Seleccione o ingrese una nueva BD");
                            cmbBD.Focus();
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
                MessageBox.Show("Ingrese el Host del Gestor de BD");
                txtInstancia.Focus();
            }              
        }
        private void cmdModificar_Click(object sender, EventArgs e)
        {
            txtInstancia.Enabled = true; txtUsuario.Enabled = true;
            txtPass.Enabled = true; txtPuerto.Enabled = true;
            cmdConectar.Enabled = true; cmdCreaConexion.Enabled = false; cmdModificar.Enabled = false;
            txtInstancia.Focus();
        }
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            LimpiaFormulario();
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            LimpiaFormulario();
            this.Close();
        }

        //FUNCIONES DE FORMATO DE INTERFAZ
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
                    LimpiaFormulario(); 
                    txtInstancia.Enabled = true;
                    txtUsuario.Enabled = true;
                    txtPass.Enabled = true;
                    txtPuerto.Enabled = true;
                    cmdConectar.Enabled = true;
                    cmdModificar.Enabled = false;
                    cmdCreaConexion.Enabled = true;
                    txtInstancia.Focus();
                }
            }
            catch (Exception ex)
            {

            }
            return status;
        }
        private void PrepararObjetos()
        {
            if (host != "" || host != null)
            {
                cmdModificar.Enabled = true; cmdCreaConexion.Enabled = false;
            }
            else
            {
                cmdModificar.Enabled = false; cmdCreaConexion.Enabled = true;
            }
            txtInstancia.Text = host; txtInstancia.Enabled = false;
            txtUsuario.Text = user; txtUsuario.Enabled = false;
            txtPass.Text = pass; txtPass.Enabled = false;
            txtPuerto.Text = puerto; txtPuerto.Enabled = false;
            cmdConectar.Enabled = false; cmdCreaConexion.Enabled = false;
            if (bd != "" && bd != null)
            {
                lblBDActual.Text = bd;
            }
            else
            {
                lblBDActual.Text = "Sin Seleccion";
            }
        }        
        private void LimpiaFormulario()
        {
            txtInstancia.Enabled = false; txtInstancia.Text = "";
            txtUsuario.Enabled = false; txtUsuario.Text = "";
            txtPass.Enabled = false; txtPass.Text = "";
            txtPuerto.Enabled = false; txtPuerto.Text = "";
            cmbBD.Text = ""; cmbBD.Enabled = false;
            txtNuevaBD.Text = ""; txtNuevaBD.Enabled = false;
            cmdConectar.Enabled = false;
            cmdSeleccionBD.Enabled = false;
            cmdNuevaBD.Enabled = false;
            cmdCreaConexion.Enabled = false;
            cmdModificar.Enabled = false;
        }        
    }
}