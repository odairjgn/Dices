using System;
using System.Text;
using System.Windows.Forms;

namespace DicesApp.Extentions
{
    public static class ExceptionExtentions
    {
        public static void Show(this Exception exception)
        {
            var texto = new StringBuilder();

            MessageBox.Show(texto.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
