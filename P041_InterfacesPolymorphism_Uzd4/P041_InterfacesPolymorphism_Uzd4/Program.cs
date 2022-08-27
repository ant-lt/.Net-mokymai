using System.Diagnostics.Metrics;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Linq;
using System;

namespace P041_InterfacesPolymorphism_Uzd4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Interfaces Polymorphism Uzduotis 4!");
        }
        /*
         * Uzduotis 4
        -	Sukurti<Movie> klase(Id, CreationDate)
        -	Sukurti<Music> klase(Id, Length, ArtistName)
        -	Sukurti<Game> klase(Id, Platform, IsMultiplayer)
        -	Sukurti<IHobby> interface ir visoms sukurtoms klasems sukurti interface implementacijas :
        o   String Name get
        o   String Publisher get
        o   String Genre get
        o   Int Rating get
        o   String GetHobbyName() -> Turetu grazinti atgal ar tai filmas, daina ar zaidimas
        o String GetHobbyInformation() -> Turetu grazinti atgal informacija apie pati hobi pvz, kad tai filmas kazkokio zanro, kurio ivertinimas yra X/Y
        -	Sukurti<Person> klase, kuri turetu savyje laikyti sarasa megstamiausiu dalyku.Turetume galeti programos eigoje prideti i ta pati sarasa bet koki Hobby t.y Movie, Music, Game
        -	Sukurti<IPerson>
        o   Void Interact(<IHobby>) -> Turetu atspausdinti i ekrana informacija apie tai kas ivyksta kada vartotojas nusprendzia uzsiimti paduota veikla.Pvz jei buna paduodamas filmas i ekrana turetu isvesti “<UserName> will now watch a<MovieName> which is a<Genre> movie.
        o   string GetFavoriteHobbyType() -> Turetu gauti hobio tipa (pvz Movie). Atspausdinti apie tai informacija I ekrana ir grazinti atgal hobio pavadinima
        o   IHobby GetFavoriteHobby() -> Turetu grazinti megstamiausios rusies hobio auksciausia ivertinima turincio iraso informacija
        o List<IHobby> GetFavoriteFromEachHobby() -> Turetu grazinti auksciausio ivertinimo irasa is kiekvienos rusies hobio
        o   String GetFavoriteMusicGenre() -> Turetu grazinti megstamiausia dazniausiai pasikartojanti muzikos zanra zmogaus hobiuose
        o   Dictionary<string, int> GetEachHobbyAvgRating() -> Grazina dictionary su irasais kuriuose key yra hobio tipas pvz filmas, o value yra vidurkis
        o Void ShareHobbies(<Person>) -> Pasidalina hobiais su paduotu zmogumi ir tie hobiai prisideda prie perduoto zmogaus hobiu
        o   Void ShareOldMovies(<Person>) -> Pasildaina filmais, kurie atsirado veliau nei 2010 metai
        o   List<IHobby> FindSimilarHobbies(<Person>) -> Grazina sarasa hobiu, kurie sutampa su perduoto zmogaus hobiais
        o List<IHobby> FindSimilarHobbies(<Person>, string hobbyType) -> Grazina sarasa hobiu, kurie sutampa su perduoto zmogaus hobiais ir yra tik tarp perduoto hobbyType pvz filmu
        o List<string> FindMatchingGenres(<Person>, string hobbyType) -> Randa sutampancius zanrus su paduoto zmogaus, kurie butu paduoto hobby tipo
        -	Prie<Person> pridekite nauja sarasa List<IHobby> CheckoutList
        -	Sukurkite nauja<Person> metoda void AddRandomToCheckList(<Person>), kuris prideda nauja(Nesikartojanti) hobby is kito zmogaus atsitiktine tvarka,
        -	Visus metodus istestuoskite
         *
         */

    }
}