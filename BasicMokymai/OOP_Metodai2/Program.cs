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

            var sunsKalbejimas = new Kalbejimas("Au");
            var katesKalbejimas = new Kalbejimas("Mia");
            var paukstelioKalbejimas = new Kalbejimas("Cip Cip");


            sunsKalbejimas.Kalbeti();
            katesKalbejimas.Kalbeti();
            paukstelioKalbejimas.Kalbeti();


            var skaiciuoklis = new Skaiciuoklis(5);
            skaiciuoklis.Atspausdinti();
            skaiciuoklis.Mazinti();

        }





        /*
         * 1.    OopMetodai – Parasykite klase Kalbejimas, kuri turetu string „garsas“ konstruktoriu 
         *  ir turetu metoda „Kalbeti“, kuri i ekrana isvestu musu zodzius
         * 
         */

        /*
         *
         * 2.	Parasykite klase „Skaiciuoklis“, kuris turetu 1 private property pavadinimu Skaicius ir 3 metodus: Didinti (Padidina Skaicius 1), Mazinti(Sumazina Skaicius 1), Atspausdinti()
            a.	Padarykite, kad Mazinti() metodas negaletu sumazinti <Skaicius> maziau 0
            b.	Sukurkite metoda Perkrauti() <Reset>, kuris turetu grazinti <Skaicius> i pradine busena (Perkrauti metodas turetu nepriimti jokiu parametru)
         * 
         * 
         */


    }
}