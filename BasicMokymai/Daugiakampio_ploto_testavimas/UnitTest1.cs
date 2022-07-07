namespace Daugiakampio_ploto_testavimas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Trikampis_Test()
        {
            var kraštines_ilgis = 1;
            var aukštis = 2;
            var plotas = 1;

            var actual = Uzduotis_daugiakampis.Program.Trikampio_plotas(kraštines_ilgis, aukštis);
            Assert.AreEqual(plotas, actual);
        }

        [TestMethod]
        public void Keturkampio_Test()
        {
            var kraštines_ilgis = 2;
            
            var plotas = 4;

            var actual = Uzduotis_daugiakampis.Program.Keturkampio_plotas(kraštines_ilgis);
            Assert.AreEqual(plotas, actual);
        }

        [TestMethod]
        public void Daugiakampio_Test()
        {
            var kraštines_ilgis = 2;
            var kraštiu_kiekis = 2;
            var statmuo = 4;

            var plotas = 8;

            var actual = Uzduotis_daugiakampis.Program.Daugiakampio_plotas(kraštiu_kiekis, kraštines_ilgis, statmuo);
            Assert.AreEqual(plotas, actual);
        }

        [TestMethod]
        public void Poligono_kampu_Test()
        {
            
            var kraštiu_kiekis = 4;
            var kampu_suma = 360;

            var actual = Uzduotis_daugiakampis.Program.Poligono_kampu_suma(kraštiu_kiekis);
            Assert.AreEqual(kampu_suma, actual);
        }
    }
}