using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace P059_MongoDb.Models
{
    public class DolarNumberInt
    {
        //[BsonElement("$numberInt")]
        [JsonProperty("$numberInt")]
        public string NumberInt { get; set; }

    }
}