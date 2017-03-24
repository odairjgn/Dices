using System.ComponentModel.DataAnnotations;

namespace DicesCore.Entidades
{
    public class Personagem : Base
    {
        [MaxLength(200)]
        [Required]
        public string Nome { get; set; }

        public string Biografia { get; set; }


        public virtual Aventura Aventura { get; set; }

        protected Personagem()
        {
            
        }
    }
}
