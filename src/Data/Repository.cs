using Microsoft.EntityFrameworkCore;

namespace DotApiMicro.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _entities;

        public Repository(AppDbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.ToList();
        }

        public T Get(int id)
        {
            return _entities.Find(id);
        }

        public T Add(T entity)
        {
            var obj = _entities.Add(entity);
            _context.SaveChanges();
            return obj.Entity;

        }

        public T Update(T entity)
        {
            var obj = _entities.Update(entity);
            _context.SaveChanges();
            return obj.Entity;
        }

        public void Delete(T entity)
        {
            _entities.Remove(entity);
            _context.SaveChanges();
        }
    }
}
