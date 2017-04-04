using System;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace DicesApp.ObjetosDeValor
{
    [XmlRoot]
    public class ConfigFile
    {
        [XmlAttribute]
        public string Versao { get; set; } = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public string WorkDirectory { get; set; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Dices");
    }
}
