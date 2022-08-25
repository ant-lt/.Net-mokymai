using P040_InterfacesPolymorphism;
using P040_InterfacesPolymorphism.Domain.Interfaces;

namespace Polymorphism_tests
{
    [TestClass]
    public class Figura_tests
    {
        [TestMethod]
        public void DefaultConstruktorTest()
        {
            var actual = new Apskritimas(10);
            var expectedPavadinimas = "Apskritimas";
            var expectedRadius = 10;
            Assert.AreEqual(expectedPavadinimas, actual.Pavadinimas);
            Assert.AreEqual(expectedRadius, actual.Radius);
        }

        [TestMethod]
        public void ApskritimoPerimetroTest()
        {
            IGeometrija apskritimas = new Apskritimas(10);

            var expected = 62.83185307179586d;
            var actual = apskritimas.Perimetras();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ApskritimoPlotoTest()
        {
            IGeometrija apskritimas = new Apskritimas(10);

            var expected = 314.1592653589793d;
            var actual = apskritimas.Plotas();
           Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KvadratasDefaultConstruktorTest()
        {
            var actual = new Kvadratas(10);
            var expectedPavadinimas = "Kvadratas";
            var expectedKrastine = 10;
            Assert.AreEqual(expectedPavadinimas, actual.Pavadinimas);
            Assert.AreEqual(expectedKrastine, actual.Krastine);
        }

        [TestMethod]
        public void KvadratasPerimetroTest()
        {
            IGeometrija kvadratas = new Kvadratas(10);

            var expected = 40;
            var actual = kvadratas.Perimetras();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KvadratasPlotoTest()
        {
            IGeometrija kvadratas = new Kvadratas(10);

            var expected = 100d;
            var actual = kvadratas.Plotas();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaciakampisDefaultConstruktorTest()
        {
            var actual = new Staciakampis(10,20);
            var expectedPavadinimas = "Staciakampis";
            var expectedIlgis = 10;
            var expectedPlotis = 20;
            Assert.AreEqual(expectedPavadinimas, actual.Pavadinimas);
            Assert.AreEqual(expectedIlgis, actual.Ilgis);
            Assert.AreEqual(expectedPlotis, actual.Plotis);
        }

        [TestMethod]
        public void StaciakampioPerimetroTest()
        {
            IGeometrija staciakampis = new Staciakampis(10, 20);

            var expected = 60;
            var actual = staciakampis.Perimetras();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaciakampioPlotoTest()
        {
            IGeometrija staciakampis = new Staciakampis(10, 20);

            var expected = 200d;
            var actual = staciakampis.Plotas();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TrikampisDefaultConstruktorTest()
        {
            var actual = new StatusisTrikampis(10, 20,30);
            var expectedPavadinimas = "Statusis trikampis";
            var expectedA = 10;
            var expectedB = 20;
            var expectedC = 30;

            Assert.AreEqual(expectedPavadinimas, actual.Pavadinimas);
            Assert.AreEqual(expectedA, actual.A);
            Assert.AreEqual(expectedB, actual.B);
            Assert.AreEqual(expectedC, actual.C);
        }

        [TestMethod]
        public void TrikampisPerimetroTest()
        {
            IGeometrija trikampis = new StatusisTrikampis(10, 20, 30);

            var expected = 60;
            var actual = trikampis.Perimetras();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TrikampisPlotoTest()
        {
            IGeometrija trikampis = new StatusisTrikampis(10, 20, 30);

            var expected = 100d;
            var actual = trikampis.Plotas();
            Assert.AreEqual(expected, actual);
        }

    }
}
