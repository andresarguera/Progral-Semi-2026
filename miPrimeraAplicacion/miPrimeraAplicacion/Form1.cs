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
                int edad = int.Parse(txtEdad.Text);
                String msg = "Ingresa tu edad";

                //if ternario
                msg = edad < 0 ? "Edad no valida" :
                    edad <= 2 ? "Eres un bebe" :
                    edad < 12 ? "Eres un niño" :
                    edad <= 17 ? "Eres un adolescente" :
                    edad < 65 ? "Eres un adulto" :
                    edad <= 80 ? "Eres un adulto mayor" :
                    edad <= 130 ? "Larga vida" : "Edad no valida";

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
        

        


      

        
  