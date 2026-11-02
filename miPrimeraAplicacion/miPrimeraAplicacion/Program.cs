using miPrimeraAplicacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPrimeraAplicacion
{
    internal static class Program
    {
        

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // Cambia esto:
            // Application.Run(new login());

            // Por esto:
            Application.Run(new frmLogin());
        }
    }
}