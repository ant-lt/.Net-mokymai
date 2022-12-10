namespace BookWebApiRepo_MSSQL_EF.Models
{
    public class LocalUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        
        public bool Active { get; set; }

        public string Role { get; set; }
        //public Role Role { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<Fine> Fines { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
}
