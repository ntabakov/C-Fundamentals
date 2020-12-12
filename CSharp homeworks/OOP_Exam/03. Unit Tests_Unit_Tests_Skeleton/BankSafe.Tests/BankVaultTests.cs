using NUnit.Framework;
using System;
using System.Linq;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private BankVault bankVault = new BankVault();
        [SetUp]
        public void Setup()
        {
            bankVault = new BankVault();
        }

        [Test]
        public void AddMethodCannotAcceptNonExistingCell()
        {
            Item item = new Item("Owner","123");

            Assert.Throws<ArgumentException>(() => bankVault.AddItem("A444", item));
        }

        [Test]
        public void AddMethodCannotAcceptTwoItemsInSameCell()
        {
            Item item = new Item("Owner", "123");
            bankVault.AddItem("A4",item);
            Assert.Throws<ArgumentException>(() => bankVault.AddItem("A4", item));

        }
        [Test]
        public void AddMethodCannotAcceptTwoSameItemsInDifferentCellS()
        {
            Item item = new Item("Owner", "123");
            bankVault.AddItem("A3", item);
            Assert.Throws<InvalidOperationException>(() => bankVault.AddItem("A4", item));

        }

        [Test]
        public void AddMethodIsWorkingProperly()
        {
            Item item = new Item("Owner", "123");
            string actual = bankVault.AddItem("A4", item);
            string expected = $"Item:{item.ItemId} saved successfully!";

            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void RemoveMethodCannotRemoveNonExistingCells()
        {
            Item item = new Item("Owner", "123");

            Assert.Throws<ArgumentException>(() => bankVault.RemoveItem("A33", item));
        }
        [Test]
        public void RemoveMethodCannotRemoveNonExistingItems()
        {
            Item item = new Item("Owner", "123");

            Assert.Throws<ArgumentException>(() => bankVault.RemoveItem("A4", item));
        }

        [Test]
        public void RemoveMethodIsWorkingProperly()
        {
            Item item = new Item("Owner", "123");
            bankVault.AddItem("A4",item);
            string actual = bankVault.RemoveItem("A4", item);
            string expected = $"Remove item:{item.ItemId} successfully!";
            Assert.AreEqual(expected,actual);
            object actualobj = bankVault.VaultCells["A4"];
            object expectedobj = null;
            Assert.AreEqual(expectedobj,actualobj);
        }

        [Test]
        public void CheckConstructor()
        {
            object obj1 = bankVault.VaultCells["A1"];
            object obj2 = bankVault.VaultCells["A2"];
            object obj3 = bankVault.VaultCells["A3"];
            object obj4 = bankVault.VaultCells["A4"];
            object obj5 = bankVault.VaultCells["B1"];
            object obj6 = bankVault.VaultCells["B2"];
            object obj7 = bankVault.VaultCells["B3"];
            object obj8 = bankVault.VaultCells["B4"];
            object obj9 = bankVault.VaultCells["C1"];
            object obj10 = bankVault.VaultCells["C2"];
            object obj11 = bankVault.VaultCells["C3"];
            object obj12 = bankVault.VaultCells["C4"];


            Assert.AreEqual(null,obj1);
            Assert.AreEqual(null, obj2);
            Assert.AreEqual(null, obj3);
            Assert.AreEqual(null, obj4);
            Assert.AreEqual(null, obj5);
            Assert.AreEqual(null, obj6);
            Assert.AreEqual(null, obj7);
            Assert.AreEqual(null, obj8);
            Assert.AreEqual(null, obj9);
            Assert.AreEqual(null, obj10);
            Assert.AreEqual(null, obj11);
            Assert.AreEqual(null, obj12);

            //string bb1 = bankVault.VaultCells.ElementAt(0).Key;
            //string bb2 = bankVault.VaultCells.ElementAt(1).Key;
            //string bb3 = bankVault.VaultCells.ElementAt(2).Key;
            //string bb4 = bankVault.VaultCells.ElementAt(3).Key;
            //string bb5 = bankVault.VaultCells.ElementAt(4).Key;
            //string bb6 = bankVault.VaultCells.ElementAt(5).Key;
            //string bb7 = bankVault.VaultCells.ElementAt(6).Key;
            //string bb8 = bankVault.VaultCells.ElementAt(7).Key;
            //string bb9 = bankVault.VaultCells.ElementAt(8).Key;
            //string bb10 = bankVault.VaultCells.ElementAt(9).Key;
            //string bb11 = bankVault.VaultCells.ElementAt(10).Key;
            //string bb12 = bankVault.VaultCells.ElementAt(11).Key;

            //Assert.AreEqual("A2", bb2);
            //Assert.AreEqual("A3", bb3);
            //Assert.AreEqual("A4", bb4);
            //Assert.AreEqual("B1", bb5);
            //Assert.AreEqual("B2", bb6);
            //Assert.AreEqual("B3", bb7);
            //Assert.AreEqual("B4", bb8);
            //Assert.AreEqual("C1", bb9);
            //Assert.AreEqual("C2", bb10);
            //Assert.AreEqual("C3", bb11);
            //Assert.AreEqual("C4", bb12);



        }

    }
}