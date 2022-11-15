using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WebAPIUzduotis1;

namespace WebAPIUzduotis1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {

            List<Book> books = new List<Book>
            {
                new Book { id = 1, pavadinimas = "Ant medinės lentelės II", autorius = "Kristina Pišniukaitė - Šimkienė", leidybosMetai = 2022}
                ,new Book { id = 2, pavadinimas = "Kakė Makė ir magiška kelionė", autorius = "Lina Žutautė", leidybosMetai = 2022}
                ,new Book { id = 3, pavadinimas = "Tolimi krantai", autorius = "Santa Montefiore", leidybosMetai = 2022 }
                ,new Book { id = 4, pavadinimas = "Aštuntas gyvenimas (Brilkai)", autorius = "Nino Haratischwili", leidybosMetai = 2022 }
                ,new Book { id = 5, pavadinimas = "Ant medinės lentelės III", autorius = "Kristina Pišniukaitė - Šimkienė", leidybosMetai = 2022 }
                ,new Book { id = 6, pavadinimas = "Kichotas", autorius = "Salman Rushdie", leidybosMetai = 2020 }
                ,new Book { id = 7, pavadinimas = "Book6", autorius = "autor1", leidybosMetai = 2000 }
                ,new Book { id = 8, pavadinimas = "Book7", autorius = "autor1", leidybosMetai = 2000 }
                ,new Book { id = 9, pavadinimas = "Ant medinės lentelės IIV", autorius = "Kristina Pišniukaitė - Šimkienė", leidybosMetai = 2022 }
                ,new Book { id = 10, pavadinimas = "Book8", autorius = "autor1", leidybosMetai = 2000 }
            };


        [HttpGet("books")]
        public List<Book> GetMyBooks()
        {
            return books;
        }

        [HttpGet("{id}")]
        public Book? GetBookById(int id)
        {
            return books.FirstOrDefault(p => p.id == id);
        }

        [HttpGet("pagalpavadinima/{pavadinimas}")]
        public Book? GetBookByName(string pavadinimas)
        {
            return books.FirstOrDefault(p => p.pavadinimas == pavadinimas);
        }

        [HttpGet("pagal")]
        public Book? Filter(string pavadinimas, string autorius)
        {
            return books.FirstOrDefault(p => p.pavadinimas == pavadinimas && p.autorius == autorius);
        }

    }
}
