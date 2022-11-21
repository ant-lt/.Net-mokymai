using WebApiF1.Enums;

namespace WebApiF1.Models
{
    public class Book
    {

        public int id { get; set; }
        public string pavadinimas { get; set; }
        public string autorius { get; set; }
        public int leidybosMetai { get; set; }
        public ECoverType coverType { get; set; }

        public Book() { }
        public Book(int id, string pavadinimas, string autorius, int leidybosMetai, ECoverType coverType)
        {
            this.id = id;
            this.pavadinimas = pavadinimas ?? throw new ArgumentNullException(nameof(pavadinimas));
            this.autorius = autorius ?? throw new ArgumentNullException(nameof(autorius));
            this.leidybosMetai = leidybosMetai;
            this.coverType = coverType;
        }
    }
}
