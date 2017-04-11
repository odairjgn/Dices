using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DicesCore.Entidades
{
    [Table(nameof(DatabaseFile))]
    public class DatabaseFile : ItemMidia
    {
        [Required]
        [Column(TypeName = "NTEXT")]
        public string DadosBase64 { get; protected set; }
        
        [Required]
        [MaxLength(20)]
        public string Extensao { get; set; }

        [NotMapped]
        public byte[] DadosByte
        {
            get { return Convert.FromBase64String(DadosBase64); }
            set { DadosBase64 = Convert.ToBase64String(value); }
        }

        protected DatabaseFile()
        {
            
        }
    }
}
