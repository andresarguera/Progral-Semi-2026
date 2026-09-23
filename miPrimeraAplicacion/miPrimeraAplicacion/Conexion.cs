using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data; //Esta libreria es para usar bases de datos
using System.Data.SqlClient; //Esta libreria permite usar SQL Server

namespace miPrimeraAplicacion
{
    internal class Conexion
    {
        //Definir los miembros, atributos y metodos de la clase
        public SqlConnection objConexion = new SqlConnection(); //Conectarse a la BD
        public SqlCommand objComando = new SqlCommand(); //Ejecutar consultas (Insert, update, delete, select) SQL en la BD
        public SqlDataAdapter objDataAdapter = new SqlDataAdapter(); //Un puente entre la BD y la aplicación
        DataSet objDs = new DataSet(); //Representa una copia en memoria de la arquitectura de la BD

        public Conexion()
        {//Constructor de la clase
            string cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbacademica.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); //abrir la BD
        }
        public DataSet obtenerDatos()
        {
            objDs.Clear();//Limpiar el datase.
            objComando.Connection = objConexion;//Establcer la conexion para ejecutar consultas a la BD

            objDataAdapter.SelectCommand = objComando;
            objComando.CommandText = "SELECT * FROM alumnos";
            objDataAdapter.Fill(objDs, "alumnos"); //tomamos los datos de la BD y llenamos el ds

            return objDs;
        }
    }
}