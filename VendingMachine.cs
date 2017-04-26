using System;
using System.Collections.Generic;

namespace VendingMachineKata
{
    public class VendingMachine
    {

        public List<Coin> CoinReturn { get; internal set; }
        public List<Coin> Coins { get; internal set; }
        public string Display { get; internal set; }

        public VendingMachine()
        {
            Coins = new List<Coin>();
            CoinReturn = new List<Coin>();
            Display = "INSERT COIN";
        }

        public void InsertCoin(Coin coin)
        {
            if (coin.IsValid)
            {
                Coins.Add(coin);
            }
            else {
                CoinReturn.Add(coin);
            }
        }
    }
}