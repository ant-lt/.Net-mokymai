using P052_CodeFirstSqliteDb.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P052_CodeFirstSqliteDb.Infrastrukture.Interfaces
{
    public interface IBloggingRepository
    {
        public void AddPerson(Person person);
        public void AddPerson(string firstName, string lastName, DateTime birthDate);
        public void PrintAllPersons();
        public void PrintAllPersonsSorted();
        public void AddAnimal(Animal animal);
        public void PrintAllAnimalSortedl();

        public List<Animal> FetchingAnimalofType(string type);
    }
}
