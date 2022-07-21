
namespace ForEach_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ApskaiciuotiVidurki_Test()
        {
            var fake = new List<int> { 5,1,6,8,7};
            var expected = 5;
            var actual = ForEach.Program.ApskaiciuotiVidurki(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TikrintiSkaiciausTeigiamuma_Test()
        {
            var fake = new List<int> { 5, -1, 0, 8, -5 };
            var expected = new List<string> { "Teigiamas", "Neigiamas", "Teigiamas", "Teigiamas", "Neigiamas" };
            var actual = ForEach.Program.TikrintiSkaiciausTeigiamuma(fake);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ApskaiciuotiGPM_Test()
        {
            int gpm = 15;
            var fake = new List<double> { 100, 150, 188.88, 153.87, 67.68 };
            var expected = 99.06450000000001;
            var actual = ForEach.Program.ApskaiciuotiGPM(fake, gpm);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Istraukti_Test()
        {
            var fake = "1sd512sd5";
            var expected = "15125";
            var actual = ForEach.Program.IstrauktiSkaicius(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsmetytiZodzius_Test()
        {
            var fake = "Labas as esu Kodelskis ir labai megstu programuoti";
            var expected = new List<string> { "Kodelskis", "labai", "Labas", "megstu", "programuoti" };
            var actual = ForEach.Program.IsmetytiZodzius(fake);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sujungti2zodziuSarasus_Test()
        {
            var fake1 = new List<string> { "Kodelskis", "labai", "Labas", "megstu", "programuoti" };
            var fake2= new List<string> { "Kodelskis", "labai", "Labas", "megstu", "programuoti" };

            var expected = new List<string> { "Kodelskis", "labai", "Labas", "megstu", "programuoti", "Kodelskis", "labai", "Labas", "megstu", "programuoti" };
            var actual = ForEach.Program.Sujungti2zodziuSarasus(fake1, fake2);
            CollectionAssert.AreEqual(expected, actual);
        }


    }
}