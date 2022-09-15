using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TLOCKER_SYSTEM;

namespace View
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmArmario());
            FrmLogin login = new FrmLogin();
            login.ShowDialog();

            if (login.retorno)
            {
                Application.Run(new FrmPrincipal(login.usuarioretorno));
            }

        }
    }
}
