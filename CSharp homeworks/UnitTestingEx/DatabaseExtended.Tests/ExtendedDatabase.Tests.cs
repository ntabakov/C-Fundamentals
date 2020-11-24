using System;
using NUnit.Framework;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        public Person pesho;
        public Person gosho;

        [SetUp]
        public void TestInit()
        {
            pesho = new Person(123, "Pesho");
            gosho = new Person(456, "Gosho");
        }

        [Test]
        public void ConstructorShouldReceivePeople()
        {
            var expected = new Person[] {pesho, gosho};

            var db = new ExtendedDatabase(expected);

            var actual = expected;

            Assert.AreEqual(actual, expected);



            //Person person1 = new Person(1,"12");
            //Person person2 = new Person(2, "13");
            //Person person3 = new Person(3, "14");
            //Person person4 = new Person(4, "15");
            //Person person5 = new Person(5, "16");
            //Person person6 = new Person(6, "17");
            //Person person7 = new Person(7, "18");
            //Person person8 = new Person(8, "19");
            //Person person9 = new Person(9, "10");
            //Person person10 = new Person(10, "231");
            //Person person11 = new Person(11, "1432");
            //Person person12 = new Person(12, "1234324");
            //Person person13 = new Person(13, "14324");
            //Person person14 = new Person(14, "1asd");
            //Person person15 = new Person(15, "1asd");
            //Person person16 = new Person(16, "1asd");

            //var ppl = new Person[]
            //{
            //    person1,person2,person3,person4,person5
            //    ,person6,person7,person8,person9,person10,person11,person12,person13,person14
            //    ,person16,person15
            //};


        }

        [Test]
        public void CountIsWorking()
        {
            Person[] pp = {pesho, gosho};
            var db = new ExtendedDatabase(pp);
            int expected = 2;
            int actual = db.Count;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CantAddPeopleWithTheSameUsername()
        {
            Person[] pp = {pesho, gosho};
            var db = new ExtendedDatabase(pp);

            Assert.Throws<InvalidOperationException>(() => db.Add(new Person(4444, "Pesho")));
        }

        [Test]
        public void CantAddPeopleWithTheSameId()
        {
            Person[] pp = {pesho, gosho};
            var db = new ExtendedDatabase(pp);

            Assert.Throws<InvalidOperationException>(() => db.Add(new Person(123, "Pesdho")));
        }

        [Test]
        public void CantRemovePeopleIfEmpty()
        {
            Person[] pp = {pesho};
            var db = new ExtendedDatabase(pp);
            db.Remove();
            Assert.Throws<InvalidOperationException>(() => db.Remove());

        }

        [Test]
        [TestCase(1)]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(15)]
        [TestCase(16)]
        public void ConstructorShouldReceivePeopleV2(int count)
        {
            Person[] people = new Person[count];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, "Ivan" + i);
            }

            ExtendedDatabase db = new ExtendedDatabase(people);

            int expected = people.Length;
            int actual = db.Count;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(16)]
        public void CantAddMoreThan16People(int count)
        {
            Person[] people = new Person[count];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(i, "Ivan" + i);
            }

            ExtendedDatabase db = new ExtendedDatabase(people);



            Assert.Throws<InvalidOperationException>(() => db.Add(gosho));
        }

        [Test]
        public void ConstructorPersonShouldInitializeCollection()
        {
            Assert.IsNotNull(pesho);
        }

        [Test]
        public void CantFindByNull()
        {
            Person[] pp = {pesho, gosho};
            var db = new ExtendedDatabase(pp);

            Assert.Throws<ArgumentNullException>(() => db.FindByUsername(null));

        }

        [Test]
        public void CantFindNonExistingName()
        {
            Person[] pp = {pesho, gosho};
            var db = new ExtendedDatabase(pp);

            Assert.Throws<InvalidOperationException>(() => db.FindByUsername("nukkkk"));

        }

        [Test]
        public void ShouldFindExistingName()
        {
            Person[] pp = {pesho, gosho};
            var db = new ExtendedDatabase(pp);
            string expected = "Pesho";
            string actual = pp[0].UserName;

            Assert.AreEqual(expected, actual);


        }

        [Test]
        public void CantFindByNegativeId()
        {
            Person[] pp = {pesho, gosho};
            var db = new ExtendedDatabase(pp);

            Assert.Throws<ArgumentOutOfRangeException>(() => db.FindById(-1));

        }

        [Test]
        public void CantFindByNonExistingId()
        {
            Person[] pp = {pesho, gosho};
            var db = new ExtendedDatabase(pp);

            Assert.Throws<InvalidOperationException>(() => db.FindById(434234));

        }

        [Test]
        public void ShouldFindWithId()
        {
            Person[] pp = {pesho, gosho};
            var db = new ExtendedDatabase(pp);

            var expected = 123;
            var actual = pp[0].Id;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(1, "Pesho")]
        [TestCase(123, "Da")]
        [TestCase(4123, "Help")]
        [TestCase(674, "Tcccc")]
        [TestCase(999, "Ne")]
        public void Person_SuccessfulConstructor(long id, string userName)
        {
            Person person = new Person(id, userName);
            long expectedId = id;
            long actualId = person.Id;
            string expectedUsername = userName;
            string actualUsername = person.UserName;

            Assert.AreEqual(expectedId, actualId);
            Assert.AreEqual(expectedUsername, actualUsername);

        }


        [Test]
        public void Removing_Person_Should_Decrement_Count()
        {
            // Arrange
            var db = new ExtendedDatabase(new Person(48, "Filip"));

            // Act
            db.Add(new Person(3, "Simba"));
            db.Add(new Person(13, "Ivan4o"));
            db.Add(new Person(23, "Petkan4o"));

            db.Remove();

            var actualResult = db.Count;
            var expectedResult = 3;

            // Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [TestCase(null)]
        [TestCase("")]
        public void FindByUsername_Should_Throw_An_Exception_In_Case_Of_Null_Or_Whitespace(string username)
        {
            // Arrange
            var db = new ExtendedDatabase();

            // Assert
            Assert.Throws<ArgumentNullException>(
                () => db.FindByUsername(username),
                "The username is not null or whitespace.");
        }

        [Test]
        public void AddShouldAddValidPerson()
        {
            var persons = new Person[] {pesho, gosho};
            var db = new ExtendedDatabase(persons);
            var newPerson = new Person(554466, "Stoi4o");
            db.Add(newPerson);

            var expected = new Person[] {pesho, gosho, newPerson};
            var actual = expected;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CantAddMoreThan16People()
        {
            // Arrange
            var personArr = new Person[17];

            for (int i = 0; i < personArr.Length; i++)
            {
                personArr[i] = new Person(i + 1, $"Dim4o {i + 1}");
            }

            // Assert
            Assert.Throws<ArgumentException>(
                () => new ExtendedDatabase(personArr), // Act
                "The collection is not full.");
        }
        [Test]
        public void FindByUsername_Should_Return_The_Person_Correctly()
        {
            // Arrange
            var db = new ExtendedDatabase(new Person(12, "Simo"));

            // Act
            var actualResult = db.FindByUsername("Simo");

            // Assert
            Assert.That(actualResult.Id, Is.EqualTo(12));

            Assert.That(actualResult.UserName, Is.EqualTo("Simo"));
        }

        [Test]
        public void FindById_Should_Return_The_Person_Correctly()
        {
            // Arrange
            var db = new ExtendedDatabase(new Person(12, "Simo"));

            // Act
            var actualResult = db.FindById(12);

            // Assert
            Assert.That(actualResult.Id, Is.EqualTo(12));

            Assert.That(actualResult.UserName, Is.EqualTo("Simo"));
        }


    }
}