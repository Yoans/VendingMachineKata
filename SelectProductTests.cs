using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace VendingMachineKata
{
    [TestClass]
    public class SelectProductTests
    {
        public VendingMachine vendingMachine;

        [TestInitialize]
        public void Setup()
        {
            vendingMachine = new VendingMachine();
        }

        [TestMethod]
        public void SelectProductDisplaysColaPrice()
        {
            vendingMachine.SelectProduct(ProductEnum.Cola);
            Assert.AreEqual("PRICE: $1.00", vendingMachine.Display);
        }

        [TestMethod]
        public void SelectProductDisplaysChipsPrice()
        {
            vendingMachine.SelectProduct(ProductEnum.Chips);
            Assert.AreEqual("PRICE: $0.50", vendingMachine.Display);
        }

        [TestMethod]
        public void SelectProductDisplaysCandyPrice()
        {
            vendingMachine.SelectProduct(ProductEnum.Candy);
            Assert.AreEqual("PRICE: $0.65", vendingMachine.Display);
        }

        //[TestMethod]
        //public void SelectProductDispensesCola()
        //{
        //    vendingMachine.InsertCoin();
        //    vendingMachine.SelectProduct(ProductEnum.Cola);
        //    Assert.AreEqual("PRICE: $1.00", vendingMachine.Display);
        //}

    }
}
