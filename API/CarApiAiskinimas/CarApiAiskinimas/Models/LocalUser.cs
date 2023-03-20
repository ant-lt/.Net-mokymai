namespace CarApiAiskinimas.Models
{
    public class LocalUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LegalId { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
