using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace DicesCore.Entidades
{
    public class Formula : Base
    {
        [MaxLength(80)]
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Expressao { get; set; }

        [MaxLength(12)]
        public string CorTexto { get; set; }

        [MaxLength(12)]
        public string CorFundo { get; set; }

        public Keys Atalho { get; set; }

        public byte[] Icone { get; set; }

        public virtual Aventura Aventura { get; set; }

        public virtual Personagem Personagem { get; set; }

        protected Formula()
        {
            
        }
    }
}
