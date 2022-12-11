namespace BookWebApiRepo_MSSQL_EF.Models
{
    public class Fine
    {
        public int Id { get; set; }
        public DateTime FineDate { get; set; }

        public decimal FineAmount { get; set; }
        public int LocalUserId { get; set; }
        public int LoanId { get; set; }


        public virtual LocalUser LocalUser { get; set; } = null!;
        public virtual Loan Loan { get; set; } = null!;

    }
}
