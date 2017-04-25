using System;
using System.Linq;
using System.Windows.Forms;
using Dices.Extentions;
using Dices.Forms.Inputs;
using Dices.UserControls.Inicio;
using DicesApp.Servicos;
using DicesCore;
using DicesCore.Contexto;
using DicesCore.Entidades;
using DicesCore.ObjetosDeValor;

namespace Dices.Forms
{
    public partial class frmPrincipal : Form
    {
        private Repositorio<Aventura> _aventuraRepositorio;

        private Aventura _aventura;

        private ucShowNumber ucShowNumber = new ucShowNumber();

        public frmPrincipal(int idAventura)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            _aventuraRepositorio = new Repositorio<Aventura>(Global.Contexto);
            _aventura = _aventuraRepositorio.Get(idAventura);
            mainMenu.Dock = DockStyle.Fill;
        }

        private void frmPrincipal_Load(object sender, System.EventArgs e)
        {
            Text = $"Dices: {_aventura.Titulo}";
        }


        private void calc_Click(object sender, System.EventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Any(f => f is frmCalc))
            {
                var form = Application.OpenForms.Cast<Form>().First(f => f is frmCalc);
                form.Focus();
                return;
            }

            new frmCalc().Show();
        }

        private void btnD20_Click(object sender, EventArgs e)
        {
            var valor = ProcessadorDeFormulas.Sortear(20);
            ucShowNumber.SetUserControl(pnPrincipal);
            ucShowNumber.SetValue(valor);
            Global.Historico.Add(new Historico("D20", valor, ""));
        }

        private void mainMenu_ActiveTabChanged(object sender, EventArgs e)
        {
            if (mainMenu.ActiveTab == rtbHistorico)
            {
                
            }
        }
    }
}
