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
        private ESocietySortBy sortBy;
        // 1 uzdavinio sprendimas
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
        // 2 uzdavinio sprendimas
        public void FillPeople()
        {
            People = PersonInitialData.DataSeed.ToList();
        }

        public void FillPeople(List<Person> people)
        {
            People = people;
            this.FillMen(people);
            this.FillWomen(people);
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

        public void FillMen(List<Person> people)
        {
            Men = new List<Person>();
            foreach (var person in people)
            {
                if (person.Gender == EGenderType.MALE)
                {
                    Men.Add(person);
                }
            }
        }

        public void FillWomen(List<Person> people)
        {
            Women = new List<Person>();
            foreach (var person in people)
            {
                if (person.Gender == EGenderType.FEMALE)
                {
                    Women.Add(person);
                }
            }
        }


        //6- sukurkite metodą SortByAge(), kuris Men ir Women sąrašuose esančius asmenis surikiuotu pagal amžių nuo jauniausio iki vyriausio. (unit-test)
        // su LINQ
        public void SortByAge()
        {
            Men.Sort((a, b) => a.BirthDate >= b.BirthDate ? 1 : -1);
            Women.Sort((a, b) => a.BirthDate >= b.BirthDate ? 1 : -1);
        }

        //6- sukurkite metodą SortByAge(), kuris Men ir Women sąrašuose esančius asmenis surikiuotu pagal amžių nuo jauniausio iki vyriausio. (unit-test)
        // be LINQ su bubble
        public void SortByAge(List<Person> list)
        {
            Person tempPerson;
            for (int j = 0; j <= list.Count; j++)
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i].BirthDate < list[i + 1].BirthDate)
                    {
                        tempPerson = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = tempPerson;
                    }
                }
            }
        }


        /*
         7- Padarykite metodą kuris People, Men ir Women properčiuose esančius asmenis  rikiuos nuo A iki Z arba nuo Z iki A.  (unit-test)
             Pagal Vardą arba Pavardę
             tokiu principu: SortByFirstName().Asc()
                             SortByLastName().Desc()
            <hint> return this
         */
        public Society SortByFirstName()
        {
            sortBy = ESocietySortBy.FirstName;
            return this;
        }

        public Society SortByLastName()
        {
            sortBy = ESocietySortBy.LastName;
            return this;
        }

        public void Asc()
        {
            switch (sortBy)
            {
                case ESocietySortBy.FirstName:
                    People.Sort((a, b) => a.FirstName.CompareTo(b.FirstName));
                    break;
                case ESocietySortBy.LastName:
                    People.Sort((a, b) => a.FirstName.CompareTo(b.LastName));
                    break;
                default:
                    break;
            }
        }

        public void Desc()
        {
            switch (sortBy)
            {
                case ESocietySortBy.FirstName:
                    People.Sort((a, b) => b.FirstName.CompareTo(a.FirstName));
                    break;
                case ESocietySortBy.LastName:
                    People.Sort((a, b) => b.FirstName.CompareTo(a.LastName));
                    break;
                default:
                    break;
            }
        }

    }
}
