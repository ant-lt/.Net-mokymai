namespace Hangman_testai
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ArYraNepanaudotuZodziuTemoj()
        {
            //ParinktiAtsitiktiniZodiTemoje

            Hangman.Program.Reset();
           
            Assert.IsTrue(Hangman.Program.ArYraNepanaudotuZodziuTemoje("VARDAI"));
        }

        [TestMethod]
        public void ParinktiAtsitiktiniZodiTemoje()
        {
            //Patikrinam, kad gràþinam kaþkoki atsitiktini þodá pagal uþduota temà 

            Hangman.Program.Reset();
            string actual = Hangman.Program.ParinktiAtsitiktiniZodiTemoje("VARDAI");
            
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void AtsitiktinisSkaicius()
        {
            //Patikrinam, kad grazinam kazkoki atsitiktini zodzio numeri nuo 1 iki 40

            Hangman.Program.Reset();
            var actual = Hangman.Program.AtsitiktinisSkaicius(1,40+1);

            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void Atidenktos_visos_raides_Ne()
        {
            // 
            bool[] mask = { true, false, false, false, false, false, false, false, false };

            var actual = Hangman.Program.Atidenktos_visos_raides(mask);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void Atidenktos_visos_raides_Taip()
        {
            bool[] mask = { true, true, true, true };

            var actual = Hangman.Program.Atidenktos_visos_raides(mask);

            Assert.IsTrue(actual);
        }


        [TestMethod]
        public void Atidenk_raide()
        {
            string zodis = "Testas";
            bool[] mask = { false, false, false, false, false, false };


            var actual = Hangman.Program.Atidenk_raide(zodis, mask, 't');

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void Atidenk_raide_mask_test()
        {
            string zodis = "Testas";
            bool[] actual = { false, false, false, false, false, false };
            bool[] expected = { true, false, false, true, false, false };

            Hangman.Program.Atidenk_raide(zodis, actual, 't');

            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Atvaizduok_zodi()
        {
            string zodis = "Testas";
            string expected = "T _ _ t _ _ ";
            bool[] mask = { true, false, false, true, false, false };

            var actual = Hangman.Program.Atvaizduok_zodi(zodis, mask);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Nupiesti_zmogeli_karimo_stadija_0()
        // kai zmogelis neatvaizduojamas - yra visos gyvybes
        {
            string expected = "|              \r\n|              \r\n|              \r\n|              \r\n";
            int karimo_stadija = 0;

            var actual = Hangman.Program.Nupiesti_zmogeli(karimo_stadija);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Nupiesti_zmogeli_karimo_stadija_7()
            // kai atvaizduojamas visas zmogelis - nera like gyvybiu
        {
            string expected = "|            O \r\n|           \\|/\r\n|            O \r\n|           / \\\r\n";            
            int karimo_stadija = 7;

            var actual = Hangman.Program.Nupiesti_zmogeli(karimo_stadija);

            Assert.AreEqual(expected, actual);
        }
    }
}