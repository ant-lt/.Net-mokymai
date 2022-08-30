using Microsoft.VisualStudio.TestTools.UnitTesting;
using P042_Praktika.InitialData;
using P042_Praktika.Models.Abstract;
using P042_Praktika.Models.Concrete;
using P042_Praktika.Models.Enums;
using P042_Praktika.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P042_Praktika.Service.Tests
{
    [TestClass()]
    public class BookServiceTests
    {
        [TestMethod()]
        public void DecodeTest()
        {
            BookService service = new BookService();
            var actual = service.Decode(BookInitialData.DataSeedHtml);

            Assert.AreEqual(4, actual.Count);
            Assert.AreEqual(4, actual[BookType.Ebook].Count);
            Assert.AreEqual(9, actual[BookType.Audio].Count);
            Assert.AreEqual(10, actual[BookType.Hardcover].Count);
            Assert.AreEqual(8, actual[BookType.Paperback].Count);
        }

        [TestMethod()]
        public void EncodeTest()
        {
            List<Book> fake = new List<Book>
            {
                new EBook { Genre = "Fantasy", Title = "Harry Potter and the Philosopher's Stone", Author = "JK Rowling", BooksSold = 12000000, Qtty = 5, Price = 10.0  },
                new AudioBook { Genre = "Fantasy", Title = "Harry Potter and the Philosopher's Stone", Author = "JK Rowling", BooksSold = 12000000, Qtty = 5, Price = 15.0  },
                new PaperbackBook { Genre = "Adventure", Title = "The Little Prince", Author = "Antoine de Saint-Exupery", BooksSold = 2000000, Qtty = 5, Price = 13.0  },
                new PaperbackBook { Genre = "Mystery", Title = "The Da Vinci Code", Author = "Dan Brown", BooksSold = 800000, Qtty = 5, Price = 20.0  },
                new HardcoverBook { Genre = "Adventure", Title = "The Little Prince", Author = "Antoine de Saint-Exupery", BooksSold = 2000000, Qtty = 5, Price = 33.0  },

            };
            BookService service = new BookService();
            string actual = service.Encode(fake);

            Assert.IsTrue(actual.Contains("<td>The Da Vinci Code</td>"));
            Assert.IsTrue(actual.Contains("<td>Harry Potter and the Philosopher's Stone</td>"));
            Assert.IsTrue(actual.Contains("<td>The Little Prince</td>"));



            var decoded = service.Decode(actual);
            Assert.AreEqual(4, decoded.Count);
        }
    }
}