using System.Xml.Serialization;

namespace DicesCore.ObjetosDeValor.Configuracao
{
    public class Configuracao
    {
        public const long VersaoAtual = 1;

        [XmlAttribute]
        public long Versao { get; set; } = VersaoAtual;

        public ConfiguracaoCalculadora ConfigCalculadora { get; set; } = new ConfiguracaoCalculadora();

        public Configuracao()
        {
            
        }
    }
}
