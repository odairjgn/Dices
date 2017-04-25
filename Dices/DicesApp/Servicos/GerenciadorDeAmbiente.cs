using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using DicesCore.ObjetosDeValor.Configuracao;

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

        public static void CarregarConfiguracao()
        {
            var ser = new SerializadorXML<Configuracao>();
            var conf = new FileInfo(DicesCore.Global.ConfigFile);

            if (!conf.Exists)
            {
                ser.SerializarXml(new Configuracao(), conf);
            }

            DicesCore.Global.Configuracao = ser.Deserializar(conf);
        }
    }
}
