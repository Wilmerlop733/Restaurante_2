using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Restaurante1.Services
{
    public static class DatabaseHelper
    {
        private static clsConexion proveedorConexion = new clsConexion();

        public static DataTable ExecuteQuery(string consultaSql, MySqlParameter[] parametros = null)
        {
            DataTable tablaResultados = new DataTable();
            
            using (MySqlConnection conexion = proveedorConexion.GetConnection())
            {
                if (proveedorConexion.OpenConnection(conexion))
                {
                    using (MySqlCommand comando = new MySqlCommand(consultaSql, conexion))
                    {
                        if (parametros != null)
                        {
                            comando.Parameters.AddRange(parametros);
                        }

                        using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                        {
                            adaptador.Fill(tablaResultados);
                        }
                    }
                    proveedorConexion.CloseConnection(conexion);
                }
            }
            return tablaResultados;
        }

        public static int ExecuteNonQuery(string consultaSql, MySqlParameter[] parametros = null)
        {
            int filasAfectadas = -1;
            using (MySqlConnection conexion = proveedorConexion.GetConnection())
            {
                if (proveedorConexion.OpenConnection(conexion))
                {
                    using (MySqlCommand comando = new MySqlCommand(consultaSql, conexion))
                    {
                        if (parametros != null)
                        {
                            comando.Parameters.AddRange(parametros);
                        }
                        
                        filasAfectadas = comando.ExecuteNonQuery();
                    }
                    proveedorConexion.CloseConnection(conexion);
                }
            }
            return filasAfectadas;
        }

        public static object ExecuteScalar(string consultaSql, MySqlParameter[] parametros = null)
        {
            object resultadoUnico = null;
            using (MySqlConnection conexion = proveedorConexion.GetConnection())
            {
                if (proveedorConexion.OpenConnection(conexion))
                {
                    using (MySqlCommand comando = new MySqlCommand(consultaSql, conexion))
                    {
                        if (parametros != null)
                        {
                            comando.Parameters.AddRange(parametros);
                        }
                        
                        resultadoUnico = comando.ExecuteScalar();
                    }
                    proveedorConexion.CloseConnection(conexion);
                }
            }
            return resultadoUnico;
        }
    }
}
