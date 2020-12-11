using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Computers.Tests
{
    public class Tests
    {
        private ComputerManager cm;
        private Computer defaultComputer;
        private readonly string defaultManufacturer = "Asus";
        private readonly string defaultModel = "X55";
        private readonly decimal defaultPrice = 1500;

        [SetUp]
        public void Setup()
        {
            cm = new ComputerManager();
            this.defaultComputer = new Computer(defaultManufacturer, defaultModel, defaultPrice);
        }

        [Test]
        public void CountIsWorkingProperly()
        {

            Computer computer = new Computer("Dawe", "Turbo", 44);
            cm.AddComputer(computer);

            int expected = 1;
            int actual = cm.Count;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddMethodCannotAcceptNulLComputers()
        {
            Computer comp = null;

            Assert.Throws<ArgumentNullException>(() => cm.AddComputer(comp));
        }

        [Test]
        public void AddCannotAcceptTwoSimilarComputers()
        {
            Computer computer = new Computer("Dawe", "Turbo", 44);
            cm.AddComputer(computer);

            Assert.Throws<ArgumentException>(() => cm.AddComputer(computer));
        }

        [Test]
        public void RemoveComputerIsWorkingProperly()
        {
            Computer computer = new Computer("Dawe", "Turbo", 44);
            cm.AddComputer(computer);

            var expected = computer;
            var actual = cm.RemoveComputer("Dawe", "Turbo");

            Assert.AreSame(expected, actual);
        }

        [Test]
        public void GetComputerIsWorkingProperly()
        {
            Computer computer = new Computer("Dawe", "Turbo", 44);
            Computer computer2 = new Computer("Op", "Mashina", 55);
            cm.AddComputer(computer2);
            cm.AddComputer(computer);

            var expected = computer;
            var actual = cm.GetComputer("Dawe", "Turbo");

            Assert.AreSame(expected, actual);
        }

        [Test]
        public void CheckIfComputerConstructorWorksCorrectly()
        {
            Assert.AreEqual(this.defaultPrice, this.defaultComputer.Price);
            Assert.AreEqual(this.defaultManufacturer, this.defaultComputer.Manufacturer);
            Assert.AreEqual(this.defaultModel, this.defaultComputer.Model);
        }
        [Test]
        public void CheckIfConstructorWorksCorrectly()
        {
            Assert.That(this.cm.Count, Is.EqualTo(0));
            Assert.That(this.cm.Computers, Is.Empty);
        }
        [Test]
        public void GetAllByManufacturerShouldReturnCorrectCollection()
        {
            this.cm.AddComputer(this.defaultComputer);
            this.cm.AddComputer(new Computer(this.defaultManufacturer, "K210", 899.99m));
            this.cm.AddComputer(new Computer(this.defaultManufacturer, "P34", 420));
            var collection = this.cm.GetComputersByManufacturer(this.defaultManufacturer);

            Assert.That(collection.Count, Is.EqualTo(3));

        }

        [Test]
        public void GetComputerCannotGetNull()
        {
            Assert.Throws<ArgumentException>(() => cm.GetComputer("Da", "Ddd"));

        }

        [Test]
        public void GetComputersByManufacturerIsWorkingProperly()
        {
            Computer computer = new Computer("Dawe", "Turbo", 44);
            Computer computer3 = new Computer("Op", "Daas", 55);

            cm.AddComputer(computer);
            cm.AddComputer(computer3);

            ICollection<Computer> expected = new List<Computer>() {computer3};
            var actual = cm.GetComputersByManufacturer("Op");

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void ComputerCollectionsIsWorking()
        {
            Computer computer = new Computer("Dawe", "Turbo", 44);

            cm.AddComputer(computer);

            IReadOnlyCollection<Computer> expected = new List<Computer>() {computer};
            var actual = cm.Computers;

            CollectionAssert.AreEqual(actual, expected);
        }
        [Test]
        public void RemoveShouldThrowExceptionWhenManufacturerNull()
        {
            ComputerManager computerManager = new ComputerManager();
            computerManager.AddComputer(this.defaultComputer);

            Assert.Throws<ArgumentNullException>(() =>
            {
                var computer = computerManager.RemoveComputer(null, "Model");
            });
        }

        [Test]
        public void GetComputersByManufacturerShouldWorkCorrectly()
        {
            ComputerManager computerManager = new ComputerManager();
            computerManager.AddComputer(this.defaultComputer);
            computerManager.AddComputer(new Computer("Asus", "NotePad", 1500.00M));

            var collection = computerManager.GetComputersByManufacturer("Asus").ToList();
            int expectedCount = 2;

            Assert.That(collection.Count, Is.EqualTo(expectedCount));
        }

        [Test]
        public void GetComputersByManufacturerShouldThrowExceptionWhenManufacturerIsNull()
        {
            ComputerManager computerManager = new ComputerManager();
            computerManager.AddComputer(this.defaultComputer);

            Assert.Throws<ArgumentNullException>(() =>
            {
                var collection = computerManager.GetComputersByManufacturer(null);
            });
        }

        [Test]
        public void GetComputersByManufacturerShouldReturnEmptyCollectionWhenNoMatchesFound()
        {
            cm.AddComputer(this.defaultComputer);

            var collection = cm.GetComputersByManufacturer("ASss").ToList();

            CollectionAssert.IsEmpty(collection);
        }

        [Test]
        public void RemoveShouldThrowExceptionWhenNullModel()
        {
            ComputerManager computerManager = new ComputerManager();
            computerManager.AddComputer(this.defaultComputer);

            Assert.Throws<ArgumentNullException>(() =>
            {
                var computer = computerManager.RemoveComputer(this.defaultComputer.Manufacturer, null);
            });
        }
        //    [Test]
        //    public void ValidateNullIsWorking()
        //    {
        //        Assert.Throws<ArgumentNullException>(()=>cm.)
        //    }
        //}
    }
}