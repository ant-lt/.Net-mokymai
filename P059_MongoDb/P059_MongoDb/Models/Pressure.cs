using MongoDB.Bson.Serialization.Attributes;

namespace P059_MongoDb.Models
{
    public class Pressure
    {
        [BsonElement("value")]
        public double? value { get; set; }

        [BsonElement("quality")]
        public string? quality { get; set; }
    }
}