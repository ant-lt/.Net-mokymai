using MongoDB.Bson.Serialization.Attributes;

namespace P059_MongoDb.Models
{
    public class PrecipitationEstimatedObservation
    {
        [BsonElement("discrepancy")]
        public string? discrepancy { get; set; }

        [BsonElement("estimatedWaterDepth")]
        public DolarNumberInt? estimatedWaterDepth { get; set; }


    }
}