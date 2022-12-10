namespace BookWebApiRepo_MSSQL_EF.Models
{
    public class Loan
    {
        public int Id { get; set; }
        DateTime loanDate { get; set; }
        DateTime? returnedDate { get; set; } = null!;

        public LocalUser LocalUser { get; set; } = null!;
        public Book Book { get; set; } = null!;

        
      //  public ICollection<Fine> Fines { get; set; }
    }
}
