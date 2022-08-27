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
        public int Id { get; set; }
        public int Length { get; set; }
        public string ArtistName { get; set; }

        public string Name => throw new NotImplementedException();

        public string Publisher => throw new NotImplementedException();

        public string Genre => throw new NotImplementedException();

        public int Rating => throw new NotImplementedException();

        public string GetHobbyInformation()
        {
            throw new NotImplementedException();
        }

        public string GetHobbyName()
        {
            throw new NotImplementedException();
        }
    }
}
