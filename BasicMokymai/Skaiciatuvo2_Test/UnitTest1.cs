namespace Skaiciatuvo2_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSuma1()
        {
            // sumavimo testavimas
            var skacius1 = 1;
            var skacius2 = 2;
            var expected = 3;

            var actual = Skaiciuotuvas2.Program.Skaiciuotuvas(skacius1, skacius2, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAtimtis1()
        {
            var skacius1 = 1;
            var skacius2 = 2;
            var expected = -1;

            var actual = Skaiciuotuvas2.Program.Skaiciuotuvas(skacius1, skacius2, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDaugyba()
        {
            var skacius1 = 2;
            var skacius2 = 2;
            var expected = 4;

            var actual = Skaiciuotuvas2.Program.Skaiciuotuvas(skacius1, skacius2, 3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDalyba()
        {
            var skacius1 = 3;
            var skacius2 = 2;
            var expected = 1.5;

            var actual = Skaiciuotuvas2.Program.Skaiciuotuvas(skacius1, skacius2, 4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKelimas2()
        {
            var skacius1 = 3;
            var skacius2 = 2;
            var expected = 9;

            var actual = Skaiciuotuvas2.Program.Skaiciuotuvas(skacius1, skacius2, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSakniesTraukimas()
        {
            var skacius1 = 3;
            var skacius2 = 2;
            var expected = 1.7320508075688772;

            var actual = Skaiciuotuvas2.Program.Skaiciuotuvas(skacius1, skacius2, 6);
            Assert.AreEqual(expected, actual);
        }

       
    }
}