using MongoDB.Bson;
using MongoDB.Driver;
using P059_MongoDb.Models;
using P059_MongoDb.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P059_MongoDb.Database.Repositories
{
    public class WeatherRepository : IWeatherRepository
    {
        private readonly IMongoCollection<BsonDocument> _collection;
        private readonly IMongoCollection<WeatherData> _obj_collection;

        public WeatherRepository()
        {
            MongoClient dbClient = new MongoClient("mongodb://localhost:27017/");
            var sample_weatherdata = dbClient.GetDatabase("sample_weatherdata");

            _collection = sample_weatherdata.GetCollection<BsonDocument>("data");
            _obj_collection = sample_weatherdata.GetCollection<WeatherData>("data");
        }

        public long Count()
        {
            return _collection.CountDocuments(new BsonDocument());
        }
        public long Count(FilterDefinition<BsonDocument> filter)
        {
            return _collection.CountDocuments(filter);
        }

        public long CountObj()
        {
            return _obj_collection.AsQueryable().Count();
        }
        public long Count(Func<WeatherData, bool> predicate)
        {
            return _obj_collection.AsQueryable().Count(predicate);
        }

        public List<BsonDocument> All()
        {
            return _collection.Find(_ => true).ToList();
        }
        public List<WeatherData> AllObj()
        {
            var all_documents = _obj_collection.Find(_ => true).ToList();
            return all_documents;
        }

        public BsonDocument First(FilterDefinition<BsonDocument> filter)
        {
            var res = _collection.Find(filter).First();
            return res;
        }

        public WeatherData FirstObj1(FilterDefinition<WeatherData> filter)
        {
            var res = _obj_collection.Find(filter).First();
            return res;
        }

        public WeatherData FirstObj(Func<WeatherData, bool> predicate)
        {
            var res = _obj_collection.AsQueryable().First(predicate);
            return res;
        }

        public BsonDocument Get(string id)
        {
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(id));

            var res = _collection.Find(filter).FirstOrDefault();
            return res;
        }
        public WeatherData GetObj(string id)
        {
            var res = _obj_collection.AsQueryable().FirstOrDefault(x => x._id == new ObjectId(id));
            return res;
        }

        public void Update(string id, WeatherData document)
        {
            _obj_collection.ReplaceOne(x => x._id == new ObjectId(id), document);
        }

        public void Update(string id, BsonDocument document)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(id));
            _collection.UpdateOne(filter, document);
        }
        public void Add(BsonDocument document)
        {
            _collection.InsertOne(document);
        }
        public void Add(WeatherData document)
        {
            _obj_collection.InsertOne(document);
        }

        public void Remove(string id)
        {
            _obj_collection.DeleteOne(x => x._id == new ObjectId(id));
        }
    }
}
