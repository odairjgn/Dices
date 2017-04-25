using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using DicesApp.Servicos;

namespace Dices.UserControls.Inicio
{
    public partial class ucShowNumber : UserControl
    {
        public ucShowNumber()
        {
            InitializeComponent();

            lbValue.Font = GerenciadorDeFontesCustomizadas.GetFont(GerenciadorDeFontesCustomizadas.LCDFonte, lbValue.Font);
        }

        public void SetValue(object value)
        {
            new Thread(() =>
            {
                lbValue.Text = value.ToString();
                lbValue.ForeColor = Color.Red;
                Thread.Sleep(100);
                lbValue.ForeColor = Color.Black;
            }).Start();
        }
    }
}
