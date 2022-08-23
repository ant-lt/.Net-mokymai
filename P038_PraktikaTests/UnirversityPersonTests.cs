using P038_Praktika.InitialData;
using P038_Praktika.Models;
using P038_Praktika.Enums;

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
            person.SetHobbies(HobbyInitialData.DataSeedCsv);
            Assert.AreEqual(2, person.Hobbies.Count);
            Assert.AreEqual("Astrology", person.Hobbies[0].Text);
            Assert.AreEqual("Blogging", person.Hobbies[1].Text);
        }

        [TestMethod()]
        public void SetProfessionTest()
        {
            UniversityPerson person = new UniversityPerson(new FakeRandom());
            person.SetProfession(ProfessionInitialData.DataSeed);
            var expected = "Architect";
            var actual = person.Profession.Text;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SetProfessionTest_CsvSemicolon()
        {
            UniversityPerson person = new UniversityPerson(new FakeRandom());
            person.SetProfession(ProfessionInitialData.DataSeedCsvSemicolon);
            var expected = "Architect";
            var actual = person.Profession.Text;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SetProfessionTest_CsvComma()
        {
            UniversityPerson person = new UniversityPerson(new FakeRandom());
            person.SetProfession(ProfessionInitialData.DataSeedCsvComma);
            var expected = "Architect";
            var actual = person.Profession.Text;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetCsvTest()
        {
            UniversityPerson person = new UniversityPerson(new FakeRandom());
            person.Id = 1;
            person.FirstName = "Vardenis";
            person.LastName = "Pavardenis";
            person.Gender = EGenderType.MALE;
            person.SetHobbies(HobbyInitialData.DataSeedCsv);
            person.SetProfession(ProfessionInitialData.DataSeed);


            var expected = "1,Vardenis,Pavardenis,MALE,,0,0,3,1,4,,";
            var actual = person.GetCsv();

            Assert.AreEqual(expected, actual);
        }
    }
}
