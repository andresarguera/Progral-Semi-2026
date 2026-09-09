using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimeaAplicacion
{
    public partial class Form1 : Form
    {
        private object objEsta;

        public Form1()
        {
            InitializeComponent();
        }
        double media(double[] serie)
        {
            double suma = 0;
            for (int i = 0; i < serie.Length; i++)
            {
                suma += serie[i];
            }
            double media = suma / serie.Length;
            return media;
        }
        double varianza(double[] serie, double media)
        {
            return serie.Average(n => Math.Pow(n - media, 2));
        }
        double desviacionTipica(double[] serie, double media)
        {
            return Math.Sqrt(varianza(serie, media));
        }
        double armonica(double[] serie)
        {
            double m = media(miSerie);
            double m = objEsta.media(miSerie);

            ltsValores.Items.Add("La media es: " + m);
            ltsValores.Items.Add("La desviacion estandar: " + objEsta.varianza(miSerie, m));
            ltsValores.Items.Add("La desviacion tipica: " + objEsta.desviacionTipica(miSerie, m));
            ltsValores.Items.Add("La media armonica: " + objEsta.armonica(miSerie));
        }
        ltsValores.Items.Clear();
            //txtSerie.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}