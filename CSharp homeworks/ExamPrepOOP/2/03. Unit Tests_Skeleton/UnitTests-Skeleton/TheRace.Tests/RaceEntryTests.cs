using System;
using System.Collections.Generic;
using NUnit.Framework;
using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        private RaceEntry raceEntry;
        [SetUp]
        public void Setup()
        {
            raceEntry = new RaceEntry();
            
        }

        [Test]
        public void CounterShouldWorkProperly()
        {
            UnitDriver driver = new UnitDriver("asd",new UnitCar("asdddas",123,12));
            int expected = 1;
            raceEntry.AddDriver(driver);
            int actual = raceEntry.Counter;
            Assert.AreEqual(1, actual);
        }

        [Test]
        public void AddDriverIsWorkingProperly()
        {
            UnitDriver driver = new UnitDriver("asd", new UnitCar("asdddas", 123, 12));
            UnitDriver driver1 = new UnitDriver("asd", new UnitCar("asdddas", 123, 12));
            UnitDriver driverNull = null;
            raceEntry.AddDriver(driver);

            Assert.Throws<InvalidOperationException>(() => raceEntry.AddDriver(driver1));
            Assert.Throws<InvalidOperationException>(() => raceEntry.AddDriver(driverNull));

        }

        [Test]
        public void CalculateHPShouldThrowAE()
        {
            Assert.Throws<InvalidOperationException>(() => raceEntry.CalculateAverageHorsePower());
        }

        [Test]
        public void CalculateHPIsWorkingProperly()
        {
            UnitDriver driver = new UnitDriver("Basd", new UnitCar("asdddas", 123, 12));
            UnitDriver driver2 = new UnitDriver("asd", new UnitCar("asfgdddas", 123, 12));
            UnitDriver driver3 = new UnitDriver("Gasd", new UnitCar("asdsdddas", 123, 12));
            raceEntry.AddDriver(driver2);
            raceEntry.AddDriver(driver3);
            raceEntry.AddDriver(driver);

            double expected = 123;
            double actual = raceEntry.CalculateAverageHorsePower();
            Assert.AreEqual(expected,actual);
        }
    }
}