using P040_InterfacesPolymorphism.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P040_InterfacesPolymorphism.Domain.Models
{
    public class Employee : Person, IPayable
    {
        /// <summary>
        /// Employee klasės konstruktorius
        /// </summary>
        /// <param name="id">Asmens ID</param>
        /// <param name="name">Vardas</param>
        /// <param name="lastName">Pavardė</param>
        /// <param name="salary">Nustatytas atlyginimas</param>
        /// <param name="mailingAddress">Pašto adresas</param>
        public Employee(int id = 1, string name = "Vardenis", string lastName = "Pavardenis", double salary = 0, string mailingAddress = "" )
        {
            //person klases duomenys / property
            Id = id;
            Name = name;
            LastName = lastName;

            // Employee klasės property priskyrimas
            Salary = salary;
            MailingAddress = mailingAddress;
        }

        private double Salary { get; set; }
        public string MailingAddress { get; private set; }

        public string GetAddress()
        {
            return MailingAddress;
        }

        public double GetSalary()
        {
            return Salary;
        }

        public void IncreaseSalary(double salary)
        {

            Salary += salary;
        }
    }
}
