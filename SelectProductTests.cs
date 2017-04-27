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

        private void InsertCoinsAndSelectCola()
        {
            var coin = new Coin() { CoinProperties = CoinPropertiesEnum.Quarter };
            var coin2 = new Coin() { CoinProperties = CoinPropertiesEnum.Quarter };
            var coin3 = new Coin() { CoinProperties = CoinPropertiesEnum.Quarter };
            var coin4 = new Coin() { CoinProperties = CoinPropertiesEnum.Quarter };
            vendingMachine.InsertCoin(coin);
            vendingMachine.InsertCoin(coin2);
            vendingMachine.InsertCoin(coin3);
            vendingMachine.InsertCoin(coin4);
            vendingMachine.SelectProduct(ProductEnum.Cola);
        }

        [TestMethod]
        public void SelectProductDispensesCola()
        {
            InsertCoinsAndSelectCola();
            Assert.AreEqual(ProductEnum.Cola,vendingMachine.DispensedProduct);
        }


        [TestMethod]
        public void DispenseProductDisplaysThankYou()
        {
            InsertCoinsAndSelectCola();
            Assert.AreEqual("THANK YOU", vendingMachine.Display);
        }
        [TestMethod]
        public void DispenseProductSetsBalanceToZero()
        {
            InsertCoinsAndSelectCola();
            Assert.AreEqual(0, vendingMachine.SumCoins());
        }


        [TestMethod]
        public void CheckDisplayChangesDisplayAfterProductIsDispensed()
        {
            InsertCoinsAndSelectCola();
            Assert.AreEqual("THANK YOU", vendingMachine.Display);
            Assert.AreEqual("INSERT COIN", vendingMachine.Display);
        }

        [TestMethod]
        public void CheckDisplayChangesWhenNotEnoughMoneyIsInserted()
        {
            vendingMachine.SelectProduct(ProductEnum.Candy);
            Assert.AreEqual("PRICE: $0.65", vendingMachine.Display);
            Assert.AreEqual("INSERT COIN", vendingMachine.Display);
        }

        [TestMethod]
        public void CheckDisplayChangesToBalanceWhenNotEnoughMoneyIsInserted()
        {
            var coin = new Coin() { CoinProperties = CoinPropertiesEnum.Quarter };
            vendingMachine.InsertCoin(coin);
            vendingMachine.SelectProduct(ProductEnum.Candy);
            Assert.AreEqual("PRICE: $0.65", vendingMachine.Display);
            Assert.AreEqual("$0.25", vendingMachine.Display);
        }
    }
}
