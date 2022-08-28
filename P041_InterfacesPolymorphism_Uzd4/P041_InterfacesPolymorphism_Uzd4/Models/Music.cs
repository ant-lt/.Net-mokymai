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
        /// <summary>
        /// private fieldai butini interfeisui IHobby
        /// </summary>
        private string _name;
        private string _publisher;
        private string _genre;
        private int _rating;

        public int Id { get; set; }
        public int Length { get; set; }
        public string ArtistName { get; set; }

        public Music(string name, string publisher, string genre, int rating, int id, int length, string artistName)
        {
            _name = name;
            _publisher = publisher;
            _genre = genre;
            _rating = rating;
            Id = id;
            Length = length;
            ArtistName = artistName;
        }

        public string Name => _name;

        public string Publisher => _publisher;

        public string Genre => _genre;

        public int Rating => _rating;

        public string GetHobbyInformation()
        {
            return string.Format($"Muzika \"{Name}\" Artistas: {ArtistName} Žanras: {Genre} Įvertinimas: {Rating}");
        }

        public string GetHobbyName()
        {
            return "Listening music";
        }
    }
}
