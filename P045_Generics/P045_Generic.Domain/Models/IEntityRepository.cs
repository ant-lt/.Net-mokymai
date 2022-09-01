using P045_Generic.Domain.Interfaces;

namespace P045_Generic.Domain.Models
{
    public interface IEntityRepository<T> where T : IUser
    {
        void Add(T entity);
        int Count();
        List<T> Fetch();
        T Fetch(int id);
        void Print();
        void Remove(T entity);
    }
}