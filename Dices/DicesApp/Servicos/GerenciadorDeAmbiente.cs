using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;

namespace DicesApp.Servicos
{
    public class GerenciadorDeAmbiente
    {
        public static string VersaoString()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        public static void CarregarFontes()
        {
            DicesCore.Global.FontesValidas = new InstalledFontCollection().Families.Where(f => f.IsStyleAvailable(FontStyle.Regular)).Select(f => f.Name);
        }
    }
}
