using P041_InterfacesPolymorphism_Uzd4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P041_InterfacesPolymorphism_Uzd4.Models
{
    public class Music:IHobby
    {
        private const string _hobbyType = "Listening music";

        public int Id { get; set; }
        public int Length { get; set; }
        public string ArtistName { get; set; }
        public string Name { get; }
        public string Publisher { get; }
        public string Genre { get; }
        public int Rating { get; }

        public Music(int id, int length, string artistName, string name, string publisher, string genre, int rating)
        {
            Id = id;
            Length = length;
            ArtistName = artistName;
            Name = name;
            Publisher = publisher;
            Genre = genre;
            Rating = rating;
        }

        public string GetHobbyInformation() => $"Music  \"{Name}\" Artist: {ArtistName} Genre:{Genre}\nRating:{Rating}\nPublisher:{Publisher}";

        public string GetHobbyName() => _hobbyType;
    }
}
