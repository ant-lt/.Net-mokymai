using Masyvu_kartojimas;
namespace Masyvu_kartojimas_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] fake = { 5, 3, 7, 6, 8, 7, 10 } ;
            
            var expected = 3;

            var actual = Masyvu_kartojimas.Program.MaziausiasSkaiciusMasyve(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDidziausias2()
        {
            int[] fake = { 5, 3, 7, 6, 8, 7, 10 };

            var expected = 10;

            var actual = Masyvu_kartojimas.Program.DidziausiasSkaiciusMasyve(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDidziausias3()
        {
            int[] fake = { 5, 3, 70, 6, 8, 7, 10 };

            var expected = 70;

            var actual = Masyvu_kartojimas.Program.DidziausiasSkaiciusMasyve(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRikioutiDidejimo_3()
        {
            int[] fake = new int[] { 5, 1, 7, 6, 8, 7, 10 };
            int[] expected = new int[] { 1, 5, 6, 7, 7, 8, 10 };

            var actual = Masyvu_kartojimas.Program.RikiuotiDidejimoTvarka(fake);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRikiouti3Raides()
        {
            char[] fake = new char[] { 'C', 'D', 'B'};
            char[] expected = new char[] { 'B', 'C', 'D' };

            var actual = Masyvu_kartojimas.Program.RikiuotiTrisRaides(fake);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRikiouti3Raides2()
        {
            char[] fake = new char[] { 'C', 'A', 'B' };
            char[] expected = new char[] { 'A', 'B', 'C' };

            var actual = Masyvu_kartojimas.Program.RikiuotiTrisRaides(fake);
            CollectionAssert.AreEqual(expected, actual);
        }


    }
}