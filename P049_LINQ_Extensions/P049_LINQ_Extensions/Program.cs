using P049_LINQ_Extensions.Domain.InitialData;
using P049_LINQ_Extensions.Domain.Interfaces;
using P049_LINQ_Extensions.Domain.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace P049_LINQ_Extensions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, LINQ!");

            // LINQ - Language Integrated Query
            // "Data iteration engine", bet jei mes bandytume sutrumpinti kazkas versle nenorejo sio dalyko vadinti DIE

            // IEnumerable sudaro 1 atributas
            // IEnumerator sudaro 2 pagrindiniai atributai: Current property ir Next() metodas
            // IEnumerable<int> result = GenerateNumbers(10); // Calling without Yield

            // Calling with yield
            // IEnumerable<int> result = GenerateNumbersWithYield(10);

            // Pipeline of instructions - Grandine veiksmu seku
            //IEnumerable<int> result = GenerateNumbersWithYield(10)
            //    .Where(n => n % 2 == 0)
            //    .Select(n => n * 3); // Projection of element

            // Nieko sugeneruojam iki kol nedaeinam pirmo Foreach ciklo arba pirmo IEnumerator.Next() metodo panaudojimo
            // Filtruojame kartu su istraukimu ir visiskai neapkrauname atminties nereikalinga data/duomenimis.
            IEnumerable<int> result = GenerateNumbersWithYield(10)
                .Where(n =>
                {
                    return n % 2 == 0;
                })
                .Select(n =>
                {
                    return n * 3; // Projection of element
                });

            // Kartu nesames visus duomenis, nes mes nenaudodami Yield prasome programos grazinti viska cia ir dabar
            IEnumerable<int> resultWithoutYield = GenerateNumbers(10)
                .Where(n =>
                {
                    return n % 2 == 0;
                })
                .Select(n =>
                {
                    return n * 3; // Projection of element
                });

            bool isEven = true;

            IEnumerable<int> isEvenResult = GenerateNumbersWithYield(10);

            if (isEven)
            {
                isEvenResult = isEvenResult.Where(n => n % 2 == 0 && n != 0);
                isEvenResult = isEvenResult.Where(n => n != 9);
            }

            // Eiliskumas LINQ yra labai svarbu, nes mes grazindami lyginius skaicius pasakome, kad tuos lyginius skaicius padaugintu is 3 is issaugotu
            isEvenResult = isEvenResult.Select(n => n * 3);
            isEvenResult = isEvenResult.Select(n => n * 3);

            Console.WriteLine("Middle of process.");

            foreach (var number in isEvenResult)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("End of process.");


            LinqSamples();

            LinqExtensionSyntaxWithObjects();


            Uzd1();

            Uzd2();

            Uzd3();

            Uzd4();

        }

        public static IEnumerable<int> GenerateNumbers(int maxValue)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < maxValue; i++)
            {
                numbers.Add(i);
            }

            return numbers;
        }

        // Yield naudojame tada kada mes zinome, kad nezinome koki kieki duomenu mums reikes laikyti atmintyje
        // Nauda: Performance, speed, doesnt break the server or application
        public static IEnumerable<int> GenerateNumbersWithYield(int maxValue)
        {
            for (int i = 0; i < maxValue; i++)
            {
                // Uzdelstas reiksmes grazinimas
                yield return i;
            }
        }


        public static void LinqSamples()
        {
            // OrderBy, OrderByDescending, Where, Any, Count, Contains - Filtravimo
            // Take, Skip, Distinct - Rusiavimo. Pavyzdys butu eshop puslapiai ir jo elementai.
            // Sum, Min, Max, Average - Matematines funkcijos

            List<string> cities = new List<string> { "Vilnius", "Kaunas", "Klaipeda", "Alytus", "Vilnius" };
            List<int> numbers = new List<int> { 3, 3, 5, 7, 8, 10 };

            Console.WriteLine("Visi miestai {0}", string.Join(", ", cities));
            // string.Join calls Next() method to initiate IEnumerator iterations
            Console.WriteLine("Miestai, kurie prasideda su raide K: {0}", string.Join(", ", cities.Where(c => c.StartsWith("K"))));
            Console.WriteLine("Miestai is K raides: {0}", cities.Count(city => city.StartsWith("K")));
            Console.WriteLine("Ar yra miestas Vilnius? {0}", cities.Any(c => c == "Vilnius") ? "Taip" : "Ne");
            Console.WriteLine("Ar yra miestas Utena? {0}", cities.Any(c => c == "Utena") ? "Taip" : "Ne");
            Console.WriteLine("Ar yra miestu tarp miestu is masyvo [Taurage, Pabrade]? {0}", cities.Any(c => (new string[] { "Taurage", "Pabrade" }).Contains(c)) ? "Taip" : "Ne");
            Console.WriteLine("Ar yra miestu tarp miestu is masyvo [Vilnius, Taurage, Pabrade]? {0}", cities.Any(c => (new string[] { "Vilnius", "Taurage", "Pabrade" }).Contains(c)) ? "Taip" : "Ne");
            Console.WriteLine("Surikiuoti miestai nuo A iki Z: {0}", string.Join(", ", cities.OrderBy(c => c)));
            Console.WriteLine("Surikiuoti miestai nuo Z iki A: {0}", string.Join(", ", cities.OrderByDescending(c => c)));
            Console.WriteLine("Du miestai is saraso: {0}", string.Join(", ", cities.Take(2)));
            Console.WriteLine("Paimt miestus is saraso be pirmu dvieju elementu: {0}", string.Join(", ", cities.Skip(2)));
            Console.WriteLine("Unikalus miestai: {0}", string.Join(", ", cities.Distinct()));

            Console.WriteLine("Skaiciu suma: {0}", numbers.Sum());
            Console.WriteLine("Skaiciu minimali reiksme: {0}", numbers.Min());
            Console.WriteLine("Skaiciu maximali reiksme: {0}", numbers.Max());
            Console.WriteLine("Skaiciu vidurkio reiksme: {0}", numbers.Average());
            Console.WriteLine("Unikaliu mazesniu uz 5 skaiciu vidurkis: {0}", numbers.Distinct().Where(n => n < 5).Average());

            List<int> numbers2 = new List<int> { 88, 99};
            //sujungia du skaicius ir paskaiciuoja vidurki
            Console.WriteLine("Sujungti skaiciai: {0}", numbers.Concat(numbers2).Average());

        }

        public static void LinqExtensionSyntaxWithObjects()
        {
            // 1 pavyzdys - string projektavimas
            var grownUps = PersonInitialData.DataSeed
                .Where(person => person.Age >= 18);

            Console.WriteLine("Suage asmenys: {0}", string.Join(", ", grownUps.Select(gu => $"{Environment.NewLine}{gu.FirstName} {gu.LastName} amzius: {gu.Age}")));

            // 2 pavyzdys - DTO projektavimas (DTO - Data Transfer Object)

            var projectedDtoPersonList = PersonInitialData.DataSeed
                .Select(p => new PersonDto
                {
                    Age = p.Age,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                });

            foreach(var personDto in projectedDtoPersonList)
            {
                Console.WriteLine("Asmuo {0} {1} amzius {2}", personDto.FirstName, personDto.LastName, personDto.Age);
            }


            // query syntax

            var queryPerson =
                from p in PersonInitialData.DataSeed
                select new PersonDto
                {
                    Age=p.Age,
                    FirstName=p.FirstName,
                    LastName=p.LastName
                };


        }



        /*
        * ​Uzduotis 1: Sarase “List<int> { 9, 78, 85, 115, 39, 49, 55, 100, 523, 95 }” isfiltruokite skaicius, kurie butu didesni arba lygus 35, bet mazesni arba lygus 99. Istestuokite.
        */


        public static void Uzd1()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Uzduotis Nr. 1");

            ExcerciseModel excerciseModel = new ExcerciseModel();

            List<int> digitsList = new List<int> { 9, 78, 85, 115, 39, 49, 55, 100, 523, 95 }; // 35 - 99 

            List<int> digits = excerciseModel.FirstExcerciseLinqFiltering(digitsList);

            foreach (int digit in digits)
            {
                Console.WriteLine(digit);
            }

        }


        /*
        * 
        * Uzduotis 2:
        Parasykite programa, kuri is spalvu saraso “List<string> { "Red", "Green", "Blue", "Teal", "Grey", "Purple", “Magenta”, “Tomato”, “Cyan” }” 
        istrauktu spalvas, kuriu ilgis yra didesnis 4 raides, projekcijos pagalba padarykite, kad visus rezultatus grazintu didziosiomis raidemis. Istestuokite.Uzduotis 2:
        *
        */
        public static void Uzd2()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Uzduotis Nr. 2");

            ExcerciseModel excerciseModel = new ExcerciseModel();

            List<string> colorsList = new List<string> { "Red", "Green", "Blue", "Teal", "Grey", "Purple", "Magenta", "Tomato", "Cyan" };

            List<string> filteredColors = excerciseModel.SecondExcerciseLinqFiltering(colorsList);

            foreach(string color in filteredColors)
            {
                Console.WriteLine(color);
            }

        }


        /*
         * Uzduotis 3:
            Parasykite programa, kuri is zodziu kratinio “List<string> {“dangus”, “afro”, “vanduo”, “darzelis”, “darzove”, “kremas”, “valdiklis”,”daumantas”, “mokinys”, “pazymys”,”danguole”} 
            isvestu I ekrana zodzius, kurie prasideda raide “d” ir baigiasi raide “s”. Istestuokite.
         * 
         */

        public static void Uzd3()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Uzduotis Nr. 3");

            ExcerciseModel excerciseModel = new ExcerciseModel();

            List<string> text = new List<string> { "dangus", "afro", "vanduo", "darzelis", "darzove", "kremas", "valdiklis", "daumantas", "mokinys", "pazymys", "danguole" };


            excerciseModel.ThirdExcerciseLinqFiltering(text);

        }


        /*
         * Uzduotis 4:
         *  Naudojant CharacterInitialData užpildyti žmonių(Human) sąrašą.
            - Žmonių sąrašui užpildyti implementuokite interfeisą IHumanFactory su metodu Bind()
                 Metodas Bind() iškoduoja DataSeed ir grąžina reikiamą objektą (Bind() turetu grazinti IEnumerable<Human>)
            - Užpildytą sąrašą išvesti į konsolę
         * 
         */
        public static void Uzd4()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Uzduotis Nr. 4");
            ExcerciseModel excerciseModel = new ExcerciseModel();
            excerciseModel.FourthExcerciseLinqFiltering();

            Console.WriteLine("---------------------------");
           




        }

    }

}