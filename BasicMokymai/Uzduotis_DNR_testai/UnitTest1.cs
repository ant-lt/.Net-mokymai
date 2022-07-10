namespace Uzduotis_DNR_testai
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNormalizacija1()
        {
            var fake = "      as  mokausi    programuoti";
            var expected = "ASMOKAUSIPROGRAMUOTI";

            var actual = Uzduotis_DNR.Program.Normalizavimas(fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNormalizacija2()
        {
            var fake = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            var expected = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";

            var actual = Uzduotis_DNR.Program.Normalizavimas(fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestValidacija1()
        {
            var fake = " T CG-TAC- gaC-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT    ";
            var expected = false;

            var actual = Uzduotis_DNR.Program.Validacija(fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestValidacija2()
        {
            var fake = "FCTACCTACCGT";
            var expected = false;

            var actual = Uzduotis_DNR.Program.Validacija(fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestValidacija3()
        {
            var fake = "TAC-CGT-CAG-ACT-TA";
            var expected = true;

            var actual = Uzduotis_DNR.Program.Validacija(fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPakeiskiAGG1()
        {
            var fake = "-GCT-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-GCT";
            var expected = "-AGG-TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA-AGG";

            var actual = Uzduotis_DNR.Program.pakeiskiAGG(fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPakeiskiAGG2()
        {
            var fake = "TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA";
            var expected = "TAC-CGT-CAG-ACT-TAa-CcA-GTC-cAt-AGA";

            var actual = Uzduotis_DNR.Program.pakeiskiAGG(fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestArTeksteCAT()
        {
            var fake = "TAC-CGT-CAG-ACT-TA";
            var tekstas = "CAT";
            var expected = false;

            var actual = Uzduotis_DNR.Program.ArYraGrandinejeTekstas(fake,tekstas);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestArTeksteCAT2()
        {
            var fake = "TAC-CGT-CAT-ACT-TA";
            var tekstas = "CAT";

            var expected = true;

            var actual = Uzduotis_DNR.Program.ArYraGrandinejeTekstas(fake,tekstas);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRaidziuKiekis()
        {
            var fake = "TAC-CGT-CAT-ACT-TA";
            var expected = 14;

            var actual = Uzduotis_DNR.Program.RaidziuKiekis(fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRaidziuKiekis2()
        {
            var fake = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var expected = 39;

            var actual = Uzduotis_DNR.Program.RaidziuKiekis(fake);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKiekKartojasiSegmentoKodas1()
        {
            var fake = "TAC-CGT-CAG-ACT-TA";
            var tekstas = "CAT";
            var expected = 0;

            var actual = Uzduotis_DNR.Program.KiekKartojasiSegmentoKodas(fake, tekstas);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestKiekKartojasiSegmentoKodas2()
        {
            var fake = "TCG-TAC-GAC-TAC-CGT-CAG-ACT-TAA-CCA-GTC-CAT-AGA-GCT";
            var tekstas = "TAC";
            var expected = 2;

            var actual = Uzduotis_DNR.Program.KiekKartojasiSegmentoKodas(fake, tekstas);

            Assert.AreEqual(expected, actual);
        }

    }
}