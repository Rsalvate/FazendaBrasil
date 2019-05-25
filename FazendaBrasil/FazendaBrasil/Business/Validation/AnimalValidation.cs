using FazendaBrasil.Business.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FazendaBrasil.Business.Validation
{
    public class AnimalValidation
    {
        public bool ValidateInsert(AnimalVO animal)
        {
            return animal.PurchaseDate != null && animal.PurchaseDate != DateTime.MinValue && animal.PurchaseWeight != 0;
        }
    }
}
