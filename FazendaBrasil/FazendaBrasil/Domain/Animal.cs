using System;
using System.Collections.Generic;

namespace FazendaBrasil.Domain
{
    public class Animal
    {
        public Animal()
        {

        }

        public Animal(string description, byte[] picture, DateTime purchaseDate, double purchaseWeight, DateTime sellingDate, double sellingWeight)
        {
            Description = description;
            Picture = picture;
            PurchaseDate = purchaseDate;
            PurchaseWeight = purchaseWeight;
            SellingDate = sellingDate;
            SellingWeight = sellingWeight;
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double PurchaseWeight { get; set; }
        public DateTime SellingDate { get; set; }
        public double SellingWeight { get; set; }
        public DateTime DeathDate { get; set; }
        //public List<AnimalMedication> AnimalMedications { get; set; }        
    }
}
