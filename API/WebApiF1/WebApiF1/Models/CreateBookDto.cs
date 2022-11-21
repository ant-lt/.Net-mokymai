namespace WebApiF1.Models
{
    public class CreateBookDto
    {
        public CreateBookDto(string title, string author, DateTime published)
        {
            Title = title;
            Author = author;
            Published = published;
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public DateTime Published { get; set; }
    }
}
