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
        public string Name { get; set; }
        public List<IHobby> Hobbies { get; set; }

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
        //public List<IHobby> GetFavoriteFromEachHobby()
        //{
        //    Dictionary<string, int> favoriteHobbyOccurence = GetHobbyOccurances();
        //    Dictionary<IHobby> favoriteHobbies = new List<IHobby>();

        //    foreach(KeyValuePair<string, int> hobbyTypes in favoriteHobbyOccurence)
        //    {
        //        foreach (IHobby hobby in Hobbies)
        //        {
        //            if(hobby.GetHobbyName() == hobbyTypes.Key)
        //            {
        //                favoriteHobbies[]
        //            }    
        //        }
        //    }
        //}

        private Dictionary<string, int> GetHobbyOccurances()
        {
            Dictionary<string, int> favoriteHobbyOccurence = new Dictionary<string, int>();

            List<string> allHobbyTypes = GetHobbyTypes();

            foreach (string hobby in allHobbyTypes)
            {
                favoriteHobbyOccurence.Add(hobby, 0);
            }

            foreach (IHobby hobby in Hobbies)
            {
                favoriteHobbyOccurence[hobby.GetHobbyName()] += 1;
            }

            return favoriteHobbyOccurence;
        }

        public string GetFavoriteHobby()
        {
            Dictionary<string, int> favoriteHobbyOccurence = GetHobbyOccurances();

            string favoriteHobby = string.Empty;

            foreach (KeyValuePair<string, int> hobby in favoriteHobbyOccurence)
            {
                if (hobby.Value > favoriteHobbyOccurence[favoriteHobby])
                {
                    favoriteHobby = hobby.Key;
                }
            }

            IHobby favHobby = null;

            foreach (IHobby hobby in Hobbies)
            {
                if (hobby.GetHobbyName() == favoriteHobby)
                {
                    if (favHobby.Rating < hobby.Rating)
                    {
                        favHobby = hobby;
                    }
                }
            }
            // Jei turetume grazinti objekta vietoj string
            //return favHobby;
            return favoriteHobby;
        }

        private List<string> GetHobbyTypes()
        {
            List<string> result = new List<string>();

            foreach (var hobby in Hobbies)
            {
                string hobbyName = hobby.GetHobbyName();

                if (!result.Contains(hobbyName))
                {
                    result.Add(hobbyName);
                }
            }

            return result;
        }

        public string GetFavoriteHobbyType()
        {
            Hobbies.Sort((h1, h2) => h1.Rating.CompareTo(h2.Rating));

            return Hobbies.FirstOrDefault().Name;
        }

        public string GetFavoriteMusicGenre()
        {
            throw new NotImplementedException();
        }

        public void Interact(IHobby hobby)
        {
            Console.WriteLine($"{Name} person is currently interacting with {hobby.GetHobbyName()} {hobby.Name}");
        }

        public void ShareHobbies(Person toPerson)
        {
            throw new NotImplementedException();
        }

        public void ShareOldMovies(Person toPerson)
        {
            throw new NotImplementedException();
        }

        string IPerson.GetFavoriteHobby()
        {
            throw new NotImplementedException();
        }
    }
}
