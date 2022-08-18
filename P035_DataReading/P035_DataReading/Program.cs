using P035_DataReading.Domain.Models;
using P035_DataReading.InicialData;

namespace P035_DataReading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Data Reading!");
            //string path = Environment.CurrentDirectory;
            //SakninioFolderioSuradimas(path);
            SkaitymasIsTxtFailoEilutemisAtskirai();
        }

        static void SakninioFolderioSuradimas(string path)
        {
            //string rootDirectoryPath = new DirectoryInfo(path).Parent.Parent.FullName;
            Console.WriteLine($"Sakninis katalogas yra {path}");
        }

        public static void SkaitymasIsIvesties()
        {
            int userColumnCount = 2;
            Console.WriteLine("Suveskite vartotojus tokiu formatu: 1, Antanas; 2, Ieva");
            string[] usersInText = Console.ReadLine()
                .Replace(" ", "") // Istriname tarpus visame stringe
                .Split(';'); // Atskiriame pagal eilutes

            List<User> users = new List<User>();

            foreach (string user in usersInText)
            {
                string[] userData = user.Split(',');

                if (userData.Length < userColumnCount) break;

                User newUser = new User(Convert.ToInt32(userData[0]), userData[1]);
                users.Add(newUser);
            }

            Console.WriteLine("Aplikacijoje turime siuos vartotojus:");
            foreach (User user in users)
            {
                Console.WriteLine($"{user.Name} ID: {user.Id}");
            }

            string naudotojoIvestis;

            Console.WriteLine("Suveskite vartotojus tokiu formatu: 1, Antanas");

            while ((naudotojoIvestis = Console.ReadLine()) != "")
            {
                Console.WriteLine("Pridedame nauja vartotoja..");
                string[] userData = naudotojoIvestis.Split(',');

                if (userData.Length < userColumnCount) break;

                User newUser = new User(Convert.ToInt32(userData[0]), userData[1]);
                users.Add(newUser);
            }

            Console.WriteLine("Aplikacijoje turime siuos vartotojus:");
            foreach (User user in users)
            {
                Console.WriteLine($"{user.Name} ID: {user.Id}");
            }
        }

        public static void SkaitymasIsStaticKlases()
        {
            List<Person> people = PersonInitialData.DataSeed.ToList();

            Console.WriteLine("Skaitant is Static Klases radome siuos zmones:");
            foreach (Person person in people)
            {
                Console.WriteLine($"Vardas Pavarde: {person.FirstName} {person.LastName}");
            }
        }

        // + Greitas sprendimas reikalaujantis nedaug laiko ir mazai ziniu
        // - Reikalauja papildomu split operaciju
        // - Uzloadina visa teksta i aktyvia atminti
        // - Kol skaito teksta nieko kito aplikacijoje negali vykti su veikianciu threadu
        // - Nesiples darbas su dideliais failais
        public static void SkaitymasIsTxtFailo()
        {
            int animalColumnCount = 2;
            List<Animal> animals = new List<Animal>();
            //string filePath = "C:\\Users\\Edvinas\\source\\repos\\CA.NET2\\OOP\\P035_DataReading\\P035_DataReading\\InitialData\\AnimalData.txt";
            string filePath = Environment.CurrentDirectory + "\\InitialData\\AnimalData.txt";
            Console.WriteLine(filePath);
            string text = File.ReadAllText(filePath);
            string[] animalStringData = text.Split(Environment.NewLine);

            Console.WriteLine(text);

            foreach (string animal in animalStringData)
            {
                string[] animalData = animal.Split(',');

                if (animalData.Length != animalColumnCount) break;

                Animal newAnimal = new Animal(animalData);
                animals.Add(newAnimal);
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }

        // + Greitas sprendimas reikalaujantis nedaug laiko ir mazai ziniu
        // - Uzloadina visa teksta i aktyvia atminti
        // - Kol skaito teksta nieko kito aplikacijoje negali vykti su veikianciu threadu
        // - Nesiples darbas su dideliais failais
        public static void SkaitymasIsTxtFailoEilutemis()
        {
            int animalColumnCount = 2;
            List<Animal> animals = new List<Animal>();
            string filePath = Environment.CurrentDirectory + "\\InitialData\\AnimalData.txt";

            string[] animalStringData = File.ReadAllLines(filePath);

            foreach (string animal in animalStringData)
            {
                string[] animalData = animal.Split(',');

                if (animalData.Length != animalColumnCount) break;

                Animal newAnimal = new Animal(animalData);
                animals.Add(newAnimal);
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }

        public static void SkaitymasIsTxtFailoEilutemisAtskirai()
        {
            int animalColumnCount = 2;
            List<Animal> animals = new List<Animal>();
            string filePath = Environment.CurrentDirectory + "\\InitialData\\AnimalData.txt";

            // IDisposable resursai butu elementai kaip: Streamai, Listeneriai, duombazes komunikacijos repositorijos, webiniai iskvietimai ir t.t.
            StreamReader sr = new StreamReader(filePath);

            string line = sr.ReadLine();
            Console.WriteLine(line);
            
            string line2 = sr.ReadLine();
            Console.WriteLine(line2);

            // Su .Close() mes pasakome GarbageCollector, kad reikia isvalyti duomenis priklausancius siam objektui
            sr.Close();

            //foreach (Animal animal in animals)
            //{
            //    Console.WriteLine(animal.Name);
            //}
        }

    }
}