using WebApiF1.Enums;

namespace WebApiF1.Models
{
    public class Book
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Years { get; set; }
        public ECoverType CoverType { get; set; }

        public Book() { }
        public Book(int id, string title, string authors, int years, ECoverType coverType)
        {
            Id = id;
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Author = authors ?? throw new ArgumentNullException(nameof(authors));
            Years = years;
            CoverType = coverType;
        }
    }
}
