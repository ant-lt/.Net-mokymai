using P038_Praktika.Models;

namespace P038_PraktikaTests
{
    [TestClass()]
    public class HobbyTests
    {
        [TestMethod()]
        public void EncodeCsvTest()
        {
            var fake = "1,Astrology,Astrologija";
            var hobby = new Hobby();
            hobby.EncodeCsv(fake);
            var expected = new Hobby(1, "Astrology", "Astrologija");

            Assert.AreEqual(expected.Text, hobby.Text);
            Assert.AreEqual(expected.TextLt, hobby.TextLt);
        }

        [TestMethod()]
        public void EncodeCsvTest1()
        {
            var fake = "1";
            var hobby = new Hobby();
            hobby.EncodeCsv(fake);
            var expected = new Hobby(0, null, null);

            Assert.AreEqual(expected.Text, hobby.Text);
            Assert.AreEqual(expected.TextLt, hobby.TextLt);
        }
    }
}