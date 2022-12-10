namespace BookWebApiRepo_MSSQL_EF.Models
{
    public class Fine
    {
        public int Id { get; set; }
        public DateTime FineDate { get; set; }

        public decimal FineAmount { get; set; }

        public LocalUser LocalUser { get; set; } = null!;
        public Loan Loan { get; set; } = null!;

    }
}
