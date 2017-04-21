using System.ComponentModel;

namespace DicesCore.ObjetosDeValor.Configuracao.Enumeradores
{
    public enum OpacidadeJanela
    {
        [Description("Sólida")]
        Solida = 100,

        [Description("75%")]
        P75 = 75,

        [Description("50%")]
        P50 = 50,

        [Description("25%")]
        P25 = 25
    }
}
