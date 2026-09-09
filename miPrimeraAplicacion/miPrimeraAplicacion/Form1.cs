using System;
using System.Globalization;
using System.Windows.Forms;

namespace miPrimeraAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(txtEconomia.Text);
            double impuesto;
            if (monto <= 500)
                impuesto = 1.5;
            else if (monto <= 1000)
                impuesto = ((monto - 500.01) / 1000 * 3) + 1.5;

            else if (monto <= 2000)
                impuesto = ((monto - 1000.01) / 1000 * 3) + 3;

            else if (monto <= 3000)
                impuesto = ((monto - 2000.01) / 1000 * 3) + 6;

            else if (monto <= 6000)
                impuesto = ((monto - 3000.01) / 1000 * 2) + 9;

            else if (monto <= 18000)
                impuesto = ((monto - 8000.01) / 1000 * 2) + 15;

            else if (monto <= 30000)
                impuesto = ((monto - 18000.01) / 1000 * 2) + 39;

            else if (monto <= 60000)
                impuesto = ((monto - 30000.01) / 1000 * 1) + 63;

            else if (monto <= 100000)
                impuesto = ((monto - 60000.01) / 1000 * 0.8) + 93;

            else if (monto <= 200000)
                impuesto = ((monto - 100000.01) / 1000 * 0.7) + 125;

            else if (monto <= 300000)
                impuesto = ((monto - 200000.01) / 1000 * 0.6) + 195;

            else if (monto <= 400000)
                impuesto = ((monto - 300000.01) / 1000 * 0.45) + 255;

            else if (monto <= 500000)
                impuesto = ((monto - 400000.01) / 1000 * 0.4) + 300;

            else if (monto <= 1000000)
                impuesto = ((monto - 500000.01) / 1000 * 0.30) + 340;

            else
                impuesto = ((monto - 1000000.01) / 1000 * 0.18) + 490;

            lblTotal.Text = "Total impuestos: " + impuesto.ToString("N2");
        }
    }
}