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
            vendingMachine.InsertCoin(new Coin() { CoinProperties = CoinPropertiesEnum.Nickel });
            Assert.IsTrue(vendingMachine.Coins.Any());
        }

        [TestMethod]
        public void RejectCoins()
        {
            vendingMachine.InsertCoin(new Coin() { CoinProperties = CoinPropertiesEnum.Penny });
            Assert.IsFalse(vendingMachine.Coins.Any());
        }

        [TestMethod]
        public void DisplaysInsertCoinInitially()
        {
            Assert.AreEqual("INSERT COIN", vendingMachine.Display);
        }

        [TestMethod]
        public void RejectedCoinsAreReturned()
        {
            var coin = new Coin() { CoinProperties = CoinPropertiesEnum.Penny };
            vendingMachine.InsertCoin(coin);
            Assert.IsTrue(vendingMachine.CoinReturn.Any());
        }

        [TestMethod]
        public void NickelsAreAccepted()
        {
            var coin = new Coin() { CoinProperties = CoinPropertiesEnum.Nickel };
            vendingMachine.InsertCoin(coin);
            Assert.IsTrue(vendingMachine.Coins.Any());
        }


        [TestMethod]
        public void DimesAreAccepted()
        {
            var coin = new Coin() { CoinProperties = CoinPropertiesEnum.Dime };
            vendingMachine.InsertCoin(coin);
            Assert.IsTrue(vendingMachine.Coins.Any());
        }


        [TestMethod]
        public void QuartersAreAccepted()
        {
            var coin = new Coin() { CoinProperties = CoinPropertiesEnum.Quarter };
            vendingMachine.InsertCoin(coin);
            Assert.IsTrue(vendingMachine.Coins.Any());
        }

        [TestMethod]
        public void PenniesAreRejected()
        {
            var coin = new Coin() { CoinProperties = CoinPropertiesEnum.Penny };
            vendingMachine.InsertCoin(coin);
            Assert.IsTrue(vendingMachine.CoinReturn.Any());
        }

    }
}
