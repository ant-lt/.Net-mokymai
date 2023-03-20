namespace BookWebApiRepo_MSSQL_EF.Services
{
    public class ShippingApiProxyService : IShippingApiProxyService
    {
        private readonly string apiKey = "5b3ce3597851110001cf624809ba9eba1e9e4f99a3843e23cfcc1026";
        private readonly string vilnius_coordinates = "25.286808098040524, 54.6856225079123";
        


        private readonly IHttpClientFactory _httpClientFactory;

        public ShippingApiProxyService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<string> GetCityLocation(string city)
        {
            var httpClient = _httpClientFactory.CreateClient("ShippingApiUri");
            var endpoint = "geocode/search";

            var reponse = await httpClient.GetAsync(endpoint + "?api_key=" + apiKey + "&text=" + city);
            if (reponse.IsSuccessStatusCode)
            {
                var content = await reponse.Content.ReadAsStringAsync();
                return GetCoordinatesFromResponseString(content);
            }
            return "";
        }

        private string GetCoordinatesFromResponseString(string content)
        {
            string text = "type\":\"Point\",\"coordinates\":[";
            var start = content.IndexOf(text) + text.Length;
            var end = content.IndexOf("]", start);
            return content.Substring(start, end - start);
        }


        public async Task<double?> GetDistanceFromCoordinates(string coordinates)
        {
            var httpClient = _httpClientFactory.CreateClient("ShippingApiUri");
            var endpoint = "/v2/directions/driving-car";


            var reponse = await httpClient.GetAsync(endpoint + "?api_key=" + apiKey + "&start=" + vilnius_coordinates + "&end=" + coordinates);
            if (reponse.IsSuccessStatusCode)
            {
                var content = await reponse.Content.ReadAsStringAsync();
                var distanceInKm = GetDistanceInMetersFromResponseString(content) / 1000;
                return distanceInKm;
            }
            return null;
        }

        private double GetDistanceInMetersFromResponseString(string content)
        {
            string text = "summary\":{\"distance\":";
            var start = content.IndexOf(text) + text.Length;
            var end = content.IndexOf(",\"duration\"", start);
            var distanceInMeters = Convert.ToDouble(content.Substring(start, end - start));
            return distanceInMeters;
        }
    }
}
