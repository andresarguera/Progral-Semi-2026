using System;
using System.Globalization;
using System.Windows.Forms;

namespace miPrimeraAplicacion
{
    public partial class Form1 : Form
    {
        String[][] etiquetas = { new[] { "Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tarea", "Manzana", "Hectárea" } };
        Double[][] valores = { new[] { 0.09290304, 0.698739, 0.83612736, 1.0, 437.5, 6988.96, 10000.0 } };

        private int opcion = 0;

        public Form1()
        {
            InitializeComponent();

            btnCalcular.Click += btnCalcular_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboDe.Items.Clear();
            cboA.Items.Clear();

            cboDe.Items.AddRange(etiquetas[opcion]);
            cboA.Items.AddRange(etiquetas[opcion]);

            cboDe.SelectedIndex = 0;
            cboA.SelectedIndex = 3;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double cantidad;

            if (!double.TryParse(txtCantidad.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out cantidad))
            {
                MessageBox.Show("Ingrese un valor numérico válido.", "Dato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return;
            }

            if (cantidad < 0)
            {
                MessageBox.Show("El área no puede ser negativa.", "Dato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return;
            }

            if (cboDe.SelectedIndex == -1 || cboA.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la unidad de origen y destino.", "Faltan datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int de = cboDe.SelectedIndex;
            int a = cboA.SelectedIndex;

            double respuesta;

            if (de == 5 && a == 4)
            {
                respuesta = cantidad * 16;
            }
            else if (de == 4 && a == 5)
            {
                respuesta = cantidad / 16;
            }
            else
            {
                double metrosCuadrados = valores[opcion][de] * cantidad;
                respuesta = metrosCuadrados / valores[opcion][a];
            }

            lblRespuesta.Text = respuesta.ToString("N6");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            lblRespuesta.Text = "";
            cboDe.SelectedIndex = 0;
            cboA.SelectedIndex = 3;
            txtCantidad.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}