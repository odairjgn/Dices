using System;
using System.Windows.Forms;

namespace Dices.Forms.Ucs
{
    public delegate void OkClicadoDelegate(int valor);

    public partial class frDCustom : Form
    {
        public event OkClicadoDelegate OkClicado;

        public frDCustom()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            OnOkClicado(Convert.ToInt32(nudFaces.Value));
        }

        protected virtual void OnOkClicado(int valor)
        {
            OkClicado?.Invoke(valor);
        }

        private void frDCustom_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Visible = false;
        }
    }
}
