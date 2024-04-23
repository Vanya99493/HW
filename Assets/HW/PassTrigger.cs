using UnityEngine;
using UnityEngine.UI;

namespace HW
{
    public class PassTrigger : MonoBehaviour
    {
        [SerializeField] private Text _passTriggerText;

        private int _passTriggerCount = 0;

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag == "sphere")
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