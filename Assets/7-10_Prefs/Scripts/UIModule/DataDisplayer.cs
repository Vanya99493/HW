using TMPro;
using UnityEngine;

namespace _7_10_Prefs.Scripts.UIModule
{
    public class DataDisplayer : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _textField;

        public void DisplayData(string dataString)
        {
            _textField.text = dataString;
        }
    }
}