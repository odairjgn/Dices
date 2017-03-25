using System.ComponentModel.DataAnnotations;
using DicesCore.ObjetosDeValor.Enumeradores;

namespace DicesCore.Entidades
{
    public abstract class ItemMidia : Base
    {
        [Required]
        [MaxLength(200)]
        public string Nome { get; set; }

        public TipoMidia Tipo { get; set; }

        protected ItemMidia() { }

        public virtual PlayList Playlist { get; set; }

        public virtual Pagina Pagina { get; set; }
    }
}
