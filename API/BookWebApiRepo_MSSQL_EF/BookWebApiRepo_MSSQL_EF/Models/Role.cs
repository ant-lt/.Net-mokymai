namespace BookWebApiRepo_MSSQL_EF.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<LocalUser> LocalUsers { get; set; }
    }
}
