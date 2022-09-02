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
        private const string _hobbyType = "Gaming";
        public int Id { get; set; }
        public string PlatForm { get; set; }
        public bool IsMultiplayer { get; set; }
        public string Name { get; }
        public string Publisher { get; }

        public string Genre { get; }

        public int Rating { get; }

        public Game(int id, string platForm, bool isMultiplayer, string gameName, string gamePublisher, string gameGenre, int gameRating)
        {
            Id = id;
            PlatForm = platForm;
            IsMultiplayer = isMultiplayer;
            Name = gameName;
            Publisher = gamePublisher;
            Genre = gameGenre;
            Rating = gameRating;
        }

        public string GetHobbyInformation() => $"Genre:{Genre}\nRating:{Rating}\nPublisher:{Publisher}";

        public string GetHobbyName() => _hobbyType;
    }
}
