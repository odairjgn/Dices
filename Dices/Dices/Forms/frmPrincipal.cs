using System.Windows.Forms;
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
            _aventuraRepositorio = new Repositorio<Aventura>(Program.Contexto);
            _aventura = _aventuraRepositorio.Get(idAventura);
        }

        private void frmPrincipal_Load(object sender, System.EventArgs e)
        {
            Text = $"Dices: {_aventura.Titulo}";
        }
    }
}
