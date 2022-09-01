using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P045_Generic.Domain.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Remove(T entity);
        void Print();
        T Fetch(int id);
        List<T> Fetch();
    }
}
