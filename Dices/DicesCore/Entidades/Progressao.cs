using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DicesCore.Entidades
{
    public class Progressao : Base
    {
        [Required]
        [MaxLength(100)]
        public string Descricao { get; set; }

        [Required]
        public string ProgressaoData { get; set; }

        [NotMapped]
        public Dictionary<double, double> Dados
        {
            get
            {
                if (string.IsNullOrEmpty(ProgressaoData)) return null;

                return ProgressaoData.Split(';')
                    .Select(a => a.Split('|'))
                    .Select(i => new {Referencia = double.Parse(i[0]), Valor = double.Parse(i[1])})
                    .ToDictionary(k => k.Referencia, v => v.Valor);
            }
            set
            {
                if (value == null)
                {
                    ProgressaoData = null;
                    return;
                }

                ProgressaoData = string.Join(";", value.Select(p => string.Join("|", p.Key, p.Value)).ToList());
            }
        }

        [InverseProperty("ProgressoesAfetadas")]
        public virtual Variavel ValorReferenciaProgressao { get; set; }

        [InverseProperty("AfetadaPor")]
        public virtual Variavel ValorBase { get; set; }
    }
}
