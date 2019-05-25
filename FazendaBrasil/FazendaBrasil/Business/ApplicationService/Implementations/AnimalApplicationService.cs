using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FazendaBrasil.Business.ValueObjects;
using FazendaBrasil.Domain;
using FazendaBrasil.Repository;

namespace FazendaBrasil.Business.ApplicationService.Implementations
{
    public class AnimalApplicationService : IAnimalApplicationService
    {
        private readonly IBaseRepository<Animal> _repository;

        public AnimalApplicationService(IBaseRepository<Animal> repository)
        {
            _repository = repository;
        }

        public AnimalVO Add(AnimalVO item)
        {
            Animal animal = new Animal(item.Description, item.Picture, item.PurchaseDate, item.PurchaseWeight, item.SellingDate, item.SellingWeight);
            var storedAnimal = _repository.Add(animal);

            item.Id = storedAnimal.Id;

            return item;
        }

        public AnimalVO Find(object Id)
        {
            var storedAnimal = _repository.Find(Id);

            if (storedAnimal == null) return null;

            return new AnimalVO(storedAnimal.Id, 
                                storedAnimal.Description, 
                                storedAnimal.Picture, 
                                storedAnimal.PurchaseDate, 
                                storedAnimal.PurchaseWeight, 
                                storedAnimal.SellingDate, 
                                storedAnimal.SellingWeight, 
                                storedAnimal.DeathDate);
        }

        public IEnumerable<AnimalVO> GetAll()
        {
            var storedAnimals = _repository.GetAll();

            if (storedAnimals == null) return null;

            return storedAnimals.Select(s => new AnimalVO(s.Id,
                                                          s.Description,
                                                          s.Picture,
                                                          s.PurchaseDate,
                                                          s.PurchaseWeight,
                                                          s.SellingDate,
                                                          s.SellingWeight,
                                                          s.DeathDate));
        }

        public void Remove(object Id)
        {
            _repository.Remove(Id);
        }

        public AnimalVO Update(AnimalVO item)
        {
            var storedAnimal = _repository.Find(item.Id);

            if (storedAnimal == null) return null;

            storedAnimal.Description = item.Description;
            storedAnimal.Picture = item.Picture;
            storedAnimal.PurchaseDate = item.PurchaseDate;
            storedAnimal.PurchaseWeight = item.PurchaseWeight;
            storedAnimal.SellingDate = item.SellingDate;
            storedAnimal.SellingWeight = item.SellingWeight;
            storedAnimal.DeathDate = item.DeathDate;

            _repository.Update(storedAnimal);

            return item;
        }
    }
}
