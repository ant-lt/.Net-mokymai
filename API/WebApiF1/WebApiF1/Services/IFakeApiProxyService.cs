using WebApiF1.Models.ApiModels;

namespace WebApiF1.Services
{
    public interface IFakeApiProxyService
    {
        Task<IEnumerable<BookApiResult>> GetBooks();
    }
}
