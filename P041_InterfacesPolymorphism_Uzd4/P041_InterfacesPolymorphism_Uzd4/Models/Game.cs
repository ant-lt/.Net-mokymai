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
        public int Id { get; set; }
        public string Platform { get; set; }
        public bool IsMultiplayer { get; set; }

        public Game(int id, string platform, bool isMultiplayer)
        {
            Id = id;
            Platform = platform;
            IsMultiplayer = isMultiplayer;
        }

        public string Name => Name;

        public string Publisher => Publisher;

        public string Genre => Genre;

        public int Rating => Rating;

        public string GetHobbyInformation()
        {
            return string.Format($"tai žaidimas {Name} zanras:{Genre}, ivertinimas yra {Rating}");
        }

        public string GetHobbyName()
        {
            return "Gaming";
        }
    }
}
