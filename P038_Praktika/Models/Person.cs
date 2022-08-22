using P038_Praktika.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P038_Praktika.Models
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

    }
}
