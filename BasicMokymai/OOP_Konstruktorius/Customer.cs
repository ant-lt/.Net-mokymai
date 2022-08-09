using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Konstruktorius
{
    internal class Customer
    {
        // Tuscio konstruktoriaus deklaravimas
        public Customer() 
        {
            Vardas = "Siuardas";
        }

        public Customer(string vardas)
        {
            Vardas = vardas;
        }

        public String Vardas { get; set; }
       
    }
}
