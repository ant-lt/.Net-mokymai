using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookWebApiRepo_MSSQL_EF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookWebApiRepo_MSSQL_EF.Models;

namespace BookWebApiRepo_MSSQL_EF.Services.Tests
{
    [TestClass()]
    public class FinesServiceTests
    {
        [TestMethod()]
        public void CallculateFineOnReturnWith2daysDelayTest()
        {
            var _fine = new FinesService();

            var loanDate = new DateTime(2022, 11, 10);
            var returnedDate = new DateTime(2022, 12, 10);

            var expected = (decimal)0.8;

            var testLoan = new Loan()
            {
                LoanDate = loanDate,
                ReturnedDate = returnedDate,

            };



            var fine = _fine.CallculateFineOnReturn(testLoan);

            var actual = fine.FineAmount;
            // Assert.IsNotNull(fine);
            Assert.AreEqual(expected, actual);
           
        }


        [TestMethod()]
        public void CallculateFineOnReturnNoDelayTest()
        {
            var _fine = new FinesService();

            var loanDate = new DateTime(2022, 11, 10);
            var returnedDate = new DateTime(2022, 11, 14);

            var expected = (decimal)0;

            var testLoan = new Loan()
            {
                LoanDate = loanDate,
                ReturnedDate = returnedDate,

            };



            var fine = _fine.CallculateFineOnReturn(testLoan);

          
           Assert.IsNull(fine);
           
        }

    }
}