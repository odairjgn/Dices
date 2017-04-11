using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Forms;
using DicesCore.ObjetosDeValor;

namespace DicesCore.Entidades
{
    public class Formula : Base
    {
        [MaxLength(80)]
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Expressao { get; set; }
        
        public Cor CorTexto { get; set; }
        
        public Cor CorFundo { get; set; }

        public Keys Atalho { get; set; }

        [Column(TypeName = "IMAGE")]
        public byte[] Icone { get; set; }

        public virtual Aventura Aventura { get; set; }

        public virtual Personagem Personagem { get; set; }

        protected Formula()
        {
            
        }
    }
}
