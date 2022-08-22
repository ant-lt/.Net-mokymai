using P038_Praktika.InitialData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P038_Praktika.Models
{
    public class UniversityPerson
    {
        public Profession Profession { get; set; }
        public List<Hobby> Hobbies { get; set; }

        private Random _rnd;

        public UniversityPerson()
        {
            _rnd = new Random();
        }

        public UniversityPerson(Random rnd)
        {
            _rnd = rnd;
        }

        public void SetHobbies()
        {
            Hobbies = new List<Hobby>();
            int hobbiesCount = _rnd.Next(0, 5);



        }
    }
}
