using FazendaBrasil.Business.ValueObjects;
using FazendaBrasil.Domain;
using FazendaBrasil.Repository;
using System;
using System.Collections.Generic;

namespace FazendaBrasil.Business.ApplicationService.Implementations
{
    public class FrequencyApplicationService : IFrequencyApplicationService
    {
        private readonly IBaseRepository<Frequency> _repository;

        public FrequencyApplicationService(IBaseRepository<Frequency> repository)
        {
            _repository = repository;
        }

        public FrequencyVO Add(FrequencyVO item)
        {
            Frequency frequency = new Frequency(item.Description, item.Name, item.RangeOfDays);
            var storedFrequency = _repository.Add(frequency);

            item.Id = storedFrequency.Id;

            return item;
        }

        public FrequencyVO Find(object Id)
        {
            var storedFrequency = _repository.Find(Id);

            if (storedFrequency == null) return null;

            return new FrequencyVO(storedFrequency.Id, storedFrequency.Description, storedFrequency.Name, storedFrequency.RangeOfDays);
        }

        public IEnumerable<FrequencyVO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(object Id)
        {
            throw new NotImplementedException();
        }

        public FrequencyVO Update(FrequencyVO item)
        {
            throw new NotImplementedException();
        }
    }
}
