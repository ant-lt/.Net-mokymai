namespace P045_Generic.Domain.Models
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