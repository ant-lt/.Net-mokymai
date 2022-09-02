using P041_InterfacesPolymorphism_Uzd4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P041_InterfacesPolymorphism_Uzd4.Models
{
    public class Movie:IHobby
    {
        private const string _hobbyType = "Watching movie";
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Name { get; }
        public string Publisher { get; }
        public string Genre { get; }
        public int Rating { get; }

        public Movie(int id, DateTime creationDate, string name, string publisher, string genre, int rating)
        {
            Id = id;
            CreationDate = creationDate;
            Name = name;
            Publisher = publisher;
            Genre = genre;
            Rating = rating;
        }

        public string GetHobbyInformation() => $"Genre:{Genre}\nRating:{Rating}\nPublisher:{Publisher}";

        public string GetHobbyName() => _hobbyType;
    }
}
