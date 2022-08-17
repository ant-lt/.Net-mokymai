using P034_Praktika.Klases;
using P034_Praktika.Models;

namespace P034_Praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Enum praktika!");

            Society society = new Society();

            society.FillPeople();
            List<Person> people = society.OldPeople;
            society.SortByAge();
            

        }

    }
    /*
    * Sukurkite enum EGenderType su reikšmėmis 0 - MALE, 1 - FEMALE
      * 
      */



}