namespace Daugiakampio_ploto_testavimas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Trikampis_Test()
        {
            var kra�tines_ilgis = 1;
            var auk�tis = 2;
            var plotas = 1;

            var actual = Uzduotis_daugiakampis.Program.Trikampio_plotas(kra�tines_ilgis, auk�tis);
            Assert.AreEqual(plotas, actual);
        }

        [TestMethod]
        public void Keturkampio_Test()
        {
            var kra�tines_ilgis = 2;
            
            var plotas = 4;

            var actual = Uzduotis_daugiakampis.Program.Keturkampio_plotas(kra�tines_ilgis);
            Assert.AreEqual(plotas, actual);
        }

        [TestMethod]
        public void Daugiakampio_Test()
        {
            var kra�tines_ilgis = 2;
            var kra�tiu_kiekis = 2;
            var statmuo = 4;

            var plotas = 8;

            var actual = Uzduotis_daugiakampis.Program.Daugiakampio_plotas(kra�tiu_kiekis, kra�tines_ilgis, statmuo);
            Assert.AreEqual(plotas, actual);
        }

        [TestMethod]
        public void Poligono_kampu_Test()
        {
            
            var kra�tiu_kiekis = 4;
            var kampu_suma = 360;

            var actual = Uzduotis_daugiakampis.Program.Poligono_kampu_suma(kra�tiu_kiekis);
            Assert.AreEqual(kampu_suma, actual);
        }
    }
}