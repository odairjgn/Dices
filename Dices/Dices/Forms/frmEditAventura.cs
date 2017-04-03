using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DicesCore.Entidades;

namespace Dices.Forms
{
    public partial class frmEditAventura : Form
    {
        private Aventura _aventura;
        private byte[] _dadosIcone;

        public Aventura Aventura => _aventura;

        public frmEditAventura(Aventura aventura = null)
        {
            InitializeComponent();
            _aventura = aventura;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitulo.Text.Trim()))
            {
                MessageBox.Show("O campo 'Título' é obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (_aventura != null)
            {
                _aventura.Titulo = txtTitulo.Text;
                _aventura.Descricao = txtTitulo.Text;
                _aventura.Icone = _dadosIcone;
            }
            else
            {
                _aventura = new Aventura(txtTitulo.Text, txtDesc.Text, DateTime.Now, _dadosIcone);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmEditAventura_Load(object sender, EventArgs e)
        {
            if (_aventura != null)
            {
                txtTitulo.Text = _aventura.Titulo;
                txtDesc.Text = _aventura.Descricao;
                _dadosIcone = _aventura.Icone;

                if(_dadosIcone != null)
                    pbImg.Image = Image.FromStream(new MemoryStream(_dadosIcone));
            }
        }

        private void btnBuscaImg_Click(object sender, EventArgs e)
        {
            if (ofdImg.ShowDialog() != DialogResult.OK) return;

            var fi = new FileInfo(ofdImg.FileName);

            if (fi.Length > 4000)
            {
                MessageBox.Show("Favor selecionar um arquivo com menos de 4000 bytes!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            _dadosIcone = File.ReadAllBytes(fi.FullName);
            pbImg.Image = Image.FromStream(new MemoryStream(_dadosIcone));
        }

        private void btnRemoveImg_Click(object sender, EventArgs e)
        {
            _dadosIcone = null;
            pbImg.Image = null;
        }
    }
}
