using Microsoft.VisualStudio.TestTools.UnitTesting;
using P049_LINQ_Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P049_LINQ_EXTENTION_TESTS
{
    [TestClass]
    public class ExcerciseModelTests
    {
        [TestMethod()]
        public void FirstExcerciseLinqFiltering_AddFixedList_ReturnFilteredList()
        {
            // Arrange
            List<int> expected = new List<int> { 78, 85, 39, 49, 55, 95 };
            List<int> fake = new List<int> { 9, 78, 85, 115, 39, 49, 55, 100, 523, 95 }; // 35 - 99 
            ExcerciseModel excerciseModel = new ExcerciseModel();

            // Act
            List<int> actual = excerciseModel.FirstExcerciseLinqFiltering(fake);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SecondExcerciseLinqFiltering_AddFixedList_ReturnFilteredList()
        {
            // Arrange
            List<string> expected = new List<string> { "GREEN",  "PURPLE", "MAGENTA", "TOMATO" };

            List<string> fake = new List<string> { "Red", "Green", "Blue", "Teal", "Grey", "Purple", "Magenta", "Tomato", "Cyan" };

            ExcerciseModel excerciseModel = new ExcerciseModel();

            // Act
            List<string> actual = excerciseModel.SecondExcerciseLinqFiltering(fake);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }


    }
}