using System;
using System.Windows.Forms;
using Dices.Forms;

namespace Dices
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            try
            {
                var files = AppDomain.CurrentDomain.SetupInformation.ActivationArguments.ActivationData;

                if (files != null)
                {
                    //Abrir File
                }
                
                var splash = new frmSplashScreen();
                if(splash.ShowDialog() != DialogResult.OK) return;
                

                var selAvt = new frmSelAventura();

                if (selAvt.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frmPrincipal(selAvt.Id));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro não tratado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
