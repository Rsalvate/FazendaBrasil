using AutoMapper;
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
        private readonly IMapper _mapper;

        public FrequencyApplicationService(IBaseRepository<Frequency> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public FrequencyVO Add(FrequencyVO item)
        {
            Frequency frequency = _mapper.Map<FrequencyVO, Frequency>(item);

            var storedFrequency = _repository.Add(frequency);

            item.Id = storedFrequency.Id;

            return item;
        }

        public FrequencyVO Find(object Id)
        {
            var storedFrequency = _repository.Find(Id);

            if (storedFrequency == null) return null;

            return _mapper.Map<Frequency, FrequencyVO>(storedFrequency);
        }

        public List<FrequencyVO> GetAll()
        {
            var storedFrequencies = _repository.GetAll();

            if (storedFrequencies == null) return null;

            return _mapper.Map<List<Frequency>, List<FrequencyVO>>(storedFrequencies.ToList());
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
