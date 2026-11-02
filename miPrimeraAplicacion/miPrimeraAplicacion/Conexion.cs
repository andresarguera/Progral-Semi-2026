using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimeraAplicacion
{
    internal class Conexion
    {
        public SqlConnection objConexion = new SqlConnection();
        public SqlCommand objComando = new SqlCommand();
        public SqlDataAdapter objDataAdapter = new SqlDataAdapter();
        public DataSet objDs = new DataSet();

        public Conexion()
        {
            // Cadena de conexión local para Visual Studio
            string cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbacademica.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open();
        }

        // ==========================================
        // 1. CREAR DATASET PARA EL MANTENIMIENTO DE USUARIOS
        // ==========================================
        public void crearDs()
        {
            try
            {
                objDs.Clear();
                objComando.Connection = objConexion;
                objComando.CommandText = "SELECT * FROM usuarios_usss020326";
                objDataAdapter.SelectCommand = objComando;
                objDataAdapter.Fill(objDs, "usuarios");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar DataSet de Usuarios: " + ex.Message);
            }
        }

        public DataSet crearDsUsuarios()
        {
            crearDs();
            return objDs;
        }

        // ==========================================
        // 2. MANTENIMIENTO DE USUARIOS (usss020326)
        // ==========================================
        public string mantenimiento_usuarios_usss020326(string[] datos, string accion)
        {
            try
            {
                string sql = "";

                // datos[0]: idUsuario, datos[1]: usuario, datos[2]: clave, datos[3]: nombre, datos[4]: direccion, datos[5]: telefono
                if (accion == "nuevo")
                {
                    sql = "INSERT INTO usuarios_usss020326 (usuario, clave, nombre, direccion, telefono) " +
                          "VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "', '" + datos[5] + "')";
                }
                else if (accion == "modificar")
                {
                    sql = "UPDATE usuarios_usss020326 SET " +
                          "usuario = '" + datos[1] + "', " +
                          "clave = '" + datos[2] + "', " +
                          "nombre = '" + datos[3] + "', " +
                          "direccion = '" + datos[4] + "', " +
                          "telefono = '" + datos[5] + "' " +
                          "WHERE idUsuario = " + datos[0];
                }
                else if (accion == "eliminar")
                {
                    sql = "DELETE FROM usuarios_usss020326 WHERE idUsuario = " + datos[0];
                }

                return ejecutarSQL(sql);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // ==========================================
        // 3. VALIDACIÓN DE CREDENCIALES PARA EL LOGIN
        // ==========================================
        public bool ValidarLogin(string usuario, string clave)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = "SELECT COUNT(*) FROM usuarios_usss020326 WHERE usuario = '" + usuario + "' AND clave = '" + clave + "'";
                int count = Convert.ToInt32(objComando.ExecuteScalar());
                return count > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // ==========================================
        // 4. EJECUTOR GENERAL DE COMANDOS SQL
        // ==========================================
        public String ejecutarSQL(String sql)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;
                int filasAfectadas = objComando.ExecuteNonQuery();
                crearDs();
                return filasAfectadas.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}