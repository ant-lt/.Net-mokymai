namespace Metodu_testavimas
{
    [TestClass]
    public class Metodu_test
    {
        [TestMethod]
        public void KiekYraZodziu_Test()
        {
            var fake = "as mokausi programuoti";
            var expected = 3;

            var actual = Praktika_Metodai.Program.ZodziuKiekis(fake);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void kiekTarpuGal_Test()
        {
            var fake = "as mokausi programuoti";
            var expected = 0;

            var actual = Praktika_Metodai.Program.kiekTarpuGale(fake);

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void kiekTarpuGal_Test2()
        {
            var fake = "  as mokausi programuoti  ";
            var expected = 2;

            var actual = Praktika_Metodai.Program.kiekTarpuGale(fake);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void kiekTarpuGal_Test3()
        {
            var fake = "  as mokausi    programuoti  ";
            var expected = 2;

            var actual = Praktika_Metodai.Program.kiekTarpuGale(fake);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void kiekTarpuPradzioje_Test1()
        {
            var fake = "  as mokausi    programuoti  ";
            var expected = 2;

            var actual = Praktika_Metodai.Program.kiekTarpuPradzioje(fake);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void kiekTarpuPradzioje_Test2()
        {
            var fake = "as  mokausi    programuoti  ";
            var expected = 0;

            var actual = Praktika_Metodai.Program.kiekTarpuPradzioje(fake);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void kiekTarpuPradzioje_Test3()
        {
            var fake = "      as  mokausi    programuoti";
            var expected = 6;

            var actual = Praktika_Metodai.Program.kiekTarpuPradzioje(fake);

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Tarpai_test1()
        {
            var fake = "      as  mokausi    programuoti";
            var expected1 = 6;
            var expected2 = 0;


            Praktika_Metodai.Program.Tarpai(fake, out var actual1, out var actual2);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);

        }

        [TestMethod]
        public void Tarpai_test2()
        {
            var fake = "      as  mokausi    programuoti  ";
            var expected1 = 6;
            var expected2 = 2;


            Praktika_Metodai.Program.Tarpai(fake, out var actual1, out var actual2);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);

        }

        [TestMethod]
        public void Tarpai_test3()
        {
            var fake = "as  mokausi    programuoti";
            var expected1 = 0;
            var expected2 = 0;


            Praktika_Metodai.Program.Tarpai(fake, out var actual1, out var actual2);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);

        }

        [TestMethod]
        public void A_test1()
        {
            var fake = "as mokausi programuoti";
            var expected = 3;

            var actual = Praktika_Metodai.Program.Araides(fake);

            Assert.AreEqual(expected, actual);



        }

        [TestMethod]
        public void A_test2()
        {
            var fake = "as mokausi programimo";
            var expected = 3;

            var actual = Praktika_Metodai.Program.Araides(fake);

            Assert.AreEqual(expected, actual);



        }

    }
}