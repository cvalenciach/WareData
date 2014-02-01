using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace WareData.AccesoDatos
{
    class ConexionSQL
    {
        static SqlDataAdapter Adaptador = new SqlDataAdapter();
        static SqlConnection Con = new SqlConnection();
        static SqlCommandBuilder ConstructorDeComando;
        static SqlCommand Comando = new SqlCommand();

        private string ConsultaSQL;
        private string Cadena_Conexion = "";//"Data Source=CESAR-PC\\SQL2008N;Initial Catalog=Prueba;Persist Security Info=True;User ID=sa;Password=2888850871";

        public ConexionSQL(string tipo, string minstancia, string muser, string mpass, string mbase)
        {
            string DtsConection = ""; // Contendra los Datos las Conexion.
            if (tipo == "1")
            {
                Cadena_Conexion = "Data Source=" + minstancia + ";Initial Catalog=" + mbase + ";Integrated Security=SSPI;Trusted_Connection=false;User ID=" + muser + ";Password=" + mpass + ";";
            }
            if (tipo == "2")
            {
                Cadena_Conexion = "Data Source=CESAR-PC\\SQL2008N;Initial Catalog=Prueba;Persist Security Info=True;User ID=sa;Password=2888850871";
            }
            if (tipo == "3")
            {
                Cadena_Conexion = "Data Source=" + minstancia + ";Initial Catalog=master;Integrated Security=SSPI;Trusted_Connection=false;User ID=" + muser + ";Password=" + mpass + ";";
            }
            Con = new SqlConnection(Cadena_Conexion);
        }

        public void Insertar_Datos(string query)
        {
            try
            {
                //Comando = new SqlCommand(ConsultaSQL,Conexion);
                Comando = new SqlCommand(query, Con);
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Ejecutar la query");
                MessageBox.Show(ex.Message);
            }
        }
        public bool Abrir()
        {
            bool estado = true;
            try
            {
                //Con.ConnectionString = Cadena_Conexion;
                Con.Open();
            }
            catch (Exception ex)
            {
                estado = false;
                MessageBox.Show("Error al Abrir la conexion");
            }
            return estado;
        }
        public void Cerrar()
        {
            try
            {
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Error al cerrar la conexion");
            }
        }
        public DataSet EjecutarDataSet(string Comando, string Tabla) // Metodo para Ejecutar Comandos
        {
            SqlDataAdapter CMD = new SqlDataAdapter(Comando, Con); // Creamos un DataAdapter con el Comando y la Conexion
            CMD.SelectCommand.CommandTimeout = 0;
            DataSet DS = new DataSet(); // Creamos el DataSet que Devolvera el Metodo
            CMD.Fill(DS, Tabla); // Ejecutamos el Comando en la Tabla
            return DS; // Regresamos el DataSet
        }
        public DataTable EjecutaDataTable(string Comando, string Tabla)
        {
            SqlCommand cmd = new SqlCommand(Comando, Con);
            cmd.CommandTimeout = 0;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;
        }
        public DataSet ListarTablas(string Comando) // Metodo para Ejecutar Comandos
        {
            SqlDataAdapter CMD = new SqlDataAdapter(Comando, Con); // Creamos un DataAdapter con el Comando y la Conexion
            DataSet DS = new DataSet(); // Creamos el DataSet que Devolvera el Metodo
            CMD.Fill(DS); // Ejecutamos el Comando en la Tabla
            return DS; // Regresamos el DataSet
        }
        public void Ejecutar_query(string Comando) // Metodo para Ejecutar Comandos
        {
            SqlCommand cmd = new SqlCommand(Comando, Con);
            cmd.CommandTimeout = 0;
            cmd.ExecuteScalar();
        }
        public void Ejecutar_query_Respaldo(string Comando, string Tabla) // Metodo para Ejecutar Comandos
        {
            SqlCommand cmd = new SqlCommand(Comando, Con);
            cmd.CommandTimeout = 0;
            cmd.ExecuteNonQuery();
        }
        public string Consulta_query(string Comando, string Tabla) // Metodo para Ejecutar Comandos
        {
            SqlCommand cmd = new SqlCommand(Comando, Con);
            cmd.CommandTimeout = 0;
            string consulta = cmd.ExecuteScalar().ToString();
            return consulta;
        }
        public string Maximo_ID(string Comando, string Tabla) // Metodo para Ejecutar Comandos
        {
            SqlCommand cmd = new SqlCommand(Comando, Con);
            cmd.CommandTimeout = 0;
            string resultado = cmd.ExecuteScalar().ToString();
            return resultado;
        }
        public void DatatableSQL(DataTable dtTabla, string minstanciaD, string mbdD, string musuarioD, string mpassD)
        {
            string ConexionDestino = "Data Source=" + minstanciaD + ";Initial Catalog=" + mbdD + ";Integrated Security=SSPI;Trusted_Connection=false;User ID=" + musuarioD + ";Password=" + mpassD + ";";
            using (SqlConnection connection = new SqlConnection(ConexionDestino))
            {
                connection.Open();

                using (SqlBulkCopy bulkcopy = new SqlBulkCopy(connection))
                {
                    bulkcopy.DestinationTableName = "" + mbdD + ".dbo.Matriz";
                    bulkcopy.BulkCopyTimeout = 0;

                    bulkcopy.WriteToServer(dtTabla);
                }
            }
        }


        ////////PROCEDIMIENTOS ALMACENADOS
        public void Ejecutar_TagTemp(string NomProcAlm, string Fecha1, string Fecha2) // Metodo para Ejecutar Comandos
        {
            try
            {
                SqlCommand cmd = new SqlCommand(NomProcAlm, Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@FechaInicio", SqlDbType.VarChar, 10);
                cmd.Parameters["@FechaInicio"].Value = Fecha1;
                cmd.Parameters.Add("@FechaFin", SqlDbType.VarChar, 10);
                cmd.Parameters["@FechaFin"].Value = Fecha2;
                cmd.CommandTimeout = 400;
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {

            }
        }
        public DataSet ExtraeTabla(string NomProcAlm)
        {
            DataSet db = new DataSet();
            try
            {

                SqlCommand Query = new SqlCommand(NomProcAlm, Con);
                Query.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter SqlDa = new SqlDataAdapter(Query);
                SqlDa.Fill(db);
                return db;
            }
            catch (Exception ex)
            {

            }
            return db;
        }
    }
}
