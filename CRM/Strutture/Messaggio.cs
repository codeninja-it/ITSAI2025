using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Strutture
{
    [Table("messaggi")]
    public class Messaggio
    {
        [Key]
        public int IdMessaggio { get; set; }
        public Contatto Da { get; set; }
        public Contatto A { get; set; }
        public string Testo { get; set; } = string.Empty;
    }
}
