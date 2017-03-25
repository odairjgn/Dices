using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DicesCore.Entidades
{
    public class Configuracao : Base
    {
        [Required]
        [MaxLength(30)]
        [Index("IX_KEY", IsUnique = true)]
        public string Key { get; set; }

        public string Value { get; set; }

        protected Configuracao() { }
    }
}
