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
        
        public byte[] Icone { get; set; }


        public virtual ICollection<Formula> Formulas { get; set; }
        public virtual ICollection<Personagem> Personagens { get; set; }
        public virtual ICollection<Variavel> Variaveis { get; set; }

        protected Aventura()
        {
            
        }

        public Aventura(string titulo, string descricao, DateTime criacao, byte[] icone)
        {
            Titulo = titulo;
            Descricao = descricao;
            Criacao = criacao;
            Icone = icone;
        }
    }
}
