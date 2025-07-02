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
        public double Stato => this.tasks.Average(t => t.Stato);

        public void AggiornaHash()
        {
            this.hash = Convert.ToBase64String(
                SHA256.HashData(
                    Encoding.UTF8.GetBytes("s" + nome + descrizione +Stato + creazione.ToLongDateString())
                )
            );
            this.ultimaModifica = DateTime.Now;
        }
    }
}
