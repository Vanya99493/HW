using UnityEngine;

namespace _12_Events.Scripts.UIModule
{
    public class UIController : MonoBehaviour
    {
        [SerializeField] private CoinDisplay _coinDisplay;

        public void UpdateCoinsNumber(int newCoinsNumber)
        {
            _coinDisplay.UpdateCoinDisplayTextField(newCoinsNumber);
        }
    }
}