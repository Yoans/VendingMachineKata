using System;
using System.Collections.Generic;

namespace VendingMachineKata
{
    internal class VendingMachine
    {
        public VendingMachine()
        {
            Coins = new List<Coin>();
        }

        public List<Coin> Coins { get; internal set; }

        internal void InsertCoin(Coin coin)
        {
            Coins.Add(coin);
        }
    }
}