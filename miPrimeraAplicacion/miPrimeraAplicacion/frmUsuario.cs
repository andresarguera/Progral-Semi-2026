using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimeraAplicacion
{
    public partial class frm_usuario : Form
    {
        Conexion conexion = new Conexion();
        DataSet ds = new DataSet();
        int posicion = 0;

        public frm_usuario()
        {
            InitializeComponent();
        }

        private void frm_usuario_Load(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void ActualizarDatos()
        {
            // Carga los datos de usuarios mediante el DataSet
            conexion.crearDs();
            ds = conexion.objDs;

            if (ds.Tables["usuarios"] != null && ds.Tables["usuarios"].Rows.Count > 0)
            {
                posicion = 0;
                MostrarDatos();
                dataGridView1.DataSource = ds.Tables["usuarios"];
            }
        }

        private void MostrarDatos()
        {
            if (ds.Tables["usuarios"] != null && ds.Tables["usuarios"].Rows.Count > 0)
            {
                DataRow fila = ds.Tables["usuarios"].Rows[posicion];
                txtId.Text = fila["idUsuario"].ToString();
                txtUsuario.Text = fila["usuario"].ToString();
                txtClave.Text = fila["clave"].ToString();
                txtConfirmarClave.Text = fila["clave"].ToString();
                txtNombre.Text = fila["nombre"].ToString();
                txtDireccion.Text = fila["direccion"].ToString();
                txtTelefono.Text = fila["telefono"].ToString();
            }
        }

        private bool ValidarCampos()
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();
            string confirmar = txtConfirmarClave.Text.Trim();

            // 1. Validar longitud del usuario (mínimo 6, máximo 16 caracteres)[cite: 1]
            if (usuario.Length < 6 || usuario.Length > 16)
            {
                MessageBox.Show("El usuario debe tener un mínimo de 6 caracteres y un máximo de 16.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return false;
            }

            // 2. Validar que la clave pida confirmación y coincidan[cite: 1]
            if (clave != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor verifique.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmarClave.Focus();
                return false;
            }

            // 3. Validar que la clave contenga letras y números[cite: 1]
            bool tieneLetras = clave.Any(char.IsLetter);
            bool tieneNumeros = clave.Any(char.IsDigit);

            if (!tieneLetras || !tieneNumeros)
            {
                MessageBox.Show("La clave debe contener obligatoriamente letras y números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
                return false;
            }

            return true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            string[] datos = {
                "", // idUsuario vacío para nuevo registro (Auto-incremental)
                txtUsuario.Text.Trim(),
                txtClave.Text.Trim(),
                txtNombre.Text.Trim(),
                txtDireccion.Text.Trim(),
                txtTelefono.Text.Trim()
            };

            // Llamada al método con tu código personal solicitado en el parcial[cite: 1]
            string respuesta = conexion.mantenimiento_usuarios_usss020326(datos, "nuevo");

            if (respuesta == "1" || int.TryParse(respuesta, out int filas) && filas > 0)
            {
                MessageBox.Show("Usuario registrado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarDatos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al registrar: " + respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Seleccione un registro para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos()) return;

            string[] datos = {
                txtId.Text.Trim(),
                txtUsuario.Text.Trim(),
                txtClave.Text.Trim(),
                txtNombre.Text.Trim(),
                txtDireccion.Text.Trim(),
                txtTelefono.Text.Trim()
            };

            // Llamada al método de mantenimiento con tu código personal[cite: 1]
            string respuesta = conexion.mantenimiento_usuarios_usss020326(datos, "modificar");

            if (respuesta == "1" || respuesta == "0" || int.TryParse(respuesta, out int filas))
            {
                MessageBox.Show("Usuario modificado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarDatos();
            }
            else
            {
                MessageBox.Show("Error al modificar: " + respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Seleccione un registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                string[] datos = { txtId.Text.Trim(), "", "", "", "", "" };

                // Llamada para eliminar con tu código personal[cite: 1]
                string respuesta = conexion.mantenimiento_usuarios_usss020326(datos, "eliminar");

                MessageBox.Show("Usuario eliminado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarDatos();
                LimpiarCampos();
            }
        }

        private void LimpiarCampos()
        {
            txtId.Text = "";
            txtUsuario.Text = "";
            txtClave.Text = "";
            txtConfirmarClave.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtUsuario.Focus();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (ds.Tables["usuarios"] != null && ds.Tables["usuarios"].Rows.Count > 0)
            {
                posicion = 0;
                MostrarDatos();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                MostrarDatos();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (ds.Tables["usuarios"] != null && posicion < ds.Tables["usuarios"].Rows.Count - 1)
            {
                posicion++;
                MostrarDatos();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (ds.Tables["usuarios"] != null && ds.Tables["usuarios"].Rows.Count > 0)
            {
                posicion = ds.Tables["usuarios"].Rows.Count - 1;
                MostrarDatos();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                posicion = e.RowIndex;
                MostrarDatos();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Botón de cerrar sesión para regresar al login
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Close();
        }
    }
}