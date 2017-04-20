using System;
using System.Windows.Forms;
using DicesApp.Extentions;
using DicesApp.Servicos;
using DicesCore;
using DicesCore.Contexto;

namespace Dices.Forms
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            lbVersao.Text = GerenciadorDeAmbiente.VersaoString();
        }

        private void TaskInicializacao()
        {
            try
            {
                ReportProgress("Inicializando banco de dados...");
                Global.Contexto = new DicesContext(Global.DbFile);

                ReportProgress("Carregando Fontes...");
                GerenciadorDeAmbiente.CarregarFontes();

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                ex.Show();
                DialogResult = DialogResult.Cancel;
            }
        }

        private void ReportProgress(string status)
        {
            Invoke(new Action(() => { lbTask.Text = status; }));
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            segundoplano.RunWorkerAsync();
        }

        private void segundoplano_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            TaskInicializacao();
        }

        private void segundoplano_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Close();
        }
    }
}
