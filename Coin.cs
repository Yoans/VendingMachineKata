namespace VendingMachineKata
{
    public class Coin
    {
        public Coin()
        {
            IsValid = true;
        }

        public bool IsValid { get; internal set; }
    }
}