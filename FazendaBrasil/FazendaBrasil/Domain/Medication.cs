using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FazendaBrasil.Domain
{
    public class Medication
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double PurchasePrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Frequency UsageFrequency { get; set; }
    }
}
