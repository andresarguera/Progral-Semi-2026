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
            try
            {
                int tabla = int.Parse(txtTabla.Text), i = 1;
                String msg = "";
                while (i <= 10)
                {
                    msg += $"{tabla} x {i} = {tabla * i}\n";
                    i++; // i= i+1
                }

                lblRespuesta.Text = msg;
            }
            catch (Exception)
            {
                lblRespuesta.Text = "Por favor ingrese la edad en numero entero";
            }
            }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }
    } 
            }
        

        


      

        
  