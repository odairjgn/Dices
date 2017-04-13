using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DicesCore.Extensoes;
using DicesCore.ObjetosDeValor;

namespace DicesCore.Entidades
{
    public class NoteBook : Base
    {
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        [Column(TypeName = "NTEXT")]
        [MaxLength]
        public string Icone { get; set; }

        [NotMapped]
        public byte[] IconeBytes
        {
            get { return Icone.GetByteArrayFromB64(); }
            set { Icone = value.GetB64FromByteArray(); }
        }

        public Cor CorTexto { get; set; }

        public Cor CorFundo { get; set; }

        public virtual ICollection<Pagina> Paginas { get; set; }

        protected NoteBook() { }
    }
}
