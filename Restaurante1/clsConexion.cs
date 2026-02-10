using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Restaurante1
{
    public class clsConexion
    {
        private string servidor = "localhost";
        private string baseDatos = "restaurante";
        private string usuario = "root";
        private string clave = "Root";

        public MySqlConnection GetConnection()
        {
            try
            {
                string cadenaConexion = $"Server={servidor}; Database={baseDatos}; Uid={usuario}; Pwd={clave};";
                return new MySqlConnection(cadenaConexion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la conexión: " + ex.Message, "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool OpenConnection(MySqlConnection conexion)
        {
            string error;
            return OpenConnection(conexion, out error);
        }

        public bool OpenConnection(MySqlConnection conexion, out string errorMessage)
        {
            errorMessage = "";
            try
            {
                if (conexion != null && conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                MessageBox.Show("No se pudo abrir la conexión a la base de datos:\n" + ex.Message, "Fallo al Abrir", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void CloseConnection(MySqlConnection conexion)
        {
            try
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar cerrar la conexión:\n" + ex.Message, "Error al Cerrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}