using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Strutture
{
    [Table("progetti")]
    public class Progetto
    {
        [Key]
        public int IdProgetto { get; set; }
        public Contatto Committente { get; set; }
        public string Titolo { get; set; } = string.Empty;
        public string Perimetro { get; set; } = string.Empty;
        public List<Richiesta> Richieste { get; } = [];
        public List<Messaggio> Messaggi { get; } = [];
        public DateTime Creazione {  get; set; } = DateTime.Now;
    }
}
