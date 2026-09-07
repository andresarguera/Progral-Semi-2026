using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace miPrimeraAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigurarFormulario();
        }

        private void ConfigurarFormulario()
        {
            // Límites del Selector de Meses
            txtMeses.Minimum = 1;
            txtMeses.Maximum = 120; // Hasta 10 años
            txtMeses.Value = 12;    // Valor inicial por defecto: 1 año

            // Configurar DataGridView
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResultados.ReadOnly = true;
            dgvResultados.AllowUserToAddRows = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int totalMeses = (int)txtMeses.Value;
            DataTable tabla = new DataTable();

            // Definición de columnas
            tabla.Columns.Add("N° Mes", typeof(int));
            tabla.Columns.Add("Nombre del Mes", typeof(string));
            tabla.Columns.Add("Monto Mensual ($)", typeof(string));
            tabla.Columns.Add("Acumulado ($)", typeof(string));

            // Simulación de ingreso base o monto acumulativo constante (en USD para El Salvador)
            decimal montoMensual = 408.80m; // Salario mínimo sector comercio/servicios en SV
            decimal acumulado = 0;

            // Configurar formato regional para El Salvador ($ USD)
            CultureInfo culturaSV = new CultureInfo("es-SV");

            DateTime fechaInicio = DateTime.Now;

            for (int i = 1; i <= totalMeses; i++)
            {
                acumulado += montoMensual;

                // Obtener nombre del mes incremental
                string nombreMes = fechaInicio.AddMonths(i - 1).ToString("MMMM yyyy", culturaSV);

                tabla.Rows.Add(
                    i,
                    char.ToUpper(nombreMes[0]) + nombreMes.Substring(1),
                    montoMensual.ToString("C2", culturaSV),
                    acumulado.ToString("C2", culturaSV)
                );
            }

            // Asignar los datos al DataGridView
            dgvResultados.DataSource = tabla;

            
            lblTotal.Text = $"Total Acumulado en {totalMeses} meses: {acumulado.ToString("C2", culturaSV)}";
        }
    }
}