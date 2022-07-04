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

    }
}