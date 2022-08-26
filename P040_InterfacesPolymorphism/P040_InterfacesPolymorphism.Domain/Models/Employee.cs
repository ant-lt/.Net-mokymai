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
        public Employee(double salary, string mailingAddress)
        {
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
