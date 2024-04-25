using UnityEngine;
using UnityEngine.UI;

namespace _4_Bouncy.Scripts
{
    public class PassTrigger : MonoBehaviour
    {
        private const string SPHERE_TAG = "sphere";
        
        [SerializeField] private Text _passTriggerText;

        private int _passTriggerCount = 0;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(SPHERE_TAG))
            {
                _passTriggerCount++;
                UpdatePassTriggerText();
            }
        }

        private void UpdatePassTriggerText()
        {
            _passTriggerText.text = $"Pass trigger count: {_passTriggerCount}";
        }
    }
}