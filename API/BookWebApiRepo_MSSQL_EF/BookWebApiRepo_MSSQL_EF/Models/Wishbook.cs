namespace BookWebApiRepo_MSSQL_EF.Models
{
    public class Wishbook
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; } = DateTime.Now;
        public int BookId { get; set; }
        public int LocalUserId { get; set; }

        public virtual Book Book { get; set; } = null!;
        public virtual LocalUser LocalUser { get; set; } = null!;
    }
}
