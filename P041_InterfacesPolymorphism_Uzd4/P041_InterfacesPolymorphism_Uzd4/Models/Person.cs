using P041_InterfacesPolymorphism_Uzd4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P041_InterfacesPolymorphism_Uzd4.Models
{
    public class Person: IPerson
    {
        public List<IHobby> CheckoutList = new List<IHobby>;

        /// <summary>
        ///  Prideda nauja(Nesikartojanti) hobby is kito zmogaus atsitiktine tvarka
        /// </summary>
        /// <param name="person"></param>
        public void AddRandomToCheckList(Person person)
        {
            person.
        }

        public List<string> FindMatchingGenres(Person toPerson, string hobbyType)
        {
            throw new NotImplementedException();
        }

        public List<IHobby> FindSimilarHobbies(Person toPerson)
        {
            throw new NotImplementedException();
        }

        public List<IHobby> FindSimilarHobbies(Person toPerson, string hobbyType)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, int> GetEachHobbyAvgRating()
        {
            throw new NotImplementedException();
        }

        public List<IHobby> GetFavoriteFromEachHobby()
        {
            throw new NotImplementedException();
        }

        public IHobby GetFavoriteHobby()
        {
            throw new NotImplementedException();
        }

        public string GetFavoriteHobbyType()
        {
            throw new NotImplementedException();
        }

        public string GetFavoriteMusicGenre()
        {
            throw new NotImplementedException();
        }

        public void Interact(IHobby hobby)
        {
            throw new NotImplementedException();
        }

        public void ShareHobbies(Person toPerson)
        {
            throw new NotImplementedException();
        }

        public void ShareOldMovies(Person toPerson)
        {
            throw new NotImplementedException();
        }
    }
}
