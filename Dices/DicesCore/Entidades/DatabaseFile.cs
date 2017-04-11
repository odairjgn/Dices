using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DicesCore.Entidades
{
    [Table(nameof(DatabaseFile))]
    public class DatabaseFile : ItemMidia
    {
        [Required]
        [MaxLength(8000)]
        public byte[] Dados { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string Extensao { get; set; }

        protected DatabaseFile()
        {
            
        }
    }
}
