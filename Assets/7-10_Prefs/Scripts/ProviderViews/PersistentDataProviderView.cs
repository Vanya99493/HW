using _7_10_Prefs.Scripts.Save_LoadModule;
using _7_10_Prefs.Scripts.UIModule;
using UnityEngine;

namespace _7_10_Prefs.Scripts.ProviderViews
{
    public class PersistentDataProviderView : MonoBehaviour
    {
        private const string FILE_NAME = "example.txt";
        
        [SerializeField] private DataDisplayer _dataDisplayer;

        private PersistentDataProvider _persistentDataProvider;

        private void Awake()
        {
            _persistentDataProvider = new PersistentDataProvider();
            string textToSave = "text from persistent data folder";
            _persistentDataProvider.Save(FILE_NAME, textToSave);
        }

        private void OnEnable()
        {
            string loadedData = _persistentDataProvider.LoadText(FILE_NAME);
            _dataDisplayer.DisplayData(loadedData);
        }
    }
}