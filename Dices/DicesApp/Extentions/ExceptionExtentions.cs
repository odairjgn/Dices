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

            texto.AppendLine($"{exception.Message}");
            texto.AppendLine();
            texto.AppendLine($"Local: {exception.TargetSite}");
            texto.AppendLine($"Fonte: {exception.Source}");
            texto.AppendLine($"Pilha: {exception.StackTrace}");

            MessageBox.Show(texto.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
