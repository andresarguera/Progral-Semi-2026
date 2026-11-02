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
    public partial class frmLogin : Form
    {
        // Instancia de la clase Conexion unificada
        Conexion objConexion = new Conexion();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Configuración inicial del formulario si lo requieres
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            // 1. Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            // 2. Verificar las credenciales directamente en la base de datos con el método ValidarLogin
            if (objConexion.ValidarLogin(usuario, clave))
            {
                MessageBox.Show("¡Acceso concedido al sistema!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ocultar el formulario de login y abrir el mantenimiento de usuarios del parcial
                this.Hide();
                frm_usuario formularioUsuarios = new frm_usuario();
                formularioUsuarios.ShowDialog();

                // Al cerrar el formulario de usuarios, cerramos la aplicación por completo
                this.Close();
            }
            else
            {
                // Denegar acceso si las credenciales no existen o son incorrectas
                MessageBox.Show("Acceso denegado: Usuario o contraseña incorrectos.", "Error de Autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClave.Clear();
                txtUsuario.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación por completo
            Application.Exit();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }
    }
}