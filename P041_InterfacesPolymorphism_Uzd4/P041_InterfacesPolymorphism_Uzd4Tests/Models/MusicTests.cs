using Microsoft.VisualStudio.TestTools.UnitTesting;
using P041_InterfacesPolymorphism_Uzd4.Interfaces;
using P041_InterfacesPolymorphism_Uzd4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P041_InterfacesPolymorphism_Uzd4.Models.Tests
{
    [TestClass()]
    public class MusicTests
    {
        [TestMethod()]
        public void MusicKonstruktorTest()
        {
            // Arrange
            var music = new Music(name: "Name", publisher: "Publisher", genre: "Genre", rating: 10, id: 1, length: 5, artistName: "ArtistName");

            var expectedName = "Name";
            var expectedPublisher = "Publisher";
            var expectedGenre = "Genre";
            var expectedRating = 10;
            var expectedID = 1;
            var expectedLength = 5;
            var expectedArtistName = "ArtistName";

            //Act
            var actualName = music.Name;
            var actualPublisher = music.Publisher;
            var actualGenre = music.Genre;
            var actualRating = music.Rating;
            var actualID = music.Id;
            var actualLength = music.Length;
            var actualArtistName = music.ArtistName;

            //Assert
            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedPublisher, actualPublisher);
            Assert.AreEqual(expectedGenre, actualGenre);
            Assert.AreEqual(expectedRating, actualRating);
            Assert.AreEqual(expectedID, actualID);
            Assert.AreEqual(expectedLength, actualLength);
            Assert.AreEqual(expectedArtistName, actualArtistName);
        }

        [TestMethod()]
        public void GetHobbyInformationTest()
        {
            // Arrange
            IHobby hobyy = new Music(name: "Name", publisher: "Publisher", genre: "Genre", rating: 10, id: 1, length: 5, artistName: "ArtistName");
            var expected = "Muzika \"Name\" Artistas: ArtistName Žanras: Genre Įvertinimas: 10";

            //Act
            var actual = hobyy.GetHobbyInformation();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetHobbyNameTest()
        {
            // Arrange
            IHobby hobyy = new Music(name: "Name", publisher: "Publisher", genre: "Genre", rating: 10, id: 1, length: 5, artistName: "ArtistName");
            var expected = "Listening music";

            //Act
            var actual = hobyy.GetHobbyName();
           //Assert
           Assert.AreEqual(expected, actual);
        }
    }
}