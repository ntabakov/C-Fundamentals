using System;
using NUnit.Framework;

namespace Tests
{
    public class CarTests
    {
        

        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ConstructorShouldWorkProperly()
        {
            Car car = new Car("VW","Golf",5,60);

            var expectedMake = "VW";
            var expectedModel = "Golf";
            var expectedFuelCons = 5.0;
            var expectedFuelCap = 60.0;
            var expecteFuelAmount = 0;

            var actualMake = car.Make;
            var actualModel = car.Model;
            var actualFuelCons = car.FuelConsumption;
            var actualFuelCap = car.FuelCapacity;
            var actualFuelAmount = car.FuelAmount;

            Assert.AreEqual(actualMake,expectedMake);
            Assert.AreEqual(expectedModel, actualModel);
            Assert.AreEqual(actualFuelCons, expectedFuelCons);
            Assert.AreEqual(expectedFuelCap, actualFuelCap);
            Assert.AreEqual(expecteFuelAmount, actualFuelAmount);


        }

        [Test]
        [TestCase("")]
        [TestCase(null)]

        public void ConstructorCantAcceptNullOrEmptyMake(string value)
        {
            Assert.Throws<ArgumentException>(() => new Car(value, "Golf", 5, 10));

        }

        [Test]
        [TestCase("")]
        [TestCase(null)]

        public void ConstructorCantAcceptNullOrEmptyModel(string value)
        {
            Assert.Throws<ArgumentException>(() => new Car("VW", value, 5, 10));

        }

        [Test]
        [TestCase(0)]
        [TestCase(-20)]
        [TestCase(-1)]

        public void FuelConsumptionCannotBeZeroOrNegative(double value)
        {
            Assert.Throws<ArgumentException>(() => new Car("VW", "Golf", value, 30));
        }

        [Test]
        [TestCase(-20)]
        [TestCase(0)]
        [TestCase(-1)]

        public void FuelCapacityCannotBeZeroOrNegative(double value)
        {
            Assert.Throws<ArgumentException>(() => new Car("VW", "Golf", 55, value));
        }

        //[Test]
        //public void FuelAmountCannotBeNegative()
        //{
        //    Car car = new Car("VW","Golf",5,60);
        //    car.FuelAmount = 2;
        //}

        [Test]
        public void RefuelIsWorkingProperly()
        {
            Car car = new Car("VW", "Golf", 10, 100);
            

            car.Refuel(50);
            var expected = 50;
            var actual = car.FuelAmount;

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void RefualCannotExceedFuelCapacity()
        {
            Car car = new Car("VW", "Golf", 10, 100);
            

            car.Refuel(5000);
            var expected = 100;
            var actual = car.FuelAmount;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-1203)]

        public void RefualCannotBeZeroOrNegative(double value)
        {
            Car car = new Car("VW", "Golf", 10, 100);

            Assert.Throws<ArgumentException>(() => car.Refuel(value));
        }

        [Test]
        public void DriveIsWorkingProperly()
        {
            Car car = new Car("VW", "Golf", 10, 100);
            car.Refuel(100);
            car.Drive(500);

            var expected = 50;
            var actual = car.FuelAmount;

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void CannotDriveIfNotEnoughtFuel()
        {
            Car car = new Car("VW", "Golf", 5, 60);

            Assert.Throws<InvalidOperationException>(() => car.Drive(200));
        }
    }
}