using P042_Praktika.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P042_Praktika.Interface
{
    public interface IUniversityBookStoreAccounting
    {
        int Stock();
        List<string> Genres();
        Dictionary<BookStorePerson, List<Book>> Sales();
    }
}
