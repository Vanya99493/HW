using System.IO;
using UnityEngine;
using UnityEngine.UI;

namespace Prefs
{
    public class LoadPrefs : MonoBehaviour
    {
        [SerializeField] private Text _text;

        private void Start()
        {
            string filePath = $"{Application.streamingAssetsPath}/example.txt";

            if (File.Exists(filePath))
            {
                string fileContents = File.ReadAllText(filePath);
                _text.text = fileContents;
            }
            else
            {
                Debug.LogError("Wrong operation. \nFile path: " + filePath);
            }
        }
    }
}