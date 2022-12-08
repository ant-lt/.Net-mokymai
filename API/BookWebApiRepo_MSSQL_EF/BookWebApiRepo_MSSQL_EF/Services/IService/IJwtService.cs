namespace BookWebApiRepo_MSSQL_EF.Services.IServices
{
    public interface IJwtService
    {
        string GetJwtToken(int userId, string role);
    }
}
