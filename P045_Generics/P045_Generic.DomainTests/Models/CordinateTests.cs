using Microsoft.VisualStudio.TestTools.UnitTesting;
using P045_Generic.Domain.Interfaces;
using P045_Generic.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P045_Generic.Domain.Models.Tests
{
    [TestClass()]
    public class CordinateTests
    {
        [TestMethod()]
        public void GetCordinateStringTest()
        {
            ICordinate intcoord = new Cordinate<string>("10", "20");

            string actual = intcoord.GetCordinate();
            string expected = "X:10 Y: 20";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetCordinateStringTest2()
        {
            Cordinate<string> intcoord = new Cordinate<string>();

            intcoord.x = "10";
            intcoord.y = "20";

            string actual = intcoord.GetCordinate();
            string expected = "X:10 Y: 20";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetCordinateIntTest()
        {
            ICordinate intcoord = new Cordinate<int>(10, 20);

            string actual = intcoord.GetCordinate();
            string expected = "X:10 Y: 20";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetCordinateDateTest()
        {
            ICordinate intcoord = new Cordinate<DateTime>(DateTime.Today, DateTime.Today);

            string actual = intcoord.GetCordinate();
            string expected = "X:2022-08-31 00:00:00 Y: 2022-08-31 00:00:00";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ResetCordinateTest()
        {

            Cordinate<int> intcoord = new Cordinate<int>(100,200);

            intcoord.ResetCordinate();

            int expected_x = default(int);
            int actual_x= intcoord.x;

           Assert.AreEqual(expected_x, actual_x);

        }

        [TestMethod()]
        public void ResetCordinateTest2()
        {

            Cordinate<DateTime> intcoord = new Cordinate<DateTime>();

            intcoord.x = DateTime.Now;
            intcoord.y = DateTime.Now;

            intcoord.ResetCordinate();

            DateTime expected_x = default(DateTime);
            DateTime actual_x = intcoord.x;

            Assert.AreEqual(expected_x, actual_x);

        }

    }
}