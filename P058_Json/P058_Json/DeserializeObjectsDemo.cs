using Newtonsoft.Json;
using P058_Json.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P058_Json
{
    public static class DeserializeObjectsDemo
    {
        public static void Show()
        {
            string jsonString = @"{
            'name':'Vardenis Pavardenis',
            'courses':['C#', 'T-SQL'],
            'happy': true,
            }";

            Console.WriteLine("Išvedame JSON tekstą:");
            Console.WriteLine(jsonString);


            Console.WriteLine($"-------------------------------------------");
            Author authorObj = JsonConvert.DeserializeObject<Author>(jsonString);
            Console.WriteLine($"Vardas yra: {authorObj.Name}");
            authorObj.Name = "Jonas Jonaitis";
            Console.WriteLine($"Pakeistas vardas yra : {authorObj.Name}");


            Console.WriteLine($"-------------------------------------------");
            var author = JsonConvert.DeserializeObject(jsonString);
            Console.WriteLine($"Vardas yra : {author}");


            Console.WriteLine($"-------------------------------------------");

            var jsonFromFile = File.ReadAllText("autorius.json");
            Author authorFromFile = JsonConvert.DeserializeObject<Author>(jsonFromFile);

            Console.WriteLine($"Vardas yra : {authorFromFile.Name}");


        }
    }
}
