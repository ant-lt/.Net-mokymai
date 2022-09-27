using MongoDB.Bson.Serialization.Attributes;

namespace P059_MongoDb.Models
{
    public class AirTemperature
    {
        [BsonElement("value")]
        public double? value { get; set; }

        [BsonElement("quality")]
        public string? quality { get; set; }
    }
}