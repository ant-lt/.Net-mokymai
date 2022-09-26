using Newtonsoft.Json;
using P058_Json.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P058_Json
{
    public static class SerializeObjectsDemo
    {
        public static void Show()
        {
            
            var author = new Author
            {
                Name = "Vardenis Pavardenis",
                Courses = new string[] { "C#", "Java", },
                Happy = true,
            };

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Objekto serelizavimas");
            string json = JsonConvert.SerializeObject(author, Formatting.Indented);
            Console.WriteLine(json);


            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Kolekcijos serelizavimas");
            List<string> kursai = new List<string> { "C#", "Java", "T-SQL"};
            string jsonArray = JsonConvert.SerializeObject(kursai, Formatting.Indented);
            Console.WriteLine(jsonArray);


            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Zodyno serelizavimas");

            Dictionary<string, int> kursuZodynas = new Dictionary<string, int>
            {
                {"c#", 10 },
                {"Java", 20 },
                {"T-SQL", 333 }
            };

            string jsonDictionary = JsonConvert.SerializeObject(kursuZodynas, Formatting.Indented);
            Console.WriteLine(jsonDictionary);


            Console.WriteLine($"-------------------------------------------");
            var anonymousAuthor = new
            {
                Name = "Jonas Petras",
                Happy = false,
                Courses = new List<string>()

            };
            Console.WriteLine(JsonConvert.SerializeObject(anonymousAuthor));

        }
    }
}
