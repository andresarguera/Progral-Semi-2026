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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola chicosss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;
            num1 = double.Parse(txtNum1.Text); //txtNum1.Text > cadena="5" => 5.0
            num2 = double.Parse(txtNum2.Text);

            resultado = num1 + num2;

            lblRespuesta.Text = "Respuesta: " + resultado.ToString();
        }
    }
}
