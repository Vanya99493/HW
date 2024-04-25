using _7_10_Prefs.Scripts.Save_LoadModule;
using _7_10_Prefs.Scripts.UIModule;
using UnityEngine;

namespace _7_10_Prefs.Scripts.ProviderViews
{
    public class ResourcesProviderView : MonoBehaviour
    {
        private const string FILE_NAME = "example";
        
        [SerializeField] private DataDisplayer _dataDisplayer;

        private void OnEnable()
        {
            ResourcesProvider resourcesProvider = new ResourcesProvider();
            string loadedData = resourcesProvider.LoadText(FILE_NAME);
            _dataDisplayer.DisplayData(loadedData);
        }
    }
}