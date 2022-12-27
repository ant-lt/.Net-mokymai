namespace BookWebApiRepo_MSSQL_EF.Models
{
    public class LocalUser
    {
        public LocalUser() 
        {
  //          Reservations = new HashSet<Reservation>();
  //          Fines = new HashSet<Fine>();
  //          Loans = new HashSet<Loan>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        
        public bool Active { get; set; }
        public int Points { get; set; } = 0;

        public int RoleId { get; set; }
        public int UserLevelId { get; set; }

        //   public string RoleName { get; set; }
        public virtual Role Role { get; set; } 
        public virtual UserLevel UserLevel { get; set; } 
  //      public virtual ICollection<Reservation> Reservations { get; set; }
  //      public virtual ICollection<Fine> Fines { get; set; }
  //      public virtual ICollection<Loan> Loans { get; set; }
    }
}
