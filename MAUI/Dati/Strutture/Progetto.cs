using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI.Dati.Strutture
{
    public class Progetto
    {
        public string nome { get; set; } = "";
        public string descrizione { get; set; } = "";
        public List<Task> tasks { get; set; } = new List<Task>();
        public DateTime creazione { get; set; } = DateTime.Now;
        public double Stato => this.tasks.Average(t => t.Stato);
    }
}
