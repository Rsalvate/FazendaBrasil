using FazendaBrasil.Business.ValueObjects;
using System.Collections.Generic;

namespace FazendaBrasil.Business.ApplicationService
{
    public interface IFrequencyApplicationService
    {
        FrequencyVO Add(FrequencyVO item);
        FrequencyVO Update(FrequencyVO item);
        void Remove(object Id);
        List<FrequencyVO> GetAll();
        FrequencyVO Find(object Id);
    }
}
