using System.ComponentModel.DataAnnotations;

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

        protected Variavel()
        {
            
        }
    }
}
