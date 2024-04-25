using _12_Events.Scripts.Delegates;

namespace _12_Events.Scripts.CoinHolderModule
{
    public class CoinHolder
    {
        private event UpdateCoinEventHandler CoinUpdateEvent;
        
        public int Coins { get; private set; }

        public CoinHolder(UpdateCoinEventHandler onUpdateCoin, int startCoins = 0)
        {
            Coins = startCoins;
            CoinUpdateEvent += onUpdateCoin;
        }

        ~CoinHolder()
        {
            CoinUpdateEvent = null;
        }

        public void AddCoins(int coinsNumber)
        {
            Coins += coinsNumber;
            CoinUpdateEvent?.Invoke(Coins);
        }
    }
}