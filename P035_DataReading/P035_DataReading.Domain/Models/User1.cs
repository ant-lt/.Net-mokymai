using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P035_DataReading.Domain.Models
{
    public class User1
    {
        public User1()
        {

        }
        public User1(string[] userData)
        {
            Id = Convert.ToInt32(userData[0]);
            First_name = userData[1];
            Last_name = userData[2];
            Email = userData[3];
            Gender = userData[4];
            Salary = double.Parse(userData[5]);
            Favorite_color = userData[6];
            Birth_date = DateTime.Parse(userData[7]);
        }

        public User1(int id, string first_name, string last_name, string email, string gender, double salary, string favorite_color, DateTime birth_date)
        {
            Id = id;
            First_name = first_name;
            Last_name = last_name;
            Email = email;
            Gender = gender;
            Salary = salary;
            Favorite_color = favorite_color;
            Birth_date = birth_date;
        }

        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
        public string Favorite_color { get; set; }
        public DateTime Birth_date { get; set; }
        public string FullName()
        { return First_name + " " + Last_name; }
        public string GenderLT()
        {
            if (Gender == "Male") return "Vyras";
            else if (Gender == "Female") return "Moteris";
            else if (Gender == "Genderqueer") return "Pakeista lytis";
            else if (Gender == "Polygender") return "Daugialytis";
            else if (Gender == "Genderfluid") return "Genderfluidas";
            else if (Gender == "Bigender") return "Bigenderis";
            else return Gender;
        }

    }
}
