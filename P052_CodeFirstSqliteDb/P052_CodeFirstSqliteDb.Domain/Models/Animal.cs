using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P052_CodeFirstSqliteDb.Domain.Models
{
    public class Animal
    {
        public Animal()
        {

        }

        public Animal(int animalId, string name, string type, DateTime birthDate)
        {
            AnimalId = animalId;
            Name = name;
            Type = type;
            BirthDate = birthDate;
        }

        [Key]
        public int AnimalId { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
