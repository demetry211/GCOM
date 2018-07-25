using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CHM_CLIENT_APP
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        

        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(CLIENT_APP_PARAM.Fenetre_principale);
            }
            catch (InvalidCastException er)
            {

            }
        }
    }
}
