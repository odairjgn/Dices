using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DicesCore.Entidades
{
    [Table(nameof(WebLink))]
    public class WebLink : ItemMidia
    {
        [MaxLength(300)]
        [Required]
        public string Url { get; set; }

        protected WebLink()
        {
            
        }
    }
}
