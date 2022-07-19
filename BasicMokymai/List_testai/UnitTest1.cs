namespace List_testai
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var fake = new List<int> { 5, 1, 6, 8, 7 };
            int expected = 8;
            var actual = List_uzduotys.Program.Didziausias_sarase(fake);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethod2()
        {
            var fake = new List<int> { 5, 1, 6, 8, 7 };
            int expected = 8;
            var actual = List_uzduotys.Program.Didziausias_sarase2(fake);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void DidesnisUzDidesniTest()
        {
            var fake = new List<int> { 5, 1, 6, 8, 7 };
            var expected = new List<int> { 5, 1, 6, 8, 7, 9 }; ;
            var actual = List_uzduotys.Program.DidesnisUzDidziausia(fake);
            CollectionAssert.AreEqual(expected, actual);

        }

    }
}