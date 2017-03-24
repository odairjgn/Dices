using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DicesCore.Entidades
{
    public class Aventura : Base
    {
        [Required]
        [MaxLength(200)]
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public DateTime Criacao { get; set; }

        public DateTime Alteracao { get; set; }

        public byte[] Icone { get; set; }


        public virtual ICollection<Formula> Formulas { get; set; }

        public virtual ICollection<Personagem> Personagens { get; set; }

        protected Aventura()
        {
            
        }
    }
}
