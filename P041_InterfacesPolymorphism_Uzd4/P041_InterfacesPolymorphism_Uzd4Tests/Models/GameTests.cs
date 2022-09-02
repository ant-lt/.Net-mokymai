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
    public class GameTests
    {
        [TestMethod()]
        public void GameTest()
        {
            // Arrange
            var game = new Game(id: 1, platForm: "Platform", isMultiplayer: true, gameName: "Game Name", gamePublisher: "Game Publisher", gameGenre: "Game Genre", gameRating: 1);

            var expectedId = 1;
            var expectedPlatform = "Platform";
            var expectedisMultiplayer = true;
            var expectedGameName = "Game Name";
            var expectedGamePublisher = "Game Publisher";
            var expectedGameGenre = "Game Genre";
            var expectedGameRating = 1;

            var actualId = game.Id;
            var actualPlatform = game.PlatForm;
            var actualIsMultiplayer = game.IsMultiplayer;
            var actualGameName = game.Name;
            var actualGamePublisher = game.Publisher;
            var actualGameGenre = game.Genre;
            var actualGameRating = game.Rating;

            Assert.AreEqual(expectedId, actualId);
            Assert.AreEqual(expectedPlatform, actualPlatform);
            Assert.AreEqual(expectedisMultiplayer, actualIsMultiplayer);
            Assert.AreEqual(expectedGameName, actualGameName);
            Assert.AreEqual(expectedGamePublisher, actualGamePublisher);
            Assert.AreEqual(expectedGameGenre, actualGameGenre);
            Assert.AreEqual(expectedGameRating, actualGameRating);
        }

        [TestMethod()]
        public void GetHobbyInformationTest()
        {
            // Arrange
            IHobby hobyy = new Game(id: 1, platForm: "Platform", isMultiplayer: true, gameName: "Game Name", gamePublisher: "Game Publisher", gameGenre: "Game Genre", gameRating: 1);
            
            var expected = "Žaidimas \"Game Name\" Žanras: Game Genre Įvertinimas: 1";

            var actual = hobyy.GetHobbyInformation();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetHobbyNameTest()
        {
            // Arrange
            IHobby hobyy = new Game(id: 1, platForm: "Platform", isMultiplayer: true, gameName: "Game Name", gamePublisher: "Game Publisher", gameGenre: "Game Genre", gameRating: 1);

            var expected = "Gaming";

            var actual = hobyy.GetHobbyName();
            Assert.AreEqual(expected, actual);
        }
    }
}