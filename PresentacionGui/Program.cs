using Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGui
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            InstitucionService service = new InstitucionService();
            if (service.ValidarExisteArchivo())
            {
                MessageBox.Show("No es posible  realizar el proceso de inscripcion, no se cuenta con el archivo de cupos.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                Application.Run(new Principal());
            }
           
        }
    }
}
