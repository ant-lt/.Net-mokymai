using P052_CodeFirstSqliteDb.Domain.Models;
using P052_CodeFirstSqliteDb.Infrastrukture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P052_CodeFirstSqliteDb.Infrastrukture.Database
{
    public class BloggingRepository : IBloggingRepository
    {
        public BloggingRepository()
        {
            using var context = new BloggingContext();
            // Naudojam kaip pavyzdi, kad zinoti, jog yra budas patikrinti ar duombaze siuo metu egzistuoja.
            // Jei neegzsituoja uz mus buna paleidziama CLI komanda update-datase
            context.Database.EnsureCreated();
        }

        public void AddPerson(Person person)
        {
            using var context = new BloggingContext();
            context.Persons.Add(person); // Pridedame perduota person i musu DbContext
            context.SaveChanges(); // Tai yra galutine vieta, kuri igyvendina jau suformuota uzklausa EntityFramework pagalba
        }

        public void AddPerson(string firstName, string lastName, DateTime birthDate)
        {
            using var context = new BloggingContext();

            Person person = new Person
            {
                FirstName = firstName,
                LastName = lastName,
                BirthDate = birthDate
            };

            context.Persons.Add(person); // Pridedame perduota person i musu DbContext
            context.SaveChanges();
        }

        public void PrintAllPersons()

        {
            using var context = new BloggingContext();

            var persons = context.Persons;

            foreach (var person in persons)
            {
                Console.WriteLine($"{person.PersonId}. {person.FirstName} {person.LastName} {person.BirthDate}");
            }
        }

        public void PrintAllPersonsSorted()
        {
            using var context = new BloggingContext();

            var persons = context.Persons
                .OrderBy(p => p.FirstName);

            foreach (var person in persons)
            {
                Console.WriteLine($"{person.PersonId}. {person.FirstName} {person.LastName}");
            }
        }
    }
}
