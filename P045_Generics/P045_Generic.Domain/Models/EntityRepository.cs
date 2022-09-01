using P045_Generic.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P045_Generic.Domain.Models
{
    public class EntityRepository<T> : IRepository<T>
       where T : IUser
    {
        private List<T> _entities = new List<T>();

        public EntityRepository()
        {
        }

        public EntityRepository(List<T> entities)
        {
            _entities = entities;
        }

        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public T Fetch(int id)
        {
            return _entities.Where(e => e.Id == id).FirstOrDefault();
        }

        public List<T> Fetch() => _entities;

        public void Print()
        {
            foreach (T entity in _entities)
            {
                Console.WriteLine(entity.Name);
            }
        }

        public void Remove(T entity) => _entities.Remove(entity);
    }
}
