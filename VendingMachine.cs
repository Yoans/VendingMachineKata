using System;
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

        public VendingMachine()
        {
            Coins = new List<Coin>();
            CoinReturn = new List<Coin>();
            Display = "INSERT COIN";
            CoinValues = new Dictionary<CoinPropertiesEnum, decimal>();
            CoinValues.Add(CoinPropertiesEnum.Nickel, (decimal) 0.05);
            CoinValues.Add(CoinPropertiesEnum.Dime, (decimal) 0.10);
            CoinValues.Add(CoinPropertiesEnum.Quarter, (decimal) 0.25);
            
        }

        public void InsertCoin(Coin coin)
        {
            if (IsValid(coin))
            {
                Coins.Add(coin);
                var centsInVendingMaching = Coins.Sum(x => CoinValues[coin.CoinProperties]);
                Display = "$"+centsInVendingMaching.ToString("0.00");
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