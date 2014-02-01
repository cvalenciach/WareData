using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WareData.AccesoDatos;
using System.Data;
using System.Windows.Forms;
using System.IO;
using Npgsql;
using System.Xml;
using Moletrator.SQLDocumentor;
using MySql.Data.MySqlClient;

namespace WareData.LogicaNegocio
{
    class Metodos
    {
        ConexionPostgres Postgres = new ConexionPostgres();
        ConexionMySQL MySQL = new ConexionMySQL();
        //METODOS CAPA LOGICA NEGOCIO
        public DataTable LoadDAT(DataTable dtDAT, string RutaDAT)
        {
            try
            {
                dtDAT.Columns.Clear();
                dtDAT.Clear();
                DataColumn column;
                column = new DataColumn(); column.DataType = System.Type.GetType("System.String"); column.ColumnName = "#"; column.ReadOnly = true; dtDAT.Columns.Add(column);
                column = new DataColumn(); column.DataType = System.Type.GetType("System.String"); column.ColumnName = "FECHA"; column.ReadOnly = true; dtDAT.Columns.Add(column);
                column = new DataColumn(); column.DataType = System.Type.GetType("System.String"); column.ColumnName = "HORA"; column.ReadOnly = true; dtDAT.Columns.Add(column);
                column = new DataColumn(); column.DataType = System.Type.GetType("System.String"); column.ColumnName = "DELTA T"; column.ReadOnly = true; dtDAT.Columns.Add(column);
                column = new DataColumn(); column.DataType = System.Type.GetType("System.String"); column.ColumnName = "FONDO PRESION 92540 PSIA"; column.ReadOnly = true; dtDAT.Columns.Add(column);
                column = new DataColumn(); column.DataType = System.Type.GetType("System.String"); column.ColumnName = "FONDO TEMP 92540 °C"; column.ReadOnly = true; dtDAT.Columns.Add(column);
                column = new DataColumn(); column.DataType = System.Type.GetType("System.String"); column.ColumnName = "SUP PRESION 92525 PSIA"; column.ReadOnly = true; dtDAT.Columns.Add(column);
                column = new DataColumn(); column.DataType = System.Type.GetType("System.String"); column.ColumnName = "SUP TEMP 92525 °C"; column.ReadOnly = true; dtDAT.Columns.Add(column);
                column = new DataColumn(); column.DataType = System.Type.GetType("System.String"); column.ColumnName = "PROFUNDIDAD MTS"; column.ReadOnly = true; dtDAT.Columns.Add(column);
                StreamReader objInput = new StreamReader(RutaDAT, System.Text.Encoding.Default);
                string contents = objInput.ReadToEnd().Trim();
                string[] split = System.Text.RegularExpressions.Regex.Split(contents, "\\s+", System.Text.RegularExpressions.RegexOptions.None);
                int col = 1, i = 0; string op = "";
                while (i < split.Length)
                {
                    op = split.GetValue(i).ToString();
                    if (i >= 58)
                    {
                        dtDAT.Rows.Add(col,//#
                                split.GetValue(i).ToString(),//FECHA
                                split.GetValue(i + 1).ToString(),//HORA
                                split.GetValue(i + 2).ToString(),//DELTA T
                                split.GetValue(i + 3).ToString(),//FONDO PRESION 92540 PSIA
                                split.GetValue(i + 4).ToString(),//FONDO TEMP 92540 °C
                                split.GetValue(i + 5).ToString(),//SUP PRESION 92525 PSIA
                                split.GetValue(i + 6).ToString(),//SUP TEMP 92525 °C
                                split.GetValue(i + 7).ToString());//PROFUNDIDAD MTS
                        i = i + 8; col++;
                    }
                    else
                    {
                        i++;
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("hubo un Problem al cargar el archivo .DAT");
                MessageBox.Show(ex.Message);
            }
            return dtDAT;
        }
        public ComboBox ListaBDPostgres(ComboBox cbListaDB, string mHost, string mUser, string mPass)
        {
            DataTable dtTabla = new DataTable();
            try
            {
                Postgres.ConexionPostgres_SinBD(mHost, mUser, mPass, "");
                Postgres.Abrir();
                /*NpgsqlDataReader ListaDBPostgres = null;
                ListaDBPostgres = Postgres.ExtraeBDPostgres(ListaDBPostgres);
                while (ListaDBPostgres.Read())
                {
                    cbListaDB.Items.Add(ListaDBPostgres.GetString(0));
                }*/
                dtTabla = Postgres.EjecutaDataTable("SELECT datname FROM pg_database WHERE datistemplate = false;");
                Postgres.Cerrar();
                for (int i= 0; i <= dtTabla.DefaultView.Count - 1; i++)
                {
                    cbListaDB.Items.Add(dtTabla.Rows[i].ItemArray[0].ToString().Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un Problem al cargar la Lista de BD");
                MessageBox.Show(ex.Message);
            }
            return cbListaDB;
        }
        public bool PruebaConexionPostgres(string mHost, string mUser, string mPass)
        {
            bool conecta;
            try
            {
                Postgres.ConexionPostgres_SinBD(mHost, mUser, mPass, "");
                Postgres.Abrir();
                conecta = true;
                Postgres.Cerrar();
            }
            catch (Exception ex)
            {
                conecta = false;
            }
            return conecta;
        }
        public bool PruebaConexionMySQL(string instancia, string user, string pass, string puerto)
        {
            bool conexion;
            try
            {
                MySQL.ConexionMySQL_SinBD(instancia, user, pass, puerto);
                MySQL.Abrir();
                MessageBox.Show("Conexion Exitosa");
                MySQL.Cerrar();
                conexion = true;
            }
            catch (Exception ex3)
            {
                MessageBox.Show("Error al Conectarse al servidor de MySQL");
                MessageBox.Show(ex3.Message.ToString());
                conexion = false;
            }
            return conexion;
        }
        public ComboBox LlenaComboBDMySQL(ComboBox mCombo, string instancia, string user, string pass, string puerto)
        {
            MySQL.ConexionMySQL_SinBD(instancia, user, pass, puerto);
            MySQL.Abrir();
            MySqlDataReader registrosObtenidosMySQL = null;
            registrosObtenidosMySQL = MySQL.ExtraeBDMySQL(registrosObtenidosMySQL);
            while (registrosObtenidosMySQL.Read())
            {
                mCombo.Items.Add(registrosObtenidosMySQL.GetString(0));
            }
            MySQL.Cerrar();
            return mCombo;
        }
        public DataTable ExtraeTablasMySQL(DataTable dt, string instancia, string user, string pass, string puerto, string mmBD)
        {
            dt.Clear();
            DataColumn column;
            column = new DataColumn(); column.DataType = System.Type.GetType("System.String"); column.ColumnName = "DATO"; column.ReadOnly = true; dt.Columns.Add(column);

            //MySQL.ConexionMySQL_SinBD(instancia, user, pass, puerto);
            MySQL.ConexionMySQL_BD(instancia, user, pass, mmBD, puerto);
            MySQL.Abrir();
            MySqlDataReader registrosObtenidosMySQL = null;
            registrosObtenidosMySQL = MySQL.ExtraeTablasMySQL(registrosObtenidosMySQL, mmBD);
            while (registrosObtenidosMySQL.Read())
            {
                dt.Rows.Add(registrosObtenidosMySQL.GetString(0));
            }
            MySQL.Cerrar();
            return dt;
        }
        public bool CreaTablaMonitorMySQL(string instancia, string user, string pass, string puerto, string mNomTabla, string mBD)
        {
            bool ok = false;
            try
            {
                MySQL.ConexionMySQL_SinBD(instancia, user, pass, puerto);
                MySQL.Abrir();
                MySQL.Ejecutar_query("USE " + mBD + ";");
                MySQL.Ejecutar_query("CREATE TABLE `monitor` ("
                                      + "`TableIndex` int(11) NOT NULL AUTO_INCREMENT,"
                                      + "`TagTimestamp` datetime NOT NULL,"
                                      + "`TagItemID` mediumtext NOT NULL,"
                                      + "`TagValue` decimal(7,2) NOT NULL,"
                                      + "`TagQuality` int(50) NOT NULL,"
                                      + "PRIMARY KEY (`TableIndex`)"
                                      + ") ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;");
                MySQL.Cerrar();
                ok = true;
            }
            catch (Exception ex)
            {
                ok = false;
            }
            return ok;
        }
        public bool CreaBDMySQL(string instancia, string user, string pass, string puerto, string mNomBD)
        {
            bool ok = false;
            try
            {
                MySQL.ConexionMySQL_SinBD(instancia, user, pass, puerto);
                MySQL.Abrir();
                MySQL.Ejecutar_query("CREATE DATABASE " + mNomBD + ";");
                MySQL.Cerrar();
                ok = true;
            }
            catch (Exception ex)
            {
                ok = false;
            }
            return ok;
        }
        public bool CreaTablaMySQL(string instancia, string user, string pass, string puerto, string mNomTabla, string mBD)
        {
            bool ok = false;
            try
            {
                MySQL.ConexionMySQL_SinBD(instancia, user, pass, puerto);
                MySQL.Abrir();
                MySQL.Ejecutar_query("USE " + mBD +";");
                MySQL.Ejecutar_query("CREATE TABLE `" + mNomTabla.Trim() + "` ("
                                      + "`TableIndex` int(11) NOT NULL AUTO_INCREMENT,"
                                      + "`TagTimestamp` datetime NOT NULL,"
                                      + "`TagItemID` mediumtext NOT NULL,"
                                      + "`TagValue` decimal(7,2) NOT NULL,"
                                      + "`TagQuality` int(50) NOT NULL,"
                                      + "PRIMARY KEY (`TableIndex`),"
                                      + "KEY `TagTimestamp` (`TagTimestamp`)"
                                      + ") ENGINE=InnoDB DEFAULT CHARSET=latin1;");
                MySQL.Cerrar();
                ok = true;                
            }
            catch (Exception ex)
            {
                ok = false;
            }
            return ok;
        }
        public ComboBox MuestraBasesSQL(ComboBox SQLComboBox, string minstancia, string musuario, string mpass)
        {
            SQLInfoEnumerator sie = new SQLInfoEnumerator();
            try
            {
                sie.SQLServer = minstancia;
                sie.Username = musuario;
                sie.Password = mpass;
                SQLComboBox.Items.Add("Ninguno");
                SQLComboBox.Items.AddRange(sie.EnumerateSQLServersDatabases());
                MessageBox.Show("Conexion Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema en la Conexion. Aceptar para Detalles");
                MessageBox.Show(ex.ToString());
            }
            return SQLComboBox;
        }
        public ComboBox MuestraInstanciasSQL(ComboBox SQLComboBox)
        {
            SQLInfoEnumerator sie = new SQLInfoEnumerator();
            try
            {
                SQLComboBox.Items.Clear();
                SQLComboBox.Items.AddRange(sie.EnumerateSQLServers());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return SQLComboBox;
        }
        public bool ConfiguraConexionBD(bool mok, string mInstancia, string mUsuario, string mPass, string mPuerto, string mBD)
        {
            try
            {
                DataSet ds2 = new DataSet();
                string ruta_xml2 = Application.StartupPath;
                ruta_xml2 = ruta_xml2 + "\\Config.xml";
                if (!System.IO.File.Exists(ruta_xml2))
                {
                    using (XmlWriter writer = XmlWriter.Create(ruta_xml2))
                    {
                        writer.WriteStartElement("Preferencias");
                        writer.WriteElementString("GestorBD", "Postgres");
                        writer.WriteElementString("Host", mInstancia);
                        writer.WriteElementString("User", mUsuario);
                        writer.WriteElementString("Pass", mPass);
                        writer.WriteElementString("Puerto", mPuerto);
                        writer.WriteElementString("BD", mBD);
                        writer.WriteEndElement();
                        writer.Flush();
                    }
                }
                else
                {
                    ds2.Clear();
                    ds2.ReadXml(ruta_xml2);
                    ////GUARDAMOS LOS NUEVOS DATOS AL XML
                    //string nueva_instancia = QuitaCaracteresDiagonal(cmbInstancias.Text);
                    ds2.Tables["Preferencias"].Rows[0]["GestorBD"] = "Postgres";
                    ds2.Tables["Preferencias"].Rows[0]["Host"] = mInstancia;
                    ds2.Tables["Preferencias"].Rows[0]["User"] = mUsuario;
                    ds2.Tables["Preferencias"].Rows[0]["Pass"] = mPass;
                    ds2.Tables["Preferencias"].Rows[0]["Puerto"] = mPuerto;
                    ds2.Tables["Preferencias"].Rows[0]["BD"] = mBD;
                    ds2.WriteXml(ruta_xml2);//GUARDAMOS EL XML NUEVO CON LOS DATOS NUEVOS INGRESADOS AL DATASET    
                }
                mok = true;
            }
            catch (Exception ex)
            {
                mok = false;
            }
            return mok;
        }
        public bool CreaBDPostgres(bool status, string mInstancia, string mUsuario, string mPass, string mPuerto, string mBD)
        {
            //CREATE DATABASE nombre_base
            bool conecta;
            try
            {
                Postgres.ConexionPostgres_SinBD(mInstancia, mUsuario, mPass, "");
                Postgres.Abrir();
                Postgres.Ejecutar_query("CREATE DATABASE " + mBD + "");
                Postgres.Cerrar();
                conecta = true;
            }
            catch (Exception ex)
            {
                conecta = false;
            }
            return conecta;
        }
        public DataGridView CargaDATPantalla(DataGridView mGrid, string mRuta)
        {
            StreamReader objReader = new StreamReader(mRuta);
            string sLine = "";
            mGrid.Columns.Add("Datos", "Datos");
            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    mGrid.Rows.Add(sLine);
            }
            return mGrid;
        }
        public void CreaArbolBDSqlServer(string NomBD, string instancia, string user, string pass)
        {
            try
            {
                ConexionSQL SQL = new ConexionSQL("3", instancia, user, pass, NomBD);
                SQL.Abrir();
                SQL.Ejecutar_query("CREATE DATABASE " + NomBD + "");
                SQL.Ejecutar_query("USE " + NomBD + "");
                SQL.Ejecutar_query("CREATE TABLE [dbo].[Matriz] ("
                + "[id_device] int NOT NULL IDENTITY(1,1) ,"
                + "[value] numeric(18,4) NULL ,"
                + "[calidad] char(20) NULL ,"
                + "[actualizacion] date NULL ,"
                + "[estado] char(10) NULL ,"
                + "[comentarios] char(255) NULL ,"
                + "[usuario] char(100) NULL ,"
                + "[rate] int NULL ,"
                + "[vigencia] int NULL ,"
                + "[logs] char(255) NULL)");
                SQL.Cerrar();
            }
            catch (Exception ex3)
            {
                MessageBox.Show("Error al Conectarse al servidor de SQL");
            }
        }
        public void GrabaMatrizRate(DataTable mdtTabla, string minstancia, string musuario, string mpass, string mbd)
        {
            try
            {
                ConexionSQL SQL = new ConexionSQL("1", minstancia, musuario, mpass, mbd);
                SQL.Abrir();
                SQL.DatatableSQL(mdtTabla, minstancia, mbd, musuario, mpass);
                SQL.Cerrar();
            }
            catch (Exception ex3)
            {
                MessageBox.Show("Error al Grabar en Base de Datos");
            }
        }
        public void LlenaTablaPF(DataTable mdtTabla, string minstancia, string musuario, string mpass, string mpuerto, string mbd, string mtabla, string mPozo, string mDevice)
        {
            string Fecha = "";
            try
            {
                //MySQL.ConexionMySQL_SinBD(minstancia, musuario, mpass, mpuerto);
                MySQL.ConexionMySQL_BD(minstancia, musuario, mpass, mbd, mpuerto);
                MySQL.Abrir();
                for (int j = 0; j <= mdtTabla.Rows.Count - 1; j++)
                {
                    Fecha = ExtraeFecha(mdtTabla.Rows[j].ItemArray[0].ToString().Trim());
                    Fecha = Fecha + " " + mdtTabla.Rows[j].ItemArray[1].ToString().Trim();
                    //dtTablasMySQL.Rows[i].ItemArray[0].ToString().Trim()                       "Device_1"
                    /*MySQL.Ejecutar_query("INSERT INTO " + mbd + "." + mtabla + " (`TagTimestamp`,`TagItemID`,`TagValue`,`TagQuality`) "
                        + "values('" + mdtTabla.Rows[j].ItemArray[0].ToString().Trim() + " " + mdtTabla.Rows[j].ItemArray[1].ToString().Trim() + "'"
                        + "'"+ mPozo + "." + mDevice + ".PF'"
                        + "'" + mdtTabla.Rows[j].ItemArray[3].ToString().Trim() +"';");*/
                    MySQL.Ejecutar_query("INSERT INTO " + mbd + "." + mtabla + " (`TagTimestamp`,`TagItemID`,`TagValue`,`TagQuality`) "
                        + "values('" + Fecha + "',"
                        + "'" + mPozo + "." + mDevice + ".pf',"
                        + "'" + mdtTabla.Rows[j].ItemArray[3].ToString().Trim() + "',"
                        + "'0');");
                }                
                MySQL.Cerrar();
            }
            catch (Exception ex3)
            {
                MessageBox.Show("Error al Grabar en Base de Datos");
            }
        }
        public void LlenaTablaTF(DataTable mdtTabla, string minstancia, string musuario, string mpass, string mpuerto, string mbd, string mtabla, string mPozo, string mDevice)
        {
            string Fecha = "";
            try
            {
                MySQL.ConexionMySQL_SinBD(minstancia, musuario, mpass, mpuerto);
                MySQL.Abrir();
                for (int j = 0; j <= mdtTabla.Rows.Count - 1; j++)
                {
                    Fecha = ExtraeFecha(mdtTabla.Rows[j].ItemArray[0].ToString().Trim());
                    Fecha = Fecha + " " + mdtTabla.Rows[j].ItemArray[1].ToString().Trim();
                    //dtTablasMySQL.Rows[i].ItemArray[0].ToString().Trim()                       "Device_1"
                    MySQL.Ejecutar_query("INSERT INTO " + mbd + "." + mtabla + " (`TagTimestamp`,`TagItemID`,`TagValue`,`TagQuality`) "
                        + "values('" + Fecha + "',"
                        + "'" + mPozo + "." + mDevice + ".tf',"
                        + "'" + mdtTabla.Rows[j].ItemArray[4].ToString().Trim() + "',"
                        + "'0');");
                }
                MySQL.Cerrar();
            }
            catch (Exception ex3)
            {
                MessageBox.Show("Error al Grabar en Base de Datos");
            }
        }
        public void LlenaTablaPS(DataTable mdtTabla, string minstancia, string musuario, string mpass, string mpuerto, string mbd, string mtabla, string mPozo, string mDevice)
        {
            string Fecha = "";
            try
            {
                MySQL.ConexionMySQL_SinBD(minstancia, musuario, mpass, mpuerto);
                MySQL.Abrir();
                for (int j = 0; j <= mdtTabla.Rows.Count - 1; j++)
                {
                    Fecha = ExtraeFecha(mdtTabla.Rows[j].ItemArray[0].ToString().Trim());
                    Fecha = Fecha + " " + mdtTabla.Rows[j].ItemArray[1].ToString().Trim();
                    //dtTablasMySQL.Rows[i].ItemArray[0].ToString().Trim()                       "Device_1"
                    MySQL.Ejecutar_query("INSERT INTO " + mbd + "." + mtabla + " (`TagTimestamp`,`TagItemID`,`TagValue`,`TagQuality`) "
                        + "values('" + Fecha + "',"
                        + "'" + mPozo + "." + mDevice + ".ps',"
                        + "'" + mdtTabla.Rows[j].ItemArray[5].ToString().Trim() + "',"
                        + "'0');");
                }
                MySQL.Cerrar();
            }
            catch (Exception ex3)
            {
                MessageBox.Show("Error al Grabar en Base de Datos");
            }
        }
        public void LlenaTablaTS(DataTable mdtTabla, string minstancia, string musuario, string mpass, string mpuerto, string mbd, string mtabla, string mPozo, string mDevice)
        {
            string Fecha = "";
            try
            {
                MySQL.ConexionMySQL_SinBD(minstancia, musuario, mpass, mpuerto);
                MySQL.Abrir();
                for (int j = 0; j <= mdtTabla.Rows.Count - 1; j++)
                {
                    Fecha = ExtraeFecha(mdtTabla.Rows[j].ItemArray[0].ToString().Trim());
                    Fecha = Fecha + " " + mdtTabla.Rows[j].ItemArray[1].ToString().Trim();
                    //dtTablasMySQL.Rows[i].ItemArray[0].ToString().Trim()                       "Device_1"
                    MySQL.Ejecutar_query("INSERT INTO " + mbd + "." + mtabla + " (`TagTimestamp`,`TagItemID`,`TagValue`,`TagQuality`) "
                        + "values('" + Fecha + "',"
                        + "'" + mPozo + "." + mDevice + ".ts',"
                        + "'" + mdtTabla.Rows[j].ItemArray[6].ToString().Trim() + "',"
                        + "'0');");
                }
                MySQL.Cerrar();
            }
            catch (Exception ex3)
            {
                MessageBox.Show("Error al Grabar en Base de Datos");
            }
        }

        public void LlenaTablaMonitor(DataTable mdtTabla, string minstancia, string musuario, string mpass, string mpuerto, string mbd, string mtabla, string mPozo, string mDevice)
        {
            try
            {
                MySQL.ConexionMySQL_SinBD(minstancia, musuario, mpass, mpuerto);
                MySQL.Abrir();
                int ColFinal = mdtTabla.Rows.Count;
                string Fecha = ExtraeFecha(mdtTabla.Rows[ColFinal - 1].ItemArray[0].ToString().Trim());
                Fecha = Fecha + " " + mdtTabla.Rows[ColFinal - 1].ItemArray[1].ToString().Trim();
                //INSERTAMOS PF
                MySQL.Ejecutar_query("INSERT INTO " + mbd + "." + mtabla + " (`TagTimestamp`,`TagItemID`,`TagValue`,`TagQuality`) "
                        + "values('" + Fecha + "',"
                        + "'" + mPozo + "." + mDevice + ".pf',"
                        + "'" + mdtTabla.Rows[ColFinal - 1].ItemArray[3].ToString().Trim() + "',"
                        + "'0');");
                //INSERTAMOS TF
                MySQL.Ejecutar_query("INSERT INTO " + mbd + "." + mtabla + " (`TagTimestamp`,`TagItemID`,`TagValue`,`TagQuality`) "
                        + "values('" + Fecha + "',"
                        + "'" + mPozo + "." + mDevice + ".tf',"
                        + "'" + mdtTabla.Rows[ColFinal - 1].ItemArray[4].ToString().Trim() + "',"
                        + "'0');");
                //INSERTAMOS PS
                MySQL.Ejecutar_query("INSERT INTO " + mbd + "." + mtabla + " (`TagTimestamp`,`TagItemID`,`TagValue`,`TagQuality`) "
                        + "values('" + Fecha + "',"
                        + "'" + mPozo + "." + mDevice + ".ps',"
                        + "'" + mdtTabla.Rows[ColFinal - 1].ItemArray[5].ToString().Trim() + "',"
                        + "'0');");
                //INSERTAMOS TS
                MySQL.Ejecutar_query("INSERT INTO " + mbd + "." + mtabla + " (`TagTimestamp`,`TagItemID`,`TagValue`,`TagQuality`) "
                        + "values('" + Fecha + "',"
                        + "'" + mPozo + "." + mDevice + ".ts',"
                        + "'" + mdtTabla.Rows[ColFinal - 1].ItemArray[6].ToString().Trim() + "',"
                        + "'0');");
                MySQL.Cerrar();
            }
            catch (Exception ex3)
            {
                MessageBox.Show("Error al Grabar en Base de Datos");
            }
        }
        public void ActualizaTablaMonitor(DataTable mdtTabla, string minstancia, string musuario, string mpass, string mpuerto, string mbd, string mtabla, string mPozo, string mDevice)
        {
            try
            {
                MySQL.ConexionMySQL_SinBD(minstancia, musuario, mpass, mpuerto);
                MySQL.Abrir();
                int ColFinal = mdtTabla.Rows.Count;
                string Fecha = ExtraeFecha(mdtTabla.Rows[ColFinal - 1].ItemArray[0].ToString().Trim());
                Fecha = Fecha + " " + mdtTabla.Rows[ColFinal - 1].ItemArray[1].ToString().Trim();
                //ACTUALIZAMOS

                MySQL.Ejecutar_query("UPDATE " + mbd + "." + mtabla + " SET TagTimestamp = '" + Fecha + "', "
                    + "TagItemID = '" + mPozo + "." + mDevice + ".pf', "
                    + "TagValue = '" + mdtTabla.Rows[ColFinal - 1].ItemArray[3].ToString().Trim() + "', "
                    + "TagQuality = '0' "
                    + "where TagItemID = '" + mPozo + "." + mDevice + ".pf'");
                MySQL.Ejecutar_query("UPDATE " + mbd + "." + mtabla + " SET TagTimestamp = '" + Fecha + "', "
                    + "TagItemID = '" + mPozo + "." + mDevice + ".tf', "
                    + "TagValue = '" + mdtTabla.Rows[ColFinal - 1].ItemArray[4].ToString().Trim() + "', "
                    + "TagQuality = '0' "
                    + "where TagItemID = '" + mPozo + "." + mDevice + ".tf'");
                MySQL.Ejecutar_query("UPDATE " + mbd + "." + mtabla + " SET TagTimestamp = '" + Fecha + "', "
                    + "TagItemID = '" + mPozo + "." + mDevice + ".ps', "
                    + "TagValue = '" + mdtTabla.Rows[ColFinal - 1].ItemArray[5].ToString().Trim() + "', "
                    + "TagQuality = '0' "
                    + "where TagItemID = '" + mPozo + "." + mDevice + ".ps'");
                MySQL.Ejecutar_query("UPDATE " + mbd + "." + mtabla + " SET TagTimestamp = '" + Fecha + "', "
                    + "TagItemID = '" + mPozo + "." + mDevice + ".ts', "
                    + "TagValue = '" + mdtTabla.Rows[ColFinal - 1].ItemArray[6].ToString().Trim() + "', "
                    + "TagQuality = '0' "
                    + "where TagItemID = '" + mPozo + "." + mDevice + ".ts'");
                MySQL.Cerrar();
            }
            catch (Exception ex3)
            {
                MessageBox.Show("Error al Grabar en Base de Datos");
            }
        }
        private string ExtraeFecha(string mCadena)
        {
            string Fecha = "", ano = "", dia = "", mes = "";
            try
            {
                ano = mCadena.Substring(6, 2);
                ano = "20" + ano;
                mes = mCadena.Substring(3, 2);
                dia = mCadena.Substring(0, 2);
                Fecha = ano + "-" + mes + "-" + dia;
                //Fecha = mCadena.Substring(0, 6) + "20" + ano;
            }
            catch (Exception ex)
            {

            }
            return Fecha;
        }
        public void GeneraActualizaXMLPreferencias(string mNom_pref, string mInstancia, string mUsuario, string mPass, string mPuerto, string mBD)
        {
            DataSet ds2 = new DataSet();
            string ruta_xml2 = Application.StartupPath;
            ruta_xml2 = ruta_xml2 + "\\Preferencias\\" + mNom_pref + ".xml";
            if (!System.IO.File.Exists(ruta_xml2))
            {
                using (XmlWriter writer = XmlWriter.Create(ruta_xml2))
                {
                    writer.WriteStartElement("Preferencias");
                    writer.WriteElementString("NomPref", mNom_pref);
                    writer.WriteElementString("Instancia", mInstancia);
                    writer.WriteElementString("Usuario", mUsuario);
                    writer.WriteElementString("Pass", mPass);
                    writer.WriteElementString("Puerto", mPuerto);
                    writer.WriteElementString("BD", mBD);
                    writer.WriteEndElement();
                    writer.Flush();
                }
            }
            else
            {
                ds2.Clear();
                ds2.ReadXml(ruta_xml2);
                ////GUARDAMOS LOS NUEVOS DATOS AL XML
                //string nueva_instancia = QuitaCaracteresDiagonal(cmbInstancias.Text);
                ds2.Tables["Preferencias"].Rows[0]["NomPref"] = mNom_pref;
                ds2.Tables["Preferencias"].Rows[0]["Instancia"] = mInstancia;
                ds2.Tables["Preferencias"].Rows[0]["Usuario"] = mUsuario;
                ds2.Tables["Preferencias"].Rows[0]["Pass"] = mPass;
                ds2.Tables["Preferencias"].Rows[0]["Puerto"] = mPuerto;
                ds2.Tables["Preferencias"].Rows[0]["BD"] = mBD;
                ds2.WriteXml(ruta_xml2);//GUARDAMOS EL XML NUEVO CON LOS DATOS NUEVOS INGRESADOS AL DATASET    
            }
        }
    }
}