using Newtonsoft.Json;
using P058_Json.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P058_Json
{
    public static class SerializeDeserializeSemo
    {
        public static void Show()
        {
            string json = InitialData.Samples.SingleJson();

            Console.WriteLine("Išvedame JSON tekstą:");
            Console.WriteLine(json);

            Console.WriteLine($"-------------------------------------------");
            Console.WriteLine("deserializuojame klase is JSON, isvedame varda ir pakeiciame varda:");
            Author author = JsonConvert.DeserializeObject<Author>(json);
            Console.WriteLine($"Vardas yra : {author.Name} ");
            author.Name = "Jonas Jonaitis";

            Console.WriteLine($"Pakeistas Vardas yra : {author.Name} ");


            Console.WriteLine($"-------------------------------------------");
            Console.WriteLine("serializuojame klase i JSON");
            string naujasJson = JsonConvert.SerializeObject(author);
            Console.WriteLine(naujasJson);


            Console.WriteLine($"-------------------------------------------");
            Console.WriteLine("suformatuotas JSON");
            string naujasIndentJson = JsonConvert.SerializeObject(author, Formatting.Indented);
            Console.WriteLine(naujasIndentJson);



        }

    }
}
