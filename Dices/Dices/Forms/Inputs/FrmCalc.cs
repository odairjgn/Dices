using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DicesApp.Interfaces;

namespace Dices.Forms.Inputs
{
    public partial class frmCalc : Form, IConfiguravel
    {
        public frmCalc()
        {
            InitializeComponent();
            AplicarConfiguracao();
        }

        public void AplicarConfiguracao()
        {
            TopMost = DicesCore.Global.Configuracao.ConfigCalculadora.JanelaFlutuante;
            Opacity = 0.01f * ((float)(int)DicesCore.Global.Configuracao.ConfigCalculadora.Opacidade);
        }
    }
}
