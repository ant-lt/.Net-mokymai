using P041_InterfacesPolymorphism_Uzd4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace P041_InterfacesPolymorphism_Uzd4.Interfaces
{
    public interface IPerson
    {

        /// <summary>
        /// Turetu atspausdinti i ekrana informacija apie tai kas ivyksta kada vartotojas nusprendzia uzsiimti paduota veikla.
        /// Pvz jei buna paduodamas filmas i ekrana turetu isvesti “<UserName> will now watch a<MovieName> which is a<Genre> movie.
        /// </summary>
        /// <param name="hobby"></param>
        void Interact(IHobby hobby);

        /// <summary>
        /// Atspausdinti hobio tipa informacija I ekrana ir grazinti atgal hobio pavadinima
        /// </summary>
        /// <returns>Grazinti atgal hobio pavadinima</returns>
        string GetFavoriteHobbyType();

        /// <summary>
        ///  Turetu grazinti megstamiausios rusies hobio auksciausia ivertinima turincio iraso informacija
        /// </summary>
        /// <returns>Megstamiausios rusies hobio auksciausia ivertinima turincio iraso informacija</returns>
        IHobby GetFavoriteHobby();

        /// <summary>
        /// Turetu grazinti auksciausio ivertinimo irasa is kiekvienos rusies hobio
        /// </summary>
        /// <returns>Grazinti auksciausio ivertinimo irasa is kiekvienos rusies hobio</returns>
        List<IHobby> GetFavoriteFromEachHobby();

        /// <summary>
        /// Turetu grazinti megstamiausia dazniausiai pasikartojanti muzikos zanra zmogaus hobiuose
        /// </summary>
        /// <returns>Turetu grazinti megstamiausia dazniausiai pasikartojanti muzikos zanra zmogaus hobiuose</returns>
        string GetFavoriteMusicGenre();

        /// <summary>
        /// Grazina dictionary su irasais kuriuose key yra hobio tipas pvz filmas, o value yra vidurkis
        /// </summary>
        /// <returns></returns>
        Dictionary<string, int> GetEachHobbyAvgRating();


        /// <summary>
        /// Pasidalina hobiais su paduotu zmogumi ir tie hobiai prisideda prie perduoto zmogaus hobiu
        /// </summary>
        /// <param name="toPerson"></param>
        void ShareHobbies(Person toPerson);

        /// <summary>
        /// Pasildaina filmais, kurie atsirado veliau nei 2010 metai
        /// </summary>
        /// <param name="toPerson"></param>
        void ShareOldMovies(Person toPerson);

        /// <summary>
        /// Grazina sarasa hobiu, kurie sutampa su perduoto zmogaus hobiais
        /// </summary>
        /// <param name="toPerson"></param>
        /// <returns></returns>
        List<IHobby> FindSimilarHobbies(Person toPerson);

        /// <summary>
        /// Grazina sarasa hobiu, kurie sutampa su perduoto zmogaus hobiais ir yra tik tarp perduoto hobbyType pvz filmu
        /// </summary>
        /// <param name="toPerson"></param>
        /// <param name="hobbyType"></param>
        /// <returns></returns>
        List<IHobby> FindSimilarHobbies(Person toPerson, string hobbyType);

        /// <summary>
        /// Randa sutampancius zanrus su paduoto zmogaus, kurie butu paduoto hobby tipo
        /// </summary>
        /// <param name="toPerson"></param>
        /// <param name="hobbyType"></param>
        /// <returns></returns>
        List<string> FindMatchingGenres(Person toPerson, string hobbyType); 
    }
}
