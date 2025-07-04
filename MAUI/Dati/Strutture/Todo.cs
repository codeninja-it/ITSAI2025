using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MAUI.Dati.Strutture
{
    public class Todo : Sicurezza
    {
        public string Nome { get; set; } = "";
        public double Stato { get; set; } = 0.0;

        public void Aggiorna(string nome, double stato)
        {
            Nome = nome;
            Stato = stato;
            AggiornaHash();
        }

        public string CreaHash()
        {
            return Convert.ToBase64String(
                SHA256.HashData(
                    Encoding.UTF8.GetBytes($"t{Nome}-{Stato}-{creazione}")
                )
            );
        }

        public void AggiornaHash()
        {
            hash = CreaHash();
            ultimaModifica = DateTime.Now;
        }

        public bool Verifica()
        {
            return hash == CreaHash();
        }
    }
}
