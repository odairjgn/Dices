using System;
using System.Drawing;
using System.Windows.Forms;
using Dices.Forms.Ucs;
using DicesApp.ObjetosDeValor;
using DicesCustomControls.Componentes;
using DicesCustomControls.Extentions;

namespace Dices.Forms.Inputs
{
    public partial class FrmCalc : Form
    {
        private DropDownProvider _dpDx;
        private ucDx _ucDx;


        public FrmCalc()
        {
            InitializeComponent();

            _ucDx = new ucDx();
            _dpDx = new DropDownProvider(_ucDx, btnDx);
        }

        private bool _errolabel;
        private bool ErrorLabel
        {
            get { return _errolabel; }
            set
            {
                _errolabel = value;

                if (_errolabel)
                {
                    lbResult.Font = new Font(new FontFamily("Microsoft Sans Serif"), 9, FontStyle.Italic);
                    lbResult.ForeColor = Color.Red;
                }
                else
                {
                    lbResult.Font = new Font(new FontFamily("Microsoft Sans Serif"), 30, FontStyle.Bold);
                    lbResult.ForeColor = Color.Navy;
                }
            }
        }

        private void btnDx_Click(object sender, EventArgs e)
        {
            _dpDx.ClickDropDown();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();

            if (!txtInput.Focused)
                txtInput.Focus();
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtInput.TextLength > 0 && txtInput.SelectionStart == 1)
            {
                txtInput.Text = txtInput.Text.Substring(1);
                txtInput.Select(0, 0);

                if (!txtInput.Focused)
                    txtInput.Focus();
            }
            else
            {
                txtInput.Backspace();
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtInput.InsertText(".");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtInput.InsertText("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtInput.InsertText("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtInput.InsertText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtInput.InsertText("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtInput.InsertText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtInput.InsertText("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtInput.InsertText("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtInput.InsertText("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtInput.InsertText("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtInput.InsertText("9");
        }

        private void btnRigth_Click(object sender, EventArgs e)
        {
            txtInput.MoveCaretRight();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            txtInput.MoveCaretLeft();
        }

        private void btnAbreParenteses_Click(object sender, EventArgs e)
        {
            txtInput.InsertText("(");
        }

        private void btnFecharParenteses_Click(object sender, EventArgs e)
        {
            txtInput.InsertText(")");
        }

        private void btnDivid_Click(object sender, EventArgs e)
        {
            txtInput.InsertText("/");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            txtInput.InsertText("*");
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            txtInput.InsertText("-");
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            txtInput.InsertText("+");
        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            try
            {
                var exp = new Expressao(txtInput.Text);

                string saida;
                ErrorLabel = !exp.ProcessarCalc(out saida);

                lbResult.Text = saida;
            }
            catch (Exception ex)
            {
                ErrorLabel = true;
                lbResult.Text = ex.Message;
            }
        }
    }
}
