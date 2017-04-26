using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace VendingMachineKata
{
    [TestClass]
    public class UnitTest1
    {
        public VendingMachine vendingMachine;

        [TestInitialize]
        public void Setup()
        {
            vendingMachine = new VendingMachine();
        }

        [TestMethod]
        public void AcceptCoins()
        {
            vendingMachine.InsertCoin(new Coin());
            Assert.IsTrue(vendingMachine.Coins.Any());
        }

        [TestMethod]
        public void RejectCoins()
        {
            vendingMachine.InsertCoin(new Coin() {IsValid = false});
            Assert.IsFalse(vendingMachine.Coins.Any());
        }
    }
}
