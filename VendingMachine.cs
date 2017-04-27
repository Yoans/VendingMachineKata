﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace VendingMachineKata
{
    public class VendingMachine
    {

        public List<Coin> CoinReturn { get; internal set; }
        public List<Coin> Coins { get; internal set; }
        public string Display { get; internal set; }
        public Dictionary<CoinPropertiesEnum,decimal> CoinValues { get; private set; }
        public Dictionary<ProductEnum,decimal> ProductPrices { get; private set; }
        const string format = "0.00";
        public VendingMachine()
        {
            Coins = new List<Coin>();
            CoinReturn = new List<Coin>();
            Display = "INSERT COIN";

            CoinValues = new Dictionary<CoinPropertiesEnum, decimal>();
            CoinValues.Add(CoinPropertiesEnum.Nickel, (decimal) 0.05);
            CoinValues.Add(CoinPropertiesEnum.Dime, (decimal) 0.10);
            CoinValues.Add(CoinPropertiesEnum.Quarter, (decimal) 0.25);

            ProductPrices = new Dictionary<ProductEnum, decimal>();
            ProductPrices.Add(ProductEnum.Cola, (decimal) 1.00);
            ProductPrices.Add(ProductEnum.Chips, (decimal) 0.50);
            ProductPrices.Add(ProductEnum.Candy, (decimal) 0.65);

        }

        public void SelectProduct(ProductEnum product)
        {
            Display = "PRICE: $" + ProductPrices[product].ToString(format);
        }

        public void InsertCoin(Coin coin)
        {
            if (IsValid(coin))
            {
                Coins.Add(coin);
                var centsInVendingMaching = Coins.Sum(x => CoinValues[coin.CoinProperties]);
                Display = "$"+centsInVendingMaching.ToString(format);
            }
            else {
                CoinReturn.Add(coin);
            }
        }
        

        private bool IsValid(Coin coin)
        {
            return CoinValues.Keys.Contains(coin.CoinProperties);
        }
    }
}