namespace For_Ciklai_testai
{
    [TestClass]
    public class UnitTest1
    {
        string dnr = "TCG-TAC-";
        int iteration = 1_000_000;

        [TestMethod]
        public void DNRGrandinesValidacija_Replace()
        {
            var actual = false;
            for (int i = 0; i < iteration; i++)
            {
                actual = For_Ciklai.Program.DNRGrandinesValidacija_Replace(dnr);
            }
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void DNRGrandinesValidacija_For()
        {
            var actual = false;
            for (int i = 0; i < iteration; i++)
            {
                actual = For_Ciklai.Program.DNRGrandinesValidacija_For(dnr);
            }
            Assert.IsTrue(actual);
        }

    }
}