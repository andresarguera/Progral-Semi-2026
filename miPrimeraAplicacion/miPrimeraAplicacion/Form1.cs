using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace miPrimeraAplicacion
{
    public partial class Form1 : Form
    {
        public enum Prioridad
        {
            Emergencia = 1,
            Urgencia = 2,
            DemandaEspontanea = 3,
            CitaPrevia = 4
        }

        public class Paciente
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string MotivoConsulta { get; set; }
            public Prioridad NivelPrioridad { get; set; }
        }

        private List<Paciente> pacientes;

        public Form1()
        {
            InitializeComponent();

            pacientes = new List<Paciente>();

            ConfigurarDataGridView();

            btnRegistrar.Click -= btnRegistrar_Click;
            btnRegistrar.Click += btnRegistrar_Click;

            btnAtender.Click -= btnAtender_Click;
            btnAtender.Click += btnAtender_Click;

            dataGridView1.CellFormatting -= dataGridView1_CellFormatting;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.AllowUserToDeleteRows = false;

            dataGridView1.RowHeadersVisible = false;

            dataGridView1.Columns.Add("Nombre", "Nombre del paciente");
            dataGridView1.Columns.Add("Edad", "Edad");
            dataGridView1.Columns.Add("Motivo", "Motivo de consulta");
            dataGridView1.Columns.Add("NivelPrioridad", "Prioridad");
        }

        public void AgregarPaciente(Paciente paciente)
        {
            pacientes.Add(paciente);
            MostrarPacientes();
        }

        private void MostrarPacientes()
        {
            dataGridView1.Rows.Clear();

            var pacientesOrdenados = pacientes
                .OrderBy(p => p.NivelPrioridad)
                .ToList();

            foreach (Paciente paciente in pacientesOrdenados)
            {
                int fila = dataGridView1.Rows.Add();

                dataGridView1.Rows[fila].Cells["Nombre"].Value =
                    paciente.Nombre;

                dataGridView1.Rows[fila].Cells["Edad"].Value =
                    paciente.Edad;

                dataGridView1.Rows[fila].Cells["Motivo"].Value =
                    paciente.MotivoConsulta;

                dataGridView1.Rows[fila].Cells["NivelPrioridad"].Value =
                    ObtenerTextoPrioridad(paciente.NivelPrioridad);
            }
        }

        private void dataGridView1_CellFormatting(
            object sender,
            DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 ||
                e.RowIndex >= dataGridView1.Rows.Count)
                return;

            string prioridad =
                dataGridView1.Rows[e.RowIndex]
                .Cells["NivelPrioridad"]
                .Value?.ToString();

            switch (prioridad)
            {
                case "Prioridad I - Emergencia":
                    dataGridView1.Rows[e.RowIndex]
                        .DefaultCellStyle.BackColor = Color.Red;

                    dataGridView1.Rows[e.RowIndex]
                        .DefaultCellStyle.ForeColor = Color.White;
                    break;

                case "Prioridad II - Urgencia":
                    dataGridView1.Rows[e.RowIndex]
                        .DefaultCellStyle.BackColor = Color.Yellow;

                    dataGridView1.Rows[e.RowIndex]
                        .DefaultCellStyle.ForeColor = Color.Black;
                    break;

                case "Prioridad III - Verde":
                    dataGridView1.Rows[e.RowIndex]
                        .DefaultCellStyle.BackColor = Color.LightGreen;

                    dataGridView1.Rows[e.RowIndex]
                        .DefaultCellStyle.ForeColor = Color.Black;
                    break;

                case "Cita Previa":
                    dataGridView1.Rows[e.RowIndex]
                        .DefaultCellStyle.BackColor = Color.LightBlue;

                    dataGridView1.Rows[e.RowIndex]
                        .DefaultCellStyle.ForeColor = Color.Black;
                    break;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmPaciente formularioPaciente = new FrmPaciente(this);
            formularioPaciente.ShowDialog();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            var siguiente = pacientes
                .OrderBy(p => p.NivelPrioridad)
                .FirstOrDefault();

            if (siguiente == null)
            {
                lblSiguiente.Text = "No hay pacientes en espera.";
                return;
            }

            lblSiguiente.Text =
                $"Atendiendo a: {siguiente.Nombre} - " +
                $"{ObtenerTextoPrioridad(siguiente.NivelPrioridad)}";

            pacientes.Remove(siguiente);

            MostrarPacientes();
        }

        private string ObtenerTextoPrioridad(Prioridad prioridad)
        {
            switch (prioridad)
            {
                case Prioridad.Emergencia:
                    return "Prioridad I - Emergencia";

                case Prioridad.Urgencia:
                    return "Prioridad II - Urgencia";

                case Prioridad.DemandaEspontanea:
                    return "Prioridad III - Verde";

                case Prioridad.CitaPrevia:
                    return "Cita Previa";

                default:
                    return "";
            }
        }
    }
}