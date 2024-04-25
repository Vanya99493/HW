using _7_10_Prefs.Scripts.Save_LoadModule;
using _7_10_Prefs.Scripts.UIModule;
using UnityEngine;

namespace _7_10_Prefs.Scripts.ProviderViews
{
    public class PlayerPrefsProviderView : MonoBehaviour
    {
        private const string KEY_NAME = "example-key";
        
        [SerializeField] private DataDisplayer _dataDisplayer;

        private PlayerPrefsProvider _playerPrefsProvider;

        private void Awake()
        {
            _playerPrefsProvider = new PlayerPrefsProvider();
            string textToSave = "text from player prefs";
            _playerPrefsProvider.Save(KEY_NAME, textToSave);
        }
        
        private void OnEnable()
        {
            string loadedData = _playerPrefsProvider.LoadText(KEY_NAME);
            _dataDisplayer.DisplayData(loadedData);
        }
    }
}