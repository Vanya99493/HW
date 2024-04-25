using TMPro;
using UnityEngine;

namespace _12_Events.Scripts.UIModule
{
    public class CoinDisplay : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _coinDisplayTextField;

        private void OnEnable()
        {
            UpdateCoinDisplayTextField(0);
        }

        public void UpdateCoinDisplayTextField(int newCoinsNumber)
        {
            _coinDisplayTextField.text = $"Coins: {newCoinsNumber}";
        }
    }
}