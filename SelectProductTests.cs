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
            Assert.AreEqual("PRICE: $1.00",vendingMachine.Display);
        }
        
    }
}
