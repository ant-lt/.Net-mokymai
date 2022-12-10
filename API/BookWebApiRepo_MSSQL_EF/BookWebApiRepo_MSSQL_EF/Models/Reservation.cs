namespace BookWebApiRepo_MSSQL_EF.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public ReservationStatus Status { get; set; }

        public LocalUser LocalUser { get; set; } = null!;
        public Book Book { get; set; } = null!;
    }
}
