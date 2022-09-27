using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using MongoDB.Bson.Serialization;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Data;
using P059_MongoDb.Database.Repositories;
using P059_MongoDb.Services;
using P059_MongoDb.Models;

namespace P059_MongoDb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Mongo Db!");
            IWeatherRepository repo = new WeatherRepository();
            
            //Console.WriteLine("----------------------------------------------------------------------");
            //Console.WriteLine(" > ADDING Documents");
            //var json = File.ReadAllText("InitialData/mongo_wether.json");

            //var list =  JsonConvert.DeserializeObject<List<WeatherData>>(json);
            //foreach (var item in list)
            //{
            //    repo.Add(item);
            //}


            
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine(" > Counting Documents");
            Console.WriteLine(repo.Count());

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine(" > LINQ Counting Documents");
            Console.WriteLine(repo.CountObj());

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine(" > Counting Filtered Documents (Bson)");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("st", "x+51900+003600");
            var a1 = repo.Count(filter);
            watch.Stop();
            Console.WriteLine($"{a1}   ({watch.ElapsedMilliseconds} ms)");


            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine(" > Counting Filtered Documents (LINQ)");
            watch = System.Diagnostics.Stopwatch.StartNew();
            var a2 = repo.Count(x => x.St == "x+51900+003600");
            watch.Stop();
            Console.WriteLine($"{a2}   ({watch.ElapsedMilliseconds} ms)");


            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine(" > Get All Documents in Bson format");
            watch = System.Diagnostics.Stopwatch.StartNew();
            var a5 = repo.All();
            watch.Stop();
            Console.WriteLine($"{a5.GetType()}  ({watch.ElapsedMilliseconds} ms)");

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine(" > Get All Documents in Object format");
            watch = System.Diagnostics.Stopwatch.StartNew();
            var a6 = repo.AllObj();
            watch.Stop();
            Console.WriteLine($" {a6.GetType()}  ({watch.ElapsedMilliseconds} ms)");



            
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine(" > Get First Document in Bson format");
            watch = System.Diagnostics.Stopwatch.StartNew();
            var a7 = repo.First(filter);
            watch.Stop();
            Console.WriteLine($"{a7}  ({watch.ElapsedMilliseconds} ms)");


            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine(" > Get First Document in Object format");
            watch = System.Diagnostics.Stopwatch.StartNew();
            var a8 = repo.FirstObj(x => x.St == "x+51900+003600");
            watch.Stop();
            Console.WriteLine($" {a8}  ({watch.ElapsedMilliseconds} ms)");

            
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine(" > Get Document by id in Bson format");
            watch = System.Diagnostics.Stopwatch.StartNew();
            var a9 = repo.Get("63332691a66a2d64d728c9b1");
            watch.Stop();
            Console.WriteLine($"{a9}  ({watch.ElapsedMilliseconds} ms)");

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine(" > Get Document by id in Object format");
            watch = System.Diagnostics.Stopwatch.StartNew();
            var a10 = repo.GetObj("63332691a66a2d64d728c9b1");
            watch.Stop();
            Console.WriteLine($" {a10}  ({watch.ElapsedMilliseconds} ms)");

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine(" > Add Document by id in Bson format");
            watch = System.Diagnostics.Stopwatch.StartNew();
            var string_to_add = @"{ ""st"" : ""x+99999-999999"", ""ts"" : ""5/3/1984 13:00:00"", ""position"" : ""{ \""type\"" : \""Point\"", \""coordinates\"" : [ -47.9, 47.6 ] }"", ""elevation"" : NumberLong(9999), ""callLetters"" : ""VCSZ"", ""qualityControlProcess"" : ""V020"", ""dataSource"" : ""4"", ""type"" : ""FM-13"", ""airTemperature"" : { ""value"" : -3.1000000000000001, ""quality"" : ""1"" }, ""dewPoint"" : { ""value"" : 999.89999999999998, ""quality"" : ""9"" }, ""pressure"" : { ""value"" : 1015.3, ""quality"" : ""1"" }, ""wind"" : { ""direction"" : { ""angle"" : { ""NumberInt"" : ""999"" }, ""quality"" : ""9"" }, ""quality"" : null, ""type"" : ""9"", ""speed"" : { ""angle"" : null, ""quality"" : ""9"" } }, ""visibility"" : ""{ \""distance\"" : { \""value\"" : { \""$numberInt\"" : \""999999\"" }, \""quality\"" : \""9\"" }, \""variability\"" : { \""value\"" : \""N\"", \""quality\"" : \""9\"" } }"", ""skyCondition"" : ""{ \""ceilingHeight\"" : { \""value\"" : { \""$numberInt\"" : \""99999\"" }, \""quality\"" : \""9\"", \""determination\"" : \""9\"" }, \""cavok\"" : \""N\"" }"", ""sections"" : ""[ \""AG1\"" ]"", ""precipitationEstimatedObservation"" : { ""discrepancy"" : ""2"", ""estimatedWaterDepth"" : { ""NumberInt"" : ""999"" } }, ""atmosphericPressureChange"" : null, ""atmosphericPressureObservation"" : null, ""seaSurfaceTemperature"" : null, ""waveMeasurement"" : null, ""liquidPrecipitation"" : null, ""pastWeatherObservationManual"" : null, ""presentWeatherObservationManual"" : null, ""skyConditionObservation"" : null, ""skyCoverLayer"" : null }";

            var bson_to_add = BsonDocument.Parse(string_to_add);
            var obj_to_add = BsonSerializer.Deserialize<WeatherData>(bson_to_add);
            repo.Add(obj_to_add);
            var id_added = obj_to_add._id;
            watch.Stop();
            Console.WriteLine($"Added id {id_added}  ({watch.ElapsedMilliseconds} ms)");
            
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine(" > Get Document by id in Bson format");
            watch = System.Diagnostics.Stopwatch.StartNew();
            var a11 = repo.Get(id_added.ToString());
            watch.Stop();
            Console.WriteLine($"{a11}  ({watch.ElapsedMilliseconds} ms)");

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine(" > Update Document by id in Bson format");
            watch = System.Diagnostics.Stopwatch.StartNew();
            var string_to_update = @"{ 
""_id"": ObjectId(""" + id_added + @"""),
""st"" : ""x+00000-999999"", 
""ts"" : ""5/3/1984 13:00:00"", 
""position"" : ""{ \""type\"" : \""Point\"", \""coordinates\"" : [ -47.9, 47.6 ] }"", 
""elevation"" : NumberLong(9999), 
""callLetters"" : ""VCSZ"", 
""qualityControlProcess"" : ""V020"", ""dataSource"" : ""4"", ""type"" : ""FM-13"", ""airTemperature"" : { ""value"" : -3.1000000000000001, ""quality"" : ""1"" }, ""dewPoint"" : { ""value"" : 999.89999999999998, ""quality"" : ""9"" }, ""pressure"" : { ""value"" : 1015.3, ""quality"" : ""1"" }, ""wind"" : { ""direction"" : { ""angle"" : { ""NumberInt"" : ""999"" }, ""quality"" : ""9"" }, ""quality"" : null, ""type"" : ""9"", ""speed"" : { ""angle"" : null, ""quality"" : ""9"" } }, ""visibility"" : ""{ \""distance\"" : { \""value\"" : { \""$numberInt\"" : \""999999\"" }, \""quality\"" : \""9\"" }, \""variability\"" : { \""value\"" : \""N\"", \""quality\"" : \""9\"" } }"", ""skyCondition"" : ""{ \""ceilingHeight\"" : { \""value\"" : { \""$numberInt\"" : \""99999\"" }, \""quality\"" : \""9\"", \""determination\"" : \""9\"" }, \""cavok\"" : \""N\"" }"", ""sections"" : ""[ \""AG1\"" ]"", ""precipitationEstimatedObservation"" : { ""discrepancy"" : ""2"", ""estimatedWaterDepth"" : { ""NumberInt"" : ""999"" } }, ""atmosphericPressureChange"" : null, ""atmosphericPressureObservation"" : null, ""seaSurfaceTemperature"" : null, ""waveMeasurement"" : null, ""liquidPrecipitation"" : null, ""pastWeatherObservationManual"" : null, ""presentWeatherObservationManual"" : null, ""skyConditionObservation"" : null, ""skyCoverLayer"" : null }";

            var obj_to_update = BsonSerializer.Deserialize<WeatherData>(string_to_update);
            repo.Update(id_added.ToString(), obj_to_update);
            var a12 = repo.Get(id_added.ToString());
            watch.Stop();
            Console.WriteLine($"{a12}  ({watch.ElapsedMilliseconds} ms)");

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine(" > Delete Document by id in Bson format");
            watch = System.Diagnostics.Stopwatch.StartNew();
            repo.Remove(id_added.ToString());
            var a13 = repo.Get(id_added.ToString());
            watch.Stop();
            Console.WriteLine($" {a13}  ({watch.ElapsedMilliseconds} ms)");
        }
    }
}