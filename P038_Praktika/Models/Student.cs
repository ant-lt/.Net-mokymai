using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P038_Praktika.Models
{
    public class Student : UniversityPerson
    {
        public Student() : base()
        {
        }

        public Student(Random rnd) : base(rnd)
        {
        }

        private readonly List<string> invalidProfessions = new List<string> { "Lecturer", "Teacher", "Scientist" };

        private Profession profession;
        public override Profession Profession
        {
            get => profession;
            set
            {
                if (invalidProfessions.Contains(value.Text))
                {
                    throw new Exception();
                }
                else
                {
                    profession = value;
                }
            }
        }

        public List<Profession> Courses { get; set; }


        public void SetCourses(Profession[] data)
        {
            Courses = new List<Profession>();
            List<int> indexesTaken = new List<int>();

            int count = _rnd.Next(1, 4);
            for (int i = 0; i < count; i++)
            {
                int index;
                do
                {
                    index = _rnd.Next(0, data.Length);
                }
                while (indexesTaken.Contains(index) || invalidProfessions.Contains(data[index].Text));
                indexesTaken.Add(index);
            }

            foreach (var index in indexesTaken)
            {
                Courses.Add(data[index]);
            }

        }

    }
}
