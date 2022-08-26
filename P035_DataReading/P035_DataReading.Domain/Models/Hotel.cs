using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P035_DataReading.Domain.Models
{
    public class Hotel
    {

        public Hotel(int id, string name, int ratting, string streetName, DateTime creationDate)
        {
            Id = id;
            Name = name;
            Rating = ratting;
            StreetName = streetName;
            CreationDate = creationDate;
        }

        public Hotel(int id, string name, int ratting, string streetName, DateTime creationDate, List<User1> users) : this(id, name, ratting, streetName, creationDate)
        {
            this.users = users;
        }

        public Hotel(string[] hotelData)
        {
            Id = Convert.ToInt32(hotelData[0]);
            Name = hotelData[1];
            Rating = Convert.ToInt32(hotelData[2]);
            StreetName = hotelData[3];
            CreationDate = DateTime.Parse(hotelData[4]);
        }


        //id,name,rating,street_name,creation_date
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }
        public string StreetName { get; set; }
        public DateTime CreationDate { get; set; }

        List<User1> users = new List<User1>();

    }
}
