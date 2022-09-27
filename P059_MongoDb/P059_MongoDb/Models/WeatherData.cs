using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using P059_MongoDb.Services;
using System.Runtime.Serialization;

namespace P059_MongoDb.Models
{
    public class WeatherData
    {
        [OnDeserialized]
        protected void OnDeserializedMethod(StreamingContext context)
        {
            AirTemperature = JsonConvert.DeserializeObject<AirTemperature>(AirTemperature_str);
        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonIgnore]
        public ObjectId _id { get; set; }

        [BsonElement("st")]
        public string St { get; set; }

        [BsonElement("ts")]
        public string Ts { get; set; }

        [BsonElement("position")]
        public object Position { get; set; }

        [BsonElement("elevation")]
        public long Elevation { get; set; }

        [BsonElement("callLetters")]
        public string CallLetters { get; set; }

        [BsonElement("qualityControlProcess")]
        public string QualityControlProcess { get; set; }

        [BsonElement("dataSource")]
        public string DataSource { get; set; }

        [BsonElement("type")]
        public string Type { get; set; }

        [BsonElement("airTemperature")]
        [JsonIgnore]
        public AirTemperature? AirTemperature { get; set; }

        [BsonIgnore]
        [JsonProperty("airTemperature")]
        public string? AirTemperature_str { get; set; }


        [BsonElement("dewPoint")]
        [JsonConverter(typeof(MongoJsonConverter<DewPoint>))]
        public DewPoint? DewPoint { get; set; }

        [BsonElement("pressure")]
        [JsonConverter(typeof(MongoJsonConverter<Pressure>))]
        public Pressure? Pressure { get; set; }

        [BsonElement("wind")]
        [JsonConverter(typeof(MongoJsonConverter<Wind>))]
        public Wind? wind { get; set; }

        [BsonElement("visibility")]
        //[JsonConverter(typeof(MongoJsonConverter<object>))]
        public object? Visibility { get; set; }

        [BsonElement("skyCondition")]
        //[JsonConverter(typeof(MongoJsonConverter<object>))]
        public object? SkyCondition { get; set; }

        [BsonElement("sections")]
        //[JsonConverter(typeof(MongoJsonConverter<object>))]
        public object? Sections { get; set; }

        [BsonElement("precipitationEstimatedObservation")]
        [JsonConverter(typeof(MongoJsonConverter<PrecipitationEstimatedObservation>))]
        public PrecipitationEstimatedObservation? PrecipitationEstimatedObservation { get; set; }

        [BsonElement("atmosphericPressureChange")]
        [JsonConverter(typeof(MongoJsonConverter<AtmosphericPressureChange>))]
        public AtmosphericPressureChange? AtmosphericPressureChange { get; set; }

        [BsonElement("atmosphericPressureObservation")]
        //[JsonConverter(typeof(MongoJsonConverter<object>))]
        public object? AtmosphericPressureObservation { get; set; }

        [BsonElement("seaSurfaceTemperature")]
        //[JsonConverter(typeof(MongoJsonConverter<object>))]
        public object? SeaSurfaceTemperature { get; set; }

        [BsonElement("waveMeasurement")]
        //[JsonConverter(typeof(MongoJsonConverter<object>))]
        public object? WaveMeasurement { get; set; }

        [BsonElement("liquidPrecipitation")]
        //[JsonConverter(typeof(MongoJsonConverter<object>))]
        public object? LiquidPrecipitation { get; set; }

        [BsonElement("pastWeatherObservationManual")]
        //[JsonConverter(typeof(MongoJsonConverter<object>))]
        public object? PastWeatherObservationManual { get; set; }

        [BsonElement("presentWeatherObservationManual")]
        //[JsonConverter(typeof(MongoJsonConverter<object>))]
        public object? PresentWeatherObservationManual { get; set; }

        [BsonElement("skyConditionObservation")]
        //[JsonConverter(typeof(MongoJsonConverter<object>))]
        public object? SkyConditionObservation { get; set; }

        [BsonElement("skyCoverLayer")]
        //[JsonConverter(typeof(MongoJsonConverter<object>))]
        public object? SkyCoverLayer { get; set; }



    }
}
