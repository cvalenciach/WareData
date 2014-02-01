using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Data;

namespace WareData.AccesoDatos
{
    class ConexionPostgres
    {
        NpgsqlConnection Con;
        //string CadenaConexion = "Server=192.168.2.196;Database=playa_caracol;User Id=postgres;Password=2888850871;";

        public void ConexionPostgres_SinBD(string minstancia, string muser, string mpass, string mpuerto)
        {
            string DtsConection = ""; // Contendra los Datos las Conexion.
            if (mpuerto != "")
            {
                DtsConection = "Server=" + minstancia.Trim() + ";Port = " + mpuerto + ";Database=mysql;Uid=" + muser.Trim() + ";Password=" + mpass.Trim() + ";";
            }
            else
            {
                DtsConection = "Server=" + minstancia.Trim() + ";Database=postgres;User Id=" + muser.Trim() + ";Password=" + mpass.Trim() + ";";
            }
            Con = new NpgsqlConnection(DtsConection);
        }

        public void ConexionPostgres_BD(string minstancia, string muser, string mpass, string mbase, string mpuerto)
        {
            string DtsConectionDB = ""; // Contendra los Datos las Conexion.

            DtsConectionDB = "Server=" + minstancia.Trim() + "Database=" + mbase + ";User Id=" + muser + ";Password=" + mpass + ";";//Port=" + mpuerto + ";";
            Con = new NpgsqlConnection(DtsConectionDB);
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
            NpgsqlCommand cmd = new NpgsqlCommand(Comando, Con);
            cmd.CommandTimeout = 0;
            cmd.ExecuteScalar();
        }
        public string Consulta_query(string Comando) // Metodo para Consultar Comandos
        {
            NpgsqlCommand cmd = new NpgsqlCommand(Comando, Con);
            cmd.CommandTimeout = 0;
            string consulta = cmd.ExecuteScalar().ToString();
            return consulta;
        }
        public DataSet EjecutarDataSet(string Comando, string Tabla) // Metodo para Guardar Consulta en DataSet
        {
            NpgsqlDataAdapter CMD = new NpgsqlDataAdapter(Comando, Con); // Creamos un DataAdapter con el Comando y la Conexion
            CMD.SelectCommand.CommandTimeout = 0;
            DataSet DS = new DataSet(); // Creamos el DataSet que Devolvera el Metodo
            CMD.Fill(DS, Tabla); // Ejecutamos el Comando en la Tabla
            return DS; // Regresamos el DataSet
        }
        public DataTable EjecutaDataTable(string Comando)//Metodo para Guardar Consulta en DataTable
        {
            NpgsqlCommand cmd = new NpgsqlCommand(Comando, Con);
            cmd.CommandTimeout = 0;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public NpgsqlDataReader ExtraeBDPostgres(NpgsqlDataReader ListaBDPostgres)//Extrae las Base de Datos de MySQL
        {
            //MySqlDataReader registrosObtenidosMySQL = null;
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT datname FROM pg_database WHERE datistemplate = false;");//SHOW DATABASES", Con);
            ListaBDPostgres = cmd.ExecuteReader();
            return ListaBDPostgres;
        }
    }
}
