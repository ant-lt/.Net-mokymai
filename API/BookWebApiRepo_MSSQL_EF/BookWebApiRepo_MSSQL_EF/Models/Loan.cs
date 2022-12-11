namespace BookWebApiRepo_MSSQL_EF.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime? ReturnedDate { get; set; } = null!;

        public virtual LocalUser LocalUser { get; set; } = null!;
        public virtual Book Book { get; set; } = null!;

        
      //  public ICollection<Fine> Fines { get; set; }
    }
}
