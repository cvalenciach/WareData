using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WareData.AccesoDatos
{
    class ConexionMySQL
    {
        MySqlConnection Con;// = new MySqlConnection();

        public void ConexionMySQL_SinBD(string minstancia, string muser, string mpass, string mpuerto)
        {

            string DtsConection = ""; // Contendra los Datos las Conexion.
            if (mpuerto != "")
            {
                DtsConection = "Server=" + minstancia.Trim() + ";Port = " + mpuerto + ";Database=mysql;Uid=" + muser.Trim() + ";Password=" + mpass.Trim() + ";";
            }
            else
            {
                DtsConection = "Server=" + minstancia.Trim() + ";Database=mysql;Uid=" + muser.Trim() + ";Password=" + mpass.Trim() + ";";
            }
            Con = new MySqlConnection(DtsConection);
        }

        public void ConexionMySQL_BD(string minstancia, string muser, string mpass, string mbase, string mpuerto)
        {
            string DtsConectionDB = ""; // Contendra los Datos las Conexion.
            if (mpuerto != "")
            {
                DtsConectionDB = "Server=" + minstancia.Trim() + ";Port = " + mpuerto + ";Database=" + mbase + ";Uid=" + muser.Trim() + ";Password=" + mpass.Trim() + ";";
            }
            else
            {
                DtsConectionDB = "Server = " + minstancia + ";Database=" + mbase + ";Uid=" + muser + ";Password=" + mpass + ";";
            }
            Con = new MySqlConnection(DtsConectionDB);
        }
        public void Abrir()
        {
            Con.Open();
        }
        public void Cerrar()
        {
            Con.Close();
        }
        public void Ejecutar_query(string Comando) // Metodo para Ejecutar Comandos
        {
            MySqlCommand cmd = new MySqlCommand(Comando, Con);
            cmd.CommandTimeout = 0;
            cmd.ExecuteScalar();
        }
        public string Consulta_query(string Comando, string Tabla) // Metodo para Consultar Comandos
        {
            MySqlCommand cmd = new MySqlCommand(Comando, Con);
            cmd.CommandTimeout = 0;
            string consulta = cmd.ExecuteScalar().ToString();
            return consulta;
        }
        public DataSet EjecutarDataSet(string Comando, string Tabla) // Metodo para Guardar Consulta en DataSet
        {
            MySqlDataAdapter CMD = new MySqlDataAdapter(Comando, Con); // Creamos un DataAdapter con el Comando y la Conexion
            CMD.SelectCommand.CommandTimeout = 0;
            DataSet DS = new DataSet(); // Creamos el DataSet que Devolvera el Metodo
            CMD.Fill(DS, Tabla); // Ejecutamos el Comando en la Tabla
            return DS; // Regresamos el DataSet
        }
        public DataTable EjecutaDataTable(string Comando, string Tabla)//Metodo para Guardar Consulta en DataTable
        {
            MySqlCommand cmd = new MySqlCommand(Comando, Con);
            cmd.CommandTimeout = 0;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public MySqlDataReader ExtraeBDMySQL(MySqlDataReader mregistrosObtenidosMySQL)//Extrae las Base de Datos de MySQL
        {
            //MySqlDataReader registrosObtenidosMySQL = null;
            MySqlCommand cmd = new MySqlCommand("SHOW DATABASES", Con);
            mregistrosObtenidosMySQL = cmd.ExecuteReader();
            return mregistrosObtenidosMySQL;
        }
        public MySqlDataReader ExtraeTablasMySQL(MySqlDataReader mregistrosObtenidosMySQL, string mBD)//Extrae las Base de Datos de MySQL
        {
            //MySqlDataReader registrosObtenidosMySQL = null;
            MySqlCommand cmd = new MySqlCommand("SHOW TABLES FROM " + mBD + "", Con);
            mregistrosObtenidosMySQL = cmd.ExecuteReader();
            return mregistrosObtenidosMySQL;
        }        
    }
}
