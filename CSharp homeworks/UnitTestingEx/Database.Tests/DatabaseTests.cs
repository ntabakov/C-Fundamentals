using System;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace Tests
{
    public class DatabaseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorShouldStoredIntegers()
        {
            var arr = Enumerable.Range(1, 16).ToArray();
            Database.Database database = new Database.Database(arr);

            CollectionAssert.AreEqual(arr,database.Fetch());
        }

        [Test]
        public void ArrayMustBe16Integers()
        {
            var arr = Enumerable.Range(1, 16).ToArray();
            Database.Database database = new Database.Database(arr);
            Assert.Throws<InvalidOperationException>(()=> database.Add(1));
        }
        [Test]
        public void CanAdd()
        {
            var arr = Enumerable.Range(1, 14).ToArray();

            Database.Database database = new Database.Database(arr);
            database.Add(1);
            int expected = 15;
            int actual = database.Fetch().Length;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldRemoveNumbers()
        {
            var arr = Enumerable.Range(1, 14).ToArray();
            Database.Database database = new Database.Database(arr);

            database.Remove();
            int expected = 13;
            int actual = database.Fetch().Length;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShouldNotRemoveEmptyArray()
        {
            
            Database.Database database = new Database.Database();
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }

        [Test]
        public void CheckIfCountIsWorking()
        {
            var arr = Enumerable.Range(1, 14).ToArray();

            Database.Database database = new Database.Database(arr);

            int expected = 14;
            int actual = database.Count;
            Assert.AreEqual(expected,actual);
        }




        //[Test]
        //public void FetchShouldReturnTheArray()
        //{
        //    var arr = Enumerable.Range(1, 14).ToArray();

        //    Database.Database database = new Database.Database(arr);

        //    var actual = database.Fetch();


        //}


    }
}