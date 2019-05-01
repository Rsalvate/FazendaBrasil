using System.Collections.Generic;

namespace FazendaBrasil.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        T Add(T item);
        T Update(T item);
        void Remove(object Id);
        IEnumerable<T> GetAll();
        T Find(object Id);
    }
}
