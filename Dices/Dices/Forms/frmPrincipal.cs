using System.Linq;
using System.Windows.Forms;
using Dices.Forms.Inputs;
using DicesCore.Contexto;
using DicesCore.Entidades;

namespace Dices.Forms
{
    public partial class frmPrincipal : Form
    {
        private Repositorio<Aventura> _aventuraRepositorio;

        private Aventura _aventura;

        public frmPrincipal(int idAventura)
        {
            InitializeComponent();
            _aventuraRepositorio = new Repositorio<Aventura>(DicesApp.Global.Contexto);
            _aventura = _aventuraRepositorio.Get(idAventura);
        }

        private void frmPrincipal_Load(object sender, System.EventArgs e)
        {
            Text = $"Dices: {_aventura.Titulo}";
        }

        
        private void toolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Any(f => f is frmCalc))
            {
                var form = Application.OpenForms.Cast<Form>().First(f => f is frmCalc);
                form.Focus();
                return;
            }

            new frmCalc().Show();
        }
    }
}
