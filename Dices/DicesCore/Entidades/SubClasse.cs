using System.ComponentModel.DataAnnotations;

namespace DicesCore.Entidades
{
    public class SubClasse : Base
    {
        [Required]
        [MaxLength(50)]
        public string Nome { get; set; }

        public string Descricao { get; set; }


        public virtual Classe Classe { get; set; }

        protected SubClasse()
        {
            
        }
    }
}
