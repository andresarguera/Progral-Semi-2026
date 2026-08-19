using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimeaAplicacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
          Metros, Cm, Pulgadas, Pies, Varas, Yardas, Km,Millas 
        Longitud
        Moneda
        Masa
        Volumen
        Almacenamiento
        Tiempo
         */
        String[][] etiquetas = {
            new string[]{"Metros", "Cm","Milimetro", "Micrómetro", "Nanometro", "Pulgadas", "Pies", "Varas", "Yardas", "Km","Millas", "Milla naútica"}, //Longitud
            new string[]{"Dolar", "Quetzal","Lempira","Cordobas","Colon CR", "soles", "Euros", "Yen", "Libra esterlina", "Real brasileño"},//Moneda
            new string[]{"Gramos", "Kilogramos", "Toneladas", "Libras", "Onzas", "Miligramos", "Quintales", "Stone", "Slug", "Carat"},//Masa
            new string[]{"Litros", "Mililitros", "Galones", "Pintas", "Barriles", "Onzas líquidas", "Decilitros", "Centilitros", "Pie Cubico", "Metros Cubicos"},//Volumen
            new string[]{"Bit", "Byte", "Kilobyte", "Megabyte", "Gigabyte", "Terabyte", "Petabyte", "Exabyte", "Zettabyte", "Yottabyte"},//Almacenamiento
            new string[]{ "Segundos", "Minutos", "Horas", "Días", "Semanas", "Meses", "Años", "Décadas", "Siglos", "Milisegundos"}//Tiempo

        };
        Double[][] valores = {
            new double[]{1, 100, 1000, 1e+6, 1e+9, 39.3701, 3.28084, 1.1963, 1.09361, 0.001, 0.000621371, 0.000539957},
            new double[]{1, 7.63, 26.81, 36.80, 449.23, 3.75, 0.92, 146.5, 0.74, 5.5},
            new double[]{1, 0.001, 1e-6, 0.000001, 0.00220462, 0.035274, 0.00001, 0.000157473, 0.0000685218, 0.2},
            new double[]{1, 1000, 0.264172, 2.11338, 0.00852, 33.814, 10, 100, 0.0353147, 0.001},
            new double[]{1, 8, 1024, 1048576, 1073741824, 1099511627776, 1.1259e+15, 1.1529e+18, 1.1806e+21, 1.2089e+24},
            new double[]{ 1, 0.0166667, 0.000277778, 1.1574e-5, 1.6534e-6, 3.8052e-7, 3.171e-8, 3.171e-9, 3.171e-10, 0.001}
        };
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            int de = cboDe.SelectedIndex, a = cboA.SelectedIndex, opcion = cboOpciones.SelectedIndex;
            double cantidad = Double.Parse(txtCantidad.Text);

            double respuesta = valores[opcion][a] / valores[opcion][de] * cantidad;

            lblRespuesta.Text = respuesta.ToString();
        }

        private void cboOpciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDe.Items.Clear();
            cboA.Items.Clear();

            //Asignamos los nuevos valores
            int opcion = cboOpciones.SelectedIndex;
            cboDe.Items.AddRange(etiquetas[opcion]);
            cboA.Items.AddRange(etiquetas[opcion]);
        }
    }
    }
