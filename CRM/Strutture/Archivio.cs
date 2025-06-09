using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Strutture
{
    public class Archivio : DbContext
    {
        public DbSet<Progetto> Progetti { get; set; }
        public DbSet<Contatto> Contatti { get; set; }
        public DbSet<Richiesta> Richieste { get; set; }
        public DbSet<Messaggio> Messaggi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=archivio.sqlite");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
