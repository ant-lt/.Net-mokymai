namespace BookWebApiRepo_MSSQL_EF.Models.Dto
{
    public class ReservationResponse
    {
        public int ReservationId {get; set;}
        public DateTime ReservationDate { get; set; }
        
        public string UserName { get; set;}
        public string BookTitle { get; set;}
        public string ReservationStatus { get; set;}
    }
    
}
