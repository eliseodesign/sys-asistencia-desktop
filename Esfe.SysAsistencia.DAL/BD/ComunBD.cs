using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------------
using System.Data;
using System.Data.SqlClient;

namespace Esfe.SysAsistencia.DAL.BD
{
    public class ComunBD
    {
        //---Se coloca el link de conexion en una constante
        const string StrConexion = @"Data Source=localhost;Initial Catalog=BDSysAsistencia;Integrated Security=True";
        //----Establecemos la conexion con SQL
        private static SqlConnection ObtenerConexion()
        {
            // obtenemos la conexión y la abrimos
            SqlConnection connection = new SqlConnection(StrConexion);
            connection.Open();
            return connection;
        }
        public static SqlCommand ObtenerComando()
        {
            // obtener comando
            SqlCommand command = new SqlCommand();
            command.Connection = ObtenerConexion();
            return command;
        }
        public static int EjecutarComando(SqlCommand pComando)
        {
            int resultado = pComando.ExecuteNonQuery();
            pComando.Connection.Close();
            return resultado;
        }
        public static SqlDataReader EjecutarReader(SqlCommand pComando)
        {
            SqlDataReader reader = pComando.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }


        //Ejecutar Comando
        public static int EjecutarSP(string nombreSP, object objeto, List<string> parametros)
        {
            SqlCommand comando = ObtenerComando();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;
            foreach (var propiedad in objeto.GetType().GetProperties())
            {
                if (parametros.Contains(propiedad.Name))
                {
                    var valor = propiedad.GetValue(objeto, null);
                    comando.Parameters.AddWithValue("@" + propiedad.Name, valor);
                }
            }
            return EjecutarComando(comando);
        }
        public static List<T> EjecutarSPSelect<T>(string nombreSP) where T : new()
        {
            SqlCommand comando = ObtenerComando();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreSP;

            SqlDataReader reader = EjecutarReader(comando);

            List<T> lista = new List<T>();
            while (reader.Read())
            {
                T item = new T();
                foreach (var propiedad in item.GetType().GetProperties())
                {
                    //if (reader[propiedad.Name] != DBNull.Value)
                    //{
                        propiedad.SetValue(item, reader[propiedad.Name]);
                    //}
                }
                lista.Add(item);
            }
            reader.Close();
            return lista;
        }


    }
}