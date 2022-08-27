using P041_InterfacesPolymorphism_Uzd4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P041_InterfacesPolymorphism_Uzd4.Models
{
    public class Person
    {
        public List<IHobby> CheckoutList;

        /// <summary>
        ///  prideda nauja(Nesikartojanti) hobby is kito zmogaus atsitiktine tvarka
        /// </summary>
        /// <param name="person"></param>
        public void AddRandomToCheckList(Person person)
        {

        }
    }
}
