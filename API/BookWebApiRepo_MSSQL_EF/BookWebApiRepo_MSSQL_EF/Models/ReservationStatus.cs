namespace BookWebApiRepo_MSSQL_EF.Models
{
    public class ReservationStatus
    {
        public ReservationStatus()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int Id { get; set; }
        public string Status { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
