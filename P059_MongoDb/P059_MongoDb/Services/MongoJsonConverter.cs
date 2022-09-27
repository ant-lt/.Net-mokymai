using Newtonsoft.Json;

namespace P059_MongoDb.Services
{
    public class MongoJsonConverter<T> : JsonConverter
    {
        public override bool CanConvert(Type objectType) => true;

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.String)
            {
                string value = (string)reader.Value;
                return JsonConvert.DeserializeObject<T>(value);
            }
            return null;
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer) => throw new NotImplementedException();
    }
}
