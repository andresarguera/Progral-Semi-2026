using System;
using System.Windows.Forms;

namespace miPrimeraAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConfigurarTabla();
        }

        private void ConfigurarTabla()
        {
            // Configurar las columnas del DataGridView
            dgvDeducciones.Columns.Clear();
            dgvDeducciones.Columns.Add("colNombre", "Empleado");
            dgvDeducciones.Columns.Add("colSueldoBase", "Sueldo Base");
            dgvDeducciones.Columns.Add("colISSS", "ISSS (3%)");
            dgvDeducciones.Columns.Add("colAFP", "AFP (7.25%)");
            dgvDeducciones.Columns.Add("colRenta", "ISR (Renta)");
            dgvDeducciones.Columns.Add("colTotalDeducciones", "Total Deducciones");
            dgvDeducciones.Columns.Add("colSueldoNeto", "Sueldo Neto");

            // Formato de moneda para columnas numéricas
            for (int i = 1; i < dgvDeducciones.Columns.Count; i++)
            {
                dgvDeducciones.Columns[i].DefaultCellStyle.Format = "C2";
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre del empleado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtSueldoBase.Text, out double sueldoBase) || sueldoBase <= 0)
            {
                MessageBox.Show("Ingrese un sueldo base válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Cálculo de ISSS (3% con tope máximo de $30.00)
            double isss = sueldoBase * 0.03;
            if (isss > 30.00)
            {
                isss = 30.00;
            }

            // 2. Cálculo de AFP (7.25%)
            double afp = sueldoBase * 0.0725;

            // 3. Base imponible para la Renta (Sueldo Base - ISSS - AFP)
            double baseImponible = sueldoBase - isss - afp;

            // 4. Cálculo de ISR (Tramos Ley de Impuesto sobre la Renta SV)
            double isr = 0.0;

            if (baseImponible <= 472.00)
            {
                isr = 0.0; // Tramo I: Exento
            }
            else if (baseImponible <= 895.24)
            {
                isr = ((baseImponible - 472.00) * 0.10) + 17.67; // Tramo II
            }
            else if (baseImponible <= 2038.10)
            {
                isr = ((baseImponible - 895.24) * 0.20) + 60.00; // Tramo III
            }
            else
            {
                isr = ((baseImponible - 2038.10) * 0.30) + 288.57; // Tramo IV
            }

            // 5. Totales
            double totalDeducciones = isss + afp + isr;
            double sueldoNeto = sueldoBase - totalDeducciones;

            // Agregar fila al DataGridView
            dgvDeducciones.Rows.Add(
                txtNombre.Text,
                sueldoBase,
                isss,
                afp,
                isr,
                totalDeducciones,
                sueldoNeto
            );
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtSueldoBase.Clear();
            txtNombre.Focus();
        }
    }
}