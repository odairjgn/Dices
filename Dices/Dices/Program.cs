using System;
using System.Windows.Forms;
using Dices.Forms;
using DicesCore.Contexto;

namespace Dices
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
            try
            {

                Contexto = new DicesContext();

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

        public static DicesCore.Contexto.DicesContext Contexto { get; set; }
    }
}
