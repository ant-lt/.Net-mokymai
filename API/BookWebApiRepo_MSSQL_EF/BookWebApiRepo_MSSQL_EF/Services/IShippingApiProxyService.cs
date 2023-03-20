namespace BookWebApiRepo_MSSQL_EF.Services
{
    public interface IShippingApiProxyService
    {
        Task<string> GetCityLocation(string city);
        Task<double?> GetDistanceFromCoordinates(string coordinates);
    }
}
