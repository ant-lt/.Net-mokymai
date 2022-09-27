using MongoDB.Bson.Serialization.Attributes;

namespace P059_MongoDb.Models
{
    public class AtmosphericPressureChange
    {
        [BsonElement("tendency")]
        public AtmosphericPressureChangeTendency? Tendency { get; set; }

        [BsonElement("quantity3Hours")]
        public AtmosphericPressureChangeQuantity? Quantity3Hours { get; set; }

        [BsonElement("quantity24Hours")]
        public AtmosphericPressureChangeQuantity? Quantity24Hours { get; set; }

        public class AtmosphericPressureChangeTendency
        {
            [BsonElement("code")]
            public string? Code { get; set; }

            [BsonElement("quality")]
            public string? Quality { get; set; }
        }
        public class AtmosphericPressureChangeQuantity
        {
            [BsonElement("value")]
            public double? Value { get; set; }

            [BsonElement("quality")]
            public string? Quality { get; set; }
        }
    }
}