using System;
using NUnit.Framework;

namespace Tests
{
    public class ArenaTests
    {
        private Arena arena;
        private Warrior warrior1;
        private Warrior warrior2;



        [SetUp]
        public void Setup()
        {
            arena = new Arena();
            warrior1 = new Warrior("Goshko", 200, 200);
            warrior2 = new Warrior("Peshko", 100, 200);


        }

        [Test]
        public void WarriorsCollectionAndCountAreWorking()
        {
            arena.Enroll(warrior1);
            arena.Enroll(warrior2);

            var expectedCount = 2;
            var actualCount = arena.Count;

            var actualWarrios = arena.Warriors.Count;

            Assert.AreEqual(expectedCount, actualCount);
            Assert.AreEqual(expectedCount, actualWarrios);

        }

        [Test]
        public void CannotEnrollWarriorMoreThanOnce()
        {
            arena.Enroll(warrior1);
            Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior1));
        }

        [Test]
        public void WarriorsFightProperly()
        {
            arena.Enroll(warrior1);
            arena.Enroll(warrior2);
            arena.Fight("Peshko","Goshko");
            var expected = 100;
            var actual = warrior1.HP;

            Assert.AreEqual(expected,actual);

        }

        [Test]
        public void WarriosThatDoNotExistCannotFight()
        {
            arena.Enroll(warrior1);
            arena.Enroll(warrior2);

            Assert.Throws<InvalidOperationException>(() => arena.Fight("Ivan", "Peshko"));
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Peshko", "Stoi4o"));
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Ivan", "Dimitri4ko"));
        }
    }
}
