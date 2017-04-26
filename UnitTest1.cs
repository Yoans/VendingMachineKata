using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace VendingMachineKata
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AcceptCoins()
        {
            var vendingMachine = new VendingMachine();
            vendingMachine.InsertCoin(new Coin());
            Assert.IsTrue(vendingMachine.Coins.Any());

        }
    }
}
