using Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class GenericRepository<T> : IGeneric<T> where T : class
    {
        private readonly AppDbContext _dbContext;
        public void Delete(T t)
        {
            _dbContext.Remove(t);
            _dbContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public void Insert(T t)
        {
            _dbContext.Add(t);
            _dbContext.SaveChanges();
        }

        public void Update(T t)
        {
            _dbContext.Update(t);
            _dbContext.SaveChanges();
        }
    }
}
