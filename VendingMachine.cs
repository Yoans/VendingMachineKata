using System;
using System.Collections.Generic;

namespace VendingMachineKata
{
    public class VendingMachine
    {

        public List<Coin> CoinReturn { get; internal set; }
        public List<Coin> Coins { get; internal set; }
        public string Display { get; internal set; }
        public List<CoinPropertiesEnum> ValidCoinProperties { get; private set; }

        public VendingMachine()
        {
            Coins = new List<Coin>();
            CoinReturn = new List<Coin>();
            Display = "INSERT COIN";
            ValidCoinProperties = new List<CoinPropertiesEnum>()
            {
                CoinPropertiesEnum.Nickel,
                CoinPropertiesEnum.Dime,
                CoinPropertiesEnum.Quarter
            };
        }

        public void InsertCoin(Coin coin)
        {
            if (IsValid(coin))
            {
                Coins.Add(coin);
            }
            else {
                CoinReturn.Add(coin);
            }
        }

        private bool IsValid(Coin coin)
        {
            return ValidCoinProperties.Contains(coin.CoinProperties);
        }
    }
}