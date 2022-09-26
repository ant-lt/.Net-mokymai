using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P058_Json
{
    public static class JsonDatesDemo
    {
        public static void Show()
        {
            Console.WriteLine("******* Dates demo ****");

            List<DateTime> dates = new List<DateTime>
            { 
                new DateTime(2022,09,26,21,22,00),
                new DateTime(2022,09,26),
                new DateTime(634455554555545454),
            };
            string jsonDateDefault = JsonConvert.SerializeObject(dates, Formatting.Indented);

            Console.WriteLine(jsonDateDefault);

            Console.WriteLine("------------------------------");
            Console.WriteLine(JsonConvert.SerializeObject(dates,
                Formatting.Indented,
                new JsonSerializerSettings
                {
                    DateFormatString = "dd/MM/yyyy"
                }));

            Console.WriteLine("------------------------------");
            // Java laiko konverteris 
            Console.WriteLine(JsonConvert.SerializeObject(dates,
            Formatting.Indented,
            new JavaScriptDateTimeConverter()));

        }
    }
}
