using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P042_Praktika.Models.Concrete
{
    public class BookHtml
    {
        public string Genre { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string BooksSold { get; set; }
        public string Qtty { get; set; } = "-";
        public string EBookPrice { get; set; } = "-";
        public string AudioPrice { get; set; } = "-";
        public string HardcoverPrice { get; set; } = "-";
        public string PaperbackPrice { get; set; } = "-";

    }
}
