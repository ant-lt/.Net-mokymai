using System.Text;

namespace Paskaita_Random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Random!");

            // konstrojamas naujas random

            Random random = new Random();
            Random rnd = new Random();

            int aRandomNumber = random.Next();
            int aRandomNUmber1 = random.Next(4);
            int aRandomNUmber2 = random.Next(1,4);

            double dRandomNUmber = random.NextDouble();

            Console.WriteLine(RandomMetodasDebuginamas());
            Console.WriteLine(RandomMetodas(random));

            // Atsitiktinis parinkimas is array ir list 
            Console.WriteLine("------------------");
            Console.WriteLine("Atsitiktinis parinkimas is array ir list ");
            string[] maleNames = { "Nedas", "Justas", "Arunas", "Arnas" };
            List<String> femaleNames = new List<String> {"Dainora", "Sonta", "Vida"};

            int mIndex = random.Next( maleNames.Length );
            Console.WriteLine("Vyriskas " + maleNames[mIndex]);

            int fIndex = rnd.Next(femaleNames.Count);
            Console.WriteLine("Moteriskas vardas " + femaleNames[fIndex]);

            // Atsitiktinis parinkimas is dictionary
            Console.WriteLine("--------------");
            Console.WriteLine("Atsitiktinis parinkimas is dictionary");

            Dictionary<String, int> miestai = new Dictionary<String, int>
            {
                {"Vilnius", 54115 },
                {"Kaunas", 25588 },
                {"Klaipeda", 15255 },
                {"Siaulia", 2555 }
            };
            List<String> miestaiKeys = new List<String>(miestai.Keys);

            int miestasIndex = rnd.Next(miestaiKeys.Count);
            string miestasKey = miestaiKeys[miestasIndex];
            int gyventojuSkaicius = miestai[miestasKey];
            Console.WriteLine($"mieste {miestasKey} gyvena {gyventojuSkaicius} gyventojai");

            // Atsitiktinio zodzio parinkimas tekste

            Console.WriteLine("-------------");
            Console.WriteLine("Atsitiktinio zodzio parinkimas tekste");

            string lorem = "Lorem ipsum dolor";
            string[] loremArr = lorem.Split(' ');

            string zodis = loremArr[rnd.Next(loremArr.Length)];
            Console.WriteLine(zodis);

            // Atsitiktiniu raidziu generavimas
            Console.WriteLine("-------------");
            Console.WriteLine("Atsitiktiniu raidziu generavimas");

            int raidziuKiekis = 10;
            string raidziuZodis = "";
            int A = 65, Z = 90;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < raidziuKiekis; i++)
            {
                sb.Append((char)rnd.Next(A, Z + 1));

            }
            Console.WriteLine(sb.ToString());


            // Atsitiktinis bool generavimas
            Console.WriteLine("-------------");
            Console.WriteLine("Atsitiktinis bool generavimas");

            bool arTrue = rnd.Next(2) == 1;
            Console.WriteLine(arTrue);


            // Atsitiktinis skaiciu surasymas i array
            Console.WriteLine("-------------");
            Console.WriteLine("// Atsitiktinis skaiciu surasymas i array");

            int skaiciuKiekis = 10;
            int min = 0;
            int max = 10;
            int[] skaiciai = new int[skaiciuKiekis];
            for (int i = 0; i < skaiciuKiekis; i++)
            {
                skaiciai[i] = rnd.Next(min, max + 1);
            }

            Console.WriteLine(String.Join(" ", skaiciai));

            // Atsitiktiniu skaiciu surasymas i lista
            Console.WriteLine("-------------");
            Console.WriteLine("Atsitiktinis skaiciu surasymas i lista");
            List<int> listas = new List<int>();

            Console.WriteLine("Listas" + string.Join(" ", listas));
            for (int i = 0; i < skaiciuKiekis; i++)
            {
                listas.Add(rnd.Next(min, max+1));
            }
            Console.WriteLine("Listas" + string.Join(" ", listas));


            // Atsitiktinis rikiavimas (Shuffle)
            Console.WriteLine("-------------");
            Console.WriteLine("Atsitiktinis rikiavimas (Shuffle)");

            List<string> skaiciai1 = new List<string> { "1", "2", "3", "4", "5" };
            skaiciai1.Sort((a, b) => rnd.Next(10) - rnd.Next(10));

            Console.WriteLine(String.Join(", ", skaiciai1));

            // Geresenis random generavimas (System.Security.Cryptography.RandomNumberGenerator
           
            Console.WriteLine("-------------");
            Console.WriteLine("Geresenis random generavimas (System.Security.Cryptography.RandomNumberGenerator");

            for (int i = 0; i < 20; i++)
            {
                var randNumber = System.Security.Cryptography.RandomNumberGenerator.GetInt32(0, 10);
                Console.Write(" " + randNumber);
            }

            Console.WriteLine();


            // GUID
            Console.WriteLine("-------------");
            Console.WriteLine("GUID");
            Guid guid = Guid.NewGuid();

            Console.WriteLine(guid);
            updateGuid(guid);
            Console.WriteLine(guid);
            void updateGuid(Guid tmpGuid)
            {
                tmpGuid = Guid.NewGuid();
            }

            var guid1 = Guid.Parse("e7826647-5f91-40ba-93c9-bcaafccffba4");
            Console.WriteLine("Guid: " + guid1);

            bool isGuidParsed = Guid.TryParse("e7826647-5f91-40ba-93c9-bcaafccffba4", out var guid2);

            Console.WriteLine("Guid2: " + guid2);

            // Geresnis atsitiktinis rikiavimas

            Console.WriteLine("----------------");
            Console.WriteLine("Geresnis atsitiktinis rikiavimas");

            List<string> skaiciai2 = new List<string> { "1", "2", "3"};

            skaiciai2.Sort((a, b) => Guid.NewGuid().CompareTo(Guid.NewGuid()));
            Console.WriteLine(String.Join(", ", skaiciai2));


            // SEED

            Console.WriteLine("----------------");
            Console.WriteLine("SEED");

            Random rnd1 = new Random(10);
            Random rnd2 = new Random(10);

            for (int i = 0; i < 5; i++)
            {
                Console.Write(rnd1.Next(100) + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.Write(rnd2.Next(100) + " ");
            }
            Console.WriteLine();

        }

        static string RandomMetodasDebuginamas()
        {
            Random rnd = new Random();
            return rnd.Next(1, 10) > 5 ? "Dideja" : "Mazeja";
        }

        static string RandomMetodas(Random rnd)
        {
            return rnd.Next(1, 10) > 5 ? "Dideja" : "Mazeja";
        }

    }
}