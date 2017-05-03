using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Dices.Extentions;
using Dices.Forms.Inputs;
using Dices.Forms.Ucs;
using Dices.UserControls.Inicio;
using DicesApp.Extentions;
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
        private ucHistorico ucHistorico = new ucHistorico();

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
                rbtnHistorico_Click(sender, e);
            }
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            var valor = ProcessadorDeFormulas.Sortear(4);
            ucShowNumber.SetUserControl(pnPrincipal);
            ucShowNumber.SetValue(valor);
            Global.Historico.Add(new Historico("D4", valor, ""));
        }

        private void btnD6_Click(object sender, EventArgs e)
        {
            var valor = ProcessadorDeFormulas.Sortear(6);
            ucShowNumber.SetUserControl(pnPrincipal);
            ucShowNumber.SetValue(valor);
            Global.Historico.Add(new Historico("D6", valor, ""));
        }

        private void btnD8_Click(object sender, EventArgs e)
        {
            var valor = ProcessadorDeFormulas.Sortear(8);
            ucShowNumber.SetUserControl(pnPrincipal);
            ucShowNumber.SetValue(valor);
            Global.Historico.Add(new Historico("D8", valor, ""));
        }

        private void btnD10_Click(object sender, EventArgs e)
        {
            var valor = ProcessadorDeFormulas.Sortear(10);
            ucShowNumber.SetUserControl(pnPrincipal);
            ucShowNumber.SetValue(valor);
            Global.Historico.Add(new Historico("D10", valor, ""));
        }

        private void btnD12_Click(object sender, EventArgs e)
        {
            var valor = ProcessadorDeFormulas.Sortear(12);
            ucShowNumber.SetUserControl(pnPrincipal);
            ucShowNumber.SetValue(valor);
            Global.Historico.Add(new Historico("D12", valor, ""));
        }

        private void btnD100_Click(object sender, EventArgs e)
        {
            var valor = ProcessadorDeFormulas.Sortear(100);
            ucShowNumber.SetUserControl(pnPrincipal);
            ucShowNumber.SetValue(valor);
            Global.Historico.Add(new Historico("D10", valor, ""));
        }

        private void btn10p_Click(object sender, EventArgs e)
        {
            new frmNaoImplementado().ShowDialog();
        }

        private void btnDOutros_Click(object sender, EventArgs e)
        {
            new frmNaoImplementado().ShowDialog();
        }

        private void mSobre_Click(object sender, EventArgs e)
        {

        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuAjuda_Click(object sender, EventArgs e)
        {
            new frmNaoImplementado().ShowDialog();
        }

        private void menuTrocar_Click(object sender, EventArgs e)
        {
            new frmNaoImplementado().ShowDialog();
        }

        private void menuImportExport_Click(object sender, EventArgs e)
        {
            new frmNaoImplementado().ShowDialog();
        }

        private void menuFeedbak_Click(object sender, EventArgs e)
        {
            new frmNaoImplementado().ShowDialog();
        }

        private void rbtnHistorico_Click(object sender, EventArgs e)
        {
            ucHistorico.SetUserControl(pnPrincipal);
            ucHistorico.Atualizar();
        }

        private void rbtnLimpar_Click(object sender, EventArgs e)
        {
            ucHistorico.SetUserControl(pnPrincipal);
            ucHistorico.Limpar();
            ucHistorico.Atualizar();
        }

        private void rbtnExpTxt_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() {Filter = "*.txt|*.txt"};

            if(sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                ExportadorTexto.ExportarTXT(Global.Historico, sfd.FileName);
                MessageBox.Show("Salvo com sucesso!");
            }
            catch (Exception exception)
            {
                exception.Show();
            }
        }

        private void rbtnExpCSV_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "*.csv|*.csv" };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                ExportadorTexto.ExportarCSV(Global.Historico, sfd.FileName);
                MessageBox.Show("Salvo com sucesso!");
            }
            catch (Exception exception)
            {
                exception.Show();
            }
        }

        private void rbtnXML_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "*.xml|*.xml" };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                var xmls = new SerializadorXML<List<Historico>>();
                xmls.SerializarXml(Global.Historico, new FileInfo(sfd.FileName));
                MessageBox.Show("Salvo com sucesso!");
            }
            catch (Exception exception)
            {
                exception.Show();
            }
        }

        private void rbtnJson_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "*.json|*.json" };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                SerializadorJson.SerializarJson(Global.Historico, new FileInfo(sfd.FileName));
                MessageBox.Show("Salvo com sucesso!");
            }
            catch (Exception exception)
            {
                exception.Show();
            }
        }
    }
}
