using System;
using System.Collections.Generic;

namespace FazendaBrasil.Domain
{
    public class Animal
    {
        public int Id { get; set; }
        public string Decription { get; set; }
        public byte[] Picture { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double PurchaseWeight { get; set; }
        public DateTime SellingDate { get; set; }
        public double SellingWeight { get; set; }
        public DateTime DeathDate { get; set; }
        public List<AnimalMedication> AnimalMedications { get; set; }        
    }
}
