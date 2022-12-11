namespace BookWebApiRepo_MSSQL_EF.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        
        public int LocalUserId { get; set; }
        public int BookId { get; set; }
        public int ReservationStatusId { get; set; }

        public virtual LocalUser LocalUser { get; set; } = null!;
        public virtual Book Book { get; set; } = null!;
        public virtual ReservationStatus ReservationStatus { get; set; }
    }
}
