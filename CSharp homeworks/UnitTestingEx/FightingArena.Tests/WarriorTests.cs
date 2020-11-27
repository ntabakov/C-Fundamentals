using System;
using NUnit.Framework;

namespace Tests
{
    public class WarriorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WarriorConstructorShouldWorkProperly()
        {
            Warrior warrior = new Warrior("Goshko",20,100);

            var expectedName = "Goshko";
            var expectedDamage = 20;
            var expectedHP = 100;

            var actualName = warrior.Name;
            var actualDamage = warrior.Damage;
            var actualHP = warrior.HP;

            Assert.AreEqual(expectedName,actualName);
            Assert.AreEqual(expectedDamage, actualDamage);
            Assert.AreEqual(expectedHP, actualHP);

        }

        [Test]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]

        public void WarriorNameShouldNotBeEmptyOrNullOrWhitespace(string name)
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, 20, 100));
        }

        [Test]
        [TestCase(-10)]
        [TestCase(-210)]
        [TestCase(0)]

        public void WarriorCantHaveZeroOrNegativeDamage(int damage)
        {
            Assert.Throws<ArgumentException>(() => new Warrior("Name", damage, 100));
        }

        [Test]
        [TestCase(-10)]
        [TestCase(-210)]

        public void WarriorCantHaveNegativeHP(int hp)
        {
            Assert.Throws<ArgumentException>(() => new Warrior("Name", 20, hp));
        }

        [Test]
        public void WarriorCannotAttackWithLessOrEqualThan30HP()
        {
            Warrior warrior1 = new Warrior("Goshko", 20, 20);
            Warrior warrior2 = new Warrior("Peshko", 20, 100);

            Assert.Throws<InvalidOperationException>(() => warrior1.Attack(warrior2));
        }

        [Test]
        public void WarriorCannotAttackEnemyWhoHasLessOrEqualThan30HP()
        {
            Warrior warrior1 = new Warrior("Goshko", 20, 100);
            Warrior warrior2 = new Warrior("Peshko", 20, 20);

            Assert.Throws<InvalidOperationException>(() => warrior1.Attack(warrior2));
        }

        [Test]
        public void WarriorCannotAttackStrongerEnemies()
        {
            Warrior warrior1 = new Warrior("Goshko", 20, 99);
            Warrior warrior2 = new Warrior("Peshko", 100, 100);

            Assert.Throws<InvalidOperationException>(() => warrior1.Attack(warrior2));
        }

        [Test]
        public void WarrorHpIsReducedProperly()
        {
            Warrior warrior1 = new Warrior("Goshko", 20, 200);
            Warrior warrior2 = new Warrior("Peshko", 20, 100);

            warrior1.Attack(warrior2);

            var expected = 180;
            var actual = warrior1.HP;

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void IfWarriorDamageMoreThanEnemyHPEnemyHPMustBe0()
        {
            Warrior warrior1 = new Warrior("Goshko", 200, 200);
            Warrior warrior2 = new Warrior("Peshko", 20, 100);

            warrior1.Attack(warrior2);

            var expected = 0;
            var actual = warrior2.HP;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void WarriorDealsDamageProperly()
        {
            Warrior warrior1 = new Warrior("Goshko", 20, 200);
            Warrior warrior2 = new Warrior("Peshko", 20, 100);

            warrior1.Attack(warrior2);

            var expected = 80;
            var actual = warrior2.HP;

            Assert.AreEqual(expected, actual);
        }
    }
}