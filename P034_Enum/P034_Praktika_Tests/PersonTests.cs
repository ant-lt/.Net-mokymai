using P034_Praktika.Enum;
using P034_Praktika.Klases;
using P034_Praktika.Models;

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

        [TestMethod]
        public void OldPeple_Test()
        {
            List<Person> fakePersonList = new List<Person>();

            fakePersonList.Add(new Person { Id = 1, FirstName = "Laurynas ", LastName = "Laurynaitis",  Gender = EGenderType.MALE, Height = 180, Weight = 80.2M, BirthDate = DateTime.Parse("1976-01-05")});
            fakePersonList.Add(new Person { Id = 3, FirstName = "Adomas",    LastName = "Adomaitis",    Gender = EGenderType.MALE, Height = 169, Weight = 105.2M, BirthDate = DateTime.Parse("2000-03-01")});
            fakePersonList.Add(new Person { Id = 4, FirstName = "Linas", LastName = "Linasis", Gender = EGenderType.MALE, Height = 191, Weight = 95.5M, BirthDate = DateTime.Parse("2002-12-05")});


            Society society = new Society();

            society.People=fakePersonList;

            List<Person> expectedOldPersonList = new List<Person>();
            expectedOldPersonList.Add(new Person { Id = 1, FirstName = "Laurynas ", LastName = "Laurynaitis", Gender = EGenderType.MALE, Height = 180, Weight = 80.2M, BirthDate = DateTime.Parse("1976-01-05") });
            expectedOldPersonList.Add(new Person { Id = 3, FirstName = "Adomas", LastName = "Adomaitis", Gender = EGenderType.MALE, Height = 169, Weight = 105.2M, BirthDate = DateTime.Parse("2000-03-01") });



            var actualOldPersonList = society.OldPeople;

 
            CollectionAssert.AreEqual(expectedOldPersonList, actualOldPersonList);
        }

        /*
        [TestMethod]
        public void FillMen_Test()
        {
            Society society = new Society();

            society.FillMen();
          
            List<Person> expectedMenList = new List<Person>();
            expectedMenList.Add(new Person { Id = 1, FirstName = "Laurynas ", LastName = "Laurynaitis", Gender = EGenderType.MALE, Height = 180, Weight = 80.2M, BirthDate = DateTime.Parse("1976-01-05") });
            expectedMenList.Add(new Person { Id = 3, FirstName = "Adomas", LastName = "Adomaitis", Gender = EGenderType.MALE, Height = 169, Weight = 105.2M, BirthDate = DateTime.Parse("2000-03-01") });


            var actualMenList = society.Men;


            CollectionAssert.AreEqual(expectedMenList, actualMenList);
        }
        */

    }
}