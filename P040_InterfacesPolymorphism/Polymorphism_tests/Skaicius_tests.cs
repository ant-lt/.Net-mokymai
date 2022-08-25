using P040_InterfacesPolymorphism;
using P040_InterfacesPolymorphism.Domain.Interfaces;
using P040_InterfacesPolymorphism.Domain.Models;

namespace Polymorphism_tests
{
    [TestClass]
    public class Skaicius_tests
    {
        [TestMethod]
        public void DefaultConstruktorTest()
        {
            var actual = new Skaicius();
            int expected = 0;
            Assert.AreEqual(expected, actual.Reiksme);
        }

        [TestMethod]
        public void DefinedConstruktorTest()
        {
            var actual = new Skaicius(5);
            int expected = 5;
            Assert.AreEqual(expected, actual.Reiksme);
        }

        [TestMethod]
        public void Atimti_test()
        {
            IMatematika actual = new Skaicius(5);

            int expected = 3;
            Assert.AreEqual(expected, actual.Atimti(2) );
        }

        [TestMethod]
        public void Padalinti_test()
        {
            IMatematika actual = new Skaicius(10);

            int expected = 5;
            // 10 / 2 = 5
            Assert.AreEqual(expected, actual.Padalinti(2));
        }

        [TestMethod]
        public void Padauginti_test()
        {
            IMatematika actual = new Skaicius(10);

            int expected = 20;
            // 10 * 2 = 20
            Assert.AreEqual(expected, actual.Padauginti(2));
        }

        [TestMethod]
        public void PakeltiKubu_test()
        {
            IMatematika actual = new Skaicius(2);

            int expected = 8;
            // 2 ^3 = 8
            Assert.AreEqual(expected, actual.PakeltiKubu());
        }

        [TestMethod]
        public void PakeltiKvadratu_test()
        {
            IMatematika actual = new Skaicius(5);

            int expected = 25;
            // 5 ^2 = 25
            Assert.AreEqual(expected, actual.PakeltiKvadratu());
        }

        [TestMethod]
        public void Prideti_test()
        {
            IMatematika actual = new Skaicius(10);

            int expected = 15;
            // 10 + 5 = 15
            Assert.AreEqual(expected, actual.Prideti(5));
        }

    }
}