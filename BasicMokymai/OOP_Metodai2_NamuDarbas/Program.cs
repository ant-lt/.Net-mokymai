using OOPMetodai.Domain.Models;
using System.Text;

namespace OOP_Metodai2_NamuDarbas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(1200);
            Console.InputEncoding = Encoding.GetEncoding(1200);

            Console.WriteLine("Hello, Namų darbas!");


            Console.WriteLine("3. Sukurkite „Produktas“ klase");
            var produktas = new Produktas(1.11d, 10, "Kivi");

            produktas.SpausdintiProdukta();
            Console.WriteLine();

            Console.WriteLine("4. Pasirašyti klasę <SkaiciuKrepselis>");

            var vidurkiai = new SkaiciuKrepselis();

            vidurkiai.PridėtiSkaiciu(2);
            vidurkiai.PridėtiSkaiciu(3);
            vidurkiai.PridėtiSkaiciu(5);

            Console.WriteLine($"Vidurkis = {vidurkiai.ApskaiciuotiVidurki():F}");

        }
    }
}