using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FazendaBrasil.Domain
{
    public class Frequency
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int RangeOfDays { get; set; }
    }
}
