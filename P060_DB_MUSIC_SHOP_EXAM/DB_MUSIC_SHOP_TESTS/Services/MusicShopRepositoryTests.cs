using Microsoft.VisualStudio.TestTools.UnitTesting;
using DB_MUSIC_SHOP.Infrastrukture.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_MUSIC_SHOP.Infrastrukture.Database;
using Microsoft.EntityFrameworkCore;
using DB_MUSIC_SHOP.Infrastrukture.Interfaces;
using P060_DB_MUSIC_SHOP_EXAM;
using System.Collections;

namespace DB_MUSIC_SHOP.Infrastrukture.Services.Tests
{
    [TestClass()]
    public class MusicShopRepositoryTests
    {
        private chinookContext context;

        [TestInitialize]
        public void OnInit()
        {
            var options = new DbContextOptionsBuilder<chinookContext>()
                .UseInMemoryDatabase(databaseName: "MusicShopDB")
                .Options;

            context = new chinookContext(options);


            Artist artist = new Artist()
            {

                Name = "Test Artist"
            };
            context.Artists.AddRange(artist);


            Album album = new Album
            {

                Title = "Album title test",
                ArtistId = 1,
            };
            context.Albums.AddRange(album);

            MediaType mediaType = new MediaType()
            {

                Name = "Test media type"
            };
            context.MediaTypes.AddRange(mediaType);

            Genre genre = new Genre()
            {

                Name = "Test genre"
            };
            context.Genres.AddRange(genre);


            Track track = new Track()
            {

                Name = "Test track",
                AlbumId = 1,
                MediaTypeId = 1,
                GenreId = 1,
                Composer = "Composer",
                Milliseconds = 1000,
                UnitPrice = 10,
                Status = "Active",
            };
            context.Tracks.AddRange(track);



            context.Customers.Add(
                new Customer
                {
                    FirstName = "Vardenis",
                    LastName = "Pavardenis",
                    Email = "test@gmail.com"
                });

            context.SaveChanges();

        }


        [TestMethod()]
        public void AddPurchaseTest()
        {
            IMusicShopRepository musicShop = new MusicShopRepository(context);

            Customer testCustomer = new Customer();
            Track track = new Track();

            testCustomer = context.Customers.First(c => c.CustomerId == 1);
            track = context.Tracks.First(c => c.TrackId == 1);

            List<Track> tracks = new List<Track>();
            tracks.Add(track);

            musicShop.AddPurchase(testCustomer, tracks);

            Invoice invoice = new Invoice();
            invoice = context.Invoices.First(c => c.CustomerId == testCustomer.CustomerId);


            decimal excpectedInvoiceTotal = track.UnitPrice;

            Assert.AreEqual(excpectedInvoiceTotal, invoice.Total);
            // tik vienas trackas parduotas
            Assert.AreEqual(1, invoice.InvoiceItems.Count);
            Assert.AreEqual(testCustomer.CustomerId, invoice.CustomerId);
        }


        [TestMethod()]
        public void AddCustomerTest()
        {
            IMusicShopRepository musicShop = new MusicShopRepository(context);
            Customer testCustomer = new Customer()
            {

                FirstName = "Vardenis2",
                LastName = "Pavardenis2",
                Email = "test2@gmail.com"
            };

            musicShop.AddCustomer(testCustomer);

            Customer findCustomer = new Customer();


            findCustomer = context.Customers.First(c => c.FirstName == testCustomer.FirstName && c.LastName == testCustomer.LastName && c.Email == testCustomer.Email);

            Assert.AreEqual(testCustomer.FirstName, findCustomer.FirstName);
            Assert.AreEqual(testCustomer.LastName, findCustomer.LastName);
            Assert.AreEqual(testCustomer.Email, findCustomer.Email);

        }

        [TestMethod()]
        public void DeleteCustomerTest()
        {
            IMusicShopRepository musicShop = new MusicShopRepository(context);

            Customer customer = new Customer()
            {
                FirstName = "Vardenis to delete",
                LastName = "Pavardenis to delete",
                Email = "test3@gmail.com"
            };


            musicShop.AddCustomer(customer);

            //issaugojam customer id kuris buvo pridetas
            long addedCustomerId = customer.CustomerId;

            musicShop.DeleteCustomer(customer);

            Customer findCustomer = context.Customers.Find(addedCustomerId);

            Assert.IsNull(findCustomer);
        }

        [TestMethod()]
        public void GetAllActiveTracksTest()
        {
            IMusicShopRepository musicShop = new MusicShopRepository(context);

            List<Track> tracks = musicShop.GetAllActiveTracks();

            foreach (Track track in tracks)
            {
                Assert.AreEqual("Active", track.Status);
            }
        }

        [TestMethod()]
        public void GetAllCustomersTest()
        {
            IMusicShopRepository musicShop = new MusicShopRepository(context);
            List<Customer> customers = musicShop.GetAllCustomers();

            Assert.AreNotEqual(0, customers.Count);
        }

        [TestMethod()]
        public void GetAllInvoicesByCustomerTest()
        {
            IMusicShopRepository musicShop = new MusicShopRepository(context);
            long customerID = 1;
            Customer findCustomer = context.Customers.Find(customerID);
            List<Invoice> invoices = musicShop.GetAllInvoicesByCustomer(findCustomer);
            Assert.AreNotEqual(0, invoices.Count);
        }

        [TestMethod()]
        public void GetAllTracksTest()
        {
            IMusicShopRepository musicShop = new MusicShopRepository(context);

            List<Track> tracks = musicShop.GetAllTracks();

            Assert.AreNotEqual(0, tracks.Count);
        }

        [TestMethod()]
        public void UpdateCustomerDataTest()
        {
            IMusicShopRepository musicShop = new MusicShopRepository(context);

            long customerID = 1;
            Customer customer = context.Customers.Find(customerID);
            customer.FirstName = "Update test";

            musicShop.UpdateCustomerData(customer);

            Customer updatedCustomer = context.Customers.Find(customerID);

            Assert.AreEqual(customer.FirstName, updatedCustomer.FirstName);
        }

        [TestMethod()]
        public void UpdateTrackStatusTest()
        {
            IMusicShopRepository musicShop = new MusicShopRepository(context);
            long trackID = 1;

            Track track = context.Tracks.Find(trackID);

            track.Status = "Inactive";

            musicShop.UpdateTrackStatus(track);

            Track updatedTrack = context.Tracks.Find(trackID);
            Assert.AreEqual(track.Status, updatedTrack.Status);
        }
    }
}