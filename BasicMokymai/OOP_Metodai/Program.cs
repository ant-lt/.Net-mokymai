using OOPMetodai.Domain.Models;

namespace OOP_Metodai
{
    internal class Program
    {
        // Vizualizacija Access Modifiers
        // https://raw.githubusercontent.com/gist/michail-peterlis/67ab9f81f16cd2fb074d8ea9c8008653/raw/1b41929acf1cab64b4cb386966659e079a9edef5/access_modifier.svg

        static void Main(string[] args)
        {
            // Get - Reiksmiu istraukimas
            // Set - Reiksmiu ivedimas
            
            Console.WriteLine("Hello, OOP Metodai!");

            var namas1 = new Namas(5, "Vilniaus g. 78");

            Console.WriteLine($"Yra darzas: {namas1.YraDarzas}");
            Namas namas2 = new(); // C# 9.0 Pristatytas objekto inicializavimo budas
            /*
            //namas1.KambariusSkaicius = 4;
            foreach (var namoGyventojoVardas in namas1.ZmoniuVardai)
            {
                Console.WriteLine($"Namo gyventojo vardas: {namoGyventojoVardas}");
            }
            */

            /*
            *    Uzduotis 4: Atnaujinti kiekvienai is klasiu aprasytu 1 uzduotyje atributus(kontrakta) taip, kad atributu reiksmes galima butu skaityti is isores, bet nustatyti reiksmes butu galima tik klases viduje.
            *    Savarankiskai (Namas, salis, knyga)
            */



        }
    }
}