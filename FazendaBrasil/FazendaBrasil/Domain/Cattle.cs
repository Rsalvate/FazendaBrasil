using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FazendaBrasil.Domain
{
    public class Cattle
    {
        public int Id { get; set; }        
        public string Decription { get; set; }
        public List<CattleAnimal> cattleAnimals { get; set; }
    }
}
