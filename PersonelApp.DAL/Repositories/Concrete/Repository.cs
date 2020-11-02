using PersonelApp.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DAL.Repositories.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbContext _context;
        private DbSet<T> _dbset;
        public Repository(DbContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }


        public void Add(T entity)
        {
            //_context.Departments
            _dbset.Add(entity);
        }

        public void AddRange(IEnumerable<T> entity)
        {
            _dbset.AddRange(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbset.ToList();
        }

        public T GetById(int id)
        {
            return _dbset.Find(id);
        }

        public void Remove(int id)
        {
            _dbset.Remove(GetById(id));
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            _dbset.RemoveRange(entity);
        }
    }
}
