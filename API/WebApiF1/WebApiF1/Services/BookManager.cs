using WebApiF1.Models;

namespace WebApiF1.Services
{
    public class BookManager: IBookManager
    {
        private readonly IBookSet _context;
        private readonly IBookWrapper _wrapper;

        public BookManager(IBookSet bookSet, IBookWrapper bookWrapper) { 
            _context = bookSet;
            _wrapper = bookWrapper;
        }

        public List<GetBookDto> Get()
        {
            var books = _context.Books;
            var dto = books.Select(s => _wrapper.Bind(s)).ToList();
            return dto;
        }

        public GetBookDto Get(int id) {
            return new GetBookDto();
        }

        public bool Exist (int id)
        {
            return false;
        }

        public List<GetBookDto> Filter( Dictionary<string, string> filter) {

            return null;
        }

        public int Add(CreateBookDto book)
        {
            return 0;
        }


        public void Update(UpdateBookDto book)
        {

        }


        public void Delete (int id)
        {
        }
    }
}
