using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace busqueda_RFC
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
       [STAThread]

        static void Main()
        {
            bool flag = true;
            verificarProceso(ref flag);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (flag == true) { Application.Run(new inicio()); }
        }

       // VERIFICA QUE EL PROCESO MODULO VERIFICADOR NO ESTE EJECUTANTOSE MAS DE UNA VEZ 

        static private void verificarProceso(ref bool flag)
        {
            int contador = 0;
            System.Diagnostics.Process[] procesos = System.Diagnostics.Process.GetProcesses();
            foreach (System.Diagnostics.Process proceso in procesos)
            {
                if (proceso.ProcessName == "Modulo Verificador")
                {
                    if (contador == 1)
                    {
                        MessageBox.Show("No es posible ejecutar mas de una vez la aplicacion",
                                        "", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        flag = false;
                    }
                    contador++;
                }
            }
        } 
    }
}
