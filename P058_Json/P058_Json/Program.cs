using Newtonsoft.Json;
using P058_Json.Models;
using System.Security.Principal;

namespace P058_Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Json!");

            // SerializeDeserializeSemo.Show();

            //SerializeObjectsDemo.Show();
            //DeserializeObjectsDemo.Show();

            //JsonDatesDemo.Show();
            Uzd1();
            Uzd2();
            Uzd3();
            Uzd4();

        }


        /* ------------------------------------------------
     ### Turite sarasa. Serelizuokite json
     List<string> games = new List<string> { "Starcraft", "Halo","Legend of Zelda"};
     */
        public static void Uzd1()
        {

            List<string> games = new List<string> { "Starcraft", "Halo", "Legend of Zelda" };

            Console.WriteLine("----------------");
            string gamesJson = JsonConvert.SerializeObject(games, Formatting.Indented);

            Console.WriteLine(gamesJson);
        }

        /* ------------------------------------------------
        ### Turite zodyna. Serelizuokite json
        Dictionary<string, int> points = new Dictionary<string, int>
        {
        { "James", 9001 },
        { "Jo", 3474 },
        { "Jess", 11926 }
        };
        */

        public static void Uzd2()
        {
            Dictionary<string, int> points = new Dictionary<string, int>
            {
                { "James", 9001 },
                { "Jo", 3474 },
                { "Jess", 11926 }
            };

            Console.WriteLine("----------------");
            string jsonDictionary = JsonConvert.SerializeObject(points, Formatting.Indented);
            Console.WriteLine(jsonDictionary);

        }

        /* ------------------------------------------------
        ### Sukurkite objekta. skukurkite klase ir serelizuokite json
              Account account = new Account
              {
                  Email = "james@example.com",
                  Active = true,
                  CreatedDate = new DateTime(2013, 1, 20, 0, 0, 0, DateTimeKind.Utc),
                  Roles = new List<string>
                  {
                      "User",
                      "Admin"
                  }
              };
              */
        public static void Uzd3()
        {
            Account account = new Account
            {
                Email = "james@example.com",
                Active = true,
                CreatedDate = new DateTime(2013, 1, 20, 0, 0, 0, DateTimeKind.Utc),
                Roles = new List<string>
                  {
                      "User",
                      "Admin"
                  }
            };

            Console.WriteLine("----------------");
    

            string json = JsonConvert.SerializeObject(account, Formatting.Indented);
            Console.WriteLine(json);


        }

        /* ------------------------------------------------
        ### sukurkite klase, irasykite json i faila
        Movie movie = new Movie{Name = "Bad Boys",Year = 1995 };
        */
        public static void Uzd4()
        {
            Movie movie = new Movie { Name = "Bad Boys", Year = 1995 };

            string json = JsonConvert.SerializeObject(movie, Formatting.Indented);

            File.WriteAllText("test.json", json);

        }


    }


}