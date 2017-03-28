using System;
using System.Windows.Forms;
using Dices.Forms.Ucs;
using DicesCustomControls.Componentes;

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

        private void btnDx_Click(object sender, EventArgs e)
        {
            _dpDx.ClickDropDown();
        }
    }
}
