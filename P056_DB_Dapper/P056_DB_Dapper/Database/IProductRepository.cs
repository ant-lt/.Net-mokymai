using P056_DB_Dapper.Models;

namespace P056_DB_Dapper.Database
{
    public interface IProductRepository
    {
        public void Create(Product product);
        public IEnumerable<Product> Get();
        public int Delete(string productName);
    }
}