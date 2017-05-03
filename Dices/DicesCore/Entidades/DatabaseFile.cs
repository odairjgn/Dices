using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DicesCore.Extensoes;

namespace DicesCore.Entidades
{
    [Table(nameof(DatabaseFile))]
    public class DatabaseFile : ItemMidia
    {
        [Required]
        [Column(TypeName = "NTEXT")]
        [MaxLength]
        public string DadosBase64 { get; set; }
        
        [Required]
        [MaxLength(20)]
        public string Extensao { get; set; }

        [NotMapped]
        public byte[] DadosByte
        {
            get { return DadosBase64.GetByteArrayFromB64(); }
            set { DadosBase64 = value.GetB64FromByteArray(); }
        }

        protected DatabaseFile()
        {
            
        }
    }
}
