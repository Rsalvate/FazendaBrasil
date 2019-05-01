using FazendaBrasil.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace FazendaBrasil.Repository.Implementations
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public T Add(T item)
        {
            _context.Set<T>().Add(item);
            _context.SaveChanges();

            return item;
        }

        public T Find(object Id)
        {
            return _context.Set<T>().Find(Id);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Remove(object Id)
        {
            _context.Set<T>().Remove(Find(Id));
            _context.SaveChanges();
        }

        public T Update(T item)
        {
            _context.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return item;
        }
    }
}
