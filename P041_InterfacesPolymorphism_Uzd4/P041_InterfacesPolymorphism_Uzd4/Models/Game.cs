using P041_InterfacesPolymorphism_Uzd4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P041_InterfacesPolymorphism_Uzd4.Models
{
    public class Game: IHobby
    {
        /// <summary>
        /// private fieldai butini interfeisui IHobby
        /// </summary>
        private string _name;
        private string _publisher;
        private string _genre;
        private int _rating;

        public int Id { get; set; }
        public string Platform { get; set; }
        public bool IsMultiplayer { get; set; }

        public Game(int id, string platform, bool isMultiplayer, string gameName, string gamePublisher, string gameGenre, int gameRating)
        {
            Id = id;
            Platform = platform;
            IsMultiplayer = isMultiplayer;

            /*
            * Duomenys IHobby implementacijai
            */
            _name = gameName;
            _publisher = gamePublisher;
            _genre = gameGenre;
            _rating = gameRating;
        }

        public string Name => _name;

        public string Publisher => _publisher;

        public string Genre => _genre;

        public int Rating => _rating;

        public string GetHobbyInformation()
        {
            return string.Format($"Žaidimas \"{Name}\" Žanras: {Genre} Įvertinimas: {Rating}");
        }

        public string GetHobbyName()
        {
            return "Gaming";
        }
    }
}
