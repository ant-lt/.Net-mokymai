using P049_LINQ_Extensions.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P049_LINQ_Extensions.Domain.Interfaces
{
    public interface IHumanFactory
    {
        IEnumerable<Human> Bing();
    }
}
