using OOPMetodai.Domain.Models;

namespace OOP_Metodai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, OOP Metodai!");
            
            var staciakampis1 = new Staciakampis(5, 5);

            Console.WriteLine($"Staciakampio 1 plotas yra: {staciakampis1.ApskaiciuotiPlota()}");
            staciakampis1.PakeistiIlgi(8);
            Console.WriteLine($"Staciakampio 1 plotas yra: {staciakampis1.ApskaiciuotiPlota()}");


            /*
            * 1.    OopMetodai – Parasykite klase Kalbejimas, kuri turetu string „garsas“ konstruktoriu 
            *  ir turetu metoda „Kalbeti“, kuri i ekrana isvestu musu zodzius
            */
            var sunsKalbejimas = new Kalbejimas("Au");
            var katesKalbejimas = new Kalbejimas("Mia");
            var paukstelioKalbejimas = new Kalbejimas("Cip Cip");


            sunsKalbejimas.Kalbeti();
            katesKalbejimas.Kalbeti();
            paukstelioKalbejimas.Kalbeti();

        }
    }
}