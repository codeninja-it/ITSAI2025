using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI.Dati.Strutture
{
    public class Sicurezza
    {
        public DateTime creazione { get; set; } = DateTime.Now;
        public DateTime ultimaModifica { get; set; } = DateTime.Now;
        public string hash { get; set; } = "";
    }
}
