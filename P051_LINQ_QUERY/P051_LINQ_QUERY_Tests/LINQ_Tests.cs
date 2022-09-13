using Microsoft.VisualStudio.TestTools.UnitTesting;

using P051_LINQ_QUERY;


namespace P051_LINQ_QUERY_Tests
{
    [TestClass]
    public class LINQ_Tests
    {
        [TestMethod]
        public void Uzd1_Lyginiai_skaiciai_Test()
        {
            var actual = Program.uzd1_Lyginiai_Skaiciai();
            int[] expected = new int[] { 0, 2, 4, 6, 8};

            CollectionAssert.AreEqual(expected, actual);

        }
    }
}