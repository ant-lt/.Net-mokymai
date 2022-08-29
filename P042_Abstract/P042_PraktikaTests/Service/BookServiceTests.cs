using Microsoft.VisualStudio.TestTools.UnitTesting;
using P042_Praktika.InitialData;
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
    }
}