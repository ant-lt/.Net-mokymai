namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, List!");

            List<string> stringMasyvas = new List<string> { "Zodis1", "Zodis2","..........."};
            List<int> intMasyvas = new List<int> { 1, 2, 3,44,5 };
            List<string> automobiliai = new List<string> { "Audi", "VW", "Opel", "Volvo" };
            automobiliai.Add("BMW");
            Console.WriteLine(string.Join(", ", automobiliai));
            automobiliai[1] = "Subaru";
            Console.WriteLine(string.Join(", ", automobiliai));
            Console.WriteLine("kiekis " + automobiliai.Count);
            Console.WriteLine("talpa " + automobiliai.Capacity);
            Console.WriteLine("------------------");
            automobiliai.Add("BMW");
            Console.WriteLine("talpa " + automobiliai.Capacity);
            
            automobiliai.Add("BMW");
            Console.WriteLine("------------------");
            Console.WriteLine("kiekis " + automobiliai.Count);
            Console.WriteLine("talpa " + automobiliai.Capacity);


            //metodai
            Console.WriteLine("------------------");
            automobiliai.Add("Citroen");
            Console.WriteLine(string.Join(", ", automobiliai));

            //prideti daug elementu i gala
            Console.WriteLine("------------------");
            List<string> daugAutomobiliai = new List<string> { "BMW", "Mercedes"};
            automobiliai.AddRange(daugAutomobiliai);
            Console.WriteLine(string.Join(", ", automobiliai));

            // isvalyti lista
            //Console.WriteLine("------------------");
            // automobiliai.Clear();
            // Console.WriteLine("isvalyta" + string.Join(", ", automobiliai));

            // istrinti elementa
            Console.WriteLine("------------------");
            automobiliai.RemoveAt(4);
            Console.WriteLine(string.Join(", ", automobiliai));

            Console.WriteLine("Kiekis " + automobiliai.Count );

            // iterpimas
            Console.WriteLine("------------------");
            automobiliai.Insert(2, "BMW");
            Console.WriteLine("Kiekis " + automobiliai.Count);
            Console.WriteLine(string.Join(", ", automobiliai));

            //paieska
            Console.WriteLine("------------------");
            bool arYraVW = automobiliai.Contains("VW");
            Console.WriteLine("Ar yra VW?" + arYraVW);

            bool arYraBMW = automobiliai.Contains("BMW");
            Console.WriteLine("Ar yra BMW?" + arYraBMW);

            //rikiavimas
            Console.WriteLine("------------------");
            automobiliai.Sort();
            Console.WriteLine(string.Join(", ", automobiliai));

            //rikiavimas atbuline tvarka
            Console.WriteLine("------------------");
            automobiliai.Sort((x, y) => y.CompareTo(x));
            Console.WriteLine(string.Join(", ", automobiliai));

            // int skaiciu rikiavimas nuo mazejimo iki didesnio
            Console.WriteLine("------------------");
            intMasyvas.Sort();
            Console.WriteLine(string.Join(", ", intMasyvas));

            // int skaiciu rikiavimas nuo didesnio iki mazejimo
            Console.WriteLine("------------------");
            intMasyvas.Sort((x,y) => y - x);
            Console.WriteLine(string.Join(", ", intMasyvas));

            Console.WriteLine("------------------");
            string[] automobiliuMasyvas = automobiliai.ToArray();

            //paieska
            Console.WriteLine("------------------");
            automobiliai.Add("VW");

            string pirmasKurYra = automobiliai.Find(x => x.Contains("V"));
            Console.WriteLine("Pirmas automobilis kur yra V "  + pirmasKurYra);

            List<string> visiKurYraV = automobiliai.FindAll(x => x.Contains("V"));
            Console.WriteLine(string.Join(", ", visiKurYraV ));

            List<int> visiVirs6 = intMasyvas.FindAll(x => x > 6);
            Console.WriteLine("Didesnis uz 6 yra "+string.Join(", ", visiVirs6));

            int[] intMasyvas2 = new int[] {1,2,3,4};
            List<int> skaiciai = intMasyvas2.ToList();

        }
    }
}