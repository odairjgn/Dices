using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dices.Forms
{
    public partial class frmNaoImplementado : Form
    {
        public frmNaoImplementado()
        {
            InitializeComponent();
        }

        private void frmNaoImplementado_Shown(object sender, EventArgs e)
        {
            new System.Media.SoundPlayer(Properties.Resources.gritopantera).Play();
        }
    }
}
