using P042_Praktika.Models.Abstract;
using P042_Praktika.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P042_Praktika.Interface
{
    public interface IBookHtmlService
    {
        Dictionary<BookType, List<Book>> Decode(String dataSeed);
        string Encode(Dictionary<BookType, List<Book>> books);
    }
}
