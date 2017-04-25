using System;
using System.ComponentModel;

namespace DicesCore.ObjetosDeValor
{
    public class Historico
    {
        [DisplayName("Data & Hora")]
        public DateTime DataHora { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Detalhes")]
        public string Detalhes { get; set; }

        [DisplayName("Valor")]
        public double Valor { get; set; }

        public Historico()
        {
            
        }

        public Historico(string descricao, double valor, string detalhes)
        {
            DataHora = DateTime.Now;
            Descricao = descricao;
            Detalhes = detalhes;
            Valor = valor;
        }
    }
}
