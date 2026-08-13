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
            int edad = int.Parse(txtEdad.Text);
            if (edad < 0)
            {
                lblRespuesta.Text = "Edad no valida";
            }
            else if (edad <= 2)
            {
                lblRespuesta.Text = "Eres un bebe";
            }
            else if (edad < 12)
            {
                lblRespuesta.Text = "Eres un niño";
            }
            else if (edad <= 17)
            {
                lblRespuesta.Text = "Eres un adolescente";
            }
            else if (edad < 65)
            {
                lblRespuesta.Text = "Eres un adulto";
            }
            else if (edad <= 80)
            {
                lblRespuesta.Text = "Eres un adulto mayor";
            }
            else if (edad <= 130)
            {
                lblRespuesta.Text = "Larga vidad";
            }
            else
            {
                lblRespuesta.Text = "Edad no valida";
            }
            }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grbOpciones_Enter(object sender, EventArgs e)
        {

        }

        private void rdbSuma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cboOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblNum1_Click(object sender, EventArgs e)
        {

        }
    }
}
