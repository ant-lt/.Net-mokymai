using P049_LINQ_Extensions.Domain.Interfaces;
using P049_LINQ_Extensions.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P049_LINQ_Extensions
{
    public class ExcerciseModel
    {
        /*
        * ​Uzduotis 1: Sarase “List<int> { 9, 78, 85, 115, 39, 49, 55, 100, 523, 95 }” isfiltruokite skaicius, kurie butu didesni arba lygus 35, bet mazesni arba lygus 99. Istestuokite.
        */
        public List<int> FirstExcerciseLinqFiltering(List<int> initialNumbers)
        {
            initialNumbers = initialNumbers
                .Where(n => n >= 35 && n <= 99)
                .ToList();

            return initialNumbers;
        }


        /*
        * Uzduotis 2:
        * Parasykite programa, kuri is spalvu saraso “List<string> { "Red", "Green", "Blue", "Teal", "Grey", "Purple", “Magenta”, “Tomato”, “Cyan” }” 
        * istrauktu spalvas, kuriu ilgis yra didesnis 4 raides, projekcijos pagalba padarykite, kad visus rezultatus grazintu didziosiomis raidemis. Istestuokite.Uzduotis 2:
        *
        */

        public List<string> SecondExcerciseLinqFiltering(List<string> colors)
        {
            colors = colors
                .Where(n => n.Length > 4 )
                .Select(n => n.ToUpper())
                .ToList();

            return colors;
        }


        /*
        * Uzduotis 3:
            Parasykite programa, kuri is zodziu kratinio “List<string> {“dangus”, “afro”, “vanduo”, “darzelis”, “darzove”, “kremas”, “valdiklis”,”daumantas”, “mokinys”, “pazymys”,”danguole”} 
            isvestu I ekrana zodzius, kurie prasideda raide “d” ir baigiasi raide “s”. Istestuokite.
        * 
        */

        public List<string> ThirdExcerciseLinqFiltering(List<string> words)
        {

            words = words
                .Where(text => text.StartsWith("d") && text.EndsWith("s") )
                .ToList();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

            return words;
        }

        /*
        * Uzduotis 4:
        *  Naudojant CharacterInitialData užpildyti žmonių(Human) sąrašą.
            - Žmonių sąrašui užpildyti implementuokite interfeisą IHumanFactory su metodu Bind()
            Metodas Bind() iškoduoja DataSeed ir grąžina reikiamą objektą (Bind() turetu grazinti IEnumerable<Human>)
            - Užpildytą sąrašą išvesti į konsolę
 * 
 */

        public void FourthExcerciseLinqFiltering()
        {
            IHumanFactory humanData = new HumanFactory();

            IEnumerable<Human> humans = humanData.Bing();

            foreach (Human human in humans)
            {
                Console.WriteLine($"{human.FirstName}, {human.LastName}, {human.ProfessionId}, {human.Gender}, {human.Race}");
            }
        }


    }
}
