using BookWebApiRepo_MSSQL_EF.Models;

namespace BookWebApiRepo_MSSQL_EF.Data.InitialData
{
    public static class ReservationStatusInitialData
    {
        public static readonly ReservationStatus[] reservationStatusInitialDataSeed = new ReservationStatus[]
        {
            new ReservationStatus{
                Id= 1,
                Status = "Active"
            },
            new ReservationStatus{
                Id= 2,
                Status = "Returned"
            },
            new ReservationStatus{
                Id= 3,
                Status = "Canceled"
            }
        };
    }
}
