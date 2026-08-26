using System;
using System.Windows.Forms;

namespace miPrimeraAplicacion
{
    public partial class FrmPaciente : Form
    {
        private Form1 formularioPrincipal;

        public FrmPaciente(Form1 formPrincipal)
        {
            InitializeComponent();

            formularioPrincipal = formPrincipal;

            btnGuardar.Click -= btnGuardar_Click;
            btnGuardar.Click += btnGuardar_Click;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show(
                    "Ingrese el nombre del paciente.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtNombre.Focus();
                return;
            }

            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show(
                    "Ingrese una edad válida.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEdad.Focus();
                return;
            }

            if (edad < 0 || edad > 120)
            {
                MessageBox.Show(
                    "Ingrese una edad entre 0 y 120.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEdad.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                MessageBox.Show(
                    "Ingrese el motivo de consulta.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtMotivo.Focus();
                return;
            }

            Form1.Prioridad prioridad;

            if (chkCita.Checked)
            {
                prioridad = Form1.Prioridad.CitaPrevia;
            }
            else if (
                chkEmergencia.Checked ||
                chkInconsciente.Checked ||
                chkEmbarazo.Checked ||
                chkMenor5.Checked ||
                chkMenor10.Checked)
            {
                prioridad = Form1.Prioridad.Emergencia;
            }
            else if (
                chkMenor1.Checked ||
                chkAdultoMayor.Checked ||
                chkENT.Checked ||
                chkDiscapacidad.Checked ||
                chkPreventiva.Checked)
            {
                prioridad = Form1.Prioridad.Urgencia;
            }
            else
            {
                prioridad = Form1.Prioridad.DemandaEspontanea;
            }

            Form1.Paciente nuevoPaciente = new Form1.Paciente
            {
                Nombre = txtNombre.Text.Trim(),
                Edad = edad,
                MotivoConsulta = txtMotivo.Text.Trim(),
                NivelPrioridad = prioridad
            };

            formularioPrincipal.AgregarPaciente(nuevoPaciente);

            string textoPrioridad;

            switch (prioridad)
            {
                case Form1.Prioridad.Emergencia:
                    textoPrioridad = "PRIORIDAD I - ROJO";
                    break;

                case Form1.Prioridad.Urgencia:
                    textoPrioridad = "PRIORIDAD II - AMARILLO";
                    break;

                case Form1.Prioridad.DemandaEspontanea:
                    textoPrioridad = "PRIORIDAD III - VERDE";
                    break;

                case Form1.Prioridad.CitaPrevia:
                    textoPrioridad = "CITA PREVIA";
                    break;

                default:
                    textoPrioridad = "";
                    break;
            }

            lblResultado.Text =
                $"Paciente: {nuevoPaciente.Nombre}" +
                Environment.NewLine +
                $"Clasificación: {textoPrioridad}";

            MessageBox.Show(
                $"Paciente registrado correctamente.\n\n" +
                $"Paciente: {nuevoPaciente.Nombre}\n" +
                $"Prioridad: {textoPrioridad}",
                "Registro exitoso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtMotivo.Clear();

            chkCita.Checked = false;
            chkEmergencia.Checked = false;
            chkInconsciente.Checked = false;
            chkEmbarazo.Checked = false;
            chkMenor5.Checked = false;
            chkMenor10.Checked = false;
            chkMenor1.Checked = false;
            chkAdultoMayor.Checked = false;
            chkENT.Checked = false;
            chkDiscapacidad.Checked = false;
            chkPreventiva.Checked = false;

            lblResultado.Text = "";

            txtNombre.Focus();
        }
    }
}