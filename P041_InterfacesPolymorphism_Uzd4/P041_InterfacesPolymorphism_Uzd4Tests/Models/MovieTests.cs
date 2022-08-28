using Microsoft.VisualStudio.TestTools.UnitTesting;
using P041_InterfacesPolymorphism_Uzd4.Interfaces;
using P041_InterfacesPolymorphism_Uzd4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P041_InterfacesPolymorphism_Uzd4.Models.Tests
{
    [TestClass()]
    public class MovieTests
    {
        [TestMethod()]
        public void MovieKonstruktorTest()
        {
            // Arrange
            var movie = new Movie(name: "Name", publisher: "Publisher", genre: "Genre", rating: 1, id: 1, creationDate: DateTime.Today);

            var expectedName = "Name";
            var expectedPublisher = "Publisher";
            var expectedgenre = "Genre";
            var expectedRating = 1;
            var expectedId = 1;
            var expectedCreationDate = DateTime.Today;

            //Act
            var actualName = movie.Name;
            var actualPublisher = movie.Publisher;
            var actualGenre = movie.Genre;
            var actualRating = movie.Rating;
            var actualId = movie.Id;
            var actualCreationDate = movie.CreationDate;


            //Assert
            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedPublisher, actualPublisher);
            Assert.AreEqual(expectedgenre, actualGenre);
            Assert.AreEqual(expectedRating, actualRating);
            Assert.AreEqual(expectedId, actualId);
            Assert.AreEqual(expectedCreationDate, actualCreationDate);
        }

        [TestMethod()]
        public void GetHobbyInformationTest()
        {
            IHobby movie = new Movie(name: "Name", publisher: "Publisher", genre: "Genre", rating: 1, id: 1, creationDate: DateTime.Today);

            var expected = "Filmas \"Name\" Žanras: Genre Įvertinimas: 1";

            var actual = movie.GetHobbyInformation();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetHobbyNameTest()
        {
            IHobby movie = new Movie(name: "Name", publisher: "Publisher", genre: "Genre", rating: 1, id: 1, creationDate: DateTime.Today);

            var expected = "Watching movie";

            var actual = movie.GetHobbyName();

            Assert.AreEqual(expected, actual);
        }
    }
}