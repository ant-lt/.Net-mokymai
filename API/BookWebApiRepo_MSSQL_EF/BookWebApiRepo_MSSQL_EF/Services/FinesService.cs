using BookWebApiRepo_MSSQL_EF.Models;

namespace BookWebApiRepo_MSSQL_EF.Services
{
    public class FinesService
    {
        public FinesService() { }

        public Fine CallculateFineOnReturn (Loan loan)
        {
            const int monthInDays = 4 * 7;
            const decimal finefee = (decimal)0.2;
            TimeSpan t = ((TimeSpan)(loan.ReturnedDate - loan.LoanDate));

            var daysDelayed = t.Days - monthInDays;

            if (daysDelayed > 0 )
            {
                decimal fineAmount = (decimal)Math.Pow(daysDelayed, 2) * finefee;

                if(fineAmount > 50 )
                {
                    fineAmount= 50;
                }

                var fine = new Fine() 
                { 
                    LoanId = loan.Id, 
                    LocalUser= loan.LocalUser,
                    FineAmount = fineAmount,
                    FineDate = DateTime.Now,
                };

                return fine;
            }
            else 
                return null;
        }
    }
}
