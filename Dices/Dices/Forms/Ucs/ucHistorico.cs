using System.Collections.Generic;
using System.Windows.Forms;
using DicesCore;
using DicesCore.ObjetosDeValor;

namespace Dices.Forms.Ucs
{
    public partial class ucHistorico : UserControl
    {
        public ucHistorico()
        {
            InitializeComponent();
            gridDados.AutoGenerateColumns = true;
        }

        public void Atualizar()
        {
            gridDados.DataSource = null;
            gridDados.DataSource = Global.Historico;
        }

        public void Limpar()
        {
            if(MessageBox.Show("Deseja mesmo limpar o Histórico?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            Global.Historico = new List<Historico>();
            gridDados.DataSource = null;
            gridDados.DataSource = Global.Historico;
        }
    }
}
