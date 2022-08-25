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
        public int Salary { get; set; }

        public string GetAdress()
        {
            throw new NotImplementedException();
        }

        public double GetSalary()
        {
            throw new NotImplementedException();
        }

        public void IncreaseSalary(double salary)
        {
            throw new NotImplementedException();
        }
    }
}
