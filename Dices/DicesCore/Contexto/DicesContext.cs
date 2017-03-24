﻿using System.Data.Entity;
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

        public DbSet<Aventura> Aventuras { get; set; }
        public DbSet<Personagem> Personagens { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<SubClasse> SubClasses { get; set; }
    }
}
