using DicesCore.ObjetosDeValor.Configuracao.Enumeradores;

namespace DicesCore.ObjetosDeValor.Configuracao
{
    public class ConfiguracaoCalculadora
    {
        public bool JanelaFlutuante { get; set; } = false;
        public OpacidadeJanela Opacidade { get; set; } = OpacidadeJanela.Solida;

        public ConfiguracaoCalculadora()
        {
            
        }
    }
}
