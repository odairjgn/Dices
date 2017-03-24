using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DicesCore.Entidades
{
    public class Classe : Base
    {
        [MaxLength(50)]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public virtual ICollection<SubClasse> SubClasses { get; set; }

        protected Classe()
        {
            
        }
    }
}
