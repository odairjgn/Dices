using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DicesCore.Entidades;

namespace DicesCore.Contexto
{
    public class DicesContext : DbContext
    {
        public DicesContext(string conn):base(conn)
        {
           
        }

        public DicesContext()
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Aventura> Aventuras { get; set; }
        public DbSet<Personagem> Personagens { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<SubClasse> SubClasses { get; set; }
        public DbSet<Formula> Formulas { get; set; }
        public DbSet<ItemMidia> ItensMidia { get; set; }
        public DbSet<NoteBook> NoteBooks { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }
        public DbSet<Pagina> Paginas { get; set; }
        public DbSet<Configuracao> Configuracoes { get; set; }
        public DbSet<Progressao> Progressoes { get; set; }
    }
}
