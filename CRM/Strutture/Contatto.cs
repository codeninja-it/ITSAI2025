using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Strutture
{
    [Table("contatti")]
    public class Contatto
    {
        [Key]
        public int IdContatto { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cognome { get; set; } = string.Empty;
        public string Email {  get; set; } = string.Empty;
        public override string ToString()
        {
            return $"{Cognome} {Nome}";
        }
    }
}
