using P038_Praktika.Models;

namespace P038_PraktikaTests
{
    public class FakeRandom : Random
    {
        private int iterator = -1;
        public override int Next(int minValue, int maxValue)
        {
            iterator++;
            return iterator switch
            {
                0 => 2,
                1 => 0,
                2 => 0,
                3 => 3,
                4 => 2,
                5 => 5,
            };
        }
    }


    [TestClass()]
    public class UniversityPersonTests
    {
        [TestMethod()]
        public void SetHobbiesTest()
        {
            UniversityPerson person = new UniversityPerson(new FakeRandom());

            person.SetHobbies();

            Assert.Fail();
        }
    }
}
