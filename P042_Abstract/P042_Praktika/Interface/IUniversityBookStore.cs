using P042_Praktika.Models.Abstract;
using P042_Praktika.Models.Concrete;
using P042_Praktika.Models.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P042_Praktika.Interface
{
    public interface IUniversityBookStore
    {
        void Fill(string dataSeed);
        void Buy(Book book, int qtty);
        Invoice Sale(BookStorePerson person, string title, BookType bookType, int qtty);
    }
}
