﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DicesCore.ObjetosDeValor;

namespace DicesCore.Entidades
{
    public class NoteBook : Base
    {
        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        [Column(TypeName = "IMAGE")]
        public byte[] Icone { get; set; }

        public Cor CorTexto { get; set; }

        public Cor CorFundo { get; set; }

        public virtual ICollection<Pagina> Paginas { get; set; }

        protected NoteBook() { }
    }
}
