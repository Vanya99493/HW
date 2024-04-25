using _7_10_Prefs.Scripts.Save_LoadModule;
using _7_10_Prefs.Scripts.UIModule;
using UnityEngine;

namespace _7_10_Prefs.Scripts.ProviderViews
{
    public class StreamingAssetsProviderView : MonoBehaviour
    {
        private const string FILE_NAME = "example.txt";

        [SerializeField] private DataDisplayer _dataDisplayer;

        private void OnEnable()
        {
            StreamingAssetsProvider streamingAssetsProvider = new StreamingAssetsProvider();
            string loadedData = streamingAssetsProvider.LoadText(FILE_NAME);
            _dataDisplayer.DisplayData(loadedData);
        }
    }
}