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
        /// <summary>
        /// private fieldai butini interfeisui IHobby
        /// </summary>
        private string _name;
        private string _publisher;
        private string _genre;
        private int _rating;

        public int Id { get; set; }
        public DateTime CreationDate { get; set; }

        public Movie(string name, string publisher, string genre, int rating, int id, DateTime creationDate)
        {
            _name = name;
            _publisher = publisher;
            _genre = genre;
            _rating = rating;
            Id = id;
            CreationDate = creationDate;
        }

        public string Name => _name;

        public string Publisher => _publisher;

        public string Genre => _genre;

        public int Rating => _rating;

        public string GetHobbyInformation()
        {
            return string.Format($"Filmas \"{Name}\" Žanras: {Genre} Įvertinimas: {Rating}");
        }

        public string GetHobbyName()
        {
            return "Watching movie";
        }
    }
}
