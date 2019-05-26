using System.Collections.Generic;
using System.Runtime.Serialization;
using Tapioca.HATEOAS;

namespace FazendaBrasil.Business.ValueObjects
{
    [DataContract]
    public class FrequencyVO : ISupportsHyperMedia
    {
        public FrequencyVO(int id, string description, string name, int rangeOfDays)
        {
            Id = id;
            Description = description;
            Name = name;
            RangeOfDays = rangeOfDays;
            Links = new List<HyperMediaLink>();
        }

        [DataMember(Order = 1, Name = "Code")]
        public int Id { get; set; }

        [DataMember(Order = 2, Name = "Desc")]
        public string Description { get; set; }

        [DataMember(Order = 3, Name = "Name")]
        public string Name { get; set; }

        [DataMember(Order = 4, Name = "Days")]
        public int RangeOfDays { get; set; }

        [DataMember(Order = 5, IsRequired = false)]
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
