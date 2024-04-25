using UnityEngine;
using UnityEngine.UI;

namespace _4_Bouncy.Scripts
{
    public class DistanceCalculator : MonoBehaviour
    {
        [Header("Objects")]
        [SerializeField] private Transform _spherePoint;
        [SerializeField] private Transform _groundPoint;
        [Header("UI")] 
        [SerializeField] private Text _distanceText;

        private void Update()
        {
            float distance = Mathf.Abs(_spherePoint.transform.position.y - _groundPoint.transform.position.y);
            UpdateDistanceText(distance);
        }

        private void UpdateDistanceText(float distance)
        {
            _distanceText.text = $"Distance: {distance:F3}";
        }
    }
}