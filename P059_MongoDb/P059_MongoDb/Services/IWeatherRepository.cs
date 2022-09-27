using MongoDB.Bson;
using MongoDB.Driver;
using P059_MongoDb.Models;

namespace P059_MongoDb.Services
{
    public interface IWeatherRepository
    {
        void Add(BsonDocument document);
        void Add(WeatherData document);
        List<BsonDocument> All();
        List<WeatherData> AllObj();
        long Count();
        long Count(FilterDefinition<BsonDocument> filter);
        long Count(Func<WeatherData, bool> predicate);
        long CountObj();
        BsonDocument First(FilterDefinition<BsonDocument> filter);
        WeatherData FirstObj(Func<WeatherData, bool> predicate);
        WeatherData FirstObj1(FilterDefinition<WeatherData> filter);
        BsonDocument Get(string id);
        WeatherData GetObj(string id);
        void Remove(string id);
        void Update(string id, BsonDocument document);
        void Update(string id, WeatherData document);
    }
}