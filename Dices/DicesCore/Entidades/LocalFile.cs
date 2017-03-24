using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DicesCore.Entidades
{
    [Table(nameof(LocalFile))]
    public class LocalFile : ItemMidia
    {
        protected LocalFile()
        {
            
        }

        [Required]
        [MaxLength(256)]
        public string Path { get; set; }

        public bool PathRelativo { get; set; }

        [Required]
        [MaxLength(20)]
        public string Extensao { get; set; }
    }
}
