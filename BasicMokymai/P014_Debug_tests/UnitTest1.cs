namespace P014_Debug_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DecimalHours_test()
        {
            var fake = "30.30";
            var expected = "Decimal hour: 30,5000";
            var actual = P014_Debug.Program.DecimalHour(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DecimalHour_Test1()
        {
            var fake = "20.30.30";
            var expected = "Decimal hour: 20,5083";
            var actual = P014_Debug.Program.DecimalHour(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DecimalHour_Test2()
        {
            var fake = "20";
            var expected = "Invalid time";
            var actual = P014_Debug.Program.DecimalHour(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DecimalHour_Test3()
        {
            var fake = "-20.50";
            var expected = "Invalid hours";
            var actual = P014_Debug.Program.DecimalHour(fake);
            Assert.AreEqual(expected, actual);
        }
    }
}