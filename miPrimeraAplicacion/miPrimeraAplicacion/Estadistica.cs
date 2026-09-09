using miPrimeaAplicacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miPrimeraAplicacion
{
    internal class Estadistica
    {
    }
}
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

    ltsValores.Items.Add("La media es: " + m);
    ltsValores.Items.Add("La desviacion estandar: " + varianza(miSerie, m));
    ltsValores.Items.Add("La desviacion tipica: " + desviacionTipica(miSerie, m));
    ltsValores.Items.Add("La media armonica: " + armonica(miSerie));
}