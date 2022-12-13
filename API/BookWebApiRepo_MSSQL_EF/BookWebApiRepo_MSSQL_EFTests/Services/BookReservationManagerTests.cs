using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookWebApiRepo_MSSQL_EF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using BookWebApiRepo_MSSQL_EF.Repositories.IRepository;
using BookWebApiRepo_MSSQL_EF.Repositories;
using BookWebApiRepo_MSSQL_EF.Models;

namespace BookWebApiRepo_MSSQL_EF.Services.Tests
{

    [TestClass()]
    public class BookReservationManagerTests
    {
        [AssemblyInitialize] //pirmas dalykas kuri bus paleistas
        public static void MyAssemblyInitialize(TestContext context)
        {
        }

        [ClassInitialize]
        public static void MyClassInitialize(TestContext context) //antras dalykas kuris bus paleistas
        {
            //cia geriausiai vieta atlikti konfiguracinius dalykus
        }

        [TestInitialize]
        public void MyTestInitialize() //trecias dalykas kuris bus paleistas
        {
        }


        [TestMethod()]
        public void GetAllReservationTest()
        {

            var repository_mock = new Mock<IReservationRepository>();

            var fakeObj = new Reservation { Id = 1, ReservationDate = new DateTime(2020, 1, 1), BookId = 1, LocalUserId  = 1, ReservationStatusId = 1};
            repository_mock.Setup(r => r.Get(It.IsAny<int>())).Returns(fakeObj);


            var reservation = new ReservationRepository(repository_mock.Object);

            var actual = reservation.GetAll();

            Assert.IsNotNull(actual);
        }
    }
}