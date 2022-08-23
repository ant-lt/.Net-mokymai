using P038_Praktika.InitialData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P038_Praktika.Models
{
    public class UniversityPerson:Person
    {
        public virtual Profession Profession { get; set; }
        public List<Hobby> Hobbies { get; set; }


        protected Random _rnd;

        public UniversityPerson()
        {
            _rnd = new Random();
        }

        public UniversityPerson(Random rnd)
        {
            _rnd = rnd;
        }
        
        public void SetHobbies(string[] data)
        {
            Hobbies = new List<Hobby>();
            Random random = new Random();
            List<int> indexesTaken = new List<int>(); //masyvas loginantys kokie indexai jau buvo paimti

            //sugeneruoti skaiciu nuo 0 iki 4 - hobiu kieki
            int hobbiesCount = _rnd.Next(0, 5);
            for (int i = 0; i < hobbiesCount; i++)
            {
                int hobbyIndex;

                do
                {
                    hobbyIndex = _rnd.Next(0, data.Length);
                } while (indexesTaken.Contains(hobbyIndex));
                
                indexesTaken.Add(hobbyIndex);
            }

            FillHobbies(data, indexesTaken);
        }

        public void SetProfession(Profession[] data)
        {
            int professionIndex = _rnd.Next(0, data.Length);
            Profession = data[professionIndex];
        }

        public void SetProfession(string[] data)
        {
            int professionIndex = _rnd.Next(0, data.Length);
            Profession profession = new();
            profession.EncodeCsv(data[professionIndex].Replace(";", ","));
            Profession = profession;
        }

        public string GetCsv()
        {
            return $"{Id},{FirstName},{LastName},{Gender},{BirthDate},{Weight},{Height},{Profession.Id}" +
                $",{(Hobbies.Count > 0 ? Hobbies[0].Id : "")}" +
                $",{(Hobbies.Count > 1 ? Hobbies[1].Id : "")}" +
                $",{(Hobbies.Count > 2 ? Hobbies[2].Id : "")}" +
                $",{(Hobbies.Count > 3 ? Hobbies[3].Id : "")}";
        }

        private void FillHobbies(string[] data, List<int> indexesTaken)
        {
            foreach (int hobbyIndex in indexesTaken)
            {
                Hobby h = new Hobby();
                h.EncodeCsv(data[hobbyIndex]);
                Hobbies.Add(h);
            }
        }
    }
}
