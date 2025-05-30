using Microsoft.EntityFrameworkCore;
using WebChat.Dati.Strutture;

namespace WebChat.Dati
{
    public class BancaDati : DbContext
    {

        public DbSet<Utente> Utenti { get; set; }
        public DbSet<Messaggio> Messaggi { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Messaggio>()
                .HasOne<Utente>(m => m.Mittente)
                .WithMany()
                .HasForeignKey("MittenteIdUtente")
                .OnDelete(DeleteBehavior.SetNull);
            modelBuilder
                .Entity<Messaggio>()
                .HasOne<Utente>(m => m.Destinatario)
                .WithMany()
                .HasForeignKey("DestinatarioIdUtente")
                .OnDelete(DeleteBehavior.SetNull);
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=chat.sqlite");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
