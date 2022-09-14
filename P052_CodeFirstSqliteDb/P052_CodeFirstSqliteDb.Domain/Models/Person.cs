using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P052_CodeFirstSqliteDb.Domain.Models
{
    // CodeFirst approache - Klase yra lentele
    public class Person
    {
        public Person() { }

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        // PirmaryKey - pirminis raktas
        // Pirminis raktas yra visada unikalus
        // Reliacines duombazes (Relationships between tables)
        [Key]
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // public int Age { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Email { get; set; }
        public double? Height { get; set; }
    }
}
