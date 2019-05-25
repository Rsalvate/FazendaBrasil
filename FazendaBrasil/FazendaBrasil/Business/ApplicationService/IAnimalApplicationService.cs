using FazendaBrasil.Business.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FazendaBrasil.Business.ApplicationService
{
    public interface IAnimalApplicationService
    {
        AnimalVO Add(AnimalVO item);
        AnimalVO Update(AnimalVO item);
        void Remove(object Id);
        IEnumerable<AnimalVO> GetAll();
        AnimalVO Find(object Id);
    }
}
