using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace miPrimeraAplicacion
{
    public partial class Form1 : Form
    {
        // Estructura para almacenar los datos del dataset
        private class Estudiante
        {
            public int Compañero { get; set; }
            public double Edad { get; set; }
            public double Traslado { get; set; }
            public double Telefono { get; set; }
        }

        private List<Estudiante> listaEstudiantes;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Cargar las opciones del ComboBox
            cmbVariables.Items.Clear();
            cmbVariables.Items.Add("Edades");
            cmbVariables.Items.Add("Tiempo de Traslado");
            cmbVariables.Items.Add("Horas de Teléfono");
            cmbVariables.SelectedIndex = 0;

            // 2. Cargar Dataset con 64 estudiantes
            CargarDataset();
        }

        private void CargarDataset()
        {
            listaEstudiantes = new List<Estudiante>();

            // Arreglos con los 64 datos para cada variable
            int[] edades = {
                18, 19, 18, 20, 19, 18, 21, 19, 20, 18,
                22, 19, 18, 20, 21, 19, 18, 23, 19, 20,
                18, 19, 20, 21, 18, 22, 19, 18, 20, 19,
                21, 18, 19, 20, 24, 18, 19, 20, 21, 18,
                19, 18, 20, 22, 19, 21, 18, 19, 20, 18,
                25, 19, 18, 20, 21, 19, 18, 20, 19, 22,
                18, 20, 19, 18
            };

            double[] traslados = {
                25, 40, 30, 45, 35, 20, 50, 30, 25, 40,
                60, 35, 20, 45, 50, 30, 15, 75, 40, 35,
                25, 30, 45, 60, 20, 90, 40, 30, 50, 35,
                45, 25, 30, 40, 60, 20, 35, 45, 50, 25,
                30, 15, 40, 70, 35, 45, 20, 30, 50, 25,
                80, 40, 30, 45, 60, 35, 20, 40, 30, 65,
                25, 45, 35, 20
            };

            double[] telefonos = {
                6, 5, 7, 6, 8, 5, 7, 6, 5, 7,
                4, 6, 8, 5, 7, 6, 9, 3, 5, 6,
                7, 6, 5, 8, 9, 4, 6, 7, 5, 6,
                8, 7, 6, 5, 4, 9, 6, 5, 7, 8,
                6, 10, 5, 4, 7, 6, 8, 6, 5, 7,
                3, 6, 7, 5, 4, 6, 8, 5, 6, 4,
                7, 5, 6, 8
            };

            // Construir la lista de 64 registros
            for (int i = 0; i < 64; i++)
            {
                listaEstudiantes.Add(new Estudiante
                {
                    Compañero = i + 1,
                    Edad = edades[i],
                    Traslado = traslados[i],
                    Telefono = telefonos[i]
                });
            }

            // Mostrar el dataset completo en dgvDatos
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = listaEstudiantes;

            // Encabezados
            dgvDatos.Columns["Compañero"].HeaderText = "Compañero";
            dgvDatos.Columns["Edad"].HeaderText = "Edad";
            dgvDatos.Columns["Traslado"].HeaderText = "Traslado (min)";
            dgvDatos.Columns["Telefono"].HeaderText = "Teléfono (horas)";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbVariables.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una variable.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seleccionar la muestra adecuada
            List<double> muestra = new List<double>();

            switch (cmbVariables.SelectedIndex)
            {
                case 0: // Edades
                    muestra = listaEstudiantes.Select(x => x.Edad).ToList();
                    break;
                case 1: // Traslado
                    muestra = listaEstudiantes.Select(x => x.Traslado).ToList();
                    break;
                case 2: // Teléfono
                    muestra = listaEstudiantes.Select(x => x.Telefono).ToList();
                    break;
            }

            if (muestra.Count == 0) return;

            /*Calculos Estadisticos*/

            /*--Explicar con sus palabras la diferencia, de Desviación estándar y desviación típica--
             Son exactamente el mismo concepto estadístico; miden qué tan alejados están los datos respecto a la media y comparten la misma fórmula matemática
             La unica diferencia es gramatical y regional, ya que ya que "desviación estándar" es un calco del inglés (standard deviation) predominante en Latinoamérica,
             mientras que "desviación típica" es la denominación tradicional utilizada en España y textos clásicos.*/
            double media = muestra.Average();

           
            var datosOrdenados = muestra.OrderBy(NewMethod()).ToList();
            int n = datosOrdenados.Count;
            double mediana = (n % 2 == 0)
                ? (datosOrdenados[(n / 2) - 1] + datosOrdenados[n / 2]) / 2.0
                : datosOrdenados[n / 2];

           
            var gruposFrecuencia = muestra.GroupBy(x => x)
                                          .Select(g => new { Valor = g.Key, Conteo = g.Count() })
                                          .OrderByDescending(g => g.Conteo)
                                          .ToList();

            int maxFrecuencia = gruposFrecuencia.First().Conteo;
            var modas = gruposFrecuencia.Where(g => g.Conteo == maxFrecuencia).Select(g => g.Valor).ToList();
            string textoModa = (modas.Count == muestra.Count)
                ? "No hay moda"
                : string.Join(", ", modas);

            
            double sumaCuadradosDiferencia = muestra.Sum(val => Math.Pow(val - media, 2));
            double varianza = sumaCuadradosDiferencia / (n - 1);

           
            double desviacionEstandar = Math.Sqrt(varianza);

            
            double rango = muestra.Max() - muestra.Min();

         
            lstResultados.Items.Clear();
            lstResultados.Items.Add($"Media aritmética: {media:F2}");
            lstResultados.Items.Add($"Mediana: {mediana:F2}");
            lstResultados.Items.Add($"Moda: {textoModa}");
            lstResultados.Items.Add($"Varianza: {varianza:F2}");
            lstResultados.Items.Add($"Desviación estándar: {desviacionEstandar:F2}");
            lstResultados.Items.Add($"Desviación típica: {desviacionEstandar:F2}");
            lstResultados.Items.Add($"Rango: {rango:F2}");

            
            DataTable dtFrecuencias = new DataTable();
            dtFrecuencias.Columns.Add("Dato", typeof(double));
            dtFrecuencias.Columns.Add("Frecuencia", typeof(int));

            var tablaFrec = muestra.GroupBy(x => x)
                                   .OrderBy(g => g.Key)
                                   .Select(g => new { Dato = g.Key, Frecuencia = g.Count() });

            foreach (var item in tablaFrec)
            {
                dtFrecuencias.Rows.Add(item.Dato, item.Frecuencia);
            }

            dgvFrecuencias.DataSource = dtFrecuencias;
        }

        private static Func<double, double> NewMethod()
        {
            return n => n;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
            lstResultados.Items.Clear();
            dgvFrecuencias.DataSource = null;
            dgvFrecuencias.Rows.Clear();
            dgvFrecuencias.Columns.Clear();
            if (cmbVariables.Items.Count > 0)
            {
                cmbVariables.SelectedIndex = 0;
            }
            dgvDatos.ClearSelection();
        }
    }
}