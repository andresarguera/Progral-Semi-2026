using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimeraAplicacion
{
    internal class Conexion
    {
        public SqlConnection objConexion = new SqlConnection();
        public SqlCommand objComando = new SqlCommand();
        public SqlDataAdapter objDataAdapter = new SqlDataAdapter();
        DataSet objDs = new DataSet();

        public Conexion()
        {
            string cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbacademica.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open();
        }

        public DataSet obtenerDatos()
        {
            objDs.Clear();
            objComando.Connection = objConexion;
            objComando.CommandText = "SELECT * FROM alumnos";
            objDataAdapter.SelectCommand = objComando;
            objDataAdapter.Fill(objDs, "alumnos");

            return objDs;
        }

        public string administrarDatosAlumnos(string[] datos, string accion)
        {
            try
            {
                string sql = "";

                // datos[0] = idAlumnos, datos[1] = código, datos[2] = nombre, datos[3] = direccion, datos[4] = telefono, datos[5] = email
                if (accion == "nuevo")
                {
                    sql = "INSERT INTO alumnos (código, nombre, direccion, telefono, email) " +
                          "VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "', '" + datos[5] + "')";
                }
                else if (accion == "modificar")
                {
                    sql = "UPDATE alumnos SET " +
                          "código = '" + datos[1] + "', " +
                          "nombre = '" + datos[2] + "', " +
                          "direccion = '" + datos[3] + "', " +
                          "telefono = '" + datos[4] + "', " +
                          "email = '" + datos[5] + "' " +
                          "WHERE idAlumnos = " + datos[0];
                }
                else if (accion == "eliminar")
                {
                    sql = "DELETE FROM alumnos WHERE idAlumnos = " + datos[0];
                }

                objComando.Connection = objConexion;
                objComando.CommandText = sql;
                objComando.ExecuteNonQuery();

                return "1"; // Éxito
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}