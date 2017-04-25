using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DicesCore.Entidades
{
    public class Variavel : Base
    {
        [Required]
        [MaxLength(20)]
        public string Key { get; set; }

        public double Value { get; set; }

        public virtual Aventura Aventura { get; set; }
        public virtual Personagem Personagem { get; set; }

        public virtual ICollection<Progressao> ProgressoesAfetadas { get; set; }
        
        public virtual ICollection<Progressao> AfetadaPor { get; set; }

        protected Variavel()
        {
            
        }
    }
}
