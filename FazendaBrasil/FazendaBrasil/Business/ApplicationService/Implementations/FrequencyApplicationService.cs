using FazendaBrasil.Business.ValueObjects;
using FazendaBrasil.Domain;
using FazendaBrasil.Repository;
using System.Collections.Generic;
using System.Linq;

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
            var storedFrequencies = _repository.GetAll();

            if (storedFrequencies == null) return null;

            return storedFrequencies.Select(s => new FrequencyVO(s.Id, s.Description, s.Name, s.RangeOfDays)).ToList();
        }

        public void Remove(object Id)
        {
            _repository.Remove(Id);
        }

        public FrequencyVO Update(FrequencyVO item)
        {
            var storedFrequency = _repository.Find(item.Id);

            if (storedFrequency == null) return null;

            storedFrequency.Description = item.Description;
            storedFrequency.Name = item.Name;
            storedFrequency.RangeOfDays = item.RangeOfDays;

            _repository.Update(storedFrequency);

            return item;
        }
    }
}
