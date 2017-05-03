using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;

namespace DicesApp.Servicos
{
    public static class GerenciadorDeFontesCustomizadas
    {
        public const string LCDFonte = "DJB Get Digital.ttf";
        public const string LEDFonte = "LEDCalculator.ttf";

        private static readonly PrivateFontCollection Fontes = new PrivateFontCollection();

        private static readonly Dictionary<string, int> FontList = new Dictionary<string, int>()
        {
            {LCDFonte, 0},
            {LEDFonte, 1 }
        };

        public static void LoadFontes()
        {
            try
            {
                foreach (var fname in FontList.Select(f => Path.Combine(Environment.CurrentDirectory, "Fontes", f.Key)))
                {
                    Fontes.AddFontFile(fname);
                }
            }
            catch { }
        }

        public static Font GetFont(string name, Font baseFont)
        {
            try
            {
                return new Font(Fontes.Families[FontList[name]], baseFont.Size, baseFont.Style);
            }
            catch
            {
                return baseFont;
            }
        }
    }
}
