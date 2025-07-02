using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MAUI.Dati.Strutture
{
    public class Progetto : Sicurezza
    {
        public string nome { get; set; } = "";
        public string descrizione { get; set; } = "";
        public List<Task> tasks { get; set; } = new List<Task>();
        public int Stato => tasks.Count == 0 ? 100 : (int)this.tasks.Average(t => t.Stato);

        public string CreaHash()
        {
            return Convert.ToBase64String(
                SHA256.HashData(
                    Encoding.UTF8.GetBytes($"p{nome}-{descrizione}-{creazione}")
                )
            );
        }

        public void AggiornaHash()
        {
            this.hash = CreaHash();
            this.ultimaModifica = DateTime.Now;
        }

        public bool Verifica()
        {
            return hash == CreaHash();
        }
    }
}
