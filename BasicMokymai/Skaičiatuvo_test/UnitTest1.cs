namespace Skaičiatuvo_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSuma1()
        {
            var skacius1 = 1;
            var skacius2 = 2;
            var expected = 3;

            var actual = Užduotis_Skaičiuotuvas.Program.Skaiciuotuvas(skacius1, skacius2,"+");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAtimtis1()
        {
            var skacius1 = 1;
            var skacius2 = 2;
            var expected = -1;

            var actual = Užduotis_Skaičiuotuvas.Program.Skaiciuotuvas(skacius1, skacius2, "-");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDaugyba()
        {
            var skacius1 = 2;
            var skacius2 = 2;
            var expected = 4;

            var actual = Užduotis_Skaičiuotuvas.Program.Skaiciuotuvas(skacius1, skacius2, "*");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDalyba()
        {
            var skacius1 = 3;
            var skacius2 = 2;
            var expected = 1.5;

            var actual = Užduotis_Skaičiuotuvas.Program.Skaiciuotuvas(skacius1, skacius2, "/");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKelimas2()
        {
            var skacius1 = 3;
            var skacius2 = 2;
            var expected = 9;

            var actual = Užduotis_Skaičiuotuvas.Program.Skaiciuotuvas(skacius1, skacius2, "a^2");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKelimas3()
        {
            var skacius1 = 3;
            var skacius2 = 2;
            var expected = 27;

            var actual = Užduotis_Skaičiuotuvas.Program.Skaiciuotuvas(skacius1, skacius2, "a^3");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKelimas3_double()
        {
            double skacius1 = 3;
            double skacius2 = 2;
            var expected = 27;

            var actual = Užduotis_Skaičiuotuvas.Program.Skaiciuotuvas(skacius1, skacius2, "a^3");
            Assert.AreEqual(expected, actual);
        }

    }
}