using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DicesCore.Contexto;
using DicesCore.Entidades;

namespace Dices.Forms
{
    public partial class frmSelAventura : Form
    {
        private Repositorio<Aventura> _aventuraContexto;

        public frmSelAventura()
        {
            InitializeComponent();
            _aventuraContexto = new Repositorio<Aventura>(Program.Contexto);
        }

        private void frmSelAventura_Load(object sender, System.EventArgs e)
        {
            CarregarItens();
        }

        private void CarregarItens()
        {
            if(lvAventuras.LargeImageList == null)
                lvAventuras.LargeImageList = new ImageList() {ImageSize = new Size(50, 50)};

            lvAventuras.Clear();
            lvAventuras.LargeImageList.Images.Clear();

            var aventuras = _aventuraContexto.GetAll().ToList();


            foreach (var av in aventuras)
            {
                lvAventuras.LargeImageList.Images.Add(av.Id.ToString(), av.Icone == null ? Properties.Resources.DefaultAdventure : Image.FromStream(stream: new MemoryStream(av.Icone)));
                var lvi = new ListViewItem(av.Titulo);
                lvi.ImageKey = av.Id.ToString();
                lvi.ToolTipText = av.Descricao;
                lvAventuras.Items.Add(lvi);
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnNovo_Click(object sender, System.EventArgs e)
        {
            var frm = new frmEditAventura();

            if(frm.ShowDialog() != DialogResult.OK) return;

            var av = frm.Aventura;
            _aventuraContexto.AddOrUpdate(av);
            CarregarItens();
        }

        private void lvAventuras_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(lvAventuras.SelectedItems.Count <= 0) return;

            var key = lvAventuras.SelectedItems[0].ImageKey;
            MessageBox.Show(key);
        }
    }
}
