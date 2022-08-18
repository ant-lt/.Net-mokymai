using P035_DataReading.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P035_DataReading.Domain.Models
{
    public class Person
    {
        private string _firstName;
        private string _lastName;

        public Person()
        {
        }

        public Person(EGenderType gender)
        {
            Gender = gender;
        }

        public int Id { get; set; }
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (!string.IsNullOrWhiteSpace(_firstName))
                {
                    NameChanges += $"{_firstName} -> {value} ";
                }
                _firstName = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (!string.IsNullOrWhiteSpace(_lastName))
                {
                    NameChanges += $"{_lastName} -> {value} ";
                }

                _lastName = value;
            }
        }

        public string FullName => $"{FirstName} {LastName}";
        public EGenderType Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public int? Age => GetAge();
        public string NameChanges { get; private set; }




        private int? GetAge()
        {
            if (BirthDate == null)
                return null;

            var ts = DateTime.Now.Subtract((DateTime)BirthDate);
            return new DateTime(ts.Ticks).Year - 1;
        }

        public void ChangeGender(EGenderType gender)
        {
            Gender = gender;
        }

        // Perrasom egzistuojanti Object metoda, kad galetume sulyginti duomenis testuose
        public override bool Equals(object obj)
        {
            // Ar paduotas objektas yra null
            // Ar paduoto objekto klase yra ta pati klase su kuria lyginame(this)
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            // Castinam paduota objekta i mums reikalinga klase
            Person person = obj as Person;

            return (FirstName.Equals(person.FirstName))
                && (LastName.Equals(person.LastName))
                && (Gender.Equals(person.Gender));
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
