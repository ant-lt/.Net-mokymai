namespace SuperSkaiciuotuvas_Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod()]
        public void SuperSkaiciuotuvasTest1()
        {
            var fake_moves = new string[] { "1", "1", "15", "45", "2", "2", "10", "3" };
            var expected = 50d;

            SuperSkaiciuotuvas.Program.Reset();
            foreach (var move in fake_moves)
            {
                SuperSkaiciuotuvas.Program.SuperSkaiciuotuvas(move);
            }
            var actual = SuperSkaiciuotuvas.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SuperSkaiciuotuvasTest2()
        {
            var fake_moves = new string[] { "1", "1", "15", "45", "3" };
            var expected = 60d;
            SuperSkaiciuotuvas.Program.Reset();
            foreach (var move in fake_moves)
            {
                SuperSkaiciuotuvas.Program.SuperSkaiciuotuvas(move);
            }
            var actual = SuperSkaiciuotuvas.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SuperSkaiciuotuvasTest3()
        {
            var fake_moves = new string[] { "1", "1", "15", "45", "2", "2", "10", "1", "3", "2", "3", "3" };
            var expected = 6d;

            SuperSkaiciuotuvas.Program.Reset();
            foreach (var move in fake_moves)
            {
                SuperSkaiciuotuvas.Program.SuperSkaiciuotuvas(move);
            }
            var actual = SuperSkaiciuotuvas.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }

       
        [TestMethod()] // laukio pakartotinio antro skaiciaus ivedimo
        public void SuperSkaiciuotuvasDalybaIsNulio()
        {
            var fake_moves = new string[] { "1", "4", "100", "0" };
            var expected = 0d;
            SuperSkaiciuotuvas.Program.Reset();
            foreach (var move in fake_moves)
            {
                SuperSkaiciuotuvas.Program.SuperSkaiciuotuvas(move);
            }
            var actual = SuperSkaiciuotuvas.Program.Rezultatas();
     
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()] // po klaidos pakartotinai ivedamas antras skaicius ir tada atliekama dalyba
        public void SuperSkaiciuotuvasDalybaIsNulioSuIvedimoPakartojimu()
        {
            var fake_moves = new string[] { "1", "4", "100", "0", "2" };
            var expected = 50d;
            SuperSkaiciuotuvas.Program.Reset();
            foreach (var move in fake_moves)
            {
                SuperSkaiciuotuvas.Program.SuperSkaiciuotuvas(move);
            }
            var actual = SuperSkaiciuotuvas.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()] // po formatavimo klaidos pakartotinai ivedamas antras skaicius ir tada atliekama daugyba
        public void SuperSkaiciuotuvasDaugybaBlogaiIvestasSkaiciusSuIvedimoPakartojimu()
        {
            var fake_moves = new string[] { "1", "3", "dff", "40", "2", "3" };
            var expected = 80d;
            SuperSkaiciuotuvas.Program.Reset();
            foreach (var move in fake_moves)
            {
                SuperSkaiciuotuvas.Program.SuperSkaiciuotuvas(move);
            }
            var actual = SuperSkaiciuotuvas.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()] // laipsnio kelimu ir pratesimas atimtis su esamu rezultatu
        public void SuperSkaiciuotuvasKelimasLaipsiuSuAtimtiesTesimu()
        {
            var fake_moves = new string[] { "1", "5", "2", "3", "2", "2","3","3" };
            var expected = 5d;
            SuperSkaiciuotuvas.Program.Reset();
            foreach (var move in fake_moves)

            {
                SuperSkaiciuotuvas.Program.SuperSkaiciuotuvas(move);
            }
            var actual = SuperSkaiciuotuvas.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()] // kvadratines saknies traukimas
        public void SuperSkaiciuotuvasSakniesTraukimas()
        {
            var fake_moves = new string[] { "1", "6", "5", "3" };
            var expected = 2.23606797749979d;
            SuperSkaiciuotuvas.Program.Reset();
            foreach (var move in fake_moves)

            {
                SuperSkaiciuotuvas.Program.SuperSkaiciuotuvas(move);
            }
            var actual = SuperSkaiciuotuvas.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()] // kvadratines saknies traukimas su atimties tesimu 
        public void SuperSkaiciuotuvasSakniesTraukimasSuAtimtiesTesimu()
        {
            var fake_moves = new string[] { "1", "6", "25", "2", "2", "2", "3" };
            var expected = 3d;
            SuperSkaiciuotuvas.Program.Reset();
            foreach (var move in fake_moves)

            {
                SuperSkaiciuotuvas.Program.SuperSkaiciuotuvas(move);
            }
            var actual = SuperSkaiciuotuvas.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void MetodasSudetis1()
        {
            var skacius1 = 1d;
            var skacius2 = 2d;
            var expected = 3d;

            var actual = SuperSkaiciuotuvas.Program.Sudetis(skacius1, skacius2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MetodasAtimstis1()
        {
            var skacius1 = 1d;
            var skacius2 = 2d;
            var expected = -1d;

            var actual = SuperSkaiciuotuvas.Program.Atimtis(skacius1, skacius2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MetodasDaugyba1()
        {
            var skacius1 = 4d;
            var skacius2 = 2d;
            var expected = 8d;

            var actual = SuperSkaiciuotuvas.Program.Daugyba(skacius1, skacius2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MetodasDalyba1()
        {
            var skacius1 = 25d;
            var skacius2 = 5d;
            var expected = 5d;

            var actual = SuperSkaiciuotuvas.Program.Dalyba(skacius1, skacius2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MetodasDalybaIsNulio()
        {
            var skacius1 = 25d;
            var skacius2 = 0d;
            var expected = double.PositiveInfinity;

            var actual = SuperSkaiciuotuvas.Program.Dalyba(skacius1, skacius2);
            Assert.AreEqual(expected, actual);
        }


    }
}