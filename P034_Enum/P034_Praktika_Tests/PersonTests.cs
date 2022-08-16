using P034_Praktika.Enum;
using P034_Praktika.Klases;

namespace P034_Praktika_Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void FullName_Test()
        {
            var fakeFirstName = "Vardenis";
            var fakeLastName = "Pavardenis";

            var obj = new Person
            {
                FirstName = fakeFirstName,
                LastName = fakeLastName,
            };
            var actual = obj.FullName;
            var expected = "Vardenis Pavardenis";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ChangeGender_Test()
        {
            var fakeFirstName = "Vardenis";
            var fakeLastName = "Pavardenis";
            var fakeGender = EGenderType.MALE;

            var obj = new Person(EGenderType.FEMALE)
            {
                FirstName = fakeFirstName,
                LastName = fakeLastName,
            };
            obj.ChangeGender(fakeGender);
            var actual = obj.Gender;
            var expected = EGenderType.MALE;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void NameChanges_Test()
        {
            var fakeFirstName = "Vardenis";
            var fakeLastName = "Pavardenis";

            var obj = new Person
            {
                FirstName = fakeFirstName,
                LastName = fakeLastName,
            };
            obj.FirstName = "Petras";

            var actual = obj.NameChanges;
            var expected = "Vardenis -> Petras ";

            Assert.AreEqual(expected, actual);
        }
    }
}