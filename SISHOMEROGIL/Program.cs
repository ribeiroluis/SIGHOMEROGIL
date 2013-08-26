using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SISHOMEROGIL.Administrador;
using SISHOMEROGIL.Recepcao;
using SISHOMEROGIL.Acolhimento;
using SISHOMEROGIL.Especialidades.Interface;

namespace SISHOMEROGIL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            //Application.Run(new frmTelaSplash());
            Application.Run(new frmAutoCusto());
            //Application.Run(new frmEscolheDia());
        }
    }
}
