using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Tapioca.HATEOAS;

namespace FazendaBrasil.Business.ValueObjects
{
    public class AnimalVO : ISupportsHyperMedia
    {
        public AnimalVO(int id, string description, byte[] picture, DateTime purchaseDate, double purchaseWeight, DateTime sellingDate, double sellingWeight, DateTime deathDate)
        {
            Id = id;
            Description = description;
            Picture = picture;
            PurchaseDate = purchaseDate;
            PurchaseWeight = purchaseWeight;
            SellingDate = sellingDate;
            SellingWeight = sellingWeight;
            DeathDate = deathDate;
        }

        [DataMember(Order = 1, Name = "Code")]
        public int Id { get; set; }

        [DataMember(Order = 2, Name = "Desc")]
        public string Description { get; set; }

        [DataMember(Order = 3, Name = "Pic")]
        public byte[] Picture { get; set; }

        [DataMember(Order = 4, Name = "PurchaseDate")]
        public DateTime PurchaseDate { get; set; }

        [DataMember(Order = 5, Name = "PuchaseWeigth")]
        public double PurchaseWeight { get; set; }

        [DataMember(Order = 6, Name = "SellingDate")]
        public DateTime SellingDate { get; set; }

        [DataMember(Order = 7, Name = "SellingWeight")]
        public double SellingWeight { get; set; }

        [DataMember(Order = 8, Name = "DeathDate")]
        public DateTime DeathDate { get; set; }

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
