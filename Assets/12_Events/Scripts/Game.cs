using _12_Events.Scripts.CoinHolderModule;
using _12_Events.Scripts.UIModule;
using UnityEngine;

namespace _12_Events.Scripts
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private UIController _uiController;
        
        private CoinHolder _coinHolder;

        private void Start()
        {
            _coinHolder = new CoinHolder(OnUpdateCoinsNumber);
        }

        public void OnAddCoins()
        {
            int newCoins = Random.Range(1, 4);
            Debug.Log($"Added new {newCoins} coins;");
            _coinHolder.AddCoins(newCoins);
        }

        private void OnUpdateCoinsNumber(int coinsNumber)
        {
            _uiController.UpdateCoinsNumber(coinsNumber);
        }
    }
}