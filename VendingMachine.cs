using System;
using System.Collections.Generic;

namespace VendingMachineKata
{
    public class VendingMachine
    {
        public VendingMachine()
        {
            Coins = new List<Coin>();
            Display = "INSERT COIN";
        }

        public List<Coin> Coins { get; internal set; }
        public string Display { get; internal set; }

        public void InsertCoin(Coin coin)
        {
            if (coin.IsValid) {
                Coins.Add(coin);
            }
        }
    }
}