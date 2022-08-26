using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P040_InterfacesPolymorphism.Domain.Interfaces
{
    public interface IPayable
    {
        double GetSalary();
        void IncreaseSalary(double salary);
        string GetAddress();
    }
}
