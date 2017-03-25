using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DicesCore.Entidades
{
    public class Pagina : Base
    {
        [MaxLength(300)]
        public string Titulo { get; set; }

        public string Conteudo { get; set; }

        public DateTime UltimaAlteracao { get; set; }

        public DateTime Criacao { get; set; }

        public virtual NoteBook NoteBook { get; set; }

        public virtual ICollection<ItemMidia> Anexos { get; set; }

        protected Pagina() { }
    }
}
