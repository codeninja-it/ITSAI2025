﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stradario.Strutture
{
    [Table("nodi")]
    public class Nodo : Sicurezza
    {
        [Key]
        public int idNodo { get; set; }
        [Required]
        public string nome { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public override string ToString()
        {
            return this.nome;
        }

        public double CalcolaDistanza(Nodo target)
        {
            // calcolare la distanza tra i due nodi
            double deltaX = this.X - target.X;
            double deltaY = this.Y - target.Y;
            double distanza = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return distanza;
        }
    }
}
