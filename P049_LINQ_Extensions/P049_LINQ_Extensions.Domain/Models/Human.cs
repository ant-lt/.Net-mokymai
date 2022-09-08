using P049_LINQ_Extensions.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P049_LINQ_Extensions.Domain.Models
{
    public class Human
    {
        public Human()
        {

        }

        public Human(string firstName, string lastName, EGender gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Race { get; set; }
        public int ProfessionId { get; set; }
        public EGender Gender { get; set; }
    }
}
