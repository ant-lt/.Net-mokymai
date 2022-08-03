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
        public void AtidenktosVisosRaidesNe()
        {
            // 
            bool[] mask = { true, false, false, false, false, false, false, false, false };

            var actual = Hangman.Program.AtidenktosVisosRaides(mask);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void AtidenktosVisosRaidesTaip()
        {
            bool[] mask = { true, true, true, true };

            var actual = Hangman.Program.AtidenktosVisosRaides(mask);

            Assert.IsTrue(actual);
        }


        [TestMethod]
        public void AtidenkRaide()
        {
            string zodis = "Testas";
            bool[] mask = { false, false, false, false, false, false };


            var actual = Hangman.Program.AtidenkRaide(zodis, mask, 't');

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void AtidenkRaideMaskTest()
        {
            string zodis = "Testas";
            bool[] actual = { false, false, false, false, false, false };
            bool[] expected = { true, false, false, true, false, false };

            Hangman.Program.AtidenkRaide(zodis, actual, 't');

            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void AtvaizduokZodi()
        {
            string zodis = "Testas";
            string expected = "T _ _ t _ _ ";
            bool[] mask = { true, false, false, true, false, false };

            var actual = Hangman.Program.AtvaizduokZodi(zodis, mask);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NupiestiZmogeliKarimoStadija0()
        // kai zmogelis neatvaizduojamas - yra visos gyvybes
        // Turi buti suformuotas toks vaizdas
        /*
         
        |              
        |              
        |              
        |   

         */
        {
            string expected = "|              \r\n|              \r\n|              \r\n|              \r\n";
            int karimo_stadija = 0;

            var actual = Hangman.Program.NupiestiZmogeli(karimo_stadija);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NupiestiZmogeliKarimoStadija1()
        // kai zmogelis nera 1  gyvybes
        // Turi buti suformuotas toks vaizdas
        /*
         
        |            O 
        |              
        |              
        |              

         */
        {
            string expected = "|            O \r\n|              \r\n|              \r\n|              \r\n";
            int karimo_stadija = 1;

            var actual = Hangman.Program.NupiestiZmogeli(karimo_stadija);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NupiestiZmogeliKarimoStadija2()
        // kai zmogelis nera 2 gyvybes
        // Turi buti suformuotas toks vaizdas
        /*
         
        |            O 
        |            | 
        |              
        |              

         */
        {
            string expected = "|            O \r\n|            | \r\n|              \r\n|              \r\n";
            int karimo_stadija = 2;

            var actual = Hangman.Program.NupiestiZmogeli(karimo_stadija);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NupiestiZmogeliKarimoStadija3()
        // kai zmogelis nera 3 gyvybes
        // Turi buti suformuotas toks vaizdas
        /*
         
        |            O 
        |           \| 
        |              
        |                         

         */
        {
            string expected = "|            O \r\n|           \\| \r\n|              \r\n|              \r\n";
            int karimo_stadija = 3;

            var actual = Hangman.Program.NupiestiZmogeli(karimo_stadija);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NupiestiZmogeliKarimoStadija4()
        // kai zmogelis nera 4 gyvybes
        // Turi buti suformuotas toks vaizdas
        /*
        
        |            O 
        |           \|/
        |              
        |              
                        
         */
        {
            string expected = "|            O \r\n|           \\|/\r\n|              \r\n|              \r\n";
            int karimo_stadija = 4;

            var actual = Hangman.Program.NupiestiZmogeli(karimo_stadija);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NupiestiZmogeliKarimoStadija5()
        // kai zmogelis nera 5 gyvybes
        // Turi buti suformuotas toks vaizdas
        /*
        
        |            O 
        |           \|/
        |            O 
        |           
        
         */
        {
            string expected = "|            O \r\n|           \\|/\r\n|            O \r\n|              \r\n";
            int karimo_stadija = 5;

            var actual = Hangman.Program.NupiestiZmogeli(karimo_stadija);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NupiestiZmogeliKarimoStadija6()
        // kai zmogelis nera 6 gyvybiu
        // Turi buti suformuotas toks vaizdas
        /*
        |            O 
        |           \|/
        |            O 
        |           /  
             
         */
        {
            string expected = "|            O \r\n|           \\|/\r\n|            O \r\n|           /  \r\n";
            int karimo_stadija = 6;

            var actual = Hangman.Program.NupiestiZmogeli(karimo_stadija);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NupiestiZmogeliKarimoStadija7()
        // kai atvaizduojamas visas zmogelis - nera like gyvybiu
        /*
        |            O 
        |           \|/
        |            O 
        |           / \

        */
        {
            string expected = "|            O \r\n|           \\|/\r\n|            O \r\n|           / \\\r\n";            
            int karimo_stadija = 7;

            var actual = Hangman.Program.NupiestiZmogeli(karimo_stadija);

            Assert.AreEqual(expected, actual);
        }
    }
}