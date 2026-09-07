using System;
using System.Windows.Forms;

namespace miPrimeraAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            if (double.TryParse(txtMetros.Text, out double metrosConsumidos) && metrosConsumidos >= 0)
            {
                double totalPagar = 0;
                double tarifaAlcantarillado = 0.10; 

           
                if (metrosConsumidos <= 10)
                {
                    totalPagar = 2.29; 
                }
                else if (metrosConsumidos <= 20)
                {
                    totalPagar = metrosConsumidos * 0.21;
                }
                else if (metrosConsumidos <= 30)
                {
                    totalPagar = metrosConsumidos * 0.32;
                }
                else
                {
                    totalPagar = metrosConsumidos * 0.60;
                }

                
                totalPagar += tarifaAlcantarillado;

               
                lblResultado.Text = $"Total a pagar: ${totalPagar:F2}";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de metros cúbicos válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMetros.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMetros.Clear();
            lblResultado.Text = "Total a pagar: $0.00";
            txtMetros.Focus();
        }
    }
}