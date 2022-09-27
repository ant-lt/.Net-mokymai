using MongoDB.Bson.Serialization.Attributes;

namespace P059_MongoDb.Models
{
    public class Wind
    {

        [BsonElement("direction")]
        public WindDirection? Direction { get; set; }

        [BsonElement("quality")]
        public string Quality { get; set; }

        [BsonElement("type")]
        public string Type { get; set; }

        [BsonElement("speed")]
        public WindSpeed Speed { get; set; }

        public class WindDirection
        {
            [BsonElement("angle")]
            public DolarNumberInt? angle { get; set; }

            [BsonElement("quality")]
            public string? quality { get; set; }
        }

        public class WindSpeed
        {
            [BsonElement("angle")]
            public double? angle { get; set; }

            [BsonElement("quality")]
            public string? quality { get; set; }
        }
    }
}