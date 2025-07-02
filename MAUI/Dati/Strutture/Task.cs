using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MAUI.Dati.Strutture
{
    public class Task : Sicurezza
    {
        public string nome { get; set; } = "";
        public double Stato { get; set; } = 0.0;

        public void AggiornaHash()
        {
            hash = Convert.ToBase64String(
                SHA256.HashData(
                    Encoding.UTF8.GetBytes("t" + nome + Stato + creazione.ToLongDateString())
                )
            );
            ultimaModifica = DateTime.Now;
        }
    }
}
