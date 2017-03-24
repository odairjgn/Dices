using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DicesCore.Entidades
{
    public class PlayList : Base
    {
        [Required]
        [MaxLength(80)]
        public string Nome { get; set; }

        public virtual ICollection<ItemMidia> Midias { get; set; }

        protected PlayList()
        {
            
        }
    }
}
