using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace miPrimeraAplicacion
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        Conexion objConexion = new Conexion();
        Dataset ds = new DataSet();
        private object dt;
        DataTable dateTable = new DateTable();
        String accion = "nuevo";
        int posicion = 0;

        private void obtenerDatos()
        {
            ds.Clear();
            ds = objConexion.obtenerDatos();
            dt = ds.Tables["alumnos"];
            dt.PrimaryKey = new DataColumn[] { dt.Columns["idAlumno"] };

            mostrarDatos();
        }

        private void mostrarDatos()
        {
            if (dt.Rows.Count > 0){
               txtCodigoAlumno.Text = dt.Rows[posicion]["codigo"].ToString();
               txtNombreAlumno.Text = dt.Rows[posicion]["nombre"].ToString();
               txtDireccionAlumno.Text = dt.Rows[posicion]["direccion"].ToString();
               txtTelefonoAlumno.Text = dt.Rows[posicion]["telefono"].ToString();
               textEmailAlumnno.Text = dt.Rows[posicion]["email"].ToString();

               lblRegistrosAlumnos.Text = (posicion + 1) + " de " + dt.Rows.Count;

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void grbDatos_Enter(object sender, EventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void activarDesactivarCtrls(Boolean estado)
        {
            grbDatos.Enabled = estado;
            grbNavegacion.Enabled = !estado;
        }
        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            if (btnAgregarAlumno.Text == "Agregar")
            {
                btnAgregarAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";

                activarDesactivarCtrls(true);
            }
            else
            {//Guardar los datos del alumno en la base de datos
                activarDesactivarCtrls(false);
                btnAgregarAlumno.Text = "Agregar";
                btnModificarAlumno.Text = "Modificar";
            }
        }

        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            if (btnModificarAlumno.Text == "Modificar")
            {
                btnAgregarAlumno.Text = "Guardar";
                btnModificarAlumno.Text = "Cancelar";

                activarDesactivarCtrls(true);
            }
            else
            {//Guardar los datos del alumno en la base de datos
                activarDesactivarCtrls(false);
                btnAgregarAlumno.Text = "Agregar";
                btnModificarAlumno.Text = "Modificar";
            }
        }

        private void btnSiguienteAlumno_Click(object sender, EventArgs e)
        {
            posicion++;
            mostrarDatos();
        }

        private void btnPrimeroAlumno_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnAnteriorAlumno_Click(object sender, EventArgs e)
        {
            posicion--;
            mostrarDatos();
        }

        private void btnUltimoAlumno_Click(object sender, EventArgs e)
        {
            posicion = dt.Rows.Count - 1;
            mostrarDatos();
        }
    }
}

       