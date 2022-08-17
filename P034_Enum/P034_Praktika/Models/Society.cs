using P034_Praktika.Enum;
using P034_Praktika.InicialData;
using P034_Praktika.Klases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P034_Praktika.Models
{
    /*
     * Sukurkite klasę Society
         1- Sukurkite propertį People (List of persons)
         2- sukurkite metodą FillPeople kuris užpildys sąrašą iš klasės PersonInitialData.
         3- Sukurkite propertį OldPeople. Grąžinkite visus asmenis kurie gimė prieš 2001m. (unit-test)
         4- Sukurkite properčius Men ir Women.
         5- Sukurkite metodus FillMen ir FillWomen, kurie iš PersonInitialData surašys vyrus ir moteris (unit-test)
         6- sukurkite metodą SortByAge(), kuris Men ir Women sąrašus esančius asmenis surikiuotu pagal amžių nuo jauniausio iki vyriausio.
         7- Padarykite metodą kuris People, Men ir Women properčiuose esančius asmenis  rikiuos nuo A iki Z arba nuo Z iki A.
            Pagal Vardą arba Pavardę
              tokiu principu: SortByFirstName().Asc()
                              SortByLastName().Asc()
                              SortByLastName().Desc()
            <hint> return this
     * 
     */

    public class Society
    {
        public List<Person> People { get; set; } = new List<Person>();
        public List<Person> Men { get; set; } = new List<Person>();
        public List<Person> Women { get; set; } = new List<Person>();

        public List<Person> OldPeople
        {
            get
            {
                List<Person> _oldPeople = new List<Person>();

                foreach (Person person in People)
                {
                    if (person.BirthDate.Value.Year < 2001) _oldPeople.Add(person);
                }
                return _oldPeople;
            }
        }

        public void FillPeople()
        {
            People = new List<Person>();

            People = PersonInitialData.DataSeed.ToList();

        }

        public void FillMen()
        {
            foreach (Person person in PersonInitialData.DataSeed.ToList())
            {
                if (person.Gender == EGenderType.MALE) Men.Add(person);
            }
        }

        public void FillWomen()
        {
            foreach (Person person in PersonInitialData.DataSeed.ToList())
            {
                if (person.Gender == EGenderType.FEMALE) Women.Add(person);
            }
        }

        public void SortByAge()
        {
            People.OrderBy(p => p.Age);

        }
    }
}
