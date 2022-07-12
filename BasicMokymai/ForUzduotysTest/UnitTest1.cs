namespace ForUzduotysTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string expected = "10";
            int fake = 2;
            var actual = For_Uzduotys.Program.IntegerToBinary(fake);
            Assert.AreEqual(expected, actual);
        }
    }
}