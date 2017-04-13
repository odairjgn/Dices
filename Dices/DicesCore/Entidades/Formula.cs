using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Forms;
using DicesCore.Extensoes;
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

        [Column(TypeName = "NTEXT")]
        [MaxLength]
        public string Icone { get; set; }

        [NotMapped]
        public byte[] IconeBytes
        {
            get { return Icone.GetByteArrayFromB64(); }
            set { Icone = value.GetB64FromByteArray(); }
        }


        public virtual Aventura Aventura { get; set; }

        public virtual Personagem Personagem { get; set; }

        protected Formula()
        {
            
        }
    }
}
