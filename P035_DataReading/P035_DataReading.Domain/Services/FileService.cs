using P035_DataReading.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P035_DataReading.Domain.Services
{
    public class FileService
    {
        readonly string _filePath;

        public FileService(string filePath)
        {
            _filePath = filePath;
        }

        public string ReadTextFromFile()
        {
            return File.ReadAllText(_filePath);
        }

        public string[] ReadFileLines() => File.ReadAllLines(_filePath);

        public List<Animal> FetchAnimalTxtRecords()
        {
            int animalColumnCount = 2;
            List<Animal> animals = new List<Animal>();
            
            using StreamReader sr = new StreamReader(_filePath);

            string animalLine;

            while ((animalLine = sr.ReadLine()) != null)
            {
                string[] animalData = animalLine.Split(',');

                if (animalData.Length != animalColumnCount)
                {
                    break;
                }
                Animal newAnimal = new Animal(animalData);
                animals.Add(newAnimal);
            }

            return animals;
        }

        public void ReadSymbolsFromFile()
        {
            FileStream fileStream = File.OpenRead(_filePath);
            using StreamReader sr = new StreamReader(_filePath);
            
            char nextCharacter = (char)sr.Read();

            char[] bufferToPutStuffin = new char[2];

            sr.Read(bufferToPutStuffin, 0, 2);

            string whatWasReadIn = new string(bufferToPutStuffin);

            Console.WriteLine($"nextCharacter:{nextCharacter}");
            Console.WriteLine($"whatWasReadIn:{whatWasReadIn}");
            //sr.Close(); - nereikia , nes naudojame using StreamReader
        }

        public List<User> FetchBasicUserCsvRecords()
        {
            int userColumnCount = 2;
            List<User> users = new List<User>();

            using StreamReader sr = new StreamReader(_filePath);

            string userLine;

            // Nebutina setinti i kintamaji. Mokymo tikslais palikta tam, kad zinotume, jog tai yra headeris
            string headers = sr.ReadLine();

            while ((userLine = sr.ReadLine()) != null)
            {
                string[] userData = userLine.Split(',');

                if (userData.Length != userColumnCount)
                {
                    break;
                }
                User newUser = new User(userData);
                users.Add(newUser);
            }

            return users;
        }

        public string ExctractBasicUserCsvHeader()
        {
            using StreamReader sr = new StreamReader(_filePath);
            return sr.ReadLine();
        }

        public List<User1> FetchBasicUser1CsvRecords()
        {
            int userColumnCount = 8;
            List<User1> users = new List<User1>();

            using StreamReader sr = new StreamReader(_filePath);

            string userLine;

            // Nebutina setinti i kintamaji. Mokymo tikslais palikta tam, kad zinotume, jog tai yra headeris
            string headers = sr.ReadLine();

            while ((userLine = sr.ReadLine()) != null)
            {
                string[] userData = userLine.Split(',');

                if (userData.Length != userColumnCount)
                {
                    break;
                }
                User1 newUser = new User1(userData);
                users.Add(newUser);
            }

            return users;
        }

        public List<Hotel> FetchHotelCsvRecords()
        {
            int ColumnCount = 5;
            List<Hotel> hotels = new List<Hotel>();

            using StreamReader sr = new StreamReader(_filePath);

            string hotelLine;

            // Nebutina setinti i kintamaji. Mokymo tikslais palikta tam, kad zinotume, jog tai yra headeris
            string headers = sr.ReadLine();

            while ((hotelLine = sr.ReadLine()) != null)
            {
                string[] hotelData = hotelLine.Split(',');

                if (hotelData.Length != ColumnCount)
                {
                    continue;
                }
                Hotel newHotel = new Hotel(hotelData);
                hotels.Add(newHotel);
            }

            return hotels;
        }

    }
}
