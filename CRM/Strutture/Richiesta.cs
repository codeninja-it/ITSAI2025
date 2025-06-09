using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Strutture
{
    [Table("richieste")]
    public class Richiesta
    {
        [Key]
        public int IdRichiesta { get; set; }
        public Progetto Progetto { get; set; }
        public string Descrizione { get; set; }
        public DateTime Inserimento { get; set; } = DateTime.Now;
        public bool Fatto { get; set; } = false;
    }
}
