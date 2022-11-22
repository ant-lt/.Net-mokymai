using WebApiF1.Models;

namespace WebApiF1.Services
{
    public interface IBookManager
    {
        public List<GetBookDto> Get();
        public GetBookDto Get(int id);
        public bool Exist(int id);
        public List<GetBookDto> Filter(Dictionary<string, string> filter);
        public int Add(CreateBookDto book);
        public void Update(UpdateBookDto book);
        public void Delete(int id);
    }
}